using System;
using System.Collections.Generic;

namespace Components.Aphid.TypeSystem
{
    public class AphidConversionInfo
    {
        public AphidInteropMethodArg InteropArg { get; }

        public bool CanConvert { get; }

        public Type[] GenericArguments { get; }

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
