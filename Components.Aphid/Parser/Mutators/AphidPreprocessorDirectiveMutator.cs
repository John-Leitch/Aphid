using Components.Aphid.Parser.Fluent;
using System.Collections.Generic;
using System.Linq;
using ET = Components.Aphid.Parser.AphidExpressionType;
using Exp = Components.Aphid.Parser.AphidExpression;


namespace Components.Aphid.Parser
{
    public class AphidPreprocessorDirectiveMutator : AphidMutator
    {
        protected override List<Exp> MutateCore(
            Exp expression,
            out bool hasChanged)
        {
            CallExpression callExp;

            if (expression.Type != ET.CallExpression ||
                (callExp = expression.ToCall()).FunctionExpression.Type !=
                    ET.IdentifierExpression)
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

        private List<Exp> CreateIdentifer(
            CallExpression callExp,
            IdentifierExpression callIdExp) => new List<Exp>
            {
                new IdentifierExpression(
                    string.Concat(callExp.Args.Select(x => ParseArgument(callExp, x))),
                    callIdExp.Attributes)
            };

        private static List<Exp> CreateString(CallExpression callExp)
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
                case ET.IdentifierExpression:
                    var idExp = (IdentifierExpression)callExp.Args[0];

                    if (idExp.Attributes.Count != 0)
                    {
                        throw new AphidParserException(
                            "Quote preprocessor directive argument cannot have attributes.",
                            callExp);
                    }

                    s = idExp.Identifier;
                    break;

                case ET.StringExpression:
                    s = StringParser.Parse(((StringExpression)callExp.Args[0]).Value);
                    break;

                case ET.NumberExpression:
                    s = ((NumberExpression)callExp.Args[0]).Value.ToString();
                    break;

                case ET.BooleanExpression:
                    s = ((BooleanExpression)callExp.Args[0]).Value.ToString();
                    break;

                default:
                    throw new AphidParserException(
                        string.Format(
                            "Quote preprocessor directive argument must be identifier, string, " +
                                "number, or bool. Encountered {0} instead.",
                            callExp.Args[0].Type),
                        callExp);
            }

            return new List<Exp> { new StringExpression(string.Format("'{0}'", s)) };
        }

        private string ParseArgument(CallExpression call, Exp argument)
        {
            switch (argument.Type)
            {
                case ET.IdentifierExpression:
                    return argument.ToIdentifier().Identifier;

                case ET.StringExpression:
                    return StringParser.Parse(((StringExpression)argument).Value);

                default:
                    throw new AphidParserException(
                        string.Format(
                            "Unexpected {0} {1} in id() directive {2}, expected " +
                                "IdentifierExpression or StringExpression",
                            argument.Type,
                            argument,
                            call),
                        argument);
            }
        }
    }
}
