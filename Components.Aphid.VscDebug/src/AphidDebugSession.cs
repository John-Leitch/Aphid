
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
using Components.Aphid.UI.Formatters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
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
        private SortedDictionary<long, AphidExpression> _breakpoints;
        private System.Diagnostics.Process _process;
        private Handles<KeyValuePair<string, AphidObject>[]> _variableHandles;
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
            _variableHandles = new Handles<KeyValuePair<string, AphidObject>[]>();
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
            string programPath = getString(arguments, "program");
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
            bool debug = !getBool(arguments, "noDebug", false);

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

            var host = getString(arguments, "address");
            if (host == null)
            {
                SendErrorResponse(response, 3007, "Property 'address' is missing or empty.");
                return;
            }

            // validate argument 'port'
            var port = getInt(arguments, "port", -1);
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
                    _breakpoints.Clear();
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
            int frameId = getInt(arguments, "frameId", 0);
            Program.Log($"Getting frame ID {frameId}");
            var frame = _frameHandles.Get(frameId, null);

            var scopes = new List<Scope>();
            var kvps = _frameScopes[frameId].ToArray();
            
            var localsHandle = _variableHandles.Create(kvps
                .Where(x =>
                    !x.Key.StartsWith("$") ||
                    x.Key == "$args" ||
                    x.Key == "$block" ||
                    x.Key == "$_")
                .ToArray());

            var specialsHandle = _variableHandles.Create(kvps
                .Where(x => x.Key.StartsWith("$"))
                .ToArray());

            scopes.Add(new Scope("Locals", localsHandle));
            scopes.Add(new Scope("Special Variables", specialsHandle));

            if (_exception != null)
            {
                var exScope = Complex();
                exScope.Add("object", Scalar(_exception));
                exScope.Add("message", Scalar(_exception.Message));
                exScope.Add("clrStack", Scalar(_exception.StackTrace));
                exScope.Add("inner", Scalar(_exception.InnerException));
                exScope.Add("hresult", Scalar(_exception.HResult));

                var exHandle = _variableHandles.Create(exScope.ToArray());
                scopes.Add(new Scope("Exception", exHandle));
            }

#if EXPRESSION_HISTORY
            var expRecords = Interpreter.ExpressionHistory.Take(Interpreter.ExpressionHistoryIndex);

            if (Interpreter.ExpressionHistoryCount >= AphidInterpreter.ExpressionHistorySize)
            {
                expRecords = Interpreter.ExpressionHistory
                    .Skip(Interpreter.ExpressionHistoryIndex)
                    .Concat(expRecords);
            }

            var historyScope = Complex();
            var i = 0;
            foreach (var rec in expRecords.Take(Interpreter.ExpressionHistoryCount))
            {
                //var expRecordObj = Complex();
                //expRecordObj.Add("statement", Scalar(rec.Statement));
                //expRecordObj.Add("frames", Scalar(rec.Frames));
                //expRecordObj.Add("block", Scalar(rec.Block));
                //expRecordObj.Add("blockIndex", Scalar(rec.BlockIndex));
                historyScope.Add($"[#{i++:x4},Depth={rec.Frames.Length:x2},Index={rec.BlockIndex:x2}]", Scalar(rec));
            }

            scopes.Add(new Scope(
                "Statement Tracing",
                _variableHandles.Create(historyScope.ToArray())));
