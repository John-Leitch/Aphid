using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidScopeObjectAutocompletionSource : IAutocompletionSource
    {
        private AphidObject _currentScope;

        public AphidScopeObjectAutocompletionSource(AphidObject currentScope)
        {
            _currentScope = currentScope;
        }

        public IEnumerable<string> GetWords(
            string text,
            int offset,
            bool allowEmptySearch,
            out string searchBuffer)
        {
            var subStr = offset == text.Length ? text : text.Remove(offset);
            var tokens = AphidLexer.GetTokens(subStr);
            

            AphidToken lastToken = default(AphidToken);

            var inLastToken =
                tokens.Count != 0 &&
                (lastToken = tokens[tokens.Count - 1]).TokenType == AphidTokenType.Identifier &&
                lastToken.Index + lastToken.Lexeme.Length == offset;

            var isMemberAccess = lastToken.TokenType == AphidTokenType.MemberOperator;

            AphidExpression exp = null;
            AphidToken[] expTokens = null;

            try
            {
                var parseTokens = inLastToken ?
                    tokens :
                    tokens.Take(tokens.Count - 1).ToList();

                exp = AphidParser.Parse(parseTokens, subStr).LastOrDefault();
                expTokens = tokens.SkipWhile(x => x.Index != exp.Index).ToArray();
            }
            catch { }

            IEnumerable<string> words;

            if (expTokens != null)
            {
                words = ResolveAphidObject(expTokens, inLastToken);
            }
            else
            {
                words = GetGlobalWords();
            }

            if (inLastToken)
            {
                words = words.Where(x => x != lastToken.Lexeme && x.StartsWith(lastToken.Lexeme));
                searchBuffer = lastToken.Lexeme;
            }
            else
            {
                searchBuffer = "";

                if (!allowEmptySearch && !isMemberAccess)
                {
                    return null;
                }
            }

            return words.Where(x => !x.StartsWith("$")).OrderBy(x => x);
        }

        private IEnumerable<string> ResolveAphidObject(AphidToken[] tokens, bool inLastToken)
        {
            var scope = _currentScope;
            var inClrType = false;

            foreach (var t in !inLastToken ? tokens : tokens.Take(tokens.Length - 1))
            {
                switch (t.TokenType)
                {
                    case AphidTokenType.MemberOperator:
                        break;

                    case AphidTokenType.Identifier:
                        if (!inClrType && scope.Value == null)
                        {
                            if (!scope.TryResolve(t.Lexeme, out scope))
                            {
                                return new string[0];
                            }
                        }
                        else if (scope.Value == null && scope.Keys.Count == 0)
                        {
                            return new string[0];
                        }
                        else if (scope.Value != null)
                        {
                            inClrType = true;
                            scope = CreateTypeMemberObject(scope.Value.GetType());
                        }
                        else if (inClrType)
                        {
                            AphidObject obj;

                            if (!scope.TryGetValue(t.Lexeme, out obj))
                            {
                                return new string[0];
                            }

                            var prop = obj.Value as PropertyInfo;
                            var field = obj.Value as FieldInfo;

                            if (prop != null)
                            {
                                scope = CreateTypeMemberObject(prop.PropertyType);
                            }
                            else if (field != null)
                            {
                                scope = CreateTypeMemberObject(field.FieldType);
                            }
                            else
                            {
                                return new string[0];
                            }
                        }
                        break;
                }
            }

            if (scope.Value == null)
            {
                return scope.Keys;
            }
            else
            {
                return CreateTypeMemberObject(scope.Value.GetType()).Keys;
            }
        }

        private IEnumerable<string> GetGlobalWords()
        {
            var scope = _currentScope;
            IEnumerable<string> words = scope.Keys;

            while ((scope = scope.Parent) != null)
            {
                words = words.Concat(scope.Keys);
            }

            return words;
        }

        private AphidObject CreateTypeMemberObject(Type type)
        {
            var scope = new AphidObject();

            foreach (var m in type.GetMembers().GroupBy(x => x.Name))
            {
                scope.Add(m.Key, new AphidObject(m.First()));
            }

            return scope;
        }
    }
}
