using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Components.Aphid.Parser.Mutators;
using Group = Components.Aphid.Parser.AphidMutatorGroup;

namespace Components.Aphid.Parser
{
    public static class MutatorGroups
    {
        public static Group GetMinimal() => new Group(Mutators.GetMinimal());
        public static Group GetStandard() => new Group(Mutators.GetStandard());
        public static Group GetOptimizing() => new Group(Mutators.GetOptimizing());
    }
}
