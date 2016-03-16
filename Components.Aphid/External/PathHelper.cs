using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Components.External
{
    public static class PathHelper
    {
        public static string GetEntryDirectory()
        {
            return new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName;
        }

        public static string GetEntryPath(params string[] paths)
        {
            return Path.Combine(new[] { GetEntryDirectory() }.Concat(paths).ToArray());
        }

        public static string GetExecutingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
        }

        public static string GetExecutingPath(params string[] paths)
        {
            return Path.Combine(new[] { Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) }.Concat(paths).ToArray());
        }

        public static string GetSiblingFileName(string path, string filename)
        {
            return Path.Combine(Path.GetDirectoryName(path), filename);
        }
    }
}
