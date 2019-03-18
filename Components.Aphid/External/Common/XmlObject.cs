using System.IO;
using System.Xml.Serialization;

namespace Components
{
    public static class XmlObject
    {
        private static XmlSerializer GetSerializer<T>() => new XmlSerializer(typeof(T));

        public static void Serialize<T>(T o, Stream stream) => GetSerializer<T>().Serialize(stream, o);

        public static string SerializeToString<T>(T o) => GetSerializer<T>().Serialize(o);

        public static T Deserialize<T>(Stream stream) => (T)GetSerializer<T>().Deserialize(stream);
    }
}
