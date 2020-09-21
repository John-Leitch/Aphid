using System;
using System.Linq;

namespace LLex
{
    public class RegexCompiler
    {
        private readonly RegexExpression _expression;

        public RegexCompiler(RegexExpression expression) => _expression = expression;

        private int CountStrings(RegexExpression exp, int seed = 1)
        {
            var x = seed;
            if (exp.Quantifier == RegexTokenType.ZeroOrOneQuantifier)
            {
                x++;
            }

            if (exp is BinaryExpression binExp)
            {
                if (binExp.Operator == RegexTokenType.OrOperator)
                {
                    x++;
                }

                x += CountStrings(binExp.Left, 0) + CountStrings(binExp.Right, 0);
            }
            else if (exp is GroupExpression)
            {
                var groupExp = (exp as GroupExpression);
                x += CountStrings(groupExp.Expression, 0);
            }

            return x;
        }

        private string[] CompileToLiterals(RegexExpression exp, string seed = "")
        {
            if (exp is BinaryExpression binExp)
            {
                string[] leftLiterals = CompileToLiterals(binExp.Left),
                    rightLiterals = CompileToLiterals(binExp.Right);

                if (rightLiterals != null)
                {
                    var combinedStrings = leftLiterals.SelectMany(x => rightLiterals.Select(y => x + y));

                    return binExp.Operator == RegexTokenType.OrOperator ? leftLiterals.Concat(rightLiterals).ToArray() : combinedStrings.ToArray();
                }

                return leftLiterals;
            }
            else if (exp is GroupExpression groupExp)
            {
                var literals = CompileToLiterals(groupExp.Expression, seed);

                if (groupExp.Quantifier == RegexTokenType.ZeroOrOneQuantifier)
                {
                    return literals.Concat(new[] { "" }).ToArray();
                }
                else if (groupExp.Quantifier != RegexTokenType.None)
                {
                    throw new InvalidOperationException(
                        string.Format("Unsupported quantifier: {0}", groupExp.Quantifier));
                }

                return literals;
            }
            else
            {
                return exp is CharExpression charExp
                    ? charExp.Quantifier == RegexTokenType.None
                                    ? (new string[] { seed + charExp.Char.ToString() })
                                    : throw new InvalidOperationException(
                                    string.Format("Unsupported quantifier: {0}", charExp.Quantifier))
                    : throw new InvalidOperationException();
            }
        }

        public string[] ExpandRegex()
        {
            CountStrings(_expression);
            return CompileToLiterals(_expression);
        }
    }
}
