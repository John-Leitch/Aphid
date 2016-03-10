using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidInteropMethodInfo
    {
        public MethodInfo Method { get; private set; }

        public Type[] GenericArguments { get; private set; }

        public AphidInteropMethodArg[] Arguments { get; private set; }        

        public AphidInteropMethodInfo(
            MethodInfo method, 
            Type[] genericArguments,
            AphidInteropMethodArg[] arguments)
        {
            Method = method;
            GenericArguments = genericArguments;
            Arguments = arguments;
        }
    }
}
