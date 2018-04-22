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
            AssertFoo("var x = { y: 'foo' }; ret x.y;");
        }

        [Test]
        public void MemberGetTest2()
        {
            AssertFoo("var x = { y = 'foo' }; ret x.y;");
        }

        [Test]
        public void MemberShortHandTest()
        {
            AssertFoo("var y = 'foo'; var x = { y }; ret x.y;");
        }

        [Test]
        public void ObjectMemberSetTest1()
        {
            AssertFoo("var x='foo'; var a={x}; a.x='bar'; ret x;");
        }

        [Test]
        public void ObjectMemberSetTest2()
        {
            AssertTrue("var x='foo'; var a={x}; a.x='bar'; ret x=='foo' && a.x=='bar';");
        }

        [Test]
        public void ObjectVarValueTypeAssignTest()
        {
            AssertTrue("var i = 0; var f = @() ++i; var a = f(); var b = f(); ret a != b");
        }

        [Test]
        public void ObjectVarValueTypeReassignTest()
        {
            AssertTrue("var i = 0; var f = @() ++i; var a = f(); var b = 0; b = f(); ret a != b");
        }

        [Test]
        public void ObjectMemberValueTypeAssignTest()
        {
            AssertTrue("var i = 0; var f = @() ++i; var o = {}; o.a = f(); o.b = f(); ret o.a != o.b");
        }

        [Test]
        public void ObjectArrayValueTypeAssignTest()
        {
            AssertTrue("var i = 0; var f = @() ++i; var a = [ f(), 123 ]; a[1] = f(); ret a[0] != a[1]");
        }
    }
}
