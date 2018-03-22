using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration.Shared
{
    [TestFixture(Category = "ScriptedTests"), Parallelizable(ParallelScope.Self)]
    public class ScriptedTests : AphidTests
    {
        [Test, TestCaseSource("Tests")]
        public void RunTestScript(Func<AphidInterpreter> createInterpreter, string funcName)
        {
            var interpreter = createInterpreter();
            var result = interpreter.CallFunction(funcName);

            if (result != null && result.Value != null && result.Value.GetType() == typeof(bool))
            {
                Assert.True(result.GetBool(), "Function {0} returned false.", funcName);
            }
        }

        public static IEnumerable Tests
        {
            get
            {
                var aphidDir = new FileInfo(typeof(AphidTests).Assembly.Location).Directory;

                var testScripts = aphidDir
                    .GetDirectories("ScriptedTests")
                    .Single()
                    .GetFiles("*.alx", SearchOption.AllDirectories)
                    .Where(x => x.Name.ToLower() != "test.alx");

                var testList = new List<TestCaseData>();

                foreach (var s in testScripts)
                {
                    Func<AphidInterpreter> create = () =>
                    {
                        var interpreter = new AphidInterpreter();
                        interpreter.Loader.SearchPaths.Add(aphidDir.FullName);
                        interpreter.Loader.SearchPaths.Add(s.Directory.FullName);

                        interpreter.Interpret(@"
                            using Components.Aphid.Tests.Integration;
                            using Components.Aphid.Tests.Integration.Shared;
                            isFoo = AphidTests.IsFoo;
                            is9 = AphidTests.Is9;
                            isNull = AphidTests.IsNull;
                            notNull = AphidTests.NotNull;
                        ");

                        interpreter.Interpret(File.ReadAllText(s.FullName));

                        return interpreter;
                    };

                    var scope = create().CurrentScope;

                    var tests = scope.Keys
                        .SkipWhile(x => x != "tests")
                        .Skip(1)
                        .Where(x => scope[x].Value != null && scope[x].Value is AphidFunction)
                        .ToArray();

                    foreach (var t in tests)
                    {
                        yield return new TestCaseData(create, t)
                            .SetCategory(Path.GetFileNameWithoutExtension(s.Name))
                            .SetName(FormatTestName(t));
                        
                    }
                }
            }
        }

        private static string FormatTestName(string funcName)
        {
            var n = funcName[0].ToString().ToUpper() + funcName.Substring(1);
            var digits = n.Where(char.IsDigit).ToArray();

            return n.Insert(digits.Any() ? n.IndexOf(digits[0]) : n.Length, "Test");
        }
    }
}
