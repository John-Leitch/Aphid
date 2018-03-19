using Components.Aphid.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Components.Aphid.Tests.Integration
{
    public class TestClass
    {
        public static bool StaticBoolField;

        public static bool StaticBoolProperty { get; set; }
    }

    // Todo
    // * Cover static members accessed via instance path
    [TestFixture(Category = "AphidInterop"), Parallelizable(ParallelScope.Self)]
    public class InteropTests : AphidTests
    {
        private TypeLoader _loader = new TypeLoader();

        [Test]
        public void StaticTest1()
        {
            AssertExp9("%%System.Math.Sqrt(81)");
        }

        [Test]
        public void StaticTest2()
        {
            Assert9(@"
                using System;
                ret %%Math.Sqrt(81);
            ");
        }

        [Test]
        public void StaticArgTest1()
        {
            AssertExpFoo("%%System.String.Format('foo')");
        }

        [Test]
        public void StaticArgTest2()
        {
            AssertExpFoo("%%System.String.Format('f{0}o', 'o')");
        }

        [Test]
        public void StaticArgTest3()
        {
            AssertExpFoo("%%System.String.Format('{0}o{1}', 'f', 'o')");
        }

        [Test]
        public void StaticArgTest4()
        {
            AssertFoo(@"
                x = 'f';
                y = 'o';
                ret %%System.String.Format('{0}o{1}', x, y);
            ");
        }

        [Test]
        public void StaticArgTest5()
        {
            AssertFoo(@"
                using System;
                x=['f','o'];
                ret %%String.Format('{0}o{1}', x[0], x[1]);
            ");
        }

        [Test]
        public void StaticArgTest6()
        {
            AssertFoo(@"
                x=['f','o'];
                ret string.Format('{0}o{1}', x[0], x[1]);
            ");
        }

        [Test]
        public void StaticRefTest1()
        {
            Assert9(@"
                using System;
                sqrt = Math.Sqrt;
                ret sqrt(81);
            ");
        }

        [Test]
        public void StaticRefTest2()
        {
            Assert9(@"
                using System;
                sqrt = Math.Sqrt;
                ret 81 |> sqrt;
            ");
        }

        [Test]
        public void StaticRefTest3()
        {
            Assert9(@"
                using System;
                math = { sqrt: Math.Sqrt };
                ret math.sqrt(81);
            ");
        }

        [Test]
        public void StaticRefTest4()
        {
            Assert9(@"
                using System;
                math = { sqrt: Math.Sqrt };
                ret 81 |> math.sqrt;
            ");
        }

        [Test]
        public void StaticRefTest5()
        {
            Assert9(@"
                using System;
                ret 81 %%Math.Sqrt;
            ");
        }

        [Test]
        public void StaticRefTest6()
        {
            Assert9(@"
                using System;
                ret 81 |> Math.Sqrt;
            ");
        }

        [Test]
        public void StaticRefTest7()
        {
            Assert9(@"
                using System;
                ret (Math.Sqrt)(81);
            ");
        }

        [Test]
        public void StaticPartialFuncTest1()
        {
            Assert9(@"
                using System;
                pow = Math.Pow;
                ret 2 @pow(3);
            ");
        }

        [Test]
        public void StaticPartialFuncTest2()
        {
            Assert9(@"
                using System;
                pow = Math.Pow;
                ret 2 |> @pow(3);
            ");
        }

        [Test]
        public void StaticPartialFuncTest3()
        {
            Assert9(@"
                using System;
                pow = Math.Pow;
                ret (@pow(3))(2);
            ");
        }

        [Test]
        public void StaticPartialFuncTest4()
        {
            Assert9(@"
                using System;
                pow = Math.Pow;
                f = @pow(3);
                ret f(2); 
            ");
        }

        [Test]
        public void StaticPartialFuncTest5()
        {
            Assert9(@"
                using System;
                pow = Math.Pow;
                f = @pow(3);
                ret 2 |> f; 
            ");
        }

        [Test]
        public void InstanceTest1()
        {
            Assert9(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('*********');
                w.Flush();
                
                ret s.Position;
            ");
        }

        [Test]
        public void InstanceTest2()
        {
            Assert9(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('****************');
                w.Flush();
                s.Position = 9;

                ret s.Position;
            ");
        }

        [Test]
        public void InstanceTest3()
        {
            Assert9(@"
                using System;
                using System.IO;

                w = new StreamWriter(new MemoryStream());
                w.Write('****************');
                w.Flush();
                w.BaseStream.Position = 9;

                ret w.BaseStream.Position;
            ");
        }

        [Test]
        public void InstanceTest4()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('foo');
                w.Flush();
                Console.WriteLine('Stream position: {0}', s.Position);
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                Console.WriteLine('Value: {0}', v);

                ret v;
            ");
        }

        [Test]
        public void InstancePartialFuncTest1()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                f = @w.Write('f{0}');
                f('oo');
                w.Flush();
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                
                ret v;
            ");
        }

        [Test]
        public void InstancePartialFuncTest2()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                'oo' @w.Write('f{0}');
                w.Flush();
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                
                ret v;
            ");
        }

        [Test]
        public void StaticFieldGetBoolTest()
        {
            StaticGetTest(
                "Components.Aphid.Tests.Integration.TestClass.StaticBoolField",
                false,
                setExpectedValue: true);

            // Todo: use for sanity check test
            //Components.Aphid.Tests.Integration.TestClass.StaticBoolField = false;
            //Components.Aphid.Tests.Integration.TestClass.StaticBoolProperty = false;

            //StaticGetTest(
            //    "Components.Aphid.Tests.Integration.TestClass.StaticBoolField",
            //    true,
            //    setExpectedValue: false);

            //StaticGetTest(
            //    "Components.Aphid.Tests.Integration.TestClass.StaticBoolProperty",
            //    true,
            //    setExpectedValue: false);
        }

        [Test]
        public void StaticFieldGetBoolTest2()
        {
            StaticGetTest(
                "Components.Aphid.Tests.Integration.TestClass.StaticBoolField",
                true,
                setExpectedValue: true);
        }

        [Test]
        public void StaticPropertyGetBoolTest()
        {
            StaticGetTest(
                "Components.Aphid.Tests.Integration.TestClass.StaticBoolProperty",
                false,
                setExpectedValue: true);
        }

        [Test]
        public void StaticPropertyGetBoolTest2()
        {
            StaticGetTest(
                "Components.Aphid.Tests.Integration.TestClass.StaticBoolProperty",
                true,
                setExpectedValue: true);
        }

        // Todo: refactor fullMemberName into expression for strong typing
        private void StaticGetTest<TValue>(
            string fullMemberName,
            TValue expectedValue,
            bool setExpectedValue)
        {
            TValue backup = default(TValue);

            var member = (dynamic)GetMember(fullMemberName).Single();

            if (setExpectedValue)
            {
                backup = (TValue)member.GetValue(null);
                member.SetValue(null, expectedValue);
            }

            try
            {
                // Todo: refactor into shared path parsing
                var fullTypeName = fullMemberName.RemoveAtLastIndexOf('.');
                var ns = fullTypeName.RemoveAtLastIndexOf('.');
                var memberPath = fullMemberName.Substring(ns.Length + 1);
                var script = string.Format("using {0}; ret {1}", ns, memberPath);
                AssertEquals(expectedValue, script);
            }
            finally
            {
                if (setExpectedValue)
                {
                    member.SetValue(null, backup);
                }
            }
        }

        private MemberInfo[] GetMember(string fullMemberName)
        {
            var memberName = fullMemberName.SubstringAtLastIndexOf('.', 1);
            var fullTypeName = fullMemberName.RemoveAtLastIndexOf('.');
            var ns = fullTypeName.RemoveAtLastIndexOf('.');
            var typeName = fullTypeName.SubstringAtLastIndexOf('.', 1);
            var type = _loader.ResolveFullType(fullTypeName);

            if (type == null)
            {
                throw new InvalidOperationException(
                    string.Format("Could not find type '{0}'.", fullTypeName));
            }

            return type.GetMember(memberName);
        }
    }
}
