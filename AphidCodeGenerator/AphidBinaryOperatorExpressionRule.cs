using Components.Aphid.Interpreter;

namespace AphidCodeGenerator
{
    public class AphidBinaryOperatorExpressionRule
    {
        [AphidProperty("name")]
        public string Name { get; set; }

        [AphidProperty("operators")]
        public string[] Operators { get; set; }

        [AphidProperty("operand")]
        public string Operand { get; set; }
    }
}
