//#define TRACE_SCOPE
//#define TEXT_FRAME_PERFORMANCE_TRACE
//#define BINARY_FRAME_PERFORMANCE_TRACE

#if TRACE_SCOPE || TEXT_FRAME_PERFORMANCE_TRACE || BINARY_FRAME_PERFORMANCE_TRACE
using Components.Aphid.Debugging;
using Components.External;
using System.Diagnostics;
#endif

using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.External.ConsolePlus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;


namespace Components.Aphid.Interpreter
{
    // Todo:
    // * Fix all methods that return object instead of AphidObject,
    //   then remove excessive ValueHelper.Wrap/Unwrap and casting.
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
    // * Add strict mode that requires explicit variable declaration.
    // * Take crash dump of self when unhandled exception encountered.
    //   - Save not only standard Windows dmp files, but also Aphid specific
    //     dumps containing serialized scope.
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
    // * Add interop-types-as-values support e.g. var f = System.IO.File;
    // * Generate new bitwise operator implementations based on
    //   public AphidObject BinaryAnd(AphidObject x, AphidObject y)
    // * Look into generating interpreter thunks that handle interpreter
    //   construction and forwarding when public interpret methods are called
    //   from non-owner threads.
    // * Add using keyword support for IDisposable.
    // * Add scope keyword support for automatic disposal immediately upon leaving
    //   leaving scope via ascend (not descend) or by breaking scope chain entirely.
    // * Apply syntax highlighting throughout the CLI e.g. erro code excerpt,
    //   faulting expression, faulting statement, stack trace, serialization
    //   AphidExpression.ToString() output.
    // * Consider pure console IDE.
    //   -Draw inspiration from edit.com
    // * Add fan-out support for C# generation e.g.
    //   AphidCli.*()->AphidCli.Try*()
    //   AphidCli.*()->$_.Try*
    // * Support [] attributes by matching identifier after array decl/access
    //   to support multiple attrs declared with any expression
    // * Add jmp/goto support
    // * Replace foreach, Select, etc. with for.
    public partial class AphidInterpreter
    {
        private bool
            _isReturning,
            _isContinuing,
            _isBreaking,
            _isInTryCatchFinally;

        private Stack<AphidFrame> _frames;

        private int _queuedFramePops;

        private IEnumerable<AphidExpression> _insertNextBuffer;

        private ManualResetEvent _breakpointReset;

        private bool _isSingleStepping;

        private AutoResetEvent _singleStepReset;

#if TRACE_SCOPE
        private AphidTrace _scopeTrace;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
        private AphidTrace _framePerformanceTrace;
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
        private Stack<Tuple<string, Stopwatch>> _frameStopwatchStack = new Stack<Tuple<string, Stopwatch>>();
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
        private BinaryWriter _framePerformanceBinaryWriter;
#endif

        private AphidObject _localScope;

        private AphidObject _currentScope;

        public AphidObject CurrentScope
        {
            get { return _currentScope; }
            private set
            {
#if TRACE_SCOPE
                if (_scopeTrace != null)
                {
                    _scopeTrace.Trace("Set scope begin");
                }
#endif

                _currentScope = value;

#if TRACE_SCOPE
                if (_scopeTrace != null)
                {
                    _scopeTrace.Trace("Set scope end");
                }
#endif
            }
        }

        public int OwnerThread { get; private set; }

        public AphidAssemblyBuilder AsmBuilder { get; private set; }

        public InteropMethodResolver InteropMethodResolver { get; private set; }

        public OperatorHelper OperatorHelper { get; private set; }

        public ValueHelper ValueHelper { get; private set; }

        public InteropTypeResolver InteropTypeResolver { get; private set; }

        public TypeExtender TypeExtender { get; private set; }

        public AphidTypeConverter TypeConverter { get; private set; }

        public AphidFunctionConverter FunctionConverter { get; private set; }

        public AphidIpcContext IpcContext { get; private set; }

        public Action<AphidExpression> HandleExecutionBreak { get; set; }

        public AphidSerializer Serializer { get; private set; }

        public TextWriter Out { get; set; }

        public Func<string, string> OutFilter { get; set; }

        public Func<string, string> GatorEmitFilter { get; set; }

        public AphidLoader Loader { get; private set; }

        public AphidExpression CurrentStatement { get; private set; }

        public AphidExpression CurrentExpression { get; private set; }

        public AphidInterpreter()
            : this(createLoader: true)
        {
        }

        public AphidInterpreter(bool createLoader)
            : this(new AphidObject(), createLoader)
        {
            // Optimize by generating all built-in
            // variables here without having to perform
            // key existence checks.
        }

        public AphidInterpreter(AphidObject currentScope)
            : this(currentScope, createLoader: true)
        {
        }

        public AphidInterpreter(AphidObject currentScope, bool createLoader)
            : this(currentScope, createLoader, null)
        {

        }

        private AphidInterpreter(AphidLoader loader)
            : this(new AphidObject(), loader)
        {
        }

        private AphidInterpreter(AphidObject currentScope, AphidLoader loader)
            : this(currentScope, createLoader: false, loader: loader)
        {
        }

