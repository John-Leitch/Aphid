using Components.Aphid.Interpreter;
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

        public IEnumerable<Autocomplete> GetWords(
            string text,
            int offset,
            bool allowEmptySearch,
            out string searchBuffer)
        {
            var subStr = offset == text.Length ? text : text.Remove(offset);
            var tokens = AphidLexer.GetTokens(subStr);

            var assignIndex = tokens.FindLastIndex(x => x.TokenType == AphidTokenType.AssignmentOperator);

            if (assignIndex >= 0)
            {
                tokens = tokens.Skip(assignIndex + 1).ToList();
            }
            

            AphidToken lastToken = default(AphidToken);

            var inLastToken =
                tokens.Count != 0 &&
                (lastToken = tokens[tokens.Count - 1]).TokenType == AphidTokenType.Identifier &&
                lastToken.Index + lastToken.Lexeme.Length == offset;

            var isMemberAccess = lastToken.TokenType == AphidTokenType.MemberOperator;

            if (lastToken.TokenType == AphidTokenType.newKeyword)
            {
                searchBuffer = "";
                
                return CreateTypeAutocomplete(null);
            }
            else if (tokens.Count >= 2 &&
                tokens[tokens.Count - 2].TokenType == AphidTokenType.newKeyword)
            {
                searchBuffer = tokens[tokens.Count - 1].Lexeme;
                
                return CreateTypeAutocomplete(searchBuffer);
            }

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

            IEnumerable<Autocomplete> words;

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
                words = words.Where(x => x.Text != lastToken.Lexeme && x.Text.StartsWith(lastToken.Lexeme));
                searchBuffer = lastToken.Lexeme;
            }
            else
            {
                searchBuffer = "";

                if (!allowEmptySearch && !isMemberAccess && !isMemberAccess)
                {
                    return null;
                }
            }

            return words.Where(x => !x.Text.StartsWith("$")).OrderBy(x => x.Text);
        }

        //private string GetImports

        private IEnumerable<Autocomplete> ResolveAphidObject(AphidToken[] tokens, bool inLastToken)
        {
            var scope = _currentScope;
            IEnumerable<Autocomplete> autocomplete;
            var inClrType = false;

            if ((!inLastToken && tokens.Length >= 1 && tokens.Last().TokenType == AphidTokenType.newKeyword))
            {
            }

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
                                return new Autocomplete[0];
                            }
                        }
                        else if (scope.Value == null && scope.Keys.Count == 0)
                        {
                            return new Autocomplete[0];
                        }
                        else if (scope.Value != null)
                        {
                            inClrType = true;
                            return CreateTypeMemberObject(scope.Value.GetType());
                        }
                        else if (inClrType)
                        {
                            AphidObject obj;

                            if (!scope.TryGetValue(t.Lexeme, out obj))
                            {
                                return new Autocomplete[0];
                            }

                            var prop = obj.Value as PropertyInfo;
                            var field = obj.Value as FieldInfo;

                            if (prop != null)
                            {
                                return CreateTypeMemberObject(prop.PropertyType);
                            }
                            else if (field != null)
                            {
                                return CreateTypeMemberObject(field.FieldType);
                            }
                            else
                            {
                                return new Autocomplete[0];
                            }
                        }
                        break;
                }
            }

            if (scope.Value == null)
            {
                return CreateAphidMemberAutocompleteSet(scope, scope.Keys);
                //return scope.Keys;
            }
            else
            {
                return CreateTypeMemberObject(scope.Value.GetType());
            }
        }

        private IEnumerable<Autocomplete> GetGlobalWords()
        {
            return CreateAphidMemberAutocompleteSet(_currentScope);
        }

        private IEnumerable<Autocomplete> CreateAphidMemberAutocompleteSet(AphidObject scope)
        {
            var words = CreateAphidMemberAutocompleteSet(scope, scope.Keys);

            while ((scope = scope.Parent) != null)
            {
                words = words.Concat(CreateAphidMemberAutocompleteSet(scope, scope.Keys));
            }

            return words;
        }

        private IEnumerable<Autocomplete> CreateAphidMemberAutocompleteSet(
            AphidObject scope,
            IEnumerable<string> keys)
        {
            return keys.Select(x => CreateAphidMemberAutocomplete(scope, x));
        }

        private Autocomplete CreateAphidMemberAutocomplete(AphidObject scope, string key)
        {
            var view = key;
            var obj = scope[key];

            if (obj == null || (obj.Value == null && obj.Count == 0))
            {
                view += " null";
            }
            else if (obj.Keys.Count > 0)
            {
                view += " { }";
            }
            else if (obj.Value != null)
            {
                var func = obj.Value as AphidFunction;

                if (func != null)
                {
                    view += "(" + string.Join(", ", func.Args) + ")";
                }

                var interopFunc = obj.Value as AphidInteropFunction;

                if (interopFunc != null)
                {
                    view += "()";
                }

                if (func == null && interopFunc == null)
                {
                    view += string.Format(
                        " {0}",
                        obj.Value.GetType().Name);
                }
            }

            return new Autocomplete(view, key);
        }

        private IEnumerable<Autocomplete> CreateTypeMemberObject(Type type)
        {
            Autocomplete ac;

            var scope = new List<Autocomplete>();

            foreach (var m in type.GetMembers().GroupBy(x => x.Name))
            {
                var m2 = m.First();
                var view = m.Key;

                if (m2 is ConstructorInfo)
                {
                }
                else if (m2 is MethodBase)
                {
                    view += "()";
                }
                else if (m2 is PropertyInfo)
                {
                    view += "{ ";
                    var accessors = (m2 as PropertyInfo).GetAccessors();
                    if (accessors.Any(x => x.ReturnType != typeof(void)))
                    {
                        view += "get; ";
                    }

                    if (accessors.Any(x => x.ReturnType == typeof(void)))
                    {
                        view += "set; ";
                    }
                    
                    view += "}";
                }

                scope.Add(new Autocomplete(view, m.Key));
                //scope.Add(m.Key, new AphidObject(m.First()));
            }

            return scope;
        }

        private IEnumerable<Autocomplete> CreateTypeAutocomplete(string match = null)
        {
            AphidObject importObj;
            
            if (!_currentScope.TryGetValue(AphidName.Imports, out importObj))
            {
                return new Autocomplete[0];
            }

            var imports = (List<string>)importObj.Value;

            var loader = new TypeLoader();
            
            var types = loader
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => imports
                    .Any(y =>
                        x.FullName.StartsWith(y) &&
                        !x.FullName.Substring(y.Length + 1).Contains('.')))
                .Distinct()
                .ToArray();

            return types
                .Where(x => match != null ? x.Name.StartsWith(match) : true)
                .Select(x => new Autocomplete(x.Name + "()", x.Name));
        }
    }
}
