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
                "o = {0} |> serialize |> deserialize;\r\n{1}",
                objectDecl,
                code);

            AssertEquals(expected, script);
        }

        private void AssertFooSerialization(string objectDecl, string code)
        {
            AssertSerialization("foo", objectDecl, code);
        }

        private void Assert9Serialization(string objectDecl, string code)
        {
            AssertSerialization(9, objectDecl, code);
        }

        [Test]
        public void SerializeStringTest()
        {
            AssertFooSerialization("'foo'", "ret o");
        }

        [Test]
        public void SerializeStringTest2()
        {
            AssertFooSerialization("{ x: 'foo' }", "ret o.x");
        }

        [Test]
        public void SerializeStringTest3()
        {
            AssertFooSerialization("{ vec: { x: 'foo' } }", "ret o.vec.x");
        }

        /// <summary>
        /// Todo: fix AphidObjectLexer.
        /// </summary>
        [Test]
        public void SerializeNumberTest()
        {
            Assert9Serialization(
                "@{ using Components.Aphid.Interpreter; ret ValueHelper.Wrap(9) }()",
                "ret o");
        }

        [Test]
        public void SerializeNumberTest2()
        {
            Assert9Serialization("{ x: 9 }", "ret o.x");
        }

        [Test]
        public void SerializeNumberTest3()
        {
            Assert9Serialization("{ vec: { x: 9 } }", "ret o.vec.x");
        }

        //[Test]
        //public void ConstantFoldingTest2()
        //{
        //}
    }
}
