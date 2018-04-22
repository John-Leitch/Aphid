using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidSwitch"), Parallelizable(ParallelScope.Self)]
    public class SwitchTests : AphidTests
    {
        [Test]
        public void SwitchTest()
        {
            Assert9(@"
                var x = 0;
                var y = 'bar';

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
                var x = 0;
                var y = 'hello world';

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
                var x = 0;
                var y = 'bar';

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
                var x = 0;
                var y = 'abc';

                switch (y) {
                    'foo': 0;
                    'bar': 0;
                    'abc': { x = 0; ret 9; }
                    default: 0;
                }

                ret 0;
            ");
        }

        [Test]
        public void SwitchArgsCountTest()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 9;
                        2: ret 7;
                        default: ret 0;
                    }
                }(1)
            ");
        }

        [Test]
        public void SwitchArgsCountTest2()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 9;
                        2: ret 7;
                        default: ret 0;
                    }
                }(1, 2, 3)
            ");
        }

        [Test]
        public void SwitchArgsCountTest3()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 0;
                        2: ret 9;
                        default: ret 0;
                    }
                }(1, 2)
            ");
        }

        [Test]
        public void SwitchArgsCountTest4()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 0;
                        2: ret 1;
                        default: ret 9;
                    }
                }()
            ");
        }

        [Test]
        public void SwitchArgsCountTest5()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 0;
                        2: ret 1;
                        default: ret 9;
                    }
                }(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)
            ");
        }

        [Test]
        public void SwitchStringTest()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count.ToString()) {
                        '1', '3': ret 9;
                        2: ret 1;
                        default: ret 0;
                    }
                }(1, 2, 3)
            ");
        }

        [Test]
        public void SwitchStringTest2()
        {
            AssertExp9(@"
                @{
                    switch ($args.Count.ToString()) {
                        '1', 3.ToString(): ret 9;
                        2: ret 1;
                        default: ret 0;
                    }
                }(1, 2, 3)
            ");
        }

        [Test]
        public void SwitchFalseTest()
        {
            AssertExpFalse(@"
                @{
                    switch ($args.Count) {
                        1, 3: ret 9;
                        2: ret 1;
                        default: ret 0;
                    }
                }(1, 2) == 9
            ");
        }

        [Test]
        public void SwitchFalseTest2()
        {
            AssertExpFalse(@"
                @{
                    switch ($args.Count.ToString()) {
                        '1', '3': ret 0;
                        2: ret 1;
                        default: ret 9;
                    }
                }(1) == 9
            ");
        }

        [Test]
        public void SwitchFalseTest3()
        {
            AssertExpFalse(@"
                @{
                    switch ($args.Count.ToString()) {
                        '1', 3.ToString(): ret 9;
                        2: ret 1;
                        default: ret 0;
                    }
                }() == 9
            ");
        }
    }
}
