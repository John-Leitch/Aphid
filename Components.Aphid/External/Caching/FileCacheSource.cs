using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public class FileCacheSource
    {
        public string Name { get; private set; }

        public DateTime CacheTime { get; private set; }

        public FileInfo File { get; private set; }

        public FileCacheSource(string name, DateTime cacheTime)
        {
            File = new FileInfo(Name = name);
            CacheTime = cacheTime;
        }

        public FileCacheSource(FileInfo file)
        {
            Name = file.FullName;
            File = file;
            CacheTime = file.LastWriteTimeUtc;
        }

        public FileCacheSource(string name, FileInfo file)
        {
            Name = name;
            File = file;
            CacheTime = file.LastWriteTimeUtc;
        }

        public FileCacheSource(string name, FileInfo file, DateTime cacheTime)
        {
            Name = name;
            File = file;
            CacheTime = cacheTime;
        }
    }
}
