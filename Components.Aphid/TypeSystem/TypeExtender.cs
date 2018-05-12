using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public class TypeExtender : AphidRuntimeComponent
    {
        public TypeExtender(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public string GetCtorName(string type)
        {
            return GetName(type, "$ctor");
        }

        public string GetDynamicName(string type)
        {
            return GetName(type, null);
        }

        public string GetName(string type, string nameStr)
        {
            return nameStr != null ?
                string.Format("$ext.{0}.{1}", type, nameStr) :
                string.Format("$ext.{0}", type);
        }

        public string[] FanStaticInteropTypeName(Type type)
        {
            var names = new List<string>();

            while (type != null)
            {
                names.Add(GetInteropName(type));
                type = type.BaseType;
            }

            return names.ToArray();
        }

        public string[] FanAphidName(AphidObject obj)
        {
            return FanInteropNameCore(obj, includeAphidType: true);
        }

        public string[] FanInteropName(AphidObject obj)
        {
            return FanInteropNameCore(obj, includeAphidType: false);
        }

        private string[] FanInteropNameCore(AphidObject obj, bool includeAphidType)
        {
            var names = !includeAphidType ?
                new List<string>() :
                new[] { obj.GetValueType() }.ToList();

            var t = obj.IsScalar ? obj.Value.GetType() : typeof(AphidObject);

            do
            {
                names.Add(GetInteropName(t));
                t = t.BaseType;
            } while (t != null);

            names.Add(AphidType.Unknown);

            return names.ToArray();
        }

        public string GetInteropName(AphidObject obj)
        {
            return GetInteropName(obj.Value.GetType());
        }

        public string GetInteropName(Type t)
        {
            var n = AphidAlias.Resolve(t) ?? t.FullName;

            if (!t.IsGenericType)
            {
                return n;
            }
            else
            {
                var isFirstTypeArg = true;
                var sb = new StringBuilder(n);
                sb.Append('<');

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

                sb.Append('>');

                return sb.ToString();
            }
        }

        public void Extend(
            IdentifierExpression type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            Extend(
                type.Identifier,
                type.Attributes.Select(x => x.Identifier).ToArray(),
                extensions,
                ctorHandler,
                dynamicHandler);
        }

        public void Extend(
            string type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            Extend(type, new string[0], extensions, ctorHandler, dynamicHandler);
        }

        public void Extend(
            string type,
            string[] attributes,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            if (AphidAlias.Resolve(type) == null)
            {
                var interopType = Interpreter.InteropTypeResolver.ResolveType(
                    Interpreter.GetImports().ToArray(),
                    new[] { type },
                    isType: true);

                if (attributes != null)
                {
                    if (attributes.Length == 1)
                    {
                        if (attributes[0] == AphidType.List)
                        {
                            interopType = typeof(List<>).MakeGenericType(interopType);
                        }
                        else
                        {
                            throw GetInteropTypeException(attributes, type);
                        }
                    }
                    else if (attributes.Length != 0)
                    {
                        throw GetInteropTypeException(attributes, type);
                    }
                }

                type = GetInteropName(interopType);
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

        private AphidRuntimeException GetInteropTypeException(string[] attributes, string type)
        {
            return Interpreter.CreateRuntimeException(
                "Unexpected attribute(s) '{0}' for type '{1}'. Expected attribute 'list' or none.",
                string.Join(", ", attributes),
                type);
        }

        public AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef)
        {
            return TryResolve(
                scope,
                obj,
                isAphidType ? FanAphidName(obj) : FanInteropName(obj),
                key,
                isAphidType,
                isCtor,
                isDynamic,                
                isStatic: false,
                returnRef: returnRef);
        }

        public AphidObject TryResolve(
            AphidObject scope,
            Type staticType,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef)
        {
            return TryResolve(
                scope,
                null,
                FanStaticInteropTypeName(staticType),
                key,
                isAphidType,
                isCtor,
                isDynamic,                
                isStatic: true,
                returnRef: returnRef);
        }

        public AphidObject TryResolve(
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
            AphidObject val = null;

            var selector =
                isDynamic ? (Func<string, string>)(x => GetDynamicName(x)) :
                isCtor ? (Func<string, string>)(x => GetCtorName(x)) :
                (Func<string, string>)(x => GetName(x, key));

            if (classHierarchy
                .Select(selector)
                .FirstOrDefault(x => scope.TryResolve(x, out val)) == null)
            {
                return null;
            }

            AphidObject result;
            var func = val.Value as AphidFunction;

            if (func != null)
            {
                var function = func.Clone();
                //var function = func;
                var skipOffset = isStatic ? 1 : 0;

                function.ParentScope = AphidObject.Scope(scope);

                if (!isStatic)
                {
                    function.ParentScope.Add(AphidName.ImplicitArg, obj);
                }

                function.ParentScope.Add(AphidName.Extension, AphidObject.Scalar(true));
                function.ParentScope.Add(AphidName.StaticExtension, AphidObject.Scalar(isStatic));

                if (function.Args.Any())
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
                if (!returnRef)
                {
                    if (!val.ContainsKey(key))
                    {
                        result = null;
                    }
                    else
                    {
                        result = val[key];
                    }
                }
                else
                {
                    result = val;
                }
            }

            return !returnRef ? result : AphidObject.Scalar(new AphidRef() { Name = key, Object = result });
        }
    }
}
