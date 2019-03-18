using System;
using System.IO;
using System.Reflection;

namespace Components.Aphid
{
    public class FileCacheInfoSerializer
    {
        private const uint
            _formatVersion = 0x01,
            _headerMask = 0x68952300,
            _header = _headerMask | _formatVersion;

        private readonly Version _dependencyVersion;

        private readonly FileInfoCache _fileInfoCache;

        public FileCacheInfoSerializer(
            Version dependencyVersion,
            FileInfoCache fileInfoCache)
        {
            _dependencyVersion = dependencyVersion;
            _fileInfoCache = fileInfoCache;
        }

        public FileCacheInfoSerializer(
            Assembly dependency,
            FileInfoCache fileInfoCache)
            : this(dependency.GetName().Version, fileInfoCache)
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
                var name = reader.ReadString();
                sources[i] = new FileCacheSource(
                    name,
                    _fileInfoCache.GetFileInfo(name),
                    new DateTime(reader.ReadInt64()));
            }

            return new FileCacheInfo(sources);
        }
    }
}
