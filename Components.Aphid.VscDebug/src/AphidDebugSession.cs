using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI.Formatters;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using static Components.Aphid.TypeSystem.AphidObject;

namespace VSCodeDebug
{
    public class AphidDebugSession : DebugSession
    {
        private readonly string[] _fileExtensions = new[] { ".alx" };

        private const int _maxChildren = 10000,
            _maxConnectionAttempts = 10,
            _connectionAttemptInterval = 500;

        private AutoResetEvent _resumeEvent = new AutoResetEvent(false);
        private bool _debuggeeExecuting;
        private readonly object _lock = new object();

        private volatile bool _debuggeeKilled = true;
        //private SortedDictionary<long, AphidExpression> _breakpoints;
        private ObjectExplorer _explorer = new ObjectExplorer();
        private System.Diagnostics.Process _process;
        private Handles<StackFrame> _frameHandles;
        private Dictionary<int, AphidObject> _frameScopes = new Dictionary<int, AphidObject>();
        public AphidObject _exceptionScope;
        private Exception _exception;
        private readonly Dictionary<int, Thread> _seenThreads = new Dictionary<int, Thread>();
        private bool _attachMode;
        private string _script;
        private int _threadId;
        private string _code;
        private List<AphidExpression> _ast;
        private bool _isRunning;

        public AphidInterpreter Interpreter { get; } = new AphidInterpreter();

        public AphidDebugSession()
            : base()
        {
            _frameHandles = new Handles<StackFrame>();
            _seenThreads = new Dictionary<int, Thread>();
            Interpreter.CurrentScope.Add("$debugger", Scalar(this));
            Interpreter.HandleExecutionBreak = HandleBreak;
        }

        private void HandleBreak(AphidExpression expression)
        {
            Program.Log("Execution break on {0}", expression.ToString());
            Stopped();
            Program.Log("Stopped on {0}", expression.ToString());

            SendEvent(
                new StoppedEvent(
                    _threadId,
                    "breakpoint",
                    expression.ToString()));

            _resumeEvent.Set();
        }

        public override void Initialize(Response response, dynamic arguments)
        {
            var os = Environment.OSVersion;

            if (os.Platform != PlatformID.MacOSX &&
                os.Platform != PlatformID.Unix &&
                os.Platform != PlatformID.Win32NT)
            {
                SendErrorResponse(response, 3000, "Aphid is not supported on this platform ({_platform}).", new { _platform = os.Platform.ToString() }, true, true);
                return;
            }

            SendResponse(response, new Capabilities()
            {
                // This debug adapter does not need the configurationDoneRequest.
                supportsConfigurationDoneRequest = false,

                // This debug adapter does not support function breakpoints.
                supportsFunctionBreakpoints = false,

                // This debug adapter doesn't support conditional breakpoints.
                supportsConditionalBreakpoints = true,

                // This debug adapter does not support a side effect free evaluate request for data hovers.
                supportsEvaluateForHovers = true,

                supportsExceptionInfoRequest = true,
#if EXPRESSION_HISTORY
                supportsStepBack = true,
#else
                supportsStepBack = false,
#endif
                //supportsModulesRequest = true,
                //supportsSetExpression = true,

                supportsSetVariable = true,

                // This debug adapter does not support exception breakpoint filters
                exceptionBreakpointFilters = new dynamic[0]
            });

            // Mono Debug is ready to accept breakpoints immediately
            SendEvent(new InitializedEvent());
        }

        public List<AphidExpression> Parse(Response response, string file)
        {
            var code = File.ReadAllText(file);

            try
            {
                return MutatorGroups.GetStandard().Mutate(AphidParser.Parse(code, file));
            }
            catch (AphidParserException e)
            {
                SendErrorResponse(
                    response,
                    0x523000,
                    ParserErrorMessage.Create(code, e, highlight: false));

                return null;
            }
        }

