using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class HttpUpload
    {
        public string Name { get; set; }

        public string Filename { get; set; }

        public string FileMimeType { get; set; }

        public Stream Stream { get; set; }

        public HttpUpload()
        {
            FileMimeType = MimeType.ApplicationOctetStream;
        }

        public HttpUpload(string name, string filename, Stream stream)
            : this()
        {
            Name = name;
            Filename = filename;
            Stream = stream;
        }
    }
}
