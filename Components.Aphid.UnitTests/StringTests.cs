using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidString"), Parallelizable(ParallelScope.All)]
    public class StringTests : AphidTests
    {
        public override bool LoadStd => true;

        [Test]
        public void CharsTest() =>
            AssertFoo("var c='foo'.chars(); ret c[0] + c[1] + c[2];");

        [Test]
        public void SplitTest() =>
            AssertFoo("ret ('test foo'.split([' ']))[1];");

        [Test]
        public void LengthTest() =>
            Assert9("ret 'aaaaaaaaa'.length();");

        [Test]
        public void RemoveTest() =>
            AssertFoo("ret 'foobar'.remove(3);");

        [Test]
        public void SubstringTest() =>
            AssertFoo("ret 'testfoo'.substring(4);");

        [Test]
        public void SubstringTest2() =>
            AssertFoo("ret 'testfootest'.substring(4, 3);");

        [Test]
        public void IsMatchTest() =>
            AssertTrue("ret 'foo'.isMatch('f');");

        [Test]
        public void IsMatchTest2() =>
            AssertTrue("ret 'foo'.isMatch('.oo');");

        [Test]
        public void IsMatchTest3() =>
            AssertFalse("ret 'foo'.isMatch('of');");

        [Test]
        public void IsMatchTest4() =>
            AssertFalse("ret 'foo'.isMatch('\\\\d+');");

        [Test]
        public void StartsWithTest() =>
            AssertTrue("ret 'foo'.startsWith('fo');");

        [Test]
        public void StartsWithTest2() =>
            AssertFalse("ret 'foo'.startsWith('oo');");

        [Test]
        public void EndsWithTest() =>
            AssertTrue("ret 'foo'.endsWith('oo');");

        [Test]
        public void EndsWithTest2() =>
            AssertFalse("ret 'foo'.endsWith('fo');");
    }
}
