//#define TRACE_SCOPE
//#define TEXT_FRAME_PERFORMANCE_TRACE
//#define BINARY_FRAME_PERFORMANCE_TRACE
#define APHID_FRAME_ADD_DATA
#define APHID_FRAME_CATCH_POP
#define TRACK_PREVIOUS_SCOPE
//#define EXPRESSION_HISTORY

using System;
using System.Collections;
using System.Collections.Generic;
#if TRACE_SCOPE || TEXT_FRAME_PERFORMANCE_TRACE || BINARY_FRAME_PERFORMANCE_TRACE
using System.Diagnostics;
#endif
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

using Components.Aphid.Compiler;
using Components.Aphid.Debugging;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
#if TRACE_SCOPE || TEXT_FRAME_PERFORMANCE_TRACE || BINARY_FRAME_PERFORMANCE_TRACE
using Components.External;
#endif
using Components.External.ConsolePlus;

using static System.Convert;
using static System.String;
using static Components.Aphid.Lexer.AphidTokenType;
using static Components.Aphid.TypeSystem.AphidObject;
using static Components.Aphid.TypeSystem.TypeExtender;
using static Components.Aphid.TypeSystem.ValueHelper;

using Exp = Components.Aphid.Parser.AphidExpressionType;
using LinqExp = System.Linq.Expressions.Expression;

namespace Components.Aphid.Interpreter
{
    // Todo:
    // * Fix all methods that return object instead of AphidObject,
    //   then remove excessive Wrap/Unwrap and casting.
    // * Add support for token macros--transform during lexical analysis
    //   instead of parsing.
    // * Text mutators as well, akin to C macros
    // * Add preprocessor looping support
    //   - Spin up secondary interpreter during preprocessing to easily
    //     support state, complex filter/projection, etc.
    // * Add quote support for macros.
    // * Add optional 'using' validation controlled via directive.
    //   - Cache previously loaded asm names at start, subscribe to
    //     AppDomain events to refresh cache.
    // * Add throw support.
    // * Add void ret support.
    // * Expand aphid function capabilities.
    //   - Add in default values e.g. f = @(x = 10, y = 'test') { /* ... */ }
    //   - Add in named params: f(y: 'test2');
    //   - Add tuple support e.g. 'test', x @Console.WriteLine('Foo: {0} {1}')
    //   - Add decomposition e.g. x, y = f();
    //     * Support decomposition of tuples and anything that implements IEnumerable
    //   - Add support for param/return type and constraint declarations.
    //     * Explicit return type: @(string value, int count : string) { ... }
    //     * Mixed type (no type for value): @(value, int count : string) { ... }
    //     * Implicit void return type: @(string msg) { ... }
    //     * Constraint (if null return null): @(value -> null, int count) { ... }
    //     * Multi Constraint (if x return x else if y return y etc):
    //          repeat = @(value -> null | '', int count) { ... }
    //     * Pattern Constraint:
    //          indexOf = @(value :== '' -> -1) { ... }
    //     * Mixed Constraint:
    //          indexOf = @(value -> null :== '' -> -1) { ... }
    //   - Add auto param attribute -- if argument is not explicitly passed, resolves
    //     by parameter name and passes value e.g.
    //     var foo = 'test'; var f = @(auto foo) foo @print('Message: {0}');
    // * Add lazy keyword.
    //   - Expression support: x = lazy f()
    //   - Param support: foo = @(lazy arg0) { ... }
    //   - Op param support:
    //      @ ?> = @(lazy lhs, lazy rhs) { ... }
    // * Implicit var support e.g.
    //   isTypeEnumerableOf = @(enumerableType, type)
    //       (var type.GetInterface('IEnumerable`1')) != null &&
    //       $&.GetGenericArguments()[0] == enumerableType;
    // * Support Aphid implemented operator override for types, via class decl and 
    //   extend
    // * Seamless implicit/explicit operator interop
    // * AphidShell script monitors build, kills and optionally restarts processes 
    //   that hold blocking file locks.
    // * Add update-safe loader that moves Aphid to a unique folder immediately
    //   following build/deploy and forward execution.
    //   - Forward via aphid.exe stub built using IL header
    //     * Add inline assembly support (stretch)
    //   - Use CrossProcessLock to sync bootstrap execution/overwrite.
    // * Add yield return/break support, possibly infer based on lazy attribute
    // * Add contextual semantics for | --binary OR for numbers, pipe for callables.
    // * Create standalone debugger.
    //   - Build both command-line and graphical interfaces.
    //   - Add ability to open Aphid-specific crash dumps.
    //   - Add execution rewind.
    //   - Add replay of trace dumps.
    //   - Support editing of code in memory.
    //   - Act as JIT debugger when Aphid scripts crash.
    // * Add execution tracing with multiple levels.
    //   - Levels by granularity, descending: script, func, block, stmt, and expr.
    // * Create object database system (AphidDB).
    //   - Compile high performance serializers (must support several TB databases).
    //   - Persist Aphid bytecode and metadata for use as indexes.
    //   - Pull pieces from AphidUI for use as generic database management UI.
    //   - Memoize query bytecode and results for hot paths.
    // * Add enum support.
    // * Add struct support.
    //   - Support first-class unions with FieldOffsetAttribute.
    //   - Add first-class pointer support.
    // * Generate new bitwise operator implementations based on
    //   public AphidObject BinaryAnd(AphidObject x, AphidObject y)
    // * Look into generating interpreter thunks that handle interpreter
    //   construction and forwarding when public interpret methods are called
    //   from non-owner threads.
    // * Add using keyword support for IDisposable.
    // * Add scope keyword support for automatic disposal immediately upon leaving
    //   leaving scope via ascend (not descend) or by breaking scope chain entirely.
    // * Consider pure console IDE.
    //   -Draw inspiration from edit.com
    // * Add fan-out support for C# generation e.g.
    //   AphidCli.*()->AphidCli.Try*()
    //   AphidCli.*()->$_.Try*
    // * Support [] attributes by matching identifier after array decl/access
    //   to support multiple attrs declared with any expression
    // * Add jmp/goto support
    // * Replace foreach, Select, etc. with for.
    [Serializable]
    public partial class AphidInterpreter
    {
        #region Constants

        private const bool _createLoaderDefault = true;

        #endregion

        #region Static Readonly Fields
        //[ThreadStatic]        

        private static readonly Dictionary<Type, Dictionary<string, MemberInfo[]>>
            _instanceMemberNameCache = new Dictionary<Type, Dictionary<string, MemberInfo[]>>(),
            _staticMemberNameCache = new Dictionary<Type, Dictionary<string, MemberInfo[]>>();

        private static readonly FieldInfo _frameArray = typeof(Stack<AphidFrame>)
            .GetField("_array", BindingFlags.Instance | BindingFlags.NonPublic);

        #endregion

        #region Instance Readonly Fields

        private readonly Lazy<Func<AphidFrame[]>> _lazyGetFrameArray;

        private readonly Stack<AphidFrame> _frames;

        private readonly ReaderWriterLockSlim _importsLock = new ReaderWriterLockSlim();

        #endregion

        #region Instance Fields

        private bool _isReturning, _isContinuing, _isBreaking, _isInTryCatchFinally;

        private int _queuedFramePops;

        private IEnumerable<AphidExpression> _insertNextBuffer;

#if APHID_DEBUGGING_ENABLED
        private List<AphidExpression> _currentBlock;

        private ManualResetEvent _breakpointReset;

        private bool _isSingleStepping;

        private AutoResetEvent _singleStepReset;

#if EXPRESSION_HISTORY
        private ExpressionHistoryRecord[] _expressionHistory = new ExpressionHistoryRecord[0x1000];

        private int _expressionHistoryIndex = 0;

        private bool _isSteppingBack;
#endif
#endif

#if TRACE_SCOPE
        private AphidTrace _scopeTrace;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
        private AphidTrace _framePerformanceTrace;

        private Stack<Tuple<string, Stopwatch>> _frameStopwatchStack = new Stack<Tuple<string, Stopwatch>>();
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
        private FrameProfileBinaryWriter _framePerformanceBinaryWriter;
#endif

        private AphidObject _localScope, _currentScope;

#if TRACK_PREVIOUS_SCOPE
        private AphidObject _previousScope;
#endif

        #endregion

        #region Instance Properties

        public AphidObject InitialScope { get; private set; }

        public AphidObject CurrentScope
        {
            get => _currentScope;
            private set
            {
#if TRACE_SCOPE
                if (_scopeTrace != null)
                {
                    _scopeTrace.Trace("Set scope begin");
                }
#endif
#if TRACK_PREVIOUS_SCOPE
                _previousScope = CurrentScope;
#endif

#pragma warning disable IDE0027 // Use expression body for accessors
                _currentScope = value;
#pragma warning restore IDE0027 // Use expression body for accessors
#if TRACE_SCOPE
                if (_scopeTrace != null)
                {
                    _scopeTrace.Trace("Set scope end");
                }
#endif
            }
        }

#if TRACK_PREVIOUS_SCOPE
        public AphidObject PreviousScope => _previousScope;
#endif

#if APHID_DEBUGGING_ENABLED
        public Dictionary<string, int[]> FileBreakpointIndexMap { get; private set; }

        public string CurrentFileContext { get; private set; }

        public Action<AphidExpression> HandleExecutionBreak { get; set; }
#endif

        public int OwnerThread { get; private set; }

        public AphidAssemblyBuilder AsmBuilder { get; }

        public InteropMethodResolver InteropMethodResolver { get; }

        public OperatorHelper OperatorHelper { get; }

        public ValueHelper ValueHelper { get; }

        public InteropTypeResolver InteropTypeResolver { get; }

        public TypeExtender TypeExtender { get; }

        public AphidTypeConverter TypeConverter { get; }

        public AphidFunctionConverter FunctionConverter { get; }

        public AphidIpcContext IpcContext { get; private set; }

        public AphidSerializer Serializer { get; set; }

        public TextWriter Out { get; set; }

        public Func<string, string> OutFilter { get; set; }

        public Func<string, string> GatorEmitFilter { get; set; }

        public AphidLoader Loader { get; private set; }

        public AphidExpression CurrentStatement { get; private set; }

        public AphidExpression CurrentExpression { get; private set; }

        public bool StrictMode { get; set; }

        public Func<AphidFrame[]> GetFrameArray => _lazyGetFrameArray.Value;

        #endregion

