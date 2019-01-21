using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidScopeObjectAutocompletionSource : IAutocompletionSource, IDisposable
    {
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

        private const string _skipTokens =
            "( ) { } ! @ # $ % ^ & * + - = | \\ ; : ' \" < > , / ? \t";

        private static readonly List<AphidTokenType> _skipTokenTypes = AphidLexer
            .GetTokens(_skipTokens)
            .Select(x => x.TokenType)
            .Concat((AphidTokenType[])Enum
                .GetValues(typeof(AphidTokenType)))
                .OfType<AphidTokenType>()
                .Where(y =>
                    y != AphidTokenType.MemberOperator &&
                    y.ToString().EndsWith("Operator"))
            .ToList();

        private AphidObject _currentScope;

        private TypeLoader _loader = new TypeLoader();

        public AphidScopeObjectAutocompletionSource(AphidObject currentScope) => _currentScope = currentScope;

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

            var lastToken = default(AphidToken);

            var inLastToken =
                tokens.Count != 0 &&
                (lastToken = tokens[tokens.Count - 1]).TokenType == AphidTokenType.Identifier &&
                lastToken.Index + lastToken.Lexeme.Length == offset;

            var isMemberAccess = lastToken.TokenType == AphidTokenType.MemberOperator;

            // Todo: eliminate repetition
            if (lastToken.TokenType == AphidTokenType.newKeyword)
            {
                searchBuffer = "";

                return text[text.Length - 1] != 'w' ?
                    FilterAndSortWords(CreateTypeAutocomplete(null)) :
                    new Autocomplete[0];
            }
            else if (tokens.Count >= 2 &&
                tokens[tokens.Count - 2].TokenType == AphidTokenType.newKeyword)
            {
                searchBuffer = tokens[tokens.Count - 1].Lexeme;

                return FilterAndSortWords(CreateTypeAutocomplete(searchBuffer));
            }
            else if (lastToken.TokenType == AphidTokenType.usingKeyword)
            {
                searchBuffer = "";

                return text[text.Length - 1] != 'g' ?
                    FilterAndSortWords(CreateNamespaceAutocomplete(null)) :
                    new Autocomplete[0];
            }
            else if (tokens.Count >= 2 && tokens[0].TokenType == AphidTokenType.usingKeyword)
            {
                searchBuffer = tokens.Skip(1).Select(x => x.Lexeme).Join();

                return FilterAndSortWords(CreateNamespaceAutocomplete(searchBuffer));
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
#pragma warning disable CS0168 // The variable 'autocomplete' is declared but never used
            IEnumerable<Autocomplete> autocomplete;
#pragma warning restore CS0168 // The variable 'autocomplete' is declared but never used
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
                            scope = AphidObject.Scope();

                            foreach (var m in staticType
                                .GetMembers(BindingFlags.Public | BindingFlags.Static)
                                .GroupBy(x => x.Name))
                            {
                                // Todo: add all instead of first
                                scope.Add(m.Key, AphidObject.Scalar(m.First()));
                            }
                        }
                        else if (inStaticClrType)
                        {
                            scope = AphidObject.Scope();

                            if (scope.Value == null)
                            {
                                return new Autocomplete[0];
                            }

                            foreach (var m in ((Type)scope.Value)
                                .GetMembers(BindingFlags.Public | BindingFlags.Static)
                                .GroupBy(x => x.Name))
                            {
                                scope.Add(m.Key, AphidObject.Scalar(m.First()));
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
                            if (!scope.TryGetValue(t.Lexeme, out var obj))
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

        private IEnumerable<Autocomplete> GetGlobalWords() =>
            CreateAphidMemberAutocompleteSet(_currentScope);

        private static IEnumerable<Autocomplete> CreateAphidMemberAutocompleteSet(AphidObject scope)
        {
            var words = CreateAphidMemberAutocompleteSet(scope, scope.Keys);

            while ((scope = scope.Parent) != null)
            {
                words = words.Concat(CreateAphidMemberAutocompleteSet(scope, scope.Keys));
            }

            return words;
        }

        private static IEnumerable<Autocomplete> CreateAphidMemberAutocompleteSet(
            AphidObject scope,
            IEnumerable<string> keys) => keys.Select(x => CreateAphidMemberAutocomplete(scope, x));

        private static Autocomplete CreateAphidMemberAutocomplete(AphidObject scope, string key)
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
                    view += CreateArgTuple(interopFunc.InvokeDelegate.Method);
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

        private static IEnumerable<Autocomplete> CreateTypeMemberObject(Type type)
        {
            var scope = new List<Autocomplete>();

            foreach (var m in type.GetMembers(BindingFlags.Instance | BindingFlags.Public))
            {
                scope.Add(CreateMemberAutocomplete(m));
            }

            return scope;
        }

        private static Autocomplete CreateMemberAutocomplete(MemberInfo member)
        {
            var view = member.Name;

            if (member is MethodBase mb)
            {
                view += CreateArgTuple(mb);
            }
            else if (member is PropertyInfo prop)
            {
                view += " { ";
                var accessors = prop.GetAccessors();
                if (accessors.Any(x => x.ReturnType != typeof(void)))
                {
                    view += "get; ";
                }

                if (accessors.Any(x => x.ReturnType == typeof(void)))
                {
                    view += "set; ";
                }

                view += string.Format("}} -> {0}", prop.PropertyType.Name);
            }

            return new Autocomplete(view, member.Name);
        }

        private static string CreateArgTuple(MethodBase method)
        {
            var methodParams = method.GetParameters();

            var tup = methodParams
                .Select(x => string.Format("{0} {1}", x.ParameterType.Name, x.Name))
                .Join(", ");

            var methodInfo = method as MethodInfo;

            return methodInfo != null ?
                string.Format("({0}) -> {1}", tup, methodInfo.ReturnType.Name) :
                string.Format("({0})", tup);
        }

        private IEnumerable<Autocomplete> CreateTypeAutocomplete(string match = null)
        {
            if (!_currentScope.TryGetValue(AphidName.Imports, out var importObj))
            {
                return new Autocomplete[0];
            }

            var imports = (HashSet<string>)importObj.Value;

            var types = _loader
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => imports
                    .Any(y =>
                        x.FullName.StartsWith(y) &&
                        !x.FullName.Substring(y.Length + 1).Contains('.')))
                .SelectMany(x => x.GetConstructors())
                .Distinct()
                .ToArray();

            var typeMatches = types
                .Where(x =>
                    match != null ? x.DeclaringType.Name.StartsWith(match) : true)
                .Select(x => new Autocomplete(
                    x.DeclaringType.Name + CreateArgTuple(x),
                    x.DeclaringType.Name));

            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    var typeMatchesArray = typeMatches.ToArray();
            //}

            return typeMatches;
        }

        private IEnumerable<Autocomplete> CreateNamespaceAutocomplete(string match = null) =>
            _loader
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Select(x => new
                {
                    Namespace = x.FullName.Contains('.') ?
                        x.FullName.RemoveAtLastIndexOf('.') :
                        x.FullName,
                    x.Assembly,
                })
                .Where(x => match == null || x.Namespace.StartsWith(match))
                .GroupToDictionary(x => x.Namespace, x => x.Select(y => y.Assembly).Distinct())
                .Select(x => new Autocomplete(
                    string.Format(
                        "{0} -> {1}",
                        x.Key,
                        x.Value
                            .Select(y => !y.IsDynamic ?
                                Path.GetFileName(y.Location) :
                                y.GetName().Name)
                            .Join(", ")),
                    x.Key));

        private static IEnumerable<Autocomplete> FilterAndSortWords(IEnumerable<Autocomplete> words) =>
            words
                .Where(x =>
                    _wordContainsIgnore.None(y => x.Text.Contains(y)) &&
                    _wordStartsWithIgnore.None(y => x.Text.StartsWith(y)))
                .Distinct(x => x.View)
                .OrderBy(x => x.Text);

        private HashSet<string> GetImports()
        {
            if (!_currentScope.TryGetValue(AphidName.Imports, out var importObj))
            {
                return new HashSet<string>();
            }

            return (HashSet<string>)importObj.Value;
        }

        public void Dispose() => _loader.Dispose();
    }
}