#endif

            SendResponse(response, new ScopesResponseBody(scopes));
        }

        public override void Variables(Response response, dynamic arguments)
        {
            int reference = getInt(arguments, "variablesReference", -1);
            if (reference == -1)
            {
                SendErrorResponse(response, 3009, "variables: property 'variablesReference' is missing", null, false, true);
                return;
            }

            //Program.Log("[variables] Waiting for {0}", reference);
            WaitForSuspend();
            //Program.Log("[variables] Done waiting for {0}", reference);
            var variables = new List<Variable>();

            if (_variableHandles.TryGet(reference, out var children))
            {
                Program.Log("[variables] Got {0} children for {1}", children.Length, reference);
                foreach (var c in children)
                {
                    //Program.Log(
                    //    "[variables] Got child for {0}: {1}",
                    //    reference,
                    //    c.Value != null ? c.Value.GetType().FullName : c.ToString());

                    if (c.Value == null)
                    {
                        variables.Add(CreateVariable(c));
                    }
                    else if (c.Value.Value == null)
                    {
                        variables.Add(CreateVariable(c));
                        //c.Value.ToArray()
                        //foreach (var kvp in c.Value)
                        //{
                        //    variables.Add(CreateVariable(kvp));
                        //}
                    }
                    else if (false && c.Value.Value.GetType() == typeof(List<AphidObject>))
                    {
                        variables.Add(
                            CreateVariable(
                                new KeyValuePair<string, AphidObject>(
                                    c.Key,
                                    Scalar(c.Value.GetList()))));

                        //variables.Add(CreateVariable(c));
                        foreach (var o in c.Value.GetList().Select(x => x.ToArray()))
                        {
                        }
                        //variables.Add(CreateVariable(c));

                        foreach (var obj in c.Value.GetList())
                        {
                            //new KeyValuePair<string, AphidObject>(c.Key, obj.Va

                            //foreach (var kvp in obj)
                            //{
                            //    variables.Add(CreateVariable(kvp));
                            //}
                        }
                    }
                    else
                    {
                        variables.Add(CreateVariable(c));
                    }
                }

                //variables.AddRange(children
                //    .Where(x => x != null)
                //    .SelectMany(x => x
                //        .Where(y => y.Key != null)
                //        .Select(y => CreateVariable(y.Key, y.Value))));
                //.GroupBy(x => x.Key)
                //.Select(x => x.First().Key, x.First().Value)));
                //variables.AddRange(children
                //    .SelectMany(x => x.ToArray())
                //    .GroupBy(x => x.Key)
                //    .Select(x => CreateVariable(x.First().Key, x.First().Value)));
            }
            else if (false)
            {
                if (children?.Length > 0)
                {
                    var more = false;
                    if (children.Length > _maxChildren)
                    {
                        children = children.Take(_maxChildren).ToArray();
                        more = true;
                    }

                    if (children.Length < 20)
                    {
                        // Wait for all values at once.
                        //WaitHandle.WaitAll(children.Select(x => x.WaitHandle).ToArray());
                        foreach (var v in children)
                        {
                            //variables.Add(CreateVariable(v));
                        }
                    }
                    else
                    {
                        foreach (var v in children)
                        {
                            //v.WaitHandle.WaitOne();
                            //variables.Add(CreateVariable(v));
                        }
                    }

                    if (more)
                    {
                        variables.Add(new Variable("...", null, null));
                    }
                }
            }
            else
            {
                Program.Log("No variable handle created");
            }

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
                        SendEvent(new ThreadEvent("exited", _threadId));
                        //Terminate("target exited");
                    }).Start();
                    _isRunning = true;

                    reset.WaitOne();
                    var threads2 = new List<Thread>();
                    threads2.Add(new Thread(_threadId, "Main Thread"));
                    SendResponse(response, new ThreadsResponseBody(threads2));
                }

                return;
            }

            var threads = new List<Thread>();
            threads.Add(new Thread(_threadId, "Main Thread"));
            SendResponse(response, new ThreadsResponseBody(threads));
        }

        public override void ExceptionInfo(Response response, dynamic arguments) =>
            SendResponse(
                response,
                new ExceptionInfoResponseBody(
                    string.Format(
                        "{0} on thread 0x{1:x}",
                        _exception.GetType().Name,
                        getInt(arguments, "threadId")),
                    _exception.Message,
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
            var expStr = (string)getString(arguments, "expression");
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

            var v = CreateVariable(new KeyValuePair<string, AphidObject>(expStr, value));
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
            _variableHandles.Reset();
            _frameHandles.Reset();
        }

        private static string GetObjectPreview(AphidObject obj) =>
            obj.Keys.Count > 0 ? string.Format("{{ {0} }}", string.Join(", ", obj.Keys)) : "{ [Empty] }";

        private static string GetCollectionPreview(IEnumerable collection)
        {
            var c = collection.Cast<object>().Count();
            return string.Format("[ {0:n0} element{1} ]", c, c != 1 ? "s" : "");
        }

        private Variable CreateVariable(KeyValuePair<string, AphidObject> v)
        {
            if (v.Value == null || (v.Value.IsScalar && v.Value.Value == null))
            {
                return new Variable(v.Key, "null", AphidType.Null);
            }
            else if (v.Value.Value == null)
            {
                return new Variable(
                    v.Key,
                    GetObjectPreview(v.Value),
                    AphidType.Object,
                    _variableHandles.Create(v.Value.ToArray()));
            }
            else
            {
                if (v.Value.Value.GetType() == typeof(List<AphidObject>))
                {
                    return new Variable(
                        v.Key,
                        GetCollectionPreview((List<AphidObject>)v.Value.Value),
                        AphidType.List,
                        _variableHandles.Create(((List<AphidObject>)v.Value.Value)
                            .SelectMany((x, i) => x.Value == null ?
                                x.ToArray() :
                                new[]
                                {
                                    new KeyValuePair<string, AphidObject>(
                                        i.ToString(),
                                        ValueHelper.Wrap(x.Value))
                                })
                            .ToArray()));
                }
                else if (v.Value.Value.GetType() == typeof(AphidObject))
                {
                    return new Variable(
                        v.Key,
                        GetObjectPreview((AphidObject)v.Value.Value),
                        AphidType.Object,
                        _variableHandles.Create(((AphidObject)v.Value.Value).ToArray()));
                }
                //else if (v.Value.IsAphidType())
                //{
                //    return new Variable(
                //        v.Key,
                //        new AphidSerializer(Interpreter).Serialize(v.Value),
                //        v.Value.GetValueType(),
                //        0);
                //}
                else if (v.Value.Value.GetType() != typeof(string) &&
                    v.Value.Value.GetType().GetInterface("IEnumerable") != null)
                {
                    var l = new List<AphidObject>();

                    foreach (var o in (IEnumerable)v.Value.Value)
                    {
                        l.Add(ValueHelper.Wrap(o));
                    }

                    return new Variable(
                        v.Key,
                        GetCollectionPreview(l),
                        "list",
                        _variableHandles.Create(l
                            .Select((x, i) => new KeyValuePair<string, AphidObject>(
                                i.ToString(),
                                x))
                            .ToArray()));
                }
                else
                {
                    var t = v.Value.Value.GetType();

                    //Program.Log("Reflecting type {0}", t.FullName);

                    if (t.IsPrimitive || t.IsEnum)
                    {
                        return new Variable(v.Key, v.Value.Value.ToString(), t.FullName);
                    }

                    return new Variable(
                        v.Key,
                        v.Value.Value.ToString(),
                        t.FullName,
                        _variableHandles.Create(t
                            .GetProperties(BindingFlags.Public |
                                    BindingFlags.Instance |
                                    BindingFlags.Static |
                                    BindingFlags.FlattenHierarchy)
                            .Where(x => x.GetIndexParameters().Length == 0)
                            .Select((x, i) => new KeyValuePair<string, AphidObject>(
                                x.Name,
                                ValueHelper.Wrap(TryGetValue(x, v.Value.Value))))
                            .Concat(
                                t
                                .GetFields(BindingFlags.Public |
                                    BindingFlags.Instance |
                                    BindingFlags.Static |
                                    BindingFlags.FlattenHierarchy)
                                .Select((y, j) => new KeyValuePair<string, AphidObject>(
                                    y.Name,
                                    ValueHelper.Wrap(TryGetValue(y, v.Value.Value)))))
                            .ToArray()));
                }
            }
        }

        private object TryGetValue(FieldInfo field, object target)
        {
            try
            {
                return field.GetValue(target);
            }
            catch (Exception e)
            {
                Program.Log(e.ToString());
                return $"Error evaluating field: {e.ToString()}";
            }
        }

        private object TryGetValue(PropertyInfo property, object target)
        {
            try
            {
                return property.GetValue(target);
            }
            catch (Exception e)
            {
                Program.Log($"Property error: {e.InnerException}");
                return $"Error evaluating property: {e.ToString()}";
            }
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

        private static bool getBool(dynamic container, string propertyName, bool dflt = false)
        {
            try
            {
                return (bool)container[propertyName];
            }
            catch (Exception)
            {
                // ignore and return default value
            }
            return dflt;
        }

        private static int getInt(dynamic container, string propertyName, int dflt = 0)
        {
            try
            {
                return (int)container[propertyName];
            }
            catch (Exception)
            {
                // ignore and return default value
            }
            return dflt;
        }

        private static string getString(dynamic args, string property, string dflt = null)
        {
            var s = (string)args[property];
            if (s == null)
            {
                return dflt;
            }
            s = s.Trim();
            if (s.Length == 0)
            {
                return dflt;
            }
            return s;
        }

        //-----------------------

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
