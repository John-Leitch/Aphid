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
        public const string Root = "obj";

        private List<object> _traversed;

        private Dictionary<object, string> _traversedPaths = new Dictionary<object, string>();

        private Stack<string> _currentPath = new Stack<string>();

        public bool IgnoreFunctions { get; set; }

        public bool IgnoreSpecialVariables { get; set; }

        public bool QuoteToStringResults { get; set; }

        public AphidSerializer(AphidInterpreter interpreter)
            : base(interpreter)
        {
            IgnoreFunctions = true;
        }

        public string Serialize(AphidObject o)
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

            Action<object> checkGraph = x =>
            {
                if (x == null || !Interpreter.ValueHelper.IsComplexAphidObject(x))
                {
                    return;
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
                                .Select(y => !ShouldQuote(y) ? y : string.Format("{{'{0}'}}", y))
                                .Reverse()));
                    _traversed.Add(x);
                }
            };

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
                s.Append("{\r\n");

                foreach (var kvp in ao)
                {
                    if ((IgnoreFunctions &&
                        kvp.Value != null &&
                        (kvp.Value.Value is AphidFunction ||
                        kvp.Value.Value is AphidInteropFunction ||
                        kvp.Value.Value is AphidInteropPartialFunction ||
                        kvp.Value.Value is BinaryOperatorBodyExpression ||
                        kvp.Value.Value is AphidFunctionComposition)) ||
                        (IgnoreSpecialVariables && kvp.Key.StartsWith("$")))
                    {
                        continue;
                    }

                    s.AppendFormat(
                        !ShouldQuote(kvp.Key) ? "{0}{1}: " : "{0}'{1}':",
                        new string(' ', (indent + 1) * 4),
                        kvp.Key);

                    _currentPath.Push(kvp.Key);
                    Serialize(s, kvp.Value, indent + 1);
                    //ObjToString(kvp.Value, s, indent + 1);
                    _currentPath.Pop();
                    s.Append(",\r\n");
                }

                s.AppendFormat("{0}}}", new string(' ', indent * 4));
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
            else if (value is string)
            {
                s.Append(Quote((string)value));
            }
            else if (value is List<AphidObject>)
            {
                var list = (List<AphidObject>)value;

                if (list.Count > 0)
                {
                    s.Append("[\r\n");

                    foreach (var x in list)
                    {
                        s.Append(new string(' ', (indent + 1) * 4));
                        //ObjToString(x, s, indent + 1);
                        Serialize(s, x, indent + 1);
                        s.Append(",\r\n");
                    }

                    s.AppendFormat("{0}]", new string(' ', indent * 4));
                }
                else
                {
                    s.Append("[]");
                }
            }
            else if (value is IEnumerable)
            {
                SerializeEnumerable(s, value, indent);
            }
            else
            {
                SerializeToString(s, value);
            }
        }

        private void SerializeEnumerable(StringBuilder s, object value, int indent)
        {
            var enumerable = ((IEnumerable)value).Cast<object>();

            if (enumerable.Any())
            {
                s.Append("[\r\n");

                foreach (var x in enumerable)
                {
                    s.Append(new string(' ', (indent + 1) * 4));
                    SerializeValue(s, x, indent + 1);
                    //ObjToString(x, s, indent + 1);
                    s.Append(",\r\n");
                }

                s.AppendFormat("{0}]", new string(' ', indent * 4));
            }
            else
            {
                s.Append("[]");
            }
        }

        private void SerializeToString(StringBuilder s, object value)
        {
            if (value == null)
            {
                s.Append("null");

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
                s.Append(value.ToString());
            }
            else if (hasToString)
            {
                if (!QuoteToStringResults)
                {
                    s.Append(value.ToString());
                }
                else
                {
                    s.Append(Quote(value.ToString()));
                }
            }
            else
            {
                if (!QuoteToStringResults)
                {
                    s.AppendFormat("clrObject({0})", value.GetType().FullName);
                }
                else
                {
                    s.AppendFormat("{1}clrObject({0}){1}", value.GetType().FullName, "'");
                }

            }
        }

        public AphidObject Deserialize(string obj)
        {
            var lexer = new AphidObjectLexer(obj);
            var tokens = lexer.GetTokens();

            var ast = new AphidObjectThisKeywordMutator().Mutate(
                new List<AphidExpression>
                {
                    AphidParser.ParseExpression(tokens, obj)
                });

            if (ast.Count != 1)
            {
                throw Interpreter.CreateRuntimeException("Invalid Aphid object string: {0}", obj);
            }

            ast[0] = new BinaryOperatorExpression(
                new IdentifierExpression(
                    Root,
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(AphidName.Var)
                    })
                    .WithPositionFrom(ast[0]),
                AphidTokenType.AssignmentOperator,
                ast[0]);

            ast.AddRange(
                new AphidObjectReferenceVisitor()
                    .FindReferenceAssignments(ast));

            new AphidCodeVisitor(obj).Visit(ast);

            var objInterpreter = new AphidInterpreter();
            objInterpreter.Interpret(ast);

            return objInterpreter.CurrentScope[Root];
        }

        private bool ShouldQuote(string key)
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

        private string Quote(string value)
        {
            return string.Format("'{0}'", Escape(value));
        }

        private string Escape(string s)
        {
            return Regex.Replace(s, @"([\\'])", "\\$1").Replace("\r", "\\r").Replace("\n", "\\n");
        }
    }
}
