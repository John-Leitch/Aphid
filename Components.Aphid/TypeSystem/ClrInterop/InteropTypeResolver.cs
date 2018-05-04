using Components.Aphid.Interpreter;
using Components.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeResolver : AphidRuntimeComponent
    {
        private class InteropTypeContext
        {
            public string[] Imports { get; set; }

            public string[] Path { get; set; }

            public bool IsType { get; set; }

            public InteropTypeContext(string[] imports, string[] path, bool isType)
            {
                Imports = imports;
                Path = path;
                IsType = isType;
            }
        }

        private class InteropTypeContextComparer : IEqualityComparer<InteropTypeContext>
        {
            public bool Equals(InteropTypeContext x, InteropTypeContext y)
            {
                if ((x.Imports == null && y.Imports != null) ||
                    (x.Imports != null && y.Imports == null) ||
                    (x.Path == null && y.Path != null) ||
                    (x.Path != null && y.Path == null) ||
                    (x.IsType != y.IsType))
                {
                    return false;
                }
                else if (x.Imports != null)
                {
                    if (x.Imports.Length == y.Imports.Length)
                    {
                        for (var i = 0; i < x.Imports.Length; i++)
                        {
                            if (x.Imports[i] != y.Imports[i])
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                if (x.Path != null)
                {
                    if (x.Path.Length == y.Path.Length)
                    {
                        for (var i = 0; i < x.Path.Length; i++)
                        {
                            if (x.Path[i] != y.Path[i])
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

            public int GetHashCode(InteropTypeContext obj)
            {
                var x = 2;

                unchecked
                {
                    for (var i = 0; i < obj.Imports.Length; i++)
                    {
                        var t = obj.Imports[i].GetHashCode();

                        x *= t != 0 ? t : 8;

                        if (x == 0 || x == 1)
                        {
                            x = 9;
                        }
                    }

                    for (var i = 0; i < obj.Path.Length; i++)
                    {
                        var t = obj.Path[i].GetHashCode();

                        x *= t != 0 ? t : 10;

                        if (x == 0 || x == 1)
                        {
                            x = 11;
                        }
                    }

                    x *= obj.IsType ? 7 : 9;
                }

                return x;
            }
        }

        private static Dictionary<InteropTypeContext, Type> _typeCache =
            new Dictionary<InteropTypeContext, Type>(new InteropTypeContextComparer());

        public InteropTypeResolver(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public Type TryResolveType(string[] imports, string[] path, bool isType = false)
        {
            return ResolveType(imports, path, isFatal: false, isType: isType);
        }

        public Type ResolveType(string[] imports, string[] path, bool isFatal = true, bool isType = false)
        {
            lock (_typeCache)
            {
                return ResolveTypeCore(imports, path, isFatal, isType);
            }
        }

        private Type ResolveTypeCore(string[] imports, string[] path, bool isFatal, bool isType)
        {
            var ctx = new InteropTypeContext(imports, path, isType);
            Type t;

            if (_typeCache.TryGetValue(ctx, out t))
            {
                return t;
            }

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
                .FirstOrDefault(x => x.Type != null);

            if (type == null)
            {
                if (isFatal)
                {
                    throw Interpreter.CreateRuntimeException(
                        "Could not resolve member expression '{0}'",
                        pathStr);
                }
                else
                {
                    return null;
                }
            }

            if (type.PartCount != path.Length - offset)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not resolve member expression '{0}'",
                    pathStr);
            }

            _typeCache.Add(ctx, type.Type);

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
                case "bool": return "System.Boolean";
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
                case "void": return "System.Void";
                default: return name;
            }
        }
    }
}
