using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidMacro
    {
        public string Name { get; private set; }

        public FunctionExpression Declaration { get; private set; }

        public BinaryOperatorExpression OriginalExpression { get; private set; }

        public AphidMacro(string name, FunctionExpression declaration, BinaryOperatorExpression originalExpression)
        {
            Name = name;
            Declaration = declaration;
            OriginalExpression = originalExpression;
        }

        public static AphidMacro[] Parse(List<AphidExpression> ast)
        {
            return ast
                .OfType<BinaryOperatorExpression>()
                .Select(x => new
                {
                    Id = x.LeftOperand as IdentifierExpression,
                    Call = x.RightOperand as CallExpression,
                    Original = x,
                })
                .Where(x => x.Id != null && x.Call != null && x.Call.Args.Count() == 1)
                .Select(x => new
                {
                    Name = x.Id.Identifier,
                    CallName = x.Call.FunctionExpression as IdentifierExpression,
                    Func = x.Call.Args.Single() as FunctionExpression,
                    x.Original,
                })
                .Where(x =>
                    x.CallName != null &&
                    x.CallName.Identifier == "macro" &&
                    x.Func != null)
                .Select(x => new AphidMacro(x.Name, x.Func, x.Original))
                .ToArray();
        }        
    }
}
