using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class DeclarativeStatementMutator : AphidMutator
    {
        private readonly string[] _tokenTypes, _parseFunctions;

        public DeclarativeStatementMutator(string[] tokenTypes, string[] parseFunctions)
        {
            _tokenTypes = tokenTypes;
            _parseFunctions = parseFunctions;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            if (!IsStatement || expression.Type != AphidExpressionType.IdentifierExpression)
            {
                return null;
            }

            var id = expression.ToIdentifier();
            var attributes = AphidAttributeParser.Parse<DeclarativeStatementAttributes>(id);
            var nameId = new IdentifierExpression(attributes.Name);

            if (_tokenTypes.Contains(id.Identifier))
            {
                hasChanged = true;

                var match = new CallExpression(
                    new IdentifierExpression("Match"),
                    new IdentifierExpression(id.Identifier));

                return attributes.Name == null ?
                    new List<AphidExpression> { match, } :
                    new List<AphidExpression>
                    {
                        new BinaryOperatorExpression(
                            nameId,
                            AphidTokenType.AssignmentOperator,
                            new IdentifierExpression("TokenType")),
                        match,
                    };
            }
            else if (_parseFunctions.Contains(id.Identifier))
            {
                hasChanged = true;
                var call = new CallExpression(new IdentifierExpression(id.Identifier));

                return attributes.Name == null ?
                    new List<AphidExpression> { call } :
                    new List<AphidExpression>
                    {
                        new BinaryOperatorExpression(
                            nameId,
                            AphidTokenType.AssignmentOperator,
                            call)
                    };
            }
            else if (id.Identifier == "NextToken")
            {
                hasChanged = true;

                return new List<AphidExpression>
                {
                    new CallExpression(new IdentifierExpression(id.Identifier))
                };
            }

            return null;
        }
    }
}
