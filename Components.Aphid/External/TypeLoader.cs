using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class TypeLoader
    {
        private RevertibleLazy<Dictionary<string, Assembly[]>> _assemblies =
            new RevertibleLazy<Dictionary<string, Assembly[]>>(() =>
                AppDomain.CurrentDomain
                    .GetAssemblies()
                    .GroupToArrayDictionary(x => x.FullName.RemoveAtIndexOf(',')));

        public IEnumerable<Assembly> GetAssemblies()
        {
            return _assemblies.Value.SelectMany(x => x.Value).Distinct();
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

            lock (_assemblies)
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

        private Exception GetResolveException(string name)
        {
            return new InvalidOperationException(
                string.Format("Could not resolve type '{0}'.", name));
        }
    }
}
