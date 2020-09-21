using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Components.Aphid.TypeSystem
{
    public class TypeExtender : AphidRuntimeComponent
    {
        private static readonly DirectArgLockingMemoizer<Type, string[]>
            _staticTypeMemoizer = new DirectArgLockingMemoizer<Type,string[]>(),
            _fanInteropTypeMemoizer = new DirectArgLockingMemoizer<Type, string[]>(),
            _fanAphidTypeMemoizer = new DirectArgLockingMemoizer<Type, string[]>();

        private static bool _isUnknownExtended;

        private static readonly HashSet<string> _typesExtended = new HashSet<string>(),
            _typesCtorExtended = new HashSet<string>(),
            _typesDynamicallyExtended = new HashSet<string>();

        private readonly ReaderWriterLockSlim _importsLock;

        public TypeExtender(AphidInterpreter interpreter, ReaderWriterLockSlim importsLock)
            : base(interpreter) =>
            _importsLock = importsLock;

        public static string GetCtorName(string type) => "$ext." + type + ".$ctor";

        private static string GetDynamicName(string type) => "$ext." + type;

        private static string GetName(string type, string nameStr) => nameStr != null ? "$ext." + type + "." + nameStr : "$ext." + type;

        private static string[] FanStaticInteropTypeName(Type type) => type != null ? _staticTypeMemoizer.Call(FanStaticInteropTypeNameCore, type) : Array.Empty<string>();

        private static string[] FanStaticInteropTypeNameCore(Type type)
        {
            var names = new List<string>();

            while (type != null)
            {
                names.Add(GetInteropName(type));
                type = type.BaseType;
            }

            return names.ToArray();
        }

        private static string[] FanAphidName(AphidObject obj) => obj.IsScalar
                ? obj.Value != null ? _fanAphidTypeMemoizer.Call(FanAphidName, obj.Value.GetType()) : Array.Empty<string>()
                : (new string[]
            {
                    AphidType.Object,
                    typeof(AphidObject).FullName,
                    AphidType.Unknown
            });

        private static string[] FanInteropName(AphidObject obj) => obj.IsScalar
                ? obj.Value != null ? _fanInteropTypeMemoizer.Call(FanAphidName, obj.Value.GetType()) : Array.Empty<string>()
                : (new string[] { typeof(AphidObject).FullName, AphidType.Unknown });

        //private static string[] FanInteropName(Type t)
        //{
        //    var names = new List<string>();
        //    FanInteropType(t, names);

        //    return names.ToArray();
        //}

        private static string[] FanAphidName(Type t)
        {
            var names = new List<string>();
            var curType = t;
            string aphidType;

            while (curType != typeof(object))
            {
                if ((aphidType = AphidAlias.Resolve(curType)) != null)
                {
                    names.Add(aphidType);
                }

                FanInteropType(curType, names);

                curType = curType.BaseType;
            }

            var interfaces = t.GetInterfaces();

            for (var i = 0; i < interfaces.Length; i++)
            {
                FanInteropType(interfaces[i], names);
            }

            names.Add(typeof(object).FullName);
            names.Add(AphidType.Unknown);

            return names.ToArray();
        }

        private static void FanInteropType(Type t, List<string> names)
        {
            if (!t.IsGenericType)
            {
                names.Add(t.FullName);
            }
            else
            {
                names.Add(GetGenericInteropName(t));

                if (t.IsConstructedGenericType)
                {
                    names.Add(t.GetGenericTypeDefinition().FullName);
                }
            }
        }

        private static string GetInteropName(Type t) => !t.IsGenericType ? t.FullName : GetGenericInteropName(t);

        private static string GetGenericInteropName(Type t)
        {
            var isFirstTypeArg = true;
            var sb = new StringBuilder(t.FullName);
            sb.Append('[');

            foreach (var p in t.GetGenericArguments())
            {
                if (isFirstTypeArg)
                {
                    isFirstTypeArg = false;
                }
                else
                {
                    sb.Append(',');
                }

                sb.Append(p.FullName);
            }

            sb.Append(']');

            return sb.ToString();
        }

        public void Extend(
            IdentifierExpression type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler) =>
            Extend(
                type.Identifier,
                type.Attributes.Select(x => x.Identifier).ToArray(),
                extensions,
                ctorHandler,
                dynamicHandler);

        public void Extend(
            string type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler) =>
            Extend(type, Array.Empty<string>(), extensions, ctorHandler, dynamicHandler);

        public void Extend(
            string type,
            string[] attributes,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            if (AphidAlias.Resolve(type) == null)
            {
                var path = new[] { type };
                Type interopType;
                //_importsLock.EnterReadLock();

                //try
                //{
                    interopType = Interpreter.InteropTypeResolver.ResolveType(
                        Interpreter.GetImports(),
                        _importsLock,
                        path,
                        isType: true);
                //}
                //finally
                //{
                //    _importsLock.ExitReadLock();
                //}

                if (attributes != null)
                {
                    if (attributes.Length == 1)
                    {
                        interopType = attributes[0] == AphidType.List
                            ? typeof(List<>).MakeGenericType(interopType)
                            : throw GetInteropTypeException(attributes, type);
                    }
                    else if (attributes.Length != 0)
                    {
                        throw GetInteropTypeException(attributes, type);
                    }
                }

                type = GetInteropName(interopType);
            }

            if (type == AphidType.Unknown || type == typeof(object).FullName)
            {
                _isUnknownExtended = true;
            }
            else if (!_typesExtended.Contains(type))
            {
                _typesExtended.Add(type);
            }

            if (ctorHandler != null &&
                !_typesCtorExtended.Contains(type))
            {
                _typesCtorExtended.Add(type);
            }

            if (dynamicHandler != null &&
                !_typesDynamicallyExtended.Contains(type))
            {
                _typesDynamicallyExtended.Add(type);
            }

            foreach (var extension in extensions)
            {
                var nameStr = extension.Key;
                var keys = new List<string> { GetName(type, nameStr) };

                if (nameStr == dynamicHandler)
                {
                    keys.Add(GetDynamicName(type));
                }

                if (nameStr == ctorHandler)
                {
                    keys.Add(GetCtorName(type));
                }

                foreach (var key in keys)
                {
                    if (Interpreter.CurrentScope.ContainsKey(key))
                    {
                        Interpreter.CurrentScope[key] = extension.Value;
                    }
                    else
                    {
                        Interpreter.CurrentScope.Add(key, extension.Value);
                    }
                }
            }
        }

        private AphidRuntimeException GetInteropTypeException(string[] attributes, string type) =>
            Interpreter.CreateRuntimeException(
                "Unexpected attribute(s) '{0}' for type '{1}'. Expected attribute 'list' or none.",
                string.Join(", ", attributes),
                type);

        public static AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef) => isAphidType
                ? TryResolve(
                    scope,
                    obj,
                    FanAphidName(obj),
                    key,
                    isAphidType,
                    isCtor,
                    isDynamic,
                    isStatic: false,
                    returnRef: returnRef)
                : TryResolve(
                scope,
                obj,
                FanInteropName(obj),
                key,
                isAphidType,
                isCtor,
                isDynamic,
                isStatic: false,
                returnRef: returnRef);

        public static AphidObject TryResolve(
            AphidObject scope,
            Type staticType,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef) =>
            TryResolve(
                scope,
                null,
                FanStaticInteropTypeName(staticType),
                key,
                isAphidType,
                isCtor,
                isDynamic,
                isStatic: true,
                returnRef: returnRef);

        public static AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string[] classHierarchy,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool isStatic,
            bool returnRef)
        {
            var startOffset = 0;
            HashSet<string> types = isCtor ? _typesCtorExtended : isDynamic ? _typesDynamicallyExtended : _typesExtended;
            if (!_isUnknownExtended)
            {
                var isTypeExtended = false;
                int len = !isStatic ? classHierarchy.Length - 2 : classHierarchy.Length - 1;
                for (; startOffset < len; startOffset++)
                {
                    if (types.Contains(classHierarchy[startOffset]))
                    {
                        isTypeExtended = true;
                        break;
                    }
                }

                if (!isTypeExtended)
                {
                    return null;
                }
            }

            AphidObject val = null;

            if (isDynamic)
            {
                var isFirst = true;

                for (; startOffset < classHierarchy.Length; startOffset++)
                {
                    var c = classHierarchy[startOffset];

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else if (c != AphidType.Unknown &&
                        c != typeof(AphidObject).FullName &&
                        !types.Contains(c))
                    {
                        continue;
                    }

                    if (scope.TryResolve(GetDynamicName(c), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }
            else if (isCtor)
            {
                var isFirst = true;

                for (; startOffset < classHierarchy.Length; startOffset++)
                {
                    var c = classHierarchy[startOffset];

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else if (c != AphidType.Unknown &&
                        c != typeof(AphidObject).FullName &&
                        !types.Contains(c))
                    {
                        continue;
                    }

                    if (scope.TryResolve(GetCtorName(c), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }
            else
            {
                var isFirst = true;

                for (; startOffset < classHierarchy.Length; startOffset++)
                {
                    var c = classHierarchy[startOffset];

                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else if (c != AphidType.Unknown &&
                        c != typeof(AphidObject).FullName &&
                        !types.Contains(c))
                    {
                        continue;
                    }

                    if (scope.TryResolve(GetName(c, key), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }

            AphidObject result;

            if (val.Value is AphidFunction func)
            {
                func.Clone();

                var function = func.Clone();
                //var function = func;
                var skipOffset = isStatic ? 1 : 0;

                function.ParentScope = AphidObject.Scope(scope);

                if (!isStatic)
                {
                    function.ParentScope.Add(AphidName.ImplicitArg, obj);
                }

                function.ParentScope.Add(AphidName.Extension, AphidObject.InternedTrue);
                function.ParentScope.Add(AphidName.StaticExtension, AphidObject.Scalar(isStatic));

                if (function.Args.Length > 0)
                {
                    if (!isStatic)
                    {
                        function.ParentScope.Add(function.Args[0], obj);
                    }

                    int skip;

                    if (isDynamic && function.Args.Length >= 2 - skipOffset)
                    {
                        function.ParentScope.Add(
                            function.Args[1 - skipOffset],
                            AphidObject.Scalar(key));

                        skip = 2 - skipOffset;
                    }
                    else
                    {
                        skip = 1 - skipOffset;
                    }

                    function.Args = function.Args.Skip(skip).ToArray();
                }

                result = AphidObject.Scalar(function);
            }
            else
            {
                result = !returnRef ? !val.ContainsKey(key) ? null : val[key] : val;
            }

            return !returnRef ? result : AphidObject.Scalar(new AphidRef { Name = key, Object = result });
        }
    }
}
