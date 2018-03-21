using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidStatementModifier"), Parallelizable(ParallelScope.Self)]
    public class StatementModifierTests : AphidTests
    {
        [Test]
        public void ForModifierTest()
        {
            AssertFoo("c=['f','o','o']; s=''; c for(x){s = s + x}; ret s;");
        }

        [Test]
        public void ForModifierTest2()
        {
            AssertFoo("c=['f','o','o']; s=''; c for(x){s = s + $_}; ret s;");
        }

        [Test]
        public void ForModifierTest3()
        {
            AssertFoo("c=['f','o','o']; s=''; c for{s = s + $_}; ret s;");
        }

        [Test]
        public void ForModifierTest4()
        {
            AssertFoo("c=['f','o','o']; s=''; c for s = s + $_; ret s;");
        }

        [Test]
        public void ForModifierTest5()
        {
            AssertFoo("s=''; ['f','o','o'] for s = s + $_; ret s;");
        }

        [Test]
        public void ForModifierTest6()
        {
            AssertFoo("s=''; ['f','o','o'] for s += $_; ret s;");
        }

        [Test]
        public void ForModifierTest7()
        {
            AssertFoo("s=''; ['f','o','o'] for (x) s += x; ret s;");
        }

        [Test]
        public void ForModifierTest8()
        {
            AssertFoo("s=''; ['f','o','o'] for (x) s += $_; ret s;");
        }
    }
}
