using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Components.Aphid.Parser
{
    public static class AphidByteCode
    {
        private static BinaryFormatter _serializer = new BinaryFormatter()
        {
            Binder = new AphidExpressionBinder()
        };

        public static byte[] Encode(List<AphidExpression> ast)
        {
            using (var s = new MemoryStream())
            {
                _serializer.Serialize(s, ast);

                return s.ToArray();
            }
        }

        public static List<AphidExpression> Decode(byte[] bytecode)
        {
            using (var s = new MemoryStream(bytecode))
            {
                return Decode(s);
            }
        }

        public static List<AphidExpression> Decode(Stream stream)
        {
            return (List<AphidExpression>)_serializer.Deserialize(stream);
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
