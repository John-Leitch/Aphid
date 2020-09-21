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
using AT = Components.Aphid.Lexer.AphidTokenType;
using AC = Components.External.ConsolePlus.Autocomplete;
using System.Text;

namespace Components.Aphid.UI
{
    public class AphidScopeObjectAutocompletionSource : IAutocompletionSource, IDisposable
    {
        private static readonly Lazy<AC[]> _keywords = new Lazy<AC[]>(() =>
            Enum
                .GetValues(typeof(AphidTokenType))
                .OfType<AphidTokenType>()
                .Select(x => x.ToString())
                .Where(x => x.EndsWith("Keyword"))
                .Select(x => x.Replace("Keyword", ""))
                .Where(x => AphidLexer.GetToken(x).TokenType.ToString().EndsWith("Keyword"))
                .Select(x => new AC($"{x} keyword", x))
                .ToArray());

        private static readonly string[] _wordContainsIgnore = new[]
        {
            //"`",
            "<"
        };

        private static readonly string[] _wordStartsWithIgnore = new[]
        {
            ".ctor",
            "$",
            "get_",
            "set_",
            "op_"
        };

        private const string _skipTokens =
            "( ) { } ! @ # $ % ^ & * + - = | \\ ; : ' \" < > , / ? \t";

        private static readonly List<AT> _skipTokenTypes = AphidLexer
            .GetTokens(_skipTokens)
            .Select(x => x.TokenType)
            .Concat((AT[])Enum
                .GetValues(typeof(AT)))
                .OfType<AT>()
                .Where(y =>
                    y != AT.MemberOperator &&
                    y.ToString().EndsWith("Operator"))
            .ToList();

        private readonly AphidObject _currentScope;

        private readonly TypeLoader _loader = new TypeLoader();

        public AphidScopeObjectAutocompletionSource(AphidObject currentScope) => _currentScope = currentScope;

        public IEnumerable<AC> GetWords(
            string text,
            int offset,
            bool allowEmptySearch,
            out string searchBuffer)
        {
            var subStr = offset == text.Length ? text : text.Remove(offset);
            var tokens = AphidLexer.GetTokens(subStr).ToArray();

            var lastSkipTokenIndex = -1;

            for (var i = 0; i < tokens.Length; i++)
            {
                if (_skipTokenTypes.Contains(tokens[i].TokenType))
                {
                    lastSkipTokenIndex = i;
                }
            }

            if (lastSkipTokenIndex >= 0)
            {
                var len = tokens.Length - (++lastSkipTokenIndex);
                var tmp = new AphidToken[len];

                for (var i = 0; i < len; i++)
                {
                    tmp[i] = tokens[lastSkipTokenIndex + i];
                }
                //tokens = tokens.Skip(lastSkipTokenIndex + 1).ToArray();
            }

            var lastToken = default(AphidToken);

            var inLastToken =
                tokens.Length != 0 &&
                ((lastToken = tokens[tokens.Length - 1]).TokenType == AT.Identifier ||
                    lastToken.TokenType == AT.newKeyword ||
                    lastToken.TokenType == AT.usingKeyword) &&
                lastToken.Index + lastToken.Lexeme.Length == offset;

            var isMemberAccess = lastToken.TokenType == AT.MemberOperator;

            // Todo: eliminate repetition
            if (lastToken.TokenType == AT.newKeyword)
            {
                searchBuffer = "";

                return subStr[subStr.Length - 1] != 'w' ?
                    FilterAndSortWords(CreateTypeAutocomplete(null)) :
                    Array.Empty<AC>();
            }
            else if (tokens.Length >= 2 &&
                tokens[tokens.Length - 2].TokenType == AT.newKeyword)
            {
                searchBuffer = tokens[tokens.Length - 1].Lexeme;

                return FilterAndSortWords(CreateTypeAutocomplete(searchBuffer));
            }
            else if (lastToken.TokenType == AT.usingKeyword)
            {
                searchBuffer = "";

                return subStr[subStr.Length - 1] != 'g' ?
                    FilterAndSortWords(CreateNamespaceAutocomplete(null)) :
                    Array.Empty<AC>();
            }
            else if (tokens.Length >= 2 && tokens[0].TokenType == AT.usingKeyword)
            {
                searchBuffer = tokens.Skip(1).Select(x => x.Lexeme).Join();

                return FilterAndSortWords(CreateNamespaceAutocomplete(searchBuffer));
            }

            AphidExpression exp = null;
            AphidToken[] expTokens = null;

            //try
            //{
            //    var parseTokens = inLastToken ?
            //        tokens :
            //        tokens.Take(tokens.Count - 1).ToList();

            //    if (parseTokens.Count > 0)
            //    {
            //        exp = AphidParser.Parse(parseTokens, subStr).LastOrDefault();
            //        expTokens = tokens.SkipWhile(x => x.Index != exp.Index).ToArray();
            //    }
            //    else
            //    {
            //        expTokens = tokens.ToArray();
            //    }
            //}
            //catch { }
            expTokens = tokens;

            IEnumerable<AC> words = expTokens != null ? ResolveAphidObject(expTokens, inLastToken) : GetGlobalWords();
            if (inLastToken)
            {
                words = words.Where(x => x.Text != lastToken.Lexeme && x.Text.StartsWith(lastToken.Lexeme));
                searchBuffer = lastToken.Lexeme;
            }
            else
            {
                searchBuffer = "";

                if (!allowEmptySearch && !isMemberAccess)
                {
                    words = GetGlobalWords();
                    //return null;
                }
            }

            return FilterAndSortWords(words);
        }

