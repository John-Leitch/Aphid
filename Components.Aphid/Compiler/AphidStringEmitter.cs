using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Components.Aphid.Compiler
{
    public abstract partial class AphidStringEmitter
    {
        private Dictionary<AphidTokenType, string> _binaryOperators = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.AdditionOperator, " + " },
            { AphidTokenType.MinusOperator, " - " },
            { AphidTokenType.MultiplicationOperator, " * " },
            { AphidTokenType.DivisionOperator, " / " },
            { AphidTokenType.ModulusOperator, " % " },

            { AphidTokenType.AndOperator, " && " },
            { AphidTokenType.OrOperator, " || " },

            { AphidTokenType.BinaryAndOperator, " & " },
            { AphidTokenType.BinaryOrOperator, " | " },
            { AphidTokenType.ShiftLeft, " << " },
            { AphidTokenType.ShiftRight, " >> " },
            
            { AphidTokenType.MemberOperator, "." },
            
            { AphidTokenType.EqualityOperator, " == " },
            { AphidTokenType.NotEqualOperator, " != " },
            { AphidTokenType.LessThanOperator, " < " },
            { AphidTokenType.LessThanOrEqualOperator, " <= " },
            { AphidTokenType.GreaterThanOperator, " > " },
            { AphidTokenType.GreaterThanOrEqualOperator, " >= " },

            { AphidTokenType.Comma, ", " },

            { AphidTokenType.AssignmentOperator, " = " },
            { AphidTokenType.PlusEqualOperator, " += " },
            { AphidTokenType.MinusEqualOperator, " -= " },
            { AphidTokenType.MultiplicationEqualOperator, " *= " },
            { AphidTokenType.DivisionEqualOperator, " /= " },
            { AphidTokenType.ModulusEqualOperator, " %= " },
            { AphidTokenType.ShiftLeftEqualOperator, " <<= " },
            { AphidTokenType.ShiftRightEqualOperator, " >>= " },
            { AphidTokenType.BinaryAndEqualOperator, " &= " },
            { AphidTokenType.OrEqualOperator, " |= " },
            { AphidTokenType.XorEqualOperator, " ^= " },
        };

        protected StringBuilder _out = new StringBuilder();

        protected void Append(string format, params object[] args)
        {
            _out.AppendFormat(format, args);
        }

        protected void Append(object value)
        {
            _out.Append(value.ToString());
        }

        protected virtual void EmitHeader() { }

        public void Emit(List<AphidExpression> statements)
        {
            foreach (var stmt in statements)
            {
                BeginStatement();
                Emit(stmt, isStatement: true);
                EndStatement();
            }
        }

        public virtual string Compile(List<AphidExpression> ast)
        {
            _out.Clear();
            EmitHeader();
            Emit(ast);

            return _out.ToString();
        }

        protected string GetOperator(Dictionary<AphidTokenType, string> table, AphidTokenType op)
        {
            string s;

            if (!table.TryGetValue(op, out s))
            {
                throw new NotImplementedException();
            }

            return s;
        }

        protected virtual string GetBinaryOperator(AphidTokenType op)
        {
            return GetOperator(_binaryOperators, op);
        }
    }
}
