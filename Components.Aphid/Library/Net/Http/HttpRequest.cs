using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class HttpRequest : HttpMessagePart
    {
        public string Path { get; set; }

        public string Method { get; set; }

        public string Version { get; set; }

        public FieldValuePair[] QueryString { get; set; }

        public FieldValuePair[] PostValues { get; set; }

        public HttpUpload[] Uploads { get; set; }

        public bool IsMultipart { get; set; }

        public string Boundary { get; set; }

        public string StartBoundary { get; set; }

        public string EndBoundary { get; set; }

        public HttpRequest()
        {
            Path = "/";
            Method = HttpMethod.Get;
            Version = HttpVersion.V11;
        }

        public void SetMultipart(string boundary = "boundary5230")
        {
            IsMultipart = true;
            Boundary = boundary;
            StartBoundary = "--" + Boundary + "\r\n";
            EndBoundary = "--" + Boundary + "--\r\n";
            ResetField(HttpField.ContentType, MimeType.Multipart + "; boundary=" + boundary);
        }

        public void SetContentLength()
        {
            ResetField(HttpField.ContentLength, 0);
        }        

        public string BuildRelativeUrl()
        {
            var url = (Path[0] == '/' ? "" : "/") + Path;

            if (QueryString != null && QueryString.Any())
            {
                url += "?" + FormUrlEncoder.Encode(QueryString);
            }

            return url;
        }

        public string BuildAbsoluteUrl(string host)
        {
            return "http://" + host + BuildRelativeUrl();
        }

        public string CreateHeader(string host)
        {
            return Method + " " + BuildRelativeUrl() + " HTTP/" + Version + "\r\n" +
                GetAttributeString() + "\r\n\r\n";
        }        
    }
}
