﻿using Components.Aphid.Interpreter;
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

        private Dictionary<object, string> _traversedPaths = new Dictionary<object,string>();

        private Stack<string> _currentPath = new Stack<string>();

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
                                .Select(y => !y.Contains("$") ? y : string.Format("{{'{0}'}}", y))
                                .Reverse()));
                    _traversed.Add(x);
                }
            };

            checkGraph(obj);

            if (circular)
            {
                return;
            }

            checkGraph(obj.Value);

            if (circular)
            {
                return;
            }

            if (obj.Value != null)
            {
                if (obj.Value is bool)
                {
                    s.Append(obj.Value.ToString().ToLower());
                }
                else if (obj.Value is decimal)
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
                else
                {
                    s.AppendFormat("'`{0}`'", obj.Value.GetType().Name);
                }
            }
            else
            {
                s.Append("{\r\n");

                foreach (var kvp in obj)
                { 
                    if (IgnoreFunctions && 
                        kvp.Value != null &&
                        (kvp.Value.Value is AphidFunction ||
                        kvp.Value.Value is AphidInteropFunction))
                    {
                        continue;
                    }

                    s.AppendFormat(
                        !kvp.Key.Contains("$") ? "{0}{1}: " : "{0}'{1}':",
                        new string(' ', (indent + 1) * 4),
                        kvp.Key);

                    _currentPath.Push(kvp.Key);
                    ObjToString(kvp.Value, s, indent + 1);
                    _currentPath.Pop();
                    s.Append(",\r\n");
                }

                s.AppendFormat("{0}}}", new string(' ', indent * 4));
            }
        }

        public string Serialize(AphidObject o)
        {
            _traversedPaths.Clear();
            _currentPath.Clear();
            _currentPath.Push("this");
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
