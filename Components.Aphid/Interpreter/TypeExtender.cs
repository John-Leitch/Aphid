using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class TypeExtender : AphidInterpreterComponent
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

        public string[] FanInteropName(AphidObject obj)
        {
            var names = new List<string>();
            var t = obj.Value.GetType();

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
            foreach (var extension in extensions)
            {
                var nameStr = extension.Key;

                if (AphidAlias.Resolve(type) == null)
                {
                    var interopType = Interpreter.InteropTypeResolver.ResolveType(
                        Interpreter.GetImports(),
                        new[] { type },
                        isType: true);

                    if (attributes != null &&
                        attributes.Length == 1 &&
                        attributes[0] == AphidType.List)
                    {
                        interopType = typeof(List<>).MakeGenericType(interopType);
                    }

                    type = GetInteropName(interopType);
                }

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

        //public AphidObject TryResolve(
        //    AphidObject scope,
        //    AphidObject obj,
        //    string key)
        //{
        //    return TryResolve(scope, obj, key, true, false);
        //}

        //public AphidObject TryResolve(
        //    AphidObject scope,
        //    AphidObject obj,
        //    string key,
        //    bool isAphidType)
        //{
        //    return TryResolve(scope, obj, key, isAphidType, false);
        //}

        public AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef)
        {
            var classHierarchy = isAphidType ?
                new[] { obj.GetValueType() } :
                FanInteropName(obj);

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
                function.ParentScope = new AphidObject { Parent = scope };
                function.ParentScope.Add(AphidName.ImplicitArg, obj);
                function.ParentScope.Add(AphidName.Extension, new AphidObject(true));

                if (function.Args.Any())
                {
                    function.ParentScope.Add(function.Args[0], obj);

                    int skip;

                    if (isDynamic && function.Args.Length >= 2)
                    {
                        function.ParentScope.Add(function.Args[1], new AphidObject(key));
                        skip = 2;
                    }
                    else
                    {
                        skip = 1;
                    }

                    function.Args = function.Args.Skip(skip).ToArray();
                }

                result = new AphidObject(function);
            }
            else
            {
                result = !returnRef ? val[key] : val;
            }

            return !returnRef ? result : new AphidObject(new AphidRef() { Name = key, Object = result });
        }
    }
}
