using System.Collections.Generic;
using System.IO;

namespace Components.Caching
{
    public static class FileMemoryCache
    {
        private static Dictionary<string, CacheBlob<byte[]>> _cache =
            new Dictionary<string, CacheBlob<byte[]>>();

        public static byte[] ReadAllBytes(string filename)
        {
            var key = Path.GetFullPath(filename);

            using (CreateLock(key))
            {
                var time = new FileInfo(key).LastWriteTimeUtc;

                if (!_cache.TryGetValue(key, out CacheBlob<byte[]> bytes))
                {
                    var b = File.ReadAllBytes(key);
                    _cache.Add(key, new CacheBlob<byte[]>(time, b));

                    return b;
                }
                else if (bytes.CacheTime != time)
                {
                    bytes.CacheTime = time;
                    return bytes.Value = File.ReadAllBytes(key);
                }
                else
                {
                    return bytes.Value;
                }
            }
        }

        public static Stream OpenRead(string filename)
        {
            return new MemoryStream(ReadAllBytes(filename));
        }

        public static void WriteAllBytes(string filename, byte[] buffer)
        {
            var key = Path.GetFullPath(filename);

            using (CreateLock(key))
            {
                var exists = File.Exists(key);

                if (exists)
                {
                    using (var s = File.Open(key, FileMode.OpenOrCreate))
                    {
                        if (s.Length > buffer.Length)
                        {
                            s.SetLength(buffer.Length);
                        }

                        s.Write(buffer);
                    }
                }
                else if (exists)
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

        private static CrossProcessLock CreateLock(string filename)
        {
            return new CrossProcessLock(
                string.Format(
                    "FileCache_{0}",
                    Path
                        .GetFullPath(filename)
                        .Replace("$", "$$")
                        .Replace(':', '$')
                        .Replace('\\', '$')
                        .Replace('/', '$')
                        .ToLower()));
        }

        private static void SetHiddenFlag(string filename)
        {
            File.SetAttributes(
                filename,
                File.GetAttributes(filename) | FileAttributes.Hidden);
        }
    }
}
