﻿using System.Text;

namespace Components
{
    public static class ByteArrayExtension
    {
        private static readonly Encoding _encoding = Encoding.GetEncoding("iso-8859-1");

        public static string GetString(this byte[] Bytes) => _encoding.GetString(Bytes);
    }
}
