using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidInteropMethodArg
    {
        public object Argument { get; private set; }

        public Type TargetType { get; private set; }

        public AphidInteropMethodArg(object argument, Type targetType)
        {
            Argument = argument;
            TargetType = targetType;
        }
    }
}
