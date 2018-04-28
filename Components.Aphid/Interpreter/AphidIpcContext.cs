using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidIpcContext : MarshalByRefObject
    {
        private static AphidInterpreter _registeredInterpreter;

        private AphidInterpreter _interpreter;

        private static object _sync = new object();

        public static AphidIpcContext Instance { get; private set; }

        public AphidIpcContext()
        {
            lock (_sync)
            {
                if (Instance != null || _registeredInterpreter == null)
                {
                    throw new InvalidOperationException();
                }

                _interpreter = _registeredInterpreter;
                Instance = this;
            }
        }

        public void InitializeServer(AphidInterpreter interpreter)
        {
            _interpreter = interpreter;
        }

        public string Eval(string block)
        {
            var result = _interpreter.InterpretStream(block);

            return _interpreter.Serializer.Serialize(AphidObject.Scalar(result));
        }

        public static void Register(AphidInterpreter interpreter)
        {
            lock (_sync)
            {
                if (_registeredInterpreter != null)
                {
                    throw new InvalidOperationException();
                }

                _registeredInterpreter = interpreter;
            }
        }
    }
}
