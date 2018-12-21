using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidConditional"), Parallelizable(ParallelScope.All)]
    public class ConditionalTests : AphidTests
    {
        [Test]
        public void IfTest()
        {
            AssertFoo("if(true){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void IfTest2()
        {
            AssertFoo("if(true)ret 'foo';else{ret 'bar';}");
        }

        [Test]
        public void IfTest3()
        {
            AssertFoo("if(false || true){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void IfTest4()
        {
            AssertFoo("if(false || false || true){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void IfTest5()
        {
            AssertFoo("if(false || false || false || true){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void IfTest6()
        {
            AssertFoo("if((true && false) || true){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void IfTest7()
        {
            AssertFoo("if((true && false) || (false && true) || (true && true)){ret 'foo';}else{ret 'bar';}");
        }

        [Test]
        public void ElseTest()
        {
            AssertFoo("if(false){ret 'bar';}else{ret 'foo';}");
        }

        [Test]
        public void ElseTest2()
        {
            AssertFoo("if(false)ret 'bar'; else ret 'foo';");
        }

        [Test]
        public void ElseTest3()
        {
            AssertFoo("if(false){ret 'bar';}else ret 'foo';");
        }

        [Test]
        public void ElseTest4()
        {
            AssertFoo("if(false)ret 'bar';else{ret 'foo';}");
        }        
    }
}
