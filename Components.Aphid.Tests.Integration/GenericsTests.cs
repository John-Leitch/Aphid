using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidGenerics"), Parallelizable(ParallelScope.All)]
    public class GenericsTests : AphidTests
    {
        [Test]
        public void EnumerableRangeCountTest()
        {
            Assert9(@"
                using System.Linq;

                ret Enumerable.Range(0, 9) |> Enumerable.Count;
            ");
        }

        [Test]
        public void EnumerableRangeLastTest()
        {
            Assert9(@"
                using System.Linq;

                ret Enumerable.Range(0, 10) |> Enumerable.Last;
            ");
        }

        [Test]
        public void EnumerableAphidListFirstTest()
        {
            AssertFoo(@"
                using System.Linq;

                ret [ 'foo', 'bar', 'a', 'b' ] |> Enumerable.First;
            ");
        }
        
        [Test]
        public void EnumerableAphidListLastTest()
        {
            AssertFoo(@"
                using System.Linq;

                ret [ 'bar', 'a', 'b', 'foo' ] |> Enumerable.Last;
            ");
        }

        [Test]
        public void EnumerableAphidListSkipFirstTest()
        {
            AssertFoo(@"
                using System.Linq;
                
                ret Enumerable.Skip([ 'bar', 'a', 'foo', 'b' ], 2)
                    |> Enumerable.First;
            ");
        }

        [Test]
        public void EnumerableAphidListSkipFirstTest2()
        {
            Assert9(@"
                using System.Linq;
                
                ret Enumerable.Skip([ 0, 1, 9, 10 ], 2)
                    |> Enumerable.First;
            ");
        }

        [Test]
        public void EnumerableAphidListTakeLastTest()
        {
            AssertFoo(@"
                using System.Linq;
                
                ret Enumerable.Take([ 'bar', 'a', 'foo', 'b' ], 3)
                    |> Enumerable.Last;
            ");
        }

        [Test]
        public void EnumerableAphidListTakeLastTest2()
        {
            Assert9(@"
                using System.Linq;
                
                ret Enumerable.Take([ 0, 1, 9, 10 ], 3)
                    |> Enumerable.Last;
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualTest()
        {
            AssertTrue(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 3], [1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualTest2()
        {
            AssertFalse(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 4], [1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualTest3()
        {
            AssertFalse(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 3, 2], [1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialImplicitPipeTest()
        {
            AssertTrue(@"
                using System.Linq;

                ret [1, 2, 3] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialImplicitPipeTest2()
        {
            AssertFalse(@"
                using System.Linq;

                ret [1, 2, 4] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialImplicitPipeTest3()
        {
            AssertFalse(@"
                using System.Linq;

                ret [1, 2, 3, 4] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialPipeTest()
        {
            AssertTrue(@"
                using System.Linq;
                var p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 3] |> p;
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialPipeTest2()
        {
            AssertFalse(@"
                using System.Linq;
                var p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 4] |> p;
            ");
        }

        [Test]
        public void EnumerableAphidListSequenceEqualPartialPipeTest3()
        {
            AssertFalse(@"
                using System.Linq;
                var p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 3, 4] |> p;
            ");
        }

        [Test]
        public void EnumerableAphidListSelectTest()
        {
            AssertCollectionIs(
                @"using System.Linq; ret Enumerable.Select(0..3, @(x) x * x)",
                0,
                1,
                4);
        }

        [Test]
        public void EnumerableAphidListWhereTest()
        {
            Assert9(@"
                using System.Linq;
                ret Enumerable.Where(0..18, @(x)(x&1)==0) |> Enumerable.Count;
            ");
        }

        [Test]
        public void EnumerableAphidListWherePartialPipeTest()
        {
            Assert9(@"
                using System.Linq;
                ret (@(x)(x&1)==0) @Enumerable.Where(0..18) |> Enumerable.Count;
            ");
        }

        [Test]
        public void EnumerableAphidListFirstPredicateTest()
        {
            Assert9(@"using System.Linq; ret Enumerable.First([ 2, 4, 9, 3, 5 ], @(x)(x&1)==1);");
        }

        [Test]
        public void EnumerableAphidListFirstPredicateImplicitArgTest()
        {
            Assert9(@"using System.Linq; ret Enumerable.First([ 2, 4, 9, 3, 5 ], @()($_&1)==1);");
        }

        [Test]
        public void EnumerableAphidListFirstPredicateImplicitArgFailTest()
        {
            AllFail(
                () => Assert9(@"using System.Linq;ret Enumerable.First([2,4,9,3,5],@(x)(x&1)==0);"),
                () => Assert9(@"using System.Linq;ret Enumerable.First([2,4,9,3,5],@()($_&1)==0);"));
        }

        [Test]
        public void EnumerableAphidListOrderByTest()
        {
            AssertFoo(@"
                using System.Linq;
                ret Enumerable.OrderBy(['hello world', 'foo', 'test 1234'], @() $_.Length)
                    |> Enumerable.First;
            ");
        }
    }
}
