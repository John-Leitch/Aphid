using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Components
{
    public static class XmlSerializerExtensions
    {
        public static void Serialize(this XmlSerializer Serializer, string Filename, object o)
        {
            using (var s = File.Create(Filename))
                Serializer.Serialize(s, o);
        }

        public static string Serialize(this XmlSerializer Serializer, object o)
        {
            using (var s = new MemoryStream())
            {
                Serializer.Serialize(s, o);

                s.Position = 0;

                using (var reader = new StreamReader(s))
                    return reader.ReadToEnd();
            }
        }

        public static object Deserialize(this XmlSerializer Serializer, string Filename)
        {
            using (var s = File.OpenRead(Filename))
                return Serializer.Deserialize(s);
        }
    }
}
