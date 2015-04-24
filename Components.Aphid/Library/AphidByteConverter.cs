using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Library
{
    public static class AphidByteConverter
    {
        public static byte[] ToBytes(AphidObject obj)
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
                throw new AphidRuntimeException("Invalid object passed as buffer: {0}", v);
            }

            return bytes;
        }
    }
}
