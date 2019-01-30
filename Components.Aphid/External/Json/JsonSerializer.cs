#if NO_JSON
#else
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Components.Json
{
    public static class JsonSerializer
    {
        private static JavaScriptSerializer _serializer = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };

        private static JsonFormatter _formatter = new JsonFormatter { ConvertToHex = false };

        public static T Deserialize<T>(string json)
        {
            //return _serializer.Deserialize<T>(_formatter.MakeCompliant(json));
            return _serializer.Deserialize<T>(json);
        }

        public static T DeserializeFile<T>(string filename) => Deserialize<T>(File.ReadAllText(filename));

        public static object DeserializeObject(string json)
        {
            //return _serializer.DeserializeObject(_formatter.MakeCompliant(json));
            return _serializer.DeserializeObject(json);
        }

        public static object DeserializeObjectFile(string filename) => DeserializeObject(File.ReadAllText(filename));

        public static string Serialize(object o)
        {
            lock (_formatter)
            {
                return _formatter.Format(_serializer.Serialize(o));
            }
            //return _serializer.Serialize(o);
        }

        public static void SerializeToFile(string filename, object o) => File.WriteAllText(filename, Serialize(o));
    }
}
#endif