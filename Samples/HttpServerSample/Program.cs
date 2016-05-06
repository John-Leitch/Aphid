using Components.Aphid.Library;
using Components.External;
using System.Threading;

namespace HttpServerSample
{
    class Program
    {
        private const string _prefix = "http://localhost:8888/";

        static void Main(string[] args)
        {
            var webRoot = PathHelper.GetExecutingPath("WebRoot");
            var server = new HttpServer(_prefix, webRoot);
            server.Start();
            Thread.Sleep(-1);
        }
    }
}
