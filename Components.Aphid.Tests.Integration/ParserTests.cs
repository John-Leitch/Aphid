using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidParserTests"), Parallelizable(ParallelScope.Self)]
    public class ParserTests : AphidTests
    {
        [Test]
        public void TestArrayAccessCall1()
        {
            AssertFoo("var x = [ @()'foo' ]; var y = x[0](); ret y;");
        }

        [Test]
        public void TestArrayAccessCall2()
        {
            AssertFoo("var x = [ @()'foo' ]; ret x[0]();");
        }

        [Test]
        public void TestArrayAccessInstanceCall1()
        {
            AssertFoo("var x = [ { y: @()'foo' } ]; var z = x[0].y; ret z();");
        }

        [Test]
        public void TestArrayAccessInstanceCall2()
        {
            AssertFoo("var x = [ { y: @()'foo' } ]; ret x[0].y();");
        }
    }
}
