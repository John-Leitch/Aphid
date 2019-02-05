using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public class FileInfoCache
    {
        private ArgLockingMemoizer<string, FileInfo> _fileInfoCache =
            new ArgLockingMemoizer<string, FileInfo>(StringComparer.OrdinalIgnoreCase);

        public FileInfo GetFileInfo(string path) => _fileInfoCache.Call(GetFileInfoCore, path);

        private static FileInfo GetFileInfoCore(string filename) => new FileInfo(filename);
    }
}
