using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.TypeSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.Serialization
{
    // Todo:
    // * Exploit [Serializable] and [DataContract] by special casing type
    //   decorated as such to use appropriate serializers and embed result.
    // * Possibly support inline XML, use with aforementioned feature for
    //   cleaner data.
    // * Consider XML -> AphidData to use in previous feature.
    // * Add better binary support.
    //   - Use base64 or similar to support pure-text scenarios.
    //   - Support mixed-mode with embedded binary data for improved perf.
    //     * Append binary data after object expression using %> tag.
    //     * In object expression, reference data sections using offset and 
    //       length.
    //     * Check data integrity using hash function like SHA512.
    //     * Support different compression modes e.g. run-length encoding,
    //       GZ, etc.
    public class AphidSerializer : AphidRuntimeComponent
    {
        private readonly Type[] _safeEnumerableInterfaces = new Type[]
        {
            typeof(ICollection),
            typeof(ICollection<>),
            typeof(IList),
            typeof(IReadOnlyCollection<>),
            typeof(IReadOnlyDictionary<,>),
            typeof(IReadOnlyList<>)
        };

        public const string Root = "obj";

        private List<object> _traversed;

        private readonly Dictionary<object, string> _traversedPaths = new Dictionary<object, string>();

        private readonly Stack<string> _currentPath = new Stack<string>();
        
        private bool _useDoubleQuotes = false;

        private char _quoteChar = '\'';

        public bool IgnoreLazyLists { get; set; }

        public bool IgnoreFunctions { get; set; }

        public bool IgnoreSpecialVariables { get; set; }

        public bool QuoteToStringResults { get; set; }

        public bool AlwaysQuoteKeys { get; set; }

        public bool ToStringClrTypes { get; set; }

        public int MaxElements { get; set; } = -1;

        public bool UseDoubleQuotes
        {
            get => _useDoubleQuotes;
            set
            {
                _quoteChar = value ? '"' : '\'';
                _useDoubleQuotes = value;
            }
        }

        public AphidSerializer(AphidInterpreter interpreter)
            : base(interpreter) => IgnoreFunctions = true;

        public string Serialize(object o)
        {
            lock (this)
            {
                return SerializeCore(ValueHelper.Wrap(o));
            }
        }

        public string Serialize(AphidObject o)
        {
            lock (this)
            {
                return SerializeCore(o);
            }
        }

        private string SerializeCore(AphidObject o)
        {
            _traversedPaths.Clear();
            _currentPath.Clear();
            _currentPath.Push("this");
            _traversed = new List<object>();
            var sb = new StringBuilder();
            Serialize(sb, o, 0);

            return sb.ToString();
        }

        private void Serialize(StringBuilder s, object obj, int indent)
        {
            var ao = obj as AphidObject;

            if (obj == null)
            {
                s.Append("null");

                return;
            }

            var circular = false;

            void checkGraph(object x)
            {
                AphidObject ao2;

                if (x == null ||
                    (ao2 = x as AphidObject) == null ||
                    !ao2.IsComplex)
                {
                }
                else if (_traversed.Contains(x))
                {
                    s.Append(_traversedPaths[x]);
                    circular = true;
                }
                else
                {
                    _traversedPaths.Add(
                        x,
                        string.Join(
                            ".",
                            _currentPath
                                .Select(y => !ShouldQuote(y) ? y : Quote(y))
                                .Reverse()));
                    _traversed.Add(x);
                }
            }

            checkGraph(obj);

            if (circular)
            {
                return;
            }

            if (ao != null)
            {
                checkGraph(ao.Value);

                if (circular)
                {
                    return;
                }
            }

            if (ao.Value != null)
            {
                SerializeValue(s, ao.Value, indent);
            }
            else if (ao.IsScalar)
            {
                s.Append("null");
            }
            else if (ao.Keys.Count > 0)
            {
                var hasAny = false;

                foreach (var kvp in ao)
                {
                    if ((IgnoreFunctions &&
                        kvp.Value != null &&
                        (kvp.Value.Value is AphidFunction ||
                        kvp.Value.Value is AphidInteropFunction ||
                        kvp.Value.Value is AphidInteropPartialFunction ||
                        kvp.Value.Value is BinaryOperatorBodyExpression ||
                        kvp.Value.Value is AphidFunctionComposition ||
                        kvp.Value.Value is AphidInteropMember)) ||
                        (IgnoreSpecialVariables && kvp.Key.StartsWith("$")))
                    {
                        continue;
                    }

                    if (!hasAny)
                    {
                        s.Append("{\r\n");
                        hasAny = true;
                    }

                    if (!AlwaysQuoteKeys && !ShouldQuote(kvp.Key))
                    {
                        s.AppendFormat(
                             "{0}{2}: ",
                            new string(' ', (indent + 1) * 4),
                            _quoteChar,
                            kvp.Key);
                    }
                    else
                    {
                        s.AppendFormat(
                            "{0}{1}{2}{1}:",
                            new string(' ', (indent + 1) * 4),
                            _quoteChar,
                            Escape(kvp.Key));
                    }

                    _currentPath.Push(kvp.Key);
                    Serialize(s, kvp.Value, indent + 1);
                    //ObjToString(kvp.Value, s, indent + 1);
                    _currentPath.Pop();
                    s.Append(",\r\n");
                }

                if (hasAny)
                {
                    s.AppendFormat("{0}}}", new string(' ', indent * 4));
                }
                else
                {
                    s.Append("{ }");
                }
            }
            else
            {
                s.Append("{}");
            }
        }

        private void SerializeValue(StringBuilder s, object value, int indent)
        {
            if (value == null)
            {
                s.AppendFormat("{0}null", new string(' ', indent * 4));

                return;
            }

            var objType = value.GetType();

            if (objType == typeof(AphidObject))
            {
                Serialize(s, value, indent);
                return;
            }

            if (value is bool)
            {
                s.Append(value.ToString().ToLower());
            }
            //else if (value is decimal)
            else if ((objType = value.GetType()).IsPrimitive || objType.IsEnum)
            {
                s.Append(value.ToString());
            }
            else if (value is string str)
            {
                s.Append(Quote(str));
            }
            else if (value is List<AphidObject> list)
            {
                if (list.Count > 0)
                {

                    s.Append("[\r\n");

                    if (MaxElements < 0)
                    {

                        foreach (var x in list)
                        {
                            s.Append(new string(' ', (indent + 1) * 4));
                            //ObjToString(x, s, indent + 1);
                            Serialize(s, x, indent + 1);
                            s.Append(",\r\n");
                        }

                    }
                    else
                    {
                        var h = MaxElements / 2f;
                        int first = (int)Math.Ceiling(h), last = (int)Math.Floor(h);
                        var count = list.Count;
                        var skip = Math.Max(0, count - first - last);

                        foreach (var x in list.Take(first))
                        {
                            s.Append(new string(' ', (indent + 1) * 4));
                            //ObjToString(x, s, indent + 1);
                            Serialize(s, x, indent + 1);
                            s.Append(",\r\n");
                        }

                        if (skip != 0)
                        {
                            s.AppendFormat(
                                "{0}/* Skipped {1:n0} elements */\r\n",
                                new string(' ', (indent + 1) * 4),
                                skip);
                        }

                        foreach (var x in list.Skip(first + skip))
                        {
                            s.Append(new string(' ', (indent + 1) * 4));
                            //ObjToString(x, s, indent + 1);
                            Serialize(s, x, indent + 1);
                            s.Append(",\r\n");
                        }
                    }

                    s.AppendFormat("{0}]", new string(' ', indent * 4));

                }
                else
                {
                    s.Append("[]");
                }
            }
            else if (!IgnoreFunctions && value is AphidFunction function)
            {
                s.AppendFormat("@({0}) ", function.Args.Join(", "));

                if (function.Body.Count == 0)
                {
                    s.Append("{ },\r\n");
                }
                else if (function.Body.Count == 1 &&
                    function.Body[0].Type == AphidExpressionType.UnaryOperatorExpression &&
                    function.Body[0].ToUnaryOperator().Operator == AphidTokenType.retKeyword)
                {
                    s.AppendFormat("{0},\r\n", function.Body[0].ToUnaryOperator().Operand);
                }
                else
                {
                    s.Append("{\r\n");

                    var body = function.Body
                        .Select(x => x.IsStatement() ? x.ToString() : x.ToString() + ";")
                        .SelectMany(x => x.SplitLines())
                        .Select(x => x.Split(x.TakeWhile(char.IsWhiteSpace).Count()))
                        .Select(x => new[] { x[0].Replace("\t", "    "), x[1] })
                        .ToArray();

                    var trim = body.Min(x => x[0].Length);

                    var block = body
                        .Select(x => new string(' ', ((indent + 1) * 4) + x[0].Length - trim) + x[1])
                        .JoinLines();

                    s.AppendFormat("{0}\r\n{1}}}\r\n", block, new string(' ', indent * 4));
                }
            }
            else if (value is IEnumerable enumerable)
            {
                SerializeEnumerable(s, enumerable, indent);
            }
            else
            {
                SerializeToString(s, value);
            }
        }

        private void SerializeEnumerable(StringBuilder s, IEnumerable enumerable, int indent)
        {
            if (IgnoreLazyLists)
            {
                var type = enumerable.GetType();

                if (IgnoreLazyLists &&
                    !_safeEnumerableInterfaces
                        .Any(x => type.GetInterface(x.FullName) != null))
                {
                    SerializeClrTypeName(s, enumerable);

                    return;
                }
            }

            var hasAny = false;

            if (MaxElements < 0)
            {
                foreach (var x in enumerable)
                {
                    if (!hasAny)
                    {
                        s.Append("[\r\n");
                        hasAny = true;
                    }

                    s.Append(new string(' ', (indent + 1) * 4));
                    SerializeValue(s, x, indent + 1);
                    s.Append(",\r\n");
                }
            }
            else
            {
                var skipped = 0;
                var i = 0;
                var h = MaxElements / 2f;
                int first = (int)Math.Ceiling(h), last = (int)Math.Floor(h);
                List<object> head = new List<object>(), tail = new List<object>();

                foreach (var x in enumerable)
                {
                    if (++i > first)
                    {
                        

                        if (head.Count < last)
                        {
                            head.Add(x);
                        }
                        else
                        {
                            skipped++;
                        }

                        if (tail.Count == last)
                        {
                            tail.RemoveAt(0);
                        }

                        tail.Add(x);

                        continue;
                    }

                    if (!hasAny)
                    {
                        s.Append("[\r\n");
                        hasAny = true;
                    }

                    s.Append(new string(' ', (indent + 1) * 4));
                    SerializeValue(s, x, indent + 1);
                    s.Append(",\r\n");
                }

                if (skipped > 0)
                {
                    foreach (var x in head.Take(head.Count - tail.Count))
                    {
                        s.Append(new string(' ', (indent + 1) * 4));
                        SerializeValue(s, x, indent + 1);
                        s.Append(",\r\n");
                    }

                    //if (head.Count + tail.Count > MaxElements)
                    {
                        s.AppendFormat(
                            "{0}/* Skipped {1:n0} elements */\r\n",
                            new string(' ', (indent + 1) * 4),
                            skipped);
                    }

                    foreach (var x in tail)
                    {
                        s.Append(new string(' ', (indent + 1) * 4));
                        SerializeValue(s, x, indent + 1);
                        s.Append(",\r\n");
                    }
                }
                else
                {
                    foreach (var x in head)
                    {
                        s.Append(new string(' ', (indent + 1) * 4));
                        SerializeValue(s, x, indent + 1);
                        s.Append(",\r\n");
                    }
                }
            }

            if (hasAny)
            {
                s.AppendFormat("{0}]", new string(' ', indent * 4));
            }
            else
            {
                s.Append("[]");
            }
        }

        private void SerializeToString(StringBuilder sb, object value)
        {
            try
            {
                SerializeToStringCore(sb, value);
            }
            catch (Exception e)
            {
                sb.Append(Quote($"Error: {e}"));
            }
        }

        private void SerializeToStringCore(StringBuilder sb, object value)
        {
            if (value == null)
            {
                sb.Append("null");

                return;
            }

            Type valueType;

            var hasToString =
                (valueType = value.GetType())
                .GetMethod("ToString", new Type[0])
                .DeclaringType != typeof(object);

            if (valueType.IsPrimitive ||
                valueType.IsEnum ||
                valueType == typeof(bool) ||
                valueType == typeof(sbyte) ||
                valueType == typeof(short) ||
                valueType == typeof(int) ||
                valueType == typeof(long) ||
                valueType == typeof(byte) ||
                valueType == typeof(uint) ||
                valueType == typeof(ulong) ||
                valueType == typeof(float) ||
                valueType == typeof(double) ||
                valueType == typeof(decimal))
            {
                sb.Append(value.ToString());
            }
            else if (hasToString)
            {
                if (!QuoteToStringResults)
                {
                    sb.Append(value.ToString());
                }
                else
                {
                    sb.Append(Quote(value.ToString()));
                }
            }
            else
            {
                SerializeClrTypeName(sb, value);
            }
        }

        private void SerializeClrTypeName(StringBuilder sb, object clrObject) =>
            sb.AppendFormat(
                !QuoteToStringResults ? "clrObject({0})" : "{1}clrObject({0}){1}",
                clrObject.GetType().FullName,
                _quoteChar);

        public AphidObject Deserialize(string obj)
        {
            lock (this)
            {
                return DeserializeCore(obj);
            }
        }

        private AphidObject DeserializeCore(string obj)
        {
            var lexer = new AphidObjectLexer(obj);
            var tokens = lexer.GetTokens();

            var ast = new AphidObjectThisKeywordMutator().Mutate(
                new List<AphidExpression> { AphidParser.ParseExpression(tokens, obj) });

            if (ast.Count != 1)
            {
                throw Interpreter.CreateRuntimeException("Invalid Aphid object string: {0}", obj);
            }

            ast[0] = new BinaryOperatorExpression(
                new IdentifierExpression(
                    Root,
                    new List<IdentifierExpression>
                    {
                        (IdentifierExpression)new IdentifierExpression(AphidName.Var)
                            .WithPositionFrom(ast[0])
                    })
                    .WithPositionFrom(ast[0]),
                AphidTokenType.AssignmentOperator,
                ast[0])
                .WithPositionFrom(ast[0]);

            ast.AddRange(
                new AphidObjectReferenceVisitor()
                    .FindReferenceAssignments(ast));

            new AphidCodeVisitor().Visit(ast);

            var objInterpreter = new AphidInterpreter();
            objInterpreter.Interpret(ast);

            return objInterpreter.CurrentScope[Root];
        }

        private static bool ShouldQuote(string key)
        {
            if (key.Contains('$'))
            {
                return true;
            }

            try
            {
                var t = new AphidObjectLexer(key).GetTokens();

                return t.Count != 1 || t[0].TokenType != AphidTokenType.Identifier;
            }
            catch
            {
                return true;
            }
        }
            
        private string Quote(string value) =>
            string.Format("{0}{1}{0}", _quoteChar, Escape(value));

        private string Escape(string s) =>
            Regex.Replace(s, $@"([\\{_quoteChar}])", "\\$1").Replace("\r", "\\r").Replace("\n", "\\n");
    }
}
