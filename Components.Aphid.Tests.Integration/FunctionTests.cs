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

        [Test]
        public void PartialFunctionTest2()
        {
            Assert9("add=@(x, y)x+y; ret 5 |> @add(4);");
        }

        [Test]
        public void PartialFunctionTest3()
        {
            Assert9("add=@(x, y)x+y; ret 4 |> @add(2) |> @add(3);");
        }

        [Test]
        public void FunctionCompositionTest()
        {
            Assert9(@"
                square= @(x) x * x;
                sub7= @(x) x - 7;
                f = square @> sub7;
                ret f(4);
            ");
        }

        [Test]
        public void FunctionCompositionTest2()
        {
            Assert9(@"
                square = @(x) x * x;
                sub7 = @- 7;
                f = square @> sub7;
                ret f(4);
            ");
        }

        [Test]
        public void FunctionCompositionTest3()
        {
            Assert9(@"
                square = @(x) x * x;
                sub8 = @- 8;
                add1 = @(x) x + 1;
                f = square @> sub8 @> add1;
                ret f(4);
            ");
        }

        [Test]
        public void FunctionCompositionTest4()
        {
            Assert9(@"
                square = @(x) x * x;
                sub8 = @- 8;
                add1 = @+ 1;
                f = square @> sub8 @> add1;
                ret f(4);
            ");
        }

        [Test]
        public void FunctionCompositionTest5()
        {
            Assert9(@"
                square = @(x) x * x;
                add1 = @+ 1;
                f = square @> (@- 8) @> add1;
                ret f(4);
            ");
        }

        [Test]
        public void FunctionCompositionTest6()
        {
            Assert9(@"ret ((@(x) x * x) @> @- 7)(4); ");
        }

        [Test]
        public void FunctionCompositionTest7()
        {
            Assert9(@"ret ((@(x) x * x) @> (@-8) @> (@+1))(4);");
        }

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
        public void ImplicitArgumentTest()
        {
            Assert9(@"
                square = @{ ret $_ * $_ };
                
                ret 3 |> square;
            ");
        }

        [Test]
        public void ImplicitArgumentTest2()
        {
            Assert9(@"
                square = @() $_ * $_;
                
                ret 3 |> square;
            ");
        }

        [Test]
        public void ImplicitArgumentTest3()
        {
            Assert9(@"ret 3 |> @() $_ * $_;");
        }

        [Test]
        public void ImplicitArgumentsTest()
        {
            Assert9(@"
                foo = @{ ret $args[0]; };
                
                ret foo(9, 0, 0, 0);
            ");
        }

        [Test]
        public void ImplicitArgumentsTest2()
        {
            Assert9(@"
                foo = @{ ret $args[2]; };
                
                ret foo(0, 0, 9, 0);
            ");
        }

        [Test]
        public void ImplicitArgumentsTest3()
        {
            AssertFoo(@"
                foo = @{ ret $args[2]; };
                
                ret foo(0, 0, 'foo', 0);
            ");
        }

        [Test]
        public void ImplicitArgumentsTest4()
        {
            Assert9(@"
                foo = @() $args[0];
                
                ret foo(9, 0, 0, 0);
            ");
        }

        [Test]
        public void ImplicitArgumentsTest5()
        {
            Assert9(@"
                foo = @() $args[2];
                
                ret foo(0, 0, 9, 0);
            ");
        }
    }
}
