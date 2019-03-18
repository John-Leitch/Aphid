using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Components.Aphid.Parser
{
    public class AphidMutatorGroup
    {
        public virtual ReadOnlyCollection<AphidMutator> Mutators { get; }

        public AphidMutatorGroup(IEnumerable<AphidMutator> mutators) => Mutators = new ReadOnlyCollection<AphidMutator>(mutators.ToList());

        public AphidExpression MutateSingle(AphidExpression expression)
        {
            var mc = Mutators.Count;

            for (var x = 0; x < mc; x++)
            {
                expression = Mutators[x].MutateSingle(expression);
            }

            return expression;
        }

        public List<AphidExpression> Mutate(List<AphidExpression> ast)
        {
            var mc = Mutators.Count;

            for (var x = 0; x < mc; x++)
            {
                ast = Mutators[x].Mutate(ast);
            }

            return ast;
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
