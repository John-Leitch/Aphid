using Components.External;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Components.Aphid.Compiler
{
    public class BuildNumberRepository
    {
        public static int NextBuildNumber(string filename)
        {
            var table = ReadBuildNumberTable();
            BuildNumber build;

            if (table.TryGetValue(filename, out build))
            {
                build.Number++;
            }
            else
            {
                table.Add(filename, build = new BuildNumber(filename, 1));
            }

            WriteBuildNumberTable(table);

            return build.Number;
        }

        private static XmlSerializer GetSerializer()
        {
            return new XmlSerializer(typeof(BuildNumber[]));
        }

        private static Dictionary<string, BuildNumber> ReadBuildNumberTable()
        {
            var serializer = GetSerializer();
            var repoFile = GetBuildRepositoryName();

            if (File.Exists(repoFile))
            {
                using (var s = File.OpenRead(repoFile))
                {
                    return ((BuildNumber[])serializer.Deserialize(s))
                        .ToDictionary(x => x.Name);
                }
            }
            else
            {
                return new Dictionary<string, BuildNumber>();
            }
        }

        private static void WriteBuildNumberTable(Dictionary<string, BuildNumber> table)
        {
            var serializer = GetSerializer();

            using (var s = File.OpenWrite(GetBuildRepositoryName()))
            {
                serializer.Serialize(s, table.Select(x => x.Value).ToArray());
            }
        }

        private static string GetBuildRepositoryName()
        {
            var asmName = Assembly.GetEntryAssembly().GetName().Name;

            return PathHelper.GetEntryPath(asmName + ".builds.xml");
        }
    }
}
