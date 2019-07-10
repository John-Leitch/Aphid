using Components.Aphid.Interpreter;
using Components.External.ConsolePlus;
using System;

namespace Components.Aphid.UI
{
    public class AphidAutocompleteConsole : AutocompleteConsole, IDisposable
    {
        public AphidAutocompleteConsole(AphidInterpreter interpreter, bool useNativeApi)
            : base(
                ">>>",
                new AphidScanner(),
                new AphidSyntaxHighlighter(),
                new AphidScopeObjectAutocompletionSource(interpreter.CurrentScope),
                useNativeApi)
        {
        }

        public void Dispose() =>
            ((AphidScopeObjectAutocompletionSource)Source).Dispose();
    }
}
