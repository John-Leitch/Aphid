using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "TraversableEnumerableSmokeTest"), Parallelizable(ParallelScope.All)]
    public class TraversableEnumerableSmokeTests
    {
        private static readonly Dictionary<string, object> dict = new Dictionary<string, object>
        {
            { "test", "foo" },
            { "bar", "foo bleh" },
            { "bar2", null },
            { "bar5", 0xdeadbeef },
            { "test 1 2 3", "foo" },
        };

        [Test] public void TraversableEnumerableSmokeTest1() => dict.Member(x => x.Value).Is<string>().Is("foo").ToArray();
        [Test] public void TraversableEnumerableSmokeTest2() => dict.Member(x => x.Value).Is("foo bleh").ToArray();
        [Test] public void TraversableEnumerableSmokeTest3() => dict.Member(x => x.Value).Is<string>().ToArray();
        [Test] public void TraversableEnumerableSmokeTest4() => dict.Member(x => x.Value).Is<string>().Is("foo").ToArray();
        [Test] public void TraversableEnumerableSmokeTest5() => dict.Member(x => x.Value).Is<string>().And(x => x.Length).Is(8).ToArray();
        [Test] public void TraversableEnumerableSmokeTest6() => dict.Member(x => x.Value).Is<string>().And(x => x.Length).Is<int>().ToArray();
        [Test] public void TraversableEnumerableSmokeTest7() => dict.Member(x => x.Value).Is<string>().And(x => x.Length).Is<int>().Is(8).ToArray();
        [Test] public void TraversableEnumerableSmokeTest8() => dict.Member(x => x.Value).Is<string>().And(x => x.Length).Is<int>().Is(x => x > 3).ToArray();
        [Test] public void TraversableEnumerableSmokeTest9() => dict.Member(x => x.Value).Is<string>().Member(x => x.Key).Not("test").ToArray();

        [Test] public void TraversableEnumerableSmokeTest10() =>
            dict
                .GetType()
                .GetMembers(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Member(x => x.DeclaringType)
                .Is<Type>()
                .ToArray();

        [Test]
        public void TraversableEnumerableSmokeTest11() =>
            dict
                .GetType()
                .GetMembers(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Member(x => x.DeclaringType)
                .Is<TypeInfo>()
                .ToArray();

        [Test]
        public void TraversableEnumerableSmokeTest12() =>
            dict
                .GetType()
                .GetMembers(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Element()
                .Is<PropertyInfo>()
                .And(x => x.Name)
                .Is("Count")
                .ToArray();

        [Test]
        public void TraversableEnumerableSmokeTest13() =>
            dict
                .GetType()
                .GetMembers(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Element()
                .Is<PropertyInfo>()
                .And(x => x.Name)
                .Is("Count")
                .Member(x => x.DeclaringType)
                .Not<TypeInfo>()
                .ToArray();

        [Test]
        public void TraversableEnumerableSmokeTest14() =>
            dict
                .GetType()
                .GetMembers(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Element()
                .Is<PropertyInfo>()
                .And(x => x.Name)
                .Is("Keys")
                .Member(x => x.DeclaringType)
                .Not<TypeBuilder>()
                .ToArray();
    }
}
