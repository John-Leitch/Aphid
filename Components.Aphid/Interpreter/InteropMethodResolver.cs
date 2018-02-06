using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
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
        Func<object, BinaryOperatorExpression, bool, Func<AphidObject>, AphidObject>
            InterpretMemberInteropExpression { get; set; }

        public InteropMethodResolver(
            AphidInterpreter interpreter,
            Func<object, BinaryOperatorExpression, bool, Func<AphidObject>, AphidObject> interpretMemberInteropExpression)
            : base(interpreter)
        {
            InterpretMemberInteropExpression = interpretMemberInteropExpression;
        }

        public object TryResolveMember(BinaryOperatorExpression expression, AphidObject obj, bool returnRef)
        {
            if (obj == null)
            {
                var interopMethod = TryResolveStaticMember(
                    expression,
                    returnRef);

                if (interopMethod != null)
                {
                    return interopMethod;
                }
            }

            if (obj != null && !obj.IsAphidType())
            {
                return TryResolveInstanceMember(
                    expression,
                    obj,
                    returnRef);
            }

            return null;
        }

        public object TryResolveStaticMember(BinaryOperatorExpression expression, bool returnRef)
        {
            string key;
            Type staticType = null;
            Func<AphidObject> dynamicHandler = null;

            if (expression.RightOperand.Type == AphidExpressionType.IdentifierExpression)
            {
                //if (expression.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                //    expression.LeftOperand.ToIdentifier().Identifier.Contains("Thread"))
                //{
                //    Console.WriteLine();
                //}
                key = expression.RightOperand.ToIdentifier().Identifier;

                staticType = Interpreter.InteropTypeResolver.TryResolveType(
                    Interpreter.GetImports(),
                    Interpreter.FlattenPath(expression.LeftOperand),
                    isType: true);

                var extension = Interpreter.TypeExtender.TryResolve(
                    Interpreter.CurrentScope,
                    staticType,
                    key,
                    isAphidType: false,
                    isCtor: false,
                    isDynamic: false,
                    returnRef: returnRef);

                if (extension != null)
                {
                    return extension;
                }

                dynamicHandler = () => Interpreter.TypeExtender.TryResolve(
                    Interpreter.CurrentScope,
                    staticType,
                    key,
                    isAphidType: false,
                    isCtor: false,
                    isDynamic: true,
                    returnRef: returnRef);
            }

            var staticObj = InterpretMemberInteropExpression(
                null,
                expression,
                returnRef,
                dynamicHandler);

            var staticRef = staticObj.Value as AphidInteropReference;

            if (staticRef != null && staticRef.Property != null)
            {
                return staticRef;
            }
            else if (staticObj != null)
            {
                return staticObj;
            }

            return null;
        }

        public object TryResolveInstanceMember(
            BinaryOperatorExpression expression,
            AphidObject obj,
            bool returnRef)
        {
            Func<AphidObject> dynamicHandler = null;

            if (expression.RightOperand.Type == AphidExpressionType.IdentifierExpression)
            {
                var key = expression.RightOperand.ToIdentifier().Identifier;
                var extension = Interpreter.TypeExtender.TryResolve(
                    Interpreter.CurrentScope,
                    obj,
                    key,
                    isAphidType: false,
                    isCtor: false,
                    isDynamic: false,
                    returnRef: returnRef);

                if (extension != null)
                {
                    return extension;
                }

                dynamicHandler = () => Interpreter.TypeExtender.TryResolve(
                    Interpreter.CurrentScope,
                    obj,
                    key,
                    isAphidType: false,
                    isCtor: false,
                    isDynamic: true,
                    returnRef: returnRef);
            }

            return InterpretMemberInteropExpression(
                obj.Value,
                expression,
                returnRef,
                dynamicHandler);
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
