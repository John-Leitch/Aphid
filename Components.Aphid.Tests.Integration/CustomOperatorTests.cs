using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidCustomOperator"), Parallelizable(ParallelScope.Self)]
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
        public void CustomUnaryOperatorScopeTest()
        {
            Assert9(@"
                @:% (x) { ret x * x; };
                foo = @{ @:% (x) x * x * x };
                foo();
                ret :% 3;
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest2()
        {
            Assert9(@"
                foo = @{ @:% (x) x * x * x };
                foo();
                @:% (x) { ret x * x; };
                ret :% 3;
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest3()
        {
            Assert9(@"
                @:% (x) { ret x * x * x; };
                foo = @{ @:% (x) x * x; ret :% 3 };
                ret foo();
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest4()
        {
            Assert9(@"
                foo = @{ @:% (x) x * x; ret :% 3 };
                ret foo();
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest5()
        {
            AssertFoo(@"
                @:% (x) { ret 'f' + x; };
                foo = @{ @:% (x) x + 'o'; ret :% $_ };
                ret (:% 'o') |> foo;
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest6()
        {
            AssertFalse(@"
                @:% (x) x * x * x;
                try { :% 3; ret false } catch { ret true }
            ");
        }

        [Test]
        public void CustomUnaryOperatorScopeTest7()
        {
            AssertTrue(@"
                foo = @{ @:% (x) x * x * x };
                foo();
                try { :% 3; ret false } catch { ret true }
            ");
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
