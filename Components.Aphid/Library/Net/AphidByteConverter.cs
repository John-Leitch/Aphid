using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Library
{
    public class AphidByteConverter : AphidRuntimeComponent
    {
        public AphidByteConverter(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public byte[] ToBytes(AphidObject obj)
        {
            var v = obj.Value;
            byte[] bytes;

            if (v is List<AphidObject> objects)
            {
                bytes = objects.Select(x => (byte)(decimal)x.Value).ToArray();
            }
            else if (v is string str)
            {
                bytes = StandardLibrary.Encoding.GetBytes(str);
            }
            else
            {
                throw Interpreter.CreateRuntimeException(
                    "Invalid object passed as buffer: {0}",
                    v);
            }

            return bytes;
        }
    }
}
