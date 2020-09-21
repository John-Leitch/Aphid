using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Components.Aphid.Library
{
    [AphidLibrary("stream")]
    public static class StreamLibrary
    {
        [AphidInteropFunction("__stream.write", PassInterpreter = true)]
        public static void StreamWrite(AphidInterpreter interpreter, Stream stream, object buffer)
        {
            byte[] bytes = buffer is List<AphidObject> objects
                ? objects.Select(x => (byte)(decimal)x.Value).ToArray()
                : buffer is string str
                    ? StandardLibrary.Encoding.GetBytes(str)
                    : throw interpreter.CreateRuntimeException(
                                    "Invalid object passed as buffer: {0}",
                                    buffer);
            stream.Write(bytes, 0, bytes.Length);
        }

        [AphidInteropFunction("__stream.read")]
        public static List<AphidObject> StreamRead(Stream stream, decimal bufferLength)
        {
            var buffer = new byte[(int)bufferLength];

            var len = stream.Read(buffer, 0, buffer.Length);

            if (len != buffer.Length)
            {
                Array.Resize(ref buffer, len);
            }

            return buffer.Select(x => AphidObject.Scalar((decimal)x)).ToList();
        }
    }
}
