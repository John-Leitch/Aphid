using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public static class AphidObjectConverter
    {
        public static string[] ToStringArray(AphidObject obj)
        {
            return (obj.Value as List<AphidObject>).Select(x => (string)x.Value).ToArray();
        }
    }
}
