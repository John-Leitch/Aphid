using Components.Aphid.Parser;
using System.Collections.Generic;

namespace Mantispid
{
    public class ParserIdentifier
    {
        public string Name { get; set; }

        [AphidAttribute]
        public string Type { get; set; }

        [AphidAttribute("list")]
        public bool IsList { get; set; }

        [AphidAttribute("root")]
        public bool IsRoot { get; set; }

        [AphidAttribute("opt")]
        public bool IsOptional { get; set; }

        public IdentifierExpression ToIdentifierExpression()
        {
            var idExp = new IdentifierExpression(Name);
            var attrs = new List<IdentifierExpression>();

            if (IsRoot)
            {
                attrs.Add(new IdentifierExpression("root"));
            }

            if (IsOptional)
            {
                attrs.Add(new IdentifierExpression("opt"));
            }

            if (IsList)
            {
                attrs.Add(new IdentifierExpression("list"));
            }

            if (Type != null)
            {
                attrs.Add(new IdentifierExpression(Type));
            }

            idExp.Attributes.AddRange(attrs);

            return idExp;
        }

        public static ParserIdentifier FromIdentifierExpression(IdentifierExpression identifierExpression)
        {
            var id = AphidAttributeParser.Parse<ParserIdentifier>(identifierExpression);
            id.Name = identifierExpression.Identifier;

            return id;
        }
    }
}
