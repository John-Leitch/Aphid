using Components.Aphid.Tests.Integration.Shared;
using Components.Aphid.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Tests.Integration
{
    public partial class InteropTests
    {
        [Test]
        public void StringFormatImplicitParamsTest()
        {
            AssertExpFoo("%%System.String.Format('foo')");
        }

        [Test]
        public void StringFormatImplicitParamsTest2()
        {
            AssertExpFoo("%%System.String.Format('f{0}o', 'o')");
        }

        [Test]
        public void StringFormatImplicitParamsTest3()
        {
            AssertExpFoo("%%System.String.Format('{0}o{1}', 'f', 'o')");
        }

        [Test]
        public void StringFormatImplicitParamsTest4()
        {
            AssertFoo(@"
                var x = 'f';
                var y = 'o';
                ret %%System.String.Format('{0}o{1}', x, y);
            ");
        }

        [Test]
        public void StringFormatExplicitParamsTest()
        {
            AssertFoo(@"
                using System;
                var x=['f','o'];
                ret %%String.Format('{0}o{1}', x[0], x[1]);
            ");
        }

        [Test]
        public void StringFormatExplicitParamsTest2()
        {
            AssertFoo(@"
                var x=['f','o'];
                ret string.Format('{0}o{1}', x[0], x[1]);
            ");
        }
    }
}
