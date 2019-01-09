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
            var db = ObjectDatabase.ObjectDatabase.OpenStringDatabase("test.sdb");

            for (var i = 0; i < 10000000; i++)
            {
                db.Create("A");
            }
        }
    }
}