        private AphidObject CreateTypeMemberScope(IEnumerable<Type> types, bool isStatic = false)
        {
            var scope = AphidObject.Scope();
            types
                .SelectMany(x =>
                    x.GetMembers(
                        isStatic ?
                            BindingFlags.Static |
                            BindingFlags.FlattenHierarchy |
                            BindingFlags.Public :
                            BindingFlags.Instance |
                            BindingFlags.Static |
                            BindingFlags.FlattenHierarchy |
                            BindingFlags.Public))
                .GroupBy(x => x.Name)
                .Iter(x => scope.Add(x.Key, AphidObject.Scalar(x.Distinct())));

            scope.Add(AphidName.MemberSets, AphidObject.InternedTrue);

            return scope;
        }

        private AphidObject CreateTypeMemberScope(Type type, bool isStatic = false)
        {
            var scope = AphidObject.Scope();
            type
                .GetMembers(
                        isStatic ?
                            BindingFlags.Static |
                            BindingFlags.FlattenHierarchy |
                            BindingFlags.Public :
                            BindingFlags.Instance |
                            BindingFlags.Static |
                            BindingFlags.FlattenHierarchy |
                            BindingFlags.Public)
                .GroupBy(x => x.Name)
                .Iter(x => scope.Add(x.Key, AphidObject.Scalar(x.Distinct())));

            scope.Add(AphidName.MemberSets, AphidObject.InternedTrue);

            return scope;
        }