        private AphidInterpreter(AphidObject currentScope, bool createLoader, AphidLoader loader)
        {
            if (createLoader)
            {
                Loader = new AphidLoader(this);
            }
            else
            {
                Loader = loader;
            }

            CurrentScope = currentScope;

            OwnerThread = -1;
#if TRACE_SCOPE
            _scopeTrace = new AphidTrace(
                "Scope Trace",
                PathHelper.GetExecutingPath(
                    string.Format("AphidScope.{0}.log", Guid.NewGuid())),
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

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var framePerfGuid = Guid.NewGuid();

            var frameStart = string.Format(
                "Tracing frame performance beginning at:\r\n{0}\r\n\r\n",
                new StackTrace().ToString());
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace = new AphidTrace(
                "Frame performance Trace",
                PathHelper.GetExecutingPath(
                    string.Format("AphidFramePerformance.{0}.log", framePerfGuid)),
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
            _framePerformanceBinaryWriter = new BinaryWriter(
                File.Create(
                    PathHelper.GetExecutingPath(
                        string.Format(
                            "AphidFramePerformance.{0}.dat",
                            framePerfGuid))));
            
            _framePerformanceBinaryWriter.Write(frameStart);
            _framePerformanceBinaryWriter.Flush();
#endif

            Out = Console.Out;
            AsmBuilder = new AphidAssemblyBuilder(this);

            InteropMethodResolver = new InteropMethodResolver(
                this,
                InterpretMemberInteropExpression);

            OperatorHelper = new OperatorHelper(this);
            ValueHelper = new ValueHelper(this);
            TypeExtender = new TypeExtender(this);
            InteropTypeResolver = new InteropTypeResolver(this);
            TypeConverter = new AphidTypeConverter(this);
            FunctionConverter = new AphidFunctionConverter(this);

            Serializer = new AphidSerializer(this)
            {
                IgnoreSpecialVariables = false,
                IgnoreFunctions = false,
                QuoteToStringResults = true,
            };

            _frames = new Stack<AphidFrame>(new[] { CreateEntryFrame() });

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
                CurrentScope.Add(AphidName.FramesKey, new AphidObject(_frames));
            }

            if (!CurrentScope.ContainsKey(AphidName.AsmBuilder))
            {
                CurrentScope.Add(AphidName.AsmBuilder, new AphidObject(AsmBuilder));
            }

            if (!CurrentScope.ContainsKey(AphidName.Interpreter))
            {
                CurrentScope.Add(AphidName.Interpreter, new AphidObject(this));
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateUndefinedMemberException(AphidExpression expression, AphidExpression memberExpression)
        {
            return CreateRuntimeException(
                    "Undefined member {0} in expression {1}",
                    memberExpression,
                    expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateUnaryOperatorException(UnaryOperatorExpression expression)
        {
            return CreateRuntimeException(
                "Unknown operator {0} in expression {1}.",
                expression.Operator,
                expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public List<string> GetImports()
        {
            AphidObject imports = null;

            if (CurrentScope.TryResolve(AphidName.Imports, out imports))
            {
                return (List<string>)imports.Value;
            }
            else
            {
                var list = new List<string>();
                CurrentScope.Add(AphidName.Imports, new AphidObject(list));

                return list;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddImport(string name)
        {
            var imports = GetImports();

            if (!imports.Contains(name))
            {
                imports.Add(name);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject GetReturnValue()
        {
            return GetReturnValue(false);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject GetReturnValue(bool remove)
        {
            AphidObject retVal = null;
            if (CurrentScope.TryResolve(AphidName.Return, out retVal) && remove)
            {
                CurrentScope.Remove(AphidName.Return);
            }

            return retVal;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetReturnValue(AphidObject obj)
        {
            CurrentScope.Add(AphidName.Return, obj);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetScriptFilename(string filename)
        {
            var obj = new AphidObject(filename);

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
            AphidObject scriptObj;

            if (CurrentScope != null)
            {
                return CurrentScope.TryResolve(AphidName.Script, out scriptObj) ?
                    scriptObj != null ? scriptObj.GetString() : null :
                    null;
            }
            else
            {
                return null;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnterScope()
        {
#if TRACE_SCOPE
            _scopeTrace.Trace("Enter scope begin");
#endif

            CurrentScope = new AphidObject(null, CurrentScope);
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

        public void EnterSharedScope(AphidObject sharedScope)
        {
            EnterSharedScope(sharedScope, createChild: true);
        }

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
                new AphidObject(null, sharedScope);

            PushFrame("[Shared Scope]");
        }

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

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CompareDecimals(BinaryOperatorExpression expression, Func<decimal, decimal, bool> equal)
        {
            return new AphidObject(
                equal(
                    Convert.ToDecimal(ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand))),
                    Convert.ToDecimal(ValueHelper.Unwrap(InterpretExpression(expression.RightOperand)))));
        }

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

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretAndExpression(BinaryOperatorExpression expression)
        {
            var left = (bool)ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand));

            if (!left)
            {
                return new AphidObject(false);
            }
            else
            {
                return new AphidObject((bool)ValueHelper.Unwrap(InterpretExpression(expression.RightOperand)));
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretOrExpression(BinaryOperatorExpression expression)
        {
            var left = (bool)ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand));

            if (left)
            {
                return new AphidObject(true);
            }
            else
            {
                return new AphidObject((bool)ValueHelper.Unwrap(InterpretExpression(expression.RightOperand)));
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretEqualityExpression(BinaryOperatorExpression expression)
        {
            var left = (AphidObject)InterpretExpression(expression.LeftOperand);
            var right = (AphidObject)InterpretExpression(expression.RightOperand);

            bool val;

            if (left == null)
            {
                throw CreateUndefinedMemberException(expression, expression.LeftOperand);
            }
            else if (right == null)
            {
                throw CreateUndefinedMemberException(expression, expression.RightOperand);
            }
            else
            {
                if (left.Value != null && right.Value != null)
                {
                    Type leftType = left.Value.GetType(), rightType = right.Value.GetType();
                    val = InterpretEqualityExpression(left.Value, leftType, right.Value, rightType);
                }
                else if (left.Value != null)
                {
                    val = left.Value.Equals(right.Value);
                }
                else if (right.Value != null)
                {
                    val = right.Value.Equals(left.Value);
                }
                else
                {
                    val = left.Count == 0 && right.Count == 0;
                }
            }

            if (expression.Operator == AphidTokenType.NotEqualOperator)
            {
                val = !val;
            }

            return new AphidObject(val);
        }

        // Todo: add interop support for dynamic members e.g. Path.{'Combine'}
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretMemberInteropExpression(
            object lhs,
            BinaryOperatorExpression expression,
            bool returnRef = false,
            Func<AphidObject> dynamicHandler = null)
        {
            if (expression.RightOperand.Type != AphidExpressionType.IdentifierExpression)
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
                var type = InteropTypeResolver.ResolveType(GetImports().ToArray(), path);
                members = GetInteropStaticMembers(type, path);
                TypeInfo nestedTypeInfo;

                if (members.Length == 1 &&
                    (nestedTypeInfo = members[0] as TypeInfo) != null)
                {
                    return new AphidObject(nestedTypeInfo);
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
            BinaryOperatorExpression expression,
            bool returnRef = false,
            Func<AphidObject> dynamicHandler = null)
        {
            if (members.Length == 1)
            {
                var propInfo = members[0] as PropertyInfo;

                if (propInfo != null)
                {
                    if (!returnRef)
                    {
                        return propInfo.PropertyType != typeof(AphidObject) ?
                            new AphidObject(propInfo.GetValue(lhs)) :
                            (AphidObject)propInfo.GetValue(lhs);
                    }
                    else
                    {
                        return new AphidObject(new AphidInteropReference(lhs, propInfo));
                    }
                }

                var fieldInfo = members[0] as FieldInfo;

                if (fieldInfo != null)
                {
                    if (!returnRef)
                    {
                        return fieldInfo.FieldType != typeof(AphidObject) ?
                            new AphidObject(fieldInfo.GetValue(lhs)) :
                            (AphidObject)fieldInfo.GetValue(lhs);
                    }
                    else
                    {
                        return new AphidObject(new AphidInteropReference(lhs, fieldInfo));
                    }
                }
            }
            else if (members.Length == 0)
            {
                if (dynamicHandler == null)
                {
                    throw CreateRuntimeException(
                        "Could not find property '{0}'",
                        expression.RightOperand.ToIdentifier().ToIdentifier());
                }
                else
                {
                    return dynamicHandler();
                }
            }

            return new AphidObject(new AphidInteropMember(expression, lhs, members));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private MemberInfo[] GetInteropInstanceMembers(object target, BinaryOperatorExpression expression)
        {
            var memberName = expression.RightOperand.ToIdentifier().Identifier;

            return target
                .GetType()
                .GetMembers()
                .Where(x => x.Name == memberName)
                .ToArray();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private MemberInfo[] GetInteropInstanceMembers(object target, string name)
        {
            return target
                .GetType()
                .GetMembers()
                .Where(x => x.Name == name)
                .ToArray();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private MemberInfo[] GetInteropStaticMembers(Type type, string[] path)
        {
            var member = path.Last();

            return type
                .GetMembers(BindingFlags.Static | BindingFlags.Public)
                .Where(x => x.Name == member)
                .ToArray();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private MemberInfo[] GetInteropStaticMembers(Type type, string name)
        {
            return type
                .GetMembers(BindingFlags.Static | BindingFlags.Public)
                .Where(x => x.Name == name)
                .ToArray();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretMemberExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            var obj = InterpretExpression(expression.LeftOperand) as AphidObject;

            Type type;

            if (obj != null && ((type = obj.Value as Type) != null))
            {
                var name = ((IdentifierExpression)expression.RightOperand).Identifier;

                if (!type.Assembly.IsDynamic)
                {
                    var members = GetInteropStaticMembers(type, name);

                    if (members.Length != 0)
                    {
                        var nestedType = members[0] as Type;

                        return nestedType == null ?
                            InterpretMemberInteropExpression(
                                null,
                                members,
                                expression,
                                returnRef,
                                null) :
                                new AphidObject(nestedType);
                    }

                    members = GetInteropInstanceMembers(type, name);

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
                    var members = GetInteropInstanceMembers(type, name);

                    if (members.Length != 0)
                    {
                        return InterpretMemberInteropExpression(
                            type,
                            members,
                            expression,
                            returnRef,
                            null);
                    }

                    members = GetInteropStaticMembers(type, name);

                    if (members.Length != 0)
                    {
                        var nestedType = members[0] as Type;

                        return nestedType == null ?
                            InterpretMemberInteropExpression(
                                null,
                                members,
                                expression,
                                returnRef,
                                null) :
                                new AphidObject(nestedType);
                    }
                }

                var ext = TypeExtender.TryResolve(
                    CurrentScope,
                    type,
                    key: ((IdentifierExpression)expression.RightOperand).Identifier,
                    isAphidType: false,
                    isCtor: false,
                    isDynamic: false,
                    returnRef: returnRef);

                if (ext != null)
                {
                    return ext;
                }
            }

            if (expression.RightOperand.Type == AphidExpressionType.IdentifierExpression)
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

            string key;

            if (expression.RightOperand is IdentifierExpression)
            {
                key = (expression.RightOperand as IdentifierExpression).Identifier;
            }
            else if (expression.RightOperand is StringExpression)
            {
                key = (string)ValueHelper.Unwrap(InterpretStringExpression(expression.RightOperand as StringExpression));
            }
            else if (expression.RightOperand is DynamicMemberExpression)
            {
                var memberExp = expression.RightOperand as DynamicMemberExpression;
                key = ValueHelper.Unwrap(InterpretExpression(memberExp.MemberExpression)).ToString();
            }
            else
            {
                throw CreateRuntimeException("Unexpected expression {0}", expression.RightOperand);
            }

            if (returnRef)
            {
                return new AphidRef() { Name = key, Object = obj };
            }
            else
            {
                AphidObject val;

                if (obj == null || (obj.Count == 0 && obj.Value == null))
                {
                    if (expression.LeftOperand.Type != AphidExpressionType.IdentifierExpression)
                    {
                        throw CreateRuntimeException("Null reference exception: {0}", expression);
                    }

                    return InterpretMemberInteropExpression(null, expression, returnRef);
                }
                else if (obj.Count == 0)
                {
                    var aphidType = obj.IsAphidType();

                    val = TypeExtender.TryResolve(
                            CurrentScope,
                            obj,
                            key,
                            isAphidType: aphidType,
                            isCtor: false,
                            isDynamic: false,
                            returnRef: returnRef) ??
                        InterpretMemberInteropExpression(
                            obj.Value,
                            expression,
                            returnRef,
                            () => TypeExtender.TryResolve(
                                CurrentScope,
                                obj,
                                key,
                                isAphidType: aphidType,
                                isCtor: false,
                                isDynamic: true,
                                returnRef: returnRef));

                    if (val == null)
                    {
                        throw CreateException(key, obj, expression);
                    }

                    return val;
                }
                else if (!obj.TryResolve(key, out val))
                {
                    if (obj.Value != null)
                    {
                        val = TypeExtender.TryResolve(
                            CurrentScope,
                            obj,
                            key,
                            isAphidType: true,
                            isCtor: false,
                            isDynamic: false,
                            returnRef: returnRef);

                        return val == null ?
                            InterpretMemberInteropExpression(
                                obj.Value,
                                expression,
                                returnRef,
                                () => TypeExtender.TryResolve(
                                    CurrentScope,
                                    obj,
                                    key,
                                    isAphidType: true,
                                    isCtor: false,
                                    isDynamic: true,
                                    returnRef: returnRef)) :
                            val;
                    }
                    else
                    {
                        throw CreateException(key, obj, expression);
                    }
                }

                return val;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidRuntimeException CreateException(string key, AphidObject obj, AphidExpression expression)
        {
            return CreateRuntimeException(
                "No CLR member or Aphid extension '{0}' " +
                    "declared for type '{1}'.\r\n\r\n" +
                    "Expression: {2}\r\n\r\n" +
                    "Serialized target object: {3}",
                key,
                obj.GetValueType(includeClrTypes: true),
                expression,
                new AphidSerializer(this).Serialize(obj));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpetAssignmentExpression(
            BinaryOperatorExpression expression,
            bool returnRef = false)
        {
            var value = InterpretExpression(expression.RightOperand);
            var result = InterpetAssignmentExpression(
                expression.LeftOperand,
                value,
                returnRef,
                expression);

            return result;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpetAssignmentExpression(
            AphidExpression destinationExpression,
            object value,
            bool returnRef = false,
            AphidExpression completeExpression = null)
        {
            //var value = InterpretExpression(expression.RightOperand);
            var value2 = ValueHelper.Wrap(value);
            AphidFunction func;


            if (destinationExpression.Type == AphidExpressionType.IdentifierExpression)
            {
                var idExp = (IdentifierExpression)destinationExpression;
                var id = idExp.Identifier;

                if (idExp.Attributes.Count == 0 || idExp.Attributes[0].Identifier != "var")
                {
                    var destObj = InterpretIdentifierExpression(idExp, canResolveType: false);

                    if (destObj == null)
                    {
                        CurrentScope.Add(id, value2);
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
                        CurrentScope.Add(id, value2);
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
            else if (destinationExpression.Type == AphidExpressionType.ArrayAccessExpression)
            {
                var arrayAccessExp = (ArrayAccessExpression)destinationExpression;
                var targetObj = InterpretExpression(arrayAccessExp.ArrayExpression);
                var targetObjUnwrapped = ValueHelper.Unwrap(targetObj);

                var keyObj = ValueHelper.Unwrap(
                    InterpretExpression(arrayAccessExp.KeyExpression));

                Array targetArray;
                List<AphidObject> targetAphidList;

                if ((targetArray = targetObjUnwrapped as Array) != null)
                {
                    targetArray.SetValue(
                        Convert.ChangeType(
                            ValueHelper.Unwrap(value),
                            targetArray.GetType().GetElementType()),
                        Convert.ToInt32(keyObj));
                }
                else if ((targetAphidList = targetObjUnwrapped as List<AphidObject>) != null)
                {
                    if (value2.Count == 0 && value2.Value != null)
                    {
                        value = value2 = new AphidObject(value2.Value);
                    }

                    targetAphidList[Convert.ToInt32(keyObj)] = value2;
                }
                else
                {
                    var targetType = targetObjUnwrapped.GetType();

                    if (targetType
                        .GetInterfaces()
                        .Any(x => x.GetGenericTypeDefinition() == typeof(IList<>)))
                    {
                        var index = targetType
                            .GetProperties()
                            .Select(x => new { Property = x, Params = x.GetIndexParameters() })
                            .Single(x =>
                                x.Params.Length == 1 &&
                                x.Params[0].ParameterType == typeof(int));

                        index.Property.SetValue(
                            targetObjUnwrapped,
                            Convert.ChangeType(
                                ValueHelper.Unwrap(value),
                                index.Property.PropertyType),
                            new object[] { Convert.ToInt32(keyObj) });
                    }
                    else
                    {
                        throw CreateRuntimeException("Could not set value by index.");
                    }
                }
            }
            else if (destinationExpression.Type == AphidExpressionType.BinaryOperatorExpression)
            {
                var obj = InterpretBinaryOperatorExpression(
                    (BinaryOperatorExpression)destinationExpression,
                    true);

                var objRef = obj as AphidRef;

                if (objRef != null)
                {
                    if (objRef.Object == null)
                    {
                        throw CreateRuntimeException("Undefined variable {0}", destinationExpression);
                    }
                    else if (objRef.Object.ContainsKey(objRef.Name))
                    {
                        if (ValueHelper.IsComplexAphidObject(value))
                        {
                            var v = (AphidObject)value;

                            func = ValueHelper.Unwrap(value) as AphidFunction;

                            if ((func = ValueHelper.Unwrap(value) as AphidFunction) != null)
                            {
                                func.ParentScope = v;
                            }

                            objRef.Object[objRef.Name] = v;
                        }
                        else
                        {
                            if ((func = ValueHelper.Unwrap(value) as AphidFunction) != null)
                            {
                                func.ParentScope = objRef.Object;
                            }

                            objRef.Object[objRef.Name].Value = ValueHelper.Unwrap(value);
                        }
                    }
                    else
                    {
                        objRef.Object.Add(objRef.Name, ValueHelper.Wrap(value));

                        if ((func = ValueHelper.Unwrap(value) as AphidFunction) != null)
                        {
                            func.ParentScope = objRef.Object;
                        }
                    }

                    return value;
                }

                var interopRef = ValueHelper.Unwrap(obj) as AphidInteropReference;

                if (interopRef == null)
                {
                    obj = InterpretMemberInteropExpression(
                        null,
                        (BinaryOperatorExpression)destinationExpression,
                        returnRef: true);

                    interopRef = ValueHelper.Unwrap(obj) as AphidInteropReference;
                }

                if (interopRef != null)
                {
                    var v = ValueHelper.Unwrap(value);

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

                    if ((func = ValueHelper.Unwrap(value) as AphidFunction) != null)
                    {
                        var o = interopRef.Object;

                        var ao = o as AphidObject;

                        if (ao != null)
                        {
                            func.ParentScope = ao;
                        }
                        else
                        {
                            func.ParentScope = new AphidObject(o, CurrentScope);
                        }
                    }

                    return value;
                }


            }
            else
            {
                throw CreateRuntimeException(
                    "Invalid left hand side of assignment expression: {0}",
                    completeExpression ?? destinationExpression);
            }

            return value;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool HandleInteropReference(AphidInteropReference interopRef, AphidObject value)
        {
            if (interopRef == null)
            {
                return false;
            }

            var v = ValueHelper.Unwrap(value);

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

            AphidFunction func;

            if ((func = ValueHelper.Unwrap(value) as AphidFunction) != null)
            {
                var o = interopRef.Object;

                var ao = o as AphidObject;

                if (ao != null)
                {
                    func.ParentScope = ao;
                }
                else
                {
                    func.ParentScope = new AphidObject(o, CurrentScope);
                }
            }

            return true;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterprentOperatorAndAssignmentExpression(
            Func<AphidObject, AphidObject, AphidObject> performOperation,
            BinaryOperatorExpression expression)
        {
            var value = performOperation(
                (AphidObject)InterpretExpression(expression.LeftOperand),
                (AphidObject)InterpretExpression(expression.RightOperand));

            var result = InterpetAssignmentExpression(
                expression.LeftOperand,
                value,
                returnRef: false,
                completeExpression: expression);

            return ValueHelper.Wrap(result);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretBinaryOperatorExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.AdditionOperator:
                    return OperatorHelper.Add(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MinusOperator:
                    return OperatorHelper.Subtract(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MultiplicationOperator:
                    return OperatorHelper.Multiply(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.DivisionOperator:
                    return OperatorHelper.Divide(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MemberOperator:
                    return InterpretMemberExpression(expression, returnRef);

                case AphidTokenType.AssignmentOperator:
                    return InterpetAssignmentExpression(expression, returnRef);

                case AphidTokenType.PlusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Add, expression);

                case AphidTokenType.MinusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Subtract, expression);

                case AphidTokenType.MultiplicationEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Multiply, expression);

                case AphidTokenType.DivisionEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Divide, expression);

                case AphidTokenType.ModulusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Mod, expression);

                case AphidTokenType.BinaryAndEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryAnd, expression);

                case AphidTokenType.OrEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryOr, expression);

                case AphidTokenType.XorEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Xor, expression);

                case AphidTokenType.ShiftLeftEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftLeft, expression);

                case AphidTokenType.ShiftRightEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftRight, expression);

                case AphidTokenType.NotEqualOperator:
                case AphidTokenType.EqualityOperator:
                    return InterpretEqualityExpression(expression);

                case AphidTokenType.LessThanOperator:
                    return CompareDecimals(expression, (x, y) => x < y);

                case AphidTokenType.LessThanOrEqualOperator:
                    return CompareDecimals(expression, (x, y) => x <= y);

                case AphidTokenType.GreaterThanOperator:
                    return CompareDecimals(expression, (x, y) => x > y);

                case AphidTokenType.GreaterThanOrEqualOperator:
                    return CompareDecimals(expression, (x, y) => x >= y);

                case AphidTokenType.AndOperator:
                    return InterpretAndExpression(expression);

                case AphidTokenType.OrOperator:
                    return InterpretOrExpression(expression);

                case AphidTokenType.ModulusOperator:
                    return OperatorHelper.Mod(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.ShiftLeft:
                    return OperatorHelper.BinaryShiftLeft(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.ShiftRight:
                    return OperatorHelper.BinaryShiftRight(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.BinaryAndOperator:
                    return OperatorHelper.BinaryAnd(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.BinaryOrOperator:
                    return OperatorHelper.BinaryOr(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.XorOperator:
                    return OperatorHelper.Xor(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.PipelineOperator:
                    return InterpretCallExpression(
                        (CallExpression)new CallExpression(
                            expression.RightOperand,
                            expression.LeftOperand)
                                .WithPositionFrom(expression));

                case AphidTokenType.RangeOperator:
                    return OperatorHelper.Range(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.SelectOperator:
                    var collection = InterpretExpression(expression.LeftOperand);
                    var funcObj = InterpretExpression(expression.RightOperand);
                    var func = ValueHelper.Unwrap(funcObj);

                    return ((IEnumerable<object>)ValueHelper
                        .UnwrapAndBoxCollection(collection))
                        .Select(x => ValueHelper.Wrap(
                            InterpretFunctionExpression(
                                expression,
                                expression.RightOperand,
                                func,
                                new[] { x })))
                        .ToList();

                case AphidTokenType.SelectManyOperator:
                    func = ValueHelper.Unwrap(InterpretExpression(expression.RightOperand));

                    return ((IEnumerable<object>)ValueHelper
                        .UnwrapAndBoxCollection(InterpretExpression(expression.LeftOperand)))
                        .SelectMany(x =>
                            (IEnumerable<object>)(ValueHelper.Unwrap(
                                InterpretFunctionExpression(
                                    expression,
                                    expression.RightOperand,
                                    func,
                                    new[] { x }))))
                        .Select(ValueHelper.Wrap)
                        .ToList();


                case AphidTokenType.AggregateOperator:
                    func = ValueHelper.Unwrap(InterpretExpression(expression.RightOperand));

                    return ((IEnumerable<object>)ValueHelper
                        .UnwrapAndBoxCollection(InterpretExpression(expression.LeftOperand)))
                        .Aggregate((x, y) => ValueHelper.Wrap(
                            InterpretFunctionExpression(
                                expression,
                                expression.RightOperand,
                                func,
                                new[] { x, y })));

                case AphidTokenType.AnyOperator:
                    func = ValueHelper.Unwrap(InterpretExpression(expression.RightOperand));

                    return ((IEnumerable<object>)ValueHelper
                        .UnwrapAndBoxCollection(InterpretExpression(expression.LeftOperand)))
                        .Any(x => (bool)ValueHelper.Unwrap(
                            InterpretFunctionExpression(
                                expression,
                                expression.RightOperand,
                                func,
                                new[] { x })));

                case AphidTokenType.WhereOperator:
                    func = ValueHelper.Unwrap(InterpretExpression(expression.RightOperand));

                    return ((IEnumerable<object>)ValueHelper
                        .UnwrapAndBoxCollection(InterpretExpression(expression.LeftOperand)))
                        .Where(x => (bool)ValueHelper.Unwrap(
                            InterpretFunctionExpression(
                                expression,
                                expression.RightOperand,
                                func,
                                new[] { x })))
                        .ToList();

                case AphidTokenType.CompositionOperator:
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
                case AphidTokenType.CustomOperator320:
                case AphidTokenType.CustomOperator321:
                case AphidTokenType.CustomOperator322:
                case AphidTokenType.CustomOperator323:
                case AphidTokenType.CustomOperator324:
                case AphidTokenType.CustomOperator325:
                case AphidTokenType.CustomOperator326:
                case AphidTokenType.CustomOperator327:
                case AphidTokenType.CustomOperator328:
                case AphidTokenType.CustomOperator329:
                case AphidTokenType.CustomOperator330:
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

            AphidObject obj, obj2;

            if (CurrentScope.TryGetValue(key, out obj))
            {
                obj.Value = func.GetFunction();
                CurrentScope.TryGetValue(key2, out obj2);
                obj2.Value = expression;

                return obj;
            }
            else
            {
                CurrentScope.Add(key, func);
                CurrentScope.Add(key2, new AphidObject(expression));

                return func;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretFunctionComposition(BinaryOperatorExpression composition)
        {
            var funcs = new[] { composition.LeftOperand, composition.RightOperand }
                .Select(x => ValueHelper.Unwrap(InterpretExpression(x)))
                .ToArray();

            var c = new AphidFunctionComposition(
                composition.LeftOperand,
                composition.RightOperand,
                funcs[0],
                funcs[1]);

            return new AphidObject(c);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCustomUnaryOperator(UnaryOperatorExpression expression)
        {
            return CallCustomOperatorFunction(
                expression,
                expression.Operator,
                "unary",
                new[] { InterpretExpression(expression.Operand) });
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCustomBinaryOperator(BinaryOperatorExpression expression)
        {
            return CallCustomOperatorFunction(
                expression,
                expression.Operator,
                "binary",
                new[]
                {
                    InterpretExpression(expression.LeftOperand),
                    InterpretExpression(expression.RightOperand)
                });
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
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidFunction GetCustomOperatorFunction(AphidTokenType op, string name)
        {
            AphidObject obj;

            if (!CurrentScope.TryResolve(GetCustomOperatorKey(op), out obj))
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
        private string GetCustomOperatorKey(AphidTokenType op)
        {
            return string.Format("$customOperator.{0}.body", op);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetCustomOperatorExpressionKey(AphidTokenType op)
        {
            return string.Format("$customOperator.{0}.expression", op);
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
                !expression.Identifier.Attributes.Any() ||
                expression.Identifier.Attributes[0].Identifier != "class")
            {
                var parent = CurrentScope;
                var obj = new AphidObject { Parent = parent };
                CurrentScope = obj;

                try
                {
                    foreach (var kvp in expression.Pairs)
                    {
                        var objectKey = kvp.LeftOperand.Type == AphidExpressionType.IdentifierExpression ?
                            kvp.LeftOperand.ToIdentifier().Identifier :
                            ValueHelper.Unwrap(InterpretExpression(kvp.LeftOperand)).ToString();

                        var objectValue = ValueHelper.Wrap(InterpretExpression(kvp.RightOperand));

                        if (objectValue.Value == null)
                        {
                            obj.Add(objectKey, objectValue);
                        }
                        else
                        {
                            obj.Add(objectKey, new AphidObject(objectValue.Value));
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
            else
            {
                //if (!expression.IsStatement())
                //{
                //    ThrowRuntimeException(
                //        "Class declaration '{0}' must be statement.",
                //        expression.Identifier.Identifier);
                //}

                var t = AsmBuilder.CreateType(expression, GetImports());

                return new AphidObject(t); ;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIdentifierExpression(IdentifierExpression expression)
        {
            return InterpretIdentifierExpression(expression, canResolveType: true);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIdentifierExpression(
            IdentifierExpression expression,
            bool canResolveType)
        {
            AphidObject obj;
            Type t;

            if (CurrentScope.TryResolve(expression.Identifier, out obj))
            {
                return obj;
            }
            else if (canResolveType && 
                (t = InteropTypeResolver.TryResolveType(
                    GetImports().ToArray(),
                    new[] { expression.Identifier },
                    isType: true)) != null)
            {
                return new AphidObject(t);
            }
            else
            {

                return null;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretStringExpression(StringExpression expression)
        {
            return new AphidObject(StringParser.Parse(expression.Value));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(string name, params object[] parms)
        {
            var idExp = new IdentifierExpression(name);
            PushFrame(idExp, idExp, parms);

            try
            {
                var val = InterpretIdentifierExpression(idExp);
                var func = ValueHelper.Unwrap(val) as AphidFunction;

                return CallFunction(func, parms);
            }
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(AphidFunction function, params object[] parms)
        {
            return CallFunctionWithScope(function, null, parms);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunctionWithScope(AphidFunction function, AphidObject scope, params object[] parms)
        {
            var parmsWrapped = parms.Select(ValueHelper.Wrap).ToArray();

            if (Thread.CurrentThread.ManagedThreadId == OwnerThread)
            {
                return CallFunctionCore(function, scope, parmsWrapped);
            }
            else
            {
                var childInterpreter = new AphidInterpreter(CurrentScope.CreateChild(), Loader);
                return childInterpreter.CallFunctionCore(function, scope, parmsWrapped);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallFunctionCore(AphidFunction function, AphidObject[] parms)
        {
            return CallFunctionCore(function, null, parms);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallFunctionCore(AphidFunction function, AphidObject scope, AphidObject[] parms)
        {
            AphidObject isExtensionObject;

            bool isExtension, isStaticExtension;
            AphidObject extensionArg;

            if (function.ParentScope != null &&
                function.ParentScope.TryGetValue(AphidName.Extension, out isExtensionObject) &&
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

            var functionScope = new AphidObject(null, function.ParentScope)
            {
                { AphidName.Parent, function.ParentScope }
            };

            functionScope.Add(AphidName.Scope, functionScope);
            var argList = parms.ToList();

            for (var i = 0; i < argList.Count; i++)
            {
                var arg = argList[i];

                if ((!isExtension || isStaticExtension) && i == 0)
                {
                    SetImplicitArg(functionScope, arg);
                }

                if (function.Args.Length == i)
                {
                    break;
                }

                functionScope.Add(function.Args[i], arg);
            }

            if (isExtension && !isStaticExtension)
            {
                argList.Insert(0, extensionArg);
                functionScope[AphidName.ImplicitArg] = extensionArg;
            }

            functionScope[AphidName.ImplicitArgs] = new AphidObject(argList);
            AphidObject backupScope = null;

            if (scope != null)
            {
                functionScope.CopyTo(scope);
                scope.Parent = functionScope.Parent;
                functionScope = scope;
                backupScope = functionScope;
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
        private void SetImplicitArg(AphidObject arg)
        {
            SetImplicitArg(CurrentScope, arg);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetImplicitArg(AphidObject scope, AphidObject arg)
        {
            scope[AphidName.ImplicitArg] = arg;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject CallInteropFunction(AphidInteropFunction func, params AphidObject[] objArgs)
        {
            object[] args = objArgs;

            if (func.UnwrapParameters)
            {
                args = objArgs.Select(x => x.Value).ToArray();
            }

            return ValueHelper.Wrap(func.Invoke(this, args));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallFunction(AphidObject function, params object[] args)
        {
            var value = function.Value;
            var func = value as AphidFunction;

            if (func != null)
            {
                return CallFunction(func, args);
            }

            var func2 = value as AphidInteropFunction;

            if (func2 != null)
            {
                return CallInteropFunction(func2, (AphidObject[])args);
            }

            throw CreateRuntimeException("Object is not function: {0}", function);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetInteropAttribute(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var attr = expression.ToIdentifier().Attributes.SingleOrDefault();

                    return attr != null ? attr.Identifier : null;

                case AphidExpressionType.BinaryOperatorExpression:
                    return GetInteropAttribute(
                        expression.ToBinaryOperator().LeftOperand);

                case AphidExpressionType.CallExpression:
                    return GetInteropAttribute(
                        expression.ToCall().FunctionExpression);

                default:
                    return null;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject CallStaticInteropFunction(CallExpression callExpression)
        {
            var path = FlattenPath(callExpression.FunctionExpression);
            var pathStr = string.Join(".", path);
            var imports = GetImports();

            var type = InteropTypeResolver.ResolveType(GetImports().ToArray(), path);
            var methodName = path.Last();

            var args = callExpression.Args
                .Select(InterpretExpression)
                .Select(ValueHelper.Unwrap)
                .ToArray();

            var methodInfo = InteropMethodResolver.Resolve(type, methodName, args);

            MethodBase method;

            if (!methodInfo.GenericArguments.Any())
            {
                method = methodInfo.Method;
            }
            else
            {
                var m = (MethodInfo)methodInfo.Method;

                if (methodInfo.GenericArguments.Length != m.GetGenericArguments().Length)
                {
                    throw CreateRuntimeException(
                        "Generic type parameter mismatch between {0} and {1}.",
                        methodInfo.Method.ToString(),
                        m.ToString());
                }

                method = m.MakeGenericMethod(m.GetGenericArguments());
            }

            var convertedArgs = TypeConverter.Convert(
                methodInfo.Arguments,
                methodInfo.GenericArguments);

            return ValueHelper.Wrap(method.Invoke(null, convertedArgs));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string FlattenAndJoinPath(AphidExpression exp)
        {
            return string.Join(".", FlattenPath(exp));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string[] FlattenPath(AphidExpression exp)
        {
            var pathExps = Flatten(exp);

            if (!pathExps.All(x => x.Type == AphidExpressionType.IdentifierExpression))
            {
                throw CreateRuntimeException("Invalid interop call path '{0}'", exp);
            }

            var path = pathExps
                .Select(x => ((IdentifierExpression)x).Identifier)
                .ToArray();

            return path;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidExpression[] Flatten(AphidExpression exp)
        {
            var expressions = new List<AphidExpression>();

            switch (exp.Type)
            {
                case AphidExpressionType.BinaryOperatorExpression:
                    var binOpExp = (BinaryOperatorExpression)exp;
                    expressions.AddRange(Flatten(binOpExp.LeftOperand));
                    expressions.Add(binOpExp.RightOperand);
                    break;

                default:
                    expressions.Add(exp);
                    break;
            }

            return expressions.ToArray();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretCallExpression(CallExpression expression)
        {
            var value = InterpretExpression(expression.FunctionExpression);
            var funcExp = ValueHelper.Unwrap(value);

            if (funcExp == null)
            {
                throw CreateRuntimeException("Could not find function {0}", expression.FunctionExpression);
            }

            var args = expression.Args.Select(InterpretExpression).ToArray();

            return InterpretFunctionExpression(expression, expression.FunctionExpression, funcExp, args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretFunctionExpression(
            AphidExpression callExpression,
            AphidExpression expression,
            object funcExp,
            object[] args)
        {
            var func = funcExp as AphidInteropFunction;

            if (func != null)
            {
                var interopArgs = func.UnwrapParameters ?
                    args.Select(ValueHelper.Unwrap).ToArray() :
                    args;

                PushFrame(callExpression, expression, interopArgs);

                try
                {
                    return ValueHelper.Wrap(func.Invoke(this, interopArgs)); ;
                }
                finally
                {
                    PopFrame();
                }
            }

            // Todo: make this use enums rather than slow type casting
            var interopMembers = funcExp as AphidInteropMember;

            if (interopMembers != null)
            {
                return InterpretInteropCallExpression(
                    callExpression,
                    expression,
                    args.Select(ValueHelper.DeepUnwrap).ToArray(),
                    interopMembers);
            }

            var interopPartial = funcExp as AphidInteropPartialFunction;

            if (interopPartial != null)
            {
                var curArgs = args.Select(ValueHelper.DeepUnwrap).ToArray();

                return InterpretInteropCallExpression(
                    callExpression,
                    expression,
                    interopPartial.Applied
                        .Concat(curArgs)
                        .ToArray(),
                    interopPartial.Member);
            }

            var del = funcExp as Delegate;

            if (del != null)
            {
                PushFrame(callExpression, expression, args);

                try
                {
                    return ValueHelper.Wrap(
                        del.DynamicInvoke(
                            args.Select(ValueHelper.Unwrap).ToArray()));
                }
                finally
                {
                    PopFrame();
                }
            }

            var func2 = funcExp as AphidFunction;

            if (func2 != null)
            {
                PushFrame(callExpression, expression, args);

                try
                {
                    return CallFunctionCore(
                        func2,
                        args.Select(ValueHelper.Wrap).ToArray());
                }
                finally
                {
                    PopFrame();
                }
            }

            var composition = funcExp as AphidFunctionComposition;

            if (composition != null)
            {
                var retVal = InterpretFunctionExpression(
                    callExpression,
                    composition.LeftExpression,
                    composition.LeftFunction,
                    args);

                return InterpretFunctionExpression(
                    callExpression,
                    composition.RightExpression,
                    composition.RightFunction,
                    new[] { retVal });
            }

            throw CreateRuntimeException("Could not find function {0}", expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretImplicitArgumentExpression(AphidExpression expression)
        {
            return CurrentScope.Resolve(this, AphidName.ImplicitArg);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretImplicitArgumentsExpression(AphidExpression expression)
        {
            return CurrentScope.Resolve(
                this,
                AphidName.ImplicitArgs,
                "$args cannot be used outside of function.");
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(string name)
        {
            PushFrame(CreateNameFrame(name));
        }

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
                    case AphidExpressionType.IdentifierExpression:
                        return ((IdentifierExpression)functionExpression).Identifier;

                    case AphidExpressionType.BinaryOperatorExpression:
                        var operands = Flatten(functionExpression);

                        return operands.All(x => x.Type == AphidExpressionType.IdentifierExpression) ?
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
            Lazy<string> name,
            IEnumerable<object> args)
        {
            _frames.Push(new AphidFrame(this, CurrentScope, callExpression, name, args));

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, name.Value);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.Write(id);
            _framePerformanceBinaryWriter.Write(true);
            _framePerformanceBinaryWriter.Write(name.Value);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(name.Value, sw));
            sw.Start();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushFrame(AphidFrame frame)
        {
            _frames.Push(frame);

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var id = Thread.CurrentThread.ManagedThreadId;
#endif

#if TEXT_FRAME_PERFORMANCE_TRACE
            _framePerformanceTrace.TraceText("{0:x8} > {1}\r\n", id, frame.Name);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE
            // Todo: Pack enter/leave in as high order bit of thread id
            _framePerformanceBinaryWriter.Write(id);
            _framePerformanceBinaryWriter.Write(true);
            _framePerformanceBinaryWriter.Write(frame.Name);
#endif

#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
            var sw = new Stopwatch();
            _frameStopwatchStack.Push(Tuple.Create(frame.Name, sw));
            sw.Start();
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopFrame()
        {
#if BINARY_FRAME_PERFORMANCE_TRACE || TEXT_FRAME_PERFORMANCE_TRACE
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
            _framePerformanceBinaryWriter.Write(id);
            _framePerformanceBinaryWriter.Write(false);
            _framePerformanceBinaryWriter.Write(tup.Item1);
            _framePerformanceBinaryWriter.Write(tup.Item2.ElapsedTicks);
            _framePerformanceBinaryWriter.Write(tup.Item2.ElapsedMilliseconds);
#endif
            if (!_isInTryCatchFinally)
            {
                _frames.Pop();
            }
            else
            {
                _queuedFramePops++;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidFrame CreateEntryFrame()
        {
            return CreateNameFrame("[Entrypoint]");
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidFrame CreateNameFrame(string name)
        {
            return new AphidFrame(
                this,
                CurrentScope,
                CurrentExpression,
                new Lazy<string>(() => name));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretInteropCallExpression(
            AphidExpression callExpression,
            AphidExpression expression,
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

            PushFrame(
                callExpression,
                new Lazy<string>(() =>
                    string.Format("{0}.{1}", method.DeclaringType.FullName, method.Name)),
                convertedArgs);

            try
            {
                return ValueHelper.Wrap(
                    method.Invoke(
                        interopMembers.Target,
                        convertedArgs));
            }
            finally
            {
                PopFrame();
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
                    string.Format("{0}.{1}", method.DeclaringType.FullName, method.Name)),
                convertedArgs);

            try
            {
                return ValueHelper.Wrap(
                    method.Invoke(
                        interopMembers.Target,
                        convertedArgs));
            }
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidObject WrapInteropValue(object value)
        {
            if (AphidObject.IsAphidType(value))
            {
                return ValueHelper.Wrap(value);
            }
            else
            {
                throw CreateValueException(value, "Cannot wrap value");
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretInteropNewExpression(AphidExpression operand)
        {
            switch (operand.Type)
            {
                case AphidExpressionType.CallExpression:
                    var call = operand.ToCall();

                    var args = call.Args
                        .Select(InterpretExpression)
                        .Select(ValueHelper.DeepUnwrap)
                        .ToArray();

                    PushFrame(operand, operand, args);

                    try
                    {
                        var path = FlattenPath(call.FunctionExpression);
                        var type = InteropTypeResolver.ResolveType(GetImports().ToArray(), path, isType: true);
                        var ctor = InteropMethodResolver.Resolve(type.GetConstructors(), args);

                        var convertedArgs = TypeConverter.Convert(
                            ctor.Arguments,
                            ctor.GenericArguments);

                        var result = ((ConstructorInfo)ctor.Method).Invoke(convertedArgs);
                        var obj = ValueHelper.Wrap(result);

                        var extension = TypeExtender.TryResolve(
                            CurrentScope,
                            obj,
                            TypeExtender.GetCtorName(type.FullName),
                            false,
                            isCtor: true,
                            isDynamic: false,
                            returnRef: false);

                        if (extension != null)
                        {
                            var func = extension.Value as AphidFunction;

                            if (func != null)
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
            return new AphidObject(new AphidFunction()
            {
                Args = expression.Args
                    .Select(x => ((IdentifierExpression)x).Identifier)
                    .ToArray(),

                Body = expression.Body,
                ParentScope = CurrentScope,
            });
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretArrayExpression(ArrayExpression expression)
        {
            var list = new AphidObject(expression.Elements.Select(InterpretExpression).OfType<AphidObject>().ToList());

            return list;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretUnaryOperatorExpression(UnaryOperatorExpression expression)
        {
            if (!expression.IsPostfix)
            {
                switch (expression.Operator)
                {
                    case AphidTokenType.AdditionOperator:
                        return (AphidObject)InterpretExpression(expression.Operand);

                    case AphidTokenType.MinusOperator:
                        var val = ValueHelper.Unwrap(InterpretExpression(expression.Operand));

                        if (!(val is decimal))
                        {
                            throw CreateRuntimeException(
                                "Unary operator '-' expects number, {0} was provided instead.",
                                val.GetType());
                        }

                        return ValueHelper.Wrap((decimal)val * -1);

                    case AphidTokenType.ComplementOperator:
                        val = InterpretAndUnwrap(expression.Operand);
                        ValueHelper.AssertNumber(val, "unary operator '~'");

                        return ValueHelper.Wrap((decimal)~Convert.ToUInt64(val));

                    case AphidTokenType.retKeyword:
                        SetReturnValue(ValueHelper.Wrap(InterpretExpression(expression.Operand)));
                        _isReturning = true;
                        return null;

                    case AphidTokenType.deleteKeyword:
                        var operand = ((IdentifierExpression)expression.Operand).Identifier;
                        return new AphidObject(CurrentScope.TryResolveAndRemove(operand));

                    case AphidTokenType.NotOperator:
                        return new AphidObject(!(bool)ValueHelper.Unwrap(InterpretExpression(expression.Operand) as AphidObject));

                    case AphidTokenType.IncrementOperator:
                        var obj = InterpretExpression(expression.Operand) as AphidObject;
                        obj.Value = ((decimal)obj.Value) + 1;
                        return obj;

                    case AphidTokenType.DecrementOperator:
                        obj = InterpretExpression(expression.Operand) as AphidObject;
                        obj.Value = ((decimal)obj.Value) - 1;
                        return obj;

                    case AphidTokenType.DistinctOperator:
                        var opExp = InterpretExpression(expression.Operand);
                        var list = ((IEnumerable<object>)ValueHelper.UnwrapAndBoxCollection(opExp));

                        var result = list
                            .Select(ValueHelper.Unwrap)
                            .Distinct()
                            .Select(ValueHelper.Wrap) // To maintain backwards compat with Aphid
                            .ToList();                // list extension such as __list.count().

                        return ValueHelper.Wrap(result);

                    //return new AphidObject(list.Distinct(_comparer).ToList());

                    case AphidTokenType.usingKeyword:
                        var path = FlattenAndJoinPath(expression.Operand);
                        AddImport(path);

                        return null;

                    case AphidTokenType.newKeyword:
                        return InterpretInteropNewExpression(expression.Operand);

                    case AphidTokenType.loadKeyword:
                        // Todo: make more robust by searching application dir,
                        // script dir, etc.
                        Assembly asm = null;

                        switch (expression.Operand.Type)
                        {
                            case AphidExpressionType.IdentifierExpression:
                            case AphidExpressionType.BinaryOperatorExpression:
                                path = FlattenAndJoinPath(expression.Operand);
                                asm = Assembly.LoadWithPartialName(path);
                                break;

                            case AphidExpressionType.StringExpression:
                                var strExp = (StringExpression)expression.Operand;
                                var str = StringParser.Parse(strExp.Value);

                                if (File.Exists(path = Path.GetFullPath(str)))
                                {
                                    asm = Assembly.LoadFile(path);
                                }

                                break;
                        }

                        if (asm == null)
                        {
                            // Todo: safely deref member expression to avoid
                            // null ref exception on fallback.
                            var loadOperand = InterpretExpression(expression.Operand);
                            var unwrappedPath = ValueHelper.Unwrap(loadOperand);

                            if (unwrappedPath == null)
                            {
                                return new AphidObject(null);
                            }

                            if (File.Exists(path = unwrappedPath.ToString()))
                            {
                                asm = Assembly.LoadFile(path);
                            }
                        }

                        return new AphidObject(asm);

                    case AphidTokenType.InteropOperator:
                        var attr = GetInteropAttribute(expression.Operand);

                        switch (attr)
                        {
                            case null:
                                switch (expression.Operand.Type)
                                {
                                    case AphidExpressionType.CallExpression:
                                        var callExp = (CallExpression)expression.Operand;
                                        return CallStaticInteropFunction(callExp);

                                    case AphidExpressionType.BinaryOperatorExpression:
                                        return InterpretMemberInteropExpression(
                                            null,
                                            expression.Operand.ToBinaryOperator());

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
                    case AphidTokenType.CustomOperator320:
                    case AphidTokenType.CustomOperator321:
                    case AphidTokenType.CustomOperator322:
                    case AphidTokenType.CustomOperator323:
                    case AphidTokenType.CustomOperator324:
                    case AphidTokenType.CustomOperator325:
                    case AphidTokenType.CustomOperator326:
                    case AphidTokenType.CustomOperator327:
                    case AphidTokenType.CustomOperator328:
                    case AphidTokenType.CustomOperator329:
                    case AphidTokenType.CustomOperator330:
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
                    case AphidTokenType.IncrementOperator:
                        var obj = InterpretExpression(expression.Operand) as AphidObject;
                        var v = obj.Value;
                        obj.Value = ((decimal)obj.Value) + 1;
                        return new AphidObject(v);

                    case AphidTokenType.DecrementOperator:
                        obj = InterpretExpression(expression.Operand) as AphidObject;
                        v = obj.Value;
                        obj.Value = ((decimal)obj.Value) - 1;
                        return new AphidObject(v);

                    case AphidTokenType.definedKeyword:


                        if (expression.Operand is IdentifierExpression)
                        {
                            return new AphidObject(CurrentScope.IsDefined(expression.Operand.ToIdentifier().Identifier));
                        }
                        else if (expression.Operand is BinaryOperatorExpression)
                        {
                            var objRef = InterpretBinaryOperatorExpression(expression.Operand as BinaryOperatorExpression, true) as AphidRef;

                            return new AphidObject(objRef.Object.IsDefined(objRef.Name));
                        }
                        else
                        {
                            throw CreateRuntimeException("Unknown ? operand");
                        }


                    //var obj = InterpretExpression(

                    default:
                        throw CreateUnaryOperatorException(expression);
                }
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretBooleanExpression(BooleanExpression expression)
        {
            return new AphidObject(expression.Value);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretIfExpression(IfExpression expression)
        {
            if ((bool)ValueHelper.Unwrap(InterpretExpression(expression.Condition)))
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
        private AphidObject InterpretNumberExpression(NumberExpression expression)
        {
            return new AphidObject(expression.Value);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretArrayAccessExpression(ArrayAccessExpression expression)
        {
            var val = ValueHelper.Unwrap(InterpretExpression(expression.ArrayExpression));
            var index = Convert.ToInt32(ValueHelper.Unwrap(InterpretExpression(expression.KeyExpression)));
            var array = val as List<AphidObject>;
            string str;
            IList list;
            IEnumerable enumerable;

            if (array != null)
            {
                if (index < 0 || index >= array.Count)
                {
                    throw CreateRuntimeException("Index out of range: {0}.", index);
                }

                return array[index];
            }
            else if ((str = val as string) != null)
            {
                if (index < 0 || index >= str.Length)
                {
                    throw CreateOutOfBoundsException(expression, val, index, str.Length);
                }

                return new AphidObject(str[index].ToString());
            }
            else if ((list = val as IList) != null)
            {
                if (index < 0 || index >= list.Count)
                {
                    throw CreateOutOfBoundsException(expression, val, index, list.Count);
                }

                return ValueHelper.Wrap(list[index]);
            }
            else if ((enumerable = val as IEnumerable) != null)
            {
                var i = 0;

                foreach (var o in enumerable)
                {
                    if (i++ == index)
                    {
                        return new AphidObject(o);
                    }
                }

                throw CreateOutOfBoundsException(expression, val, index, i - 1);
            }
            else
            {
                throw CreateExpressionException(
                    expression.ArrayExpression,
                    val,
                    "Array access not supported by");
            }
        }

        private AphidRuntimeException CreateOutOfBoundsException(
            AphidExpression expression,
            object val,
            int index,
            int count)
        {
            return CreateExpressionException(
                expression,
                val,
                "Index {0} is out of bounds of {1} element collection",
                index,
                count);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretForExpression(ForExpression expression)
        {
            var inBodyScope = false;
            EnterScope();

            try
            {
                var init = InterpretExpression(expression.Initialization);

                while ((bool)(InterpretExpression(expression.Condition) as AphidObject).Value)
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
            var collection = InterpretExpression(expression.Collection) as AphidObject;
            var elements = collection.Value as IEnumerable;

            var elementId = expression.Element != null ?
                (expression.Element as IdentifierExpression).Identifier :
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
                    var obj = ValueHelper.Wrap(element);
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
        private AphidObject InterpretLoadScriptExpression(LoadScriptExpression expression)
        {
            var file = ValueHelper.Unwrap(InterpretExpression(expression.FileExpression)) as string;

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
                    Loader.SearchPaths.RemoveAt(Loader.SearchPaths.Count - 1);
                }
                else
                {
                    ast = Loader.LoadScript(file);
                }

                return new AphidObject(ast);
            }
            finally
            {
                PopFrame();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretLoadLibraryExpression(LoadLibraryExpression expression)
        {
            var library = ValueHelper.Unwrap(InterpretExpression(expression.LibraryExpression)) as string;

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
            var obj = (AphidObject)InterpretExpression(expression.Call.FunctionExpression);

            if (obj == null)
            {
                throw CreatePartialFunctionException(expression, obj);
            }

            var func = obj.Value as AphidFunction;
            if (func != null)
            {
                var partialArgCount = func.Args.Length - expression.Call.Args.Count();
                var partialArgs = func.Args.Skip(partialArgCount).ToArray();

                var partialFunc = new AphidFunction()
                {
                    Args = partialArgs,
                    Body = new List<AphidExpression> 
                    {
                        new UnaryOperatorExpression(AphidTokenType.retKeyword,
                            new CallExpression(
                                expression.Call.FunctionExpression, 
                                expression.Call.Args
                                    .Concat(partialArgs
                                        .Select((x, i) => (IdentifierExpression)new IdentifierExpression(x)
                                        .WithPositionFrom(expression.Call.Args[i])))
                                    .ToList())
                                .WithPositionFrom(expression.Call))
                            .WithPositionFrom(expression.Call),
                    },
                    ParentScope = CurrentScope,
                };

                return new AphidObject(partialFunc);
            }
            else
            {
                var interopObj = obj.Value as AphidInteropMember;

                if (interopObj == null)
                {
                    throw CreatePartialFunctionException(expression, obj);
                }

                // Todo: Fix partial application bug seemingly caused
                // by unwrapping Object[] when passed during call to partial.
                var applied = expression.Call.Args
                    .Select(InterpretExpression)
                    .Select(ValueHelper.DeepUnwrap)
                    .ToArray();

                return new AphidObject(new AphidInteropPartialFunction(interopObj, applied));
            }
        }

        private AphidRuntimeException CreatePartialFunctionException(
            PartialFunctionExpression expression,
            AphidObject obj)
        {
            return CreateExpressionException(
                expression.Call.FunctionExpression,
                obj != null ? obj.Value : null,
                "Cannot perform partial function application on");
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretPartialOperatorExpression(PartialOperatorExpression expression)
        {
            var name = "$po";

            var func = new AphidFunction()
            {
                Args = new[] { name },
                Body = new List<AphidExpression> 
                {
                    new UnaryOperatorExpression(
                        AphidTokenType.retKeyword,
                        new BinaryOperatorExpression(
                            new IdentifierExpression(name)
                                .WithPositionFrom(expression),
                            expression.Operator,
                            expression.Operand)
                            .WithPositionFrom(expression))
                        .WithPositionFrom(expression)
                },
            };

            return new AphidObject(func);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretThisExpression()
        {
            return CurrentScope;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretPatternMatchingExpression(PatternMatchingExpression expression)
        {
            var left = (AphidObject)InterpretExpression(expression.TestExpression);
            var leftType = left.Value != null ? left.Value.GetType() : null;

            foreach (var pattern in expression.Patterns)
            {
                if (pattern.Patterns != null && pattern.Patterns.Any())
                {
                    foreach (var patternTest in pattern.Patterns)
                    {
                        var right = (AphidObject)InterpretExpression(patternTest);
                        var rightType = right.Value != null ? right.Value.GetType() : null;

                        if (InterpretEqualityExpression(
                            left.Value,
                            leftType,
                            right.Value,
                            rightType))
                        {
                            return ValueHelper.Wrap(InterpretExpression(pattern.Value));
                        }
                    }
                }
                else
                {
                    return ValueHelper.Wrap(InterpretExpression(pattern.Value));
                }
            }

            return new AphidObject();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretExtendExpression(ExtendExpression expression)
        {
            var obj = InterpretObjectExpression(expression.Object);

            var dynamic = GetModifiedKey(expression, "dynamic");
            var ctor = GetModifiedKey(expression, "ctor");

            TypeExtender.Extend(
                expression.ExtendType,
                obj,
                ctor.SingleOrDefault(),
                dynamic.SingleOrDefault());
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string[] GetModifiedKey(ExtendExpression expression, string modifier)
        {
            var modified = expression.Object.Pairs
                .Where(x =>
                    x.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
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
            while ((bool)((AphidObject)(InterpretExpression(expression.Condition))).Value)
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
            } while ((bool)((AphidObject)(InterpretExpression(expression.Condition))).Value);
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
                    var ex = new AphidObject();
                    ex.Add("message", new AphidObject(ExceptionHelper.Unwrap(e).Message));
                    ex.Add("exception", new AphidObject(e));
                    ex.Add("stack", new AphidObject(ExceptionHelper.StackTrace(GetStackTrace())));
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
            bool nested;

            if (!_isInTryCatchFinally)
            {
                nested = false;
                _isInTryCatchFinally = true;
            }
            else
            {
                nested = true;
            }

            if (expression.FinallyBody == null)
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                catch (Exception e)
                {
#if DEBUG
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
#if DEBUG
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

            if (!nested)
            {
                _isInTryCatchFinally = false;
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretTextExpression(TextExpression expression)
        {
            WriteOut(expression.Text);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretGatorEmitExpression(GatorEmitExpression expression)
        {
            var obj = InterpretExpression(expression.Expression);

            if (obj == null)
            {
                return;
            }

            var result = ValueHelper.Unwrap(obj).ToString();

            if (GatorEmitFilter != null)
            {
                result = GatorEmitFilter(result);
            }

            WriteOut(result);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private AphidObject InterpretTernaryOperatorExpression(TernaryOperatorExpression expression)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.ConditionalOperator:
                    bool conditionResult;
                    var c = InterpretExpression(expression.FirstOperand);

                    try
                    {
                        conditionResult = (bool)ValueHelper.Unwrap(c);
                    }
                    catch (InvalidCastException)
                    {
                        throw CreateRuntimeException(
                            "Conditional operator expected boolean, got '{0}' of type '{1}'.",
                            c,
                            c != null ? c.GetType().FullName : "null");
                    }

                    var result = InterpretExpression(
                        conditionResult ?
                            expression.SecondOperand :
                            expression.ThirdOperand);

                    return ValueHelper.Wrap(result);

                default:
                    throw new InvalidOperationException();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InterpretSwitchExpression(SwitchExpression expression)
        {
            var exp = (AphidObject)InterpretExpression(expression.Expression);

            foreach (var c in expression.Cases)
            {
                foreach (var c2 in c.Cases)
                {
                    var caseValue = (AphidObject)InterpretExpression(c2);

                    if (!InterpretEqualityExpression(
                        exp.Value,
                        exp.Value.GetType(),
                        caseValue.Value,
                        caseValue.Value.GetType()))
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
        public object InterpretStream(string code)
        {
            var ast = AphidParser.Parse(code);
#if APHID_SET_CODE_VAR
            SetAstCode(ast);
#endif
            var mutatedAst = new PartialOperatorMutator().MutateRecursively(ast);
            mutatedAst = new AphidMacroMutator().MutateRecursively(mutatedAst);
            mutatedAst = new AphidIdDirectiveMutator().MutateRecursively(mutatedAst);

            foreach (var exp in mutatedAst)
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
        public object Interpret(AphidExpression expression)
        {
#if APHID_SET_CODE_VAR
            SetAstCode(new List<AphidExpression> { expression });
#endif
            return InterpretExpression(expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretExpression(AphidExpression expression)
        {
            while (_queuedFramePops > 0)
            {
                _frames.Pop();
                _queuedFramePops--;
            }

            CurrentExpression = expression;
            HandleDebugging(expression);
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
                case AphidExpressionType.BinaryOperatorExpression:
                    return InterpretBinaryOperatorExpression((BinaryOperatorExpression)expression);

                case AphidExpressionType.BinaryOperatorBodyExpression:
                    return InterpretBinaryOperatorBodyExpression((BinaryOperatorBodyExpression)expression);

                case AphidExpressionType.ObjectExpression:
                    return InterpretObjectExpression((ObjectExpression)expression);

                case AphidExpressionType.StringExpression:
                    return InterpretStringExpression((StringExpression)expression);

                case AphidExpressionType.NumberExpression:
                    return InterpretNumberExpression((NumberExpression)expression);

                case AphidExpressionType.CallExpression:
                    return InterpretCallExpression((CallExpression)expression);

                case AphidExpressionType.IdentifierExpression:
                    return InterpretIdentifierExpression((IdentifierExpression)expression);

                case AphidExpressionType.FunctionExpression:
                    return InterpretFunctionExpression((FunctionExpression)expression);

                case AphidExpressionType.ArrayExpression:
                    return InterpretArrayExpression((ArrayExpression)expression);

                case AphidExpressionType.UnaryOperatorExpression:
                    return InterpretUnaryOperatorExpression((UnaryOperatorExpression)expression);

                case AphidExpressionType.BooleanExpression:
                    return InterpretBooleanExpression((BooleanExpression)expression);

                case AphidExpressionType.IfExpression:
                    return InterpretIfExpression((IfExpression)expression);

                case AphidExpressionType.ArrayAccessExpression:
                    return InterpretArrayAccessExpression((ArrayAccessExpression)expression);

                case AphidExpressionType.ForEachExpression:
                    return InterpretForEachExpression((ForEachExpression)expression);

                case AphidExpressionType.ForExpression:
                    return InterpretForExpression((ForExpression)expression);

                case AphidExpressionType.LoadScriptExpression:
                    return InterpretLoadScriptExpression((LoadScriptExpression)expression);

                case AphidExpressionType.LoadLibraryExpression:
                    return InterpretLoadLibraryExpression((LoadLibraryExpression)expression);

                case AphidExpressionType.NullExpression:
                    return new AphidObject(null);

                case AphidExpressionType.ContinueExpression:
                    return InterpretContinueExpression();

                case AphidExpressionType.BreakExpression:
                    return InterpretBreakExpression();

                case AphidExpressionType.PartialFunctionExpression:
                    return InterpretPartialFunctionExpression((PartialFunctionExpression)expression);

                case AphidExpressionType.ThisExpression:
                    return InterpretThisExpression();

                case AphidExpressionType.PatternMatchingExpression:
                    return InterpretPatternMatchingExpression((PatternMatchingExpression)expression);

                case AphidExpressionType.ExtendExpression:
                    InterpretExtendExpression((ExtendExpression)expression);

                    return null;

                case AphidExpressionType.WhileExpression:
                    InterpretWhileExpression((WhileExpression)expression);

                    return null;

                case AphidExpressionType.DoWhileExpression:
                    InterpretDoWhileExpression((DoWhileExpression)expression);

                    return null;

                case AphidExpressionType.TryExpression:
                    InterpretTryExpression((TryExpression)expression);

                    return null;

                case AphidExpressionType.TernaryOperatorExpression:
                    return InterpretTernaryOperatorExpression((TernaryOperatorExpression)expression);

                case AphidExpressionType.SwitchExpression:
                    InterpretSwitchExpression((SwitchExpression)expression);

                    return null;

                case AphidExpressionType.TextExpression:
                    InterpretTextExpression((TextExpression)expression);

                    return null;

                case AphidExpressionType.GatorOpenExpression:
                case AphidExpressionType.GatorCloseExpression:
                    return null;

                case AphidExpressionType.GatorEmitExpression:
                    InterpretGatorEmitExpression((GatorEmitExpression)expression);

                    return null;

                case AphidExpressionType.PartialOperatorExpression:
                    var partialOpExp = (PartialOperatorExpression)expression;

                    return InterpretPartialOperatorExpression(partialOpExp);

                case AphidExpressionType.ImplicitArgumentExpression:
                    return InterpretImplicitArgumentExpression((ImplicitArgumentExpression)expression);

                case AphidExpressionType.ImplicitArgumentsExpression:
                    return InterpretImplicitArgumentsExpression((ImplicitArgumentsExpression)expression);

                default:
                    throw CreateRuntimeException("Unexpected expression {0}", expression);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private object InterpretAndUnwrap(AphidExpression expression)
        {
            return ValueHelper.Unwrap(InterpretExpression(expression));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InterpretFile(string filename)
        {
            InterpretFile(filename, false);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InterpretFile(string filename, bool isTextDocument)
        {
            var fullFilename = Loader.FindScriptFile(filename);

            if (fullFilename == null)
            {
                throw CreateRuntimeException("Cannot find script {0}", filename);
            }

            SetScriptFilename(fullFilename);
            var code = File.ReadAllText(filename);
            Interpret(code, filename, isTextDocument);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(string code)
        {
            Interpret(code, false);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Interpret(string code, bool isTextDocument)
        {
            Interpret(code, null, isTextDocument);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Interpret(string code, string filename, bool isTextDocument)
        {
            var ast = AphidParser.Parse(code, filename, isTextDocument);
#if APHID_SET_CODE_VAR
            SetAstCode(ast);
#endif
            var mutatedAst = new PartialOperatorMutator().MutateRecursively(ast);
            mutatedAst = new AphidMacroMutator().MutateRecursively(mutatedAst);
            mutatedAst = new AphidIdDirectiveMutator().MutateRecursively(mutatedAst);

            Interpret(mutatedAst);
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
                new AphidInterpreter(CurrentScope.CreateChild(), Loader).Interpret(expressions);
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Interpret(List<AphidExpression> expressions, bool resetIsReturning = true)
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
                CurrentScope.Add(AphidName.Block, new AphidObject(expressions));
            }

            for (var i = 0; i < expressions.Count || _insertNextBuffer != null; i++)
            {
                if (_insertNextBuffer != null)
                {
                    expressions.InsertRange(i, _insertNextBuffer);
                    _insertNextBuffer = null;
                }

                var expression = expressions[i];
                CurrentStatement = CurrentExpression = expression;

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

                if (expression.Type == AphidExpressionType.IdentifierExpression)
                {
                    HandleDebugging(expression);
                    var id = expression.ToIdentifier().Identifier;

                    if (CurrentScope.ContainsKey(id))
                    {
                        throw CreateRuntimeException("Duplicated variable declaration: {0}", id);
                    }

                    CurrentScope.Add(id, new AphidObject());
                }
                else
                {
                    InterpretExpression(expression);
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
        public AphidFrame[] GetStackTrace()
        {
            return _frames.ToArray();
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
            CurrentScope.Add(AphidName.Code, new AphidObject(node != null ? node.Code : null));
        }
#endif

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetState()
        {
            while (CurrentScope != null && CurrentScope.Parent != null)
            {
                CurrentScope = CurrentScope.Parent;
            }

            // Todo: Add test cases to cover try/catch influence
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

            if (CurrentScope.ContainsKey(AphidName.Block))
            {
                CurrentScope.Remove(AphidName.Block);
            }

            if (CurrentScope.ContainsKey(AphidName.Script))
            {
                CurrentScope.Remove(AphidName.Script);
            }

#if APHID_SET_CODE_VAR
            if (CurrentScope.ContainsKey(AphidName.Code))
            {
                CurrentScope.Remove(AphidName.Code);
            }
#endif
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void HandleDebugging(AphidExpression expression)
        {
            if (_isSingleStepping)
            {
                BreakExecution(expression);
            }

            if (expression.HasBreakpoint)
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
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void BreakExecution(AphidExpression expression)
        {
            if (HandleExecutionBreak != null)
            {
                new Thread(() => HandleExecutionBreak(expression)) { IsBackground = true }
                    .Start();
            }
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Continue()
        {
            _breakpointReset.Set();

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

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Pause()
        {
            SingleStep();
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateRuntimeException(string message, params object[] args)
        {
            return new AphidRuntimeException(CurrentScope, CurrentStatement, CurrentExpression, message, args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateRuntimeException(
            AphidExpression expression,
            object obj)
        {
            return CreateRuntimeException(
                "Unhandled exception caused by ",
                GetExpressionValueString(expression, obj));
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateValueException(
            object obj,
            string message,
            params object[] args)
        {
            return CreateRuntimeException(
                string.Format("{0} {1}",
                    message,
                    Cli.FormatEscape(GetValueString(obj))),
                args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateExpressionException(
            AphidExpression expression,
            object obj,
            string message,
            params object[] args)
        {
            return CreateRuntimeException(
                string.Format(
                    "{0} {1}",
                    message,
                    Cli.FormatEscape(GetExpressionValueString(expression, obj))),
                args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidRuntimeException CreateInternalException(string message, params object[] args)
        {
            return new AphidInternalException(
                CurrentScope,
                CurrentStatement,
                CurrentExpression,
                message,
                args);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetExpressionValueString(AphidExpression expression, object obj)
        {
            return string.Format(
                "{0}, which was evaluated from '{1}'.",
                GetValueString(obj),
                expression);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string GetValueString(object obj)
        {
            return obj != null ?
                string.Format("'{0}' of type '{1}'", obj, AphidType.GetName(obj)) :
                "null";
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool SetIsInTryCatchFinally(bool value)
        {
            var old = _isInTryCatchFinally;
            _isInTryCatchFinally = true;

            return old;
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Type GetIpcContextType()
        {
            return typeof(AphidIpcContext);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RegisterIpcServer()
        {
            AphidIpcContext.Register(this);
        }

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AphidIpcContext CreateIpcClientContext()
        {
            return IpcContext = new AphidIpcContext();
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

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void TakeOwnership()
        {
            OwnerThread = Thread.CurrentThread.ManagedThreadId;
        }
    }
}
