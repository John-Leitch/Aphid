using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public interface IScanner
    {
        IEnumerable<ScannerToken> Tokenize(string text);
    }
}
