using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidThis")]
    public class ThisTests : AphidTests
    {
        protected override bool LoadStd { get { return true; } }

        protected override bool LoadReflection { get { return true; } }

        [Test]
        public void ThisTest1()
        {
            Assert9("x=9; f=@(a)a.x; ret f(this);");
        }

        [Test]
        public void ThisTest2()
        {
            Assert9(@"
                f=@() {
	                x = 9;
	                ret this;
                };
                ret f().x;                
            ");
        }

        [Test]
        public void ThisTest3()
        {
            Assert9(@"
                x = 8;

                f=@() {

                    f2=@() {
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
                f = @() {
                    z = 8;
                    ret this;
                };

                f2=@(y) {

                    f3=@(x) {
                        ret this;
                    };
	                
                    ret f3(this);
                };
                
                ret f2(f()).x.y.z + 1;                
            ");
        }
    }
}
