using System.Collections.Generic;
using System.Linq;

namespace Mantispid
{
    public class RuleStructResolver
    {
        public IEnumerable<RuleStruct> _ruleTypes;

        public RuleStructResolver(IEnumerable<RuleStruct> ruleTypes) =>
            _ruleTypes = ruleTypes;

        public RuleStruct Resolve(string name) =>
            _ruleTypes.SingleOrDefault(x => x.Name == name);

        public bool Is(RuleStruct ruleStruct, string name)
        {
            RuleStruct parent;

            return
                ruleStruct.Name == name || ruleStruct.BaseName == name ? true :
                ((parent = Resolve(ruleStruct.BaseName)) != null) ? Is(parent, name) :
                false;
        }

        public bool Is(string ruleStruct, string name)
        {
            RuleStruct rule;

            return ruleStruct == name ||
                ((rule = Resolve(ruleStruct)) != null && Is(rule, name));
        }
    }
}
