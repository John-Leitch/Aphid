using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidPatternMatching"), Parallelizable(ParallelScope.Self)]
    public class PatternMatchingTests : AphidTests
    {
        [Test]
        public void PatternMatchingTest1()
        {
            Assert9("x = 'bar'; ret $(x) 'foo':0, 'bar':9, 1;");
        }

        [Test]
        public void PatternMatchingTest2()
        {
            Assert9("x = 'asdf'; ret $(x) 'foo':0, 'bar':1, 9;");
        }

        [Test]
        public void PatternMatchingTest3()
        {
            Assert9("x = 'foo'; ret $(x) 'foo':9, 'bar':1, 0;");
        }
    }
}
