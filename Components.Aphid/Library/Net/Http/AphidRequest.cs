using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public HttpRequest ToHttpRequest()
        {
            return new HttpRequest()
            {
                Path = Path,
                Method = Method,
                QueryString = QueryString,
                PostValues = PostValues,
                Uploads = Files,
            };
        }

        private FieldValuePair[] GetPairs(AphidObject source, string property)
        {
            if (source.ContainsKey(property))
            {
                return source[property]
                    .Select(x => new FieldValuePair(x.Key, x.Value.Value.ToString()))
                    .ToArray();
            }
            else
            {
                return null;
            }
        }

        private HttpUpload CreateUpload(KeyValuePair<string, AphidObject> obj)
        {
            var file = obj.Value.ConvertTo<AphidUpload>();
            file.Name = obj.Key;
            return file.ToHttpUpload();
        }

        private HttpUpload[] GetFiles(AphidObject source)
        {
            if (source.ContainsKey("files"))
            {
                return source["files"]
                    .Select(CreateUpload)
                    .ToArray();
            }
            else
            {
                return null;
            }
        }

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
