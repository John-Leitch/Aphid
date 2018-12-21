using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    /// <summary>
    /// Todo: Add class tests for lists and arrays.
    /// </summary>
    [TestFixture(Category = "AphidIndex"), Parallelizable(ParallelScope.All)]
    public class IndexTests : AphidTests
    {
        [Test]
        public void TestListIndexGet()
        {
            AssertExpFoo(@"[ 'foo' ][0]");
        }

        [Test]
        public void TestListIndexGet2()
        {
            AssertExp9(@"[ 9 ][0]");
        }

        [Test]
        public void TestListIndexGet3()
        {
            AssertExpFoo(@"[ 'bar', 'foo' ][1]");
        }

        [Test]
        public void TestListIndexGet4()
        {
            AssertExp9(@"[ 1, 9 ][1]");
        }

        [Test]
        public void TestListIndexGet5()
        {
            AssertExpFoo(@"[ 9, 'foo' ][1]");
        }

        [Test]
        public void TestListIndexGet6()
        {
            AssertExp9(@"[ 'foo', 9 ][1]");
        }

        [Test]
        public void TestListIndexSetGet()
        {
            AssertFoo(@"var x = [ 'bar' ]; x[0] = 'foo'; ret x[0]");
        }

        [Test]
        public void TestListIndexSetGet2()
        {
            AssertFoo(@"var x = [ 'bar' ]; ret x[0] = 'foo'");
        }

        [Test]
        public void TestListIndexSetGet3()
        {
            AssertFoo(@"var x = [ 'bar' ]; x[0] = 'fo'; x[0] += 'o'; ret x[0]");
        }

        [Test]
        public void TestListIndexSetGet4()
        {
            AssertFoo(@"var x = [ 'bar' ]; x[0] = 'fo'; ret x[0] += 'o'");
        }

        [Test]
        public void TestListIndexSetGet5()
        {
            AssertFoo(@"var x = [ '', 'o' ]; x[0] = 'fo'; ret x[0] + x[1]");
        }

        [Test]
        public void TestListIndexSetGet6()
        {
            AssertFoo(@"var x = [ '', '' ]; x[0] = 'fo'; ret x[0] + (x[1] += 'o')");
        }

        [Test]
        public void TestArrayIndexGet()
        {
            ArrayAssertEquals<byte>(0, 0x1, "ret a[0x0]");
        }

        [Test]
        public void TestArrayIndexGet2()
        {
            ArrayAssertEquals<byte>(0, 0x2, "ret a[0x1]");
        }

        [Test]
        public void TestArrayIndexGet3()
        {
            ArrayAssertEquals<byte>(0, 0x10, "ret a[0xf]");
        }

        [Test]
        public void TestArrayIndexGet4()
        {
            ArrayAssertEquals<string>(null, 0x10, "ret a[0x0]");
        }

        [Test]
        public void TestArrayIndexGet5()
        {
            ArrayAssertEquals<string>(null, 0x10, "ret a[0xf]");
        }

        [Test]
        public void TestArrayIndexSetGet()
        {
            ArrayAssert9<byte>(0x1, "a[0x0] = 0x9; ret a[0x0]");
        }

        [Test]
        public void TestArrayIndexSetGet2()
        {
            ArrayAssert9<byte>(0x2, "a[0x0] = 0x9; ret a[0x0]");
        }

        [Test]
        public void TestArrayIndexSetGet3()
        {
            ArrayAssert9<byte>(0x2, "a[0x1] = 0x9; ret a[0x1]");
        }

        [Test]
        public void TestArrayIndexSetGet4()
        {
            ArrayAssert9<byte>(0x100000, "a[0xfffff] = 0x9; ret a[0xfffff]");
        }

        [Test]
        public void TestArrayIndexSetGet5()
        {
            ArrayAssert9<byte>(0x100000, "a[0x100000-0x1] = 0x9; ret a[0xfffff]");
        }

        [Test]
        public void TestArrayIndexSetGet6()
        {
            ArrayAssert9<byte>(0x100000, "a[0xfffff] = 0x9; ret a[0x100000-0x1]");
        }

        [Test]
        public void TestArrayIndexSetGet7()
        {
            ArrayAssert9<byte>(0x100000, "a[0x100000-0x1] = 0x9; ret a[0x100000-0x1]");
        }

        [Test]
        public void TestArrayIndexSetGet8()
        {
            ArrayAssertFoo<string>(0x1, "a[0x0] = 'foo'; ret a[0x0]");
        }

        [Test]
        public void TestArrayIndexSetGet9()
        {
            ArrayAssertFoo<string>(0x2, "a[0x0] = 'fo'; a[0x1] = 'o'; ret a[0x0] + a[0x1]");
        }

        [Test]
        public void TestArrayIndexSetAggregate()
        {
            ArrayAssertFoo<string>(
                0x2,
                "a[0x0] = 'fo'; a[0x1] = 'o'; ret a+>@(x, y) x + y");
        }

        [Test]
        public void TestArrayIndexSetAggregate2()
        {
            ArrayAssertFoo<string>(
                0x3,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; ret a+>@(x, y) x + y");
        }

        [Test]
        public void TestArrayIndexSetAggregate3()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@(x, y) x + y");
        }

        [Test]
        public void TestArrayIndexSetAggregate4()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@(x, y) $args[0] + $args[1]");
        }

        [Test]
        public void TestArrayIndexSetAggregate5()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@(x, y) $_ + $args[1]");
        }

        [Test]
        public void TestArrayIndexSetAggregate6()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@() $args[0] + $args[1]");
        }

        [Test]
        public void TestArrayIndexSetAggregate7()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@{ ret $args[0] + $args[1] }");
        }

        [Test]
        public void TestArrayIndexSetAggregate8()
        {
            ArrayAssertFoo<string>(
                0x4,
                "a[0x0]='f'; a[0x1]='o'; a[0x2]='o'; a[0x3]=''; ret a+>@+$args[1]");
        }

        [Test]
        public void TestArrayOutOfBounds()
        {
            ArrayAssert9<byte>(0x0, "try { a[0x0] } catch { ret 9 }  ret 0");
        }

        [Test]
        public void TestArrayOutOfBounds2()
        {
            ArrayAssert9<byte>(0x1, "try { a[0x1] } catch { ret 9 } ret 0");
        }

        [Test]
        public void TestArrayOutOfBounds3()
        {
            ArrayAssert9<byte>(0x100, "try { a[0x101] } catch { ret 9 }  ret 0");
        }

        [Test]
        public void TestArrayTypeCoercion()
        {
            ArrayAssert9<byte>(0x1, "try { a[0x0] = 0xff } catch { ret 0 }  ret 9");
        }

        [Test]
        public void TestArrayTypeCoercion2()
        {
            ArrayAssert9<ushort>(0x1, "try { a[0x0] = 0xffff } catch { ret 0 }  ret 9");
        }

        [Test]
        public void TestArrayTypeCoercion3()
        {
            ArrayAssert9<uint>(0x1, "try { a[0x0] = 0xffffffff } catch { ret 0 }  ret 9");
        }

        [Test]
        public void TestArrayTypeCoercion4()
        {
            ArrayAssert9<ulong>(0x1, "try { a[0x0] = 0xffffffffffffffff } catch { ret 0 }  ret 9");
        }

        [Test]
        public void TestArrayTypeCoercion5()
        {
            ArrayAssert9<byte>(0x1, "try { a[0x0] = 0x100 } catch { ret 9 }  ret 0");
        }

        [Test]
        public void TestArrayTypeCoercion6()
        {
            ArrayAssert9<ushort>(0x1, "try { a[0x0] = 0x10000 } catch { ret 9 }  ret 0");
        }

        [Test]
        public void TestArrayTypeCoercion7()
        {
            ArrayAssert9<uint>(0x1, "try { a[0x0] = 0x100000000 } catch { ret 9 }  ret 0");
        }

        ////////////////////////////////////////////////////////////////
        // Todo: Fix ulong hex parsing bug.
        ////////////////////////////////////////////////////////////////
        [Test, Ignore("Not yet supported.")]
        public void TestArrayTypeCoercion8()
        {
            ArrayAssert9<ulong>(0x1, "try { a[0x0] = 0x10000000000000000 } catch { ret 9 }  ret 0");
        }

        private void ArrayAssert9<TElement>(int size, string script)
        {
            AssertEquals(9, GetArrayScript<TElement>(size, script));
        }

        private void ArrayAssertFoo<TElement>(int size, string script)
        {
            AssertEquals("foo", GetArrayScript<TElement>(size, script));
        }

        private void ArrayAssertEquals<TElement>(object expected, int size, string script)
        {
            AssertEquals(expected, GetArrayScript<TElement>(size, script));
        }

        private string GetArrayScript<TElement>(int size, string script)
        {
            return string.Format(
                "#'Std';\r\n" +
                "var a = Array.CreateInstance({0}, {1});\r\n" +
                "{2}",
                typeof(TElement).Name,
                size,
                script);
        }
    }
}
