using System;
using System.Collections.Generic;
using System.IO;

namespace Components.Aphid
{
    public static class FileMemoryCache
    {
        private static readonly Dictionary<string, CacheBlob<byte[]>> _cache =
            new Dictionary<string, CacheBlob<byte[]>>();

        public static Stream OpenRead(string filename) =>
            new MemoryStream(ReadAllBytes(filename, null));

        public static Stream OpenRead(string filename, FileInfoCache fileInfoCache) =>
            new MemoryStream(ReadAllBytes(filename, fileInfoCache));

        public static byte[] ReadAllBytes(string filename) => ReadAllBytes(filename, null);

        public static byte[] ReadAllBytes(string filename, FileInfoCache fileInfoCache)
        {
            var cacheName = CacheName.Normalize(filename);

            using (CreateLock(cacheName))
            {
                DateTime time;

                if (fileInfoCache != null)
                {
                    time = fileInfoCache.GetFileInfo(cacheName).LastWriteTimeUtc;
                }
                else
                {
                    time = new FileInfo(cacheName).LastWriteTimeUtc;
                }

                lock (_cache)
                {
                    if (!_cache.TryGetValue(cacheName, out var bytes))
                    {
                        var b = File.ReadAllBytes(cacheName);
                        _cache.Add(cacheName, new CacheBlob<byte[]>(time, b));

                        return b;
                    }
                    else if (bytes.CacheTime != time)
                    {
                        bytes.CacheTime = time;
                        return bytes.Value = File.ReadAllBytes(cacheName);
                    }
                    else
                    {
                        return bytes.Value;
                    }
                }
            }
        }

        public static void WriteAllBytes(string filename, byte[] buffer)
        {
            var key = Path.GetFullPath(filename);

            using (CreateLock(key))
            {
                var exists = File.Exists(key);

                if (exists)
                {
                    using (var s = File.Open(key, FileMode.Open, FileAccess.Write))
                    {
                        s.Write(buffer);

                        //if (s.Length > buffer.Length)
                        //{
                        //    s.SetLength(buffer.Length);
                        //}
                    }
                }
                else
                {
                    File.WriteAllBytes(key, buffer);
                    SetHiddenFlag(key);
                }

                var date = new FileInfo(key).LastWriteTimeUtc;

                if (!_cache.TryGetValue(key, out var bytes))
                {
                    _cache.Add(key, new CacheBlob<byte[]>(date, buffer));
                }
                else
                {
                    _cache[key] = new CacheBlob<byte[]>(date, buffer);
                }
            }
        }

        private static CrossProcessLock CreateLock(string filename) =>
            new CrossProcessLock($"FileCache_{CacheName.Sanitize(filename)}");

        private static void SetHiddenFlag(string filename) => File.SetAttributes(
                filename,
                File.GetAttributes(filename) | FileAttributes.Hidden);
    }
}
