using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public class FileCacheInfoSerializer
    {
        private const uint
            _formatVersion = 0x01,
            _headerMask = 0x68952300,
            _header = _headerMask | _formatVersion;

        private Version _dependencyVersion;

        public FileCacheInfoSerializer(Version dependencyVersion) =>
            _dependencyVersion = dependencyVersion;

        public FileCacheInfoSerializer(Assembly dependency)
            : this(dependency.GetName().Version)
        {
        }

        public void Serialize(Stream s, FileCacheInfo cacheInfo)
        {
            var writer = new BinaryWriter(s);
            writer.Write(_header);
            writer.Write(_dependencyVersion.Major);
            writer.Write(_dependencyVersion.Minor);
            writer.Write(_dependencyVersion.Build);
            writer.Write(_dependencyVersion.Revision);
            writer.Write(cacheInfo.Sources.Length);

            for (var i = 0; i < cacheInfo.Sources.Length; i++ )
            {
                var d = cacheInfo.Sources[i];
                writer.Write(d.Name);
                writer.Write(d.CacheTime.Ticks);
            }
        }

        public ICacheInfo Deserialize(Stream s)
        {
            var reader = new BinaryReader(s);

            if (s.Length < sizeof(uint) + (sizeof(int) * 4) ||
                reader.ReadUInt32() != _header ||
                new Version(
                    reader.ReadInt32(),
                    reader.ReadInt32(),
                    reader.ReadInt32(),
                    reader.ReadInt32()) !=
                    _dependencyVersion)
            {
                return PrimitiveCacheInfo.Outdated;
            }

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
