using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration.Shared
{
    [TestFixture(Category = "ScriptedTests"), Parallelizable(ParallelScope.Self)]
    public class ScriptedTests : AphidTests
    {
        [Test, TestCaseSource("Tests")]
        public void RunTestScript(AphidInterpreter interpreter, string funcName)
        {
            interpreter.TakeOwnership();
            var result = interpreter.CallFunction(funcName);

            if (result != null && result.Value != null && result.Value.GetType() == typeof(bool))
            {
                var sb = new StringBuilder(string.Format("Function {0} returned false.", funcName));

                AphidObject lastException;

                if (interpreter.CurrentScope.TryResolve("lastException", out lastException) &&
                    lastException != null)
                {
                    foreach (var kvp in lastException)
                    {
                        sb.AppendFormat("{0}: {1}\r\n\r\n", kvp.Key, kvp.Value);
                    }
                }

                Assert.True(result.GetBool(), sb.ToString());
            }
        }

        private static bool _isLibraryUpdated = false;

        private static readonly List<AphidExpression> _prologueAst = AphidParser.Parse(@"
            using Components.Aphid.Tests.Integration;
            using Components.Aphid.Tests.Integration.Shared;
            isTrue = AphidTests.IsTrue;
            isFalse = AphidTests.IsFalse;
            isFoo = AphidTests.IsFoo;
            is9 = AphidTests.Is9;
            isNull = AphidTests.IsNull;
            notNull = AphidTests.NotNull;
        ");

        public static IEnumerable Tests
        {
            get
            {
                var aphidDir = new FileInfo(typeof(AphidTests).Assembly.Location).Directory;

                var testScripts = aphidDir
                    .GetDirectories("ScriptedTests")
                    .Single()
                    .GetFiles("*.alx", SearchOption.AllDirectories)
                    .Where(x =>
                        x.Name.ToLower() != "test.alx" &&
                        x.Name.ToLower() != "testbase.alx" &&
                        x.Name.ToLower() != "aoptest.alx");

                var testList = new List<TestCaseData>();

                var asm = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (var s in testScripts)
                {
                    var script = File.ReadAllText(s.FullName);
                    var interpreter = new AphidInterpreter();
                    interpreter.Loader.SearchPaths.Add(aphidDir.FullName);
                    interpreter.Loader.SearchPaths.Add(s.Directory.FullName);
                    interpreter.Interpret(_prologueAst);
                    interpreter.Interpret(script);
                    var scope = interpreter.CurrentScope;

                    var tests = scope.Keys
                        .SkipWhile(x => x != "tests")
                        .Skip(1)
                        .Where(x => scope[x].Value != null && scope[x].Value is AphidFunction)
                        .ToArray();

                    foreach (var t in tests)
                    {
                        yield return new TestCaseData(interpreter, t)
                            .SetCategory(Path.GetFileNameWithoutExtension(s.Name))
                            .SetName(FormatTestName(t));

                    }
                }
            }
        }

        private static string FormatTestName(string funcName)
        {
            if (Regex.IsMatch(funcName, @"Test\d*$"))
            {
                return funcName;
            }

            var n = funcName[0].ToString().ToUpper() + funcName.Substring(1);
            var digits = n.Where(char.IsDigit).ToArray();

            return n.Insert(digits.Any() ? n.IndexOf(digits[0]) : n.Length, "Test");
        }
    }
}
