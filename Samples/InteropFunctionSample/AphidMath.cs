using Components.Aphid.Interpreter;

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
