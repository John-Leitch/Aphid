using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class LoadLibraryExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.LoadLibraryExpression; }
        }

        public AphidExpression LibraryExpression { get; set; }

        public LoadLibraryExpression(AphidExpression libraryExpression)
        {
            LibraryExpression = libraryExpression;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { LibraryExpression };
        }
    }
}
