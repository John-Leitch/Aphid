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
