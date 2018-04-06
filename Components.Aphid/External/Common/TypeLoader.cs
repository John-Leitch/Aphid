using Components;
using Components.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public sealed class TypeLoader : IDisposable
    {
        private object _cacheSync = new object();

        private RevertibleLazy<Dictionary<string, Assembly[]>> _assemblies =
            new RevertibleLazy<Dictionary<string, Assembly[]>>(() =>
                AppDomain.CurrentDomain
                    .GetAssemblies()
                    .GroupToArrayDictionary(x => x.FullName.RemoveAtIndexOf(',')));

        private Memoizer<List<string>, IEnumerable<Type>>
            _getAllTypesMemoizer = new Memoizer<List<string>, IEnumerable<Type>>(
                new NamespaceEqualityComparer()),

            _getStaticTypesMemoizer = new Memoizer<List<string>, IEnumerable<Type>>(
                new NamespaceEqualityComparer());

        public TypeLoader()
        {
            AppDomain.CurrentDomain.AssemblyLoad += OnAssemblyLoad;
        }

        void OnAssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            lock (_cacheSync)
            {
                _assemblies.Revert();
                _getAllTypesMemoizer.Clear();
                _getStaticTypesMemoizer.Clear();
            }
        }

        public IEnumerable<Assembly> GetAssemblies()
        {
            lock (_cacheSync)
            {
                return _assemblies.Value.SelectMany(x => x.Value).Distinct();
            }
        }

        public IEnumerable<Type> GetAllTypes(List<string> imports)
        {
            lock (_cacheSync)
            {
                return _getAllTypesMemoizer.Call(GetAllTypesCore, imports);
            }
        }

        private IEnumerable<Type> GetAllTypesCore(List<string> imports)
        {
            return this.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => imports
                    .Any(y =>
                        x.FullName.StartsWith(y) &&
                        !x.FullName.Substring(y.Length + 1).Contains('.')))
                .Distinct()
                .ToArray();
        }

        public IEnumerable<Type> GetStaticTypes(List<string> imports)
        {
            lock (_cacheSync)
            {
                return _getStaticTypesMemoizer.Call(GetStaticTypesCore, imports);
            }
        }

        private IEnumerable<Type> GetStaticTypesCore(List<string> imports)
        {
            return GetAllTypes(imports)
                .Where(x => x.GetMembers(BindingFlags.Public | BindingFlags.Static).Any())
                .ToArray();
        }

        public Type ResolveFullType(string fullTypeName)
        {
            var ns = fullTypeName;
            int i;
            var namespaceList = new List<string>();

            while ((i = ns.LastIndexOf('.')) != -1)
            {
                ns = ns.Remove(i);
                namespaceList.Add(ns);
            }

            var namespaces = namespaceList.ToArray();
            Assembly[] asms;

            lock (_cacheSync)
            {
                var hadAsms = _assemblies.IsValueCreated;

                if ((asms = TryGetAssemblies(namespaces)) == null && !hadAsms)
                {
                    throw GetResolveException(fullTypeName);
                }
                else
                {
                    _assemblies.Revert();

                    if ((asms = TryGetAssemblies(namespaces)) == null)
                    {
                        throw GetResolveException(fullTypeName);
                    }
                }
            }

            Type t;

            for (i = 0; i < asms.Length; i++)
            {
                if ((t = asms[i].GetType(fullTypeName)) != null)
                {
                    return t;
                }
            }

            throw GetResolveException(fullTypeName);
        }

        public Assembly[] TryGetAssemblies(string[] namespaces)
        {
            lock (_cacheSync)
            {
                var t = _assemblies.Value;

                Assembly[] asms;

                for (var i = 0; i < namespaces.Length; i++)
                {
                    if (t.TryGetValue(namespaces[i], out asms))
                    {
                        return asms;
                    }
                }

                return null;
            }
        }

        public static IEnumerable<TPlugin> LoadType<TPlugin>(Assembly asm)
        {
            return asm
                .GetTypes()
                .Where(x => !x.IsAbstract && x.IsDerivedFromOrImplements(typeof(TPlugin)))
                .Select(Activator.CreateInstance)
                .Cast<TPlugin>();
        }

        public IEnumerable<TPlugin> LoadType<TPlugin>()
        {
            return GetAssemblies().SelectMany(LoadType<TPlugin>);
        }

        private Exception GetResolveException(string name)
        {
            return new InvalidOperationException(
                string.Format("Could not resolve type '{0}'.", name));
        }

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= OnAssemblyLoad;
        }
    }
}
