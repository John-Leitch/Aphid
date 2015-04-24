using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Net.Http
{
    public static class HttpField
    {
        public const string Host = "Host",
            ContentType = "Content-Type",
            ContentLength = "Content-Length",
            Cookie = "Cookie",
            UserAgent = "User-Agent",
            ContentDisposition = "Content-Disposition",
            Accept = "Accept",
            Connection = "Connection",
            TransferEncoding = "Transfer-Encoding";
    }
}
