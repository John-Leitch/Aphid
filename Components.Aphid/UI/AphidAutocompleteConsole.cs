using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using Components.External.ConsolePlus;
using System;

namespace Components.Aphid.UI
{
    public class AphidAutocompleteConsole : AutocompleteConsole, IDisposable
    {
        public AphidAutocompleteConsole(AphidInterpreter interpreter, bool useNativeApi)
            :this (interpreter.CurrentScope, useNativeApi)
        {
        }

        public AphidAutocompleteConsole(AphidObject scope, bool useNativeApi)
            : base(
                ">>>",
                new AphidScanner(),
                new AphidSyntaxHighlighter(),
                new AphidScopeObjectAutocompletionSource(scope),
                useNativeApi)
        {
        }

        public void Dispose() =>
            ((AphidScopeObjectAutocompletionSource)Source).Dispose();
    }
}
