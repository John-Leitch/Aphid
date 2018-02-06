using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidProperties"), Parallelizable(ParallelScope.Self)]
    public class PropertyTests : AphidTests
    {
        [Test]
        public void PropertyGetTest()
        {
            AssertFoo("x={y:'foo'}; ret x.y;");
        }

        [Test]
        public void PropertyGetTest2()
        {
            AssertFoo("x={y:{z:{a:{b:{c:'foo'}}}}}; ret x.y.z.a.b.c;");
        }

        [Test]
        public void PropertySetTest()
        {
            AssertFoo("x={}; x.y='foo'; ret x.y;");
        }

        [Test]
        public void PropertySetTest2()
        {
            AssertFoo("x={y:'bar'}; x.y='foo'; ret x.y;");
        }

        [Test]
        public void PropertySetTest3()
        {
            AssertFoo("x={y:{z:{}}}; x.y.z.a='foo'; ret x.y.z.a;");
        }
    }
}
