/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Net;
//using Mono.Debugging.Client;
using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Library;
using System.Text;
using Components.Aphid.Lexer;
using Components.Json;
using VSCodeDebug.src;
using System.Collections;

namespace VSCodeDebug
{
	public class MonoDebugSession : DebugSession
	{
		private const string MONO = "aphid";
		private readonly string[] MONO_EXTENSIONS = new String[] {
			".alx"
		};
		private const int MAX_CHILDREN = 10000;
		private const int MAX_CONNECTION_ATTEMPTS = 10;
		private const int CONNECTION_ATTEMPT_INTERVAL = 500;

		private AutoResetEvent _resumeEvent = new AutoResetEvent(false);
		private bool _debuggeeExecuting = false;
		private readonly object _lock = new object();
		//private Mono.Debugging.Soft.SoftDebuggerSession _session;
		private volatile bool _debuggeeKilled = true;
		//private ProcessInfo _activeProcess;
		//private Mono.Debugging.Client.StackFrame _activeFrame;
		private long _nextBreakpointId = 0;
		private SortedDictionary<long, AphidExpression> _breakpoints;
		//private List<Catchpoint> _catchpoints;
		//private DebuggerSessionOptions _debuggerSessionOptions;

		private System.Diagnostics.Process _process;
		private Handles<KeyValuePair<string, AphidObject>[]> _variableHandles;
        private Dictionary<AphidObject, string> _scopeNames = new Dictionary<AphidObject, string>();
		private Handles<StackFrame> _frameHandles;
        private Dictionary<int, AphidFrame[]> _aphidFrameMap = new Dictionary<int, AphidFrame[]>();
        private Dictionary<int, AphidObject> _frameScopes = new Dictionary<int, AphidObject>();
		private AphidObject _exception;
		private Dictionary<int, Thread> _seenThreads = new Dictionary<int, Thread>();
		private bool _attachMode = false;
		private bool _terminated = false;
		private bool _stderrEOF = true;
		private bool _stdoutEOF = true;
        private string _script;
        private int _threadId;        
        private string _code;
        private List<AphidExpression> _ast;
        private AphidInterpreter _interpreter = new AphidInterpreter();
        private bool _isRunning = false;


