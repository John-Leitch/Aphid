using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropFunction : IAphidCallable
    {
        public Func<AphidInterpreter, object[], object> InvokeDelegate { get; private set; }

        public bool UnwrapParameters { get; }

        public object Invoke(AphidInterpreter interpreter, params object[] parms) => InvokeDelegate(interpreter, parms);

        private static object[] PrefixScope(AphidInterpreter interpreter, object[] parms)
        {
            var dst = new object[parms.Length + 1];
            dst[0] = interpreter;
            parms.CopyTo(dst, 1);
            return dst;
        }

        private void CreateInvokeDelegate(AphidInteropFunctionAttribute attribute, MethodInfo method)
        {
            var parameters = method.GetParameters();
            var paramsParam = Array.Find(parameters, x => x
                    .GetCustomAttributes(true)
                    .Any(y => y is ParamArrayAttribute));

            if (paramsParam == null)
            {
                if (!attribute.PassInterpreter)
                {
                    InvokeDelegate = (callerScope, x) => method.Invoke(null, x);
                }
                else
                {
                    InvokeDelegate = (callerScope, x) => method.Invoke(null, PrefixScope(callerScope, x));
                }
            }
            else
            {
                var paramCount = parameters.Length;

                if (attribute.PassInterpreter)
                {
                    paramCount--;
                }

                InvokeDelegate = (callerScope, x) =>
                {
                    object[] parameters2;
                    if (x.Length < paramCount)
                    {
                        parameters2 = new object[x.Length + 1];
                        Array.Copy(x, parameters2, x.Length);
                        parameters2[x.Length] = new object[0];
                    }
                    else
                    {
                        parameters2 = new object[paramCount];
                        var stdParamCount = paramCount - 1;
                        Array.Copy(x, parameters2, stdParamCount);
                        var paramArrayLen = x.Length - stdParamCount;
                        var paramArray = new object[paramArrayLen];
                        Array.Copy(x, stdParamCount, paramArray, 0, paramArrayLen);
                        parameters2[stdParamCount] = paramArray;
                    }

                    if (attribute.PassInterpreter)
                    {
                        parameters2 = PrefixScope(callerScope, parameters2);
                    }

                    return method.Invoke(null, parameters2);
                };
            }
        }

        public AphidInteropFunction(Func<AphidInterpreter, object[], object> function) => InvokeDelegate = function;

        public AphidInteropFunction(AphidInteropFunctionAttribute attribute, MethodInfo method)
        {
            UnwrapParameters = attribute.UnwrapParameters;
            CreateInvokeDelegate(attribute, method);
        }
    }
}
