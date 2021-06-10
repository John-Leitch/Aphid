using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.External
{
    public static class PathHelper
    {
        public static string GetLocation() =>
            (Assembly.GetEntryAssembly() ??
            Assembly.GetExecutingAssembly() ??
            throw new ArgumentNullException(
                "fileName",
                "Could not resolve fileName using Assembly.GetEntryAssembly or Assembly.GetExecutingAssembly."))
                .Location;

        public static string GetEntryDirectory() => new FileInfo(GetLocation()).DirectoryName;

        public static string GetEntryPath(params string[] paths) =>
            Path.Combine(new[] { GetEntryDirectory() }.Concat(paths).ToArray());

        public static string GetExecutingDirectory() =>
            Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);

        public static string GetExecutingPath(params string[] paths) =>
            Path.Combine(new[] { Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) }.Concat(paths).ToArray());

        public static string GetSiblingFileName(string path, string filename) =>
            Path.Combine(Path.GetDirectoryName(path), filename);
    }
}
