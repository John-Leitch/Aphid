using Components.ObjectDatabase;
using System;
using System.IO;
using static System.IO.Path;
//using static NUnit.Framework.CollectionAssert;
using System.Threading;
using BinDB = Components.ObjectDatabase.BinaryObjectDatabase<object>;

namespace Components.External.Tests
{
    public class ObjectDatabaseTestContext
    {
        public BinDB CurrentDB { get; private set; }

        public Widget CurrentWidget { get; private set; }

        public BinDB NextDB() => CurrentDB = BinaryObjectDatabase.OpenFile(NextDBName());

        public string NextDBName() => Combine(GetTempPath(), $"TestDB_{Guid.NewGuid()}.odb");

        public Widget NextWidget() => CurrentWidget = new Widget(
            0x10,
            0x20,
            BitConverter.GetBytes(0xdeadbeef),
            "Hello world",
            null);

        //public void TestDB(Action<BinDB> action)
        //{
        //    BinDB db = null;

        //    try
        //    {
        //        using (db = NextDB())
        //        {
        //            action(db);
        //        }
        //    }
        //    finally
        //    {
        //        if (db != null)
        //        {
        //            File.Delete(db.Filename);
        //            File.Delete(db.MemoryManagerFilename);
        //        }
        //    }
        //}
    }
}
