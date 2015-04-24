using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Net.Http
{
    public static class HttpMethod
    {
        public const string Get = "GET",
            Head = "HEAD",
            Post = "POST",
            PUT = "PUT",
            Delete = "DELETE",
            Trace = "TRACE",
            Options = "OPTIONS",
            Connect = "CONNECT",
            Patch = "PATCH";
    }
}
