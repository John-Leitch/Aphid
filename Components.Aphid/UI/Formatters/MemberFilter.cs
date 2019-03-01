using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using AphidPair = System.Collections.Generic.KeyValuePair<string, Components.Aphid.TypeSystem.AphidObject>;

namespace Components.Aphid.UI.Formatters
{
    public static class MemberFilter
    {
        public static AphidPair[] Apply(AphidObject complexObj) =>
            complexObj
                .ExceptKey(
                    AphidName.AsmBuilder,
                    AphidName.Interpreter,
                    AphidName.DumpSerializer,
                    AphidName.Scope,
                    AphidName.Parent,
                    AphidName.Block,
                    AphidName.Code,
                    AphidName.FramesKey,
                    AphidName.Imports)
                .ExceptKey(x => x.StartsWith("$ext.") || x.StartsWith("$customOperator."))
                .Member(x => x.Value.Value)
                .Not<AphidFunction, AphidInteropFunction, AphidInteropMember>()
                .Member(x => x.Value.Values)
                .Not(x =>
                    x.Count > 0 &&
                    x.Member(y => y.Value)
                        .Not<AphidFunction, AphidInteropFunction, AphidInteropMember>()
                        .None())
                .ToArray();
    }
}
