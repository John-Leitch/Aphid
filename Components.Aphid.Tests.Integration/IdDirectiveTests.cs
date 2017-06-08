using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "IdDirective")]
    public class IdDirectiveTests : AphidTests
    {
        [Test]
        public void TestIdDirective()
        {
            Assert9(@"
                id(foo, bar) = 9;
                ret foobar;
            ");
        }

        [Test]
        public void TestIdDirective2()
        {
            Assert9(@"
                foobar = 9;
                ret id(foo, bar);
            ");
        }

        [Test]
        public void TestIdDirective3()
        {
            Assert9(@"
                id(foo, bar) = 9;
                ret id(foo, bar);
            ");
        }
    }
}
