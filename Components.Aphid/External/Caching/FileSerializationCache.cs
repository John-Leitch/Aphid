using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.Caching
{
    public abstract class FileSerializationCache<T>
    {
        private FileCacheInfoSerializer _serializer;

        private static Dictionary<string, T> _inMemoryCache = new Dictionary<string, T>();

        public uint Flags { get; private set; }

        public FileSerializationCache(Assembly dependency)
        {
            _serializer = new FileCacheInfoSerializer(dependency);
        }

        public FileSerializationCache(Version dependencyVersion)
        {
            _serializer = new FileCacheInfoSerializer(dependencyVersion);
        }

        public FileSerializationCache(Assembly dependency, uint flags)
            : this(dependency)
        {
            Flags = flags;
        }

        public FileSerializationCache(Version dependencyVersion, uint flags)
            : this(dependencyVersion)
        {
            Flags = flags;
        }

        public T Read(string filename)
        {
            using (CreateLock(filename))
            {
                return ReadUnsafe(filename);
            }
        }

        public T Read(string filename, out FileCacheSource[] cacheSources)
        {
            using (CreateLock(filename))
            {
                return ReadUnsafe(filename, out cacheSources);
            }
        }

        private T ReadUnsafe(string filename)
        {
            return ReadUnsafe(filename, out _);
        }

        private T ReadUnsafe(string filename, out FileCacheSource[] cacheSources)
        {
            var info = LoadCacheInfoUnsafe(filename);
            T cache;

            if (info == null || info.IsOutdated)
            {
                cache = CreateCache(filename, out var sources);

                if (_inMemoryCache.ContainsKey(filename))
                {
                    _inMemoryCache[filename] = cache;
                }
                else
                {
                    _inMemoryCache.Add(filename, cache);
                }

                using (var s = new MemoryStream())
                {
                    SerializeCache(s, cache);

                    FileMemoryCache.WriteAllBytes(
                        GetCacheFilename(filename),
                        s.ToArray());
                }

                // Todo: fix race condition by caching begin datetime.
                SaveCacheInfoUnsafe(
                    filename,
                    new FileCacheInfo(
                        cacheSources = sources
                            .Select(x => new FileCacheSource(
                                Path.GetFullPath(x),
                                new FileInfo(x).LastWriteTimeUtc))
                            .ToArray()));
            }
            else
            {
                var fileCacheInfo = info as FileCacheInfo;

                cacheSources = fileCacheInfo != null ?
                    fileCacheInfo.Sources :
                    new FileCacheSource[0];

                if (!_inMemoryCache.TryGetValue(filename, out cache))
                {
                    using (var s = FileMemoryCache.OpenRead(GetCacheFilename(filename)))
                    {
                        cache = DeserializeCache(s);
                    }

                    _inMemoryCache.Add(filename, cache);
                }
            }

            return cache;
        }

        private ICacheInfo LoadCacheInfoUnsafe(string filename)
        {
            var cacheInfoFile = GetCacheInfoFilename(filename);

            if (!File.Exists(cacheInfoFile))
            {
                return null;
            }
            else
            {
                using (var s = FileMemoryCache.OpenRead(cacheInfoFile))
                {
                    return _serializer.Deserialize(s);
                }
            }
        }

        private CrossProcessLock CreateLock(string filename)
        {
            return new CrossProcessLock(
                string.Format(
                    "FileSerializationCache_{0}",
                    Path
                        .GetFullPath(filename)
                        .Replace("$", "$$")
                        .Replace(':', '$')
                        .Replace('\\', '$')));
        }

        private void SaveCacheInfoUnsafe(string filename, FileCacheInfo cacheInfo)
        {
            using (var s = new MemoryStream())
            {
                _serializer.Serialize(s, cacheInfo);

                FileMemoryCache.WriteAllBytes(
                    GetCacheInfoFilename(filename),
                    s.ToArray());
            }
        }

        protected abstract T CreateCache(string filename, out string[] sources);

        protected abstract void SerializeCache(Stream stream, T cache);

        protected abstract T DeserializeCache(Stream stream);

        protected virtual string GetCacheFilename(string filename)
        {
            if (Flags == 0x0)
            {
                return filename + ".cache";
            }
            else
            {
                return filename + "." + Flags + ".cache";
            }
        }

        protected virtual string GetCacheInfoFilename(string filename)
        {
            if (Flags == 0x0)
            {
                return filename + ".cacheMetadata";
            }
            else
            {
                return filename + "." + Flags + ".cacheMetadata";
            }
        }
    }
}