        private IEnumerable<AC> ResolveAphidObject(AphidToken[] tokens, bool inLastToken)
        {
            var scope = _currentScope;
            bool inClrType = false, inStaticClrType = false;

            var staticTypes = _loader.GetStaticTypes(GetImports());
            var memberAccess = false;
            var tokenSet = !inLastToken ? tokens : tokens.Take(tokens.Length - 1).ToArray();

            for (var i = 0; i < tokenSet.Length; i++)
            {
                var t = tokenSet[i];
                var scanningLast = i == tokenSet.Length - 1;

                //if (memberAccess)
                //{
                //    if (scope.TryGetValue(t.Lexeme, out var member))
                //    {
                //        scope = member;
                //    }

                //    memberAccess = false;

                //    if (inLastToken)
                //    {
                //        return CreateAphidMemberAutocompleteSet(scope);
                //    }
                //}                

                switch (t.TokenType)
                {
                    case AT.MemberOperator:
                        memberAccess = true;
                        break;

                    case AT.Identifier:
                        if (inClrType || inStaticClrType)
                        {
                            inClrType = false;
                            inStaticClrType = false;
                            if (!scope.TryGetValue(t.Lexeme, out var memberSetObj))
                            {
                                scope = _currentScope;
                                continue;
                            }

                            var memberSet = (IEnumerable<MemberInfo>)memberSetObj.Value;

                            if (memberSet.Count() == 1)
                            {
                                var member = memberSet.First();

                                if (member is PropertyInfo prop)
                                {
                                    scope = CreateTypeMemberScope(prop.PropertyType);
                                    inClrType = true;
                                }
                                else if (member is FieldInfo field)
                                {
                                    scope = CreateTypeMemberScope(field.FieldType);
                                    inClrType = true;
                                }
                                else if (member is MethodInfo m)
                                {
                                    scope = CreateTypeMemberScope(m.ReturnType);
                                }
                                else
                                {
                                    inClrType = false;
                                    scope = _currentScope;
                                }
                            }
                            else if (memberSet.OfType<MethodInfo>().Any())
                            {
                                inClrType = true;

                                scope = CreateTypeMemberScope(memberSet
                                    .OfType<MethodInfo>()
                                    .Select(x => x.ReturnType).ToArray());                               
                            }
                            else
                            {                                
                                scope = _currentScope;
                            }
                        }
                        else if (staticTypes.Any(x => x.Name == t.Lexeme))
                        {
                            inStaticClrType = true;

                            scope = CreateTypeMemberScope(
                                staticTypes.Where(x => x.Name == t.Lexeme),
                                isStatic: true);
                        }
                        else if (!inClrType && scope.Value == null)
                        {
                            if (!scope.TryResolve(t.Lexeme, out scope))
                            {
                                scope = _currentScope;                                
                            }
                            else if (scope.Value != null)
                            {
                                inClrType = true;

                                scope = CreateTypeMemberScope(scope.Value.GetType());
                            }
                        }
                        else
                        {
                            scope = scope.Value == null && scope.Keys.Count == 0 ? _currentScope : throw new NotImplementedException();
                        }

                        break;

                    default:
                        //memberAccess = false;
                        //inClrType = false;
                        //inStaticClrType = false;
                        //scope = _currentScope;
                        break;
                }
            }

            if (inStaticClrType || inClrType || scope.ContainsKey(AphidName.MemberSets))
            {
                return CreateMemberGroupAutoCompleteSet(scope);
            }
            else if (scope.Value == null)
            {
                if (_currentScope == scope)
                {
                    return CreateAphidMemberAutocompleteSet(scope)
                        .Concat(_loader.GetAllTypes(GetImports())
                        .Select(x => new AC(x.Name, x.Name))
                        .Concat(_keywords.Value))
                        #if NO_LAZY_EVAL
                        .ToArray()
                        #endif
                        ;
                }
                else
                {
                    return CreateAphidMemberAutocompleteSet(scope, scope.Keys);
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

            return CreateMemberGroupAutoCompleteSet(CreateTypeMemberScope(scope.Value.GetType()));
        }

        private IEnumerable<AC> CreateMemberGroupAutoCompleteSet(AphidObject scope)
        { 
            scope.Remove(AphidName.MemberSets);

            return scope
                .SelectMany(x => (IEnumerable<MemberInfo>)x.Value.Value)
                .Select(CreateMemberAutocomplete)
                #if NO_LAZY_EVAL
                .ToArray()
                #endif
                ;
        }

        private IEnumerable<AC> GetGlobalWords() =>
            CreateAphidMemberAutocompleteSet(_currentScope);
        
        private static IEnumerable<AC> CreateAphidMemberAutocompleteSet(AphidObject scope)
        {
            var words = CreateAphidMemberAutocompleteSet(scope, scope.Keys);

            while ((scope = scope.Parent) != null)
            {
                words = words.Concat(CreateAphidMemberAutocompleteSet(scope, scope.Keys));
            }

            return words;
        }

        private static IEnumerable<AC> CreateAphidMemberAutocompleteSet(
            AphidObject scope,
            IEnumerable<string> keys) => keys.Select(x => CreateAphidMemberAutocomplete(scope, x));

        private static AC CreateAphidMemberAutocomplete(AphidObject scope, string key)
        {
            var sb = new StringBuilder(key);
            var obj = scope[key];

            if (obj == null || (obj.Value == null && obj.Count == 0))
            {
                sb.Append(" null");
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
                sb.AppendFormat(" {{ {0} members }}", obj.Keys.Count);
            }
            else if (obj.Value is AphidFunction func)
            {
                sb.Append("(" + string.Join(", ", func.Args) + ")");
            }
            //else if (obj.Value is AphidInteropMember interopMember)
            //{
            //    sb.Append(CreateArgTuple(interopMember.Members.First()));
            //}
            else if  (obj.Value is AphidInteropFunction interopFunc)
            {
                sb.Append(CreateArgTuple(interopFunc.InvokeDelegate.Method));
            }
            else
            {
                sb.AppendFormat(" {0}", obj.Value.GetType().Name);
            }

            return new AC(sb.ToString(), key);
        }

        private static AC CreateMemberAutocomplete(MemberInfo member)
        {
            var sb = new StringBuilder(member.Name);

            if (member is MethodBase mb)
            {
                sb.Append(CreateArgTuple(mb));
            }
            else if (member is PropertyInfo prop)
            {
                sb.Append(" { ");
                var accessors = prop.GetAccessors();
                if (accessors.Any(x => x.ReturnType != typeof(void)))
                {
                    sb.Append("get; ");
                }

                if (accessors.Any(x => x.ReturnType == typeof(void)))
                {
                    sb.Append("set; ");
                }

                sb.AppendFormat("}} -> {0}", prop.PropertyType.Name);
            }

            return new AC(sb.ToString(), member.Name);
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

        private IEnumerable<AC> CreateTypeAutocomplete(string match = null)
        {
            var imports = GetImports();

            var types = _loader
                .GetAssemblies()
                .SelectMany(x => x.TryGetTypes() ?? Array.Empty<Type>())
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
                .Select(x => new AC(
                    x.DeclaringType.Name + CreateArgTuple(x),
                    x.DeclaringType.Name));

            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    var typeMatchesArray = typeMatches.ToArray();
            //}

            return typeMatches;
        }

        private IEnumerable<AC> CreateNamespaceAutocomplete(string match = null) =>
            _loader
                .GetAssemblies()
                .SelectMany(x => x.TryGetTypes() ?? Array.Empty<Type>())
                .Select(x => new
                {
                    Namespace = x.FullName.Contains('.') ?
                        x.FullName.RemoveAtLastIndexOf('.') :
                        x.FullName,
                    x.Assembly,
                })
                .Where(x => match == null || x.Namespace.StartsWith(match))
                .GroupToDictionary(x => x.Namespace, x => x.Select(y => y.Assembly).Distinct())
                .Select(x => new AC(
                    string.Format(
                        "{0} -> {1}",
                        x.Key,
                        x.Value
                            .Select(y => !y.IsDynamic ?
                                Path.GetFileName(y.Location) :
                                y.GetName().Name)
                            .Join(", ")),
                    x.Key));

        private static IEnumerable<AC> FilterAndSortWords(IEnumerable<AC> words) =>
            words
                .Where(x =>
                    _wordContainsIgnore.None(y => x.Text.Contains(y)) &&
                    _wordStartsWithIgnore.None(y => x.Text.StartsWith(y)))
                .Distinct(x => x.View)
                .OrderBy(x => x.Text);

        private HashSet<string> GetImports() => !_currentScope.TryResolve(AphidName.Imports, out var importObj)
                ? new HashSet<string>(AphidConfig.Current.Imports)
                : (HashSet<string>)importObj.Value;

        public void Dispose() => _loader.Dispose();
    }
}
