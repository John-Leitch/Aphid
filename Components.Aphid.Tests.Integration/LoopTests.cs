using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidLoop")]
    public class LoopTests : AphidTests
    {
        [Test]
        public void ForTest()
        {
            AssertFoo("c=['f','o','o']; s=''; for(x in c){s = s + x;} ret s;");
        }

        [Test]
        public void ForTest2()
        {
            AssertFoo("c=['f','o','o']; s=''; for(x in c)s = s + x; ret s;");
        }

        [Test]
        public void WhileTest()
        {
            Assert9("x = 0; while (x < 9) x++; ret x;");
        }

        [Test]
        public void WhileTest2()
        {
            Assert9("x = 0; while (x < 50) { x++; if (x == 9) break; } ret x;");
        }

        [Test]
        public void DoWhileTest()
        {
            Assert9(@"
                x = 0;
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
                x = 0;
                do {
                    x++;
                    if (x == 9) break;
                } while (true);

                ret x;
            ");
        }
    }
}
