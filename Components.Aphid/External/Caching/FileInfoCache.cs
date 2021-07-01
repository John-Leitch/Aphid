using System;
using System.IO;

namespace Components.Aphid
{
    public class FileInfoCache
    {
        private readonly ArgLockingMemoizer<string, FileInfo> _fileInfoCache =
            new(StringComparer.OrdinalIgnoreCase);

        public FileInfo GetFileInfo(string path) => _fileInfoCache.Call(GetFileInfoCore, path);

        private static FileInfo GetFileInfoCore(string filename) => new(filename);
    }
}
