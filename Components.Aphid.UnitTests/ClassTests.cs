using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidClass"), Parallelizable(ParallelScope.All)]
    public class ClassTests : AphidTests
    {
        [Test]
        public void TestClassProperty() =>
            AssertFoo(@"
                class Test { A };
                var x = new Test();
                x.A = 'foo';
                ret x.A;
            ");

        [Test]
        public void TestClassProperty2() =>
            AssertFoo(@"
                class Test2 { string A };
                var x = new Test2();
                x.A = 'foo';
                ret x.A;
            ");

        [Test]
        public void TestClassProperty3() =>
            AssertFoo(@"
                class Test3 { string A, string B };
                var x = new Test3();
                x.A = 'fo';
                x.B = 'o';
                ret x.A + x.B;
            ");

        [Test]
        public void TestClassProperty4() =>
            AssertEquals(
                0xdeadbeef,
                @"
                    class Test4 { uint A };
                    var x = new Test4();
                    x.A = 0xdeadbeef;
                    ret x.A;
            ");

        [Test]
        public void TestClassPropertyDowncast() =>
            AssertEquals(
                0xff,
                @"
                    class Test5 { byte A };
                    var x = new Test5();
                    x.A = 0xff;
                    ret x.A;
            ");

        [Test]
        public void TestClassPropertyDowncast1() =>
            AssertEquals(
                0x00,
                @"
                    class Test6 { byte A };
                    var x = new Test6();
                    x.A = 0x00;
                    ret x.A;
            ");

        [Test]
        public void TestClassPropertyDowncast2() =>
            AssertEquals(
                false,
                @"
                    class Test7 { byte A };
                    var x = new Test7();
                    try { x.A = 0x100 } catch { ret false }
                    ret true;
            ");

        [Test]
        public void TestClassPropertyType() =>
            AssertEquals(
                typeof(object),
                @"
                    class Test8 { A };
                    ret (new Test8()).GetType().GetProperty('A').PropertyType;
            ");

        [Test]
        public void TestClassPropertyType2() =>
            AssertEquals(
                typeof(long),
                @"
                    class of long Test9 { A };
                    ret (new Test9()).GetType().GetProperty('A').PropertyType;
            ");

        [Test]
        public void TestClassPropertyType3() =>
            AssertEquals(
                typeof(short),
                @"
                    class of long Test10 { A, short B };
                    ret (new Test10()).GetType().GetProperty('B').PropertyType;
            ");

        [Test]
        public void TestClassPropertyType4() =>
            AssertEquals(
                typeof(short),
                @"
                    class of long Test11 { short A, B, byte C };
                    ret (new Test11()).GetType().GetProperty('A').PropertyType;
            ");

        [Test]
        public void TestClassPropertyType5() =>
            AssertEquals(
                typeof(long),
                @"
                    class of long Test12 { short A, B, byte C };
                    ret (new Test12()).GetType().GetProperty('B').PropertyType;
            ");

        [Test]
        public void TestClassPropertyType6() =>
            AssertEquals(
                typeof(byte),
                @"
                    class of long Test13 { short A, B, byte C };
                    ret (new Test13()).GetType().GetProperty('C').PropertyType;
            ");
    }
}
