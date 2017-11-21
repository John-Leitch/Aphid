using Components.Aphid.Interpreter;
using Components.Aphid.Library.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net
{
    public class HttpLibrary
    {
        [AphidInteropFunction("__http.request", UnwrapParameters = false)]
        public static string HttpRequest(AphidObject request)
        {
            var req = request.ConvertTo<AphidRequest>();

            try
            {
                var req2 = req.ToHttpRequest();
                using (var client = HttpClient.Connect(req.Host, req.Port))
                {
                    client.Write(req2);
                    var resp = client.Read().GetBodyString();
                    return resp;
                }
            }
            finally
            {
                if (req.Files != null)
                {
                    foreach (var f in req.Files)
                    {
                        if (f.Stream != null)
                        {
                            f.Stream.Dispose();
                        }
                    }
                }
            }
        }
    }
}
