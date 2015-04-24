using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidMutatorGroup
    {
        public ReadOnlyCollection<AphidMutator> Mutators { get; private set; }

        public AphidMutatorGroup(IEnumerable<AphidMutator> mutators)
        {
            Mutators = new ReadOnlyCollection<AphidMutator>(mutators.ToList());
        }

        public List<AphidExpression> MutateRecursively(List<AphidExpression> ast)
        {
            var anyMutations = false;

            do
            {
                foreach (var m in Mutators)
                {
                    ast = m.MutateRecursively(ast);

                    if (m.HasMutated)
                    {
                        anyMutations = true;
                    }
                }
            } while (anyMutations);

            return ast;
        }
    }
}
