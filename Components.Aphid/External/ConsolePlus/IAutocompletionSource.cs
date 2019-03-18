using System.Collections.Generic;

namespace Components.External.ConsolePlus
{
    public interface IAutocompletionSource
    {
        IEnumerable<Autocomplete> GetWords(string text, int offset, bool allowEmptySearch, out string searchBuffer);
    }
}
