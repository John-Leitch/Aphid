using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Components
{
    public static class XmlObject
    {
        private static XmlSerializer GetSerializer<T>()
        {
            return new XmlSerializer(typeof(T));
        }

        public static void Serialize<T>(T o, Stream stream)
        {
            GetSerializer<T>().Serialize(stream, o);
        }

        public static string SerializeToString<T>(T o)
        {
            return GetSerializer<T>().Serialize(o);
        }

        public static T Deserialize<T>(Stream stream)
        {
            return (T)GetSerializer<T>().Deserialize(stream);
        }
    }
}
