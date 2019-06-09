using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidProperties"), Parallelizable(ParallelScope.All)]
    public class PropertyTests : AphidTests
    {
        [Test]
        public void PropertyGetTest() =>
            AssertFoo("var x={y:'foo'}; ret x.y;");

        [Test]
        public void PropertyGetTest2() =>
            AssertFoo("var x={y:{z:{a:{b:{c:'foo'}}}}}; ret x.y.z.a.b.c;");

        [Test]
        public void PropertySetTest() =>
            AssertFoo("var x={}; x.y='foo'; ret x.y;");

        [Test]
        public void PropertySetTest2() =>
            AssertFoo("var x={y:'bar'}; x.y='foo'; ret x.y;");

        [Test]
        public void PropertySetTest3() =>
            AssertFoo("var x={y:{z:{}}}; x.y.z.a='foo'; ret x.y.z.a;");
    }
}
