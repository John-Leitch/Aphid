using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class ChunkedTransferEncoding
    {
        public static void Decode(Stream source, Stream destination)
        {
            source.Position = 0;

            var lenSb = new StringBuilder();

            while (true)
            {
                var c = (char)source.ReadByte();

                if (c == '\r')
                {
                    source.ReadByte();
                    var chunkSize = Convert.ToInt32(lenSb.ToString(), 16);

                    if (chunkSize == 0)
                    {
                        break;
                    }

                    lenSb.Clear();

                    var buffer = new byte[chunkSize];
                    source.Read(buffer, 0, chunkSize);
                    destination.Write(buffer, 0, chunkSize);
                    source.ReadByte();
                    source.ReadByte();
                }
                else
                {
                    lenSb.Append(c);
                }
            }

            destination.Flush();
            destination.Position = 0;
        }
    }
}
