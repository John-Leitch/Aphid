using Components.Aphid.TypeSystem;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Library.Net.Http
{
    public class AphidRequest : IAphidBindable
    {
        [AphidProperty("host")]
        public string Host { get; set; }

        [AphidProperty("port")]
        public int Port { get; set; }

        [AphidProperty("path")]
        public string Path { get; set; }

        [AphidProperty("method")]
        public string Method { get; set; }

        [AphidProperty("version")]
        public string Version { get; set; }

        public FieldValuePair[] QueryString { get; set; }

        public FieldValuePair[] PostValues { get; set; }

        public HttpUpload[] Files { get; set; }

        public AphidRequest()
        {
            Method = "GET";
            Path = "/";
            Version = "1.1";
            Port = 80;
            Host = "localhost";
        }

        public HttpRequest ToHttpRequest() => new HttpRequest
        {
            Path = Path,
            Method = Method,
            QueryString = QueryString,
            PostValues = PostValues,
            Uploads = Files
        };

        private static FieldValuePair[] GetPairs(AphidObject source, string property) => source.ContainsKey(property)
                ? source[property]
                    .Select(x => new FieldValuePair(x.Key, x.Value.Value.ToString()))
                    .ToArray()
                : null;

        private HttpUpload CreateUpload(KeyValuePair<string, AphidObject> obj)
        {
            var file = obj.Value.ConvertTo<AphidUpload>();
            file.Name = obj.Key;
            return file.ToHttpUpload();
        }

        private HttpUpload[] GetFiles(AphidObject source) => source.ContainsKey("files")
                ? source["files"]
                    .Select(CreateUpload)
                    .ToArray()
                : null;

        public void OnBinding(AphidObject source)
        {
        }

        public void OnBound(AphidObject source)
        {
            QueryString = GetPairs(source, "query");
            PostValues = GetPairs(source, "post");
            Files = GetFiles(source);
        }
    }
}
