using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
using System.Linq;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidTypeCoercion"), Parallelizable(ParallelScope.All)]
    public class TypeCoercionTests : AphidTests
    {
        [Test]
        public void StringJoinNumbersTest() =>
            AssertExpEquals(
                string.Join(",", Enumerable.Range(0x0, 0x10).ToArray()),
                "0x0..0x10 @String.Join(',')");

        [Test]
        public void StringFormatTest() =>
            AssertExpFoo("String.Format('fo{0}', 'o')");

        [Test]
        public void StringFormatTest2() =>
            AssertExpFoo("String.Format('f{0}', 'oo')");

        [Test]
        public void StringFormatTest3() =>
            AssertExpFoo("String.Format('f{0}{0}', 'o', 'o')");

        [Test]
        public void StringFormatTest4() =>
            AssertExpFoo("String.Format('{0}{1}{1}', 'f', 'o')");

        [Test]
        public void StringFormatTest5() =>
            AssertExpFoo("String.Format('fo{0}', [ 'o' ])");

        [Test]
        public void StringFormatTest6() =>
            AssertExpFoo("String.Format('f{0}', [ 'oo' ])");

        [Test]
        public void StringFormatTest7() =>
            AssertExpFoo("String.Format('f{0}{0}', [ 'o', 'o' ])");

        [Test]
        public void StringFormatTest8() =>
            AssertExpFoo("String.Format('{0}{1}{1}', [ 'f', 'o' ])");

        [Test]
        public void StringFormatTest9() =>
            AssertExpFoo("'o' @String.Format('fo{0}')");

        [Test]
        public void StringFormatTest10() =>
            AssertExpFoo("'oo' @String.Format('f{0}')");

        [Test]
        public void StringFormatTest11() =>
            AssertExpFoo("[ 'o' ] @String.Format('fo{0}')");

        [Test]
        public void StringFormatTest12() =>
            AssertExpFoo("[ 'oo' ] @String.Format('f{0}')");

        [Test]
        public void StringFormatTest13() =>
            AssertExpFoo("[ 'o', 'o' ] @String.Format('f{0}{0}')");

        [Test]
        public void StringFormatTest14() =>
            AssertExpFoo("[ 'f', 'o' ] @String.Format('{0}{1}{1}')");
    }
}
