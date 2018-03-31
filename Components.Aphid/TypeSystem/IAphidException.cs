using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public interface IAphidException
    {
        AphidExceptionType Type { get; }
    }
}
