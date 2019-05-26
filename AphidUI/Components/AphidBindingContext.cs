using Components.Aphid.Parser;
using System.Collections.Generic;

namespace Components.Aphid.Wpf
{
    public class AphidBindingContext
    {
        public AphidExpression[] BindingExpressions { get; private set; }

        public List<AphidExpression> MutatedAst { get; private set; }

        public string[] BindingPaths { get; private set; }

        public AphidBindingContext(
            AphidExpression[] bindingExpressions,
            List<AphidExpression> mutatedAst,
            string[] bindingPaths)
        {
            BindingExpressions = bindingExpressions;
            MutatedAst = mutatedAst;
            BindingPaths = bindingPaths;
        }
    }
}
