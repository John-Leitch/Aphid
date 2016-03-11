using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public static class InteropTypeResolver
    {
        public static Type ResolveType(IEnumerable<string> imports, string[] path, bool isType = false)
        {
            var pathStr = string.Join(".", path);
            var offset = !isType ? 1 : 0;

            var type = path
                .Take(path.Length - offset)
                .Select((x, i) => new
                {
                    Count = i + 1,
                    Path = string.Join(".", path.Take(i + 1))
                })
                .SelectMany(x =>
                    new[] { "" }
                        .Concat(imports)
                        .Select(y => new
                        {
                            x.Count,
                            Path = y.Any() ? y + "." + x.Path : x.Path,
                        }))
                .Select(x => new
                {
                    PartCount = x.Count,
                    Type = InteropTypeResolver.ResolveType(x.Path),
                })
                .SingleOrDefault(x => x.Type != null);

            if (type == null)
            {
                throw new AphidRuntimeException(
                    "Could not find type for interop call '{0}'",
                    pathStr);
            }

            if (type.PartCount != path.Length - offset)
            {
                throw new AphidRuntimeException(
                    "Could not find method for interop call '{0}'",
                    pathStr);
            }

            return type.Type;
        }

        public static Type ResolveType(string name)
        {
            var n = InteropTypeResolver.Unalias(name);

            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                var t = asm.GetType(n);

                if (t != null)
                {
                    return t;
                }
            }

            return null;
        }

        public static string Unalias(string name)
        {
            switch (name)
            {
                case "string": return "System.String";
                case "byte": return "System.Byte";
                case "ushort": return "System.UInt16";
                case "uint": return "System.UInt32";
                case "ulong": return "System.UInt64";
                case "sbyte": return "System.Byte";
                case "short": return "System.Int16";
                case "int": return "System.Int32";
                case "long": return "System.Int64";
                case "float": return "System.Single";
                case "double": return "System.Double";
                case "decimal": return "System.Decimal";
                default: return name;
            }
        }
    }
}
