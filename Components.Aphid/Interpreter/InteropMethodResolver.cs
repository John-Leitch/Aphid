using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class InteropMethodResolver : AphidInterpreterComponent
    {
        public InteropMethodResolver(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public AphidInteropMethodInfo Resolve<TTargetType>(string methodName, object[] args)
        {
            return Resolve(typeof(TTargetType), methodName, args);
        }

        public AphidInteropMethodInfo Resolve(Type targetType, string methodName, object[] args)
        {
            return Resolve(
                targetType
                    .GetMethods()
                    .Where(x => x.Name == methodName && x.GetParameters().Length == args.Length)
                    .ToArray(),
                args);
        }

        public AphidInteropMethodInfo Resolve(MethodBase[] nameMatches, object[] args)
        {
            var methods = nameMatches
                .Where(x => x.GetParameters().Length == args.Length)
                .Select(x => new
                {
                    Method = x,
                    Args = x
                        .GetParameters()
                        .Select((y, i) => new AphidInteropMethodArg(args[i], y.ParameterType))
                        .ToArray()
                })
                .Select(x => new 
                {
                    x.Method,
                    x.Args,
                    ConversionInfo = x.Args
                        .Select(y =>  Interpreter.TypeConverter.CanConvert(x.Method, y.Argument, y.TargetType))
                        .ToArray()
                })
                .Where(x => x.ConversionInfo.All(y => y.CanConvert))
                .OrderBy(x => x.Args.Count(y => y.TargetType == typeof(object)))
                //.ThenByDescending(x => x.Args.Count(y => y.TargetType == typeof(object[])))
                .Select(x => new AphidInteropMethodInfo(
                    x.Method,
                    x.ConversionInfo
                        .Where(y => y.GenericArguments != null)
                        .SelectMany(y => y.GenericArguments)
                        .Distinct()
                        .ToArray(),
                    x.Args))
                .ToArray();

            if (!methods.Any())
            {
                
                var msg = !nameMatches.Any() ? 
                    "Could not resolve interop method." :
                    string.Format(
                        "Call did not match interop signature. Methods found:\r\n{0}",
                        string.Join("\r\n", nameMatches.Select(GetMethodDescription)));

                throw Interpreter.CreateRuntimeException(msg, new object[0]);
            }

            return methods.First();
        }

        public string GetMethodDescription(MethodBase method)
        {
            var sb = new StringBuilder();
            MethodInfo info;

            if ((info = method as MethodInfo) != null)
            {
                sb.AppendFormat(
                    "{0} ",
                    info.ReturnType.Name);
            }

            sb.AppendFormat(
                "{0}({1})",
                method.Name,
                string.Join(", ", method.GetParameters().Select(GetParamDescription)));

            return sb.ToString();
        }

        private string GetParamDescription(ParameterInfo parameter)
        {
            return string.Format("{0} {1}", parameter.ParameterType, parameter.Name);
        }
    }
}
