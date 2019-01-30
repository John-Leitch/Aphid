using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Components.Aphid.Library
{
    [AphidLibraryAttribute("stream")]
    public static class StreamLibrary
    {
        [AphidInteropFunction("__stream.write", PassInterpreter = true)]
        public static void StreamWrite(AphidInterpreter interpreter, Stream stream, object buffer)
        {
            byte[] bytes;
            string str;

            if (buffer is List<AphidObject> objects)
            {
                bytes = objects.Select(x => (byte)(decimal)x.Value).ToArray();
            }
            else if ((str = buffer as string) != null)
            {
                bytes = StandardLibrary.Encoding.GetBytes(str);
            }
            else
            {
                throw interpreter.CreateRuntimeException(
                    "Invalid object passed as buffer: {0}",
                    buffer);
            }

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
