using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropCallContext
    {
        public MethodBase Method { get; }

        public AphidConversionInfo[] ConversionInfo { get; }

        public AphidInteropMethodArg[] Args { get; }

        public uint Weight { get; }

        public AphidInteropCallContext(
            MethodBase method,
            AphidConversionInfo[] conversionInfo,
            AphidInteropMethodArg[] args)
        {
            Method = method;
            ConversionInfo = conversionInfo;
            Args = args;
        }
    }
}
