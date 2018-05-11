using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Caching
{
    public class FileCacheInfoSerializer
    {
        public void Serialize(Stream s, FileCacheInfo cacheInfo)
        {
            var writer = new BinaryWriter(s);
            writer.Write(cacheInfo.Sources.Length);

            for (var i = 0; i < cacheInfo.Sources.Length; i++ )
            {
                var d = cacheInfo.Sources[i];
                writer.Write(d.Name);
                writer.Write(d.CacheTime.Ticks);
            }
        }

        public FileCacheInfo Deserialize(Stream s)
        {
            var reader = new BinaryReader(s);
            var sources = new FileCacheSource[reader.ReadInt32()];

            for (var i = 0; i < sources.Length; i++)
            {
                sources[i] = new FileCacheSource(
                    reader.ReadString(),
                    new DateTime(reader.ReadInt64()));
            }

            return new FileCacheInfo(sources);
        }
    }
}
