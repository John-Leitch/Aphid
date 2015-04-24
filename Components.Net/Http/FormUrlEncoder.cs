using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Net.Http
{
    public static class FormUrlEncoder
    {
        public static string Encode(IEnumerable<FieldValuePair> pairs)
        {
            return pairs
                .Select(x =>
                    Uri.EscapeDataString(x.Field) +
                    "=" +
                    Uri.EscapeDataString(x.Value))
                .Aggregate((x, y) => x + "&" + y);
        }
    }
}
