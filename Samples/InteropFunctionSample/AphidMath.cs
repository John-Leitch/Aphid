using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;

namespace InteropFunctionSample
{
    public static class AphidMath
    {
        [AphidInteropFunction("math.add")]
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
    }
}
