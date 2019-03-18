using System.Collections.Generic;

namespace Components.External.ConsolePlus
{
    public interface IScanner
    {
        IEnumerable<ScannerToken> Tokenize(string text);
    }
}