        #region Constructors

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter()
            : this(Scope(), createLoader: _createLoaderDefault, loader: null, frames: null)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(bool createLoader)
            : this(Scope(), createLoader, loader: null, frames: null)
        {
            // Optimize by generating all built-in
            // variables here without having to perform
            // key existence checks.
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidObject currentScope)
            : this(currentScope, createLoader: _createLoaderDefault, loader: null, frames: null)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidObject currentScope, bool createLoader)
            : this(currentScope, createLoader, loader: null, frames: null)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidLoader loader)
            : this(Scope(), createLoader: false, loader: loader, null)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidObject currentScope, AphidLoader loader)
            : this(currentScope, createLoader: false, loader: loader, frames: null)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidObject currentScope, Stack<AphidFrame> frames)
            : this(currentScope, createLoader: _createLoaderDefault, loader: null, frames: frames)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter(AphidObject currentScope, bool createLoader, Stack<AphidFrame> frames)
            : this(currentScope, createLoader: createLoader, loader: null, frames: frames)
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidInterpreter(
            AphidObject currentScope,
            bool createLoader,
            AphidLoader loader,
            Stack<AphidFrame> frames)
        {
            AphidErrorReporter.Init();
            StrictMode = AphidConfig.Current.StrictMode;

            if (createLoader)
            {
                Loader = new AphidLoader(this);
            }
            else
            {
                Loader = loader;
            }

            InitialScope = CurrentScope = currentScope ?? Scope();

            OwnerThread = -1;
#if TRACE_SCOPE
            _scopeTrace = new AphidTrace(
                "Scope Trace",
                PathHelper.GetExecutingPath(
                    Format("AphidScope.{0}.log", Guid.NewGuid())),
                this)
                {
                    Settings = new AphidTraceSettings
                    {
                        TraceTimestamp = true,
                        DefaultMessageTraceLevel = TraceLevel.Info,
                        TimestampFormat = AphidTraceSettings.DefaultTimestampFormat,
                        TraceAphidStack = false,
                        TraceCurrentExpression = false,
                        TraceCurrentStatement = false,
                        TraceClrStack = true,
                    },
                };

            _scopeTrace.Open();
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            var framePerfGuid = Guid.NewGuid();

            var frameStart = Format(
                "Tracing frame performance beginning at:\r\n{0}\r\n\r\n",
                new StackTrace().ToString());
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace = new AphidTrace(
                "Frame performance Trace",
                PathHelper.GetExecutingPath(
                    Format("AphidFramePerformance.{0}.log", framePerfGuid)),
                this)
                 {
                    Settings = new AphidTraceSettings
                    {
                        TraceTimestamp = false,
                        DefaultMessageTraceLevel = TraceLevel.Info,
                        TimestampFormat = AphidTraceSettings.DefaultTimestampFormat,
                        TraceAphidStack = false,
                        TraceCurrentExpression = false,
                        TraceCurrentStatement = false,
                        TraceClrStack = false,
                    },
                };

            _framePerformanceTrace.Open();
            _framePerformanceTrace.TraceText(frameStart);
            _framePerformanceTrace.Flush();
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            if (frames == null)
            {
                _framePerformanceBinaryWriter = new FrameProfileBinaryWriter(Guid.NewGuid());
                _framePerformanceBinaryWriter.WriteStart();
            }
#endif

#if APHID_DEBUGGING_ENABLED
            FileBreakpointIndexMap = new Dictionary<string, int[]>(
                StringComparer.OrdinalIgnoreCase);
#endif

            Out = Console.Out;
            AsmBuilder = new AphidAssemblyBuilder(this, _importsLock);

            InteropMethodResolver = new InteropMethodResolver(
                this,
                InterpretMemberInteropExpression,
                _importsLock);

            OperatorHelper = new OperatorHelper(this);
            ValueHelper = new ValueHelper(this);
            TypeExtender = new TypeExtender(this, _importsLock);
            InteropTypeResolver = new InteropTypeResolver(this);
            TypeConverter = new AphidTypeConverter(this);
            FunctionConverter = new AphidFunctionConverter(this);

            Serializer = new AphidSerializer(this)
            {
                IgnoreSpecialVariables = false,
                IgnoreFunctions = true,
                QuoteToStringResults = true
            };

            _frames = frames ?? new Stack<AphidFrame>(new[] { CreateEntryFrame() });

            _lazyGetFrameArray = new Lazy<Func<AphidFrame[]>>(() =>
                LinqExp
                    .Lambda<Func<AphidFrame[]>>(
                        LinqExp.Field(LinqExp.Constant(_frames, typeof(Stack<AphidFrame>)), _frameArray))
                    .Compile());

            if (!CurrentScope.ContainsKey(AphidName.Scope))
            {
                CurrentScope.Add(AphidName.Scope, CurrentScope);
            }

            if (!CurrentScope.ContainsKey(AphidName.Parent))
            {
                CurrentScope.Add(AphidName.Parent, CurrentScope.Parent);
            }

            if (!CurrentScope.ContainsKey(AphidName.FramesKey))
            {
                CurrentScope.Add(AphidName.FramesKey, Scalar(_frames));
            }

            if (!CurrentScope.ContainsKey(AphidName.AsmBuilder))
            {
                CurrentScope.Add(AphidName.AsmBuilder, Scalar(AsmBuilder));
            }

            if (!CurrentScope.ContainsKey(AphidName.Interpreter))
            {
                CurrentScope.Add(AphidName.Interpreter, Scalar(this));
            }

            InitialScope = CurrentScope;
        }

        #endregion

        #region Interpreter State Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HashSet<string> GetImports()
        {
            if (CurrentScope.TryResolve(AphidName.Imports, out var imports))
            {
                return (HashSet<string>)imports.Value;
            }

            var list = new HashSet<string>(AphidConfig.Current.Imports);
            CurrentScope.Add(AphidName.Imports, Scalar(list));

            return list;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddImport(string name)
        {
            _importsLock.EnterWriteLock();

            try
            {
                var imports = GetImports();

                if (!imports.Contains(name))
                {
                    imports.Add(name);
                }
            }
            finally
            {
                _importsLock.ExitWriteLock();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject GetReturnValue() => GetReturnValue(false);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject GetReturnValue(bool remove)
        {
            if (CurrentScope.TryGetValue(AphidName.Return, out var retVal) && remove)
            {
                CurrentScope.Remove(AphidName.Return);
            }

            return retVal;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetReturnValue(AphidObject obj) => CurrentScope.Add(AphidName.Return, obj);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetScriptFilename(string filename)
        {
            var obj = Scalar(filename);

            if (!CurrentScope.ContainsKey(AphidName.Script))
            {
                CurrentScope.Add(AphidName.Script, obj);
            }
            else
            {
                CurrentScope.Remove(AphidName.Script);
                CurrentScope.Add(AphidName.Script, obj);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetScriptFilename()
        {
            if (CurrentScope != null)
            {
                return CurrentScope.TryResolve(AphidName.Script, out var scriptObj) ?
                    scriptObj?.GetString() :
                    null;
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool SetIsInTryCatchFinally(bool value)
        {
            var old = _isInTryCatchFinally;
            _isInTryCatchFinally = value;

            return old;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetState()
        {
            CurrentScope = InitialScope;

            // Todo: Add test cases to cover try/catch influence
            CurrentExpression = null;
            CurrentStatement = null;
            _isReturning = false;
            _isContinuing = false;
            _isBreaking = false;
            _isInTryCatchFinally = false;
            _frames.Clear();
            _frames.Push(CreateEntryFrame());
            _queuedFramePops = 0;

            if (CurrentScope.ContainsKey(AphidName.Return))
            {
                CurrentScope.Remove(AphidName.Return);
            }

            //if (CurrentScope.ContainsKey(AphidName.Block))
            //{
            //    CurrentScope.Remove(AphidName.Block);
            //}

            //if (CurrentScope.ContainsKey(AphidName.Script))
            //{
            //    CurrentScope.Remove(AphidName.Script);
            //}

#if APHID_SET_CODE_VAR
            if (CurrentScope.ContainsKey(AphidName.Code))
            {
                CurrentScope.Remove(AphidName.Code);
            }
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertNext(IEnumerable<AphidExpression> block)
        {
            if (_insertNextBuffer != null)
            {
                CreateRuntimeException("Cannot insert block, buffer already set.");
            }

            _insertNextBuffer = block;
        }

#if APHID_SET_CODE_VAR
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAstCode(List<AphidExpression> ast)
        {
            if (CurrentScope.ContainsKey(AphidName.Code))
            {
                CurrentScope.Remove(AphidName.Code);
            }

            var node = ast.FirstOrDefault(x => x.Code != null);
            CurrentScope.Add(AphidName.Code, Scalar(node != null ? node.Code : null));
        }
#endif

        #endregion

        #region Scope Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetInitialScope(AphidObject scope) =>
            CurrentScope = InitialScope = scope;

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnterScope()
        {
#if TRACE_SCOPE
            _scopeTrace.Trace("Enter scope begin");
#endif

            CurrentScope = Scope(CurrentScope);
            CurrentScope.Add(AphidName.Scope, CurrentScope);
            CurrentScope.Add(AphidName.Parent, CurrentScope.Parent);

#if TRACE_SCOPE
            _scopeTrace.Trace("Enter scope end");
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool LeaveScope(bool bubbleReturnValue = false)
        {
#if TRACE_SCOPE
            _scopeTrace.Trace("Leave scope begin");
#endif

            if (CurrentScope.Parent == null)
            {
#if TRACE_SCOPE
                _scopeTrace.Trace("Internal error leaving scope, parent scope is null.");
#endif

                throw CreateInternalException(
                    "Internal error leaving scope, parent scope is null.");
            }

            if (bubbleReturnValue)
            {
                var ret = GetReturnValue(true);
                CurrentScope = CurrentScope.Parent;

                if (ret != null)
                {
                    SetReturnValue(ret);

#if TRACE_SCOPE
                    _scopeTrace.Trace("Leave scope end");
#endif

                    return true;
                }
            }
            else
            {
                CurrentScope = CurrentScope.Parent;
            }

#if TRACE_SCOPE
            _scopeTrace.Trace("Leave scope end");
#endif

            return false;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnterSharedScope(AphidObject sharedScope) =>
            EnterSharedScope(sharedScope, createChild: true);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnterSharedScope(AphidObject sharedScope, bool createChild)
        {
            if (_localScope != null)
            {
                throw CreateRuntimeException(
                    "Already in shared scope, cannot enter another.");
            }

            _localScope = CurrentScope;

            CurrentScope = !createChild ?
                sharedScope :
                Scope(sharedScope);

            PushFrame("[Shared Scope]");
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void LeaveSharedScope()
        {
            PopFrame();

            if (_localScope == null)
            {
                throw CreateRuntimeException(
                    "Leave shared scope failed, not in shared scope.");
            }

            CurrentScope = _localScope;
            _localScope = null;
        }

        #endregion

        #region IO Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteOut(string text)
        {
            if (Out != null)
            {
                if (OutFilter != null)
                {
                    text = OutFilter(text);
                }

                Out.Write(text);
            }
        }

        #endregion

        #region CLR Interop Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private MemberInfo[] GetInteropInstanceMembers(object target, BinaryOperatorExpression expression) =>
            GetTypeInteropInstanceMembers(target.GetType(), GetMemberKey(expression.RightOperand));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetInteropInstanceMembers(object target, string name) =>
            GetTypeInteropInstanceMembers(target.GetType(), name);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetTypeInteropInstanceMembers(Type targetType, string name)
        {
            lock (_instanceMemberNameCache)
            {
                MemberInfo[] members;
                if (!_instanceMemberNameCache.TryGetValue(targetType, out var nameMembers))
                {
                    members = GetTypeInteropInstanceMembersCore(targetType, name);

                    _instanceMemberNameCache.Add(
                        targetType,
                        new Dictionary<string, MemberInfo[]> { { name, members } });
                }
                else if (!nameMembers.TryGetValue(name, out members))
                {
                    members = GetTypeInteropInstanceMembersCore(targetType, name);
                    nameMembers.Add(name, members);
                }

                return members;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetTypeInteropInstanceMembersCore(Type targetType, string name)
        {
            var allMembers = targetType.GetMembers(
                BindingFlags.FlattenHierarchy |
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.Static);

            var members = new MemberInfo[allMembers.Length];
            var count = 0;

            for (var i = 0; i < allMembers.Length; i++)
            {
                var am = allMembers[i];

                if (am.Name == name)
                {
                    members[count++] = am;
                }
            }

            if (count != members.Length)
            {
                Array.Resize(ref members, count);
            }

            return members;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetInteropStaticMembers(Type type, string[] path) =>
            GetInteropStaticMembers(type, path[path.Length - 1]);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetInteropStaticMembers(Type targetType, string name)
        {
            lock (_staticMemberNameCache)
            {
                MemberInfo[] members;
                if (!_staticMemberNameCache.TryGetValue(targetType, out var nameMembers))
                {
                    members = GetInteropStaticMembersCore(targetType, name);

                    _staticMemberNameCache.Add(
                        targetType,
                        new Dictionary<string, MemberInfo[]> { { name, members } });
                }
                else if (!nameMembers.TryGetValue(name, out members))
                {
                    members = GetInteropStaticMembersCore(targetType, name);
                    nameMembers.Add(name, members);
                }

                return members;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static MemberInfo[] GetInteropStaticMembersCore(Type targetType, string name)
        {
            var allMembers = targetType.GetMembers(
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.FlattenHierarchy);

            var members = new MemberInfo[allMembers.Length];
            var count = 0;

            for (var i = 0; i < allMembers.Length; i++)
            {
                var am = allMembers[i];

                if (am.Name == name)
                {
                    members[count++] = am;
                }
            }

            if (count != members.Length)
            {
                Array.Resize(ref members, count);
            }

            return members;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool HandleInteropReference(AphidInteropReference interopRef, AphidObject value)
        {
            if (interopRef == null)
            {
                return false;
            }

            var v = value.Value;

            if (interopRef.Field != null)
            {
                interopRef.Field.SetValue(
                    interopRef.Object,
                    TypeConverter.Convert(interopRef.Field.FieldType, v, null));
            }
            else
            {
                interopRef.Property.SetValue(
                    interopRef.Object,
                    v != null ?
                        TypeConverter.Convert(interopRef.Property.PropertyType, v, null) :
                        null);
            }

            if (Unwrap(value) is AphidFunction func)
            {
                if (interopRef.Object is AphidObject ao)
                {
                    func.ParentScope = ao;
                }
                else
                {
                    func.ParentScope = CurrentScope;
                }
            }

            return true;
        }

        #endregion

        #region Function Call Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(string name, params object[] parms)
        {
            var idExp = new IdentifierExpression(name);
            PushFrame(idExp, name, parms);

            try
            {
                return CallFunction(InterpretIdentifierExpression(idExp), parms);
            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
            catch (Exception e)
#else
            catch
#endif
            {
                if (e.Source != AphidName.DebugInterpreter)
                {
                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                    while (_queuedFramePops > 0)
                    {
                        _frames.Pop();
                        _queuedFramePops--;
                    }
#endif

#if APHID_FRAME_ADD_DATA
                    e.Data.Add(AphidName.Interpreter, this);
                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                }

                throw;
            }
#endif
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(AphidFunction function, params object[] parms) =>
            CallFunctionWithScope(function, null, parms);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunctionWithScope(AphidFunction function, AphidObject scope, params object[] parms)
        {
            var parmsWrapped = parms.Select(Wrap).ToArray();

            //PushFrame(CurrentExpression, CurrentExpression, parms);

            //try
            //{
            if (Thread.CurrentThread.ManagedThreadId == OwnerThread)
            {
                return CallFunctionCore(function, scope, parmsWrapped);
            }

            if (AphidErrorReporter.IsEnabled)
            {
                try
                {
                    return AphidThread.CreateChild(this).CallFunctionCore(function, scope, parmsWrapped);
                }
                catch (Exception e)
                {
                    AphidErrorReporter.Report(e, passThrough: true);

                    return null;
                }
            }
            else
            {
                return AphidThread.CreateChild(this).CallFunctionCore(function, scope, parmsWrapped);
                //Todo: proper error handling
                //if (AphidErrorHandling.HandleErrors)
                //{
                //    try
                //    {
                //        return AphidThread.CreateChild(this).CallFunctionCore(function, scope, parmsWrapped);
                //    }
                //    catch (Exception e)
                //    {
                //        AphidCli.DumpException(
                //    }
                //}
            }

            //}
            //finally
            //{
            //    PopFrame();
            //}
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallFunctionCore(AphidFunction function, AphidObject[] parms) =>
            CallFunctionCore(function, null, parms);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallFunctionCore(AphidFunction function, AphidObject scope, AphidObject[] parms)
        {
            bool isExtension, isStaticExtension;
            AphidObject extensionArg;
            var functionScope = Scope(function.ParentScope);
            functionScope.Add(AphidName.Interpreter, Scalar(this));

            if (function.ParentScope != null)
            {
                functionScope.Add(AphidName.Parent, function.ParentScope);
                functionScope.Add(AphidName.Scope, functionScope);

                if (function.ParentScope.TryGetValue(AphidName.Extension, out var isExtensionObject) &&
                    (bool)isExtensionObject.Value)
                {
                    isExtension = true;
                    isStaticExtension = function.ParentScope.ResolveBool(AphidName.StaticExtension);
                    function.ParentScope.TryGetValue(AphidName.ImplicitArg, out extensionArg);
                }
                else
                {
                    isExtension = isStaticExtension = false;
                    extensionArg = null;
                }
            }
            else
            {
                isExtension = isStaticExtension = false;
                extensionArg = null;
            }

            for (var i = 0; i < parms.Length; i++)
            {
                var arg = parms[i];

                if (i == 0 && (!isExtension || isStaticExtension))
                {
                    SetImplicitArg(functionScope, arg);
                }

                if (function.Args.Length == i)
                {
                    break;
                }

                functionScope.Add(function.Args[i], arg);
            }

            var argList = parms.ToList();

            if (isExtension && !isStaticExtension)
            {
                argList.Insert(0, extensionArg);
                functionScope[AphidName.ImplicitArg] = extensionArg;
            }

            functionScope[AphidName.ImplicitArgs] = Scalar(argList);

            if (scope != null)
            {
                functionScope.CopyTo(scope);
                scope.Parent = functionScope.Parent;
                functionScope = scope;
            }

            var parent = CurrentScope;
            CurrentScope = functionScope;

            try
            {
                Interpret(function.Body);

                return GetReturnValue(true);
            }
            finally
            {
                CurrentScope = parent;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetImplicitArg(AphidObject arg) => SetImplicitArg(CurrentScope, arg);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void SetImplicitArg(AphidObject scope, AphidObject arg) =>
            scope[AphidName.ImplicitArg] = arg;

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallInteropFunction(AphidInteropFunction func, params AphidObject[] objArgs)
        {
            object[] args = objArgs;

            if (func.UnwrapParameters)
            {
                for (var i = 0; i < objArgs.Length; i++)
                {
                    args[i] = objArgs[i].Value;
                }
            }

            return Wrap(func.Invoke(this, args));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(AphidObject function, params object[] args)
        {
            switch (function.Value)
            {
                case AphidFunction func:
                    return CallFunction(func, args);
                case AphidInteropFunction func2:
                    return CallInteropFunction(func2, (AphidObject[])args);
                default:
                    throw CreateRuntimeException("Object is not function: {0}", function);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallInteropFunction(
            AphidExpression callExpression,
            AphidInteropMethodInfo methodInfo,
            AphidInteropMember interopMembers)
        {
            MethodBase method;

            if (!methodInfo.Method.IsGenericMethod)
            {
                method = methodInfo.Method;
            }
            else
            {
                method = ((MethodInfo)methodInfo.Method).MakeGenericMethod(methodInfo.GenericArguments);
            }

            var convertedArgs = TypeConverter.Convert(
                methodInfo.Arguments,
                methodInfo.GenericArguments);

            PushFrame(
                callExpression,
                new Lazy<string>(() =>
                    Format(
                        "{0}.{1}",
                        AphidType.TypeToString(method.DeclaringType),
                        method.Name)),
                convertedArgs);

            try
            {
                return Wrap(
                    method.Invoke(
                        interopMembers.Target,
                        convertedArgs));
            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
            catch (Exception e)
#else
           catch
#endif
            {
                if (e.Source != AphidName.DebugInterpreter)
                {
                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                    while (_queuedFramePops > 0)
                    {
                        _frames.Pop();
                        _queuedFramePops--;
                    }
#endif

#if APHID_FRAME_ADD_DATA
                    e.Data.Add(AphidName.Interpreter, this);
                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                }

                throw;
            }
#endif
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallStaticInteropFunction(CallExpression callExpression)
        {
            var path = FlattenPath(callExpression.FunctionExpression);
            var type = InteropTypeResolver.ResolveType(GetImports(), _importsLock, path);
            var methodName = path.Last();

            var args = new object[callExpression.Args.Count];

            for (var i = 0; i < args.Length; i++)
            {
                args[i] = InterpretExpression(callExpression.Args[i]).Value;
            }

            var methodInfo = InteropMethodResolver.Resolve(type, methodName, args);
            MethodBase method;

            if (methodInfo.GenericArguments.Length == 0)
            {
                method = methodInfo.Method;
            }
            else
            {
                var m = (MethodInfo)methodInfo.Method;
                Type[] generics;

                if (methodInfo.GenericArguments.Length != (generics = m.GetGenericArguments()).Length)
                {
                    throw CreateRuntimeException(
                        "Generic type parameter mismatch between {0} and {1}.",
                        methodInfo.Method.ToString(),
                        m.ToString());
                }

                method = m.MakeGenericMethod(generics);
            }

            return Wrap(
                method.Invoke(null,
                    TypeConverter.Convert(
                        methodInfo.Arguments,
                        methodInfo.GenericArguments)));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetInteropAttribute(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case Exp.IdentifierExpression:
                    var attrs = ((IdentifierExpression)expression).Attributes;

                    if (attrs.Count == 1)
                    {
                        return attrs[0].Identifier;
                    }

                    return null;

                case Exp.BinaryOperatorExpression:
                    return GetInteropAttribute(((BinaryOperatorExpression)expression).LeftOperand);

                case Exp.CallExpression:
                    return GetInteropAttribute(((CallExpression)expression).FunctionExpression);

                default:
                    return null;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static AphidObject CreateUnsafeArgument(AphidExpression argExp)
        {
            var arg = Complex();
            arg.Add("UnsafeArgument", Wrap(argExp));

            return arg;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object[] CreateSafeArgs(List<AphidExpression> argExpressions)
        {
            var args = new object[argExpressions.Count];

            for (var i = 0; i < argExpressions.Count; i++)
            {
                try
                {
                    switch (argExpressions[i])
                    {
                        case IdentifierExpression exp:
                            args[i] = InterpretIdentifierExpression(exp);
                            break;

                        case BinaryOperatorExpression exp:
                            args[i] = InterpretMemberExpression(exp, false);
                            break;

                        case NumberExpression exp:
                            args[i] = InterpretNumberExpression(exp);
                            break;

                        case StringExpression exp:
                            args[i] = InterpretStringExpression(exp);
                            break;

                        default:
                            //args[i] = CreateUnsafeArgument(argExpressions[i]);
                            args[i] = argExpressions[i];
                            break;
                    }
                }
                catch (Exception e)
                {
                    var a = CreateUnsafeArgument(argExpressions[i]);
                    a.Add("ArgumentException", Scalar(e));
                    args[i] = a;
                }
            }

            return args;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallCustomOperatorFunction(
            AphidExpression customOperatorExpression,
            AphidTokenType op,
            string name,
            object[] args)
        {
            var funcName = GetCustomOperatorFunction(op, name);
            var funcExp = CurrentScope.Resolve(this, GetCustomOperatorExpressionKey(op));
            PushFrame(customOperatorExpression, (AphidExpression)funcExp.Value, args);

            try
            {
                return CallFunction(funcName, args);
            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
            catch (Exception e)
#else
            catch
#endif
            {
                if (e.Source != AphidName.DebugInterpreter)
                {
                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                    while (_queuedFramePops > 0)
                    {
                        _frames.Pop();
                        _queuedFramePops--;
                    }
#endif

#if APHID_FRAME_ADD_DATA
                    e.Data.Add(AphidName.Interpreter, this);
                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                }

                throw;
            }
#endif
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidFunction GetCustomOperatorFunction(AphidTokenType op, string name)
        {
            if (!CurrentScope.TryResolve(GetCustomOperatorKey(op), out var obj))
            {
                throw CreateRuntimeException("Custom operator '{0}' not defined.", op);
            }

            var func = obj.GetFunction();

            if (func == null)
            {
                throw CreateRuntimeException(
                    "Custom operator '{0}' should be function, was '{1}'.",
                    op,
                    obj.GetValueType());
            }

            return func;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetCustomOperatorKey(AphidTokenType op) =>
            $"$customOperator.{op.ToString()}.body";

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetCustomOperatorExpressionKey(AphidTokenType op) =>
            $"$customOperator.{op.ToString()}.expression";

        #endregion

        #region Frame Management Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(string name) => PushFrame(CreateNameFrame(name));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(
            AphidExpression callExpression,
            AphidExpression functionExpression,
            IEnumerable<object> args)
        {
            var name = new Lazy<string>(() =>
            {
                switch (functionExpression.Type)
                {
                    case Exp.IdentifierExpression:
                        return ((IdentifierExpression)functionExpression).Identifier;

                    case Exp.BinaryOperatorExpression:
                        var operands = Flatten(functionExpression);

                        return operands.All(x => x.Type == Exp.IdentifierExpression) ?
                            FlattenAndJoinPath(functionExpression) :
                            functionExpression.ToString();

                    default:
                        return functionExpression.ToString();
                }
            });

            PushFrame(callExpression, name, args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(
            AphidExpression callExpression,
            AphidExpression functionExpression,
            object arg)
        {
            var name = new Lazy<string>(() =>
            {
                switch (functionExpression.Type)
                {
                    case Exp.IdentifierExpression:
                        return ((IdentifierExpression)functionExpression).Identifier;

                    case Exp.BinaryOperatorExpression:
                        var operands = Flatten(functionExpression);

                        return operands.All(x => x.Type == Exp.IdentifierExpression) ?
                            FlattenAndJoinPath(functionExpression) :
                            functionExpression.ToString();

                    default:
                        return functionExpression.ToString();
                }
            });

            PushFrame(callExpression, name, arg);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(
            AphidExpression callExpression,
            Lazy<string> name,
            IEnumerable<object> args)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            _frames.Push(new AphidFrame(this, CurrentScope, callExpression, name, args));

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, name.Value);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.WriteEnter(name.Value);
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(name.Value, sw));
            sw.Start();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(AphidExpression callExpression, Lazy<string> name, object arg)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            _frames.Push(new AphidFrame(this, CurrentScope, callExpression, name, arg));

#if TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, name.Value);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.WriteEnter(name.Value);
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(name.Value, sw));
            sw.Start();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(
            AphidExpression callExpression,
            string name,
            IEnumerable<object> args)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            _frames.Push(new AphidFrame(this, CurrentScope, callExpression, name, args));

#if TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, name);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.WriteEnter(name);
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(name, sw));
            sw.Start();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(in AphidFrame frame)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            _frames.Push(frame);
            //frame.Name.ToString();

#if TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, frame.Name);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.WriteEnter(frame.Name);
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(frame.Name, sw));
            sw.Start();
#endif
        }

#if BINARY_FRAME_PERFORMANCE_TRACE
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrameSilent(in AphidFrame frame)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            _frames.Push(frame);
        }
#endif

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopFrame()
        {
#if TEXT_FRAME_PERFORMANCE_TRACE
            var tup = _frameStopwatchStack.Pop();
            tup.Item2.Stop();
            var id = Thread.CurrentThread.ManagedThreadId;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace.TraceText(
                "{0:x8} < {1} - {2:n0} ticks / {3:n0}ms\r\n",
                id,
                tup.Item1,
                tup.Item2.ElapsedTicks,
                tup.Item2.ElapsedMilliseconds);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            _framePerformanceBinaryWriter.WriteLeave();
#endif
            if (!_isInTryCatchFinally)
            {
                while (_queuedFramePops > 0)
                {
                    _frames.Pop();
                    _queuedFramePops--;
                }

                _frames.Pop();
            }
            else
            {
                _queuedFramePops++;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopQueuedFrames()
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopQueuedFrames(int offset)
        {
            while (_queuedFramePops > offset)
            {
                _frames.Pop();
                _queuedFramePops--;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal AphidFrame CreateEntryFrame() =>
            OwnerThread != -1 ?
                CreateNameFrame(GetEntryName()) :
                new AphidFrame(
                    this,
                    CurrentScope,
                    CurrentExpression,
                    new Lazy<string>(() => GetEntryName()));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetEntryName() => Format("[Entrypoint (Thread 0x{0:X})]", OwnerThread);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidFrame CreateNameFrame(string name) => new AphidFrame(
            this,
            CurrentScope,
            CurrentExpression,
            name);

        #endregion

        #region Root Interpret Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject InterpretStream(string code)
        {
            var ast = AphidParser.Parse(code);
#if APHID_SET_CODE_VAR
            SetAstCode(ast);
#endif

            var mutatedAst = MutatorGroups.GetStandard().Mutate(ast);
            Interpret(mutatedAst, resetIsReturning: true);

            return GetReturnValue(true);

#pragma warning disable CS0162 // Unreachable code detected
            foreach (var exp in mutatedAst)
#pragma warning restore CS0162 // Unreachable code detected
            {
                InterpretExpression(exp);

                if (_isReturning)
                {
                    _isReturning = false;
                    return GetReturnValue(true);
                }
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject Interpret(AphidExpression expression)
        {
            CurrentStatement = expression;

#if APHID_SET_CODE_VAR
            SetAstCode(new List<AphidExpression> { expression });
#endif
            IdentifierExpression idExp;
            UnaryOperatorExpression unaryExp;

            if (((expression.Type == Exp.IdentifierExpression &&
                (idExp = (IdentifierExpression)expression).Attributes.Count == 1) ||
                (expression.Type == Exp.UnaryOperatorExpression &&
                ((unaryExp = (UnaryOperatorExpression)expression).Operator == retKeyword) &&
                unaryExp.Operand.Type == Exp.IdentifierExpression &&
                (idExp = (IdentifierExpression)unaryExp.Operand).Attributes.Count == 1)) &&
                idExp.Attributes[0].Identifier == AphidName.Var)
            {
                var id = idExp.Identifier;

                if (CurrentScope.ContainsKey(id))
                {
                    throw CreateRuntimeException("Duplicated variable declaration: {0}", id);
                }

                CurrentScope.Add(id, InternedNull);

                return null;
            }

            return InterpretExpression(expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretExpression(AphidExpression expression)
        {
            CurrentExpression = expression;

#if APHID_DEBUGGING_ENABLED
            HandleDebugging(expression);
#endif

#if STRICT_INDEX
            if (expression.Index == -1 || expression.Length == -1)
            {
                throw new InvalidOperationException("Invalid index/length.");
            }
#endif

            if (OnInterpretExpression != null && !OnInterpretExpressionExecuting)
            {
                OnInterpretExpressionExecuting = true;
                try
                {
                    AphidExecutionContext<AphidExpression> ctx = expression;
                    OnInterpretExpression(ctx);

                    if (ctx.IsHandled)
                    {
                        return ctx.Result;
                    }
                    else if (ctx.IsModified)
                    {
                        expression = ctx.Expression;
                    }
                }
                finally
                {
                    OnInterpretExpressionExecuting = false;
                }
            }

            switch (expression.Type)
            {
                case Exp.BinaryOperatorExpression:
                    return (AphidObject)InterpretBinaryOperatorExpression((BinaryOperatorExpression)expression);

                case Exp.BinaryOperatorBodyExpression:
                    return InterpretBinaryOperatorBodyExpression((BinaryOperatorBodyExpression)expression);

                case Exp.ObjectExpression:
                    return InterpretObjectExpression((ObjectExpression)expression);

                case Exp.StringExpression:
                    return InterpretStringExpression((StringExpression)expression);

                case Exp.NumberExpression:
                    return InterpretNumberExpression((NumberExpression)expression);

                case Exp.CallExpression:
                    return InterpretCallExpression((CallExpression)expression);

                case Exp.IdentifierExpression:
                    return InterpretIdentifierExpression((IdentifierExpression)expression);

                case Exp.FunctionExpression:
                    return InterpretFunctionExpression((FunctionExpression)expression);

                case Exp.ArrayExpression:
                    return InterpretArrayExpression((ArrayExpression)expression);

                case Exp.UnaryOperatorExpression:
                    return InterpretUnaryOperatorExpression((UnaryOperatorExpression)expression);

                case Exp.BooleanExpression:
                    return InterpretBooleanExpression((BooleanExpression)expression);

                case Exp.IfExpression:
                    return InterpretIfExpression((IfExpression)expression);

                case Exp.ArrayAccessExpression:
                    return InterpretArrayAccessExpression((ArrayAccessExpression)expression);

                case Exp.ForEachExpression:
                    return InterpretForEachExpression((ForEachExpression)expression);

                case Exp.ForExpression:
                    return InterpretForExpression((ForExpression)expression);

                case Exp.UsingExpression:
                    return InterpretUsingExpression((UsingExpression)expression);

                case Exp.LockExpression:
                    return InterpretLockExpression((LockExpression)expression);

                case Exp.LoadScriptExpression:
                    return InterpretLoadScriptExpression((LoadScriptExpression)expression);

                case Exp.LoadLibraryExpression:
                    return InterpretLoadLibraryExpression((LoadLibraryExpression)expression);

                case Exp.NullExpression:
                    return InternedNull;

                case Exp.ContinueExpression:
                    return InterpretContinueExpression();

                case Exp.BreakExpression:
                    return InterpretBreakExpression();

                case Exp.PartialFunctionExpression:
                    return InterpretPartialFunctionExpression((PartialFunctionExpression)expression);

                case Exp.ThisExpression:
                    return InterpretThisExpression();

                case Exp.PatternMatchingExpression:
                    return InterpretPatternMatchingExpression((PatternMatchingExpression)expression);

                case Exp.ExtendExpression:
                    InterpretExtendExpression((ExtendExpression)expression);

                    return null;

                case Exp.WhileExpression:
                    InterpretWhileExpression((WhileExpression)expression);

                    return null;

                case Exp.DoWhileExpression:
                    InterpretDoWhileExpression((DoWhileExpression)expression);

                    return null;

                case Exp.TryExpression:
                    InterpretTryExpression((TryExpression)expression);

                    return null;

                case Exp.TernaryOperatorExpression:
                    return InterpretTernaryOperatorExpression((TernaryOperatorExpression)expression);

                case Exp.SwitchExpression:
                    InterpretSwitchExpression((SwitchExpression)expression);

                    return null;

                case Exp.TextExpression:
                    InterpretTextExpression((TextExpression)expression);

                    return null;

                case Exp.GatorOpenExpression:
                case Exp.GatorCloseExpression:
                    return null;

                case Exp.GatorEmitExpression:
                    InterpretGatorEmitExpression((GatorEmitExpression)expression);

                    return null;

                case Exp.PartialOperatorExpression:
                    var partialOpExp = (PartialOperatorExpression)expression;

                    return InterpretPartialOperatorExpression(partialOpExp);

                case Exp.ImplicitArgumentExpression:
                    return InterpretImplicitArgumentExpression();

                case Exp.ImplicitArgumentsExpression:
                    return InterpretImplicitArgumentsExpression();

                default:
                    throw CreateRuntimeException("Unexpected expression {0}", expression);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretAndUnwrap(AphidExpression expression) =>
            Unwrap(InterpretExpression(expression));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InterpretFile(string filename) => InterpretFile(filename, false);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InterpretFile(string filename, bool isTextDocument)
        {
            var fullFilename = Loader.FindScriptFile(filename);

            if (fullFilename == null)
            {
                throw CreateRuntimeException("Cannot find script {0}.", filename);
            }

            SetScriptFilename(fullFilename);
            var code = AphidScript.Read(filename);
            Interpret(code, filename, isTextDocument);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(string code) => Interpret(code, false);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(string code, bool isTextDocument) =>
            Interpret(code, null, isTextDocument);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(string code, string filename, bool isTextDocument)
        {
            var ast = AphidParser.Parse(code, filename, isTextDocument);
#if APHID_SET_CODE_VAR
            SetAstCode(ast);
#endif
            Interpret(MutatorGroups.GetStandard().Mutate(ast));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(List<AphidExpression> expressions)
        {
            if (OwnerThread == -1)
            {
                OwnerThread = Thread.CurrentThread.ManagedThreadId;
#if APHID_SET_CODE_VAR
                SetAstCode(expressions);
#endif
                Interpret(expressions, resetIsReturning: true);
            }
            else if (OwnerThread == Thread.CurrentThread.ManagedThreadId)
            {
#if APHID_SET_CODE_VAR
                SetAstCode(expressions);
#endif
                Interpret(expressions, resetIsReturning: true);
            }
            else
            {
                // Todo: come up with more foolproof solution to this issue.
                var child = AphidThread.CreateChild(this);

                if (AphidErrorReporter.IsEnabled)
                {
                    try
                    {
                        child.Interpret(expressions);
                    }
                    catch (Exception e)
                    {
                        AphidErrorReporter.Report(e, passThrough: true);

                        return;
                    }
                }
                else
                {
                    child.Interpret(expressions);
                }

                child.Interpret(expressions);

                var r = child.GetReturnValue();

                if (r != null)
                {
                    SetReturnValue(r);
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Interpret(List<AphidExpression> expressions, bool resetIsReturning)
        {
            if (OnInterpretBlock != null && !OnInterpretBlockExecuting)
            {
                OnInterpretBlockExecuting = true;

                try
                {
                    var ctx = new AphidExecutionContext();
                    var result = OnInterpretBlock(expressions, ctx);

                    if (ctx.IsModified)
                    {
                        expressions = result;
                    }

                    if (ctx.IsHandled)
                    {
                        return;
                    }
                }
                finally
                {
                    OnInterpretBlockExecuting = false;
                }
            }

            if (!CurrentScope.ContainsKey(AphidName.Block))
            {
                CurrentScope.Add(AphidName.Block, Scalar(expressions));
            }

            for (var i = 0; i < expressions.Count || _insertNextBuffer != null; i++)
            {
#if APHID_DEBUGGING_ENABLED
                _currentBlock = expressions;
#endif

                if (_insertNextBuffer != null)
                {
                    expressions.InsertRange(i, _insertNextBuffer);
                    _insertNextBuffer = null;
                }

                var expression = expressions[i];
                CurrentStatement = CurrentExpression = expression;

#if EXPRESSION_HISTORY
                if (!_isSteppingBack)
                {
                    if (++_expressionHistoryIndex == 0x100)
                    {
                        _expressionHistoryIndex = 0;
                    }

                    AphidObject scopeCopy;

                    if (CurrentScope != null)
                    {
                        //var num = 0;
                        scopeCopy = Complex();

                        var dst = scopeCopy;
                        var src = CurrentScope;

                        while (true)
                        {
                            foreach (var kvp in src)
                            {
                                dst.Add(
                                    kvp.Key,
                                    kvp.Value == null ? null :
                                    kvp.Value.IsComplex ? Complex(kvp.Value) :
                                    Scalar(kvp.Value.Value));
                            }

                            //dst.Add("$copy", Scalar(num++));

                            if (src.Parent != null)
                            {
                                var p = Scope();
                                dst.Parent = p;
                                dst["$parent"] = p;
                                dst = p;
                                src = src.Parent;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        scopeCopy = null;
                    }


                    _expressionHistory[_expressionHistoryIndex] = new ExpressionHistoryRecord(
                        CurrentStatement,
                        expressions,
                        i,
                        scopeCopy,
                        GetStackTrace(-1));
                }
                else
                {
                    _isSteppingBack = false;
                }
#endif

                if (OnInterpretStatement != null && !OnInterpretStatementExecuting)
                {
                    OnInterpretStatementExecuting = true;

                    try
                    {
                        AphidExecutionContext<AphidExpression> ctx = expression;
                        OnInterpretStatement(ctx);

                        if (ctx.IsHandled)
                        {
                            continue;
                        }
                        else if (ctx.IsModified)
                        {
                            expression = ctx.Expression;
                        }
                    }
                    finally
                    {
                        OnInterpretStatementExecuting = false;
                    }
                }

                if (expression.Type == Exp.IdentifierExpression)
                {
#if APHID_DEBUGGING_ENABLED
#if EXPRESSION_HISTORY
                    try
                    {
#endif
                        HandleDebugging(expression);
#if EXPRESSION_HISTORY
                    }
                    catch (StepBackException)
                    {
                        var rec = _expressionHistory[_expressionHistoryIndex];
                        expressions = rec.Block;
                        i = rec.BlockIndex - 1;
                        CurrentStatement = CurrentExpression = rec.Statement;

                        if (_singleStepReset != null)
                        {
                            _singleStepReset.Reset();
                        }
                        else
                        {
                            _singleStepReset = new AutoResetEvent(false);
                        }

                        BreakExecution(CurrentStatement);
                        _isSingleStepping = true;
                        continue;
                    }
#endif
#endif

                    var idExp = (IdentifierExpression)expression;
                    var id = idExp.Identifier;
                    List<IdentifierExpression> attrs;

                    if (CurrentScope.ContainsKey(id))
                    {
                        throw CreateRuntimeException("Duplicated variable declaration: {0}", id);
                    }
                    else if (StrictMode &&
                        ((attrs = idExp.Attributes).Count == 0 ||
                        attrs[0].Identifier != AphidName.Var))
                    {
                        throw CreateStrictModeException(id);
                    }

                    CurrentScope.Add(id, InternedNull);
                }
                else
                {
#if APHID_DEBUGGING_ENABLED && EXPRESSION_HISTORY
                    try
                    {
#endif
                        InterpretExpression(expression);
#if APHID_DEBUGGING_ENABLED && EXPRESSION_HISTORY
                    }
                    catch (StepBackException)
                    {
                        var rec = _expressionHistory[_expressionHistoryIndex];
                        expressions = rec.Block;
                        i = rec.BlockIndex - 1;
                        CurrentStatement = CurrentExpression = rec.Statement;

                        if (_singleStepReset != null)
                        {
                            _singleStepReset.Reset();
                        }
                        else
                        {
                            _singleStepReset = new AutoResetEvent(false);
                        }

                        BreakExecution(CurrentStatement);
                        _isSingleStepping = true;
                        continue;
                    }
#endif
                }

                if (_isBreaking || _isContinuing)
                {
                    break;
                }
                else if (_isReturning)
                {
                    if (resetIsReturning)
                    {
                        _isReturning = false;
                    }

                    break;
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretBlock(List<AphidExpression> block)
        {
            EnterScope();

            try
            {
                Interpret(block, false);
            }
            finally
            {
                LeaveScope(true);
            }
        }

        #endregion

        #region Node Specific Interpret Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretInteropNewExpression(AphidExpression operand)
        {
            switch (operand.Type)
            {
                case Exp.CallExpression:
                    var call = (CallExpression)operand;

                    var args = new object[call.Args.Count];

                    for (var i = 0; i < args.Length; i++)
                    {
                        args[i] = DeepUnwrap(InterpretExpression(call.Args[i]));
                    }

                    PushFrame(operand, call.FunctionExpression, args);

                    try
                    {
                        var typeObj = Unwrap(InterpretExpression(call.FunctionExpression));

                        if (typeObj == null)
                        {
                            throw CreateRuntimeException(
                                "Could not resolve type {0}.",
                                call.FunctionExpression);
                        }
                        else if (!typeof(Type).IsAssignableFrom(typeObj.GetType()))
                        {
                            throw CreateRuntimeException(
                                "Expression '{0}' resolved to '{1}', expected type.",
                                call.FunctionExpression,
                                typeObj);
                        }

                        var type = (Type)typeObj;

                        object result;
                        AphidObject obj;

                        if (!type.IsValueType || args.Length > 0)
                        {
                            var ctor = InteropMethodResolver.Resolve(
                                type.GetConstructors(),
                                args);

                            var convertedArgs = TypeConverter.Convert(
                                ctor.Arguments,
                                ctor.GenericArguments);

                            result = ((ConstructorInfo)ctor.Method).Invoke(convertedArgs);

                            if (type != typeof(AphidObject))
                            {
                                obj = Scalar(result);
                            }
                            else
                            {
                                obj = (AphidObject)result;
                            }
                        }
                        else
                        {
                            obj = Scalar(result = Activator.CreateInstance(type));
                        }

                        var extension = TryResolve(
                            CurrentScope,
                            obj,
                            GetCtorName(type.FullName),
                            false,
                            isCtor: true,
                            isDynamic: false,
                            returnRef: false);

                        if (extension != null)
                        {
                            if (extension.Value is AphidFunction func)
                            {
                                var obj2 = CallFunction(func, obj);

                                if (obj2 != null)
                                {
                                    obj = obj2;
                                }
                            }
                            else
                            {
                                obj = extension;
                            }
                        }

                        return obj;
                    }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                            while (_queuedFramePops > 0)
                            {
                                _frames.Pop();
                                _queuedFramePops--;
                            }
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, this);
                            e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                            e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                        }

                        throw;
                    }
#endif
                    finally
                    {
                        PopFrame();
                    }

                default:
                    throw CreateRuntimeException("Operand not supported in new expression: {0}", operand);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretFunctionExpression(FunctionExpression expression)
        {
            var args = new string[expression.Args.Count];

            for (var i = 0; i < args.Length; i++)
            {
                args[i] = ((IdentifierExpression)expression.Args[i]).Identifier;
            }

            return Scalar(new AphidFunction(args, expression.Body, CurrentScope));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretArrayExpression(ArrayExpression expression)
        {
            var list = new List<AphidObject>(expression.Elements.Count);

            for (var i = 0; i < expression.Elements.Count; i++)
            {
                var element = InterpretExpression(expression.Elements[i]);

                if (element is AphidObject ao)
                {
                    if (ao.IsComplex)
                    {
                        list.Add(ao);
                    }
                    else
                    {
                        list.Add(Scalar(ao.Value));
                    }
                }
                else
                {
                    list.Add(Scalar(element));
                }
            }

            return Scalar(list);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretUnaryOperatorExpression(UnaryOperatorExpression expression)
        {
            if (!expression.IsPostfix)
            {
                switch (expression.Operator)
                {
                    case AdditionOperator:
                        return InterpretExpression(expression.Operand);

                    case MinusOperator:
                        var val = Unwrap(InterpretExpression(expression.Operand));

                        if (!(val is decimal))
                        {
                            throw CreateRuntimeException(
                                "Unary operator '-' expects number, {0} was provided instead.",
                                val.GetType());
                        }

                        return Scalar((decimal)val * -1);

                    case ComplementOperator:
                        val = InterpretAndUnwrap(expression.Operand);
                        ValueHelper.AssertNumber(val, "unary operator '~'");

                        return Scalar((decimal)~ToUInt64(val));

                    case throwKeyword:
                        var exceptionObj = Unwrap(InterpretExpression(expression.Operand));

                        switch (exceptionObj)
                        {
                            case Exception exception:
                                throw exception;
                            case string message:
                                throw CreateRuntimeException(message);
                            default:
                                throw CreateRuntimeException(
                            "Cannot throw value of type {0}, from expression {1} " +
                                "expected Exception or string.",
                                exceptionObj ?? "null",
                                expression);
                        }

                    case retKeyword:
                        SetReturnValue(InterpretExpression(expression.Operand));
                        _isReturning = true;
                        return null;

                    case deleteKeyword:
                        var operand = ((IdentifierExpression)expression.Operand).Identifier;
                        return Scalar(CurrentScope.TryResolveAndRemove(operand));

                    case NotOperator:
                        return Scalar(!(bool)InterpretExpression(expression.Operand).Value);

                    case IncrementOperator:
                        var obj = InterpretExpression(expression.Operand);
                        obj.Value = ((decimal)obj.Value) + 1;
                        return obj;

                    case DecrementOperator:
                        obj = InterpretExpression(expression.Operand);
                        obj.Value = ((decimal)obj.Value) - 1;
                        return obj;

                    case DistinctOperator:
                        var result = ValueHelper
                            .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                            .Select(Unwrap)
                            .Distinct()
                            .Select(Wrap) // To maintain backwards compat with Aphid
                            .ToList()
                            ;                // list extension such as __list.count().

                        return Scalar(result);

                    case PostfixCountOperator:
                        return Scalar(
                            ValueHelper
                                .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                                .Count());

                    case PostfixFirstOperator:
                        return Wrap(
                            ValueHelper
                                .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                                .First());

                    case PostfixLastOperator:
                        return Wrap(
                            ValueHelper
                                .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                                .Last());

                    case PostfixOrderOperator:
                        return Wrap(
                            ValueHelper
                                .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                                .OrderBy(Unwrap));

                    case PostfixOrderDescendingOperator:
                        return Wrap(
                            ValueHelper
                                .UnwrapIEnumerableObject(InterpretExpression(expression.Operand))
                                .OrderByDescending(Unwrap));

                    //return Scalar(list.Distinct(_comparer).ToList());

                    case usingKeyword:
                        AddImport(FlattenAndJoinPath(expression.Operand));

                        return null;

                    case newKeyword:
                        return InterpretInteropNewExpression(expression.Operand);

                    case loadKeyword:
                        // Todo: make more robust by searching application dir,
                        // script dir, etc.
                        Assembly asm = null;
                        string path;

                        switch (expression.Operand.Type)
                        {
                            case Exp.IdentifierExpression:
                            case Exp.BinaryOperatorExpression:
#pragma warning disable CS0618 // 'Assembly.LoadWithPartialName(string)' is obsolete: 'This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202'
                                asm = Assembly.LoadWithPartialName(
                                    path = FlattenAndJoinPath(expression.Operand));
#pragma warning restore CS0618 // 'Assembly.LoadWithPartialName(string)' is obsolete: 'This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202'
                                break;

                            case Exp.StringExpression:
                                if (File.Exists(path = Path.GetFullPath(
                                    StringParser.Parse(
                                        ((StringExpression)expression.Operand).Value))))
                                {
                                    asm = Assembly.LoadFrom(path);
                                }

                                break;
                        }

                        if (asm == null)
                        {
                            // Todo: safely deref member expression to avoid
                            // null ref exception on fallback.
                            var loadOperand = InterpretExpression(expression.Operand);
                            var unwrappedPath = Unwrap((object)loadOperand);

                            if (unwrappedPath == null)
                            {
                                return InternedNull;
                            }

                            if (File.Exists(path = unwrappedPath.ToString()))
                            {
                                asm = Assembly.LoadFrom(path);
                            }
                        }

                        return Scalar(asm);

                    case InteropOperator:
                        switch (GetInteropAttribute(expression.Operand))
                        {
                            case null:
                                switch (expression.Operand.Type)
                                {
                                    case Exp.CallExpression:
                                        return CallStaticInteropFunction(
                                            (CallExpression)expression.Operand);

                                    case Exp.BinaryOperatorExpression:
                                        return InterpretMemberInteropExpression(
                                            null,
                                            (BinaryOperatorExpression)expression.Operand);

                                    default:
                                        throw new NotImplementedException();
                                }

                            default:
                                throw new NotImplementedException();
                        }

                    #region Custom Operator Cases
                    case AphidTokenType.CustomOperator000:
                    case AphidTokenType.CustomOperator001:
                    case AphidTokenType.CustomOperator002:
                    case AphidTokenType.CustomOperator003:
                    case AphidTokenType.CustomOperator004:
                    case AphidTokenType.CustomOperator005:
                    case AphidTokenType.CustomOperator006:
                    case AphidTokenType.CustomOperator007:
                    case AphidTokenType.CustomOperator008:
                    case AphidTokenType.CustomOperator009:
                    case AphidTokenType.CustomOperator010:
                    case AphidTokenType.CustomOperator011:
                    case AphidTokenType.CustomOperator012:
                    case AphidTokenType.CustomOperator013:
                    case AphidTokenType.CustomOperator014:
                    case AphidTokenType.CustomOperator015:
                    case AphidTokenType.CustomOperator016:
                    case AphidTokenType.CustomOperator017:
                    case AphidTokenType.CustomOperator018:
                    case AphidTokenType.CustomOperator019:
                    case AphidTokenType.CustomOperator020:
                    case AphidTokenType.CustomOperator021:
                    case AphidTokenType.CustomOperator022:
                    case AphidTokenType.CustomOperator023:
                    case AphidTokenType.CustomOperator024:
                    case AphidTokenType.CustomOperator025:
                    case AphidTokenType.CustomOperator026:
                    case AphidTokenType.CustomOperator027:
                    case AphidTokenType.CustomOperator028:
                    case AphidTokenType.CustomOperator029:
                    case AphidTokenType.CustomOperator030:
                    case AphidTokenType.CustomOperator031:
                    case AphidTokenType.CustomOperator032:
                    case AphidTokenType.CustomOperator033:
                    case AphidTokenType.CustomOperator034:
                    case AphidTokenType.CustomOperator035:
                    case AphidTokenType.CustomOperator036:
                    case AphidTokenType.CustomOperator037:
                    case AphidTokenType.CustomOperator038:
                    case AphidTokenType.CustomOperator039:
                    case AphidTokenType.CustomOperator040:
                    case AphidTokenType.CustomOperator041:
                    case AphidTokenType.CustomOperator042:
                    case AphidTokenType.CustomOperator043:
                    case AphidTokenType.CustomOperator044:
                    case AphidTokenType.CustomOperator045:
                    case AphidTokenType.CustomOperator046:
                    case AphidTokenType.CustomOperator047:
                    case AphidTokenType.CustomOperator048:
                    case AphidTokenType.CustomOperator049:
                    case AphidTokenType.CustomOperator050:
                    case AphidTokenType.CustomOperator051:
                    case AphidTokenType.CustomOperator052:
                    case AphidTokenType.CustomOperator053:
                    case AphidTokenType.CustomOperator054:
                    case AphidTokenType.CustomOperator055:
                    case AphidTokenType.CustomOperator056:
                    case AphidTokenType.CustomOperator057:
                    case AphidTokenType.CustomOperator058:
                    case AphidTokenType.CustomOperator059:
                    case AphidTokenType.CustomOperator060:
                    case AphidTokenType.CustomOperator061:
                    case AphidTokenType.CustomOperator062:
                    case AphidTokenType.CustomOperator063:
                    case AphidTokenType.CustomOperator064:
                    case AphidTokenType.CustomOperator065:
                    case AphidTokenType.CustomOperator066:
                    case AphidTokenType.CustomOperator067:
                    case AphidTokenType.CustomOperator068:
                    case AphidTokenType.CustomOperator069:
                    case AphidTokenType.CustomOperator070:
                    case AphidTokenType.CustomOperator071:
                    case AphidTokenType.CustomOperator072:
                    case AphidTokenType.CustomOperator073:
                    case AphidTokenType.CustomOperator074:
                    case AphidTokenType.CustomOperator075:
                    case AphidTokenType.CustomOperator076:
                    case AphidTokenType.CustomOperator077:
                    case AphidTokenType.CustomOperator078:
                    case AphidTokenType.CustomOperator079:
                    case AphidTokenType.CustomOperator080:
                    case AphidTokenType.CustomOperator081:
                    case AphidTokenType.CustomOperator082:
                    case AphidTokenType.CustomOperator083:
                    case AphidTokenType.CustomOperator084:
                    case AphidTokenType.CustomOperator085:
                    case AphidTokenType.CustomOperator086:
                    case AphidTokenType.CustomOperator087:
                    case AphidTokenType.CustomOperator088:
                    case AphidTokenType.CustomOperator089:
                    case AphidTokenType.CustomOperator090:
                    case AphidTokenType.CustomOperator091:
                    case AphidTokenType.CustomOperator092:
                    case AphidTokenType.CustomOperator093:
                    case AphidTokenType.CustomOperator094:
                    case AphidTokenType.CustomOperator095:
                    case AphidTokenType.CustomOperator096:
                    case AphidTokenType.CustomOperator097:
                    case AphidTokenType.CustomOperator098:
                    case AphidTokenType.CustomOperator099:
                    case AphidTokenType.CustomOperator100:
                    case AphidTokenType.CustomOperator101:
                    case AphidTokenType.CustomOperator102:
                    case AphidTokenType.CustomOperator103:
                    case AphidTokenType.CustomOperator104:
                    case AphidTokenType.CustomOperator105:
                    case AphidTokenType.CustomOperator106:
                    case AphidTokenType.CustomOperator107:
                    case AphidTokenType.CustomOperator108:
                    case AphidTokenType.CustomOperator109:
                    case AphidTokenType.CustomOperator110:
                    case AphidTokenType.CustomOperator111:
                    case AphidTokenType.CustomOperator112:
                    case AphidTokenType.CustomOperator113:
                    case AphidTokenType.CustomOperator114:
                    case AphidTokenType.CustomOperator115:
                    case AphidTokenType.CustomOperator116:
                    case AphidTokenType.CustomOperator117:
                    case AphidTokenType.CustomOperator118:
                    case AphidTokenType.CustomOperator119:
                    case AphidTokenType.CustomOperator120:
                    case AphidTokenType.CustomOperator121:
                    case AphidTokenType.CustomOperator122:
                    case AphidTokenType.CustomOperator123:
                    case AphidTokenType.CustomOperator124:
                    case AphidTokenType.CustomOperator125:
                    case AphidTokenType.CustomOperator126:
                    case AphidTokenType.CustomOperator127:
                    case AphidTokenType.CustomOperator128:
                    case AphidTokenType.CustomOperator129:
                    case AphidTokenType.CustomOperator130:
                    case AphidTokenType.CustomOperator131:
                    case AphidTokenType.CustomOperator132:
                    case AphidTokenType.CustomOperator133:
                    case AphidTokenType.CustomOperator134:
                    case AphidTokenType.CustomOperator135:
                    case AphidTokenType.CustomOperator136:
                    case AphidTokenType.CustomOperator137:
                    case AphidTokenType.CustomOperator138:
                    case AphidTokenType.CustomOperator139:
                    case AphidTokenType.CustomOperator140:
                    case AphidTokenType.CustomOperator141:
                    case AphidTokenType.CustomOperator142:
                    case AphidTokenType.CustomOperator143:
                    case AphidTokenType.CustomOperator144:
                    case AphidTokenType.CustomOperator145:
                    case AphidTokenType.CustomOperator146:
                    case AphidTokenType.CustomOperator147:
                    case AphidTokenType.CustomOperator148:
                    case AphidTokenType.CustomOperator149:
                    case AphidTokenType.CustomOperator150:
                    case AphidTokenType.CustomOperator151:
                    case AphidTokenType.CustomOperator152:
                    case AphidTokenType.CustomOperator153:
                    case AphidTokenType.CustomOperator154:
                    case AphidTokenType.CustomOperator155:
                    case AphidTokenType.CustomOperator156:
                    case AphidTokenType.CustomOperator157:
                    case AphidTokenType.CustomOperator158:
                    case AphidTokenType.CustomOperator159:
                    case AphidTokenType.CustomOperator160:
                    case AphidTokenType.CustomOperator161:
                    case AphidTokenType.CustomOperator162:
                    case AphidTokenType.CustomOperator163:
                    case AphidTokenType.CustomOperator164:
                    case AphidTokenType.CustomOperator165:
                    case AphidTokenType.CustomOperator166:
                    case AphidTokenType.CustomOperator167:
                    case AphidTokenType.CustomOperator168:
                    case AphidTokenType.CustomOperator169:
                    case AphidTokenType.CustomOperator170:
                    case AphidTokenType.CustomOperator171:
                    case AphidTokenType.CustomOperator172:
                    case AphidTokenType.CustomOperator173:
                    case AphidTokenType.CustomOperator174:
                    case AphidTokenType.CustomOperator175:
                    case AphidTokenType.CustomOperator176:
                    case AphidTokenType.CustomOperator177:
                    case AphidTokenType.CustomOperator178:
                    case AphidTokenType.CustomOperator179:
                    case AphidTokenType.CustomOperator180:
                    case AphidTokenType.CustomOperator181:
                    case AphidTokenType.CustomOperator182:
                    case AphidTokenType.CustomOperator183:
                    case AphidTokenType.CustomOperator184:
                    case AphidTokenType.CustomOperator185:
                    case AphidTokenType.CustomOperator186:
                    case AphidTokenType.CustomOperator187:
                    case AphidTokenType.CustomOperator188:
                    case AphidTokenType.CustomOperator189:
                    case AphidTokenType.CustomOperator190:
                    case AphidTokenType.CustomOperator191:
                    case AphidTokenType.CustomOperator192:
                    case AphidTokenType.CustomOperator193:
                    case AphidTokenType.CustomOperator194:
                    case AphidTokenType.CustomOperator195:
                    case AphidTokenType.CustomOperator196:
                    case AphidTokenType.CustomOperator197:
                    case AphidTokenType.CustomOperator198:
                    case AphidTokenType.CustomOperator199:
                    case AphidTokenType.CustomOperator200:
                    case AphidTokenType.CustomOperator201:
                    case AphidTokenType.CustomOperator202:
                    case AphidTokenType.CustomOperator203:
                    case AphidTokenType.CustomOperator204:
                    case AphidTokenType.CustomOperator205:
                    case AphidTokenType.CustomOperator206:
                    case AphidTokenType.CustomOperator207:
                    case AphidTokenType.CustomOperator208:
                    case AphidTokenType.CustomOperator209:
                    case AphidTokenType.CustomOperator210:
                    case AphidTokenType.CustomOperator211:
                    case AphidTokenType.CustomOperator212:
                    case AphidTokenType.CustomOperator213:
                    case AphidTokenType.CustomOperator214:
                    case AphidTokenType.CustomOperator215:
                    case AphidTokenType.CustomOperator216:
                    case AphidTokenType.CustomOperator217:
                    case AphidTokenType.CustomOperator218:
                    case AphidTokenType.CustomOperator219:
                    case AphidTokenType.CustomOperator220:
                    case AphidTokenType.CustomOperator221:
                    case AphidTokenType.CustomOperator222:
                    case AphidTokenType.CustomOperator223:
                    case AphidTokenType.CustomOperator224:
                    case AphidTokenType.CustomOperator225:
                    case AphidTokenType.CustomOperator226:
                    case AphidTokenType.CustomOperator227:
                    case AphidTokenType.CustomOperator228:
                    case AphidTokenType.CustomOperator229:
                    case AphidTokenType.CustomOperator230:
                    case AphidTokenType.CustomOperator231:
                    case AphidTokenType.CustomOperator232:
                    case AphidTokenType.CustomOperator233:
                    case AphidTokenType.CustomOperator234:
                    case AphidTokenType.CustomOperator235:
                    case AphidTokenType.CustomOperator236:
                    case AphidTokenType.CustomOperator237:
                    case AphidTokenType.CustomOperator238:
                    case AphidTokenType.CustomOperator239:
                    case AphidTokenType.CustomOperator240:
                    case AphidTokenType.CustomOperator241:
                    case AphidTokenType.CustomOperator242:
                    case AphidTokenType.CustomOperator243:
                    case AphidTokenType.CustomOperator244:
                    case AphidTokenType.CustomOperator245:
                    case AphidTokenType.CustomOperator246:
                    case AphidTokenType.CustomOperator247:
                    case AphidTokenType.CustomOperator248:
                    case AphidTokenType.CustomOperator249:
                    case AphidTokenType.CustomOperator250:
                    case AphidTokenType.CustomOperator251:
                    case AphidTokenType.CustomOperator252:
                    case AphidTokenType.CustomOperator253:
                    case AphidTokenType.CustomOperator254:
                    case AphidTokenType.CustomOperator255:
                    case AphidTokenType.CustomOperator256:
                    case AphidTokenType.CustomOperator257:
                    case AphidTokenType.CustomOperator258:
                    case AphidTokenType.CustomOperator259:
                    case AphidTokenType.CustomOperator260:
                    case AphidTokenType.CustomOperator261:
                    case AphidTokenType.CustomOperator262:
                    case AphidTokenType.CustomOperator263:
                    case AphidTokenType.CustomOperator264:
                    case AphidTokenType.CustomOperator265:
                    case AphidTokenType.CustomOperator266:
                    case AphidTokenType.CustomOperator267:
                    case AphidTokenType.CustomOperator268:
                    case AphidTokenType.CustomOperator269:
                    case AphidTokenType.CustomOperator270:
                    case AphidTokenType.CustomOperator271:
                    case AphidTokenType.CustomOperator272:
                    case AphidTokenType.CustomOperator273:
                    case AphidTokenType.CustomOperator274:
                    case AphidTokenType.CustomOperator275:
                    case AphidTokenType.CustomOperator276:
                    case AphidTokenType.CustomOperator277:
                    case AphidTokenType.CustomOperator278:
                    case AphidTokenType.CustomOperator279:
                    case AphidTokenType.CustomOperator280:
                    case AphidTokenType.CustomOperator281:
                    case AphidTokenType.CustomOperator282:
                    case AphidTokenType.CustomOperator283:
                    case AphidTokenType.CustomOperator284:
                    case AphidTokenType.CustomOperator285:
                    case AphidTokenType.CustomOperator286:
                    case AphidTokenType.CustomOperator287:
                    case AphidTokenType.CustomOperator288:
                    case AphidTokenType.CustomOperator289:
                    case AphidTokenType.CustomOperator290:
                    case AphidTokenType.CustomOperator291:
                    case AphidTokenType.CustomOperator292:
                    case AphidTokenType.CustomOperator293:
                    case AphidTokenType.CustomOperator294:
                    case AphidTokenType.CustomOperator295:
                    case AphidTokenType.CustomOperator296:
                    case AphidTokenType.CustomOperator297:
                    case AphidTokenType.CustomOperator298:
                    case AphidTokenType.CustomOperator299:
                    case AphidTokenType.CustomOperator300:
                    case AphidTokenType.CustomOperator301:
                    case AphidTokenType.CustomOperator302:
                    case AphidTokenType.CustomOperator303:
                    case AphidTokenType.CustomOperator304:
                    case AphidTokenType.CustomOperator305:
                    case AphidTokenType.CustomOperator306:
                    case AphidTokenType.CustomOperator307:
                    case AphidTokenType.CustomOperator308:
                    case AphidTokenType.CustomOperator309:
                    case AphidTokenType.CustomOperator310:
                    case AphidTokenType.CustomOperator311:
                    case AphidTokenType.CustomOperator312:
                    case AphidTokenType.CustomOperator313:
                    case AphidTokenType.CustomOperator314:
                    case AphidTokenType.CustomOperator315:
                    case AphidTokenType.CustomOperator316:
                    case AphidTokenType.CustomOperator317:
                    case AphidTokenType.CustomOperator318:
                    case AphidTokenType.CustomOperator319:
                        #endregion
                        return InterpretCustomUnaryOperator(expression);

                    default:
                        throw CreateUnaryOperatorException(expression);
                }
            }
            else
            {
                switch (expression.Operator)
                {
                    case IncrementOperator:
                        var obj = InterpretExpression(expression.Operand);
                        var v = obj.Value;
                        obj.Value = ((decimal)obj.Value) + 1;
                        return Scalar(v);

                    case DecrementOperator:
                        obj = InterpretExpression(expression.Operand);
                        v = obj.Value;
                        obj.Value = ((decimal)obj.Value) - 1;
                        return Scalar(v);

                    case definedKeyword:
                        switch (expression.Operand.Type)
                        {
                            case Exp.IdentifierExpression:
                                if (CurrentScope.IsDefined(((IdentifierExpression)expression.Operand).Identifier))
                                {
                                    return InternedTrue;
                                }
                                else
                                {
                                    return InternedFalse;
                                }


                            case Exp.BinaryOperatorExpression:
                                try
                                {
                                    var memberRefObj = Unwrap(
                                        InterpretBinaryOperatorExpression(
                                            (BinaryOperatorExpression)expression.Operand,
                                            returnRef: true));

                                    switch (memberRefObj)
                                    {
                                        case AphidRef memberRef:
                                            var o = memberRef.Object;

                                            if (o.IsComplex && o.IsDefined(memberRef.Name))
                                            {
                                                return InternedTrue;
                                            }
                                            else
                                            {
                                                return InternedFalse;
                                            }

                                        default:
                                            if (memberRefObj is AphidInteropReference)
                                            {
                                                return InternedTrue;
                                            }
                                            else
                                            {
                                                return InternedFalse;
                                            }

                                    }
                                }
                                catch
                                {
                                    return InternedFalse;
                                }

                            case Exp.ArrayAccessExpression:
                                var arrayExp = (ArrayAccessExpression)expression.Operand;

                                if (arrayExp.KeyExpressions.Count != 1)
                                {
                                    throw CreateRuntimeException("Index expected.");
                                }

                                var keyObj = InterpretExpression(arrayExp.KeyExpressions[0]).Value;

                                if (keyObj is string key)
                                {
                                    var aphidObj = InterpretExpression(arrayExp.ArrayExpression);

                                    if (aphidObj.IsScalar)
                                    {
                                        if (aphidObj.Value != null &&
                                            aphidObj.Value.GetType().GetMember(key).Length != 0)
                                        {
                                            return InternedTrue;
                                        }
                                        else
                                        {
                                            return InternedFalse;
                                        }
                                    }
                                    else if (aphidObj.ContainsKey(key))
                                    {
                                        return InternedTrue;
                                    }

                                    return InternedFalse;
                                }
                                //Todo: support numbers
                                else
                                {
                                    throw CreateRuntimeException(
                                        "Expected string for object key, encountered {0}.",
                                        keyObj != null ? keyObj.GetType().FullName : "null");
                                }





                            default:
                                throw CreateRuntimeException("Unknown ? operand");
                        }

                    default:
                        throw CreateUnaryOperatorException(expression);
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static AphidObject InterpretBooleanExpression(BooleanExpression expression) =>
            Scalar(expression.Value);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIfExpression(IfExpression expression)
        {
            if ((bool)InterpretExpression(expression.Condition).Value)
            {
                InterpretBlock(expression.Body);
            }
            else if (expression.ElseBody != null)
            {
                InterpretBlock(expression.ElseBody);
            }
            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static AphidObject InterpretNumberExpression(NumberExpression expression) =>
            Scalar(expression.Value);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretArrayAccessExpression(ArrayAccessExpression expression)
        {
            var indexes = InterpretArrayAccessIndexes(expression, out var isTypeArgument);

            if (isTypeArgument)
            {
                if (expression.ArrayExpression.Type != Exp.IdentifierExpression)
                {
                    throw CreateRuntimeException("Expected identifier in generic type expression.");
                }

                var id = ((IdentifierExpression)expression.ArrayExpression).Identifier;

                Type genericType;
                var path = new[] { Format("{0}`{1}", id, indexes.Length) };

                //_importsLock.EnterReadLock();

                //try
                //{
                genericType = InteropTypeResolver.TryResolveType(
                    GetImports(),
                    _importsLock,
                    path,
                    isType: true);
                //}
                //finally
                //{
                //    _importsLock.ExitReadLock();
                //}

                if (genericType == null)
                {
                    throw CreateRuntimeException("Could not resolve generic type {0}<>", id);
                }

                var typeParams = new Type[indexes.Length];

                for (var i = 0; i < indexes.Length; i++)
                {
                    typeParams[i] = indexes[i].Value as Type;

                    if (typeParams[i] == null)
                    {
                        throw CreateRuntimeException(
                            "Invalid type parameter '{0}'.",
                            indexes[i].Value);
                    }
                }

                var constructedGenericType = genericType.MakeGenericType(typeParams);

                return Scalar(constructedGenericType);
            }
            else if (indexes.Length == 1 &&
                indexes[0]?.Value != null &&
                indexes[0].Value.GetType() == typeof(string))
            {
                var key = (string)indexes[0].Value;
                var target = InterpretExpression(expression.ArrayExpression);

                if (target == null)
                {
                    throw CreateRuntimeException("Cannot get member {0} from null.", key);
                }

                if (target is AphidObject aphidObj)
                {
                    if (aphidObj.IsScalar)
                    {
                        if (aphidObj.Value == null)
                        {
                            throw CreateRuntimeException("Cannot get member {0} from null.", key);
                        }

                        var members = GetInteropInstanceMembers(aphidObj.Value, key);

                        if (members.Length == 0)
                        {
                            throw CreateRuntimeException(
                                "Cannot get member {0} from {1}.",
                                key,
                                aphidObj.Value.GetType());
                        }

                        return InterpretMemberInteropExpression(
                            aphidObj.Value,
                            members,
                            expression);
                    }

                    if (aphidObj.TryGetValue(key, out var val))
                    {
                        return val.IsScalar ? Scalar(val.Value) : val;
                    }

                    throw CreateRuntimeException(
                        "Cannot get member {0} from {1}",
                        key,
                        aphidObj);
                }

                throw new NotImplementedException();
            }
            else
            {
                if (indexes.Length != 1)
                {
                    throw CreateRuntimeException("Multi-dimensional arrays not yet supported.");
                }

                var val = Unwrap(InterpretExpression(expression.ArrayExpression));
                var index = ToInt32(indexes[0].Value);

                switch (val)
                {
                    case List<AphidObject> array:
                        if (index < 0 || index >= array.Count)
                        {
                            throw CreateRuntimeException("Index out of range: {0}.", index);
                        }

                        return array[index];

                    case string str:
                        if (index < 0 || index >= str.Length)
                        {
                            throw CreateOutOfBoundsException(expression, val, index, str.Length);
                        }

                        return Scalar(str[index].ToString());

                    case IList list:
                        if (index < 0 || index >= list.Count)
                        {
                            throw CreateOutOfBoundsException(expression, val, index, list.Count);
                        }

                        return Wrap(list[index]);

                    case IEnumerable<AphidObject> aphidObjEnumerable:
                        var count = aphidObjEnumerable.Count();

                        if (index < 0 || index >= count)
                        {
                            throw CreateOutOfBoundsException(expression, val, index, count);
                        }

                        return aphidObjEnumerable.ElementAt(index);

                    case IEnumerable enumerable:
                        var i = 0;

                        foreach (var o in enumerable)
                        {
                            if (i++ == index)
                            {
                                return Wrap(o);
                            }
                        }

                        throw CreateOutOfBoundsException(expression, val, index, i - 1);

                    default:
                        throw CreateExpressionException(
                            expression.ArrayExpression,
                            val,
                            "Array access not supported by");
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject[] InterpretArrayAccessIndexes(
            ArrayAccessExpression expression,
            out bool isTypeArgument)
        {
            var indexExpressions = expression.KeyExpressions;
            isTypeArgument = false;

            if (indexExpressions.Count == 0)
            {
                return new AphidObject[0];
            }

            var indexes = new AphidObject[indexExpressions.Count];

            for (var i = 0; i < indexes.Length; i++)
            {
                var index = InterpretExpression(indexExpressions[i]);

                if (i == 0)
                {
                    var obj = Unwrap(index);
                    Type t;
                    isTypeArgument = obj != null &&
                        (((t = obj.GetType()) == typeof(Type)) ||
                        (t.BaseType == typeof(Type)) ||
                        (t.BaseType != null && t.BaseType.BaseType == typeof(Type)));
                }

                indexes[i] = Wrap(index);
            }

            return indexes;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretForExpression(ForExpression expression)
        {
            var inBodyScope = false;
            EnterScope();

            try
            {
                InterpretExpression(expression.Initialization);

                while ((bool)InterpretExpression(expression.Condition).Value)
                {
                    EnterScope();
                    inBodyScope = true;
                    Interpret(expression.Body, resetIsReturning: false);
                    InterpretExpression(expression.Afterthought);
                    _isContinuing = false;
                    var isReturning = LeaveScope(true);
                    inBodyScope = false;

                    if (isReturning || _isBreaking)
                    {
                        _isBreaking = false;
                        break;
                    }
                }
            }
            finally
            {
                LeaveScope(true);

                if (inBodyScope)
                {
                    LeaveScope(true);
                }
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretForEachExpression(ForEachExpression expression)
        {
            var collection = InterpretExpression(expression.Collection);
            var elements = (IEnumerable)collection.Value;

            var elementId = expression.Element != null ?
                ((IdentifierExpression)expression.Element).Identifier :
                null;

            var elementObjScope = elementId != null ?
                CurrentScope.TryResolveParent(elementId) :
                null;

            foreach (var element in elements)
            {
                bool isReturning;
                EnterScope();

                try
                {
                    var obj = Wrap(element);
                    SetImplicitArg(obj);

                    if (elementId != null)
                    {
                        if (elementObjScope == null)
                        {
                            CurrentScope.Add(elementId, obj);
                        }
                        else
                        {
                            elementObjScope[elementId] = obj;
                        }
                    }

                    Interpret(expression.Body, false);
                    _isContinuing = false;
                }
                finally
                {
                    isReturning = LeaveScope(true);
                }

                if (isReturning || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretUsingExpression(UsingExpression expression)
        {
            var result = Unwrap(InterpretExpression(expression.Disposable));

            if (!(result is IDisposable disposable))
            {
                throw CreateRuntimeException(
                    "{0} does not implement IDisposable.",
                    result ?? "null");
            }

            using (disposable)
            {
                InterpretBlock(expression.Body);
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretLockExpression(LockExpression expression)
        {
            object[] references;

            if (expression.Expressions.Count > 0)
            {
                references = new object[expression.Expressions.Count];

                for (var i = 0; i < references.Length; i++)
                {
                    var obj = InterpretExpression(expression.Expressions[i]);

                    if (obj.IsComplex)
                    {
                        references[i] = obj;
                    }
                    else
                    {
                        references[i] = obj.Value;

                        if (references[i] == null)
                        {
                            throw CreateMonitorException(
                                "null",
                                expression.Expressions[i]);
                        }

                        if (references[i].GetType().IsValueType)
                        {
                            // Todo: possibly support locking value types using internal
                            // sync object table.
                            throw CreateMonitorException(
                                Format("value type '{0}'", references[i]),
                                expression.Expressions[i]);
                        }
                    }
                }
            }
            else
            {
                references = new object[] { InterpretThisExpression() };
            }

            for (var i = 0; i < references.Length; i++)
            {
                Monitor.Enter(references[i]);
            }

            try
            {
                InterpretBlock(expression.Body);
            }
            finally
            {
                for (var i = 0; i < references.Length; i++)
                {
                    Monitor.Exit(references[i]);
                }
            }

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateMonitorException(
            string description,
            AphidExpression expression) => CreateRuntimeException(
                "Cannot lock {0} evaluated from '{1}'.",
                description,
                expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretLoadScriptExpression(LoadScriptExpression expression)
        {
            var file = Unwrap(InterpretExpression(expression.FileExpression)) as string;

            if (Loader == null || file == null)
            {
                throw CreateRuntimeException("Cannot load script {0}", expression.FileExpression);
            }

            PushFrame(file);

            try
            {
                List<AphidExpression> ast;
                string scriptDir;

                if (expression.Filename != null &&
                    !Loader.SearchPaths.Contains(
                        scriptDir = Path.GetDirectoryName(expression.Filename)))
                {
                    Loader.SearchPaths.Add(scriptDir);
                    ast = Loader.LoadScript(file);
                    Loader.SearchPaths.Remove(scriptDir);
                }
                else
                {
                    ast = Loader.LoadScript(file);
                }

                return Scalar(ast);
            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
            catch (Exception e)
#else
            catch
#endif
            {
                if (e.Source != AphidName.DebugInterpreter)
                {
                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                    while (_queuedFramePops > 0)
                    {
                        _frames.Pop();
                        _queuedFramePops--;
                    }
#endif

#if APHID_FRAME_ADD_DATA
                    e.Data.Add(AphidName.Interpreter, this);
                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                }

                throw;
            }
#endif
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretLoadLibraryExpression(LoadLibraryExpression expression)
        {
            var library = Unwrap(InterpretExpression(expression.LibraryExpression)) as string;

            if (Loader == null || library == null)
            {
                throw CreateRuntimeException("Cannot load script {0}", expression.LibraryExpression);
            }

            Loader.LoadLibrary(library, CurrentScope);

            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretContinueExpression()
        {
            _isContinuing = true;
            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretBreakExpression()
        {
            _isBreaking = true;
            return null;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretPartialFunctionExpression(PartialFunctionExpression expression)
        {
            var obj = InterpretExpression(expression.Call.FunctionExpression);

            if (obj == null)
            {
                throw CreatePartialFunctionException(expression, obj);
            }

            if (obj.Value is AphidFunction func)
            {
                var paramOffset = Math.Max(func.Args.Length - expression.Call.Args.Count, 0);
                var paramCount = Math.Max(func.Args.Length - paramOffset, 0);
                var callArgs = new List<AphidExpression>(expression.Call.Args.Count + paramCount);

                for (var i = 0; i < expression.Call.Args.Count; i++)
                {
                    callArgs.Add(expression.Call.Args[i]);
                }

                var paramSet = new string[paramCount];

                for (var i = 0; i < paramSet.Length; i++)
                {
                    callArgs.Add(
                        new IdentifierExpression(paramSet[i] = func.Args[paramOffset + i])
                            .WithPositionFrom(expression.Call.Args[i]));
                }

                return Scalar(
                    new AphidFunction(
                        paramSet,
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                retKeyword,
                                new CallExpression(
                                    expression.Call.FunctionExpression,
                                    callArgs)
                                    .WithPositionFrom(expression.Call))
                                .WithPositionFrom(expression.Call)
                        },
                        CurrentScope));
            }

            if (!(obj.Value is AphidInteropMember interopObj))
            {
                throw CreatePartialFunctionException(expression, obj);
            }

            // Todo: Fix partial application bug seemingly caused
            // by unwrapping Object[] when passed during call to partial.
            var applied = new object[expression.Call.Args.Count];

            for (var i = 0; i < applied.Length; i++)
            {
                applied[i] = DeepUnwrap(InterpretExpression(expression.Call.Args[i]));
            }

            return Scalar(new AphidInteropPartialFunction(interopObj, applied));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreatePartialFunctionException(
            PartialFunctionExpression expression,
            AphidObject obj) => CreateExpressionException(
                expression.Call.FunctionExpression,
                obj?.Value,
                "Cannot perform partial function application on");

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretPartialOperatorExpression(PartialOperatorExpression expression) => Scalar(
                new AphidFunction(
                    new[] { "$po" },
                    new List<AphidExpression>
                    {
                        new UnaryOperatorExpression(
                            retKeyword,
                            new BinaryOperatorExpression(
                                new IdentifierExpression("$po")
                                    .WithPositionFrom(expression),
                                expression.Operator,
                                expression.Operand)
                                .WithPositionFrom(expression))
                            .WithPositionFrom(expression)
                    },
                    CurrentScope));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretThisExpression() => CurrentScope;

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretPatternMatchingExpression(PatternMatchingExpression expression)
        {
            var left = InterpretExpression(expression.TestExpression);

            for (var x = 0; x < expression.Patterns.Count; x++)
            {
                var pattern = expression.Patterns[x];

                if (pattern.Patterns != null && pattern.Patterns.Count != 0)
                {
                    for (var y = 0; y < pattern.Patterns.Count; y++)
                    {
                        var patternTest = pattern.Patterns[y];
                        var right = InterpretExpression(patternTest);

                        if (OperatorHelper.Equals(this, left.Value, right.Value))
                        {
                            return InterpretExpression(pattern.Value);
                        }
                    }
                }
                else
                {
                    return InterpretExpression(pattern.Value);
                }
            }

            return InternedNull;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretExtendExpression(ExtendExpression expression) =>
            TypeExtender.Extend(
                expression.ExtendType,
                InterpretObjectExpression(expression.Object),
                GetModifiedKey(expression, "ctor").SingleOrDefault(),
                GetModifiedKey(expression, "dynamic").SingleOrDefault());

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string[] GetModifiedKey(ExtendExpression expression, string modifier)
        {
            var modified = expression.Object.Pairs
                .Where(x =>
                    x.LeftOperand.Type == Exp.IdentifierExpression &&
                    x.LeftOperand
                        .ToIdentifier()
                        .Attributes
                        .Any(y => y.Identifier == modifier))
                .Select(x => x.LeftOperand.ToIdentifier().Identifier)
                .ToArray();

            if (modified.Length > 1)
            {
                throw CreateRuntimeException(
                    "Only one extension can be marked as {0}.",
                    modifier);
            }

            return modified;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretWhileExpression(WhileExpression expression)
        {
            while ((bool)(InterpretExpression(expression.Condition)).Value)
            {
                bool isReturning;
                EnterScope();

                try
                {
                    Interpret(expression.Body, false);
                    _isContinuing = false;
                }
                finally
                {
                    isReturning = LeaveScope(true);
                }

                if (isReturning || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretDoWhileExpression(DoWhileExpression expression)
        {
            do
            {
                bool isReturning;
                EnterScope();

                try
                {
                    Interpret(expression.Body, false);
                    _isContinuing = false;
                }
                finally
                {
                    isReturning = LeaveScope(true);
                }

                if (isReturning || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            } while ((bool)(InterpretExpression(expression.Condition)).Value);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretTryBlock(TryExpression expression)
        {
            EnterScope();

            try
            {
                Interpret(expression.TryBody, false);
            }
            finally
            {
                LeaveScope(true);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretCatchBlock(TryExpression expression, Exception e)
        {
            EnterScope();

            try
            {
                if (expression.CatchArg != null)
                {
                    var ex = Complex();
                    ex.Add("message", Scalar(ExceptionHelper.Unwrap(e).Message));
                    ex.Add("exception", Scalar(e));
                    ex.Add("stack", Scalar(ExceptionHelper.StackTrace(GetRawStackTrace())));

                    CurrentScope.Add(expression.CatchArg.Identifier, ex);
                }

                Interpret(expression.CatchBody, false);
            }
            finally
            {
                LeaveScope(true);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretFinallyBlock(TryExpression expression)
        {
            EnterScope();

            try
            {
                Interpret(expression.FinallyBody, false);
            }
            finally
            {
                LeaveScope(false);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretTryExpression(TryExpression expression)
        {
            var ehBackup = _isInTryCatchFinally;
            _isInTryCatchFinally = true;

            if (expression.FinallyBody == null)
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                catch (Exception e)
                {
#if THROW_INTERNAL_EXCEPTIONS
                    if (e is AphidInternalException)
                    {
                        throw;
                    }
#endif
                    InterpretCatchBlock(expression, e);
                }
            }
            else if (expression.CatchBody != null)
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                catch (Exception e)
                {
#if THROW_INTERNAL_EXCEPTIONS
                    if (e is AphidInternalException)
                    {
                        throw;
                    }
#endif
                    InterpretCatchBlock(expression, e);
                }
                finally
                {
                    InterpretFinallyBlock(expression);
                }
            }
            else
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                finally
                {
                    InterpretFinallyBlock(expression);
                }
            }

            _isInTryCatchFinally = ehBackup;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretTextExpression(TextExpression expression) => WriteOut(expression.Text);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretGatorEmitExpression(GatorEmitExpression expression)
        {
            var obj = InterpretExpression(expression.Expression);

            if (obj == null)
            {
                return;
            }

            var result = Unwrap(obj).ToString();

            if (GatorEmitFilter != null)
            {
                result = GatorEmitFilter(result);
            }

            WriteOut(result);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretTernaryOperatorExpression(TernaryOperatorExpression expression)
        {
#pragma warning disable ERP031 // Some enum cases are not covered by switch statement.
            switch (expression.Operator)
#pragma warning restore ERP031 // Some enum cases are not covered by switch statement.
            {
                case ConditionalOperator:
                    bool conditionResult;
                    var c = InterpretExpression(expression.FirstOperand);

                    try
                    {
                        conditionResult = (bool)c.Value;
                    }
                    catch (InvalidCastException)
                    {
                        throw CreateRuntimeException(
                            "Conditional operator expected boolean, got '{0}' of type '{1}'.",
                            c,
                            c != null ? c.GetType().FullName : "null");
                    }

                    return InterpretExpression(
                        conditionResult ?
                            expression.SecondOperand :
                            expression.ThirdOperand);

                default:
                    throw new InvalidOperationException();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretSwitchExpression(SwitchExpression expression)
        {
            var exp = InterpretExpression(expression.Expression);

            for (var x = 0; x < expression.Cases.Count; x++)
            {
                var c = expression.Cases[x];

                for (var y = 0; y < c.Cases.Count; y++)
                {
                    var c2 = c.Cases[y];
                    var caseValue = InterpretExpression(c2);

                    if (!OperatorHelper.Equals(this, exp.Value, caseValue.Value))
                    {
                        continue;
                    }

                    EnterScope();

                    try
                    {
                        Interpret(c.Body, resetIsReturning: false);
                    }
                    finally
                    {
                        LeaveScope(bubbleReturnValue: true);
                    }

                    return;
                }
            }

            if (expression.DefaultCase != null)
            {
                EnterScope();

                try
                {
                    Interpret(expression.DefaultCase, resetIsReturning: false);
                }
                finally
                {
                    LeaveScope(bubbleReturnValue: true);
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretAndExpression(BinaryOperatorExpression expression)
        {
            if (!(bool)InterpretExpression(expression.LeftOperand).Value)
            {
                return InternedFalse;
            }

            return Scalar((bool)InterpretExpression(expression.RightOperand).Value);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretOrExpression(BinaryOperatorExpression expression)
        {
            if ((bool)InterpretExpression(expression.LeftOperand).Value)
            {
                return InternedTrue;
            }

            return Scalar((bool)InterpretExpression(expression.RightOperand).Value);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretEqualityExpression(BinaryOperatorExpression expression)
        {
            var left = InterpretExpression(expression.LeftOperand);
            var right = InterpretExpression(expression.RightOperand);

            if (expression.Operator == EqualityOperator)
            {
                //bool val;

                if (left == null)
                {
                    throw CreateUndefinedMemberException(expression, expression.LeftOperand);
                }
                else if (right == null)
                {
                    throw CreateUndefinedMemberException(expression, expression.RightOperand);
                }
                else if (left.IsScalar)
                {
                    if (right.IsScalar && OperatorHelper.Equals(this, left.Value, right.Value))
                    {
                        return InternedTrue;
                    }

                    return InternedFalse;
                }
                else if (left.IsComplex)
                {
                    if (left == right)
                    {
                        return InternedTrue;
                    }

                    return InternedFalse;
                }
                else
                {
                    return InternedFalse;
                }
            }
            else
            {
                if (left == null)
                {
                    throw CreateUndefinedMemberException(expression, expression.LeftOperand);
                }
                else if (right == null)
                {
                    throw CreateUndefinedMemberException(expression, expression.RightOperand);
                }
                else if (left.IsScalar)
                {
                    if (right.IsScalar && OperatorHelper.Equals(this, left.Value, right.Value))
                    {
                        return InternedFalse;
                    }

                    return InternedTrue;
                }
                else if (left.IsComplex)
                {
                    if (left == right)
                    {
                        return InternedFalse;
                    }

                    return InternedTrue;
                }
                else
                {
                    return InternedTrue;
                }
            }

            //if (expression.Operator == NotEqualOperator)
            //{
            //    val = !val;
            //}

            //return Scalar(val);
        }

        // Todo: add interop support for dynamic members e.g. Path.{'Combine'}
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretMemberInteropExpression(
            object lhs,
            BinaryOperatorExpression expression,
            bool returnRef = false,
            Func<AphidObject> dynamicHandler = null)
        {
            if (expression.RightOperand.Type != Exp.IdentifierExpression &&
                expression.RightOperand.Type != Exp.DynamicMemberExpression)
            {
                throw CreateRuntimeException(
                    "Invalid member interop access, expected identifier on right-hand " +
                        "side of expression '{0}'.",
                    expression);
            }

            MemberInfo[] members;

            if (lhs != null)
            {
                members = GetInteropInstanceMembers(lhs, expression);
            }
            else
            {
                var path = FlattenPath(expression);

                var type = InteropTypeResolver.ResolveType(
                    GetImports(),
                    _importsLock,
                    path);

                members = GetInteropStaticMembers(type, path);
                TypeInfo nestedTypeInfo;

                if (members.Length == 1 &&
                    (nestedTypeInfo = members[0] as TypeInfo) != null)
                {
                    return Scalar(nestedTypeInfo);
                }
            }

            return InterpretMemberInteropExpression(
                lhs,
                members,
                expression,
                returnRef,
                dynamicHandler);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretMemberInteropExpression(
            object lhs,
            MemberInfo[] members,
            AphidExpression expression,
            bool returnRef = false,
            Func<AphidObject> dynamicHandler = null)
        {
            if (!returnRef && members.Length > 1)
            {
                var isNotFunc = true;

                for (var i = 0; i < members.Length; i++)
                {
                    var t = members[i].GetType();

                    if (!typeof(PropertyInfo).IsAssignableFrom(t) &&
                        !typeof(FieldInfo).IsAssignableFrom(t) &&
                        !typeof(EventInfo).IsAssignableFrom(t))
                    {
                        isNotFunc = false;
                        break;
                    }
                }

                if (isNotFunc)
                {
                    members = new[] { members[0] };
                }
            }

            if (members.Length == 1)
            {
                var propInfo = members[0] as PropertyInfo;

                if (propInfo != null)
                {
                    if (!returnRef)
                    {
                        if (propInfo.PropertyType != typeof(AphidObject))
                        {
                            if (!propInfo.PropertyType.IsAssignableFrom(typeof(AphidObject)))
                            {
                                return Scalar(propInfo.GetValue(lhs));
                            }

                            return Wrap(propInfo.GetValue(lhs));
                        }

                        return (AphidObject)propInfo.GetValue(lhs);
                    }

                    return Scalar(new AphidInteropReference(lhs, propInfo));
                }

                var fieldInfo = members[0] as FieldInfo;

                if (fieldInfo != null)
                {
                    if (!returnRef)
                    {
                        if (fieldInfo.FieldType != typeof(AphidObject))
                        {
                            if (!fieldInfo.FieldType.IsAssignableFrom(typeof(AphidObject)))
                            {
                                return Scalar(fieldInfo.GetValue(lhs));
                            }

                            return Wrap(fieldInfo.GetValue(lhs));
                        }

                        return (AphidObject)fieldInfo.GetValue(lhs);
                    }

                    return Scalar(new AphidInteropReference(lhs, fieldInfo));
                }
            }
            else if (members.Length == 0)
            {
                if (dynamicHandler == null)
                {
                    throw CreateRuntimeException(
                        "Could not find property '{0}'",
                        expression);
                }

                return dynamicHandler();
            }

            return Scalar(new AphidInteropMember(expression, lhs, members));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCallExpression(CallExpression expression)
        {
            var obj = InterpretExpression(expression.FunctionExpression) ??
                throw CreateUndefinedFunctionException(
                    expression,
                    expression.FunctionExpression);

            var func = obj.Value;
            var args = new object[expression.Args.Count];

            for (var i = 0; i < expression.Args.Count; i++)
            {
                args[i] = InterpretExpression(expression.Args[i]);
            }

            return InterpretCallExpression(expression, expression.FunctionExpression, func, args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCallExpression(
            AphidExpression callExpression,
            AphidExpression functionExpression,
            object funcExp,
            object[] args)
        {
            switch (funcExp)
            {
                case AphidInteropFunction func:
                    var interopArgs = args;

                    if (func.UnwrapParameters)
                    {
                        for (var i = 0; i < args.Length; i++)
                        {
                            interopArgs[i] = Unwrap(interopArgs[i]);
                        }
                    }

                    PushFrame(callExpression, functionExpression, interopArgs);

                    try
                    {
                        return Wrap(func.Invoke(this, interopArgs));
                    }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                            while (_queuedFramePops > 0)
                            {
                                _frames.Pop();
                                _queuedFramePops--;
                            }
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, this);
                            e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                            e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                        }

                        throw;
                    }
#endif
                    finally
                    {
                        PopFrame();
                    }
                case AphidInteropMember interopMembers:
                    return InterpretInteropCallExpression(
                        callExpression,
                        functionExpression,
                        DeepUnwrapObjectArrayRef(args),
                        interopMembers);

                case AphidInteropPartialFunction interopPartial:
                    return InterpretInteropCallExpression(
                        callExpression,
                        functionExpression,
                        interopPartial.Applied
                            .Concat(DeepUnwrapObjectArrayRef(args))
                            .ToArray(),
                        interopPartial.Member);

                case Delegate del:
                    PushFrame(callExpression, functionExpression, args);

                    try
                    {
                        return Wrap(del.DynamicInvoke(UnwrapObjectArrayRef(args)));
                    }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                            while (_queuedFramePops > 0)
                            {
                                _frames.Pop();
                                _queuedFramePops--;
                            }
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, this);
                            e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                            e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                        }

                        throw;
                    }
#endif
                    finally
                    {
                        PopFrame();
                    }

                case AphidFunction aphidFunc:
                    PushFrame(callExpression, functionExpression, args);

                    try
                    {
                        return CallFunctionCore(aphidFunc, WrapObjectArray(args));
                    }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                            while (_queuedFramePops > 0)
                            {
                                _frames.Pop();
                                _queuedFramePops--;
                            }
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, this);
                            e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                            e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                        }

                        throw;
                    }
#endif
                    finally
                    {
                        PopFrame();
                    }

                case AphidFunctionComposition composition:
                    var retVal = InterpretCallExpression(
                        callExpression,
                        composition.LeftExpression,
                        composition.LeftFunction,
                        args);

                    return InterpretCallExpression(
                        callExpression,
                        composition.RightExpression,
                        composition.RightFunction,
                        new object[] { retVal });

                default:
                    object refObj;
                    AphidInteropReference memberRef;
                    AphidObject extObj;
                    AphidFunction func2;

                    if (functionExpression.Type == Exp.BinaryOperatorExpression &&
                        (refObj = InterpretMemberExpression(
                            (BinaryOperatorExpression)functionExpression,
                            returnRef: true)) != null &&
                        (memberRef = Unwrap(refObj) as AphidInteropReference) != null)
                    {
                        if (((extObj = TryResolve(
                                CurrentScope,
                                Wrap(memberRef.Object),
                                memberRef.Name,
                                isAphidType: false,
                                isCtor: false,
                                isDynamic: false,
                                returnRef: false)) != null &&
                            (func2 = extObj.Value as AphidFunction) != null) ||
                            ((extObj = TryResolve(
                                CurrentScope,
                                Wrap(memberRef.Object),
                                memberRef.Name,
                                isAphidType: false,
                                isCtor: false,
                                isDynamic: true,
                                returnRef: false)) != null &&
                            (func2 = extObj.Value as AphidFunction) != null))
                        {
                            PushFrame(callExpression, functionExpression, args);

                            try
                            {
                                return CallFunctionCore(
                                    func2,
                                    WrapObjectArray(args));
                            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                            catch (Exception e)
#else
                            catch
#endif
                            {
                                if (e.Source != AphidName.DebugInterpreter)
                                {
                                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                                    while (_queuedFramePops > 0)
                                    {
                                        _frames.Pop();
                                        _queuedFramePops--;
                                    }
#endif

#if APHID_FRAME_ADD_DATA
                                    e.Data.Add(AphidName.Interpreter, this);
                                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                                }

                                throw;
                            }
#endif
                            finally
                            {
                                PopFrame();
                            }
                        }
                    }

                    break;
            }

            throw CreateRuntimeException("Could not find function {0}", functionExpression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretImplicitArgumentExpression() =>
            CurrentScope.Resolve(this, AphidName.ImplicitArg);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretImplicitArgumentsExpression() =>
            CurrentScope.Resolve(
                this,
                AphidName.ImplicitArgs,
                "$args cannot be used outside of function.");

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretInteropCallExpression(
            AphidExpression callExpression,
            AphidExpression functionExpression,
            object[] arguments,
            AphidInteropMember interopMembers)
        {
            var methodInfo = InteropMethodResolver.Resolve(
                interopMembers.Members.OfType<MethodInfo>().ToArray(),
                arguments);

            MethodBase method;

            if (!methodInfo.Method.IsGenericMethod)
            {
                method = methodInfo.Method;
            }
            else
            {
                method = ((MethodInfo)methodInfo.Method).MakeGenericMethod(methodInfo.GenericArguments);
            }

            var convertedArgs = TypeConverter.Convert(
                methodInfo.Arguments,
                methodInfo.GenericArguments);

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            

            PushFrame(
                callExpression,
                new Lazy<string>(() =>
                    Format(
                        "{0}.{1}",
                        AphidType.TypeToString(method.DeclaringType, true, new StringBuilder()),
                        method.Name)),
                convertedArgs);
#else
            PushFrame(
                callExpression,
                functionExpression,
                //new Lazy<string>(() =>
                //    Format(
                //        "{0}.{1}",
                //        AphidType.TypeToString(method.DeclaringType),
                //        method.Name)),
                convertedArgs);
#endif

            try
            {
                return Wrap(
                    method.Invoke(
                        interopMembers.Target,
                        convertedArgs));
            }
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
            catch (Exception e)
#else
            catch
#endif
            {
                if (e.Source != AphidName.DebugInterpreter)
                {
                    e.Source = AphidName.DebugInterpreter;
#if APHID_FRAME_CATCH_POP
                    while (_queuedFramePops > 0)
                    {
                        _frames.Pop();
                        _queuedFramePops--;
                    }
#endif

#if APHID_FRAME_ADD_DATA
                    e.Data.Add(AphidName.Interpreter, this);
                    e.Data.Add(AphidName.FramesKey, GetRawStackTrace());
#if TRACK_PREVIOUS_SCOPE
                    e.Data.Add(AphidName.Scope, PreviousScope);
#endif
#endif
                }

                throw;
            }
#endif
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretObjectExpression(ObjectExpression expression)
        {
            if (OnInterpretObject != null && !OnInterpretObjectExecuting)
            {
                OnInterpretObjectExecuting = true;
                try
                {
                    AphidExecutionContext<ObjectExpression> ctx = expression;
                    OnInterpretObject(ctx);

                    if (ctx.IsHandled)
                    {
                        return ctx.Result;
                    }
                    else if (ctx.IsModified)
                    {
                        expression = ctx.Expression;
                    }
                }
                finally
                {
                    OnInterpretObjectExecuting = false;
                }
            }

            if (expression.Identifier == null ||
                expression.Identifier.Attributes == null ||
                expression.Identifier.Attributes.Count == 0 ||
                expression.Identifier.Attributes[0].Identifier != AphidName.Class)
            {
                var parent = CurrentScope;
                var obj = Scope(parent);
                CurrentScope = obj;

                try
                {
                    foreach (var kvp in expression.Pairs)
                    {
                        var objectKey = kvp.LeftOperand.Type == Exp.IdentifierExpression ?
                            kvp.LeftOperand.ToIdentifier().Identifier :
                            InterpretExpression(kvp.LeftOperand).Value.ToString();

                        var objectValue = InterpretExpression(kvp.RightOperand);

                        if (objectValue.Value == null)
                        {
                            obj.Add(objectKey, objectValue);
                        }
                        else
                        {
                            obj.Add(objectKey, Scalar(objectValue.Value));
                        }
                    }

                    if (CurrentScope.Parent == null)
                    {
                        throw CreateInternalException(
                            "Internal error leaving scope, parent scope is null.");
                    }
                }
                finally
                {
                    CurrentScope = parent;
                }

                return obj;
            }

            return Scalar(AsmBuilder.CreateType(expression, GetImports()));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIdentifierExpression(IdentifierExpression expression) =>
            InterpretIdentifierExpression(expression, canResolveType: true);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIdentifierExpression(
            IdentifierExpression expression,
            bool canResolveType)
        {
            if (CurrentScope.TryResolve(expression.Identifier, out var obj))
            {
                return obj;
            }
            else if (canResolveType)
            {
                Type t;
                //_importsLock.EnterReadLock();

                //try
                //{
                if ((t = InteropTypeResolver.TryResolveType(
                    GetImports(),
                    _importsLock,
                    new[] { expression.Identifier },
                    isType: true)) == null)
                {
                    return null;
                }
                //}
                //finally
                //{
                //    _importsLock.ExitReadLock();
                //}

                return Scalar(t);
            }
            else //if (!StrictMode)
            {
                return null;
            }
            //else
            //{
            //    throw CreateStrictModeException(expression.Identifier);
            //}
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static AphidObject InterpretStringExpression(StringExpression expression) =>
            Scalar(StringParser.Parse(expression.Value));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretMemberExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            // Todo: cleanup and improve perf by evaluating and saving key early
            var obj = InterpretExpression(expression.LeftOperand);
            var key = GetMemberKey(expression.RightOperand);
            Type type;
            AphidObject val;

            if (obj != null)
            {
                if (expression.RightOperand.Type == Exp.IdentifierExpression ||
                    expression.RightOperand.Type == Exp.DynamicMemberExpression)
                {
                    var interopMember = InteropMethodResolver.TryResolveMember(
                        expression,
                        obj,
                        returnRef);

                    if (interopMember != null)
                    {
                        return interopMember;
                    }
                }

                if (obj.IsScalar)
                {
                    if ((type = obj.Value as Type) != null)
                    {
                        if (!type.Assembly.IsDynamic)
                        {
                            var members = GetInteropStaticMembers(type, key);

                            if (members.Length != 0)
                            {
                                if (!(members[0] is Type nestedType))
                                {
                                    return InterpretMemberInteropExpression(
                                        null,
                                        members,
                                        expression,
                                        returnRef,
                                        null);
                                }

                                return Scalar(nestedType);
                            }

                            members = GetInteropInstanceMembers(type, key);

                            if (members.Length != 0)
                            {
                                return InterpretMemberInteropExpression(
                                    type,
                                    members,
                                    expression,
                                    returnRef,
                                    null);
                            }
                        }
                        else
                        {
                            var members = GetInteropInstanceMembers(type, key);

                            if (members.Length != 0)
                            {
                                return InterpretMemberInteropExpression(
                                    type,
                                    members,
                                    expression,
                                    returnRef,
                                    null);
                            }

                            members = GetInteropStaticMembers(type, key);

                            if (members.Length != 0)
                            {
                                if (!(members[0] is Type nestedType))
                                {
                                    return InterpretMemberInteropExpression(
                                        null,
                                        members,
                                        expression,
                                        returnRef,
                                        null);
                                }

                                return Scalar(nestedType);
                            }
                        }

                        var ext = TryResolve(
                            CurrentScope,
                            type,
                            key: key,
                            isAphidType: false,
                            isCtor: false,
                            isDynamic: false,
                            returnRef: returnRef);

                        if (ext == null)
                        {
                            throw CreateMemberException(key, obj, expression);
                        }

                        return ext;
                    }
                    else if (returnRef)
                    {
                        if (obj.Value != null)
                        {
                            throw CreateRuntimeException(
                                "Cannot resolve member '{0}' for value '{1}' of type " +
                                    "'{2}' from expression '{3}'.",
                                key,
                                obj.Value,
                                obj.Value.GetType(),
                                expression.ToString().Trim());
                        }

                        throw CreateRuntimeException(
                            "Cannot resolve member '{0}' for null value from " +
                                "expression '{1}'.",
                            key,
                            expression.ToString().Trim());
                    }
                    else if (obj.Value != null)
                    {
                        var aphidType = obj.IsAphidType();

                        if ((val = TryResolve(
                            CurrentScope,
                            obj,
                            key,
                            isAphidType: aphidType,
                            isCtor: false,
                            isDynamic: false,
                            returnRef: returnRef)) != null)
                        {
                            return val;
                        }
                        else if ((val = InterpretMemberInteropExpression(
                            obj.Value,
                            expression,
                            returnRef,
                            () => TryResolve(
                                CurrentScope,
                                obj,
                                key,
                                isAphidType: aphidType,
                                isCtor: false,
                                isDynamic: true,
                                returnRef: returnRef))) != null)
                        {
                            return val;
                        }
                        else
                        {
                            throw CreateMemberException(key, obj, expression);
                        }
                    }
                    else if (expression.LeftOperand.Type == Exp.IdentifierExpression)
                    {
                        return InterpretMemberInteropExpression(null, expression, returnRef);
                    }
                    else
                    {
                        throw CreateRuntimeException("Null reference exception: {0}.", expression);
                    }
                }
                else if (returnRef)
                {
                    return new AphidRef { Name = key, Object = obj };
                }
                else if (obj.TryResolve(key, out val))
                {
                    return val;
                }
                else if ((val = InterpretMemberInteropExpression(
                    obj,
                    expression,
                    returnRef,
                    () => TryResolve(
                        CurrentScope,
                        obj,
                        key,
                        isAphidType: true,
                        isCtor: false,
                        isDynamic: false,
                        returnRef: returnRef))) != null)
                {
                    return val;
                }
                else
                {
                    throw CreateMemberException(key, obj, expression);
                }
            }
            else
            {
                throw CreateMemberException(key, obj, expression);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretAssignmentExpression(BinaryOperatorExpression expression) =>
            InterpretAssignmentExpression(
                expression.LeftOperand,
                InterpretExpression(expression.RightOperand),
                expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretAssignmentExpression(
            AphidExpression destinationExpression,
            AphidObject value,
            AphidExpression completeExpression = null)
        {
            //var value = InterpretExpression(expression.RightOperand);
            var value2 = value ?? InternedNull;

            if (destinationExpression.Type == Exp.IdentifierExpression)
            {
                var idExp = (IdentifierExpression)destinationExpression;
                var id = idExp.Identifier;

                if (idExp.Attributes.Count == 0 ||
                    idExp.Attributes[0].Identifier != AphidName.Var)
                {
                    var destObj = InterpretIdentifierExpression(idExp, canResolveType: false);

                    if (destObj == null)
                    {
                        if (!StrictMode)
                        {
                            CurrentScope.Add(id, value2);
                        }
                        else
                        {
                            throw CreateStrictModeException(id);
                        }
                    }
                    else
                    {
                        var parent = CurrentScope.TryResolveParent(id);
                        parent[id] = value2;
                    }
                }
                else
                {
                    if (!CurrentScope.ContainsKey(id))
                    {
                        if (value2.IsComplex)
                        {
                            CurrentScope.Add(id, value2);
                        }
                        else
                        {
                            CurrentScope.Add(id, Scalar(value2.Value));
                        }
                    }
                    else
                    {
                        throw CreateRuntimeException(
                            "Variable '{0}' has already been defined in the current scope.",
                            id);
                    }
                }

                return value2;
            }
            else if (destinationExpression.Type == Exp.ArrayAccessExpression)
            {
                var arrayAccessExp = (ArrayAccessExpression)destinationExpression;
                var targetObj = InterpretExpression(arrayAccessExp.ArrayExpression);
                var targetObjUnwrapped = Unwrap(targetObj);

                var keyObjects = new object[arrayAccessExp.KeyExpressions.Count];

                for (var i = 0; i < keyObjects.Length; i++)
                {
                    keyObjects[i] = InterpretExpression(arrayAccessExp.KeyExpressions[i]).Value;
                }

                if (keyObjects.Length != 1)
                {
                    throw CreateRuntimeException("Multi-dimensional arrays not yet supported.");
                }

                var keyObj = keyObjects[0];

                if (targetObjUnwrapped is Array targetArray)
                {
                    targetArray.SetValue(
                        ChangeType(
                            value2.Value,
                            targetArray.GetType().GetElementType()),
                        ToInt32(keyObj));
                }
                else if (targetObjUnwrapped is List<AphidObject> targetAphidList)
                {
                    if (value2.Count == 0 && value2.Value != null)
                    {
                        value = value2 = Scalar(value2.Value);
                    }

                    targetAphidList[ToInt32(keyObj)] = value2;
                }
                else if (targetObjUnwrapped is AphidObject aphidObj)
                {
                    if (keyObj == null || !(keyObj is string key))
                    {
                        throw CreateRuntimeException(
                            "Expected string for object key, encountered {0}.",
                            keyObj != null ? keyObj.GetType().FullName : "null");
                    }
                    else if (aphidObj.IsScalar)
                    {
                        if (aphidObj.Value == null)
                        {
                            throw CreateRuntimeException(
                                "Cannot set key value for null, object expected.");
                        }

                        var members = GetInteropInstanceMembers(aphidObj.Value, key);

                        //#if CHECKED
                        if (members.Length > 1)
                        {
                            throw CreateInternalException($"More than one interop instance member {key}");
                        }
                        //#endif

                        for (var i = 0; i < members.Length; i++)
                        {
                            switch (members[i])
                            {
                                case PropertyInfo prop:
                                    prop.SetValue(aphidObj.Value, value2);
                                    break;

                                case FieldInfo field:
                                    field.SetValue(aphidObj.Value, value2);
                                    break;
                            }
                        }
                    }
                    else if (aphidObj.ContainsKey(key))
                    {
                        aphidObj[key] = value2;
                    }
                    else
                    {
                        aphidObj.Add(key, value2);
                    }
                }
                else
                {
                    var targetType = targetObjUnwrapped.GetType();
                    var listType = targetType.GetInterface("System.Collections.Generic.IList`1", false);

                    if (listType != null)
                    {
                        var valueType = listType.GenericTypeArguments[0];
                        var list = (dynamic)targetObjUnwrapped;

                        list[ToInt32(keyObj)] = (dynamic)ChangeType(value2.Value, valueType);
                    }
                    else
                    {
                        throw CreateRuntimeException("Could not set value by index.");
                    }
                }
            }
            else if (destinationExpression.Type == Exp.BinaryOperatorExpression)
            {
                var destBinOp = (BinaryOperatorExpression)destinationExpression;
                var obj = InterpretBinaryOperatorExpression(destBinOp, true);

                if (obj is AphidRef objRef)
                {
                    if (objRef.Object == null)
                    {
                        throw CreateRuntimeException("Undefined variable {0}", destinationExpression);
                    }
                    else if (objRef.Object.ContainsKey(objRef.Name))
                    {
                        if (value2.IsComplex)
                        {
                            objRef.Object[objRef.Name] = value2;
                        }
                        else
                        {
                            objRef.Object[objRef.Name] = Scalar(value2.Value);

                            if (value2.Value is AphidFunction func)
                            {
                                func.ParentScope = objRef.Object;
                            }
                        }
                    }
                    else
                    {
                        if (value2.IsComplex)
                        {
                            objRef.Object.Add(objRef.Name, value2);
                        }
                        else
                        {
                            objRef.Object.Add(objRef.Name, Scalar(value2.Value));

                            if (value2.Value is AphidFunction func)
                            {
                                func.ParentScope = objRef.Object;
                            }
                        }
                    }

                    return value2;
                }

                if (!(Unwrap(obj) is AphidInteropReference interopRef))
                {
                    obj = InterpretMemberInteropExpression(null, destBinOp, returnRef: true);
                    interopRef = Unwrap(obj) as AphidInteropReference;
                }

                if (interopRef != null)
                {
                    var v = value2.Value;

                    if (interopRef.Field != null)
                    {
                        interopRef.Field.SetValue(
                            interopRef.Object,
                            TypeConverter.Convert(interopRef.Field.FieldType, v, null));
                    }
                    else
                    {
                        interopRef.Property.SetValue(
                            interopRef.Object,
                            v != null ?
                                TypeConverter.Convert(interopRef.Property.PropertyType, v, null) :
                                null);
                    }

                    if (value2.Value is AphidFunction func)
                    {
                        if (interopRef.Object is AphidObject ao)
                        {
                            func.ParentScope = ao;
                        }
                        else
                        {
                            func.ParentScope = CurrentScope;
                        }
                    }

                    return value2;
                }
            }
            else
            {
                throw CreateRuntimeException(
                    "Invalid left hand side of assignment expression: {0}",
                    completeExpression ?? destinationExpression);
            }

            return value2;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterprentOperatorAndAssignmentExpression(
            Func<AphidObject, AphidObject, AphidObject> performOperation,
            BinaryOperatorExpression expression) =>
            InterpretAssignmentExpression(
                expression.LeftOperand,
                performOperation(
                    InterpretExpression(expression.LeftOperand),
                    InterpretExpression(expression.RightOperand)),
                completeExpression: expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretBinaryOperatorExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            switch (expression.Operator)
            {
                case AdditionOperator:
                    return OperatorHelper.Add(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case MinusOperator:
                    return OperatorHelper.Subtract(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case MultiplicationOperator:
                    return OperatorHelper.Multiply(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case DivisionOperator:
                    return OperatorHelper.Divide(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case MemberOperator:
                    return InterpretMemberExpression(expression, returnRef);

                case AssignmentOperator:
                    return InterpretAssignmentExpression(expression);

                case PlusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Add, expression);

                case MinusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Subtract, expression);

                case MultiplicationEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Multiply, expression);

                case DivisionEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Divide, expression);

                case ModulusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Mod, expression);

                case BinaryAndEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryAnd, expression);

                case OrEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryOr, expression);

                case XorEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Xor, expression);

                case ShiftLeftEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftLeft, expression);

                case ShiftRightEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftRight, expression);

                case NotEqualOperator:
                case EqualityOperator:
                    return InterpretEqualityExpression(expression);

                case LessThanOperator:
                    return Scalar(
                        ToDecimal(InterpretExpression(expression.LeftOperand).Value) <
                        ToDecimal(InterpretExpression(expression.RightOperand).Value));

                case LessThanOrEqualOperator:
                    return Scalar(
                        ToDecimal(InterpretExpression(expression.LeftOperand).Value) <=
                        ToDecimal(InterpretExpression(expression.RightOperand).Value));

                case GreaterThanOperator:
                    return Scalar(
                        ToDecimal(InterpretExpression(expression.LeftOperand).Value) >
                        ToDecimal(InterpretExpression(expression.RightOperand).Value));

                case GreaterThanOrEqualOperator:
                    return Scalar(
                        ToDecimal(InterpretExpression(expression.LeftOperand).Value) >=
                        ToDecimal(InterpretExpression(expression.RightOperand).Value));

                case AndOperator:
                    return InterpretAndExpression(expression);

                case OrOperator:
                    return InterpretOrExpression(expression);

                case ModulusOperator:
                    return OperatorHelper.Mod(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case ShiftLeft:
                    return OperatorHelper.BinaryShiftLeft(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case ShiftRight:
                    return OperatorHelper.BinaryShiftRight(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case BinaryAndOperator:
                    return OperatorHelper.BinaryAnd(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case BinaryOrOperator:
                    AphidObject pipeLhs = InterpretExpression(expression.LeftOperand),
                        pipeRhs = InterpretExpression(expression.RightOperand);

                    if (pipeRhs == null)
                    {
                        throw CreateUndefinedFunctionException(expression, expression.RightOperand);
                    }

                    return pipeRhs.Value is IAphidCallable ?
                        InterpretCallExpression(
                            expression,
                            expression.RightOperand,
                            pipeRhs.Value,
                            new object[] { pipeLhs }) :
                        OperatorHelper.BinaryOr(pipeLhs, pipeRhs);

                case XorOperator:
                    return OperatorHelper.Xor(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case PipelineOperator:
                    return InterpretCallExpression(
                        (CallExpression)new CallExpression(
                            expression.RightOperand,
                            expression.LeftOperand)
                                .WithPositionFrom(expression));

                case RangeOperator:
                    return OperatorHelper.Range(
                        InterpretExpression(expression.LeftOperand),
                        InterpretExpression(expression.RightOperand));

                case SelectOperator:
                    var collection = InterpretExpression(expression.LeftOperand).Value;
                    var func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Select(x =>
                                InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x }))
                            .ToList());

                case SelectManyOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .SelectMany(x =>
                                (IEnumerable<object>)(Unwrap(
                                    InterpretCallExpression(
                                        expression,
                                        expression.RightOperand,
                                        func,
                                        new object[] { x }))))
                            .Select(Wrap)
                            .ToList());

                case GroupByOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .GroupBy(x => Unwrap(
                                InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x }))));

                case AggregateOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Wrap(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Aggregate((x, y) =>
                                InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x, y })));

                case AnyOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Any(x =>
                                (bool)InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x })
                                    .Value));

                case WhereOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Where(x =>
                                (bool)InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x })
                                    .Value));

                case CountOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Count(x =>
                                (bool)InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x })
                                    .Value));

                case OrderByOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .OrderBy(x => Unwrap(
                                InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x }))));

                case OrderByDescendingOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .OrderByDescending(x => Unwrap(
                                InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x }))));

                case FirstOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Wrap(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .First(x =>
                                (bool)InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x })
                                    .Value));

                case LastOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;
                    func = InterpretExpression(expression.RightOperand).Value;

                    return Wrap(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Last(x =>
                                (bool)InterpretCallExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new object[] { x })
                                    .Value));

                case StartsWithOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;

                    var pattern =
                        Unwrap(InterpretExpression(expression.RightOperand))
                        .ToString();

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Where(x =>
                            {
                                var v = Unwrap(x);

                                return v?.ToString().StartsWith(pattern) == true;
                            }));

                case EndsWithOperator:
                    collection = InterpretExpression(expression.LeftOperand).Value;

                    pattern =
                        Unwrap(InterpretExpression(expression.RightOperand))
                        .ToString();

                    return Scalar(
                        ((IEnumerable)collection)
                            .Cast<object>()
                            .Where(x =>
                            {
                                var v = Unwrap(x);

                                return v?.ToString().EndsWith(pattern) == true;
                            }));

                case CompositionOperator:
                    return InterpretFunctionComposition(expression);

                #region Custom Operator Cases
                case AphidTokenType.CustomOperator000:
                case AphidTokenType.CustomOperator001:
                case AphidTokenType.CustomOperator002:
                case AphidTokenType.CustomOperator003:
                case AphidTokenType.CustomOperator004:
                case AphidTokenType.CustomOperator005:
                case AphidTokenType.CustomOperator006:
                case AphidTokenType.CustomOperator007:
                case AphidTokenType.CustomOperator008:
                case AphidTokenType.CustomOperator009:
                case AphidTokenType.CustomOperator010:
                case AphidTokenType.CustomOperator011:
                case AphidTokenType.CustomOperator012:
                case AphidTokenType.CustomOperator013:
                case AphidTokenType.CustomOperator014:
                case AphidTokenType.CustomOperator015:
                case AphidTokenType.CustomOperator016:
                case AphidTokenType.CustomOperator017:
                case AphidTokenType.CustomOperator018:
                case AphidTokenType.CustomOperator019:
                case AphidTokenType.CustomOperator020:
                case AphidTokenType.CustomOperator021:
                case AphidTokenType.CustomOperator022:
                case AphidTokenType.CustomOperator023:
                case AphidTokenType.CustomOperator024:
                case AphidTokenType.CustomOperator025:
                case AphidTokenType.CustomOperator026:
                case AphidTokenType.CustomOperator027:
                case AphidTokenType.CustomOperator028:
                case AphidTokenType.CustomOperator029:
                case AphidTokenType.CustomOperator030:
                case AphidTokenType.CustomOperator031:
                case AphidTokenType.CustomOperator032:
                case AphidTokenType.CustomOperator033:
                case AphidTokenType.CustomOperator034:
                case AphidTokenType.CustomOperator035:
                case AphidTokenType.CustomOperator036:
                case AphidTokenType.CustomOperator037:
                case AphidTokenType.CustomOperator038:
                case AphidTokenType.CustomOperator039:
                case AphidTokenType.CustomOperator040:
                case AphidTokenType.CustomOperator041:
                case AphidTokenType.CustomOperator042:
                case AphidTokenType.CustomOperator043:
                case AphidTokenType.CustomOperator044:
                case AphidTokenType.CustomOperator045:
                case AphidTokenType.CustomOperator046:
                case AphidTokenType.CustomOperator047:
                case AphidTokenType.CustomOperator048:
                case AphidTokenType.CustomOperator049:
                case AphidTokenType.CustomOperator050:
                case AphidTokenType.CustomOperator051:
                case AphidTokenType.CustomOperator052:
                case AphidTokenType.CustomOperator053:
                case AphidTokenType.CustomOperator054:
                case AphidTokenType.CustomOperator055:
                case AphidTokenType.CustomOperator056:
                case AphidTokenType.CustomOperator057:
                case AphidTokenType.CustomOperator058:
                case AphidTokenType.CustomOperator059:
                case AphidTokenType.CustomOperator060:
                case AphidTokenType.CustomOperator061:
                case AphidTokenType.CustomOperator062:
                case AphidTokenType.CustomOperator063:
                case AphidTokenType.CustomOperator064:
                case AphidTokenType.CustomOperator065:
                case AphidTokenType.CustomOperator066:
                case AphidTokenType.CustomOperator067:
                case AphidTokenType.CustomOperator068:
                case AphidTokenType.CustomOperator069:
                case AphidTokenType.CustomOperator070:
                case AphidTokenType.CustomOperator071:
                case AphidTokenType.CustomOperator072:
                case AphidTokenType.CustomOperator073:
                case AphidTokenType.CustomOperator074:
                case AphidTokenType.CustomOperator075:
                case AphidTokenType.CustomOperator076:
                case AphidTokenType.CustomOperator077:
                case AphidTokenType.CustomOperator078:
                case AphidTokenType.CustomOperator079:
                case AphidTokenType.CustomOperator080:
                case AphidTokenType.CustomOperator081:
                case AphidTokenType.CustomOperator082:
                case AphidTokenType.CustomOperator083:
                case AphidTokenType.CustomOperator084:
                case AphidTokenType.CustomOperator085:
                case AphidTokenType.CustomOperator086:
                case AphidTokenType.CustomOperator087:
                case AphidTokenType.CustomOperator088:
                case AphidTokenType.CustomOperator089:
                case AphidTokenType.CustomOperator090:
                case AphidTokenType.CustomOperator091:
                case AphidTokenType.CustomOperator092:
                case AphidTokenType.CustomOperator093:
                case AphidTokenType.CustomOperator094:
                case AphidTokenType.CustomOperator095:
                case AphidTokenType.CustomOperator096:
                case AphidTokenType.CustomOperator097:
                case AphidTokenType.CustomOperator098:
                case AphidTokenType.CustomOperator099:
                case AphidTokenType.CustomOperator100:
                case AphidTokenType.CustomOperator101:
                case AphidTokenType.CustomOperator102:
                case AphidTokenType.CustomOperator103:
                case AphidTokenType.CustomOperator104:
                case AphidTokenType.CustomOperator105:
                case AphidTokenType.CustomOperator106:
                case AphidTokenType.CustomOperator107:
                case AphidTokenType.CustomOperator108:
                case AphidTokenType.CustomOperator109:
                case AphidTokenType.CustomOperator110:
                case AphidTokenType.CustomOperator111:
                case AphidTokenType.CustomOperator112:
                case AphidTokenType.CustomOperator113:
                case AphidTokenType.CustomOperator114:
                case AphidTokenType.CustomOperator115:
                case AphidTokenType.CustomOperator116:
                case AphidTokenType.CustomOperator117:
                case AphidTokenType.CustomOperator118:
                case AphidTokenType.CustomOperator119:
                case AphidTokenType.CustomOperator120:
                case AphidTokenType.CustomOperator121:
                case AphidTokenType.CustomOperator122:
                case AphidTokenType.CustomOperator123:
                case AphidTokenType.CustomOperator124:
                case AphidTokenType.CustomOperator125:
                case AphidTokenType.CustomOperator126:
                case AphidTokenType.CustomOperator127:
                case AphidTokenType.CustomOperator128:
                case AphidTokenType.CustomOperator129:
                case AphidTokenType.CustomOperator130:
                case AphidTokenType.CustomOperator131:
                case AphidTokenType.CustomOperator132:
                case AphidTokenType.CustomOperator133:
                case AphidTokenType.CustomOperator134:
                case AphidTokenType.CustomOperator135:
                case AphidTokenType.CustomOperator136:
                case AphidTokenType.CustomOperator137:
                case AphidTokenType.CustomOperator138:
                case AphidTokenType.CustomOperator139:
                case AphidTokenType.CustomOperator140:
                case AphidTokenType.CustomOperator141:
                case AphidTokenType.CustomOperator142:
                case AphidTokenType.CustomOperator143:
                case AphidTokenType.CustomOperator144:
                case AphidTokenType.CustomOperator145:
                case AphidTokenType.CustomOperator146:
                case AphidTokenType.CustomOperator147:
                case AphidTokenType.CustomOperator148:
                case AphidTokenType.CustomOperator149:
                case AphidTokenType.CustomOperator150:
                case AphidTokenType.CustomOperator151:
                case AphidTokenType.CustomOperator152:
                case AphidTokenType.CustomOperator153:
                case AphidTokenType.CustomOperator154:
                case AphidTokenType.CustomOperator155:
                case AphidTokenType.CustomOperator156:
                case AphidTokenType.CustomOperator157:
                case AphidTokenType.CustomOperator158:
                case AphidTokenType.CustomOperator159:
                case AphidTokenType.CustomOperator160:
                case AphidTokenType.CustomOperator161:
                case AphidTokenType.CustomOperator162:
                case AphidTokenType.CustomOperator163:
                case AphidTokenType.CustomOperator164:
                case AphidTokenType.CustomOperator165:
                case AphidTokenType.CustomOperator166:
                case AphidTokenType.CustomOperator167:
                case AphidTokenType.CustomOperator168:
                case AphidTokenType.CustomOperator169:
                case AphidTokenType.CustomOperator170:
                case AphidTokenType.CustomOperator171:
                case AphidTokenType.CustomOperator172:
                case AphidTokenType.CustomOperator173:
                case AphidTokenType.CustomOperator174:
                case AphidTokenType.CustomOperator175:
                case AphidTokenType.CustomOperator176:
                case AphidTokenType.CustomOperator177:
                case AphidTokenType.CustomOperator178:
                case AphidTokenType.CustomOperator179:
                case AphidTokenType.CustomOperator180:
                case AphidTokenType.CustomOperator181:
                case AphidTokenType.CustomOperator182:
                case AphidTokenType.CustomOperator183:
                case AphidTokenType.CustomOperator184:
                case AphidTokenType.CustomOperator185:
                case AphidTokenType.CustomOperator186:
                case AphidTokenType.CustomOperator187:
                case AphidTokenType.CustomOperator188:
                case AphidTokenType.CustomOperator189:
                case AphidTokenType.CustomOperator190:
                case AphidTokenType.CustomOperator191:
                case AphidTokenType.CustomOperator192:
                case AphidTokenType.CustomOperator193:
                case AphidTokenType.CustomOperator194:
                case AphidTokenType.CustomOperator195:
                case AphidTokenType.CustomOperator196:
                case AphidTokenType.CustomOperator197:
                case AphidTokenType.CustomOperator198:
                case AphidTokenType.CustomOperator199:
                case AphidTokenType.CustomOperator200:
                case AphidTokenType.CustomOperator201:
                case AphidTokenType.CustomOperator202:
                case AphidTokenType.CustomOperator203:
                case AphidTokenType.CustomOperator204:
                case AphidTokenType.CustomOperator205:
                case AphidTokenType.CustomOperator206:
                case AphidTokenType.CustomOperator207:
                case AphidTokenType.CustomOperator208:
                case AphidTokenType.CustomOperator209:
                case AphidTokenType.CustomOperator210:
                case AphidTokenType.CustomOperator211:
                case AphidTokenType.CustomOperator212:
                case AphidTokenType.CustomOperator213:
                case AphidTokenType.CustomOperator214:
                case AphidTokenType.CustomOperator215:
                case AphidTokenType.CustomOperator216:
                case AphidTokenType.CustomOperator217:
                case AphidTokenType.CustomOperator218:
                case AphidTokenType.CustomOperator219:
                case AphidTokenType.CustomOperator220:
                case AphidTokenType.CustomOperator221:
                case AphidTokenType.CustomOperator222:
                case AphidTokenType.CustomOperator223:
                case AphidTokenType.CustomOperator224:
                case AphidTokenType.CustomOperator225:
                case AphidTokenType.CustomOperator226:
                case AphidTokenType.CustomOperator227:
                case AphidTokenType.CustomOperator228:
                case AphidTokenType.CustomOperator229:
                case AphidTokenType.CustomOperator230:
                case AphidTokenType.CustomOperator231:
                case AphidTokenType.CustomOperator232:
                case AphidTokenType.CustomOperator233:
                case AphidTokenType.CustomOperator234:
                case AphidTokenType.CustomOperator235:
                case AphidTokenType.CustomOperator236:
                case AphidTokenType.CustomOperator237:
                case AphidTokenType.CustomOperator238:
                case AphidTokenType.CustomOperator239:
                case AphidTokenType.CustomOperator240:
                case AphidTokenType.CustomOperator241:
                case AphidTokenType.CustomOperator242:
                case AphidTokenType.CustomOperator243:
                case AphidTokenType.CustomOperator244:
                case AphidTokenType.CustomOperator245:
                case AphidTokenType.CustomOperator246:
                case AphidTokenType.CustomOperator247:
                case AphidTokenType.CustomOperator248:
                case AphidTokenType.CustomOperator249:
                case AphidTokenType.CustomOperator250:
                case AphidTokenType.CustomOperator251:
                case AphidTokenType.CustomOperator252:
                case AphidTokenType.CustomOperator253:
                case AphidTokenType.CustomOperator254:
                case AphidTokenType.CustomOperator255:
                case AphidTokenType.CustomOperator256:
                case AphidTokenType.CustomOperator257:
                case AphidTokenType.CustomOperator258:
                case AphidTokenType.CustomOperator259:
                case AphidTokenType.CustomOperator260:
                case AphidTokenType.CustomOperator261:
                case AphidTokenType.CustomOperator262:
                case AphidTokenType.CustomOperator263:
                case AphidTokenType.CustomOperator264:
                case AphidTokenType.CustomOperator265:
                case AphidTokenType.CustomOperator266:
                case AphidTokenType.CustomOperator267:
                case AphidTokenType.CustomOperator268:
                case AphidTokenType.CustomOperator269:
                case AphidTokenType.CustomOperator270:
                case AphidTokenType.CustomOperator271:
                case AphidTokenType.CustomOperator272:
                case AphidTokenType.CustomOperator273:
                case AphidTokenType.CustomOperator274:
                case AphidTokenType.CustomOperator275:
                case AphidTokenType.CustomOperator276:
                case AphidTokenType.CustomOperator277:
                case AphidTokenType.CustomOperator278:
                case AphidTokenType.CustomOperator279:
                case AphidTokenType.CustomOperator280:
                case AphidTokenType.CustomOperator281:
                case AphidTokenType.CustomOperator282:
                case AphidTokenType.CustomOperator283:
                case AphidTokenType.CustomOperator284:
                case AphidTokenType.CustomOperator285:
                case AphidTokenType.CustomOperator286:
                case AphidTokenType.CustomOperator287:
                case AphidTokenType.CustomOperator288:
                case AphidTokenType.CustomOperator289:
                case AphidTokenType.CustomOperator290:
                case AphidTokenType.CustomOperator291:
                case AphidTokenType.CustomOperator292:
                case AphidTokenType.CustomOperator293:
                case AphidTokenType.CustomOperator294:
                case AphidTokenType.CustomOperator295:
                case AphidTokenType.CustomOperator296:
                case AphidTokenType.CustomOperator297:
                case AphidTokenType.CustomOperator298:
                case AphidTokenType.CustomOperator299:
                case AphidTokenType.CustomOperator300:
                case AphidTokenType.CustomOperator301:
                case AphidTokenType.CustomOperator302:
                case AphidTokenType.CustomOperator303:
                case AphidTokenType.CustomOperator304:
                case AphidTokenType.CustomOperator305:
                case AphidTokenType.CustomOperator306:
                case AphidTokenType.CustomOperator307:
                case AphidTokenType.CustomOperator308:
                case AphidTokenType.CustomOperator309:
                case AphidTokenType.CustomOperator310:
                case AphidTokenType.CustomOperator311:
                case AphidTokenType.CustomOperator312:
                case AphidTokenType.CustomOperator313:
                case AphidTokenType.CustomOperator314:
                case AphidTokenType.CustomOperator315:
                case AphidTokenType.CustomOperator316:
                case AphidTokenType.CustomOperator317:
                case AphidTokenType.CustomOperator318:
                case AphidTokenType.CustomOperator319:
                    #endregion
                    return InterpretCustomBinaryOperator(expression);

                default:
                    throw CreateRuntimeException("Unknown operator {0} in expression {1}", expression.Operator, expression);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretBinaryOperatorBodyExpression(BinaryOperatorBodyExpression expression)
        {
            var key = GetCustomOperatorKey(expression.Operator);
            var key2 = GetCustomOperatorExpressionKey(expression.Operator);
            var func = InterpretFunctionExpression(expression.Function);

            if (CurrentScope.TryGetValue(key, out var obj))
            {
                obj.Value = func.GetFunction();
                CurrentScope.TryGetValue(key2, out var obj2);
                obj2.Value = expression;

                return obj;
            }

            CurrentScope.Add(key, func);
            CurrentScope.Add(key2, Scalar(expression));

            return func;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretFunctionComposition(BinaryOperatorExpression composition) =>
            Scalar(new AphidFunctionComposition(
                composition.LeftOperand,
                composition.RightOperand,
                InterpretExpression(composition.LeftOperand).Value,
                InterpretExpression(composition.RightOperand).Value));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCustomUnaryOperator(UnaryOperatorExpression expression) =>
            CallCustomOperatorFunction(
                expression,
                expression.Operator,
                "unary",
                new[] { InterpretExpression(expression.Operand) });

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCustomBinaryOperator(BinaryOperatorExpression expression) =>
            CallCustomOperatorFunction(
                expression,
                expression.Operator,
                "binary",
                new[]
                {
                    InterpretExpression(expression.LeftOperand),
                    InterpretExpression(expression.RightOperand)
                });

        #endregion

        #region Stack Trace Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame[] GetStackTrace()
        {
            var c = _frames.Count - 1;
            var src = GetFrameArray();
            var arr = new AphidFrame[c];
            Array.Copy(src, 0, arr, 0, c);
            Array.Reverse(arr);

            return arr;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame[] GetRawStackTrace()
        {
            var c = _frames.Count;
            var src = GetFrameArray();
            var arr = new AphidFrame[c];
            Array.Copy(src, 0, arr, 0, c);
            Array.Reverse(arr);

            return arr;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame[] GetRawStackTraceReversed()
        {
            var c = _frames.Count;
            var src = GetFrameArray();
            var arr = new AphidFrame[c];
            Array.Copy(src, 0, arr, 0, c);

            return arr;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame[] GetStackTrace(int skip)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            var c = _frames.Count - 1 - skip;
            var src = GetFrameArray();
            var arr = new AphidFrame[c];
            Array.Copy(src, 0, arr, 0, c);
            Array.Reverse(arr);

            return arr;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame GetStackFrame(int offset)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            //var f = _frames.ToArray().Select(x => x.ToString()).JoinLines();
            var c = _frames.Count - 2;

            if (offset < 0 || offset > c)
            {
                throw new IndexOutOfRangeException($"Frame index out of range: {offset.ToString()}");
            }

            return GetFrameArray()[c - offset];
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidFrame GetStackFrame()
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            return GetFrameArray()[_frames.Count - 2];
        }

        #endregion

        #region Debugger Methods

#if APHID_DEBUGGING_ENABLED
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void HandleDebugging(AphidExpression expression)
        {
            if (CurrentExpression.Filename != null)
            {
                if (!CurrentExpression.Filename.Equals(
                    CurrentFileContext,
                    StringComparison.OrdinalIgnoreCase))
                {
#if APHID_DEBUGGING_TRACE
                    Cli.WriteInfoMessage(
                        "File context changed from ~Cyan~{0}~R~ to ~Magenta~{1}~R~",
                        CurrentFileContext,
                        CurrentExpression.Filename);
#endif

                    CurrentFileContext = CurrentExpression.Filename;
                    SetBreakpoints(CurrentFileContext = CurrentExpression.Filename);
                }
            }
            else if (CurrentFileContext != null)
            {
#if APHID_DEBUGGING_TRACE
                Cli.WriteErrorMessage("Expression without file context: ~Yellow~{0}~R~", expression);
#endif
                CurrentFileContext = null;
            }

            if (_isSingleStepping)
            {
                BreakExecution(expression);
            }
            else if (expression.HasBreakpoint)
            {
                using (_breakpointReset = new ManualResetEvent(false))
                {
                    if (HandleExecutionBreak != null)
                    {
                        BreakExecution(expression);
                    }

                    _breakpointReset.WaitOne();
                }

                _breakpointReset = null;
            }

            if (_singleStepReset != null)
            {
                _singleStepReset.WaitOne();

                if (!_isSingleStepping)
                {
                    _singleStepReset.Dispose();
                    _singleStepReset = null;
                }
            }

#if EXPRESSION_HISTORY
            if (_isSteppingBack)
            {
                throw new StepBackException();
            }
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFileBreakpoints(string filename, int[] breakpoints)
        {
#if APHID_DEBUGGING_TRACE
            Cli.WriteInfoMessage(
                "Currently at offset ~Cyan~{0}~R~ of file ~Magenta~{1}~R~, " + 
                    "Setting file breakpoints for ~Cyan~{2}~R~:",
                CurrentStatement != null ? CurrentStatement.Index.ToString() : "[null]",
                CurrentStatement != null ? CurrentStatement.Filename : "[null]",
                filename);

            foreach (var i in breakpoints)
            {
                Cli.WriteLine("    {0}", i);
            }
#endif

            //Todo: handle case sensitive file systems and forward slashes
            lock (FileBreakpointIndexMap)
            {
                if (FileBreakpointIndexMap.ContainsKey(filename))
                {
                    FileBreakpointIndexMap[filename] = breakpoints;
                }
                else
                {
#if APHID_DEBUGGING_TRACE
                    Cli.WriteInfoMessage(
                        "Adding ~Cyan~{0}~R~ to breakpoint map",
                        filename);
#endif

                    FileBreakpointIndexMap.Add(filename, breakpoints);
                }

                if (filename.Equals(CurrentFileContext, StringComparison.OrdinalIgnoreCase))
                {
#if APHID_DEBUGGING_TRACE
                    Cli.WriteInfoMessage(
                        "Current context matches ~Cyan~{0}~R~, clearing",
                        filename);
#endif

                    CurrentFileContext = null;
                }
            }

#if APHID_DEBUGGING_TRACE
            Cli.WriteLine();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetBreakpoints(string filename)
        {
            lock (FileBreakpointIndexMap)
            {
                if (FileBreakpointIndexMap.TryGetValue(filename, out var indexes))
                {
#if APHID_DEBUGGING_TRACE
                    Cli.WriteSuccessMessage("Found breakpoints for ~Cyan~{0}~R~", filename);
#endif
                    new AphidBreakpointVisitor(filename, indexes).Visit(_currentBlock);
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void BreakExecution(AphidExpression expression)
        {
            if (HandleExecutionBreak != null)
            {
                while (_queuedFramePops > 0)
                {
                    _frames.Pop();
                    _queuedFramePops--;
                }

                new Thread(() => HandleExecutionBreak(expression)) { IsBackground = true }
                    .Start();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Continue()
        {
            if (_breakpointReset != null)
            {
                _breakpointReset.Set();
            }

            if (_isSingleStepping)
            {
                _isSingleStepping = false;
                _singleStepReset.Set();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SingleStep()
        {
            _isSingleStepping = true;

            if (_singleStepReset == null)
            {
                _singleStepReset = new AutoResetEvent(true);
            }
            else
            {
                _singleStepReset.Set();
            }

            if (_breakpointReset != null)
            {
                _breakpointReset.Set();
            }
        }

#if EXPRESSION_HISTORY
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SingleStepBack()
        {
            _isSteppingBack = true;
            _expressionHistoryIndex = _expressionHistoryIndex > 0 ?
            _expressionHistoryIndex - 1 : (0x100 - 1);
            var entry = _expressionHistory[_expressionHistoryIndex];
            _currentScope = entry.Scope;
            _frames.Clear();
            _queuedFramePops = 0;

            for (var i = 0; i < entry.Frames.Length; i++)
            {
                _frames.Push(entry.Frames[i]);
            }


            if (_breakpointReset != null)
            {
                _breakpointReset.Set();
            }

            if (_isSingleStepping)
            {
                _isSingleStepping = false;
                _singleStepReset.Set();
            }
        }
#endif

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Pause() => SingleStep();
#endif

        #endregion

        #region Exception Helper Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateUndefinedMemberException(
            BinaryOperatorExpression expression,
            AphidExpression memberExpression) => CreateRuntimeException(
                "Undefined member {0} in expression {1}",
                memberExpression,
                expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateUndefinedFunctionException(
            AphidExpression callExpression,
            AphidExpression funcExpression) => CreateRuntimeException(
                "Undefined function {0} in call expression {1}",
                funcExpression,
                callExpression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateUnaryOperatorException(UnaryOperatorExpression expression) => CreateRuntimeException(
                "Unknown operator {0} in expression {1}.",
                expression.Operator,
                expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateOutOfBoundsException(
            AphidExpression expression,
            object val,
            int index,
            int count) => CreateExpressionException(
                expression,
                val,
                "Index {0} is out of bounds of {1} element collection",
                index,
                count);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateRuntimeException(string message, params object[] args) =>
            new AphidRuntimeException(
                this,
                CurrentScope,
                CurrentStatement,
                CurrentExpression,
                message,
                args);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateRuntimeException(
            AphidExpression expression,
            object obj) => CreateRuntimeException(
                "Unhandled exception caused by ",
                GetExpressionValueString(expression, obj));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateValueException(
            object obj,
            string message,
            params object[] args) => CreateRuntimeException(
                Format("{0} {1}",
                    message,
                    Cli.FormatEscape(GetValueString(obj))),
                args);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateExpressionException(
            AphidExpression expression,
            object obj,
            string message,
            params object[] args) => CreateRuntimeException(
                Format(
                    "{0} {1}",
                    message,
                    Cli.FormatEscape(GetExpressionValueString(expression, obj))),
                args);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateStrictModeException(string id) =>
            throw CreateRuntimeException(
                "Variable '{0}' must first be declared using var when running in strict mode.",
                id);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateInternalException(string message, params object[] args) =>
            new AphidInternalException(
                this,
                CurrentScope,
                CurrentStatement,
                CurrentExpression,
                message,
                args);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateMemberException(
            string key,
            AphidObject obj,
            BinaryOperatorExpression expression)
        {
            CurrentExpression = expression.RightOperand;

            var sb = new StringBuilder();
            sb.AppendFormat(
                "No Aphid or .NET interop member '{0}' has been declared " +
                    "by {1}, which was evaluated from '{2}', the left-hand " +
                    "side of the expression '{3}'. The serialized target " +
                    "object is '{4}'",
                key,
                obj != null ? obj.GetValueType(includeClrTypes: true) : "null",
                expression.LeftOperand,
                expression,
                new AphidSerializer(this).Serialize(obj));

            //if (!string.IsNullOrEmpty(expression.Filename))
            //{
            //    sb.AppendFormat("'{3}' in '{4}'. The serialized target object is: {3}",
            //}

            return CreateRuntimeException(sb.ToString());
        }

        #endregion

        #region Path Manipulation Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetMemberKey(AphidExpression memberExpression)
        {
            switch (memberExpression.Type)
            {
                case Exp.IdentifierExpression:
                    return ((IdentifierExpression)memberExpression).Identifier;

                case Exp.StringExpression:
                    return (string)InterpretStringExpression((StringExpression)memberExpression).Value;

                case Exp.DynamicMemberExpression:
                    var exp = ((DynamicMemberExpression)memberExpression).MemberExpression;
                    var memberObj = InterpretExpression(exp).Value;

                    try
                    {
                        return (string)memberObj;
                    }
                    catch
                    {
                        throw CreateRuntimeException(
                            "Dynamic member expression resolved to {0} of type {1}, expected string.",
                            memberObj ?? "null",
                            memberObj != null ? memberObj.GetType().FullName : "null");
                    }

                default:
                    throw CreateRuntimeException(
                        "Expected identifier or dynamic member expression, encountered {0} in {1}.",
                        memberExpression.Type,
                        memberExpression);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string FlattenAndJoinPath(AphidExpression exp) => Join(".", FlattenPath(exp));

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string[] FlattenPath(AphidExpression exp)
        {
            var pathExps = Flatten(exp);
            var path = new string[pathExps.Length];

            for (var i = 0; i < pathExps.Length; i++)
            {
                path[i] = GetMemberKey(pathExps[i]);
            }

            return path;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidExpression[] Flatten(AphidExpression exp) =>
            Flatten(exp, MemberOperator);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidExpression[] Flatten(AphidExpression exp, AphidTokenType sequenceOperator)
        {
            var expressions = new List<AphidExpression>();

            switch (exp.Type)
            {
                case Exp.BinaryOperatorExpression:
                    var binOpExp = (BinaryOperatorExpression)exp;

                    if (binOpExp.Operator == sequenceOperator)
                    {
                        expressions.AddRange(Flatten(binOpExp.LeftOperand));
                        expressions.Add(binOpExp.RightOperand);
                    }
                    else
                    {
                        expressions.Add(exp);
                    }

                    break;

                default:
                    expressions.Add(exp);
                    break;
            }

            return expressions.ToArray();
        }

        #endregion

        #region Aphid Object Helper Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetExpressionValueString(AphidExpression expression, object obj) =>
            Format(
                "{0}, which was evaluated from '{1}'.",
                GetValueString(obj),
                expression);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetValueString(object obj) => obj != null ?
                Format("'{0}' of type '{1}'", obj, AphidType.GetName(obj)) :
                "null";

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject WrapInteropValue(object value)
        {
            if (IsAphidType(value))
            {
                return Wrap(value);
            }

            throw CreateValueException(value, "Cannot wrap value");
        }

        #endregion

        #region IPC Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type GetIpcContextType() => typeof(AphidIpcContext);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RegisterIpcServer() => AphidIpcContext.Register(this);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidIpcContext CreateIpcClientContext() => IpcContext = new AphidIpcContext();

        #endregion

        #region Thread Management Methods

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void TakeOwnership() =>
            OwnerThread = Thread.CurrentThread.ManagedThreadId;

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter CreateChild() => AphidThread.CreateChild(this);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidInterpreter CreateChild(bool createChildScope) => AphidThread.CreateChild(this, createChildScope);

        #endregion

        #region Inner Types
#if APHID_DEBUGGING_ENABLED && EXPRESSION_HISTORY
        private readonly struct ExpressionHistoryRecord
        {
            public readonly AphidExpression Statement;

            public readonly List<AphidExpression> Block;

            public readonly int BlockIndex;

            public readonly AphidObject Scope;

            public readonly AphidFrame[] Frames;

            //public readonly int FramesLength;

            //public readonly int QueuedFramePops;

            public ExpressionHistoryRecord(
                AphidExpression statement,
                List<AphidExpression> block,
                int blockIndex,
                AphidObject scope,
                AphidFrame[] frame)
            //int framesLength,
            //int queuedFramePops)
            {
                Statement = statement;
                Block = block;
                BlockIndex = blockIndex;
                Scope = scope;
                Frames = frame;
                //FramesLength = framesLength;
                //QueuedFramePops = queuedFramePops;
            }
        }

        private class StepBackException : Exception { }
#endif
        #endregion
    }
}
