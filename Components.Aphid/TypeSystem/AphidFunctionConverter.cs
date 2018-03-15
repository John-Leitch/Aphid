using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Components.External;
using Components.Aphid.Interpreter;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionWrapper : AphidRuntimeComponent
    {
        //public static readonly 

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

            if (result == null && typeof(TResult).IsClass)
            {
                return  (TResult)(object)null;
            }
            else if ((t = result.Value.GetType()) == typeof(TResult))
            {
                return (TResult)result.Value;
            }
            else if (
                Interpreter.ValueHelper.IsComplexAphidObject(result) &&
                (ctor = t.GetConstructor(new Type[0])).IsPublic)
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

    public class AphidFunctionConverter : AphidRuntimeComponent
    {
        public AphidFunctionConverter(AphidInterpreter interpreter)
            : base(interpreter)
        {

        }

        public Delegate Convert(Type methodType, object function)
        {
            var methodInfo = methodType.GetMethod("Invoke");
            var funcObj = Interpreter.ValueHelper.Unwrap(function);
            var func = funcObj as AphidFunction;

            if (func == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Conversion from {0} to {1} not supported.",
                    function.GetType(),
                    methodInfo.ToString());
            }

            return Convert(methodInfo, methodType, func);
        }

        public Delegate Convert(
            MethodInfo method,
            Type delegateType,
            AphidFunction function)
        {
            var methodParams = method.GetParameters();
            
            var wrapper = new AphidFunctionWrapper(Interpreter, function);
            var call = wrapper
                .GetType()
                .GetMethods()
                .Where(x =>
                    x.Name == "Call" &&
                    (method.ReturnType == typeof(void) ? 
                        x.ReturnType == typeof(void) :
                        x.ReturnType != typeof(void)) &&
                    methodParams.Length == x.GetParameters().Length)
                .SingleOrDefault();

            if (call == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not match conversion function for {0}",
                    method);
            }

            if (methodParams.Length == 0)
            {
                return call.CreateDelegate(delegateType, wrapper);
            }

            var methodParamTypes = methodParams.Select(x => x.ParameterType).ToArray();

            var genericCall = call.MakeGenericMethod(
                method.ReturnType != typeof(void) ?
                    methodParamTypes.Concat(new[] { method.ReturnType }).ToArray() :
                    methodParamTypes);

            return genericCall.CreateDelegate(delegateType, wrapper);
        }
    }
}
