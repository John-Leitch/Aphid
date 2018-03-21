using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class InteropMethodResolver : AphidRuntimeComponent
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
                key = expression.RightOperand.ToIdentifier().Identifier;

                staticType = Interpreter.InteropTypeResolver.TryResolveType(
                    Interpreter.GetImports().ToArray(),
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

        //Todo: memoize resolved types 
        public AphidInteropMethodInfo Resolve(Type targetType, string methodName, object[] args)
        {
            var matches = targetType
                .GetMethods()
                .Where(x => x.Name == methodName && CheckArgumentCount(x, args))
                .ToArray();

            if (matches.Length == 0)
            {
                throw Interpreter.CreateRuntimeException(
                    "Type {0} does not declare a method that matches signature {1}({2}).",
                    targetType,
                    methodName,
                    string.Join(", ", args.Select(x => x.GetType().ToString())));
            }

            return ResolveCore(matches, args);
        }

        public AphidInteropMethodInfo Resolve(MethodBase[] nameMatches, object[] args)
        {
            var signatureMatches = nameMatches.Where(x => CheckArgumentCount(x, args)).ToArray();

            if (signatureMatches.Length == 0)
            {
                throw CreateSignatureException(args, nameMatches);
            }

            return ResolveCore(signatureMatches, args);
        }

        private AphidInteropMethodInfo ResolveCore(MethodBase[] signatureMatches, object[] args)
        {
            var methodArgs = signatureMatches
                .Select(x => new
                {
                    Method = x,
                    Args = x
                        .GetParameters()
                        .Select((y, i) => CreateMethodArg(y, i, args))
                        .ToArray()
                })
                #if DEBUG
                .ToArray()
                #endif
                ;

            var methodConversionInfo = methodArgs
                .Select(x => new
                {
                    x.Method,
                    x.Args,
                    ConversionInfo = x.Args
                        .Select(y => Interpreter.TypeConverter.CanConvert(
                            y,
                            x.Method,
                            y.Argument,
                            y.TargetType))
                        .ToArray()
                })
                #if DEBUG
                .ToArray()
                #endif
                ;

            var canConvert = methodConversionInfo
                .Where(x => x.ConversionInfo.All(y => y.CanConvert))
                #if DEBUG
                .ToArray()
                #endif
                ;

            var weighted = canConvert
                .OrderBy(x => WeightInference(x.Args))
                #if DEBUG
                .ToArray()
                #endif
                ;

            var fanned = weighted
                .SelectMany(x => x.ConversionInfo
                    .Select(y => y.GenericArguments)
                    .Distinct()
                    .DefaultIfEmpty(new Type[0])
                    .Select(y => new AphidInteropMethodInfo(x.Method, y, x.Args)))
                #if DEBUG
                .ToArray()
                #endif
                ;

            var methods = fanned
                .Where(x =>
                        !x.Method.IsGenericMethod ||
                        x.GenericArguments.Length == x.Method.GetGenericArguments().Length)
                .ToArray();

            if (methods.Length == 0)
            {
                throw CreateSignatureException(args, signatureMatches);
            }

            return methods.First();
        }

        private uint WeightInference(AphidInteropMethodArg[] args)
        {
            var u = 0u;

            for (var i = 0; i < args.Length; i++)
            {
                u += WeightInference(args[i]);
            }

            return u;
        }

        private uint WeightInference(AphidInteropMethodArg arg)
        {
            if (arg.IsExactBasicTypeMatch)
            {
                return 0x1;
            }
            else if (arg.IsExactUserReferenceTypeMatch)
            {
                return 0x2;
            }
            else if (arg.IsDerivedFromUserReferenceType)
            {
                return 0x4;
            }
            else if (arg.IsNonRootImplementationOfTarget)
            {
                return 0x10;
            }
            else if (arg.IsSafeConvertibleNumberPair)
            {
                return 0x20;
            }
            else if (arg.HasImplicitConversion)
            {
                return 0x40;
            }
            else if (arg.TargetType == typeof(object))
            {
                return 0x80;
            }
            else if (arg.TargetType == typeof(object[]))
            {
                if (arg.ConstructsParamArray)
                {
                    return 0x200;
                }
                else if (!arg.ArgumentType.IsArray)
                {
                    return 0x100;
                }
                else
                {
                    return 0x80;
                }
            }
            else if (arg.ArgumentType == null)
            {
                return 0x10000;
            }
            //else if (arg.HasImplicitConversion)
            //{
            //    return 0x100000;
            //}
            else if (arg.HasExplicitConversion)
            {
                return 0x1000000;
            }
            else if (arg.IsUnsafeConvertibleNumberPair)
            {
                return 0x10000000;
            }
            else if (arg.HasToStringConversion)
            {
                return 0x80000000;
            }
            else
            {
                return 0x400;
            }
        }

        private AphidRuntimeException CreateSignatureException(object[] args, MethodBase[] matches)
        {
            return Interpreter.CreateRuntimeException(
                "Call did not match interop signature {0}({1}).\r\n\r\n" + 
                    "Methods found:\r\n{2}\r\n\r\n" + 
                    "Arguments:\r\n{3}",
                matches.Length != 0 ? matches[0].Name : "",
                string.Join(
                    ", ",
                    args.Select(x => (x != null ? x.GetType() : typeof(object)).FullName)),
                string.Join("\r\n", matches.Select(GetMethodDescription)),
                CreateArgumentString(args));
        }

        private string CreateArgumentString(object[] args)
        {
            var sb = new StringBuilder();
            IEnumerable enumerable;

            foreach (var arg in args)
            {
                sb.AppendFormat("{0}=", AphidType.GetName(arg));

                if (arg == null ||
                    arg is string ||
                    (enumerable = arg as IEnumerable) == null)
                {
                    sb.AppendFormat("{0}\r\n", arg);
                }
                else
                {
                    sb.Append("[\r\n");

                    foreach (var element in enumerable)
                    {
                        sb.AppendFormat("    {0}={1},\r\n", AphidType.GetName(element), element);
                    }

                    sb.Append("]\r\n");
                }
            }

            return sb.ToString();
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

        private bool CheckArgumentCount(MethodBase method, object[] args)
        {
            var p = method.GetParameters();
            ParameterInfo lp;

            if (p.Length == args.Length)
            {
                return true;
            }
            else if (p.Length > 0 && (lp = p[p.Length - 1]).IsDefined(typeof(ParamArrayAttribute)))
            {
                return lp.ParameterType == typeof(object[]) && args.Length >= p.Length - 1;
            }
            else
            {
                return false;
                //return p.Length == args.Length;
            }
        }

        private AphidInteropMethodArg CreateMethodArg(ParameterInfo parameter, int index, object[] args)
        {
            object arg;
            Type argType;

            if (!parameter.IsDefined(typeof(ParamArrayAttribute)))
            {
                return new AphidInteropMethodArg(args[index], parameter);
            }
            else if (args.Length - 1 == index &&
                (argType = (arg = args[index]).GetType()).IsArray &&
                Interpreter.TypeConverter.CanConvertArray(arg, argType, parameter.ParameterType))
            {
                return new AphidInteropMethodArg(arg, parameter, false);
            }
            else if (parameter.ParameterType.IsArray)
            {
                var p = new object[args.Length - index];
                Array.Copy(args, index, p, 0, p.Length);

                return new AphidInteropMethodArg(p, parameter);
            }
            else
            {
                throw Interpreter.CreateRuntimeException(
                    "Invalid param array element type {0}, only {1} currently supported.",
                    parameter.ParameterType.GetElementType(),
                    typeof(object));
            }
        }
    }
}
