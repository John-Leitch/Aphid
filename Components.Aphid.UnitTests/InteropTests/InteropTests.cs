using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
using System;
using System.Reflection;
using System.Linq;
using Components.Aphid.TypeSystem;
using Components.Aphid.Interpreter;
using static NUnit.Framework.Assert;
using System.Diagnostics;
using static Components.Aphid.TypeSystem.AphidObject;
using System.Runtime.CompilerServices;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidExplicitInterop"), Parallelizable(ParallelScope.All), AphidLibrary("testLib")]    
    public static class ExplicitInteropTests
    {
        #region Helpers
        private static AphidTests _aphid = new AphidTests()
            .Do(x => x.InterpreterCreated += (o, e) =>
                e.Interpreter
                    .Do(y => y.Loader.LoadModule(Assembly.GetExecutingAssembly()))
                    .Do(y => y.Interpret("##'Components.Aphid.UnitTests.ExplicitInteropTests';")));

        private static void IsFrame(string name) => new StackTrace(true).GetFrame(1).GetMethod().Name.Do(x => AreEqual(x, name));

        //private static void Execute(string code) => _aphid.Execute("##'Components.Aphid.UnitTests.ExplicitInteropTests'; " + code);

        private static void Eq<T>(T expected, params object[] args) =>
            Are(AreEqual, expected, args);

        private static void NotEq<T>(T expected, params object[] args) =>
            Are(AreNotEqual, expected, args);

        private static void Ex<T>(params object[] args) where T : Exception => Catch<T>(() => Exec(args));

        private static void Are<T>(Action<object, object> assert, T expected, params object[] args) =>
            assert(expected, ValueHelper.Unwrap(Exec(args)));

        private static AphidObject Exec(params object[] args) => new StackTrace()
            .GetFrames()
            .Select(x => x.GetMethod())
            .First(x => x.IsDefined(typeof(TestAttribute)))
            .Then(x => _aphid.Execute(
                $"ret at.{FormatName(x)}" +
                $"({args.Select(y => y.ToString()).Join(", ")})"));

        private static string FormatName(MethodBase x) =>
            (x.Name.StartsWith("Test") ? x.Name.Substring("Test".Length) : x.Name)
                .TrimEnd(Digits);

        private static char[] Digits => Enumerable.Range('0', 10).Select(Convert.ToChar).ToArray();
        #endregion

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.NoArgsNoReturn")]
        public static void NoArgsNoReturn() => IsFrame(nameof(NoArgsNoReturn));

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestNoArgsNoReturn() => Exec();

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.NoArgs")]
        public static decimal NoArgs() => 9;

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestNoArgs() => Eq(9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestNoArgs2() => NotEq(10m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestNoArgs3() => NotEq("test");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestNoArgs4() => NotEq(AphidObject.Complex());

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.ArgsNoReturn")]
        public static void ArgsNoReturn(decimal x) => IsFrame(nameof(ArgsNoReturn));

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsNoReturn() => Exec(9m);
        [Test, Ignore("Fix")] public static void TestArgsNoReturn2() => Ex<TargetInvocationException>("test");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsNoReturn3() => Ex<TargetParameterCountException>();
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsNoReturn4() => Ex<TargetParameterCountException>(9m, 9m);

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.ArgsReturn")]
        public static decimal ArgsReturn(decimal x) => 9m + x;

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsReturn() => Eq(18m, 9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsReturn1() => NotEq(9m, 9m);
        [Test, Ignore("Fix")] public static void TestArgsReturn2() => NotEq(9m, "test");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsReturn3() => Ex<TargetParameterCountException>();
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestArgsReturn4() => Ex<TargetParameterCountException>(9m, 9m);

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.WrappedArg", UnwrapParameters = false)]
        public static AphidObject WrappedArg(AphidObject x) =>
            Scalar(9m + (decimal)ValueHelper.Unwrap(x));

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestWrappedArg() => Eq(18m, 9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestWrappedArg2() => Eq(18m, Scalar(9m));
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestWrappedArg3() => Ex<TargetParameterCountException>();
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestWrappedArg4() => Ex<TargetParameterCountException>(9m, 9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestWrappedArg5() => Ex<TargetParameterCountException>(Scalar(9m), Scalar(9m));

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.PassInterpreter", PassInterpreter = true)]
        public static decimal PassInterpreter(AphidInterpreter interpreter, decimal x) =>
            (9m + x).Do(y => NotNull(interpreter));

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestPassInterpreter() => Eq(18m, 9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestPassInterpreter1() => Eq(18m, Scalar(9m));
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestPassInterpreter2() => Ex<TargetParameterCountException>();
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestPassInterpreter3() => Ex<TargetParameterCountException>(9m, 9m);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestPassInterpreter4() => Ex<TargetParameterCountException>(Scalar(9m), Scalar(9m));
        [Test, Ignore("Fix")] public static void TestPassInterpreter5() => Ex<TargetParameterCountException>("new AphidInterpreter()", 9m);
        
        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.Params")]
        public static string Params(string format, params object[] args) =>
            string.Format(format, args);

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams() => Eq("foobar", new[] { "'foo{0}'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams2() => Eq("foobar", new[] { "'{0}{1}'", "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams3() => Eq("12", new[] { "'{0}{1}'", "1", "2" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams4() => Eq("1,2", new[] { "'{0},{1}'", "1", "2" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams5() => Eq("foo", new[] { "'foo'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams6() => Eq("foo", new[] { "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams7() => Eq("bar", new[] { "'{1}'", "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams8() => Eq("1234567890", new object[] { "'{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams9() => Eq("1", new object[] { "'{0}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams10() => Eq("0", new object[] { "'{9}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams11() => Eq("", new object[] { "''", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams12() => Ex<TargetInvocationException>("'{0}'");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams13() => Ex<TargetInvocationException>("'{0} {1}'", 1);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams14() => Ex<TargetInvocationException>("'{0} {1}'", "'test'");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParams15() => Ex<TargetInvocationException>("'{1}'", 1);

        [MethodImpl(MethodImplOptions.NoInlining), AphidInteropFunction("at.ParamsPassInterpreter", PassInterpreter = true)]
        public static string ParamsPassInterpreter(AphidInterpreter interpreter, string format, params object[] args) =>
            string.Format(format, args).Do(y => NotNull(interpreter));

        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter() => Eq("foobar", new[] { "'foo{0}'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter2() => Eq("foobar", new[] { "'{0}{1}'", "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter3() => Eq("12", new[] { "'{0}{1}'", "1", "2" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter4() => Eq("1,2", new[] { "'{0},{1}'", "1", "2" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter5() => Eq("foo", new[] { "'foo'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter6() => Eq("foo", new[] { "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter7() => Eq("bar", new[] { "'{1}'", "'foo'", "'bar'" });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter8() => Eq("1234567890", new object[] { "'{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter9() => Eq("1", new object[] { "'{0}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter10() => Eq("0", new object[] { "'{9}'", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter11() => Eq("", new object[] { "''", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter12() => Ex<TargetInvocationException>("'{0}'");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter13() => Ex<TargetInvocationException>("'{0} {1}'", 1);
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter14() => Ex<TargetInvocationException>("'{0} {1}'", "'test'");
        [Test][MethodImpl(MethodImplOptions.NoInlining)] public static void TestParamsPassInterpreter15() => Ex<TargetInvocationException>("'{1}'", 1);
        

    }
}
