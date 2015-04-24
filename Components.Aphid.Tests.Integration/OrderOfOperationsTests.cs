using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidOrderOfOperations")]
    public class OrderOfOperationsTests : AphidTests
    {
        [Test]
        public void CallMemberTest()
        {
            AssertFoo("x = { y: @()'foo' }; ret x.y();");
        }

        [Test]
        public void CallMemberTest2()
        {
            AssertFoo("x = { y: { z: @()'foo' } }; ret x.y.z();");
        }

        [Test]
        public void CallPrecedenceTest()
        {
            AssertFoo("x = @()'f'; ret x() + 'oo';");
        }

        [Test]
        public void CallPrecedenceTest2()
        {
            AssertFoo("x = { y: @()'f' }; ret x.y() + 'oo';");
        }

        [Test]
        public void CallPrecedenceTest3()
        {
            AssertFoo("x = @()'oo'; ret 'f' + x();");
        }

        [Test]
        public void CallPrecedenceTest4()
        {
            AssertFoo("x = { y: @()'oo' }; ret 'f' + x.y();");
        }

        [Test]
        public void CallPrecedenceTest5()
        {
            AssertFoo("x = @()@()'foo'; ret x()();");
        }

        [Test]
        public void CallPrecedenceTest6()
        {
            AssertFoo("x = { y: @()@()'f' }; ret x.y()() + 'oo';");
        }

        [Test]
        public void CallPrecedenceTest7()
        {
            AssertFoo("x = { y: @()@()'oo' }; ret 'f' + x.y()();");
        }

        [Test]
        public void CallPrecedenceTest8()
        {
            AssertFoo("x = { y: @()@()'o' }; ret 'f' + x.y()() + 'o';");
        }

        [Test]
        public void CallPrecedenceTest9()
        {
            AssertFoo("x = { y: @(){ ret { a: @()'foo' }; } }; z = x.y().a(); ret z;");
        }

        [Test]
        public void CallPrecedenceTest10()
        {
            AssertFoo("x = { y: @(){ ret { a: @()'o' }; } }; ret 'f' + x.y().a() + 'o';");
        }

        [Test]
        public void CallPrecedenceTest11()
        {
            Assert9("#'Std'; ret range(2, 3).aggregate(@(x, y)x+y);");
        }

        [Test]
        public void OrderOfOperationsTest()
        {
            AssertEquals(7m, "ret 1+2*3;");
        }

        [Test]
        public void OrderOfOperationsTest2()
        {
            Assert9("ret (1+2)*3;");
        }

        [Test]
        public void OrderOfOperationsTest3()
        {
            Assert9("x={y:{a:1+2,b:3}}; ret x.y.a*x.y.b;");
        }

        [Test]
        public void OrderOfOperationsTest4()
        {
            Assert9("x={y:{a:1+2,b:3}}; ret 1+x.y.a*x.y.b-1;");
        }

        [Test]
        public void OrderOfOperationsTest5()
        {
            Assert9("x={y:{a:@()1+2,b:3}}; ret 1+x.y.a()*x.y.b-1;");
        }

        [Test]
        public void LogicalExpressionTest()
        {
            AssertTrue("ret !false && true;");
        }

        [Test]
        public void LogicalExpressionTest2()
        {
            AssertTrue("ret true && !false;");
        }

        [Test]
        public void LogicalExpressionTest3()
        {
            AssertTrue("ret !false && !false;");
        }

        [Test]
        public void LogicalExpressionTest4()
        {
            AssertTrue("ret true || false;");
        }

        [Test]
        public void LogicalExpressionTest5()
        {
            AssertTrue("ret false || true;");
        }

        [Test]
        public void LogicalExpressionTest6()
        {
            AssertTrue("ret !false || false;");
        }

        [Test]
        public void LogicalExpressionTest7()
        {
            AssertTrue("ret false || !false;");
        }

        [Test]
        public void LogicalExpressionTest8()
        {
            AssertTrue("ret !(false || false);");
        }

        [Test]
        public void LogicalExpressionTest9()
        {
            AssertTrue("ret !(true && false);");
        }
    }
}
