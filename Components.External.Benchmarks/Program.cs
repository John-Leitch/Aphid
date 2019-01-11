using Components;
using Components.ObjectDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            SizeTest();
        }

        static void SizeTest()
        {
            var db = ObjectDatabase.ObjectDatabase.OpenStringDatabase("test2.sdb");
            var mm = db.ReadMemoryManagerUnsafe();
            mm.PageSize = 0x2;
            db.WriteMemoryManagerUnsafe(mm);

            var r = new string('A', 2);
            for (var i = 0; i < 10000000; i++)
            {
                db.Create(r);
            }

            db.ReadUnsafe();
        }

        //static void SizeTest()
        //{
        //    var db = ObjectDatabase.ObjectDatabase.OpenStringDatabase("test2.sdb");
        //    var mm = db.ReadMemoryManagerUnsafe();
        //    mm.PageSize = 0x2;
        //    db.WriteMemoryManagerUnsafe(mm);

        //    var r = new string('A', 100 * 0x100000);
        //    for (var i = 0; i < 30; i++)
        //    {
        //        db.Create(r);
        //    }

        //    db.ReadUnsafe();
        //}

        static void PerfTest()
        {
            var db = ObjectDatabase.ObjectDatabase.OpenStringDatabase("test.sdb");

            for (var i = 0; i < 10000000; i++)
            {
                db.Create("A");
            }
        }
    }
}
