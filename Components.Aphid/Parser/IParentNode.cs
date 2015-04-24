using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public interface IParentNode
    {
        IEnumerable<AphidExpression> GetChildren();
    }
}
