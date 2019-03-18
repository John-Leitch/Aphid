using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public interface IParentNode
    {
        IEnumerable<AphidExpression> GetChildren();
    }
}
