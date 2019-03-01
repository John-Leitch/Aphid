using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidParserTests"), Parallelizable(ParallelScope.All)]
    public class ParserTests : AphidTests
    {
        [Test]
        public void TestArrayAccessCall1() => AssertFoo("var x = [ @()'foo' ]; var y = x[0](); ret y;");

        [Test]
        public void TestArrayAccessCall2() => AssertFoo("var x = [ @()'foo' ]; ret x[0]();");

        [Test]
        public void TestArrayAccessInstanceCall1() => AssertFoo("var x = [ { y: @()'foo' } ]; var z = x[0].y; ret z();");

        [Test]
        public void TestArrayAccessInstanceCall2() => AssertFoo("var x = [ { y: @()'foo' } ]; ret x[0].y();");
    }
}
