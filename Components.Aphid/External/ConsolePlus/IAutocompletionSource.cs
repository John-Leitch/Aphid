using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public interface IAutocompletionSource
    {
        IEnumerable<Autocomplete> GetWords(string text, int offset, bool allowEmptySearch, out string searchBuffer);
    }
}
