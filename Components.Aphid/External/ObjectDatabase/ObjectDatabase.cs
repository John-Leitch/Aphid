//#define ODB_NULL_CHECKS
using System;

namespace Components.ObjectDatabase
{
    public static class ObjectDatabase
    {
        public static ObjectDatabase<string> OpenStringDatabase(
            string filename,
            bool useUnsafeMemoryManager = false) =>
#pragma warning disable CA2000 // Call dispose before reference leaves scope
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
#pragma warning restore CA2000 // Call dispose before reference leaves scope
    }
}