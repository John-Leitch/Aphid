using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidDynamicMember"), Parallelizable(ParallelScope.Self)]
    public class DynamicMemberTests : AphidTests
    {
        [Test]
        public void DynamicMemberTest()
        {
            AssertFoo("x = { y: 'foo' }; ret x.{'y'};");
        }

        [Test]
        public void DynamicMemberTest2()
        {
            AssertFoo("x = { y: { z: 'foo' } }; ret x.{'y'}.z;");
        }

        [Test]
        public void DynamicMemberTest3()
        {
            AssertFoo("x = { y: { z: 'foo' } }; ret x.{'y'}.{'z'};");
        }

        [Test]
        public void DynamicMemberTest4()
        {
            AssertFoo("x = { y: { z: 'bar' } }; x.{'y'}.{'z'} = 'foo'; ret x.y.z;");
        }

        [Test]
        public void DynamicMemberTest5()
        {
            AssertFoo("x = { y: { z: 'bar' } }; x.{'y'}.{'z'} = 'foo'; ret x.{'y'}.{'z'};");
        }
    }
}
