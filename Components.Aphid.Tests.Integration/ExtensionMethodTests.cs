using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidExtensionMethod")]
    public class ExtensionMethodTests : AphidTests
    {       
        [Test]
        public void ExtensionMethodTest()
        {
            Assert9(@"
                extend number {
                    square: @(l) l * l
                }

                x = 3;
                ret x.square();
            ");
        }

        [Test]
        public void ExtensionMethodTest2()
        {
            Assert9(@"
                extend number {
                    square: @(l) l * l
                }
                
                ret (3).square();
            ");
        }

        [Test]
        public void ExtensionMethodNumberTest()
        {
            Assert9("extend number{g:@(x)x}ret(9).g()");
        }

        [Test]
        public void ExtensionMethodNumberTest2()
        {
            Assert9("extend number{g:@(x)$_}ret(9).g()");
        }

        [Test]
        public void ExtensionMethodNumberTest3()
        {
            Assert9("extend number{g:@(x)$args[0]}ret(9).g()");
        }

        [Test]
        public void ExtensionMethodNumberTest4()
        {
            Assert9("extend number{g:@(x,y)x+y}ret(8).g(1)");
        }

        [Test]
        public void ExtensionMethodNumberTest5()
        {
            Assert9("extend number{g:@(x,y)$_+y}ret(8).g(1)");
        }

        [Test]
        public void ExtensionMethodNumberTest6()
        {
            Assert9("extend number{g:@(x,y)$args[0]+y}ret(8).g(1)");
        }

        [Test]
        public void ExtensionMethodNumberTest7()
        {
            Assert9("extend number{g:@(x,y)$_+$args[1]}ret(8).g(1)");
        }

        [Test]
        public void ExtensionMethodNumberTest8()
        {
            Assert9("extend number{g:@(x,y)$args[0]+$args[1]}ret(8).g(1)");
        }

        [Test]
        public void ExtensionMethodTestUnknown()
        {
            Assert9("extend unknown{g:@(x)9}ret 1.GetType().g()");
        }

        [Test]
        public void ExtensionMethodTestUnknown2()
        {
            Assert9("extend unknown{g:@(x)9}ret 1.Equals.g()");
        }

        [Test]
        public void ExtensionMethodTestUnknown3()
        {
            Assert9("extend unknown{g:@()9}ret 1.GetType().g()");
        }

        [Test]
        public void ExtensionMethodTestUnknown4()
        {
            Assert9("extend unknown{g:@()9}ret 1.Equals.g()");
        }

        [Test]
        public void ExtensionMethodTestUnknownSecondArg()
        {
            Assert9("extend unknown{g:@(x, y)y}ret 1.Equals.g(9)");
        }

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg()
        {
            AssertTrue(@"
                extend unknown{g:@(x)$_.ToString()=='Components.Aphid.Interpreter.AphidInteropMember'}
                ret 1.Equals.g(2)");
        }

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg2()
        {
            AssertTrue(@"
                extend unknown{g:@(x)$_.ToString()=='Components.Aphid.Interpreter.AphidInteropMember'}
                ret 1.Equals.g()");
        }

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg3()
        {
            AssertTrue(@"
                extend unknown{g:@()$_.ToString()=='Components.Aphid.Interpreter.AphidInteropMember'}
                ret 1.Equals.g()");
        }

        [Test]
        public void ExtensionMethodTestUnknownImplicitArgArray()
        {
            AssertTrue(@"
                extend unknown{g:@()$args[0].ToString()=='Components.Aphid.Interpreter.AphidInteropMember'}
                ret 1.Equals.g()");
        }

        [Test]
        public void ExtensionMethodInteropTest()
        {
            Assert9(@"
                using Components.Aphid.Parser;
                extend FunctionExpression {isFunc: @(o)9}
                ret @{@{ }}.Body[0].isFunc();
            ");
        }

        public void ExtensionMethodInteropTest(
            string targetType,
            string paramDecl = "o", 
            string paramRef = "o")
        {
            AssertTrue(@"
                #'Std';
                #'Meta';
                using Components.Aphid.Parser;
                using System;
                extend " + targetType + @" {" + 
                    @"isFunc: @(" + paramDecl + @")" + paramRef + @".GetType()" + 
                        @"==(FunctionExpression|>typeof)}
                ret @{@{ }}.Body[0].isFunc();
            ");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest()
        {
            ExtensionMethodInteropTest("FunctionExpression");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest2()
        {
            ExtensionMethodInteropTest("AphidExpression");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest3()
        {
            ExtensionMethodInteropTest("AphidNode");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest4()
        {
            ExtensionMethodInteropTest("Object");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest5()
        {
            ExtensionMethodInteropTest("FunctionExpression", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest6()
        {
            ExtensionMethodInteropTest("AphidExpression", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest7()
        {
            ExtensionMethodInteropTest("AphidNode", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest8()
        {
            ExtensionMethodInteropTest("Object", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest9()
        {
            ExtensionMethodInteropTest("FunctionExpression", "", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest10()
        {
            ExtensionMethodInteropTest("AphidExpression", "", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest11()
        {
            ExtensionMethodInteropTest("AphidNode", "", paramRef: "$_");
        }

        [Test]
        public void ExtensionMethodInteropInheritanceTest12()
        {
            ExtensionMethodInteropTest("Object", "", paramRef: "$_");
        }
    }
}
