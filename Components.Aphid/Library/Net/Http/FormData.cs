using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class FormData : HttpMessagePart
    {
        public string Header { get; private set; }

        public string StringValue { get; set; }

        public HttpUpload UploadValue { get; set; }

        public FormData(string value)
        {
            StringValue = value;
        }

        public FormData(HttpUpload value)
        {
            UploadValue = value;
        }

        public void SetHeader()
        {
            Header = GetAttributeString() + "\r\n\r\n";
        }
    }
}
