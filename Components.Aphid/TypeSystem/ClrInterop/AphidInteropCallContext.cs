using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropCallContext
    {
        public MethodBase Method { get; private set; }

        public AphidConversionInfo[] ConversionInfo { get; private set; }

        public AphidInteropMethodArg[] Args { get; private set; }

        public uint Weight { get; private set; }

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
