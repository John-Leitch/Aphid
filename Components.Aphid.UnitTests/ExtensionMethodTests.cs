using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidExtensionMethod"), Parallelizable(ParallelScope.All)]
    public class ExtensionMethodTests : AphidTests
    {
        [Test]
        public void ExtensionMethodTest() =>
            Assert9(@"
                extend number {
                    square: @(l) l * l
                }

                var x = 3;
                ret x.square();
            ");

        [Test]
        public void ExtensionMethodTest2() =>
            Assert9(@"
                extend number {
                    square: @(l) l * l
                }
                
                ret (3).square();
            ");

        [Test]
        public void ExtensionMethodNumberTest() =>
            Assert9("extend number{g:@(x)x}ret(9).g()");

        [Test]
        public void ExtensionMethodNumberTest2() =>
            Assert9("extend number{g:@(x)$_}ret(9).g()");

        [Test]
        public void ExtensionMethodNumberTest3() =>
            Assert9("extend number{g:@(x)$args[0]}ret(9).g()");

        [Test]
        public void ExtensionMethodNumberTest4() =>
            Assert9("extend number{g:@(x,y)x+y}ret(8).g(1)");

        [Test]
        public void ExtensionMethodNumberTest5() =>
            Assert9("extend number{g:@(x,y)$_+y}ret(8).g(1)");

        [Test]
        public void ExtensionMethodNumberTest6() =>
            Assert9("extend number{g:@(x,y)$args[0]+y}ret(8).g(1)");

        [Test]
        public void ExtensionMethodNumberTest7() =>
            Assert9("extend number{g:@(x,y)$_+$args[1]}ret(8).g(1)");

        [Test]
        public void ExtensionMethodNumberTest8() =>
            Assert9("extend number{g:@(x,y)$args[0]+$args[1]}ret(8).g(1)");

        [Test]
        public void ExtensionMethodGenericTest() =>
            Assert9(@"
                #'Std';
                using Components.Aphid.Parser;
                extend list AphidExpression {
                    whereId: @(l, id) id defined ?
                        l-?@(x) x.isId() && x.id() == id :
                        l-?@(x) x.isId(),

                    singleId: @(l, id) {
                        matches = l-?@(x) x.isId() && x.id() == id;


                        if ((matches -# @() true) != 1) {
                            fatal('Expected single expression with id ""{0}"".', id);
                        }

                        ret matches[0];
                    },
                }

                var b = @{ a; b; c; d; e; f; g; h; i; };
                ret b.Body.whereId() -# @() true;
            ");

        [Test]
        public void ExtensionMethodGenericTest2() =>
            Assert9(@"
                #'Std';
                using Components.Aphid.Parser;
                extend list AphidExpression {
                    whereId: @(l, id) id defined ?
                        l-?@(x) x.isId() && x.id() == id :
                        l-?@(x) x.isId(),

                    singleId: @(l, id) {
                        matches = l-?@(x) x.isId() && x.id() == id;


                        if ((matches -# @() true) != 1) {
                            fatal('Expected single expression with id ""{0}"".', id);
                        }

                        ret matches[0];
                    },
                }

                var b = @{ 'foo'; a; b; c; d; e; f; g; h; i; 'bar'; };
                ret b.Body.whereId() -# @() true;
            ");

        [Test]
        public void ExtensionMethodGenericTest3() =>
            AssertFalse(@"
                #'Std';
                using Components.Aphid.Parser;
                extend list AphidExpression {
                    whereId: @(l, id) id defined ?
                        l-?@(x) x.isId() && x.id() == id :
                        l-?@(x) x.isId(),

                    singleId: @(l, id) {
                        matches = l-?@(x) x.isId() && x.id() == id;


                        if ((matches -# @() true) != 1) {
                            fatal('Expected single expression with id ""{0}"".', id);
                        }

                        ret matches[0];
                    },
                }

                var b = @{ a; b; c; d; e; f; g; h; i; };
                ret (b.Body.whereId() -# @() true) == 8;
            ");

        [Test]
        public void ExtensionMethodGenericTest4() =>
            AssertFalse(@"
                #'Std';
                using Components.Aphid.Parser;
                extend list AphidExpression {
                    whereId: @(l, id) id defined ?
                        l-?@(x) x.isId() && x.id() == id :
                        l-?@(x) x.isId(),

                    singleId: @(l, id) {
                        matches = l-?@(x) x.isId() && x.id() == id;


                        if ((matches -# @() true) != 1) {
                            fatal('Expected single expression with id ""{0}"".', id);
                        }

                        ret matches[0];
                    },
                }

                var b = @{ 'foo'; a; b; c; d; e; f; g; h; i; 'bar'; };
                ret (b.Body.whereId() -# @() true) == 8;
            ");

        [Test]
        public void ExtensionMethodGenericTestFault() =>
            AssertFalse(@"
                #'Std';
                try {
                    extend list AphidExpressiona {
                        whereId: @(l, id) id defined ?
                            l-?@(x) x.isId() && x.id() == id :
                            l-?@(x) x.isId(),
                    }

                    ret true;
                } catch (e) {
                    ret false;
                }
            ");

        [Test]
        public void ExtensionMethodGenericTestFault2() =>
            AssertFalse(@"
                #'Std';
                try {
                    extend list list AphidExpression {
                        whereId: @(l, id) id defined ?
                            l-?@(x) x.isId() && x.id() == id :
                            l-?@(x) x.isId(),
                    }

                    ret true;
                } catch (e) {
                    ret false;
                }
            ");

        [Test]
        public void ExtensionMethodGenericTestFault3() =>
            AssertFalse(@"
                try {
                    extend AphidExpressiona {
                        whereId: @(l, id) id defined ?
                            l-?@(x) x.isId() && x.id() == id :
                            l-?@(x) x.isId(),
                    }

                    ret true;
                } catch (e) {
                    ret false;
                }
            ");

        //Todo: Add alias tests using SuiteAttribute.
        [Test]
        public void ExtensionMethodCSStyleDecimalAliasTest8() =>
            Assert9("using System; extend decimal{g:@(x,y)$args[0]+$args[1]}ret(8).g(1)");

        //public void ExtensionMethodNumberCore([CallerMemberName] string name = null)
        //{

        //    string t;

        //    if (name.Contains("CSStyleDecimalAlias"))
        //    {
        //        t = "decimal";
        //    }
        //    else if (name.StartsWith("ExtensionMethodNumberTest"))
        //    {
        //        t = "number";
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Invalid caller name: {0}", name);
        //    }


        //    Assert9("extend {0}{{g:@(x,y)$args[0]+$args[1]}}ret(8).g(1)", t);
        //}

        [Test]
        public void ExtensionMethodTestUnknown() =>
            Assert9("extend unknown{g:@(x)9}ret 1.GetType().g()");

        [Test]
        public void ExtensionMethodTestUnknown2() =>
            Assert9("extend unknown{g:@(x)9}ret 1.Equals.g()");

        [Test]
        public void ExtensionMethodTestUnknown3() =>
            Assert9("extend unknown{g:@()9}ret 1.GetType().g()");

        [Test]
        public void ExtensionMethodTestUnknown4() =>
            Assert9("extend unknown{g:@()9}ret 1.Equals.g()");

        [Test]
        public void ExtensionMethodTestUnknownSecondArg() =>
            Assert9("extend unknown{g:@(x, y)y}ret 1.Equals.g(9)");

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg() =>
            AssertTrue(@"
                extend unknown{g:@(x)$_.ToString()=='Components.Aphid.TypeSystem.AphidInteropMember'}
                ret 1.Equals.g(2)");

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg2() =>
            AssertTrue(@"
                extend unknown{g:@(x)$_.ToString()=='Components.Aphid.TypeSystem.AphidInteropMember'}
                ret 1.Equals.g()");

        [Test]
        public void ExtensionMethodTestUnknownImplicitArg3() =>
            AssertTrue(@"
                extend unknown{g:@()$_.ToString()=='Components.Aphid.TypeSystem.AphidInteropMember'}
                ret 1.Equals.g()");

        [Test]
        public void ExtensionMethodTestUnknownImplicitArgArray() =>
            AssertTrue(@"
                extend unknown{g:@()$args[0].ToString()=='Components.Aphid.TypeSystem.AphidInteropMember'}
                ret 1.Equals.g()");

        [Test]
        public void ExtensionMethodInteropTest() =>
            Assert9(@"
                using Components.Aphid.Parser;
                extend FunctionExpression {isFunc: @(o)9}
                ret @{@{ }}.Body[0].isFunc();
            ");

        public void ExtensionMethodInteropTest(
            string targetType,
            string paramDecl = "o",
            string paramRef = "o") =>
            AssertTrue(@"
                #'Meta';
                using Components.Aphid.Parser;
                using System;
                extend " + targetType + @" {" +
                    @"isFunc: @(" + paramDecl + @")" + paramRef + @".GetType()" +
                        @"== FunctionExpression}
                ret @{@{ }}.Body[0].isFunc();
            ");

        [Test]
        public void ExtensionMethodInteropInheritanceTest() => ExtensionMethodInteropTest("FunctionExpression");

        [Test]
        public void ExtensionMethodInteropInheritanceTest2() => ExtensionMethodInteropTest("AphidExpression");

        [Test]
        public void ExtensionMethodInteropInheritanceTest3() => ExtensionMethodInteropTest("AphidNode");

        [Test]
        public void ExtensionMethodInteropInheritanceTest4() => ExtensionMethodInteropTest("Object");

        [Test]
        public void ExtensionMethodInteropInheritanceTest5() => ExtensionMethodInteropTest("FunctionExpression", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest6() => ExtensionMethodInteropTest("AphidExpression", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest7() => ExtensionMethodInteropTest("AphidNode", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest8() => ExtensionMethodInteropTest("Object", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest9() => ExtensionMethodInteropTest("FunctionExpression", "", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest10() => ExtensionMethodInteropTest("AphidExpression", "", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest11() => ExtensionMethodInteropTest("AphidNode", "", paramRef: "$_");

        [Test]
        public void ExtensionMethodInteropInheritanceTest12() => ExtensionMethodInteropTest("Object", "", paramRef: "$_");

        [Test]
        public void DynamicExtensionMethodTest() =>
            AssertFoo(@"
                using System;
                extend string {
                    dynamic handle: @(s, funcName) funcName,
                }

                ret 'abc'.foo();
            ");

        [Test]
        public void DynamicExtensionMethodTest2() =>
            AssertFoo(@"
                using System;
                extend string {
                    dynamic handle: @(s, funcName) funcName + 'oo',
                }

                ret 'abc'.f();
            ");

        [Test]
        public void DynamicExtensionMethodTest3() =>
            AssertFoo(@"
                using System;
                extend string {
                    dynamic handle: @(s, funcName) s + funcName * 2,
                }

                ret 'f'.o();
            ");

        [Test]
        public void DynamicExtensionMethodInheritance() =>
            Assert9(@"
                using Components.Aphid.Parser;
                extend FunctionExpression {dynamic isFunc: @(o)9}
                ret @{@{ }}.Body[0].aaa();
            ");

        [Test]
        public void DynamicExtensionMethodInheritance2() =>
            Assert9(@"
                using Components.Aphid.Parser;
                extend AphidExpression {dynamic isFunc: @(o)9}
                ret @{@{ }}.Body[0].aaa();
            ");

        [Test, Ignore("Not yet supported.")]
        public void StaticExtensionMethodDefinedTest() =>
            AssertTrue(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt /*...*/) 9,
                }

                ret Cli.Return defined;
            ");

        [Test, Ignore("Not yet supported.")]
        public void StaticExtensionMethodNotDefinedTest() =>
            AssertTrue(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return2: @(fmt /*...*/) 9,
                }

                ret Cli.Return defined;
            ");

        [Test]
        public void StaticExtensionMethodTest() =>
            Assert9(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt /*...*/) 9,
                }

                ret Cli.Return();
            ");

        [Test]
        public void StaticExtensionMethodTest2() =>
            Assert9(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt, a, b, c, d /*...*/) 8 + b,
                }

                ret Cli.Return(2, 4, 1, 12);
            ");

        [Test]
        public void StaticExtensionMethodTest3() =>
            AssertFalse(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt, a, b, c, d /*...*/) 8 + a,
                }

                ret Cli.Return(2, 4, 1, 12) == 9;
            ");

        [Test]
        public void StaticExtensionMethodRefTest() =>
            Assert9(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt, a, b, c, d /*...*/) 8 + b,
                }

                var f = Cli.Return;

                ret f(2, 4, 1, 12);
            ");

        [Test]
        public void StaticExtensionMethodRefTest2() =>
            Assert9(@"
                using Components.External.ConsolePlus;

                extend Cli {
                    Return: @(fmt, a, b, c, d /*...*/) 8 + b,
                }

                var f = Cli.Return;
                var x = f;

                ret x(2, 4, 1, 12);
            ");
    }
}
