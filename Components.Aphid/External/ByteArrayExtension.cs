using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Components
{
    public static class ByteArrayExtension
    {
        private static Encoding _encoding = Encoding.GetEncoding("iso-8859-1");

        public static string GetString(this byte[] Bytes)
        {
            return _encoding.GetString(Bytes);
        }
    }
}
