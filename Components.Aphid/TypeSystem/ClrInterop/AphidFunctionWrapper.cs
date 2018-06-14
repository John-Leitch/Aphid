using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionWrapper : AphidRuntimeComponent
    {
        public AphidFunction Function { get; private set; }

        public AphidFunctionWrapper(AphidInterpreter interpreter, AphidFunction function)
            : base(interpreter)
        {
            Function = function;
        }

        public void Call()
        {
            Interpreter.CallFunction(Function);
        }

        public void Call<T1>(T1 arg)
        {
            Interpreter.CallFunction(Function, arg);
        }

        public void Call<T1, T2>(T1 arg, T2 arg2)
        {
            Interpreter.CallFunction(Function, arg, arg2);
        }

        public void Call<T1, T2, T3>(T1 arg, T2 arg2, T3 arg3)
        {
            Interpreter.CallFunction(Function, arg, arg2, arg3);
        }

        public void Call<T1, T2, T3, T4>(T1 arg, T2 arg2, T3 arg3, T4 arg4)
        {
            Interpreter.CallFunction(Function, arg, arg2, arg3, arg4);
        }

        public TResult Call<TResult>()
        {
            return GetResult<TResult>(Interpreter.CallFunction(Function));
        }

        public TResult Call<T1, TResult>(T1 arg)
        {
            return GetResult<TResult>(Interpreter.CallFunction(Function, arg));
        }

        public TResult Call<T1, T2, TResult>(T1 arg, T2 arg2)
        {
            return GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2));
        }

        public TResult Call<T1, T2, T3, TResult>(T1 arg, T2 arg2, T3 arg3)
        {
            return GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2, arg3));
        }

        public TResult Call<T1, T2, T3, T4, TResult>(T1 arg, T2 arg2, T3 arg3, T4 arg4)
        {
            return GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2, arg3, arg4));
        }

        private TResult GetResult<TResult>(AphidObject result)
        {
            Type t;
            ConstructorInfo ctor;

            if ((result == null || (result.IsScalar && result.Value == null)) &&
                typeof(TResult).IsClass)
            {
                return (TResult)(object)null;
            }
            else if (typeof(TResult).IsAssignableFrom(t = result.Value.GetType()))
            {
                return (TResult)result.Value;
            }
            else if (result.IsComplex && (ctor = t.GetConstructor(new Type[0])).IsPublic)
            {
                var obj = Activator.CreateInstance(t);
                result.Bind(obj, true);

                return (TResult)obj;
            }
            else
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not convert return value from {0} to {1}",
                    Interpreter.GetStackTrace()[0].Name,
                    typeof(TResult));
            }
        }
    }
}
