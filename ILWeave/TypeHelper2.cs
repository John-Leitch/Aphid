using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Cci
{
    public static class TypeHelper2
    {
        public static INamedTypeDefinition FindType<T>(IMetadataHost host)
        {
            var asm = (IAssembly)host.LoadUnitFrom(typeof(T).Assembly.Location);

            var type = UnitHelper.FindType(
                host.NameTable,
                asm,
                typeof(T).FullName);

            return type;
        }

        public static IMethodDefinition GetMethodRecursive(
            ITypeDefinition declaringType, 
            IName methodName, 
            params ITypeReference[] parameterTypes)
        {
            var m = TypeHelper.GetMethod(declaringType, methodName, parameterTypes);

            if (m == Dummy.Method)
            {
                foreach (var b in declaringType.BaseClasses)
                {
                    m = GetMethodRecursive(b.ResolvedType, methodName, parameterTypes);

                    if (m != Dummy.Method)
                    {
                        return m;
                    }
                }

                return Dummy.Method;
            }
            else
            {
                return m;
            }
        }
    }
}
