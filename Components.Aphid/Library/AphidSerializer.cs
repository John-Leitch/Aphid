using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.Library
{
    public class AphidSerializer
    {
        private List<object> _traversed;

        public bool IgnoreFunctions { get; set; }

        public AphidSerializer()
        {
            IgnoreFunctions = true;
        }

        private string Escape(string s)
        {
            return Regex.Replace(s, @"([\\'])", "\\$1").Replace("\r", "\\r").Replace("\n", "\\n");
        }

        private void ObjToString(AphidObject obj, StringBuilder s, int indent)
        {
            if (obj == null)
            {
                s.Append("null");
                
                return;
            }

            var circular = false;

            Action<object> checkGraph = x =>
            {
                if (x == null)
                {
                    return;
                }

                if (_traversed.Contains(x))
                {
                    s.Append("'`Circular Reference`'");
                    circular = true;
                }
                else
                {
                    _traversed.Add(x);
                }
            };

            checkGraph(obj);
            checkGraph(obj.Value);

            if (circular)
            {
                return;
            }

            if (obj.Value != null)
            {
                if (obj.Value is bool ||
                    obj.Value is decimal)
                {
                    s.Append(obj.Value);
                }
                else if (obj.Value is string)
                {
                    s.Append(string.Format("'{0}'", Escape((string)obj.Value)));
                }
                else if (obj.Value is List<AphidObject>)
                {
                    var list = (List<AphidObject>)obj.Value;
                    s.Append("[\r\n");

                    foreach (var x in list)
                    {
                        s.Append(new string(' ', (indent + 1) * 4));
                        ObjToString(x, s, indent + 1);
                        s.Append(",\r\n");
                    }

                    s.AppendFormat("{0}]", new string(' ', indent * 4));
                }
                //else if (obj.Value is AphidFunction ||
                //    obj.Value is AphidInteropFunction)
                else
                {
                    s.AppendFormat("'`{0}`'", obj.Value.GetType().Name);
                }
                //else
                //{
                //    throw new InvalidOperationException();
                //}
            }
            else
            {
                s.Append("{\r\n");

                foreach (var kvp in obj)
                {
                    if (IgnoreFunctions && 
                        (kvp.Value.Value is AphidFunction ||
                        kvp.Value.Value is AphidInteropFunction))
                    {
                        continue;
                    }

                    s.AppendFormat(
                        "{0}{1}: ",
                        new string(' ', (indent + 1) * 4),
                        kvp.Key);

                    ObjToString(kvp.Value, s, indent + 1);
                    s.Append(",\r\n");
                }

                s.AppendFormat("{0}}}", new string(' ', indent * 4));
            }
        }

        public string Serialize(AphidObject o)
        {
            _traversed = new List<object>();
            var sb = new StringBuilder();
            ObjToString(o, sb, 0);

            return sb.ToString();
        }

        public AphidObject Deserialize(string obj)
        {
            var lexer = new AphidObjectLexer(obj);
            var tokens = lexer.GetTokens();
            tokens.Add(new AphidToken(AphidTokenType.EndOfStatement, null, 0));
            var ast = new AphidParser(tokens).Parse();

            if (ast.Count != 1)
            {
                throw new AphidRuntimeException("Invalid Aphid object string: {0}", obj);
            }

            ast[0] = new UnaryOperatorExpression(AphidTokenType.retKeyword, ast[0]);
            var objInterpreter = new AphidInterpreter();
            objInterpreter.Interpret(ast);
            return objInterpreter.GetReturnValue();
        }
    }
}
