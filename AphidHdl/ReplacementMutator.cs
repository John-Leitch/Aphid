using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class ReplacementMutator : AphidMutator
    {
        private Func<AphidExpression, bool> _predicate;

        private Func<AphidExpression, List<AphidExpression>> _selector;

        public ReplacementMutator(
            Func<AphidExpression, bool> predicate,
            Func<AphidExpression, List<AphidExpression>> selector)
        {
            _predicate = predicate;
            _selector = selector;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (!_predicate(expression))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return _selector(expression);
        }
    }
}