        public override async void Launch(Response response, dynamic arguments)
        {
            _attachMode = false;

            //SetExceptionBreakpoints(args.__exceptionOptions);

            // validate argument 'program'
            string programPath = DynamicHelper.GetString(arguments, "program");
            if (programPath == null)
            {
                SendErrorResponse(response, 3001, "Property 'program' is missing or empty.", null);
                return;
            }

            //Program.Log("Program path: {0}\r\n", programPath);

            programPath = ConvertClientPathToDebugger(programPath);
            if (!File.Exists(programPath) && !Directory.Exists(programPath))
            {
                SendErrorResponse(response, 3002, "Program '{path}' does not exist.", new { path = programPath });
                return;
            }

            // validate argument 'cwd'
            var workingDirectory = (string)arguments.cwd;
            if (workingDirectory != null)
            {
                workingDirectory = workingDirectory.Trim();
                if (workingDirectory.Length == 0)
                {
                    SendErrorResponse(response, 3003, "Property 'cwd' is empty.");
                    return;
                }
                workingDirectory = ConvertClientPathToDebugger(workingDirectory);
                if (!Directory.Exists(workingDirectory))
                {
                    SendErrorResponse(response, 3004, "Working directory '{path}' does not exist.", new { path = workingDirectory });
                    return;
                }
            }

            // Todo: handle case insensitive file systems and forward slashes
            _script = Path.GetFullPath(programPath).Replace('/', '\\');
            _code = File.ReadAllText(programPath);

            if ((_ast = Parse(response, _script)) == null)
            {
                return;
            }

            const string host = "127.0.0.1";
            var port = Utilities.FindFreePort(55555);
            bool debug = !DynamicHelper.GetBool(arguments, "noDebug", false);

            if (debug)
            {
                Connect(IPAddress.Parse(host), port);
            }

            var termArgs = new
            {
                kind = "external",
                title = "Aphid Debug Console",
                cwd = workingDirectory,
                args = programPath,
                //env = environmentVariables
            };

            var resp = await SendRequest("runInTerminal", termArgs);

            SendResponse(response);
        }

        public override void Attach(Response response, dynamic arguments)
        {
            _attachMode = true;

            var host = DynamicHelper.GetString(arguments, "address");
            if (host == null)
            {
                SendErrorResponse(response, 3007, "Property 'address' is missing or empty.");
                return;
            }

            // validate argument 'port'
            var port = DynamicHelper.GetInt(arguments, "port", -1);
            if (port == -1)
            {
                SendErrorResponse(response, 3008, "Property 'port' is missing.");
                return;
            }

            IPAddress address = Utilities.ResolveIPAddress(host);
            if (address == null)
            {
                SendErrorResponse(response, 3013, "Invalid address '{address}'.", new { address });
                return;
            }

            Connect(address, port);

            SendResponse(response);
        }

        public override void Disconnect(Response response, dynamic arguments)
        {
            if (_attachMode)
            {
                lock (_lock)
                {
                    //if (_session != null) {
                    _debuggeeExecuting = true;
                    //_breakpoints.Clear();
                    //_session.Breakpoints.Clear();
                    //_session.Continue();
                    //_session = null;
                    //}
                }
            }
            else
            {
                // Let's not leave dead Mono processes behind...
                if (_process != null)
                {
                    _process.Kill();
                    _process = null;
                }
                else
                {
                    //PauseDebugger();
                    DebuggerKill();

                    while (!_debuggeeKilled)
                    {
                        System.Threading.Thread.Sleep(10);
                    }
                }
            }

            SendResponse(response);
        }

        public override void Continue(Response response, dynamic arguments)
        {
            WaitForSuspend();
            SendResponse(response);
            Interpreter.Continue();
            //Program.Log("Continuing execution");

            _debuggeeExecuting = true;
            //lock (_lock) {
            //    if (_session != null && !_session.IsRunning && !_session.HasExited) {
            //        _session.Continue();
            //        _debuggeeExecuting = true;
            //    }
            //}
        }

        public override void Next(Response response, dynamic arguments)
        {
            WaitForSuspend();
            SendResponse(response);
            Interpreter.SingleStep();
            _debuggeeExecuting = true;
            //lock (_lock) {
            //    if (_session != null && !_session.IsRunning && !_session.HasExited) {
            //        _session.NextLine();
            //        _debuggeeExecuting = true;
            //    }
            //}
        }

        public override void StepIn(Response response, dynamic arguments)
        {
            WaitForSuspend();
            SendResponse(response);
            Interpreter.SingleStep();
            _debuggeeExecuting = true;
            //         lock (_lock) {
            //    if (_session != null && !_session.IsRunning && !_session.HasExited) {
            //        _session.StepLine();
            //        _debuggeeExecuting = true;
            //    }
            //}
        }

        public override void StepOut(Response response, dynamic arguments)
        {
            WaitForSuspend();
            SendResponse(response);
            Interpreter.SingleStep();
            _debuggeeExecuting = true;
            //         lock (_lock) {
            //    if (_session != null && !_session.IsRunning && !_session.HasExited) {
            //        _session.Finish();
            //        _debuggeeExecuting = true;
            //    }
            //}
        }

#if EXPRESSION_HISTORY
        public override void StepBack(Response response, dynamic arguments)
        {
            WaitForSuspend();
            SendResponse(response);
            Interpreter.SingleStepBack();
            _debuggeeExecuting = true;
        }
#endif

