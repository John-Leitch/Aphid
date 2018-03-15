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

        public MethodInfo ImplicitConversionOperator { get; private set; }

        public MethodInfo ExplicitConversionOperator { get; private set; }

        public AphidConversionInfo(
            AphidInteropMethodArg interopArg,
            bool canConvert,
            Type[] genericArguments)
            : this(interopArg, canConvert, genericArguments, null, null)
        {
        }

        public AphidConversionInfo(
            AphidInteropMethodArg interopArg,
            bool canConvert,
            Type[] genericArguments,
            MethodInfo implicitConversionOperator,
            MethodInfo explicitConversionOperator)
        {
            InteropArg = interopArg;
            CanConvert = canConvert;
            GenericArguments = genericArguments;
            ImplicitConversionOperator = implicitConversionOperator;
            ExplicitConversionOperator = explicitConversionOperator;
        }
    }
}
