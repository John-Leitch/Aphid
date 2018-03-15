using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.Library
{
    public class AphidSerializer : AphidRuntimeComponent
    {
        private const string _root = "obj";

        private List<object> _traversed;

        private Dictionary<object, string> _traversedPaths = new Dictionary<object, string>();

        private Stack<string> _currentPath = new Stack<string>();

        public bool IgnoreFunctions { get; set; }

        public AphidSerializer(AphidInterpreter interpreter)
            : base(interpreter)
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
                        !ShouldQuote(kvp.Key) ? "{0}{1}: " : "{0}'{1}':",
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
                new IdentifierExpression(_root).WithPositionFrom(ast[0]),
                AphidTokenType.AssignmentOperator,
                ast[0]);

            ast.AddRange(
                new AphidObjectReferenceVisitor()
                    .FindReferenceAssignments(ast));

            new AphidCodeVisitor(obj).Visit(ast);

            var objInterpreter = new AphidInterpreter();
            objInterpreter.Interpret(ast);

            return objInterpreter.CurrentScope[_root];
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

        private class AphidObjectThisKeywordMutator : AphidMutator
        {
            protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
            {
                if (expression.Type != AphidExpressionType.ThisExpression &&
                    (expression.Type != AphidExpressionType.IdentifierExpression ||
                        expression.ToIdentifier().Identifier != "this"))
                {
                    hasChanged = false;

                    return null;
                }

                hasChanged = true;

                return new List<AphidExpression> { new IdentifierExpression(_root) };
            }
        }

        private class AphidObjectReferenceVisitor : AphidVisitor
        {
            private ObjectExpression _object;

            private ArrayExpression _array;

            private BinaryOperatorExpression _member;

            private Stack<AphidExpression> _currentPath;

            private List<BinaryOperatorExpression> _refAssignments;

            public IEnumerable<BinaryOperatorExpression> FindReferenceAssignments(List<AphidExpression> ast)
            {
                Visit(ast);

                return _refAssignments.ToArray();
            }

            protected override void Visit(AphidExpression expression)
            {
                if (_member != null &&_member == expression && IsRef(_member.RightOperand))
                {
                    AddMemberReference(expression);
                }
            }

            private void AddMemberReference(AphidExpression expression)
            {
                AphidExpression lhs = null;

                foreach (var x in _currentPath.Reverse())
                {
                    if (lhs != null)
                    {
                        lhs = new BinaryOperatorExpression(lhs, AphidTokenType.MemberOperator, x)
                            .WithPositionFrom(x);
                    }
                    else
                    {
                        lhs = x;
                    }
                }

                _refAssignments.Add(
                    new BinaryOperatorExpression(
                        lhs,
                        AphidTokenType.AssignmentOperator,
                        _member.RightOperand));


                var i = _object.Pairs.IndexOf(_member);
                _object.Pairs.RemoveAt(i);

                _object.Pairs.Insert(
                    i,
                    new BinaryOperatorExpression(
                        _member.LeftOperand,
                        _member.Operator,
                        AphidParser.Parse("null").First()));
            }

            protected override void BeginVisit(List<AphidExpression> ast)
            {
                _currentPath = new Stack<AphidExpression>(
                    new[] { new IdentifierExpression(_root) });

                _refAssignments = new List<BinaryOperatorExpression>();
            }

            protected override void BeginVisitNode(AphidExpression expression)
            {
                if (IsMember(expression))
                {
                    _object = Ancestors.Peek().ToObject();
                    _member = expression.ToBinaryOperator();
                    _currentPath.Push(_member.LeftOperand);
                }
                else if (IsArray(expression))
                {
                    _array = expression.ToArray();
                }
            }

            protected override void EndVisitNode(AphidExpression expression)
            {
                if (IsMember(expression))
                {
                    _currentPath.Pop();
                    _member = null;
                    _object = null;
                }
                else if (IsArray(expression))
                {
                    _array = null;
                }
            }

            private bool IsMember(AphidExpression expression)
            {
                return expression != null &&
                    expression.Type == AphidExpressionType.BinaryOperatorExpression &&
                    Ancestors.Count >= 1 &&
                    Ancestors.Peek().Type == AphidExpressionType.ObjectExpression;
            }

            private bool IsArray(AphidExpression expression)
            {
                return expression != null && expression.Type == AphidExpressionType.ArrayExpression;
            }

            private bool IsRef(AphidExpression expression)
            {
                return expression.Type == AphidExpressionType.IdentifierExpression ||
                    expression.Type == AphidExpressionType.BinaryOperatorExpression;
            }
        }
    }
}
