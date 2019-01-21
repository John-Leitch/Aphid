using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidMacro
    {
        public string Name { get; }

        public FunctionExpression Declaration { get; }

        public BinaryOperatorExpression OriginalExpression { get; }

        public AphidMacro(string name, FunctionExpression declaration, BinaryOperatorExpression originalExpression)
        {
            Name = name;
            Declaration = declaration;
            OriginalExpression = originalExpression;
        }

        public static ArraySegment<AphidMacro> Parse(List<AphidExpression> ast)
        {
            var macros = new AphidMacro[ast.Count];
            var macroCount = 0;

            for (var i = 0; i < ast.Count; i++)
            {
                var node = ast[i];
                BinaryOperatorExpression binOp;
                CallExpression call;

                if (node.Type == AphidExpressionType.BinaryOperatorExpression &&
                    ((binOp = (BinaryOperatorExpression)node).LeftOperand.Type ==
                        AphidExpressionType.IdentifierExpression) &&
                    binOp.RightOperand.Type == AphidExpressionType.CallExpression &&
                    (call = (CallExpression)binOp.RightOperand).FunctionExpression.Type ==
                        AphidExpressionType.IdentifierExpression &&
                    ((IdentifierExpression)call.FunctionExpression).Identifier == "macro" &&
                    call.Args.Count == 1 &&
                    call.Args[0].Type == AphidExpressionType.FunctionExpression)
                {
                    macros[macroCount++] = new AphidMacro(
                        ((IdentifierExpression)binOp.LeftOperand).Identifier,
                        (FunctionExpression)call.Args[0],
                        binOp);
                }
            }

            return new ArraySegment<AphidMacro>(macros, 0, macroCount);
        }        
    }
}
