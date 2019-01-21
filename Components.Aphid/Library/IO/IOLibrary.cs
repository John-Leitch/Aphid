using Components.Aphid.Interpreter;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Library
{
    [AphidLibraryAttribute("io")]
    public class IOLibrary
    {
        [AphidInteropFunction("io.file.read")]
        private static List<AphidObject> ReadBytes(string filename)
        {
            var list = new List<AphidObject>();

            foreach (var b in File.ReadAllBytes(filename))
            {
                list.Add(AphidObject.Scalar((decimal)b));
            }

            return list;
        }

        [AphidInteropFunction("io.file.write")]
        private static void WriteBytes(string filename, List<AphidObject> bytes)
        {
            var buffer = new byte[bytes.Count];

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = Convert.ToByte(bytes[i].Value);
            }

            File.WriteAllBytes(filename, buffer);
        }

        [AphidInteropFunction("io.file.readText")]
        private static string ReadText(string filename) => File.ReadAllText(filename);

        [AphidInteropFunction("io.file.writeText")]
        private static void WriteText(string filename, string text) => File.WriteAllText(filename, text);

        [AphidInteropFunction("io.dir.exists")]
        public static bool DirExists(string dir) => Directory.Exists(dir);

        [AphidInteropFunction("io.file.exists")]
        public static bool FileExists(string file) => File.Exists(file);

        [AphidInteropFunction("io.dir.create")]
        public static string DirCreate(string dir) => Directory.CreateDirectory(dir).FullName;

        private static List<AphidObject> GetFileSystemObjects(
            Func<string, string, SearchOption, string[]> func,
            string dir,
            string pattern,
            bool recurse)
        {
            var searchOption = recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            return func(dir, pattern, searchOption).Select(x => AphidObject.Scalar(x)).ToList();
        }

        [AphidInteropFunction("io.dir.getFilesInternal")]
        public static List<AphidObject> DirGetFiles(string dir, string pattern, bool recurse) => GetFileSystemObjects(Directory.GetFiles, dir, pattern, recurse);

        [AphidInteropFunction("io.dir.getDirsInternal")]
        public static List<AphidObject> DirGetDirs(string dir, string pattern, bool recurse) => GetFileSystemObjects(Directory.GetFiles, dir, pattern, recurse);
    }
}

