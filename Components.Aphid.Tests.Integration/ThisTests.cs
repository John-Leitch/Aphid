using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidThis"), Parallelizable(ParallelScope.All)]
    public class ThisTests : AphidTests
    {
        public override bool LoadStd => true;

        [Test]
        public void ThisTest1() => Assert9("var x=9; var f=@(a)a.x; ret f(this);");

        [Test]
        public void ThisTest2()
        {
            Assert9(@"
                var f=@() {
	                var x = 9;
	                ret this;
                };
                ret f().x;                
            ");
        }

        [Test]
        public void ThisTest3()
        {
            Assert9(@"
                var x = 8;

                var f=@() {

                    var f2=@() {
                        ret this;
                    };
	                
                    ret f2();
                };
                
                ret f().x + 1;                
            ");
        }

        [Test]
        public void ThisTest4()
        {
            Assert9(@"
                var f = @() {
                    var z = 8;
                    ret this;
                };

                var f2=@(y) {

                    var f3=@(x) {
                        ret this;
                    };
	                
                    ret f3(this);
                };
                
                ret f2(f()).x.y.z + 1;                
            ");
        }
    }
}
