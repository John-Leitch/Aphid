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
            byte[] bytes = v is List<AphidObject> objects
                ? objects.Select(x => (byte)(decimal)x.Value).ToArray()
                : v is string str
                    ? StandardLibrary.Encoding.GetBytes(str)
                    : throw Interpreter.CreateRuntimeException(
                                    "Invalid object passed as buffer: {0}",
                                    v);
            return bytes;
        }
    }
}
