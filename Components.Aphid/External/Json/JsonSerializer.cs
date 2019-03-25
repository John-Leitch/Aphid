#if NO_JSON
#else
using System;
using System.IO;
using System.Reflection;
#if EAGER_JSON
using System.Web.Script.Serialization;
#endif

namespace Components.Json
{
    public static class JsonSerializer
    {
#if !EAGER_JSON
#pragma warning disable CS0618 // Type or member is obsolete
        private static readonly Lazy<dynamic> _lazySerializer = new Lazy<dynamic>(() =>
            Activator.CreateInstance(
                Assembly
                    .LoadWithPartialName("System.Web.Extensions")
                    .GetType("System.Web.Script.Serialization.JavaScriptSerializer")));

        private static dynamic _serializer => _lazySerializer.Value;
#pragma warning restore CS0618 // Type or member is obsolete)
#else
        private static readonly JavaScriptSerializer _serializer = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };
#endif

        public static T Deserialize<T>(string json) => _serializer.Deserialize<T>(json);

        public static T DeserializeFile<T>(string filename) => Deserialize<T>(File.ReadAllText(filename));

        public static object DeserializeObject(string json) => _serializer.DeserializeObject(json);

        public static object DeserializeObjectFile(string filename) => DeserializeObject(File.ReadAllText(filename));

        public static string Serialize(object o) => new JsonFormatter().Format(_serializer.Serialize(o));

        public static void SerializeToFile(string filename, object o) => File.WriteAllText(filename, Serialize(o));
    }
}
#endif