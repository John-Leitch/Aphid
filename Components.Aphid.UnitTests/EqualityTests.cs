using Components.Aphid.Interpreter;
using Components.Aphid.UnitTests.Shared;
using Components.Aphid.TypeSystem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidEquality"), Parallelizable(ParallelScope.All)]
    public class EqualityTests : AphidTests
    {
        private void AssertEquality(object lhs, object rhs)
        {
            AssertEquality(lhs, rhs, true);
            AssertEquality(rhs, lhs, true);
        }

        private void AssertInequality(object lhs, object rhs)
        {
            AssertEquality(lhs, rhs, false);
            AssertEquality(rhs, lhs, false);
        }

        private void AssertEquality(object lhs, object rhs, bool areEqual)
        {
            var interpreter = new AphidInterpreter();
            interpreter.CurrentScope.Add("lhs", AphidObject.Scalar(lhs));
            interpreter.CurrentScope.Add("rhs", AphidObject.Scalar(rhs));
            interpreter.Interpret("ret lhs == rhs");
            var result = interpreter.GetReturnValue().GetBool();

            Assert.AreEqual(result, areEqual);
        }

        [Test]
        public void DecimalEqualityTest() => AssertEquality(10m, 10m);

        [Test]
        public void DecimalInequalityTest() => AssertInequality(10m, 9m);

        [Test]
        public void IntEqualityTest() => AssertEquality(10, 10);

        [Test]
        public void IntInequalityTest() => AssertInequality(10, 9);

        [Test]
        public void IntDecimalEqualityTest() => AssertEquality(10, 10m);

        [Test]
        public void IntDecimalInequalityTest() => AssertInequality(10, 9m);

        [Test]
        public void StringEqualityTest() => AssertEquality("foo", "foo");

        [Test]
        public void StringInequalityTest() => AssertInequality("foo", "bar");

        [Test]
        public void CharEqualityTest() => AssertEquality('f', 'f');

        [Test]
        public void CharInequalityTest() => AssertInequality('f', 'A');

        [Test]
        public void CharCharEqualityTest() => AssertEquality("f", 'f');

        [Test]
        public void CharCharInequalityTest() => AssertInequality("f", 'A');

        [Test]
        public void CharCharInequalityTest2() => AssertInequality("ff", 'A');

        [Test]
        public void CharCharInequalityTest3() => AssertInequality("", 'A');
    }
}