        public override void Pause(Response response, dynamic arguments)
        {
            SendResponse(response);
            PauseDebugger();
        }

        public override void SetExceptionBreakpoints(Response response, dynamic arguments) => SendResponse(response);

        public override void SetBreakpoints(Response response, dynamic arguments)
        {
            string path = null;
            if (arguments.source != null)
            {
                var p = (string)arguments.source.path;
                if (p?.Trim().Length > 0)
                {
                    path = p;
                }
            }
            if (path == null)
            {
                SendErrorResponse(response, 3010, "setBreakpoints: property 'source' is empty or misformed", null, false, true);
                return;
            }
            path = ConvertClientPathToDebugger(path);

            if (!HasAphidExtension(path))
            {
                SendResponse(response, new SetBreakpointsResponseBody());
                return;
            }

            var sourceBreakpoints = (SourceBreakpoint[])arguments.breakpoints
                .ToObject<SourceBreakpoint[]>();

            //var clientLines = sourceBreakpoints.Select(x => x.line).ToArray();

            //var conditions = sourceBreakpoints.Select(x => x.condition).ToArray();
            //var breakpoints = arguments.breakpoints.ToObject<dynamic[]>();

            var bps = new AphidBreakpointController().UpdateBreakpoints(
                this,
                response,
                path,
                sourceBreakpoints);

            if (bps == null)
            {
                return;
            }

            SendResponse(response, new SetBreakpointsResponseBody(bps));

            //         HashSet<int> lin = new HashSet<int>();
            //for (int i = 0; i < clientLines.Length; i++) {
            //    lin.Add(ConvertClientLineToDebugger(clientLines[i]));
            //}

            // find all breakpoints for the given path and remember their id and line number
            //var bpts = new List<Tuple<int, int>>();
            //foreach (var be in _breakpoints) {
            //    var bp = be.Value as Mono.Debugging.Client.Breakpoint;
            //    if (bp != null && bp.FileName == path) {
            //        bpts.Add(new Tuple<int,int>((int)be.Key, (int)bp.Line));
            //    }
            //}

            //HashSet<int> lin2 = new HashSet<int>();
            //foreach (var bpt in bpts) {
            //    if (lin.Contains(bpt.Item2)) {
            //        lin2.Add(bpt.Item2);
            //    }
            //    else {
            //        // Program.Log("cleared bpt #{0} for line {1}", bpt.Item1, bpt.Item2);

            //        BreakEvent b;
            //        if (_breakpoints.TryGetValue(bpt.Item1, out b)) {
            //            _breakpoints.Remove(bpt.Item1);
            //            _session.Breakpoints.Remove(b);
            //        }
            //    }
            //}

            //for (int i = 0; i < clientLines.Length; i++) {
            //    var l = ConvertClientLineToDebugger(clientLines[i]);
            //    if (!lin2.Contains(l)) {
            //        var id = _nextBreakpointId++;
            //        _breakpoints.Add(id, _session.Breakpoints.Add(path, l));
            //        // Program.Log("added bpt #{0} for line {1}", id, l);
            //    }
            //}

            //var breakpoints = new List<Breakpoint>();
            //foreach (var l in clientLines) {
            //    breakpoints.Add(new Breakpoint(true, l));
            //}

            //SendResponse(response, new SetBreakpointsResponseBody(breakpoints));
        }

