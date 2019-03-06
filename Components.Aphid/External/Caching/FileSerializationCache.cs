using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Components.Aphid
{
    public abstract class FileSerializationCache<T>
    {
        private readonly FileCacheInfoSerializer _serializer;

        private static readonly Dictionary<string, T> _inMemoryCache = new Dictionary<string, T>();

        private static readonly ReaderWriterLockSlim _inMemoryCacheLock = new ReaderWriterLockSlim();

        private readonly FileInfoCache _fileInfoCache = new FileInfoCache();

        public uint Flags { get; protected set; }

        protected FileSerializationCache(Assembly dependency) =>
            _serializer = new FileCacheInfoSerializer(dependency, _fileInfoCache);

        protected FileSerializationCache(Version dependencyVersion) =>
            _serializer = new FileCacheInfoSerializer(dependencyVersion, _fileInfoCache);

        protected FileSerializationCache(Assembly dependency, uint flags)
            : this(dependency) => Flags = flags;

        protected FileSerializationCache(Version dependencyVersion, uint flags)
            : this(dependencyVersion) => Flags = flags;

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

        private T ReadUnsafe(string filename) => ReadUnsafe(filename, out _);

        private T ReadUnsafe(string filename, out FileCacheSource[] cacheSources)
        {
            var cacheName = CacheName.Normalize(filename);
            var info = LoadCacheInfoUnsafe(cacheName);
            T cache;

            if (info?.IsOutdated != false)
            {
                cache = CreateCache(cacheName, out var sources);

                _inMemoryCacheLock.EnterWriteLock();

                try
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
                finally
                {
                    _inMemoryCacheLock.ExitWriteLock();
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
                                _fileInfoCache.GetFileInfo(
                                    Path.GetFullPath(x))))
                            .ToArray()));
            }
            else
            {
                var fileCacheInfo = info as FileCacheInfo;

                cacheSources = fileCacheInfo != null ?
                    fileCacheInfo.Sources :
                    new FileCacheSource[0];

                _inMemoryCacheLock.EnterUpgradeableReadLock();

                try
                {
                    if (!_inMemoryCache.TryGetValue(cacheName, out cache))
                    {
                        using (var s = FileMemoryCache.OpenRead(
                            GetCacheFilename(cacheName),
                            _fileInfoCache))
                        {
                            cache = DeserializeCache(s);
                        }

                        _inMemoryCacheLock.EnterWriteLock();

                        try
                        {
                            _inMemoryCache.Add(cacheName, cache);
                        }
                        finally
                        {
                            _inMemoryCacheLock.ExitWriteLock();
                        }
                    }
                }
                finally
                {
                    _inMemoryCacheLock.ExitUpgradeableReadLock();
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

            using (var s = FileMemoryCache.OpenRead(cacheInfoFile, _fileInfoCache))
            {
                return _serializer.Deserialize(s);
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

            return filename + "." + Flags.ToString() + ".cache";
        }

        protected virtual string GetCacheInfoFilename(string filename)
        {
            if (Flags == 0x0)
            {
                return filename + ".cache.metadata";
            }

            return filename + "." + Flags.ToString() + ".cache.metadata";
        }
    }
}