using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidScope")]
    public class ScopeTests : AphidTests
    {
        [Test]
        public void ClosureGetTest()
        {
            AssertFoo("x='foo'; test=@(){ret x;}; ret test();");
        }

        [Test]
        public void ClosureGetTest2()
        {
            AssertFoo("x='foo'; test=@()x; ret test();");
        }

        [Test]
        public void ClosureSetTest()
        {
            AssertFoo("x='bar'; test=@(){x='foo';}; test(); ret x;");
        }

        [Test]
        public void ClosureSetTest2()
        {
            AssertFoo("x='foo'; test=@(){x='bar';}; ret x;");
        }

        [Test]
        public void ClosureSetTest3()
        {
            AssertFoo("x='bar'; test=@()x='foo'; test(); ret x;");
        }

        [Test]
        public void ClosureSetTest4()
        {
            AssertFoo("x='foo'; test=@()x='bar'; ret x;");
        }

        [Test]
        public void ClosureGetSetTest()
        {
            AssertFoo("x=''; test=@(){ x = 'foo'; }; test2=@(){ ret x; }; test(); ret test2();");
        }

        [Test]
        public void ClosureGetSetTest2()
        {
            AssertFoo("x=''; test=@(){ test2=@(){ x = 'foo'; }; test2(); ret x; }; ret test();");
        }

        [Test]
        public void ScopeTest()
        {
            AssertFalse("test=@(){x='foo'; ret x;}; test(); ret x defined;");
        }

        [Test]
        public void ScopeTest2()
        {
            AssertFalse("test=@()x='foo'; test(); ret x defined;");
        }

        [Test]
        public void ScopeTest3()
        {
            AssertTrue("x='foo'; ret x defined;");
        }

        [Test]
        public void ScopeTest4()
        {
            AssertFalse("if (true) { x = 1; } ret x defined;");
        }

        [Test]
        public void ScopeTest5()
        {
            AssertTrue("x = 0; if (true) { x = 1; } ret x defined;");
        }

        [Test]
        public void ScopeTest6()
        {
            Assert9("x={y:0}; if (true) { x.y = 9; } ret x.y;");
        }

        [Test]
        public void ObjectMemberScopeTest()
        {
            Assert9("x=1;o={x:9,f:@()x};ret o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest2()
        {
            Assert9("x=1;o={x:9,o2:{f:@()x}};ret o.o2.f()");
        }

        [Test]
        public void ObjectMemberScopeTest3()
        {
            Assert9("x=1;o={x:9,o2:{o3:{f:@()x}}};ret o.o2.o3.f()");
        }

        [Test]
        public void ObjectMemberScopeTest4()
        {
            Assert9("x=1;o={x:9,o:{o:{f:@()x}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest5()
        {
            Assert9("x=1;o={x:9,o:{o:{f:@()this.x}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest6()
        {
            Assert9("y=9;o={x:1,o:{o:{f:@()y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest7()
        {
            Assert9("y=9;o={x:1,o:{o:{f:@()this.y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest8()
        {
            Assert9("y=8;o={x:1,o:{o:{f:@()x+y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest9()
        {
            Assert9("y=8;o={x:1,o:{o:{f:@()this.x+y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest10()
        {
            Assert9("y=8;o={x:1,o:{o:{f:@()x+this.y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest11()
        {
            Assert9("y=8;o={x:1,o:{o:{f:@()this.x+this.y}}};ret o.o.o.f()");
        }

        [Test]
        public void ObjectMemberScopeTest12()
        {
            Assert9("y=8;o={x:1,o2:{o:{o2:{f:@()this.x+this.y}}}};ret o.o2.o.o2.f()");
        }

        [Test]
        public void ObjectMemberScopeTest13()
        {
            Assert9("y=8;o={x:1,o2:{o:{o2:{f:@()this.x+this.y}}}};ret this.o.o2.o.o2.f()");
        }

        [Test]
        public void ObjectMemberScopeTest14()
        {
            Assert9("y=11;o={x:1,o2:{o:{o2:{f:@(y)this.x+this.y}}}};ret this.o.o2.o.o2.f(8)");
        }

        [Test]
        public void AssignScopeTest()
        {
            Assert9("y=9;f=@()9;ret f()");
        }

        [Test]
        public void AssignScopeTest2()
        {
            Assert9("y=11;o={y:9};o.f=@()9;ret o.f()");
        }

        [Test]
        public void AssignScopeTest3()
        {
            Assert9("y=11;o={y:9};o.f=@()y;ret o.f()");
        }

        [Test]
        public void AssignScopeTest4()
        {
            Assert9("y=11;o={y:9};o.f=@()this.y;ret o.f()");
        }

        [Test]
        public void AssignScopeTest5()
        {
            Assert9("y=11;o={o2:{y:9}};o.o2.f=@()this.y;ret o.o2.f()");
        }

        [Test]
        public void AssignScopeTest6()
        {
            Assert9("y=11;o={o2:{},y:9};o.o2.f=@()this.y;ret o.o2.f()");
        }

        [Test]
        public void ReassignScopeTest()
        {
            Assert9("y=11;o={f:null,y:9};o.f=@()this.y;ret o.f()");
        }

        [Test]
        public void ReassignScopeTest2()
        {
            Assert9("y=11;o={f:null,y:9};o.f=null;o.f=@()this.y;ret o.f()");
        }

        [Test]
        public void ReassignScopeTest3()
        {
            Assert9("y=11;o={o2:{},y:9};o.o2.f=null;o.o2.f=@()this.y;ret o.o2.f()");
        }

        [Test]
        public void VariableDeclarationTest()
        {
            AssertTrue("x; ret x defined;");
        }
    }
}