		public MonoDebugSession() : base()
		{
			_variableHandles = new Handles<KeyValuePair<string, AphidObject>[]>();
			_frameHandles = new Handles<StackFrame>();
			_seenThreads = new Dictionary<int, Thread>();
            _interpreter.HandleExecutionBreak = HandleBreak;

			//_debuggerSessionOptions = new DebuggerSessionOptions {
			//	EvaluationOptions = EvaluationOptions.DefaultOptions
			//};

			//_session = new Mono.Debugging.Soft.SoftDebuggerSession();
			//_session.Breakpoints = new BreakpointStore();

			//_breakpoints = new SortedDictionary<long, BreakEvent>();
			//_catchpoints = new List<Catchpoint>();

			//DebuggerLoggingService.CustomLogger = new CustomLogger();

			//_session.ExceptionHandler = ex => {
			//	return true;
			//};

			//_session.LogWriter = (isStdErr, text) => {
			//};

			//_session.TargetStopped += (sender, e) => {
			//	Stopped();
			//	SendEvent(CreateStoppedEvent("step", e.Thread));
			//	_resumeEvent.Set();
			//};

			//_session.TargetHitBreakpoint += (sender, e) => {
			//	Stopped();
			//	SendEvent(CreateStoppedEvent("breakpoint", e.Thread));
			//	_resumeEvent.Set();
			//};

			//_session.TargetExceptionThrown += (sender, e) => {
			//	Stopped();
			//	var ex = DebuggerActiveException();
			//	if (ex != null) {
			//		_exception = ex.Instance;
			//		SendEvent(CreateStoppedEvent("exception", e.Thread, ex.Message));
			//	}
			//	_resumeEvent.Set();
			//};

			//_session.TargetUnhandledException += (sender, e) => {
			//	Stopped ();
			//	var ex = DebuggerActiveException();
			//	if (ex != null) {
			//		_exception = ex.Instance;
			//		SendEvent(CreateStoppedEvent("exception", e.Thread, ex.Message));
			//	}
			//	_resumeEvent.Set();
			//};

			//_session.TargetStarted += (sender, e) => {
			//	_activeFrame = null;
			//};

			//_session.TargetReady += (sender, e) => {
			//	_activeProcess = _session.GetProcesses().SingleOrDefault();
			//};

			//_session.TargetExited += (sender, e) => {

			//	DebuggerKill();

			//	_debuggeeKilled = true;

			//	Terminate("target exited");

			//	_resumeEvent.Set();
			//};

			//_session.TargetInterrupted += (sender, e) => {
			//	_resumeEvent.Set();
			//};

			//_session.TargetEvent += (sender, e) => {
			//};

			//_session.TargetThreadStarted += (sender, e) => {
			//	int tid = (int)e.Thread.Id;
			//	lock (_seenThreads) {
			//		_seenThreads[tid] = new Thread(tid, e.Thread.Name);
			//	}
			//	SendEvent(new ThreadEvent("started", tid));
			//};

			//_session.TargetThreadStopped += (sender, e) => {
			//	int tid = (int)e.Thread.Id;
			//	lock (_seenThreads) {
			//		_seenThreads.Remove(tid);
			//	}
			//	SendEvent(new ThreadEvent("exited", tid));
			//};

			//_session.OutputWriter = (isStdErr, text) => {
			//	SendOutput(isStdErr ? "stderr" : "stdout", text);
			//};
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

		public override void Initialize(Response response, dynamic args)
		{
			OperatingSystem os = Environment.OSVersion;
			if (os.Platform != PlatformID.MacOSX && os.Platform != PlatformID.Unix && os.Platform != PlatformID.Win32NT) {
				SendErrorResponse(response, 3000, "Mono Debug is not supported on this platform ({_platform}).", new { _platform = os.Platform.ToString() }, true, true);
				return;
			}

			SendResponse(response, new Capabilities() {
				// This debug adapter does not need the configurationDoneRequest.
				supportsConfigurationDoneRequest = false,

				// This debug adapter does not support function breakpoints.
				supportsFunctionBreakpoints = false,

				// This debug adapter doesn't support conditional breakpoints.
				supportsConditionalBreakpoints = false,

				// This debug adapter does not support a side effect free evaluate request for data hovers.
				supportsEvaluateForHovers = false,

				// This debug adapter does not support exception breakpoint filters
				exceptionBreakpointFilters = new dynamic[0],
			});

			// Mono Debug is ready to accept breakpoints immediately
			SendEvent(new InitializedEvent());
		}

        

        public override async void Launch(Response response, dynamic args)
		{
			_attachMode = false;

			//SetExceptionBreakpoints(args.__exceptionOptions);

			// validate argument 'program'
			string programPath = getString(args, "program");
			if (programPath == null) {
				SendErrorResponse(response, 3001, "Property 'program' is missing or empty.", null);
				return;
			}

            //Program.Log("Program path: {0}\r\n", programPath);

			programPath = ConvertClientPathToDebugger(programPath);
			if (!File.Exists(programPath) && !Directory.Exists(programPath)) {
				SendErrorResponse(response, 3002, "Program '{path}' does not exist.", new { path = programPath });
				return;
			}

			// validate argument 'cwd'
			var workingDirectory = (string)args.cwd;
			if (workingDirectory != null) {
				workingDirectory = workingDirectory.Trim();
				if (workingDirectory.Length == 0) {
					SendErrorResponse(response, 3003, "Property 'cwd' is empty.");
					return;
				}
				workingDirectory = ConvertClientPathToDebugger(workingDirectory);
				if (!Directory.Exists(workingDirectory)) {
					SendErrorResponse(response, 3004, "Working directory '{path}' does not exist.", new { path = workingDirectory });
					return;
				}
			}

            //var w = new StringWriter(sb);
            var w = new ConsoleTextWriter();
            w.DataReceived += (o, e) => SendOutput("stdout", e.Data);
            Console.SetOut(w);
            //_interpreter.Out = new StreamWriter(s);
            //Console.SetOut(_interpreter.Out);
            //Console.IsOutputRedirected = true;
            //Console.
            
            _script = programPath;
            _code = File.ReadAllText(programPath);
            _ast = AphidParser.Parse(_code);
            //_interpreter.Interpret(_ast);

            const string host = "127.0.0.1";
            int port = Utilities.FindFreePort(55555);
            bool debug = !getBool(args, "noDebug", false);

            if (debug)
            {
                Connect(IPAddress.Parse(host), port);
            }

            SendResponse(response);
            return;
		}

		public override void Attach(Response response, dynamic args)
		{
			_attachMode = true;

			//SetExceptionBreakpoints(args.__exceptionOptions);

			// validate argument 'address'
			var host = getString(args, "address");
			if (host == null) {
				SendErrorResponse(response, 3007, "Property 'address' is missing or empty.");
				return;
			}

			// validate argument 'port'
			var port = getInt(args, "port", -1);
			if (port == -1) {
				SendErrorResponse(response, 3008, "Property 'port' is missing.");
				return;
			}

			IPAddress address = Utilities.ResolveIPAddress(host);
			if (address == null) {
				SendErrorResponse(response, 3013, "Invalid address '{address}'.", new { address = address });
				return;
			}

			Connect(address, port);

			SendResponse(response);
		}

		public override void Disconnect(Response response, dynamic args)
		{
			if (_attachMode) {

				lock (_lock) {
					//if (_session != null) {
						_debuggeeExecuting = true;
						_breakpoints.Clear();
						//_session.Breakpoints.Clear();
						//_session.Continue();
						//_session = null;
					//}
				}

			} else {
				// Let's not leave dead Mono processes behind...
				if (_process != null) {
					_process.Kill();
					_process = null;
				} else {
					//PauseDebugger();
					DebuggerKill();

					while (!_debuggeeKilled) {
						System.Threading.Thread.Sleep(10);
					}
				}
			}

			SendResponse(response);
		}

		public override void Continue(Response response, dynamic args)
		{
            WaitForSuspend();
            SendResponse(response);
            _interpreter.Continue();
            //Program.Log("Continuing execution");
            
            

            _debuggeeExecuting = true;
			//lock (_lock) {
			//	if (_session != null && !_session.IsRunning && !_session.HasExited) {
			//		_session.Continue();
			//		_debuggeeExecuting = true;
			//	}
			//}
		}

		public override void Next(Response response, dynamic args)
		{
			WaitForSuspend();
			SendResponse(response);
            _interpreter.SingleStep();
            _debuggeeExecuting = true;
			//lock (_lock) {
			//	if (_session != null && !_session.IsRunning && !_session.HasExited) {
			//		_session.NextLine();
			//		_debuggeeExecuting = true;
			//	}
			//}
		}

		public override void StepIn(Response response, dynamic args)
		{
			WaitForSuspend();
			SendResponse(response);
            _interpreter.SingleStep();
            _debuggeeExecuting = true;
   //         lock (_lock) {
			//	if (_session != null && !_session.IsRunning && !_session.HasExited) {
			//		_session.StepLine();
			//		_debuggeeExecuting = true;
			//	}
			//}
		}

		public override void StepOut(Response response, dynamic args)
		{
			WaitForSuspend();
			SendResponse(response);
            _interpreter.SingleStep();
            _debuggeeExecuting = true;
   //         lock (_lock) {
			//	if (_session != null && !_session.IsRunning && !_session.HasExited) {
			//		_session.Finish();
			//		_debuggeeExecuting = true;
			//	}
			//}
		}

		public override void Pause(Response response, dynamic args)
		{
			SendResponse(response);
			PauseDebugger();
		}

		public override void SetExceptionBreakpoints(Response response, dynamic args)
		{
			//SetExceptionBreakpoints(args.exceptionOptions);
			SendResponse(response);
		}



        public override void SetBreakpoints(Response response, dynamic args)
		{
            string path = null;
			if (args.source != null) {
				string p = (string)args.source.path;
				if (p != null && p.Trim().Length > 0) {
					path = p;
				}
			}
			if (path == null) {
				SendErrorResponse(response, 3010, "setBreakpoints: property 'source' is empty or misformed", null, false, true);
				return;
			}
			path = ConvertClientPathToDebugger(path);

            

            if (!HasMonoExtension(path)) {
				// we only support breakpoints in files mono can handle
				SendResponse(response, new SetBreakpointsResponseBody());
				return;
			}

            var clientLines = (int[])args.lines.ToObject<int[]>();
            var bps = new AphidBreakpointController(_code, _ast)
                .UpdateBreakpoints(clientLines);

            SendResponse(response, new SetBreakpointsResponseBody(bps));

            

   //         HashSet<int> lin = new HashSet<int>();
			//for (int i = 0; i < clientLines.Length; i++) {
			//	lin.Add(ConvertClientLineToDebugger(clientLines[i]));
			//}

			// find all breakpoints for the given path and remember their id and line number
			//var bpts = new List<Tuple<int, int>>();
			//foreach (var be in _breakpoints) {
			//	var bp = be.Value as Mono.Debugging.Client.Breakpoint;
			//	if (bp != null && bp.FileName == path) {
			//		bpts.Add(new Tuple<int,int>((int)be.Key, (int)bp.Line));
			//	}
			//}

			//HashSet<int> lin2 = new HashSet<int>();
			//foreach (var bpt in bpts) {
			//	if (lin.Contains(bpt.Item2)) {
			//		lin2.Add(bpt.Item2);
			//	}
			//	else {
			//		// Program.Log("cleared bpt #{0} for line {1}", bpt.Item1, bpt.Item2);

			//		BreakEvent b;
			//		if (_breakpoints.TryGetValue(bpt.Item1, out b)) {
			//			_breakpoints.Remove(bpt.Item1);
			//			_session.Breakpoints.Remove(b);
			//		}
			//	}
			//}

			//for (int i = 0; i < clientLines.Length; i++) {
			//	var l = ConvertClientLineToDebugger(clientLines[i]);
			//	if (!lin2.Contains(l)) {
			//		var id = _nextBreakpointId++;
			//		_breakpoints.Add(id, _session.Breakpoints.Add(path, l));
			//		// Program.Log("added bpt #{0} for line {1}", id, l);
			//	}
			//}

			//var breakpoints = new List<Breakpoint>();
			//foreach (var l in clientLines) {
			//	breakpoints.Add(new Breakpoint(true, l));
			//}

			//SendResponse(response, new SetBreakpointsResponseBody(breakpoints));
		}

		public override void StackTrace(Response response, dynamic args)
		{
			//int maxLevels = getInt(args, "levels", 10);
			//int threadReference = getInt(args, "threadId", 0);

			//WaitForSuspend();

			//ThreadInfo thread = DebuggerActiveThread();
			//if (thread.Id != threadReference) {
			//	// Program.Log("stackTrace: unexpected: active thread should be the one requested");
			//	thread = FindThread(threadReference);
			//	if (thread != null) {
			//		thread.SetActive();
			//	}
			//}

			//var stackFrames = new List<StackFrame>();
			//int totalFrames = 0;

			//var bt = thread.Backtrace;
			//if (bt != null && bt.FrameCount >= 0) {

			//	totalFrames = bt.FrameCount;

			//	for (var i = 0; i < Math.Min(totalFrames, maxLevels); i++) {

			//		var frame = bt.GetFrame(i);

			//		string path = frame.SourceLocation.FileName;

			//		var hint = "subtle";
			//		Source source = null;
			//		if (!string.IsNullOrEmpty(path)) {
			//			string sourceName = Path.GetFileName(path);
			//			if (!string.IsNullOrEmpty(sourceName)) {
			//				if (File.Exists(path)) {
			//					source = new Source(sourceName, ConvertDebuggerPathToClient(path), 0, "normal");
			//					hint = "normal";
			//				} else {
			//					source = new Source(sourceName, null, 1000, "deemphasize");
			//				}
			//			}
			//		}

			//		var frameHandle = _frameHandles.Create(frame);
			//		string name = frame.SourceLocation.MethodName;
			//		int line = frame.SourceLocation.Line;
			//		stackFrames.Add(new StackFrame(frameHandle, name, source, ConvertDebuggerLineToClient(line), 0, hint));
			//	}
			//}

            var id = 0;

            var lineResolver = new AphidLineResolver(_code, _ast);

            var currentFrame = new StackFrame(
                id++,
                _interpreter.CurrentStatement.ToString(),
                new Source(Path.GetFileName(_script), _script, 0, "normal"),
                lineResolver.ResolveExpressionLine(_interpreter.CurrentStatement),
                0,
                "test2");

            var aphidFrames = _interpreter.GetStackTrace();

            var stackFrames = aphidFrames
                .Select(x => new StackFrame(
                    id++,
                    x.Name,
                    new VSCodeDebug.Source(
                        Path.GetFileName(_script),
                        _script,
                        0,
                        "normal"),
                    lineResolver.ResolveExpressionLine(x.Expression),
                    0,
                    "test2"))
                .ToList();

            

            stackFrames.Insert(0, currentFrame);

            var frames2 = new List<StackFrame>();
            //frames2.Add(new StackFrame(
            //    _frameHandles.Create(currentFrame),
            //    currentFrame.name,
            //    currentFrame.source,
            //    currentFrame.line,
            //    currentFrame.column,
            //    currentFrame.presentationHint

            //_frameScopes.Clear();

            var i = -1;
            foreach (var f in stackFrames)
            {
                var handle = _frameHandles.Create(f);
                var scope = ++i == 0 ?
                        _interpreter.CurrentScope :
                        aphidFrames[i - 1].Scope;

                if (!_aphidFrameMap.ContainsKey(handle))
                {
                    _aphidFrameMap.Add(handle, aphidFrames.Skip(i - 1).ToArray());

                    Program.Log(
                        "VSC Frame: {0}, Aphid Frames: {1}",
                        f.name,
                        string.Join(", ", _aphidFrameMap[handle].Select(x => x.Name)));
                }

                if (!_frameScopes.ContainsKey(handle))
                {
                    _frameScopes.Add(handle, scope);
                }

                if (!_scopeNames.ContainsKey(scope))
                {
                    _scopeNames.Add(scope, f.name);
                }

                frames2.Add(new StackFrame(handle, f.name, f.source, f.line, f.column, f.presentationHint));
            }

			SendResponse(response, new StackTraceResponseBody(frames2, frames2.Count));
		}

		public override void Source(Response response, dynamic arguments) {
			SendErrorResponse(response, 1020, "No source available");
		}

		public override void Scopes(Response response, dynamic args) {

			int frameId = getInt(args, "frameId", 0);
			var frame = _frameHandles.Get(frameId, null);

            foreach (var kvp in _frameScopes)
            {
                Program.Log(
                    "Frame scope {0}: {1}",
                    kvp.Key,
                    new AphidSerializer().Serialize(kvp.Value));
            }

            var scopes = new List<Scope>();
            var kvps = _frameScopes[frameId].ToArray();
            _variableHandles.Create(kvps.Where(x => x.Value != null).SelectMany(x => x.Value).ToArray());
            scopes.Add(new Scope(frame.name, _variableHandles.Create(kvps)));

            var mergedScope = new AphidObject();
            var aphidScopes = _frameScopes[frameId].FlattenScope();

            scopes.Add(new Scope("Locals", _variableHandles.Create(_frameScopes[frameId].FlattenScope().SelectMany(x => x).ToArray())));

            foreach (var aphidScope in aphidScopes)
            {
                
                //foreach (var kvp in aphidScope)
                //{
                //    if (mergedScope.ContainsKey(kvp.Key))
                //    {
                //        continue;
                //    }
                //    else
                //    {
                //        mergedScope.Add(kvp.Key, kvp.Value);
                //    }
                //}
            }

            Program.Log("Merged scope keys: {0}", string.Join(", ", mergedScope.Keys));

            
            //scopes.Add(new Scope("locals", _variableHandles.Create(aphidScopes)));
            


            //foreach (var aphidScope in mergedScope.Where(x => x.Value != null))
            //{
            //    var handle = _variableHandles.Create(
            //        aphidScope.Value
            //            .ToArray()
            //            .Select(x => x.Value)
            //            .ToArray());

            //}

            SendResponse(response, new ScopesResponseBody(scopes));
		}

        private string[] _ignoreKeys = new[] { "asfd"/*AphidName.Scope, AphidName.Parent, AphidName.Block, AphidName.Code*/ };

        //private int CreateVariableHandles(AphidObject scope)
        //{
        //    return _variableHandles.Create(scope
        //        .Where(x => !_ignoreKeys.Contains(x.Key))
        //        .Select(x => x.Value)
        //        .ToArray());
        //}

		public override void Variables(Response response, dynamic args)
		{
			int reference = getInt(args, "variablesReference", -1);
			if (reference == -1) {
				SendErrorResponse(response, 3009, "variables: property 'variablesReference' is missing", null, false, true);
				return;
			}

            //Program.Log("[variables] Waiting for {0}", reference);
            WaitForSuspend();
            //Program.Log("[variables] Done waiting for {0}", reference);
            var variables = new List<Variable>();

			KeyValuePair<string, AphidObject>[] children;
            
            if (_variableHandles.TryGet(reference, out children))
            {
                Program.Log("[variables] Got {0} children for {1}", children.Length, reference);
                foreach (var c in children)
                {
                    Program.Log(
                        "[variables] Got child for {0} is {1}",
                        reference,
                        c.Value != null ? c.Value.GetType().FullName : c.ToString());

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
                                    new AphidObject(c.Value.GetList()))));

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
                if (children != null && children.Length > 0)
                {

                    bool more = false;
                    if (children.Length > MAX_CHILDREN)
                    {
                        children = children.Take(MAX_CHILDREN).ToArray();
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

		public override void Threads(Response response, dynamic args)
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
                        _interpreter.Interpret(_ast);
                        SendEvent(new ThreadEvent("exited", _threadId));
                    }).Start();
                    _isRunning = true;

                    reset.WaitOne();
                    var threads2 = new List<Thread>();
                    threads2.Add(new Thread(_threadId, "Main THread"));
                    SendResponse(response, new ThreadsResponseBody(threads2));
                }

