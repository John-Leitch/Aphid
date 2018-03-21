using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidDefinedOperator"), Parallelizable(ParallelScope.Self)]
    public class DefinedOperatorTests : AphidTests
    {
        [Test]
        public void DefinedTest()
        {
            AssertTrue("x; ret x defined;");
        }

        [Test]
        public void DefinedTest2()
        {
            AssertFalse("test=@(){x='foo'; ret x;}; test(); ret x defined;");
        }

        [Test]
        public void DefinedTest3()
        {
            AssertFalse("test=@()x='foo'; test(); ret x defined;");
        }

        [Test]
        public void DefinedTest4()
        {
            AssertTrue("x='foo'; ret x defined;");
        }

        [Test]
        public void DefinedTest5()
        {
            AssertFalse("if (true) { x = 1; } ret x defined;");
        }

        [Test]
        public void DefinedTest6()
        {
            AssertTrue("x = 0; if (true) { x = 1; } ret x defined;");
        }

        [Test]
        public void DefinedMemberTest()
        {
            AssertTrue("x = { y: 10 }; ret x.y defined;");
        }

        [Test]
        public void DefinedMemberTest2()
        {
            AssertTrue("x = { y: { z: 10 } }; ret x.y.z defined;");
        }

        [Test]
        public void DefinedMemberTest3()
        {
            AssertTrue("x = { y: { z: 10 } }; ret x.y defined;");
        }

        [Test]
        public void DefinedMemberTest4()
        {
            AssertTrue("x = { y: { z: 10 } }; ret x defined;");
        }

        [Test]
        public void DefinedMemberAssignTest()
        {
            AssertTrue("x = { }; x.y = 10; ret x.y defined;");
        }

        [Test]
        public void DefinedMemberAssignTest2()
        {
            AssertTrue("x = { }; x.y = {}; x.y.z = 10; ret x.y.z defined;");
        }

        [Test]
        public void DefinedMemberAssignTest3()
        {
            AssertTrue("x = { }; x.y = {}; x.y.z = 10; ret x.y defined;");
        }

        [Test]
        public void DefinedMemberAssignTest4()
        {
            AssertTrue("x = { }; x.y = {}; x.y.z = 10; ret x defined;");
        }
    }
}
