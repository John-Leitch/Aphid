using System;
using System.Linq;
using System.Reflection;
using Components.Aphid.Interpreter;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionConverter : AphidRuntimeComponent
    {
        public AphidFunctionConverter(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public Delegate Convert(
            Type methodType,
            object function,
            Type[] genericArguments)
        {
            var methodInfo = methodType.GetMethod("Invoke");
            var funcObj = ValueHelper.Unwrap(function);

            return !(funcObj is AphidFunction func)
                ? throw Interpreter.CreateRuntimeException(
                    "Conversion from {0} to {1} not supported.",
                    function.GetType(),
                    methodInfo.ToString())
                : ConvertFunctionWrapper(methodInfo, methodType, func, genericArguments);
        }

        public Delegate ConvertFunctionWrapper(
            MethodInfo method,
            Type delegateType,
            AphidFunction function,
            Type[] genericArguments)
        {
            var methodParams = method.GetParameters();
            var wrapper = new AphidFunctionWrapper(Interpreter, function);

            var call = wrapper
                .GetType()
                .GetMethods()
                .SingleOrDefault(x =>
                    x.Name == "Call" &&
                    (method.ReturnType == typeof(void) ?
                        x.ReturnType == typeof(void) :
                        x.ReturnType != typeof(void)) &&
                    methodParams.Length == x.GetParameters().Length);

            if (call == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not match conversion function for {0}",
                    method);
            }

            if (methodParams.Length > 0 ||
                method.ReturnType != typeof(void))
            {
                var paramTypes = methodParams
                    .Select(x => !x.ParameterType.IsGenericParameter ?
                        x.ParameterType :
                        genericArguments[x.ParameterType.GenericParameterPosition]);

                call = call.MakeGenericMethod(
                    (method.ReturnType.IsGenericParameter ?
                        paramTypes.Concat(new[] { genericArguments[method.ReturnType.GenericParameterPosition] }) :
                    method.ReturnType != typeof(void) ?
                        paramTypes.Concat(new[] { method.ReturnType }) :
                        paramTypes)
                        .ToArray());
            }

            if (delegateType.ContainsGenericParameters)
            {
                var curDelegateArgs = delegateType.GetGenericArguments();
                var delegateTypeParams = new Type[curDelegateArgs.Length];

                for (var i = 0; i < curDelegateArgs.Length; i++)
                {
                    delegateTypeParams[i] = !curDelegateArgs[i].IsGenericParameter ?
                        curDelegateArgs[i] :
                        genericArguments[curDelegateArgs[i].GenericParameterPosition];
                }

                delegateType = delegateType
                    .GetGenericTypeDefinition()
                    .MakeGenericType(delegateTypeParams);
            }

            return call.CreateDelegate(delegateType, wrapper);
        }
    }
}
