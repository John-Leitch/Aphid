using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidSwitch")]
    public class SwitchTests : AphidTests
    {
        [Test]
        public void SwitchTest()
        {
            Assert9(@"
                x = 0;
                y = 'bar';

                switch (y) {
                    'foo': x = 0;
                    'bar': x = 9;
                    'abc': { x = 0; y = 0; }
                    default: x = 0;
                }

                ret x;
            ");
        }

        [Test]
        public void SwitchTest2()
        {
            Assert9(@"
                x = 0;
                y = 'hello world';

                switch (y) {
                    'foo': x = 0;
                    'bar': x = 0;
                    'abc': { x = 0; y = 0; }
                    default: x = 9;
                }

                ret x;
            ");
        }

        [Test]
        public void SwitchTest3()
        {
            Assert9(@"
                x = 0;
                y = 'bar';

                switch (y) {
                    'foo': ret 0;
                    'bar': ret 9;
                    'abc': { x = 0; ret 0; }
                    default: ret 0;
                }

                ret 0;
            ");
        }

        [Test]
        public void SwitchTest4()
        {
            Assert9(@"
                x = 0;
                y = 'abc';

                switch (y) {
                    'foo': 0;
                    'bar': 0;
                    'abc': { x = 0; ret 9; }
                    default: 0;
                }

                ret 0;
            ");
        }
    }
}
