using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidCustomOperator")]
    public class CustomOperatorTests : AphidTests
    {
        protected override bool LoadStd
        {
            get
            {
                return true;
            }
        }

        [Test]
        public void CustomUnaryOperatorTest()
        {
            Assert9(@"
                @:% (x) { ret x * x; };
                ret :% 3;
            ");
            
        }

        [Test]
        public void CustomUnaryOperatorTest2()
        {
            AssertFoo(@"
                @:% (x) { ret x + 'oo'; };
                ret :% 'f';
            ");
        }

        [Test]
        public void CustomUnaryOperatorTest3()
        {
            Assert9(@"
                @:% (x) x * x;
                ret :% 3;
            ");

        }

        [Test]
        public void CustomUnaryOperatorTest4()
        {
            Assert9(@"
                @^^ (x) x * x;
                ret ^^ 3;
            ");
        }

        [Test]
        public void CustomUnaryOperatorTest5()
        {
            Assert9("@^^(x)x*x;ret^^3;");
        }

        [Test]
        public void CustomBinaryOperatorTest()
        {
            AssertTrue(@"
                using System.Text.RegularExpressions;
                @~? (text, pattern) Regex.IsMatch(text, pattern);
                ret 'Hello foo world' ~? 'foo';
            ");
        }

        [Test]
        public void CustomBinaryOperatorTest1()
        {
            AssertFalse(@"
                using System.Text.RegularExpressions;
                @~? (text, pattern) Regex.IsMatch(text, pattern);
                ret 'Hello foo world' ~? 'foo2';
            ");
        }

        [Test]
        public void CustomBinaryOperatorTest2()
        {
            AssertFoo(@"
                using System.Text.RegularExpressions;
                @~~ (text, pattern) Regex.Matches(text, pattern);
                ret ('Hello foo world' ~~ 'foo')[0].Value;
            ");
        }
    }
}
