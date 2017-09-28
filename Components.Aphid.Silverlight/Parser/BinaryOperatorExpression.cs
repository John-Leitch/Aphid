using System;
using System.Collections.Generic;
using Components.Aphid;
using Components.Aphid.Lexer;

namespace Components.Aphid.Parser
{
    public partial class BinaryOperatorExpression : AphidExpression, IParentNode
    {
        private Dictionary<AphidTokenType, string> _opTable = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.AdditionOperator, "+" },
            { AphidTokenType.MinusOperator, "-" },
            { AphidTokenType.MultiplicationOperator, "*" },
            { AphidTokenType.DivisionOperator, "/" },
            { AphidTokenType.ModulusOperator, "%" },
            { AphidTokenType.BinaryAndOperator, "&" },
            { AphidTokenType.BinaryOrOperator, "|" },
            { AphidTokenType.XorOperator, "^" },
            { AphidTokenType.ShiftLeft, "<<" },
            { AphidTokenType.ShiftRight, ">>" },
            { AphidTokenType.AssignmentOperator, "=" },

            { AphidTokenType.PlusEqualOperator, "+=" },
            { AphidTokenType.MinusEqualOperator, "-=" },
            { AphidTokenType.MultiplicationEqualOperator, "*=" },
            { AphidTokenType.DivisionEqualOperator, "/=" },
            { AphidTokenType.ModulusEqualOperator, "%=" },
            { AphidTokenType.OrEqualOperator, "|=" },
            { AphidTokenType.XorEqualOperator, "^=" },

            { AphidTokenType.AndOperator, "&&" },
            { AphidTokenType.OrOperator, "||" },
            
            { AphidTokenType.EqualityOperator, "==" },
            { AphidTokenType.NotEqualOperator, "!=" },
            { AphidTokenType.LessThanOperator, "<" },
            { AphidTokenType.LessThanOrEqualOperator, "<=" },
            { AphidTokenType.GreaterThanOperator, ">" },
            { AphidTokenType.GreaterThanOrEqualOperator, ">=" },

            { AphidTokenType.MemberOperator, "." },
            { AphidTokenType.ColonOperator, ":" },

            { AphidTokenType.PipelineOperator, "|>" },
        };

        public override string ToString()
        {
            var op = _opTable.ContainsKey(Operator) ? _opTable[Operator] : "[Unknown Op]";
            return string.Format("({0} {1} {2})", LeftOperand, op, RightOperand);
        }
    }
}

