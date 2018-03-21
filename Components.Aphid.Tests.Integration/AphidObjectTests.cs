using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidObject"), Parallelizable(ParallelScope.Self)]
    public class AphidObjectTests : AphidTests
    {
        [Test]
        public void MemberGetTest()
        {
            AssertFoo("x = { y: 'foo' }; ret x.y;");
        }

        [Test]
        public void MemberGetTest2()
        {
            AssertFoo("x = { y = 'foo' }; ret x.y;");
        }

        [Test]
        public void MemberShortHandTest()
        {
            AssertFoo("y = 'foo'; x = { y }; ret x.y;");
        }

        [Test]
        public void ObjectMemberSetTest1()
        {
            AssertFoo("x='foo'; a={x}; a.x='bar'; ret x;");
        }

        [Test]
        public void ObjectMemberSetTest2()
        {
            AssertTrue("x='foo'; a={x}; a.x='bar'; ret x=='foo' && a.x=='bar';");
        }        
    }
}
