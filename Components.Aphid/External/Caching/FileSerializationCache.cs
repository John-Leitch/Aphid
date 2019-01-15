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

        public uint Flags { get; protected set; }

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
            var cacheName = CacheName.Normalize(filename);
            var info = LoadCacheInfoUnsafe(cacheName);
            T cache;

            if (info == null || info.IsOutdated)
            {
                cache = CreateCache(cacheName, out var sources);

                lock (_inMemoryCache)
                {
                    if (_inMemoryCache.ContainsKey(cacheName))
                    {
                        _inMemoryCache[cacheName] = cache;
                    }
                    else
                    {
                        _inMemoryCache.Add(cacheName, cache);
                    }
                }

                using (var s = new MemoryStream())
                {
                    SerializeCache(s, cache);

                    FileMemoryCache.WriteAllBytes(
                        GetCacheFilename(cacheName),
                        s.ToArray());
                }

                // Todo: fix race condition by caching begin datetime.
                SaveCacheInfoUnsafe(
                    cacheName,
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

                lock (_inMemoryCache)
                {
                    if (!_inMemoryCache.TryGetValue(cacheName, out cache))
                    {
                        using (var s = FileMemoryCache.OpenRead(GetCacheFilename(cacheName)))
                        {
                            cache = DeserializeCache(s);
                        }

                        _inMemoryCache.Add(cacheName, cache);
                    }
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

        private static CrossProcessLock CreateLock(string filename) =>
            new CrossProcessLock($"FileSerializationCache_{CacheName.Sanitize(filename)}");

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
                return filename + ".cache.metadata";
            }
            else
            {
                return filename + "." + Flags + ".cache.metadata";
            }
        }
    }
}