using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            List<AphidObject> objects;
            string str;

            if ((objects = v as List<AphidObject>) != null)
            {
                bytes = objects.Select(x => (byte)(decimal)x.Value).ToArray();
            }
            else if ((str = v as string) != null)
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
