using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public partial class UnaryOperatorExpression : AphidExpression, IParentNode
    {
        public override string ToString ()
        {
            return string.Format(IsPostfix ? "{0} {1}" : "{1} {0}", Operand, Operator);
        }
    }
}
