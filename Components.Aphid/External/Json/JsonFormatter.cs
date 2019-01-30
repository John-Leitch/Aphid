#if NO_JSON
#else
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Json
{
    public class JsonFormatter
    {
        private int _currentIndent;

        public int IndentSize { get; set; }

        public bool ConvertToHex { get; set; }

        public JsonFormatter()
        {
            IndentSize = 4;
            ConvertToHex = false;
        }

        public static string MakeCompliant(List<JsonToken> tokens)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < tokens.Count; i++)
            {
                switch (tokens[i].TokenType)
                {
                    case JsonTokenType.WhiteSpace:
                    case JsonTokenType.Comment:
                        break;

                    case JsonTokenType.HexNumber:
                        sb.Append(Convert.ToInt64(tokens[i].Lexeme, 16));
                        break;

                    default:
                        sb.Append(tokens[i].Lexeme);
                        break;
                }
            }

            return sb.ToString();
        }

        public static string MakeCompliant(string json) => MakeCompliant(new JsonLexer(json).GetAllTokens());

        private static JsonToken[] ConvertNumbersToHex(JsonToken[] tokens)
        {
            var tokensCopy = new JsonToken[tokens.Length];

            for (var i = 0; i < tokensCopy.Length; i++)
            {
                if (tokens[i].TokenType == JsonTokenType.Number && !tokens[i].Lexeme.Contains('.'))
                {
                    tokensCopy[i] = new JsonToken(
                        JsonTokenType.HexNumber,
                        "0x" + Convert.ToString(long.Parse(tokens[i].Lexeme), 16),
                        -1);
                }
                else
                {
                    tokensCopy[i] = tokens[i];
                }
            }

            return tokensCopy;
        }

        public string Format(string json)
        {
            var tokens = new JsonLexer(json)
                .GetTokens()
                .Where(x => x.TokenType != JsonTokenType.WhiteSpace && x.TokenType != JsonTokenType.Comment)
                .ToArray();

            if (ConvertToHex)
            {
                tokens = ConvertNumbersToHex(tokens);
            }

            var sb = new StringBuilder();

            foreach (var t in tokens)
            {
                switch (t.TokenType)
                {
                    case JsonTokenType.RightBrace:
                    case JsonTokenType.RightBracket:
                        _currentIndent--;
                        var indent = new string(' ', _currentIndent * IndentSize);
                        sb.Append("\r\n").Append(indent);
                        break;
                }

                sb.Append(t.Lexeme);

                if (t.TokenType == JsonTokenType.ColonOperator)
                {
                    sb.Append(' ');
                }

                switch (t.TokenType)
                {
                    case JsonTokenType.LeftBrace:
                    case JsonTokenType.LeftBracket:
                        _currentIndent++;
                        break;
                }

                switch (t.TokenType)
                {
                    case JsonTokenType.LeftBrace:
                    case JsonTokenType.LeftBracket:
                    case JsonTokenType.Comma:
                        var indent = new string(' ', _currentIndent * IndentSize);
                        sb.Append("\r\n").Append(indent);
                        break;
                }
            }

            return sb.ToString();
        }
    }
}

#endif