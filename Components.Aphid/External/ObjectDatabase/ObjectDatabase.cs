//#define ODB_NULL_CHECKS
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using Components.External;
using Components.IO;

namespace Components.ObjectDatabase
{
    public static class ObjectDatabase
    {
        public static ObjectDatabase<string> OpenStringDatabase(
            string filename,
            bool useUnsafeMemoryManager = false) =>
            new ObjectDatabase<string>(
                filename,
                (x, s) =>
                {
                    x.Write(BitConverter.GetBytes(s.Length));
                    x.Write(s.GetBytes());
                },
                (x) => x.Read(BitConverter.ToInt32(x.Read(4), 0)).GetString(),
                useUnsafeMemoryManager)
                .Do(x => x.Open());
    }
}