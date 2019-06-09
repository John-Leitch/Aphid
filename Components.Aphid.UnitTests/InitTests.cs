using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidTypeInit"), Parallelizable(ParallelScope.All)]
    public class TypeInitTests : AphidTests
    {
        public override bool LoadStd => true;

        [Test]
        public void LengthTest1() =>
            Assert9("var a={b:'aaaaaaaaa'}; var x={y:'a'}; x.{'y'}=a.{'b'}; ret x.y.length();");

        [Test]
        public void LengthTest2() =>
            Assert9("var x='aaaaaaaaa'; var y='a'; y=this.{'x'}; ret y.length();");

        [Test]
        public void LengthTest3() =>
            Assert9("this.x='aaaaaaaaa'; this.y='a'; y=this.{'x'}; ret y.length();");
    }
}