                return;
            }
            else
            {
                
            }

			var threads = new List<Thread>();
            threads.Add(new Thread(_threadId, "Main Thread"));
			SendResponse(response, new ThreadsResponseBody(threads));
            return;
		}

		public override void Evaluate(Response response, dynamic args)
		{
			var expression = getString(args, "expression");
            
            var exp = AphidParser.ParseExpression(expression);

            var retExp =
                exp.Type != AphidExpressionType.UnaryOperatorExpression  ||
                ((UnaryOperatorExpression)exp).Operator != AphidTokenType.retKeyword ?
                    new UnaryOperatorExpression(
                        AphidTokenType.retKeyword,
                        exp,
                        isPostfix: false)
                        .WithPositionFrom(exp) :
                    exp;

            var value = (AphidObject)_interpreter.Interpret(exp);


            //if (!_interpreter.CurrentScope.TryResolve(, out value))
            if (false)
            {
                SendErrorResponse(response, 3014, "Evaluate request failed, invalid expression");
            }
            else
            {
                var handle = _variableHandles.Create(value.ToArray());
                SendResponse(
                    response,
                    new EvaluateResponseBody(
                        new AphidSerializer().Serialize(value),
                        handle));
            }
		}

		//---- private ------------------------------------------

		//private void SetExceptionBreakpoints(dynamic exceptionOptions)
		//{
		//	if (exceptionOptions != null) {

		//		// clear all existig catchpoints
		//		foreach (var cp in _catchpoints) {
		//			_session.Breakpoints.Remove(cp);
		//		}
		//		_catchpoints.Clear();

		//		var exceptions = exceptionOptions.ToObject<dynamic[]>();
		//		for (int i = 0; i < exceptions.Length; i++) {

		//			var exception = exceptions[i];

		//			string exName = null;
		//			string exBreakMode = exception.breakMode;

		//			if (exception.path != null) {
		//				var paths = exception.path.ToObject<dynamic[]>();
		//				var path = paths[0];
		//				if (path.names != null) {
		//					var names = path.names.ToObject<dynamic[]>();
		//					if (names.Length > 0) {
		//						exName = names[0];
		//					}
		//				}
		//			}

		//			if (exName != null && exBreakMode == "always") {
		//				_catchpoints.Add(_session.Breakpoints.AddCatchpoint(exName));
		//			}
		//		}
		//	}
		//}

		private void SendOutput(string category, string data) {
			if (!String.IsNullOrEmpty(data)) {
				if (data[data.Length-1] != '\n') {
					data += '\n';
				}
				SendEvent(new OutputEvent(category, data));
			}
		}

		private void Terminate(string reason) {
			if (!_terminated) {

				// wait until we've seen the end of stdout and stderr
				for (int i = 0; i < 100 && (_stdoutEOF == false || _stderrEOF == false); i++) {
					System.Threading.Thread.Sleep(100);
				}

				SendEvent(new TerminatedEvent());

				_terminated = true;
				_process = null;
			}
		}

		//private StoppedEvent CreateStoppedEvent(string reason, ThreadInfo ti, string text = null)
		//{
		//	return new StoppedEvent((int)ti.Id, reason, text);
		//}

		//private ThreadInfo FindThread(int threadReference)
		//{
		//	if (_activeProcess != null) {
		//		foreach (var t in _activeProcess.GetThreads()) {
		//			if (t.Id == threadReference) {
		//				return t;
		//			}
		//		}
		//	}
		//	return null;
		//}

		private void Stopped()
		{
			_exception = null;
			_variableHandles.Reset();
			_frameHandles.Reset();
		}

        private List<object> _traversed = new List<object>();

        private string GetObjectPreview(AphidObject obj)
        {
            return obj.Keys.Any() ?
                string.Format("{{ {0} }}", string.Join(", ", obj.Keys)) :
                "{ [Empty] }";
        }

        private string GetCollectionPreview(IEnumerable collection)
        {
            var c = collection.Cast<object>().Count();
            return string.Format("[ {0:n0} element{1} ]", c, c != 1 ? "s" : "" );
        }

		private Variable CreateVariable(KeyValuePair<string, AphidObject> v)
		{
            if (v.Value == null)
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
                else if (v.Value.IsAphidType())
                {
                    return new Variable(
                        v.Key,
                        new AphidSerializer().Serialize(v.Value),
                        v.Value.GetValueType(),
                        0);
                }
                else if (v.Value.Value.GetType() == typeof(AphidObject))
                {
                    return new Variable(
                        v.Key,
                        GetObjectPreview((AphidObject)v.Value.Value),
                        AphidType.Object,
                        _variableHandles.Create(((AphidObject)v.Value.Value).ToArray()));
                }
                else if (v.Value.Value.GetType().GetInterface("IEnumerable") != null)
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

                    Program.Log("Reflecting type {0}", t.FullName);

                    if (t.IsPrimitive || t.IsEnum)
                    {
                        return new Variable(v.Key, v.Value.Value.ToString(), t.FullName.ToString());
                    }
                    else
                    {
                        return new Variable(
                            v.Key,
                            t.Name,
                            t.FullName,
                            _variableHandles.Create(t
                                .GetProperties()
                                .Select((x, i) => new KeyValuePair<string, AphidObject>(
                                    x.Name,
                                    ValueHelper.Wrap(x.GetValue(v.Value.Value))))
                                .ToArray()));
                    }
                }
            }
            //else if (v.Value.Value.GetType() == typeof(List<AphidObject>))
            //{
            //    return new Variable(
            //        v.Key,
            //        "[]",
            //        AphidType.List,
            //        _variableHandles.Create(v.Value.ToArray()));

            //    foreach (var l in v.Value.GetList().ToArray())
            //    {
            //        _variableHandles.Create(l.ToArray());
            //    }

            //    var list = v.Value.GetList().SelectMany(x => x).ToArray();
            //    var valueList = list.Select(x => x.Value).ToList();
            //    Program.Log("List: {0}", new AphidSerializer().Serialize(
            //        new AphidObject(valueList)));
            //    return new Variable(
            //            v.Key,
            //            "[]",
            //            "list",
            //            _variableHandles.Create(v.Value.ToArray()));
            //}
            //else if (v.Value.Value != null)
            //{
            //    if (v.Value.Value.GetType() == typeof(List<AphidObject>))
            //    {
            //        return new Variable(
            //            v.Key,
            //            "[]",
            //            "list",
            //            _variableHandles.Create(v.Value.GetList().SelectMany(x => x).ToArray()));
            //    }
            //    else if (v.Value.IsAphidType())
            //    {
            //        return new Variable(
            //            v.Key,
            //            new AphidSerializer().Serialize(v.Value),
            //            v.Value.GetValueType(),
            //            0);
            //    }
            //    else if (v.Value.Value.GetType().GetInterface("IEnumerable") != null)
            //    {
            //        var l = new List<AphidObject>();

            //        foreach (var o in (IEnumerable)v.Value.Value)
            //        {
            //            l.Add(ValueHelper.Wrap(o));
            //        }

            //        return new Variable(
            //            v.Key,
            //            "[c]",
            //            "list",
            //            _variableHandles.Create(l.SelectMany(x => x).ToArray()));
            //    }
            //    else
            //    {
            //        return new Variable(v.Key, v.Value.GetType().FullName, v.Value.GetType().FullName);
            //        //var t = v.Value.GetType();

            //        //Program.Log("Reflecting type {0}", t.FullName);

            //        //return new Variable(
            //        //    v.Key,
            //        //    t.FullName,
            //        //    t.FullName,
            //        //    _variableHandles.Create(t
            //        //        .GetProperties()
            //        //        .Select(x => ValueHelper.Wrap(x.GetValue(v.Value)))
            //        //        .ToArray()));
            //    }
            //}
            //else
            //{
            //    return new Variable(
            //        v.Key,
            //        "{}",
            //        AphidType.Object,
            //        _variableHandles.Create(v.Value.SelectMany(x => x.Value).ToArray()));
            //}

            //Program.Log("Creating variable {0}", v
			//var dv = new AphidSerializer().Serialize(v);
			//if (dv.Length > 1 && dv [0] == '{' && dv [dv.Length - 1] == '}') {
			//	dv = dv.Substring (1, dv.Length - 2);
			//}

   //         var scopeValue = _interpreter.CurrentScope.FirstOrDefault(x => x.Value == v);

			//return new Variable(
   //             name,
   //             //scopeValue.Key != null ? scopeValue.Key : "[value]",
   //             dv,
   //             v.Value == null ?
   //                 "null" :
   //             v.Value != null ?
   //                 v.GetValueType() :
   //                 AphidType.Object,
   //             v.Value == null || v.Value != null ?
   //                 0 :
   //                 CreateVariableHandles(v));
		}

		private bool HasMonoExtension(string path)
		{
			foreach (var e in MONO_EXTENSIONS) {
				if (path.EndsWith(e)) {
					return true;
				}
			}
			return false;
		}

		private static bool getBool(dynamic container, string propertyName, bool dflt = false)
		{
			try {
				return (bool)container[propertyName];
			}
			catch (Exception) {
				// ignore and return default value
			}
			return dflt;
		}

		private static int getInt(dynamic container, string propertyName, int dflt = 0)
		{
			try {
				return (int)container[propertyName];
			}
			catch (Exception) {
				// ignore and return default value
			}
			return dflt;
		}

		private static string getString(dynamic args, string property, string dflt = null)
		{
			var s = (string)args[property];
			if (s == null) {
				return dflt;
			}
			s = s.Trim();
			if (s.Length == 0) {
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

		//private ThreadInfo DebuggerActiveThread()
		//{
  //          return new ThreadInfo
		//	lock (_lock) {
		//		return _session == null ? null : _session.ActiveThread;
		//	}
		//}

		//private Backtrace DebuggerActiveBacktrace() {
		//	var thr = DebuggerActiveThread();
		//	return thr == null ? null : thr.Backtrace;
		//}

		//private Mono.Debugging.Client.StackFrame DebuggerActiveFrame() {
		//	if (_activeFrame != null)
		//		return _activeFrame;

		//	var bt = DebuggerActiveBacktrace();
		//	if (bt != null)
		//		return _activeFrame = bt.GetFrame(0);

		//	return null;
		//}

		//private ExceptionInfo DebuggerActiveException() {
		//	var bt = DebuggerActiveBacktrace();
		//	return bt == null ? null : bt.GetFrame(0).GetException();
		//}

		private void Connect(IPAddress address, int port)
		{
			lock (_lock) {
                //_interpreter.InterpretFile(args0.command);
                _debuggeeKilled = false;
                //            DebuggerStartInfo
                //            _debuggeeKilled = false;

                //var args0 = new Mono.Debugging.Soft.SoftDebuggerConnectArgs(string.Empty, address, port) {
                //	MaxConnectionAttempts = MAX_CONNECTION_ATTEMPTS,
                //	TimeBetweenConnectionAttempts = CONNECTION_ATTEMPT_INTERVAL
                //};

                //            _interpreter.InterpretFile(args0, isTextDocument: false);
                //_session.Run(new Mono.Debugging.Soft.SoftDebuggerStartInfo(args0), _debuggerSessionOptions);

                _debuggeeExecuting = true;
			}
		}

		private void PauseDebugger()
		{
            _interpreter.Pause();
			//lock (_lock) {
			//	if (_session != null && _session.IsRunning)
			//		_session.Stop();
			//}
		}

		private void DebuggerKill()
		{
            //_interpreter.
			//lock (_lock) {
			//	if (_session != null) {

			//		_debuggeeExecuting = true;

			//		if (!_session.HasExited)
			//			_session.Exit();

			//		_session.Dispose();
			//		_session = null;
			//	}
			//}
		}
	}
}
