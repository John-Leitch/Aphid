﻿using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidOrderOfOperations"), Parallelizable(ParallelScope.All)]
    public class OrderOfOperationsTests : AphidTests
    {
        [Test]
        public void CallMemberTest() =>
            AssertFoo("var x = { y: @()'foo' }; ret x.y();");

        [Test]
        public void CallMemberTest2() =>
            AssertFoo("var x = { y: { z: @()'foo' } }; ret x.y.z();");

        [Test]
        public void CallPrecedenceTest() =>
            AssertFoo("var x = @()'f'; ret x() + 'oo';");

        [Test]
        public void CallPrecedenceTest2() =>
            AssertFoo("var x = { y: @()'f' }; ret x.y() + 'oo';");

        [Test]
        public void CallPrecedenceTest3() =>
            AssertFoo("var x = @()'oo'; ret 'f' + x();");

        [Test]
        public void CallPrecedenceTest4() =>
            AssertFoo("var x = { y: @()'oo' }; ret 'f' + x.y();");

        [Test]
        public void CallPrecedenceTest5() =>
            AssertFoo("var x = @()@()'foo'; ret x()();");

        [Test]
        public void CallPrecedenceTest6() =>
            AssertFoo("var x = { y: @()@()'f' }; ret x.y()() + 'oo';");

        [Test]
        public void CallPrecedenceTest7() =>
            AssertFoo("var x = { y: @()@()'oo' }; ret 'f' + x.y()();");

        [Test]
        public void CallPrecedenceTest8() =>
            AssertFoo("var x = { y: @()@()'o' }; ret 'f' + x.y()() + 'o';");

        [Test]
        public void CallPrecedenceTest9() =>
            AssertFoo("var x = { y: @(){ ret { a: @()'foo' }; } }; var z = x.y().a(); ret z;");

        [Test]
        public void CallPrecedenceTest10() =>
            AssertFoo("var x = { y: @(){ ret { a: @()'o' }; } }; ret 'f' + x.y().a() + 'o';");

        [Test]
        public void CallPrecedenceTest11() =>
            Assert9("#'Std'; ret range(2, 3).aggregate(@(x, y)x+y);");

        [Test]
        public void OrderOfOperationsTest() =>
            AssertEquals(7m, "ret 1+2*3;");

        [Test]
        public void OrderOfOperationsTest2() =>
            Assert9("ret (1+2)*3;");

        [Test]
        public void OrderOfOperationsTest3() =>
            Assert9("var x={y:{a:1+2,b:3}}; ret x.y.a*x.y.b;");

        [Test]
        public void OrderOfOperationsTest4() =>
            Assert9("var x={y:{a:1+2,b:3}}; ret 1+x.y.a*x.y.b-1;");

        [Test]
        public void OrderOfOperationsTest5() =>
            Assert9("var x={y:{a:@()1+2,b:3}}; ret 1+x.y.a()*x.y.b-1;");

        [Test]
        public void LogicalExpressionTest() =>
            AssertTrue("ret !false && true;");

        [Test]
        public void LogicalExpressionTest2() =>
            AssertTrue("ret true && !false;");

        [Test]
        public void LogicalExpressionTest3() =>
            AssertTrue("ret !false && !false;");

        [Test]
        public void LogicalExpressionTest4() =>
            AssertTrue("ret true || false;");

        [Test]
        public void LogicalExpressionTest5() =>
            AssertTrue("ret false || true;");

        [Test]
        public void LogicalExpressionTest6() =>
            AssertTrue("ret !false || false;");

        [Test]
        public void LogicalExpressionTest7() =>
            AssertTrue("ret false || !false;");

        [Test]
        public void LogicalExpressionTest8() =>
            AssertTrue("ret !(false || false);");

        [Test]
        public void LogicalExpressionTest9() =>
            AssertTrue("ret !(true && false);");
    }
}
