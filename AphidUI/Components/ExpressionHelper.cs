using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Exp = Components.Aphid.Parser.AphidExpression;
using ExpType = Components.Aphid.Parser.AphidExpressionType;
using static Components.Aphid.Lexer.AphidTokenType;
using System.Text;
using Components.External;

namespace Components.Aphid.Wpf
{
    public static class ExpressionHelper
    {
        private static Memoizer<Exp, string> _memoizer = new Memoizer<Exp, string>();

        public static bool IsMemberPath(Exp exp) => GetMemberPath(exp) != null;

        public static string GetMemberPath(Exp exp) => _memoizer.Call(GetMemberPathCore, exp);

        private static string GetMemberPathCore(Exp exp)
        {
            var sb = new StringBuilder();
            var curExp = exp;

            while (true)
            {
                switch (curExp.Type)
                {
                    case ExpType.IdentifierExpression:
                        sb.Append(curExp.ToIdentifier().Identifier);

                        return sb.ToString();

                    case ExpType.BinaryOperatorExpression:
                        var binOpExp = curExp.ToBinaryOperator();

                        if (binOpExp.Operator != MemberOperator ||
                            binOpExp.LeftOperand.Type != ExpType.IdentifierExpression)
                        {
                            return null;
                        }

                        sb.Append($".{binOpExp.LeftOperand.ToIdentifier().Identifier}");
                        curExp = binOpExp.RightOperand;

                        break;

                    default:
                        return null;
                }
            }
        }
    }
}
