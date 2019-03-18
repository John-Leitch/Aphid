using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using static Components.Aphid.UI.Formatters.CodeMarker;

namespace Components.Aphid.UI.Formatters
{
    public static class ExcerptFormatter
    {
        public static string Format(AphidExpression statement, string name)
        {
            if (statement == null ||
                string.IsNullOrWhiteSpace(statement.Code) ||
                statement.Index < 0)
            {
                return null;
            }

            var code = TokenHelper.GetCodeExcerpt(
                    statement.Code
                        .Insert(statement.Index + statement.Length, End)
                        .Insert(statement.Index, Start),
                    statement.Index + Start.Length,
                    AphidConfig.Current.FrameExcerptLines / 2);

            var highlighted = SyntaxHighlightingFormatter.Format(code);

            return !string.IsNullOrWhiteSpace(highlighted) ? highlighted : null;
        }
    }
}
