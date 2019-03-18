using Components.Aphid.Parser.Fluent;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Parser
{
    public class AphidPreprocessorDirectiveMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(
            AphidExpression expression,
            out bool hasChanged)
        {
            CallExpression callExp;

            if (expression.Type != AphidExpressionType.CallExpression ||
                (callExp = expression.ToCall()).FunctionExpression.Type !=
                    AphidExpressionType.IdentifierExpression)
            {
                hasChanged = false;

                return null;
            }

            var id = (IdentifierExpression)callExp.FunctionExpression;

            switch (id.Identifier)
            {
                case AphidDirective.Id:
                    hasChanged = true;

                    return CreateIdentifer(callExp, id);

                case AphidDirective.Quote:
                    hasChanged = true;

                    return CreateString(callExp);

                default:
                    hasChanged = false;

                    return null;
            }
        }

        private List<AphidExpression> CreateIdentifer(
            CallExpression callExp,
            IdentifierExpression callIdExp)
        {
            return new List<AphidExpression>
            {
                new IdentifierExpression(
                    string.Concat(callExp.Args.Select(ParseArgument)),
                    callIdExp.Attributes)
            };
        }

        private static List<AphidExpression> CreateString(CallExpression callExp)
        {
            if (callExp.Args.Count != 1)
            {
                throw new AphidParserException(
                    "Quote preprocessor directive expects a single argument.",
                    callExp);
            }

            string s;

            switch (callExp.Args[0].Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var idExp = (IdentifierExpression)callExp.Args[0];

                    if (idExp.Attributes.Count != 0)
                    {
                        throw new AphidParserException(
                            "Quote preprocessor directive argument cannot have attributes.",
                            callExp);
                    }

                    s = idExp.Identifier;
                    break;

                case AphidExpressionType.NumberExpression:
                    s = ((NumberExpression)callExp.Args[0]).Value.ToString();
                    break;

                case AphidExpressionType.BooleanExpression:
                    s = ((BooleanExpression)callExp.Args[0]).Value.ToString();
                    break;

                default:
                    throw new AphidParserException(
                        string.Format(
                            "Quote preprocessor directive argument must be identifier, number, " +
                                "or bool. Encountered {0} instead.",
                            callExp.Args[0].Type),
                        callExp);
            }

            return new List<AphidExpression>
            {
                new StringExpression(string.Format("'{0}'", s))
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
