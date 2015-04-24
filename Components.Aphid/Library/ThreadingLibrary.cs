using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Components.Aphid.Library
{
    [AphidLibrary("threading")]
    public class ThreadingLibrary
    {
        private static ManualResetEvent ThreadCore(AphidInterpreter interpreter, Action<Action> start, AphidFunction function, params object[] parms)
        {
            var reset = new ManualResetEvent(false);
            var interpreter2 = new AphidInterpreter(interpreter.CurrentScope);
            
            Action call = () =>
            {
                interpreter2.CallFunction(function, parms);
                reset.Set();
            };

            start(call);

            return reset;
        }

        [AphidInteropFunction("threadPool", PassInterpreter = true)]
        public static ManualResetEvent ThreadPoolQueue(AphidInterpreter interpreter, AphidFunction function, params object[] parms)
        {
            return ThreadCore(interpreter, x => ThreadPool.QueueUserWorkItem(y => x()), function, parms);            
        }

        [AphidInteropFunction("thread", PassInterpreter = true)]
        public static ManualResetEvent StartThread(AphidInterpreter interpreter, AphidFunction function, params object[] parms)
        {
            return ThreadCore(interpreter, x => new Thread(y => x()).Start(), function, parms);
        }

        [AphidInteropFunction("join")]
        public static void Join(ManualResetEvent reset)
        {
            reset.WaitOne();
        }

        [AphidInteropFunction("sleep")]
        public static void Sleep(decimal timeout)
        {
            Thread.Sleep((int)timeout);
        }

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
