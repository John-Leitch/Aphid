using Components.Aphid.Interpreter;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidAutocompleteConsole : AutocompleteConsole, IDisposable
    {
        public AphidAutocompleteConsole(AphidInterpreter interpreter)
            : base(
                ">>>",
                new AphidScanner(),
                new AphidSyntaxHighlighter(),
                new AphidScopeObjectAutocompletionSource(interpreter.CurrentScope))
        {
        }

        public void Dispose() =>
            ((AphidScopeObjectAutocompletionSource)Source).Dispose();
    }
}
