using Components.Aphid.Interpreter;
using System;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionWrapper : AphidRuntimeComponent
    {
        public AphidFunction Function { get; }

        public AphidFunctionWrapper(AphidInterpreter interpreter, AphidFunction function)
            : base(interpreter) => Function = function;

        public void Call() => Interpreter.CallFunction(Function);

        public void Call<T1>(T1 arg) => Interpreter.CallFunction(Function, arg);

        public void Call<T1, T2>(T1 arg, T2 arg2) => Interpreter.CallFunction(Function, arg, arg2);

        public void Call<T1, T2, T3>(T1 arg, T2 arg2, T3 arg3) => Interpreter.CallFunction(Function, arg, arg2, arg3);

        public void Call<T1, T2, T3, T4>(T1 arg, T2 arg2, T3 arg3, T4 arg4) => Interpreter.CallFunction(Function, arg, arg2, arg3, arg4);

        public TResult Call<TResult>() => GetResult<TResult>(Interpreter.CallFunction(Function));

        public TResult Call<T1, TResult>(T1 arg) => GetResult<TResult>(Interpreter.CallFunction(Function, arg));

        public TResult Call<T1, T2, TResult>(T1 arg, T2 arg2) => GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2));

        public TResult Call<T1, T2, T3, TResult>(T1 arg, T2 arg2, T3 arg3) => GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2, arg3));

        public TResult Call<T1, T2, T3, T4, TResult>(T1 arg, T2 arg2, T3 arg3, T4 arg4) => GetResult<TResult>(Interpreter.CallFunction(Function, arg, arg2, arg3, arg4));

        private TResult GetResult<TResult>(AphidObject result)
        {
            if (result == null)
            {
                return default;
            }
            else if (result.IsScalar)
            {
                object value;

                return (value = result.Value) == null
                    ? default
                    : typeof(TResult).IsAssignableFrom(value.GetType())
                        ? (TResult)value
                        : typeof(TResult) == typeof(AphidObject)
                                            ? (TResult)(object)result
                                            : throw Interpreter.CreateRuntimeException(
                                                                "Could not convert return value from {0} to {1}",
                                                                Interpreter.GetStackTrace()[0].Name,
                                                                typeof(TResult));
            }
            else
            {
                if (typeof(TResult) == typeof(AphidObject))
                {
                    return (TResult)(object)result;
                }
                else if (typeof(TResult).GetConstructor(new Type[0]).IsPublic)
                {
                    var obj = Activator.CreateInstance<TResult>();
                    result.Bind(obj, true);

                    return obj;
                }
                else
                {
                    throw Interpreter.CreateRuntimeException(
                        "Could not convert return value from {0} to {1}",
                        Interpreter.GetStackTrace()[0].Name,
                        typeof(TResult));
                }
            }

            

            //if ((result == null || (result.IsScalar && result.Value == null)) &&
            //    typeof(TResult).IsClass)
            //{
            //    return (TResult)(object)null;
            //}
            //else if (typeof(TResult).IsAssignableFrom(t = result.Value.GetType()))
            //{
            //    return (TResult)result.Value;
            //}
            //else if (result.IsComplex && (t.GetConstructor(new Type[0])).IsPublic)
            //{
            //    var obj = Activator.CreateInstance(t);
            //    result.Bind(obj, true);

            //    return (TResult)obj;
            //}
            //else
            //{
            //    throw Interpreter.CreateRuntimeException(
            //        "Could not convert return value from {0} to {1}",
            //        Interpreter.GetStackTrace()[0].Name,
            //        typeof(TResult));
            //}
        }
    }
}
