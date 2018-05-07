using System.Collections.Generic;
using System.IO;
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
                return (List<AphidExpression>)_serializer.Deserialize(s);
            }
        }
    }
}
