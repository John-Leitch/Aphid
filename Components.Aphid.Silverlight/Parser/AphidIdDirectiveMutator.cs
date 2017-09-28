using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class AphidIdDirectiveMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(
            AphidExpression expression,
            out bool hasChanged)
        {
            CallExpression callExp;

            if (expression.Type != AphidExpressionType.CallExpression ||
                ((callExp = expression.ToCall()).FunctionExpression.Type != AphidExpressionType.IdentifierExpression) ||
                callExp.FunctionExpression.ToIdentifier().Identifier != "id")
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return new List<AphidExpression>
            {
                new IdentifierExpression(
                    string.Join("", callExp.Args.Select(ParseArgument))),
            };
        }

        private string ParseArgument(AphidExpression argument)
        {
            switch (argument.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return argument.ToIdentifier().Identifier;

                case AphidExpressionType.StringExpression:
                    return StringParser.Parse(((StringExpression)argument).Value);

                default:
                    throw new AphidParserException(
                        "Unexpected {0} in id() directive, expected " +
                            "IdentifierExpression or StringExpression",
                        argument.Type);
            }
        }
    }
}
