using System.Collections.Generic;

namespace Components.Aphid.Interpreter
{
    public partial class AphidInterpreter
    {
        internal static class AphidThread
        {
            public static AphidInterpreter CreateChild(AphidInterpreter parent) =>
                CreateChild(parent, true);

            public static AphidInterpreter CreateChild(AphidInterpreter parent, bool createChildScope)
            {
                var scope = createChildScope ? parent.CurrentScope.CreateChild() : parent.CurrentScope;

                var child = new AphidInterpreter(
                    scope,
                    createLoader: false,
                    frames: new Stack<AphidFrame>(parent.GetRawStackTraceReversed()))
                {
                    //_queuedFramePops = parent._queuedFramePops,
                    //_frames = new Stack<AphidFrame>(parent._frames),
                    //_lazyGetFrameArray = parent._lazyGetFrameArray,
                    _insertNextBuffer = parent._insertNextBuffer,
                    //_initialScope = parent._initialScope,                    

                    //AsmBuilder = parent.AsmBuilder,
                    //InteropMethodResolver = parent.InteropMethodResolver,
                    //OperatorHelper = parent.OperatorHelper,
                    //ValueHelper = parent.ValueHelper,
                    //InteropTypeResolver = parent.InteropTypeResolver,
                    //TypeExtender = parent.TypeExtender,
                    //TypeConverter = parent.TypeConverter,
                    //FunctionConverter = parent.FunctionConverter,
                    //IpcContext = parent.IpcContext,
                    Serializer = parent.Serializer,
                    Out = parent.Out,
                    OutFilter = parent.OutFilter,
                    GatorEmitFilter = parent.GatorEmitFilter,
                    //Loader = parent.Loader,
                    StrictMode = parent.StrictMode,

                    OnInterpretBlock = parent.OnInterpretBlock,
                    OnInterpretBlockExecuting = parent.OnInterpretBlockExecuting,

                    OnInterpretStatement = parent.OnInterpretStatement,
                    OnInterpretStatementExecuting = parent.OnInterpretStatementExecuting,

                    OnInterpretExpression = parent.OnInterpretExpression,
                    OnInterpretExpressionExecuting = parent.OnInterpretExpressionExecuting,

                    OnInterpretObject = parent.OnInterpretObject,
                    OnInterpretObjectExecuting = parent.OnInterpretObjectExecuting
                };

                child.PushFrame(child.CreateEntryFrame());
                //child.PushFrame(string.Format("[Entrypoint (Thread 0x{0:X})]", Thread.CurrentThread.ManagedThreadId));
                child.Loader = parent.Loader.CreateChild(child);

                //ThreadPool.QueueUserWorkItem(x =>
                //{
                //    using (new CrossProcessLock())
                //    {
                //        //Cli.WriteSubheader(Thread.CurrentThread.ManagedThreadId.ToString());
                //        //AphidConfig.Current.LazyStackTraceParams = new Lazy<bool>(() => false);
                //        Cli.WriteHeader("Stack Test");
                //        AphidCli.DumpStackTrace(child);
                //        //Console.WriteLine(child.GetRawStackTrace().Select(x => x.Name.ToString()).JoinLines());
                //        //Cli.WriteSubheader(Thread.CurrentThread.ManagedThreadId.ToString());
                //    }
                //});

                //foreach (var p in parent.Loader.SearchPaths)
                //{
                //    child.Loader.SearchPaths.Add(p);
                //}

                return child;
            }
        }
    }
}
