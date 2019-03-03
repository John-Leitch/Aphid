using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Components.Aphid.Parser
{
    public class AphidByteCodeSerializationContext
    {
        public Dictionary<string, AphidExpressionContext> ExpressionContexts { get; } =
            new Dictionary<string, AphidExpressionContext>();
    }

    public static class AphidByteCode
    {
        private static bool _useBoundSerializer;

        private static BinaryFormatter CreateFormatter() =>
            _useBoundSerializer ?
                new BinaryFormatter(null, CreateContext())
                {
                    Binder = new AphidExpressionBinder()
                } :
                new BinaryFormatter(null, CreateContext());

        private static StreamingContext CreateContext() =>
            new StreamingContext(
                StreamingContextStates.Persistence,
                new AphidByteCodeSerializationContext());

        public static byte[] Encode(List<AphidExpression> ast)
        {
            using (var s = new MemoryStream())
            {
                Encode(s, ast);

                return s.ToArray();
            }
        }

        public static void Encode(Stream stream, List<AphidExpression> ast)
        {
            CreateFormatter().Serialize(stream, ast);
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
            var serializer = CreateFormatter();

            if (!_useBoundSerializer)
            {
                try
                {
                    return (List<AphidExpression>)serializer.Deserialize(stream);
                }
                catch (InvalidCastException)
                {
                    return RetryDecode(stream);
                }
            }
            else
            {
                return (List<AphidExpression>)serializer.Deserialize(stream);
            }
        }

        private static List<AphidExpression> RetryDecode(Stream stream)
        {
            stream.Position = 0;
            _useBoundSerializer = true;

            return (List<AphidExpression>)CreateFormatter().Deserialize(stream);
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
