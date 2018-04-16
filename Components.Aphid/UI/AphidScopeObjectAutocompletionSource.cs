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
    public class AphidScopeObjectAutocompletionSource : IAutocompletionSource, IDisposable
    {
        private AphidObject _currentScope;

        private TypeLoader _loader = new TypeLoader();

        private static readonly string[] _wordContainsIgnore = new[]
        {
            "`",
            "<",
        };

        private static readonly string[] _wordStartsWithIgnore = new[]
        {
            ".ctor",
            "$",
            "get_",
            "set_",
            "op_",
        };

        private static readonly List<AphidTokenType> _skipTokenTypes = AphidLexer
            .GetTokens("( ) { } ! @ # $ % ^ & * + - = | \\ ; : '' \"\" < > , / ? \t")
            .Select(x => x.TokenType)
            .Concat((AphidTokenType[])Enum
                .GetValues(typeof(AphidTokenType)))
                .OfType<AphidTokenType>()
                .Where(y =>
                    y != AphidTokenType.MemberOperator &&
                    y.ToString().EndsWith("Operator"))
            .ToList();

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

            var lastSkipTokenIndex = tokens.FindLastIndex(x => _skipTokenTypes.Contains(x.TokenType));

            if (lastSkipTokenIndex >= 0)
            {
                tokens = tokens.Skip(lastSkipTokenIndex + 1).ToList();
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
                
                return FilterAndSortWords(CreateTypeAutocomplete(null));
            }
            else if (tokens.Count >= 2 &&
                tokens[tokens.Count - 2].TokenType == AphidTokenType.newKeyword)
            {
                searchBuffer = tokens[tokens.Count - 1].Lexeme;
                
                return FilterAndSortWords(CreateTypeAutocomplete(searchBuffer));
            }

            AphidExpression exp = null;
            AphidToken[] expTokens = null;

            try
            {
                var parseTokens = inLastToken ?
                    tokens :
                    tokens.Take(tokens.Count - 1).ToList();

                if (parseTokens.Count > 0)
                {
                    exp = AphidParser.Parse(parseTokens, subStr).LastOrDefault();
                    expTokens = tokens.SkipWhile(x => x.Index != exp.Index).ToArray();
                }
                else
                {
                    expTokens = tokens.ToArray();
                }
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

            return FilterAndSortWords(words);
        }

        private IEnumerable<Autocomplete> ResolveAphidObject(AphidToken[] tokens, bool inLastToken)
        {
            var scope = _currentScope;
            IEnumerable<Autocomplete> autocomplete;
            bool inClrType = false, inStaticClrType = false;

            var staticTypes = _loader.GetStaticTypes(GetImports());
            var tokenSet = !inLastToken ? tokens : tokens.Take(tokens.Length - 1);

            foreach (var t in tokenSet)
            {
                var isLast = t.Index == tokenSet.Last().Index;

                switch (t.TokenType)
                {
                    case AphidTokenType.MemberOperator:
                        break;

                    case AphidTokenType.Identifier:
                        if (staticTypes.Any(x => x.Name == t.Lexeme))
                        {
                            inStaticClrType = true;
                            
                            // First() hack until folding for overlapping types
                            // is implemented.
                            var staticType = staticTypes.First(x => x.Name == t.Lexeme);
                            scope = new AphidObject();

                            foreach (var m in staticType
                                .GetMembers(BindingFlags.Public | BindingFlags.Static)
                                .GroupBy(x => x.Name))
                            {
                                scope.Add(m.Key, new AphidObject(m.First()));
                            }
                        }
                        else if (inStaticClrType)
                        {
                            scope = new AphidObject();

                            if (scope.Value == null)
                            {
                                return new Autocomplete[0];
                            }

                            foreach (var m in ((Type)scope.Value)
                                .GetMembers(BindingFlags.Public | BindingFlags.Static)
                                .GroupBy(x => x.Name))
                            {
                                scope.Add(m.Key, new AphidObject(m.First()));
                            }
                        }
                        else if (!inClrType && scope.Value == null)
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
                        else
                        {
                            throw new NotImplementedException();
                        }
                        break;
                }
            }

            if (inStaticClrType)
            {
                return scope.Select(x => CreateMemberAutocomplete((MemberInfo)x.Value.Value));
            }

            if (scope.Value == null)
            {
                var ac = CreateAphidMemberAutocompleteSet(scope, scope.Keys);

                if (_currentScope == scope)
                {
                    ac = ac.Concat(
                        _loader.GetStaticTypes(GetImports())
                            .Select(x => new Autocomplete(x.Name, x.Name)));
                }

                return ac;
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
                //var objKeys = obj.Keys
                //    .Select(x => string.Format(
                //        "{0}{1}{2}",
                //        VT100.Foreground(SystemColor.AntiqueWhite),
                //        x,
                //        VT100.Reset))
                //    .Join(", ");

                //view += string.Format(" {{ {0} }}", objKeys);
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
            var scope = new List<Autocomplete>();

            foreach (var m in type.GetMembers().GroupBy(x => x.Name))
            {
                var ac = CreateMemberAutocomplete(m.First());
                scope.Add(ac);
            }

            return scope;
        }

        private Autocomplete CreateMemberAutocomplete(MemberInfo member)
        {
            var view = member.Name;

            if (member is ConstructorInfo)
            {
            }
            else if (member is MethodBase)
            {
                view += "()";
            }
            else if (member is PropertyInfo)
            {
                view += " { ";
                var accessors = (member as PropertyInfo).GetAccessors();
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

            return new Autocomplete(view, member.Name);
        }

        private IEnumerable<Autocomplete> CreateTypeAutocomplete(string match = null)
        {
            AphidObject importObj;
            
            if (!_currentScope.TryGetValue(AphidName.Imports, out importObj))
            {
                return new Autocomplete[0];
            }

            var imports = (List<string>)importObj.Value;
            
            var types = _loader
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

        private IEnumerable<Autocomplete> FilterAndSortWords(IEnumerable<Autocomplete> words)
        {
            return words
                .Where(x =>
                    _wordContainsIgnore.None(y => x.Text.Contains(y)) &&
                    _wordStartsWithIgnore.None(y => x.Text.StartsWith(y)))
                .Distinct(x => x.View)
                .OrderBy(x => x.Text);
        }

        private List<string> GetImports()
        {
            AphidObject importObj;

            if (!_currentScope.TryGetValue(AphidName.Imports, out importObj))
            {
                return new List<string>();
            }

            return (List<string>)importObj.Value;
        }

        public void Dispose()
        {
            _loader.Dispose();
        }
    }
}
