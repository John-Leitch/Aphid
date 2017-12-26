using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidList")]
    public class ListTests : AphidTests
    {
        [Test]
        public void ListAccessTest()
        {
            AssertFoo("x = [ 9, 'foo' ]; ret x[1];");
        }

        [Test]
        public void ListAccessTest2()
        {
            Assert9("x = [ 9, 'foo' ]; ret x[0];");
        }

        [Test]
        public void ListAccessTest3()
        {
            AssertFoo("x={ y:['foo'] }; ret x.y[0];");
        }

        [Test]
        public void ListElementSetTest()
        {
            AssertFoo("x = [ 'bar' ]; x[0] = 'foo'; ret x[0];");
        }

        [Test]
        public void ListElementSetTest2()
        {
            AssertFoo("x = [ 'foo' ]; y = x[0]; y = 'bar'; ret x[0];");
        }

        [Test]
        public void ListElementSetTest3()
        {
            AssertFoo("x = 'foo'; y = [ 0 ]; y[0] = x; x = 'bar'; ret y[0];");
        }

        [Test]
        public void ListElementSetTest4()
        {
            AssertFoo("x = 'foo'; y = [ x ]; x = 'bar'; ret y[0];");
        }

        [Test]
        public void ListTest3()
        {
            AssertFoo("#'Std'; a = [ 'f', 'o', 'o' ]; ret a.aggregate(@(x, y)x + y);");
        }

        [Test]
        public void ListTest4()
        {
            AssertFoo("#'Std'; a = 'foo'; ret a.chars().aggregate(@(x, y)x + y);");
        }
    }
}
