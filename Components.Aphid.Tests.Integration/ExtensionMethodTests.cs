using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidExtensionMethod")]
    public class ExtensionMethodTests : AphidTests
    {       
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
    }
}
