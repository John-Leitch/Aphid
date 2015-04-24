using Components.Aphid.Interpreter;

namespace AphidCodeGenerator
{
    public class AphidParserRules
    {
        [AphidProperty("binOpExps")]
        public AphidBinaryOperatorExpressionRule[] BinaryOperatorExpressions { get; set; }
    }    
}
