using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidTypeInit"), Parallelizable(ParallelScope.Self)]
    public class TypeInitTests : AphidTests
    {
        protected override bool LoadStd { get { return true; } }

        [Test]
        public void LengthTest1()
        {
            Assert9("var a={b:'aaaaaaaaa'}; var x={y:'a'}; x.{'y'}=a.{'b'}; ret x.y.length();");
        }

        [Test]
        public void LengthTest2()
        {
            Assert9("var x='aaaaaaaaa'; var y='a'; y=this.{'x'}; ret y.length();");
        }

        [Test]
        public void LengthTest3()
        {
            Assert9("this.x='aaaaaaaaa'; this.y='a'; y=this.{'x'}; ret y.length();");
        }
    }
}
