using System;
using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropMethodInfo
    {
        public MethodBase Method { get; }

        public Type[] GenericArguments { get; }

        public AphidInteropMethodArg[] Arguments { get; }

        public AphidInteropMethodInfo(
            MethodBase method, 
            Type[] genericArguments,
            AphidInteropMethodArg[] arguments)
        {
            Method = method;
            GenericArguments = genericArguments;
            Arguments = arguments;
        }
    }
}
