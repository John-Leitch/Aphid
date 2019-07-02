using Components.Aphid.Lexer;
using System.IO;

namespace Components.Aphid.Parser
{
    public static partial class ParserErrorMessage
    {
        public static string Create(string code, AphidParserException exception) =>
            Create(code, exception, true);

        public static string Create(string code, AphidParserException exception, bool highlight)
        {
            var actualCode = exception?.Filename != null && File.Exists(exception.Filename) ?
                AphidScript.Read(exception.Filename) :
                code;

            return
                exception.UnexpectedToken.TokenType != AphidTokenType.None ? FromToken(actualCode, exception, highlight) :
                exception.Expression != null ? FromExpression(actualCode, exception, highlight) :
                exception.Message;
        }
    }
}
