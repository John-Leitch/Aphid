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
        public void MathSqrtExplicitFullNameCallTest() => AssertExp9("%%System.Math.Sqrt(81)");

        [Test]
        public void MathSqrtExpliciteCallTest()
        {
            Assert9(@"
                using System;
                ret %%Math.Sqrt(81);
            ");
        }

        [Test]
        public void MathSqrtRefCallTest()
        {
            Assert9(@"
                using System;
                var sqrt = Math.Sqrt;
                ret sqrt(81);
            ");
        }

        [Test]
        public void MathSqrtRefPipelineTest()
        {
            Assert9(@"
                using System;
                var sqrt = Math.Sqrt;
                ret 81 |> sqrt;
            ");
        }

        [Test]
        public void MathSqrtAsMemberRefCallTest()
        {
            Assert9(@"
                using System;
                var math = { sqrt: Math.Sqrt };
                ret math.sqrt(81);
            ");
        }

        [Test]
        public void MathSqrtAsMemberRefPipelineTest()
        {
            Assert9(@"
                using System;
                var math = { sqrt: Math.Sqrt };
                ret 81 |> math.sqrt;
            ");
        }

        [Test]
        public void MathSqrtExplicitInteropPipelineTest()
        {
            Assert9(@"
                using System;
                ret 81 %%Math.Sqrt;
            ");
        }

        [Test]
        public void MathSqrtPipelineTest()
        {
            Assert9(@"
                using System;
                ret 81 |> Math.Sqrt;
            ");
        }

        [Test]
        public void MathSqrtParensTest()
        {
            Assert9(@"
                using System;
                ret (Math.Sqrt)(81);
            ");
        }

        [Test]
        public void MathPowPartialCallTest()
        {
            Assert9(@"
                using System;
                var pow = Math.Pow;
                ret 2 @pow(3);
            ");
        }

        [Test]
        public void MathPowPartialPipelineTest()
        {
            Assert9(@"
                using System;
                var pow = Math.Pow;
                ret 2 |> @pow(3);
            ");
        }

        [Test]
        public void MathPowPartialPipelineParensTest()
        {
            Assert9(@"
                using System;
                var pow = Math.Pow;
                ret (@pow(3))(2);
            ");
        }

        [Test]
        public void MathPowPartialVarCallTest()
        {
            Assert9(@"
                using System;
                var pow = Math.Pow;
                var f = @pow(3);
                ret f(2); 
            ");
        }

        [Test]
        public void MathPowPartialVarPipelineTest()
        {
            Assert9(@"
                using System;
                var pow = Math.Pow;
                var f = @pow(3);
                ret 2 |> f; 
            ");
        }
    }
}
