using Components.Aphid.Parser;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "Serialization")]
    public class SerializerTests : AphidTests
    {
        protected override bool LoadStd
        {
            get { return true;  }
        }

        private void AssertSerialization(object expected, string objectDecl, string code)
        {
            var script = string.Format(
                "o = ({0}) |> serialize |> deserialize;\r\n{1}",
                objectDecl,
                code);

            AssertEquals(expected, script);
        }

        private void AssertFooDeserialization(string objectDecl, string code)
        {
            AssertSerialization("foo", objectDecl, code);
        }

        private void Assert9Deserialization(string objectDecl, string code)
        {
            AssertSerialization(9, objectDecl, code);
        }

        private void AssertTrueDeserialization(string objectDecl, string code)
        {
            AssertSerialization(true, objectDecl, code);
        }

        private void AssertFalseDeserialization(string objectDecl, string code)
        {
            AssertSerialization(false, objectDecl, code);
        }

        [Test]
        public void TestStringSerialization()
        {
            AssertFooDeserialization("'foo'", "ret o");
        }

        [Test]
        public void TestStringSerialization2()
        {
            AssertFooDeserialization("{ x: 'foo' }", "ret o.x");
        }

        [Test]
        public void TestStringSerialization3()
        {
            AssertFooDeserialization("{ vec: { x: 'foo' } }", "ret o.vec.x");
        }

        /// <summary>
        /// Todo: fix AphidObjectLexer.
        /// </summary>
        [Test]
        public void TestNumberSerialization()
        {
            Assert9Deserialization(
                "@{ using Components.Aphid.Interpreter; ret ValueHelper.Wrap(9) }()",
                "ret o");
        }

        [Test]
        public void TestNumberSerialization2()
        {
            Assert9Deserialization("{ x: 9 }", "ret o.x");
        }

        [Test]
        public void TestNumberSerialization3()
        {
            Assert9Deserialization("{ vec: { x: 9 } }", "ret o.vec.x");
        }

        [Test]
        public void TestListSerialization()
        {
            AssertFooDeserialization("[ 'foo' ]", "ret o[0]");
        }

        [Test]
        public void TestListSerialization2()
        {
            AssertFooDeserialization("[ null, 'foo' ]", "ret o[1]");
        }

        [Test]
        public void TestListSerialization3()
        {
            Assert9Deserialization("[ 9 ]", "ret o[0]");
        }

        [Test]
        public void TestListSerialization4()
        {
            Assert9Deserialization("[ null, 9 ]", "ret o[1]");
        }

        [Test]
        public void TestListSerialization5()
        {
            Assert9Deserialization("0..9", "ret o.Count");
        }

        [Test]
        public void TestListSerialization6()
        {
            AssertTrueDeserialization("0..0", "ret o.Count == 0");
        }

        [Test]
        public void TestListSerialization7()
        {
            AssertTrueDeserialization("0..0x1000", "ret o.Count == 0x1000");
        }

        [Test, Ignore]
        public void TestListSerialization8()
        {
            Assert9Deserialization(
                "(0..0x100)->@() $_ * 2",
                "ret o.Count == 0x100 && o[0x2] == 0x4");
        }
    }
}
