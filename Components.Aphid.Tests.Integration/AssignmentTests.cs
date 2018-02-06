using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidAssignment"), Parallelizable(ParallelScope.Self)]
    public class AssignmentTests : AphidTests
    {
        [Test]
        public void AssignmentTest()
        {
            AssertTrue("x = 1; ret x == 1;");
        }

        [Test]
        public void AssignmentTest2()
        {
            AssertTrue("x = 1; y = x; y = 9; ret x == 1 && y == 9;");
        }
    }
}
