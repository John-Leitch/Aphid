#define TYPE_CACHE_NULL
using Components.Aphid.Interpreter;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeResolver : AphidRuntimeComponent
    {
        private static readonly Dictionary<InteropTypeContext, Type> _typeCache =
            new Dictionary<InteropTypeContext, Type>(new InteropTypeContextComparer());

        private static readonly ReaderWriterLockSlim _typeCacheLock = new ReaderWriterLockSlim();

        private static readonly LockTable<string[]> _pathLocks =
            new LockTable<string[]>(new PathTailComparer());

        public InteropTypeResolver(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public Type TryResolveType(
            HashSet<string> imports,
            ReaderWriterLockSlim importsLock,
            string[] path,
            bool isType = false) =>
            ResolveType(imports, importsLock, path, isFatal: false, isType: isType);

        public Type ResolveType(
            HashSet<string> imports,
            ReaderWriterLockSlim importsLock,
            string[] path,
            bool isFatal = true,
            bool isType = false)
        {
            var ctx = new InteropTypeContext(imports, path, isType, importsLock);

            //lock (_contextLocks[ctx])
            lock (_pathLocks[path])
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
            _typeCacheLock.EnterReadLock();

            try
            {
                if (_typeCache.TryGetValue(ctx, out var t))
                {
                    return t;
                }
            }
            finally
            {
                _typeCacheLock.ExitReadLock();
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
                    Type = ResolveType(x.Path),
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
#if TYPE_CACHE_NULL
                ctx.IsResolved = false;

                _typeCacheLock.EnterWriteLock();

                try
                {
                    _typeCache.Add(ctx, null);
                }
                finally
                {
                    _typeCacheLock.ExitWriteLock();
                }
#endif

                return null;
            }

            if (type.PartCount != path.Length - offset)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not resolve member expression '{0}'",
                    pathStr);
            }

            ctx.IsResolved = type.Type != null;

            _typeCacheLock.EnterWriteLock();

            try
            {
                if (!_typeCache.ContainsKey(ctx))
                {
                    _typeCache.Add(ctx, type.Type);
                }
            }
            finally
            {
                _typeCacheLock.ExitWriteLock();
            }

            return type.Type;
        }

        public static Type ResolveType(string name)
        {
            var n = Unalias(name);

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
                case "char": return "System.Char";
                case "string": return "System.String";
                case "bool": return "System.Boolean";
                case "byte": return "System.Byte";
                case "ushort": return "System.UInt16";
                case "uint": return "System.UInt32";
                case "ulong": return "System.UInt64";
                case "sbyte": return "System.SByte";
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
