using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidFunction")]
    public class FunctionTests : AphidTests
    {       
        [Test]
        public void FunctionTest()
        {
            Assert9("sqr=@(x){ret x*x;}; ret sqr(3);");
        }

        [Test]
        public void SingleLineFunctionTest()
        {
            AssertFoo("x = @()'foo'; ret x();");
        }

        [Test]
        public void SingleLineFunctionTest2()
        {
            Assert9("sqr=@(x)x*x; ret sqr(3);");
        }

        [Test]
        public void HigherOrderFunctionTest()
        {
            AssertFoo("call=@(x)x(); test=@()'foo'; ret call(test);");
        }

        [Test]
        public void HigherOrderFunctionTest2()
        {
            Assert9("add=@(x)@(y)x+y; addFour=add(4); ret addFour(5);");
        }

        [Test]
        public void PartialFunctionTest()
        {
            Assert9("add=@(x, y)x+y; addFour=@add(4); ret addFour(5);");
        }
    }
}
