using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidParserTests")]
    public class ParserTests : AphidTests
    {
        [Test]
        public void TestArrayAccessCall1()
        {
            AssertFoo("x = [ @()'foo' ]; y = x[0](); ret y;");
        }

        [Test]
        public void TestArrayAccessCall2()
        {
            AssertFoo("x = [ @()'foo' ]; ret x[0]();");
        }

        [Test]
        public void TestArrayAccessInstanceCall1()
        {
            AssertFoo("x = [ { y: @()'foo' } ]; z = x[0].y; ret z();");
        }

        [Test]
        public void TestArrayAccessInstanceCall2()
        {
            AssertFoo("x = [ { y: @()'foo' } ]; ret x[0].y();");
        }
    }
}
