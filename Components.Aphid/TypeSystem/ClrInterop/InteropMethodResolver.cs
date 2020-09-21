using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Components.Aphid.TypeSystem
{
    public class InteropMethodResolver : AphidRuntimeComponent
    {
        private Func<object, BinaryOperatorExpression, bool, Func<AphidObject>, AphidObject>
            InterpretMemberInteropExpression
            { get; }

        private readonly ReaderWriterLockSlim _importsLock;

        public InteropMethodResolver(
            AphidInterpreter interpreter,
            Func<object, BinaryOperatorExpression, bool, Func<AphidObject>, AphidObject> interpretMemberInteropExpression,
            ReaderWriterLockSlim importsLock)
            : base(interpreter)
        {
            InterpretMemberInteropExpression = interpretMemberInteropExpression;
            _importsLock = importsLock;
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

            return obj?.IsAphidType() == false
                ? TryResolveInstanceMember(
                    expression,
                    obj,
                    returnRef)
                : null;
        }

        public object TryResolveStaticMember(BinaryOperatorExpression expression, bool returnRef)
        {
            string key;
            Type staticType = null;
            Func<AphidObject> dynamicHandler = null;

            if (expression.RightOperand.Type == AphidExpressionType.IdentifierExpression)
            {
                key = ((IdentifierExpression)expression.RightOperand).Identifier;
                var path = Interpreter.FlattenPath(expression.LeftOperand);
                //_importsLock.EnterReadLock();

                //try
                //{
                    staticType = Interpreter.InteropTypeResolver.TryResolveType(
                        Interpreter.GetImports(),
                        _importsLock,
                        path,
                        isType: true);
                //}
                //finally
                //{
                //    _importsLock.ExitReadLock();
                //}

                var extension = TypeExtender.TryResolve(
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

                dynamicHandler = () => TypeExtender.TryResolve(
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

            if (staticObj.Value is AphidInteropReference staticRef && staticRef.Property != null)
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
                var extension = TypeExtender.TryResolve(
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

                dynamicHandler = () => TypeExtender.TryResolve(
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

        public AphidInteropMethodInfo Resolve<TTargetType>(string methodName, object[] args) => Resolve(typeof(TTargetType), methodName, args);

        //Todo: memoize resolved types 
        public AphidInteropMethodInfo Resolve(Type targetType, string methodName, object[] args)
        {
            var methods = targetType.GetMethods();
            var matches = new MethodInfo[methods.Length];
            var j = 0;

            for (var i = 0; i < methods.Length; i++)
            {
                var m = methods[i];

                if (m.Name == methodName && CheckArgumentCount(m, args.Length))
                {
                    matches[j++] = methods[i];
                }
            }

            Array.Resize(ref matches, j);

            return matches.Length == 0
                ? throw Interpreter.CreateRuntimeException(
                    "Type {0} does not declare a method that matches signature {1}({2}).",
                    targetType,
                    methodName,
                    string.Join(", ", args.Select(x => x.GetType().ToString())))
                : ResolveCore(matches, args);
        }

        public AphidInteropMethodInfo Resolve(MethodBase[] nameMatches, object[] args)
        {
            var signatureMatches = new MethodBase[nameMatches.Length];
            var x = 0;

            for (var i = 0; i < nameMatches.Length; i++)
            {
                var nm = nameMatches[i];

                if (CheckArgumentCount(nm, args.Length))
                {
                    signatureMatches[x++] = nm;
                }
            }

            Array.Resize(ref signatureMatches, x);

            //var signatureMatches = nameMatches.Where(x => CheckArgumentCount(x, args)).ToArray();

            return signatureMatches.Length == 0 ? throw CreateSignatureException(args, nameMatches) : ResolveCore(signatureMatches, args);
        }

        private AphidInteropMethodInfo ResolveCore(MethodBase[] signatureMatches, object[] args)
        {
            var contexts = new AphidInteropCallContext[signatureMatches.Length];
            var contextWeights = new ulong[signatureMatches.Length];
            var contextCount = 0;

            for (var i = 0; i < signatureMatches.Length; i++)
            {
                var match = signatureMatches[i];
                var matchParams = match.GetParameters();
                var matchArgs = new AphidInteropMethodArg[matchParams.Length];
                var matchConversions = new AphidConversionInfo[matchParams.Length];
                var canCall = true;

                for (var j = 0; j < matchParams.Length; j++)
                {
                    var matchArg = CreateMethodArg(matchParams[j], j, args);

                    var matchConversion = Interpreter.TypeConverter.CanConvert(
                        matchArg,
                        matchArg.Argument,
                        matchArg.TargetType);

                    if (!matchConversion.CanConvert)
                    {
                        canCall = false;
                        break;
                    }

                    matchConversions[j] = matchConversion;
                    matchArgs[j] = matchArg;
                }

                if (!canCall)
                {
                    continue;
                }

                contexts[contextCount] = new AphidInteropCallContext(
                    match,
                    matchConversions,
                    matchArgs);

                contextWeights[contextCount++] = WeightInference(matchArgs);
            }

            Array.Sort(contextWeights, contexts, 0, contextCount);

            for (var i = 0; i < contextCount; i++)
            {
                var x = contexts[i];

                if (!x.Method.IsGenericMethod)
                {
                    return new AphidInteropMethodInfo(x.Method, new Type[0], x.Args);
                }

                var genericArgs = ZipGenericParameters(x.Method, x.ConversionInfo);

                if (genericArgs.Length == x.Method.GetGenericArguments().Distinct().Count())
                {
                    return new AphidInteropMethodInfo(x.Method, genericArgs, x.Args);
                }
            }

            throw CreateSignatureException(args, signatureMatches);
        }

        private static Type[] ZipGenericParameters(MethodBase method, AphidConversionInfo[] conversionInfo)
        {
            if (!method.IsGenericMethod)
            {
                return new Type[0];
            }

            var methodParams = method.GetParameters();
            var mappedGenericArgs = new List<Type>();
            var posOffset = 0;

            for (var x = 0; x < methodParams.Length; x++)
            {
                var funcParamType = methodParams[x].ParameterType;

                if (!funcParamType.IsGenericType)
                {
                    continue;
                }

                var argGenerics = funcParamType.GetGenericArguments();

                for (var y = 0; y < argGenerics.Length; y++)
                {
                    var g = argGenerics[y];
                    int pos;

                    if (g.IsGenericParameter &&
                        (pos = g.GenericParameterPosition) >= mappedGenericArgs.Count)
                    {
                        var genericArgs = conversionInfo[x].GenericArguments;
                        var localOffset = pos - posOffset;

                        if (pos >= mappedGenericArgs.Count &&
                            localOffset < genericArgs.Length)
                        {
                            mappedGenericArgs.Add(genericArgs[localOffset]);
                            posOffset++;
                        }
                    }
                }
            }

            return mappedGenericArgs.ToArray();
        }

        private static ulong WeightInference(AphidInteropMethodArg[] args)
        {
            var u = 0ul;

            for (var i = 0; i < args.Length; i++)
            {
                u += WeightInference(args[i]);
            }

            return u;
        }

        private static uint WeightInference(AphidInteropMethodArg arg) =>
            arg.IsExactBasicTypeMatch ? 0x1 :
                arg.IsExactUserReferenceTypeMatch ? 0x2 :
                arg.IsDerivedFromUserReferenceType ? 0x4 :
                arg.IsNonRootImplementationOfTarget ? 0x10 :
                arg.IsSafeConvertibleNumberPair ? 0x20 :
                arg.HasImplicitConversion ? 0x40 :
                arg.IsGeneric ? 0x80 :
                arg.TargetType == typeof(object) ? 0x100 :
                arg.TargetType == typeof(object[]) ?
                    arg.ConstructsParamArray ? 0x400 : !arg.ArgumentType.IsArray ?
                    0x200 :
                    (uint)0x100 :
                arg.ArgumentType == null ? 0x10000 :
                arg.HasExplicitConversion ? 0x1000000 :
                arg.IsUnsafeConvertibleNumberPair ? 0x10000000 :
                arg.HasToStringConversion ? 0x80000000 :
                0x800;

        private AphidRuntimeException CreateSignatureException(object[] args, MethodBase[] matches) =>
            Interpreter.CreateRuntimeException(
                "Call did not match interop signature {0}({1}).\r\n\r\n" +
                    "Methods found:\r\n{2}\r\n\r\n" +
                    "Arguments:\r\n{3}",
                matches.Length != 0 ? matches[0].Name : "",
                string.Join(
                    ", ",
                    args.Select(x => (x != null ? x.GetType() : typeof(object)).FullName)),
                string.Join("\r\n", matches.Select(GetMethodDescription)),
                CreateArgumentString(args));

        private static string CreateArgumentString(object[] args)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                sb.AppendFormat("{0}=", AphidType.GetName(arg));

                if (arg == null ||
                    arg is string ||
                    !(arg is IEnumerable enumerable))
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

        private string GetParamDescription(ParameterInfo parameter) =>
            string.Format("{0} {1}", parameter.ParameterType, parameter.Name);

        private static bool CheckArgumentCount(MethodBase method, int argCount)
        {
            var p = method.GetParameters();
            ParameterInfo lp;

            return p.Length == argCount
                ? true
                : p.Length > 0 && (lp = p[p.Length - 1]).IsDefined(typeof(ParamArrayAttribute))
                    ? lp.ParameterType.IsArray && argCount >= p.Length - 1
                    : false;
        }

        private AphidInteropMethodArg CreateMethodArg(ParameterInfo parameter, int index, object[] args)
        {
            ParameterInfoCache paramInfo;

            lock (AphidInteropMethodArg.ParamCache)
            {
                if (!AphidInteropMethodArg.ParamCache.TryGetValue(parameter, out paramInfo))
                {
                    AphidInteropMethodArg.ParamCache.Add(
                        parameter,
                        paramInfo = new ParameterInfoCache(parameter));
                }
            }

            Type argType;
            object arg;

            if (!paramInfo.HasParamArray)
            {
                return new AphidInteropMethodArg(args[index], paramInfo);
            }
            else if (args.Length - 1 == index &&
                (arg = args[index]) != null &&
                (argType = arg.GetType()).IsArray &&
                AphidTypeConverter.CanConvertArray(arg, argType, paramInfo.TargetType))
            {
                return new AphidInteropMethodArg(arg, paramInfo, false);
            }
            else if (args.Length > index &&
                (arg = args[index]) != null &&
                arg.GetType() == typeof(string) &&
                paramInfo.IsCharArray)
            {
                return new AphidInteropMethodArg(arg, paramInfo);
            }
            else if (paramInfo.IsArray)
            {
                object a;
                IEnumerable seq;

                if (index >= args.Length ||
                    (a = args[index]) == null ||
                    a is string ||
                    (seq = a as IEnumerable) == null)
                {
                    var p = new object[args.Length - index];
                    Array.Copy(args, index, p, 0, p.Length);

                    return new AphidInteropMethodArg(p, paramInfo);
                }

                var p2 = new List<object>();

                foreach (var x in seq)
                {
                    p2.Add(x);
                }

                return new AphidInteropMethodArg(p2.ToArray(), paramInfo);
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
