using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
using System;
using Components.Aphid.TypeSystem;
using System.Linq.Expressions;

namespace Components.Aphid.UnitTests
{
    // Todo
    // * Cover static members accessed via instance path
    [TestFixture(Category = "AphidInterop"), Parallelizable(ParallelScope.All)]
    public partial class InteropTests : InteropTestBase
    {
        private static Expression<Func<object>>
            _staticBoolField = () => TestClass.StaticBoolField,
            _staticBoolProperty = () => TestClass.StaticBoolProperty,
            _staticAphidObjectProperty = () => TestClass.StaticAphidObjectProperty,
            _rootControlProperty = () => TestClass.RootControl;

        [Test]
        public void StaticFieldGetBoolTest() =>
            StaticGetTest(_staticBoolField, expected: false, setExpected: true);

        [Test]
        public void StaticFieldGetBoolTest2() =>
            StaticGetTest(_staticBoolField, expected: true, setExpected: true);

        [Test]
        public void StaticPropertyGetBoolTest() =>
            StaticGetTest(_staticBoolProperty, expected: false, setExpected: true);

        [Test]
        public void StaticPropertyGetBoolTest2() =>
            StaticGetTest(_staticBoolProperty, expected: true, setExpected: true);

        [Test, Ignore("Feature needs to be fixed.")]
        public void StaticPropertySetGetAphidObject() =>
            StaticPathTest<AphidObject>(
                _staticAphidObjectProperty,
                "{x: 10, y: 20}",
                x =>
                {
                    CollectionAssert.IsNotEmpty(x);
                    CollectionAssert.IsNotEmpty(x.Keys);
                    Assert.AreEqual(x.Keys.Count, 2);
                    CollectionAssert.Contains(x.Keys, "x");
                    CollectionAssert.Contains(x.Keys, "y");
                });

        [Test]
        public void StaticPropertyGetRootControlTest() =>
            StaticGetTest<UIComponent>(
                _rootControlProperty,
                x =>
                {
                    var textBox = x as TextBox;
                    Assert.NotNull(textBox);
                    Assert.AreEqual(x.Name, "TextBox1");
                    Assert.AreEqual(textBox.MaxLength, 0x100);
                });

        [Test]
        public void StaticFieldGetBoolFailTest() =>
            AllFail(
                () => StaticGetTest(_staticBoolField, expected: true),
                () => StaticGetTest(_staticBoolField, expected: true, setExpected: false));

        [Test]
        public void StaticPropertyGetBoolFailTest() =>
            AllFail(
                () => StaticGetTest(_staticBoolProperty, expected: true),
                () => StaticGetTest(_staticBoolProperty, expected: true, setExpected: false));

        //[Test]
        //public void StaticGetInvalidNamespaceFail()
        //{
        //    var p = "Components.Aphid.UnitTests.Shared.Bad.TestClass.StaticBoolField";

        //    AllThrow(
        //        () => StaticGetTest(p, expected: false),
        //        () => StaticGetTest(p, expected: false, setExpected: false));

        //    var p2 = "Components.Aphid.UnitTests.SharedBad.TestClass.StaticBoolField";

        //    AllThrow(
        //        () => StaticGetTest(p2, expected: false),
        //        () => StaticGetTest(p2, expected: false, setExpected: false));
        //}

        //[Test]
        //public void StaticGetInvalidClassFail()
        //{
        //    var p = "Components.Aphid.UnitTests.Shared.TestClassBad.StaticBoolField";

        //    AllThrow(
        //        () => StaticGetTest(p, expected: false),
        //        () => StaticGetTest(p, expected: false, setExpected: false));
        //}

        //[Test]
        //public void StaticGetInvalidMemberFail()
        //{
        //    var p = "Components.Aphid.UnitTests.Shared.TestClass.StaticBoolFieldBad";

        //    AllThrow(
        //        () => StaticGetTest(p, expected: false),
        //        () => StaticGetTest(p, expected: false, setExpected: false));
        //}
    }
}
