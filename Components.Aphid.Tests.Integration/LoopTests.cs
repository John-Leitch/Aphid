using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidLoop"), Parallelizable(ParallelScope.All)]
    public class LoopTests : AphidTests
    {
        protected override bool LoadStd
        {
            get { return true; }
        }

        [Test]
        public void ForTest()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(var x = 0; x < c.count(); x++){s = s + c[x];} ret s;");
        }

        [Test]
        public void ForTest2()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(var x = 0; x < c.count(); x++) s = s + c[x]; ret s;");
        }

        [Test]
        public void ForEachTest()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(x in c){s = s + x;} ret s;");
        }

        [Test]
        public void ForEachTest2()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(x in c)s = s + x; ret s;");
        }

        [Test]
        public void ForEachTest3()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(x in c)s = s + $_; ret s;");
        }

        [Test]
        public void ForEachTest4()
        {
            AssertFoo("var c=['f','o','o']; var s=''; for(c)s = s + $_; ret s;");
        }

        [Test]
        public void ForEachTest5()
        {
            Assert9(@"
                var a = 0;
                var b = 0;

                for(x in 0..100) {
                    if (x > 3) continue;
                    a = x;
                }

                for(x in 0..100) {
                    if (x > 6) continue;
                    b = x;
                }

                ret a + b;
            ");
        }

        [Test]
        public void ForEachTest6()
        {
            Assert9(@"
                var a = 0;
                var b = 0;

                for(x in 0..100) {
                    if (x > 3) break;
                    a = x;
                }

                for(x in 0..100) {
                    if (x > 6) break;
                    b = x;
                }

                ret a + b;
            ");
        }

        [Test]
        public void WhileTest()
        {
            Assert9("var x = 0; while (x < 9) x++; ret x;");
        }

        [Test]
        public void WhileTest2()
        {
            Assert9("var x = 0; while (x < 50) { x++; if (x == 9) break; } ret x;");
        }

        [Test]
        public void DoWhileTest()
        {
            Assert9(@"
                var x = 0;
                do {
                    x++;
                } while (x < 9);

                ret x;
            ");
        }

        [Test]
        public void DoWhileTest2()
        {
            Assert9(@"
                var x = 0;
                do {
                    x++;
                    if (x == 9) break;
                } while (true);

                ret x;
            ");
        }
    }
}
