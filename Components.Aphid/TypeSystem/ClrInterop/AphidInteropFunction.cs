using Components.Aphid.Interpreter;
using System;
using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropFunction : IAphidCallable
    {
        public Func<AphidInterpreter, object[], object> InvokeDelegate { get; private set; }

        public bool UnwrapParameters { get; }

        public object Invoke(AphidInterpreter interpreter, params object[] parms) =>
            InvokeDelegate(interpreter, parms);

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
            var l = parameters.Length;

            if (l == 0)
            {
                if (!attribute.PassInterpreter)
                {
                    InvokeDelegate = (callerScope, x) => method.Invoke(null, Array.Empty<object>());
                }
                else
                {
                    InvokeDelegate = (callerScope, x) => method.Invoke(null, new object[] { callerScope });
                }
            }
            else if (!parameters[l - 1].IsDefined(typeof(ParamArrayAttribute)))
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
                if (attribute.PassInterpreter)
                {
                    l--;
                }

                InvokeDelegate = (callerScope, x) =>
                {
                    object[] parameters2;
                    var argLen = x.Length;

                    if (argLen < l)
                    {
                        if (attribute.PassInterpreter)
                        {
                            parameters2 = new object[argLen + 2];
                            parameters2[0] = callerScope;
                            Array.Copy(x, 0, parameters2, 1, argLen);
                            parameters2[argLen + 1] = Array.Empty<object>();
                        }
                        else
                        {
                            parameters2 = new object[argLen + 1];
                            Array.Copy(x, parameters2, argLen);
                            parameters2[argLen] = Array.Empty<object>();
                        }                        
                    }
                    else
                    {
                        if (attribute.PassInterpreter)
                        {
                            parameters2 = new object[l + 1];
                            parameters2[0] = callerScope;
                            var stdParamCount = l - 1;
                            Array.Copy(x, 0, parameters2, 1, stdParamCount);
                            var paramArrayLen = argLen - stdParamCount;
                            var paramArray = new object[paramArrayLen];
                            Array.Copy(x, stdParamCount, paramArray, 0, paramArrayLen);
                            parameters2[stdParamCount + 1] = paramArray;
                        }
                        else
                        {
                            parameters2 = new object[l];
                            var stdParamCount = l - 1;
                            Array.Copy(x, parameters2, stdParamCount);
                            var paramArrayLen = argLen - stdParamCount;
                            var paramArray = new object[paramArrayLen];
                            Array.Copy(x, stdParamCount, paramArray, 0, paramArrayLen);
                            parameters2[stdParamCount] = paramArray;
                        }
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
