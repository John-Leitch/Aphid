using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class TypeExtender
    {
        public static string GetName(string type)
        {
            return GetName(type, null);
        }

        public static string GetName(string type, string nameStr)
        {
            return nameStr != null ?
                string.Format("$ext.{0}.{1}", type, nameStr) :
                string.Format("$ext.{0}", type);
        }

        public static string[] FanInteropName(AphidObject obj)
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

        public static string GetInteropName(AphidObject obj)
        {
            return GetInteropName(obj.Value.GetType());
        }

        public static string GetInteropName(Type t)
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

        public static void Extend(
            AphidInterpreter interpreter,
            IdentifierExpression type,
            AphidObject extensions,
            string dynamicHandler)
        {
            Extend(
                interpreter,
                type.Identifier,
                type.Attributes.Select(x => x.Identifier).ToArray(),
                extensions,
                dynamicHandler);
        }

        public static void Extend(
            AphidInterpreter interpreter,
            string type,
            AphidObject extensions,
            string dynamicHandler)
        {
            Extend(interpreter, type, new string[0], extensions, dynamicHandler);
        }

        public static void Extend(
            AphidInterpreter interpreter,
            string type,
            string[] attributes,
            AphidObject extensions,
            string dynamicHandler)
        {
            foreach (var extension in extensions)
            {
                var nameStr = extension.Key;

                if (AphidAlias.Resolve(type) == null)
                {
                    var interopType = InteropTypeResolver.ResolveType(
                        interpreter.GetImports(),
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

                var keys = nameStr != dynamicHandler ?
                    new[] { GetName(type, nameStr) } :
                    new[] { GetName(type, nameStr), GetName(type) };

                foreach (var key in keys)
                {
                    if (interpreter.CurrentScope.ContainsKey(key))
                    {
                        interpreter.CurrentScope[key] = extension.Value;
                    }
                    else
                    {
                        interpreter.CurrentScope.Add(key, extension.Value);
                    }
                }
            }
        }

        //public static AphidObject TryResolve(
        //    AphidObject scope,
        //    AphidObject obj,
        //    string key)
        //{
        //    return TryResolve(scope, obj, key, true, false);
        //}

        //public static AphidObject TryResolve(
        //    AphidObject scope,
        //    AphidObject obj,
        //    string key,
        //    bool isAphidType)
        //{
        //    return TryResolve(scope, obj, key, isAphidType, false);
        //}

        public static AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isDynamic)
        {
            var classHierarchy = isAphidType ?
                new[] { obj.GetValueType() } :
                FanInteropName(obj);

            AphidObject val = null;

            if (key == "isFunc")
            {
                Console.WriteLine();
            }

            var selector = isDynamic ?
                (Func<string, string>)(x => TypeExtender.GetName(x)) :
                (Func<string, string>)(x => TypeExtender.GetName(x, key));

            if (classHierarchy
                .Select(selector)
                .FirstOrDefault(x => scope.TryResolve(x, out val)) == null)
            {
                return null;
            }


            //{
            //    if (classHierarchy
            //        .Select(x => TypeExtender.GetName(x))
            //        .FirstOrDefault(x => scope.TryResolve(x, out val)) == null)

            //    return null;
            //}

            var function = ((AphidFunction)val.Value).Clone();
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

            return new AphidObject(function);
        }
    }
}
