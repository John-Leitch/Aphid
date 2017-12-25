using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class TypeExtender
    {
        public static string GetName(string type, string nameStr)
        {
            return string.Format("$ext.{0}.{1}", type, nameStr);
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

        public static void Extend(AphidInterpreter interpreter, IdentifierExpression type, AphidObject extensions)
        {
            Extend(
                interpreter,
                type.Identifier,
                type.Attributes.Select(x => x.Identifier).ToArray(),
                extensions);
        }

        public static void Extend(AphidInterpreter interpreter, string type, AphidObject extensions)
        {
            Extend(interpreter, type, new string[0], extensions);
        }

        public static void Extend(
            AphidInterpreter interpreter,
            string type,
            string[] attributes,
            AphidObject extensions)
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

                var key = GetName(type, nameStr);

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

        public static AphidObject TryResolve(AphidObject scope, AphidObject obj, string key)
        {
            return TryResolve(scope, obj, key, true);
        }

        public static AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType)
        {
            var classHierarchy = isAphidType ?
                new[] { obj.GetValueType() }:
                FanInteropName(obj);

            AphidObject val = null;

            if (classHierarchy
                    .Select(x => TypeExtender.GetName(x, key))
                    .FirstOrDefault(x => scope.TryResolve(x, out val)) == null)
            {
                return null;
            }

            var function = ((AphidFunction)val.Value).Clone();
            function.ParentScope = new AphidObject { Parent = scope };
            function.ParentScope.Add(function.Args[0], obj);
            function.Args = function.Args.Skip(1).ToArray();

            return new AphidObject(function);
        }
    }
}
