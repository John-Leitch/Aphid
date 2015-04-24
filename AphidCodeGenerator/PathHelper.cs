using System.IO;
using System.Linq;
using System.Reflection;

namespace AphidCodeGenerator
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

        public static string SanitizePath(string name, char c)
        {
            Path.GetInvalidPathChars().Iter(x => name = name.Replace(x, c));

            return name.Replace(':', c).Replace('\\', c).Replace('/', c);
        }

        public static string SanitizeName(string name, char c)
        {
            Path.GetInvalidFileNameChars().Iter(x => name = name.Replace(x, c));

            return name;
        }

        public static string SanitizeName(string name)
        {
            return SanitizeName(name, '_');
        }

        public static string SanitizePath(string name)
        {
            return SanitizePath(name, '_');
        }

        public static string GetSiblingFileName(string path, string filename)
        {
            return Path.Combine(Path.GetDirectoryName(path), filename);
        }
    }
}
