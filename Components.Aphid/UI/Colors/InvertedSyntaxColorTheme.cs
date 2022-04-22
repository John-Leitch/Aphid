using B = System.Byte;

namespace Components.Aphid.UI.Colors
{
    public class InvertedSyntaxColorTheme<TColorTheme> : AphidSyntaxColorTheme
        where TColorTheme : AphidSyntaxColorTheme, new()
    {
        public override B[] Foreground { get; }

        public override B[] Background { get; }

        public override B[] StringLiteral { get; }

        public override B[] Number { get; }

        public override B[] Keyword { get; }

        public override B[] Attribute { get; }

        public override B[] Identifier { get; }

        public override B[] Operator { get; }

        public override B[] MemberOperator { get; }

        public override B[] Bracket { get; }

        public override B[] Parenthesis { get; }

        public override B[] Comment { get; }

        public InvertedSyntaxColorTheme()
        {
            var src = new TColorTheme();
            Foreground = src.Foreground.Invert();
            Background = src.Background.Invert();
            StringLiteral = src.StringLiteral.Invert();
            Number = src.Number.Invert();
            Keyword = src.Keyword.Invert();
            Attribute = src.Attribute.Invert();
            Identifier = src.Identifier.Invert();
            Operator = src.Operator.Invert();
            MemberOperator = src.MemberOperator.Invert();
            Bracket = src.Bracket.Invert();
            Parenthesis = src.Parenthesis.Invert();
            Comment = src.Comment.Invert();
        }
    }
}
