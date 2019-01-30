using System.Collections.Generic;
using System.IO;

namespace Components.Caching
{
    public static class FileMemoryCache
    {
        private static Dictionary<string, CacheBlob<byte[]>> _cache =
            new Dictionary<string, CacheBlob<byte[]>>();

        public static Stream OpenRead(string filename) =>
            new MemoryStream(ReadAllBytes(filename));

        public static byte[] ReadAllBytes(string filename)
        {
            var cacheName = CacheName.Normalize(filename);

            using (CreateLock(cacheName))
            {
                var time = new FileInfo(cacheName).LastWriteTimeUtc;

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

        private static void SetHiddenFlag(string filename)
        {
            File.SetAttributes(
                filename,
                File.GetAttributes(filename) | FileAttributes.Hidden);
        }
    }
}
