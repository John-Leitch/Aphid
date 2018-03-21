using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidLiteral"), Parallelizable(ParallelScope.Self)]
    public class LiteralTests : AphidTests
    {
        [Test]
        public void NumberTest()
        {
            Assert9("ret 9;");
        }

        [Test]
        public void NumberTest2()
        {
            AssertEquals(0, "ret 0.0;");
        }

        [Test]
        public void NumberTest3()
        {
            AssertEquals(0.1, "ret 0.1;");
        }

        [Test]
        public void NumberTest4()
        {
            AssertEquals(-0.1, "ret -0.1;");
        }

        [Test]
        public void NumberTest5()
        {
            AssertEquals(-1, "ret -1;");
        }

        [Test]
        public void HexNumberTest()
        {
            Assert9("ret 0x9;");
        }

        [Test]
        public void HexNumberTest2()
        {
            Assert9("ret 0xA - 0x1;");
        }

        [Test]
        public void HexNumberTest3()
        {
            Assert9("ret 0xf - 0x6;");
        }

        [Test]
        public void HexNumberTest4()
        {
            AssertEquals(0, "ret 0x0;");
        }

        [Test]
        public void BinaryNumberTest()
        {
            AssertEquals(0, "ret 0b0;");
        }

        [Test]
        public void BinaryNumberTest2()
        {
            Assert9("ret 0b1001;");
        }

        [Test]
        public void BinaryNumberTest3()
        {
            Assert9("ret 0b00000000001001;");
        }

        [Test]
        public void StringTest()
        {
            AssertFoo("ret 'foo';");
        }
    }
}
