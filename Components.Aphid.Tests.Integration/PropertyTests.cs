using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidProperties"), Parallelizable(ParallelScope.All)]
    public class PropertyTests : AphidTests
    {
        [Test]
        public void PropertyGetTest()
        {
            AssertFoo("var x={y:'foo'}; ret x.y;");
        }

        [Test]
        public void PropertyGetTest2()
        {
            AssertFoo("var x={y:{z:{a:{b:{c:'foo'}}}}}; ret x.y.z.a.b.c;");
        }

        [Test]
        public void PropertySetTest()
        {
            AssertFoo("var x={}; x.y='foo'; ret x.y;");
        }

        [Test]
        public void PropertySetTest2()
        {
            AssertFoo("var x={y:'bar'}; x.y='foo'; ret x.y;");
        }

        [Test]
        public void PropertySetTest3()
        {
            AssertFoo("var x={y:{z:{}}}; x.y.z.a='foo'; ret x.y.z.a;");
        }
    }
}
