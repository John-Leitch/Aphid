using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boxelder
{
    public class AphidPythonEmitter : AphidStringEmitter
    {
        private Dictionary<AphidTokenType, string> _operatorTables = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.AssignmentOperator, "=" },
            { AphidTokenType.AdditionOperator, "+" },
            { AphidTokenType.MinusOperator, "-" },
            { AphidTokenType.MultiplicationOperator, "*" },
            { AphidTokenType.DivisionOperator, "/" },
        };

        private Stack<string> _tabs = new Stack<string>();

        private uint _varId = 0;

        public override string Compile(List<AphidExpression> ast)
        {
            var mutators = new AphidMutator[] 
            {
                new PipelineToCallMutator(),
            };

            foreach (var mutator in mutators)
            {
                ast = mutator.Mutate(ast);
            }

            return base.Compile(ast);
        }

        private void Indent()
        {
            _tabs.Push("    ");
        }

        private void Unindent()
        {
            _tabs.Pop();
        }

        private string GetTabs()
        {
            return string.Join("", _tabs);
        }

        private void AppendTabs()
        {
            Append(GetTabs());
        }

        private void AppendLine()
        {
            Append("\r\n");
        }

        private void AppendStatement(string format, params object[] args)
        {
            Append(GetTabs() + format, args);
        }

        protected override void BeginStatement()
        {
            Append(GetTabs());
        }

        protected override void EndStatement()
        {
            AppendLine();
        }

        protected override void EmitNumberExpression(NumberExpression expression)
        {
            Append(expression.Value);
        }

        protected override void EmitBooleanExpression(BooleanExpression expression)
        {
            Append(expression.Value ? "True" : "False");
        }

        protected override void EmitStringExpression(StringExpression expression)
        {
            var escaped = StringParser
                .Parse(expression.Value)
                .Replace("\\", "\\\\")
                .Replace("\n", "\\\n")
                .Replace("\r", "\\\r")
                .Replace("'", "\\'");

            Append("'{0}'", escaped);
        }

        protected override void EmitIdentifierExpression(IdentifierExpression expression)
        {
            if (expression.Attributes.Any())
            {
                throw new NotImplementedException();
            }

            Append(expression.Identifier);
        }

        protected override void EmitUnaryOperatorExpression(UnaryOperatorExpression expression)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.retKeyword:
                    Append("return ");
                    Emit(expression.Operand);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        protected override void EmitBinaryOperatorExpression(BinaryOperatorExpression expression)
        {
            if (expression.RightOperand.Type != AphidExpressionType.FunctionExpression)
            {
                Emit(expression.LeftOperand);
                Append(" {0} ", GetOperator(expression.Operator));
                Emit(expression.RightOperand);
            }
            else
            {
                EmitFunctionDecl(expression);
            }
        }

        protected void EmitFunctionDecl(BinaryOperatorExpression expression)
        {
            var id = expression.LeftOperand.ToIdentifier();
            var func = expression.RightOperand.ToFunction();

            if (id.Attributes.Any())
            {
                throw new NotImplementedException();
            }

            Append("def {0}(", id.Identifier);
            EmitTuple(func.Args);
            Append("):\r\n");
            Indent();
            Emit(func.Body);
            Unindent();
        }

        protected override void EmitPartialFunctionExpression(PartialFunctionExpression expression)
        {
            var id = NextVarId();
            Append("(lambda {0}:", id);
            Emit(expression.Call.FunctionExpression);
            Append("(");
            EmitTuple(expression.Call.Args);
            Append(", {0}))", id);            
        }

        protected override void EmitIfExpression(IfExpression expression)
        {
            Append("if ");
            Emit(expression.Condition);
            Append(":\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();

            if (expression.ElseBody != null && expression.Body.Any())
            {
                Append("else:\r\n");
                Indent();
                Emit(expression.ElseBody);
                Unindent();
            }

            var s = _out.ToString();
        }

        protected override void EmitCallExpression(CallExpression expression)
        {
            Emit(expression.FunctionExpression);
            Append("(");
            EmitTuple(expression.Args);
            Append(")");
        }

        private void EmitTuple(IEnumerable<AphidExpression> items)
        {
            var first = true;

            foreach (var arg in items)
            {
                if (!first)
                {
                    Append(", ");
                }
                else
                {
                    first = false;
                }

                Emit(arg);
            }
        }

        private string GetOperator(AphidTokenType op)
        {
            string s;

            if (!_operatorTables.TryGetValue(op, out s))
            {
                throw new NotImplementedException();
            }

            return s;
        }

        private string NextVarId()
        {
            return string.Format("var_{0:X8}", _varId++);
        }
    }
}
