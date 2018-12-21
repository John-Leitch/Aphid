using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "IdDirective"), Parallelizable(ParallelScope.All)]
    public class IdDirectiveTests : AphidTests
    {
        [Test]
        public void TestIdDirective()
        {
            Assert9(@"
                var id(foo, bar) = 9;
                ret foobar;
            ");
        }

        [Test]
        public void TestIdDirective2()
        {
            Assert9(@"
                var foobar = 9;
                ret id(foo, bar);
            ");
        }

        [Test]
        public void TestIdDirective3()
        {
            Assert9(@"
                var id(foo, bar) = 9;
                ret id(foo, bar);
            ");
        }
    }
}
