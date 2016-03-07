using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf
{
    public static class DeclarationHelper
    {
        public static IdentifierExpression GetDeclaredIdentifier(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.ForEachExpression:
                    var element = expression.ToForEach().Element;

                    if (element.Type == AphidExpressionType.IdentifierExpression)
                    {
                        return element.ToIdentifier();
                    }

                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOpExp = expression.ToBinaryOperator();

                    if (binOpExp.Operator == AphidTokenType.AssignmentOperator &&
                        binOpExp.LeftOperand.Type == AphidExpressionType.IdentifierExpression)
                    {
                        return binOpExp.LeftOperand.ToIdentifier();
                    }

                    break;
            }

            return null;
        }
    }
}