        public override void StackTrace(Response response, dynamic arguments)
        {
            var id = 0;

            var lineResolver = new AphidLineResolver();

            StackFrame nextFrame(AphidExpression expression)
            {
                var (line, col) = lineResolver.ResolvePosition(
                    GetAst(response, expression),
                    expression);

                return new StackFrame(
                    id++,
                    expression.ToString(),
                    GetSource(expression),
                    line,
                    col,
                    "normal");
            }

            StackFrame[] expFrames;

            var extraFrames = 0;

            if (Interpreter.CurrentExpression != null)
            {
                if (Interpreter.CurrentStatement != null &&
                    Interpreter.CurrentStatement != Interpreter.CurrentExpression)
                {
                    Program.Log("Current exp and stmt added to frames");
                    expFrames = new[]
                    {
                        nextFrame(Interpreter.CurrentExpression),
                        nextFrame(Interpreter.CurrentStatement)
                    };

                    extraFrames = 2;
                }
                else
                {
                    Program.Log("Current exp added to frames");
                    expFrames = new[] { nextFrame(Interpreter.CurrentExpression) };
                    extraFrames = 1;
                }
            }
            //if (Interpreter.CurrentExpression != null)
            //{
            //    expFrames = new[] { nextFrame(Interpreter.CurrentExpression) };
            //    extraFrames = 1;
            //}
            else if (Interpreter.CurrentStatement != null)
            {
                Program.Log("Current stmt added to frames");
                expFrames = new[] { nextFrame(Interpreter.CurrentStatement) };
                extraFrames = 1;
            }
            else
            {
                expFrames = Array.Empty<StackFrame>();
            }

            var aphidFrames = Interpreter.GetRawStackTrace();

            var stackFrames = expFrames
                .Concat(aphidFrames
                    .Select(x =>
                    {
                        var (line, col) = lineResolver.ResolvePosition(
                            GetAst(response, x.Expression),
                            x.Expression);

                        return new StackFrame(
                            id++,
                            x.ToString(),
                            GetSource(x.Expression),
                            line,
                            col,
                            "normal");
                    }))
                .ToList();

            var frames2 = new List<StackFrame>();            
            _frameScopes.Clear();
            var i = 0 - extraFrames;
            foreach (var f in stackFrames)
            {
                var scope = i < 0 ?
                    (_exception == null ?
                        Interpreter.CurrentScope :
                    _exception.Data.Contains(AphidName.Scope) ?
                        (AphidObject)_exception.Data[AphidName.Scope] :
                        aphidFrames[0].Scope) :
                    aphidFrames[i].Scope;

                if (!_frameScopes.ContainsKey(f.id))
                {
                    _frameScopes.Add(f.id, scope);
                }

                

                Program.Log($"Created frame {i}: {f.name}");
                //frames2.Add(new StackFrame(handle, f.name, f.source, f.line, f.column, f.presentationHint));
                frames2.Add(f);
                i++;
            }

            SendResponse(response, new StackTraceResponseBody(frames2, frames2.Count));
        }

        private List<AphidExpression> GetAst(Response response, AphidExpression expression)
        {
            Program.Log("Getting filename from {0}", expression);

            var file = expression?.Filename != null ?
                Parse(response, expression.Filename) :
                _ast;

            Program.Log("Filename: {0}", expression?.Filename);

            return file;
        }

        private Source GetSource(AphidExpression expression) => expression?.Filename != null ?
                new VSCodeDebug.Source(
                    Path.GetFileName(expression.Filename),
                    Path.GetFullPath(expression.Filename),
                    0,
                    "normal") :
                new VSCodeDebug.Source(
                    Path.GetFileName(_script),
                    _script,
                    0,
                    "normal");

        public override void Source(Response response, dynamic arguments) => SendErrorResponse(response, 1020, "No source available");

        public override void Scopes(Response response, dynamic arguments)
        {
            int frameId = DynamicHelper.GetInt(arguments, "frameId", 0);
            Program.Log($"Getting frame ID {frameId}");
            var frame = _frameHandles.Get(frameId, null);
            var scope = _frameScopes[frameId];
            var scopes = _explorer.Scopes(Interpreter, frame, scope, _exception);
            SendResponse(response, new ScopesResponseBody(scopes));
        }

        public override void Variables(Response response, dynamic arguments)
        {
            int reference = DynamicHelper.GetInt(arguments, "variablesReference", -1);
            if (reference == -1)
            {
                SendErrorResponse(response, 3009, "variables: property 'variablesReference' is missing", null, false, true);
                return;
            }

            //Program.Log("[variables] Waiting for {0}", reference);
            WaitForSuspend();
            //Program.Log("[variables] Done waiting for {0}", reference);
            var variables = _explorer.Variables(reference);
            SendResponse(response, new VariablesResponseBody(variables));
        }

        private void HandleException(AphidInterpreter interpreter, Exception exception)
        {
            Program.Log("Unhandled exception: {0}", exception.Message);
            Stopped();
            _exception = exception;

            if (exception.Data.Contains(AphidName.Scope))
            {
                _exceptionScope = (AphidObject)exception.Data[AphidName.Scope];
            }

            SendEvent(
                new StoppedEvent(
                    _threadId,
                    "exception",
                    ExceptionHelper.Unwrap(exception).ToString()));

            _resumeEvent.Set();
        }

