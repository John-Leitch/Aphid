using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "IdDirective"), Parallelizable(ParallelScope.All)]
    public class IdDirectiveTests : AphidTests
    {
        [Test]
        public void TestIdDirective() =>
            Assert9(@"
                var id(foo, bar) = 9;
                ret foobar;
            ");

        [Test]
        public void TestIdDirective2() =>
            Assert9(@"
                var foobar = 9;
                ret id(foo, bar);
            ");

        [Test]
        public void TestIdDirective3() =>
            Assert9(@"
                var id(foo, bar) = 9;
                ret id(foo, bar);
            ");
    }
}
