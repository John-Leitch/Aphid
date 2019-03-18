using Components.Aphid.TypeSystem;
using System;

namespace Components.Aphid.Interpreter
{
    public class AphidIpcContext : MarshalByRefObject
    {
        private static AphidInterpreter _registeredInterpreter;

        private AphidInterpreter _interpreter;

        private static readonly object _sync = new object();

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

        public void InitializeServer(AphidInterpreter interpreter) => _interpreter = interpreter;

        public string Eval(string block)
        {
            try
            {
                var result = _interpreter.InterpretStream(block);

                if (result == null)
                {
                    result = _interpreter.GetReturnValue();
                }

                var ao = ValueHelper.Wrap(result);

                return _interpreter.Serializer.Serialize(ao);
            }
            catch (Exception e)
            {
                return _interpreter.Serializer.Serialize(AphidObject.Scalar(e));
            }
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