        public override void Threads(Response response, dynamic arguments)
        {
            if (!_isRunning)
            {
                using (var reset = new ManualResetEvent(false))
                {
                    new System.Threading.Thread(() =>
                    {
                        _threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
                        reset.Set();
                        SendEvent(new ThreadEvent("started", _threadId));

                        var backup = Interpreter.SetIsInTryCatchFinally(true);
                        Interpreter.CurrentScope.Add(AphidName.Script, Scalar(_script));

                        try
                        {
                            Interpreter.Interpret(_ast);
                        }
                        catch (Exception e)
                        {
                            HandleException(Interpreter, e);
                        }

                        Interpreter.SetIsInTryCatchFinally(false);
                        Cli.WriteInfoMessage("Thread ~Cyan~0x{0:x8}~R~ exited", _threadId);
                        SendEvent(new ThreadEvent("exited", _threadId));
                        //Stop();
                        //Terminate("target exited");
                    })
                    {
                        IsBackground = true
                    }
                    .Start();
                    _isRunning = true;

                    reset.WaitOne();
                    var threads2 = new List<Thread> { new Thread(_threadId, "Main Thread") };
                    SendResponse(response, new ThreadsResponseBody(threads2));
                }

                return;
            }

            var threads = new List<Thread> { new Thread(_threadId, "Main Thread") };
            SendResponse(response, new ThreadsResponseBody(threads));
        }

        public override void ExceptionInfo(Response response, dynamic arguments) =>
            SendResponse(
                response,
                new ExceptionInfoResponseBody(
                    string.Format(
                        "{0} on thread 0x{1:x}",
                        ExceptionHelper.Unwrap(_exception).GetType().Name,
                        DynamicHelper.GetInt(arguments, "threadId")),
                    ExceptionHelper.Unwrap(_exception).Message,
                    details: CreateExceptionDetails(_exception)));

        private ExceptionDetails CreateExceptionDetails(Exception exception) =>
            new ExceptionDetails()
            {
                message = exception.Message,
                typeName = exception.GetType().Name,
                fullTypeName = exception.GetType().FullName,
                evaluateName = null,
                stackTrace = string.Join(
                    "\r\n",
                    Interpreter
                        .GetRawStackTrace()
                        .Select(x => x.ToString())) + "\r\n\r\n" +
                    exception.StackTrace,
                innerException = exception.InnerException != null ?
                    new[] { CreateExceptionDetails(exception.InnerException) } :
                    null
            };

        public override void Evaluate(Response response, dynamic arguments)
        {
            var expStr = (string)DynamicHelper.GetString(arguments, "expression");
            var exp = AphidParser.ParseExpression(expStr);

            var retExp =
                exp.Type != AphidExpressionType.UnaryOperatorExpression ||
                ((UnaryOperatorExpression)exp).Operator != AphidTokenType.retKeyword ?
                    new UnaryOperatorExpression(
                        AphidTokenType.retKeyword,
                        exp,
                        isPostfix: false)
                        .WithPositionFrom(exp) :
                    exp;

            AphidObject value = null;

            try
            {
                value = Interpreter.CreateChild(createChildScope: false).Interpret(exp);
            }
            catch (Exception e)
            {
                SendErrorResponse(response, 3014, ErrorFormatter.FormatByType(e, expStr));
            }

            if (value == null)
            {
                return;
            }

            var v = _explorer.CreateVariable(new KeyValuePair<string, AphidObject>(expStr, value));
            SendResponse(response, new EvaluateResponseBody(v.value, v.variablesReference));


            //var value = (AphidObject)new AphidInterpreter(Interpreter.CurrentScope).Interpret(exp);

            //if (false)
            //{
            //    SendErrorResponse(response, 3014, "Evaluate request failed, invalid expression");
            //}
            //else
            //{
            //    var handle = _variableHandles.Create(value.ToArray());
            //    SendResponse(
            //        response,
            //        new EvaluateResponseBody(
            //            new AphidSerializer(Interpreter).Serialize(value),
            //            handle));
            //}
        }

        private void Stopped()
        {
            _exception = null;
            _explorer.Reset();
            _frameHandles.Reset();
        }
        
        private bool HasAphidExtension(string path)
        {
            foreach (var e in _fileExtensions)
            {
                if (path.EndsWith(e))
                {
                    return true;
                }
            }
            return false;
        }

        private void WaitForSuspend()
        {
            if (_debuggeeExecuting)
            {
                Program.Log("[i] Debuggee waiting for resume event");
                _resumeEvent.WaitOne();
                Program.Log("[+] Debuggee resumeevent set");
                _debuggeeExecuting = false;
            }
            else
            {
                //Program.Log("[!] Debuggee not executing");
            }
        }

        private void Connect(IPAddress address, int port)
        {
            lock (_lock)
            {
                _debuggeeKilled = false;

                _debuggeeExecuting = true;
            }
        }

        private void PauseDebugger() => Interpreter.Pause();

        private void DebuggerKill() => Environment.Exit(0);
    }
}
