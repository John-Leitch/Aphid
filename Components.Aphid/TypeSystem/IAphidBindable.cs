using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public interface IAphidBindable
    {
        void OnBinding(AphidObject source);
        void OnBound(AphidObject source);
    }
}
