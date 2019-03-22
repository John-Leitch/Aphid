using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Threading;

namespace Components.Aphid.Library
{
    [AphidLibrary("threading")]
    public static class ThreadingLibrary
    {
        private static ManualResetEvent ThreadCore(AphidInterpreter interpreter, Action<Action> start, AphidFunction function, params object[] parms)
        {
            var reset = new ManualResetEvent(false);

            void call()
            {
                interpreter.CallFunction(function, parms);
                reset.Set();
            }

            start(call);

            return reset;
        }

        [AphidInteropFunction("threadPool", PassInterpreter = true)]
        public static WaitHandle ThreadPoolQueue(AphidInterpreter interpreter, AphidFunction function, params object[] parms) =>
            ThreadCore(interpreter, x => ThreadPool.QueueUserWorkItem(y => x()), function, parms);

        [AphidInteropFunction("thread", PassInterpreter = true)]
        public static WaitHandle StartThread(AphidInterpreter interpreter, AphidFunction function, params object[] parms) =>
            ThreadCore(interpreter, x => new Thread(y => x()).Start(), function, parms);

        //[AphidInteropFunction("join")]
        //public static void Join(WaitHandle reset) => reset.WaitOne();

        [AphidInteropFunction("sleep")]
        public static void Sleep(decimal timeout) => Thread.Sleep((int)timeout);

        [AphidInteropFunction("lock", PassInterpreter = true, UnwrapParameters = false)]
        public static void Lock(AphidInterpreter interpreter, AphidObject obj, AphidObject body)
        {
            lock (obj)
            {
                interpreter.CallFunction((AphidFunction)body.Value);
            }
        }
    }
}
