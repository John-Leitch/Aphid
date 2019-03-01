using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidNull"), Parallelizable(ParallelScope.All)]
    public class NullTests : AphidTests
    {
        [Test]
        public void NullTest() => AssertTrue("ret null == null;");

        [Test]
        public void NullTest2() => AssertTrue("ret null != 1;");

        [Test]
        public void NullTest3() => AssertTrue("ret null != 'foo';");

        [Test]
        public void NullTest4() => AssertTrue("ret null != false;");

        [Test]
        public void NullTest5() => AssertFalse("ret null != null;");

        [Test]
        public void NullTest6() => AssertFalse("ret null == 1;");

        [Test]
        public void NullTest7() => AssertFalse("ret null == 'foo';");

        [Test]
        public void NullTest8() => AssertFalse("ret null == false;");

        [Test]
        public void NullTest9() => AssertTrue("var x = { foo: 'bar' }; ret x != null;");

        [Test]
        public void NullTest10() => AssertFalse("var x = { foo: 'bar' }; ret x == null;");
    }
}
