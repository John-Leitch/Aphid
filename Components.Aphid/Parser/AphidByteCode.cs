using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Components.Aphid.Parser
{
    public static class AphidByteCode
    {
        private static bool _useBoundSerializer = false;

        [ThreadStatic]
        private static BinaryFormatter _serializer, _boundSerializer;

        public static BinaryFormatter Serializer =>
            _serializer ?? (_serializer = new BinaryFormatter());

        public static BinaryFormatter BoundSerializer =>
            _boundSerializer ?? (_boundSerializer = new BinaryFormatter()
            {
                Binder = new AphidExpressionBinder()
            });

        public static byte[] Encode(List<AphidExpression> ast)
        {
            using (var s = new MemoryStream())
            {
                Encode(s, ast);

                return s.ToArray();
            }
        }

        public static void Encode(Stream stream, List<AphidExpression> ast) => Serializer.Serialize(stream, ast);

        public static List<AphidExpression> Decode(byte[] bytecode)
        {
            using (var s = new MemoryStream(bytecode))
            {
                return Decode(s);
            }
        }

        public static List<AphidExpression> Decode(Stream stream)
        {
            if (!_useBoundSerializer)
            {
                try
                {
                    return (List<AphidExpression>)Serializer.Deserialize(stream);
                }
                catch (InvalidCastException)
                {
                    stream.Position = 0;
                    var result = (List<AphidExpression>)BoundSerializer.Deserialize(stream);
                    _useBoundSerializer = true;
                    return result;
                }
            }
            else
            {
                return (List<AphidExpression>)BoundSerializer.Deserialize(stream);
            }
        }

        public static List<AphidExpression> DecodeResource(string name)
        {
            using (var s = Assembly.GetEntryAssembly().GetManifestResourceStream(name))
            {
                if (s == null)
                {
                    throw new InvalidOperationException(
                        string.Format("Could not find resource stream {0}.", name));
                }

                return Decode(s);
            }
        }
    }
}
