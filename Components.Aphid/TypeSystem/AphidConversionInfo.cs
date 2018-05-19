using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidConversionInfo
    {
        public AphidInteropMethodArg InteropArg { get; private set; }  

        public bool CanConvert { get; private set; }

        public Type[] GenericArguments { get; private set; }

        public AphidConversionInfo(
            AphidInteropMethodArg interopArg,
            bool canConvert,
            Type[] genericArguments)
        {
            InteropArg = interopArg;
            CanConvert = canConvert;
            GenericArguments = genericArguments;

            InteropArg.IsValueTypeEnumerable =
                GenericArguments.Length == 1 &&
                GenericArguments[0].IsValueType &&
                InteropArg.TargetType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
        }
    }
}
