using System;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Library.Net.Http
{
    public static class FormUrlEncoder
    {
        public static string Encode(IEnumerable<FieldValuePair> pairs) => pairs
                .Select(x =>
                    Uri.EscapeDataString(x.Field) +
                    "=" +
                    Uri.EscapeDataString(x.Value))
                .Aggregate((x, y) => x + "&" + y);
    }
}
