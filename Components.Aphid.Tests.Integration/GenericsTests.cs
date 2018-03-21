using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidGenerics"), Parallelizable(ParallelScope.Self)]
    public class GenericsTests : AphidTests
    {
        [Test]
        public void GenericTest1()
        {
            Assert9(@"
                using System.Linq;

                ret Enumerable.Range(0, 9) |> Enumerable.Count;
            ");
        }

        [Test]
        public void GenericTest2()
        {
            Assert9(@"
                using System.Linq;

                ret Enumerable.Range(0, 10) |> Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest3()
        {
            AssertFoo(@"
                using System.Linq;

                ret [ 'foo', 'bar', 'a', 'b' ] |> Enumerable.First;
            ");
        }
        
        [Test]
        public void GenericTest4()
        {
            AssertFoo(@"
                using System.Linq;

                ret [ 'bar', 'a', 'b', 'foo' ] |> Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest5()
        {
            AssertFoo(@"
                using System.Linq;
                
                ret Enumerable.Skip([ 'bar', 'a', 'foo', 'b' ], 2)
                    |> Enumerable.First;
            ");
        }

        [Test]
        public void GenericTest6()
        {
            AssertFoo(@"
                using System.Linq;
                
                ret Enumerable.Take([ 'bar', 'a', 'foo', 'b' ], 3)
                    |> Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest7()
        {
            Assert9(@"
                using System.Linq;
                
                ret Enumerable.Skip([ 0, 1, 9, 10 ], 2)
                    |> Enumerable.First;
            ");
        }

        [Test]
        public void GenericTest8()
        {
            Assert9(@"
                using System.Linq;
                
                ret Enumerable.Take([ 0, 1, 9, 10 ], 3)
                    |> Enumerable.Last;
            ");
        }

        [Test]
        public void GenericSequenceEqualTest()
        {
            AssertTrue(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 3], [1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualTest2()
        {
            AssertFalse(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 4], [1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualTest3()
        {
            AssertFalse(@"
                using System.Linq;

                ret Enumerable.SequenceEqual([1, 2, 3, 2], [1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualPipelineTest()
        {
            AssertTrue(@"
                using System.Linq;

                ret [1, 2, 3] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualPipelineTest2()
        {
            AssertFalse(@"
                using System.Linq;

                ret [1, 2, 4] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualPipelineTest3()
        {
            AssertFalse(@"
                using System.Linq;

                ret [1, 2, 3, 4] @Enumerable.SequenceEqual([1, 2, 3]);
            ");
        }

        [Test]
        public void GenericSequenceEqualPartialApplicationTest()
        {
            AssertTrue(@"
                using System.Linq;
                p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 3] |> p;
            ");
        }

        [Test]
        public void GenericSequenceEqualPartialApplicationTest2()
        {
            AssertFalse(@"
                using System.Linq;
                p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 4] |> p;
            ");
        }

        [Test]
        public void GenericSequenceEqualPartialApplicationTest3()
        {
            AssertFalse(@"
                using System.Linq;
                p = @Enumerable.SequenceEqual([1, 2, 3]);
                ret [1, 2, 3, 4] |> p;
            ");
        }
    }
}
