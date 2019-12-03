using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TokenMap = System.Collections.Generic.Dictionary<Components.Aphid.Lexer.AphidTokenType, string>;
using static Components.Aphid.Lexer.AphidTokenType;
using System.Text.RegularExpressions;

namespace Components.Aphid.Compiler
{
    public abstract partial class AphidStringEmitter
    {
        private readonly TokenMap _unaryPrefixOperators = new TokenMap
        {
            { retKeyword, "ret " },
            { NotOperator, "!" },
            { MinusOperator, "-" },
            { ComplementOperator, "~" }
        };

        private readonly TokenMap _unaryPostfixOperators = new TokenMap
        {
            { IncrementOperator, "++" },
            { DecrementOperator, "--" }
        };

        private readonly TokenMap _binaryOperators = new TokenMap
        {
            { AdditionOperator, " + " },
            { MinusOperator, " - " },
            { MultiplicationOperator, " * " },
            { DivisionOperator, " / " },
            { ModulusOperator, " % " },

            { AndOperator, " && " },
            { OrOperator, " || " },

            { BinaryAndOperator, " & " },
            { BinaryOrOperator, " | " },
            { XorOperator,  " ^ " },
            { ShiftLeft, " << " },
            { ShiftRight, " >> " },

            { MemberOperator, "." },

            { EqualityOperator, " == " },
            { NotEqualOperator, " != " },
            { LessThanOperator, " < " },
            { LessThanOrEqualOperator, " <= " },
            { GreaterThanOperator, " > " },
            { GreaterThanOrEqualOperator, " >= " },

            { Comma, ", " },

            { AssignmentOperator, " = " },
            { PlusEqualOperator, " += " },
            { MinusEqualOperator, " -= " },
            { MultiplicationEqualOperator, " *= " },
            { DivisionEqualOperator, " /= " },
            { ModulusEqualOperator, " %= " },
            { ShiftLeftEqualOperator, " <<= " },
            { ShiftRightEqualOperator, " >>= " },
            { BinaryAndEqualOperator, " &= " },
            { OrEqualOperator, " |= " },
            { XorEqualOperator, " ^= " }
        };

        private readonly Stack<string> _tabs = new Stack<string>();

        protected StringBuilder _out = new StringBuilder();

        protected Stack<IEnumerable<AphidExpression>> Scope { get; } = new Stack<IEnumerable<AphidExpression>>();

        protected void Indent() => _tabs.Push("    ");

        protected void Unindent() => _tabs.Pop();

        protected string GetTabs() => string.Concat(_tabs);

        protected void AppendTabs() => Append(GetTabs());

        protected void AppendLine() => Append(Environment.NewLine);

        protected void Append(string format, params object[] args) => _out.AppendFormat(format, args);

        protected void Append(string value) => _out.Append(value);

        protected void Append(object value) => _out.Append(value.ToString());

        protected virtual void EmitHeader() { }

        public virtual void Emit(IEnumerable<AphidExpression> statements)
        {
            Scope.Push(statements);

            foreach (var stmt in statements)
            {
                BeginStatement(stmt);

                if (Debugger.IsAttached)
                {
                    Emit(stmt, isStatement: true);
                }
                else
                {
                    try
                    {
                        Emit(stmt, isStatement: true);
                    }
                    catch (NotImplementedException)
                    {
                        throw new InvalidOperationException(string.Format("{0} is not supported.", stmt.Type));
                    }
                }

                EndStatement(stmt);
            }

            Scope.Pop();
        }

        protected virtual void BeginExpression(AphidExpression expression) { }

        protected virtual void EndExpression(AphidExpression expression) { }

#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       public virtual string Compile(string filename, List<AphidExpression> ast)
        {
            var buildNumber = BuildNumberRepository.NextBuildNumber(filename);
            ast = new BuildConstMutator(buildNumber).Mutate(ast);
            _out.Clear();
            EmitHeader();
            Emit(ast);

            return _out.ToString();
        }

        protected static string GetOperator(TokenMap table, AphidTokenType op)
        {
            if (!table.TryGetValue(op, out var s))
            {
                throw new NotImplementedException();
            }

            return s;
        }

        protected virtual string GetUnaryPrefixOperator(AphidTokenType op) =>
            GetOperator(_unaryPrefixOperators, op);

        protected virtual string GetUnaryPostfixOperator(AphidTokenType op) =>
            GetOperator(_unaryPostfixOperators, op);

        protected virtual string GetBinaryOperator(AphidTokenType op) =>
            GetOperator(_binaryOperators, op);

#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       protected virtual void EmitUnaryOperatorExpression(UnaryOperatorExpression expression, bool isStatement = false)
        {
            if (expression.IsPostfix)
            {
                Emit(expression.Operand);
                Append(GetUnaryPostfixOperator(expression.Operator));
            }
            else
            {
                Append(GetUnaryPrefixOperator(expression.Operator));
                Emit(expression.Operand);
            }
        }

#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       protected virtual void EmitBinaryOperatorExpression(BinaryOperatorExpression expression, bool isStatement = false)
        {
            if (!isStatement)
            {
                Append("(");
            }

            Emit(expression.LeftOperand);
            Append(GetBinaryOperator(expression.Operator));
            Emit(expression.RightOperand);

            if (!isStatement)
            {
                Append(")");
            }
        }

#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       protected virtual void EmitStringExpression(StringExpression expression, bool isStatement = false)
        {
            var escaped = StringParser
                .Parse(expression.Value)
                .Replace("\\", "\\\\")
                .Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\"", "\\\"");

            escaped = Regex.Replace(
                escaped,
                @"[\x00-\x20\x7e-\xff]",
                x => $"\\x{(byte)x.Value[0]:x2}");

            Append("\"{0}\"", escaped);
        }

        protected virtual void EmitNumberExpression(NumberExpression expression, bool isStatement = false) =>
            Append(expression.Value);

#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       protected virtual void EmitNullExpression(NullExpression expression, bool isStatement = false) =>
            Append("null");

        protected virtual void EmitBooleanExpression(BooleanExpression expression, bool isStatement = false) =>
            Append(expression.Value ? "true" : "false");

        protected virtual void EmitCallExpression(CallExpression expression, bool isStatement = false)
        {
            Emit(expression.FunctionExpression);
            Append("(");
            EmitTuple(expression.Args);
            Append(")");
        }

        protected virtual void EmitArrayExpression(ArrayExpression expression, bool isStatement = false)
        {
            Append("[");
            EmitTuple(expression.Elements);
            Append("]");
        }

        protected virtual void EmitArrayAccessExpression(ArrayAccessExpression expression, bool isStatement = false)
        {
            Emit(expression.ArrayExpression);
            Append("[");
            EmitTuple(expression.KeyExpressions);
            Append("]");
        }

        protected void EmitTuple(IEnumerable<AphidExpression> items, string prefix = "", string suffix = "")
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

                Append(prefix);
                Emit(arg);
                Append(suffix);
            }
        }
    }
}
