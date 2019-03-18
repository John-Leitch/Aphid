using System;
using System.Collections.Generic;
using System.Linq;
using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using AphidPair = System.Collections.Generic.KeyValuePair<string, Components.Aphid.TypeSystem.AphidObject>;

namespace Components.Aphid.UI.Formatters
{
    public static class LocalFormatter
    {
        public static IEnumerable<Lazy<string>> Format(
            AphidInterpreter interpreter,
            AphidPair[] locals,
            List<AphidObject> scopes,
            int index = 0) =>
            locals
                .Select(x => new Lazy<string>(() =>
                    LineNumberFormatter.PrefixIndex(index++,
                        SyntaxHighlightingFormatter.Format(
                            string.Format(
                                "{0} {1} = {2}",
                                AphidCli.GetAphidObjectTypeName(x.Value),
                                x.Key,
                                SerializingFormatter.Format(
                                    interpreter,
                                    x.Value,
                                    ignoreNull: false,
                                    ignoreClrObj: false,
                                    scopes: scopes)
                                    .Indent(new string(' ', 5))
                                    .TrimStart())))));
    }
}
