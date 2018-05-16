﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Components.Caching
{
    public abstract class FileSerializationCache<T>
    {
        private FileCacheInfoSerializer _serializer = new FileCacheInfoSerializer();

        private static Dictionary<string, T> _inMemoryCache = new Dictionary<string, T>();

        public T Read(string filename)
        {
            using (CreateLock(filename))
            {
                return ReadUnsafe(filename);
            }
        }

        private T ReadUnsafe(string filename)
        {
            
            var info = LoadCacheInfoUnsafe(filename);
            T cache;

            if (info == null || info.IsOutdated)
            {
                string[] sources;
                cache = CreateCache(filename, out sources);

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
                        sources
                            .Select(x => new FileCacheSource(
                                Path.GetFullPath(x),
                                new FileInfo(x).LastWriteTimeUtc))
                            .ToArray()));
            }
            else
            {

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

        private FileCacheInfo LoadCacheInfoUnsafe(string filename)
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
            return filename + ".cache";
        }

        protected virtual string GetCacheInfoFilename(string filename)
        {
            return filename + ".cacheMetadata";
        }
    }
}