using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidIndex")]
    public class IndexTests : AphidTests
    {
        [Test]
        public void TestListIndexGet()
        {
            AssertExpFoo(@"[ 'foo' ][0]");
        }

        [Test]
        public void TestListIndexGet2()
        {
            AssertExp9(@"[ 9 ][0]");
        }

        [Test]
        public void TestListIndexGet3()
        {
            AssertExpFoo(@"[ 'bar', 'foo' ][1]");
        }

        [Test]
        public void TestListIndexGet4()
        {
            AssertExp9(@"[ 1, 9 ][1]");
        }

        [Test]
        public void TestListIndexGet5()
        {
            AssertExpFoo(@"[ 9, 'foo' ][1]");
        }

        [Test]
        public void TestListIndexGet6()
        {
            AssertExp9(@"[ 'foo', 9 ][1]");
        }        
    }
}
