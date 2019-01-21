#define TYPE_CACHE_NULL
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
        private static Dictionary<InteropTypeContext, Type> _typeCache =
            new Dictionary<InteropTypeContext, Type>(new InteropTypeContextComparer());

        private static LockTable<InteropTypeContext> _contextLocks = 
            new LockTable<InteropTypeContext>(new InteropTypeContextComparer());

        public InteropTypeResolver(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public Type TryResolveType(HashSet<string> imports, string[] path, bool isType = false) => ResolveType(imports, path, isFatal: false, isType: isType);

        public Type ResolveType(HashSet<string> imports, string[] path, bool isFatal = true, bool isType = false)
        {
            var ctx = new InteropTypeContext(imports, path, isType);
            
            lock (_contextLocks[ctx])
            {
                return ResolveTypeCore(ctx, imports, path, isFatal, isType);
            }
        }

        private Type ResolveTypeCore(
            InteropTypeContext ctx,
            HashSet<string> imports,
            string[] path,
            bool isFatal,
            bool isType)
        {
            lock (_typeCache)
            {
                if (_typeCache.TryGetValue(ctx, out var t))
                {
                    return t;
                }
            }

            var importsCopy = imports.ToArray();

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
                        .Concat(importsCopy)
                        .Select(y => new
                        {
                            x.Count,
                            Path = y.Length > 0 ? y + "." + x.Path : x.Path,
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
                        "Could not resolve member expression '{0}'.",
                        pathStr);
                }
                else
                {
#if TYPE_CACHE_NULL
                    ctx.IsResolved = false;

                    lock (_typeCache)
                    {
                        _typeCache.Add(ctx, null);
                    }
#endif

                    return null;
                }
            }

            if (type.PartCount != path.Length - offset)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not resolve member expression '{0}'",
                    pathStr);
            }

            ctx.IsResolved = type.Type != null;

            lock (_typeCache)
            {
                _typeCache.Add(ctx, type.Type);
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
