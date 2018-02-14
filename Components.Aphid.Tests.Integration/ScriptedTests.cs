using Components.Aphid.Interpreter;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "ScriptedTests"), Parallelizable(ParallelScope.Self)]
    public class ScriptedTests : AphidTests
    {
        [Test, TestCaseSource("Tests")]
        public void TestFoo(AphidInterpreter interpreter, string funcName)
        {
            interpreter.CallFunction(funcName);
        }

        public static IEnumerable Tests
        {
            get
            {
                var aphidDir = new FileInfo(typeof(AphidTests).Assembly.Location).Directory;

                var testScripts = aphidDir
                    .GetDirectories("ScriptedTests")
                    .Single()
                    .GetFiles("*.alx", SearchOption.AllDirectories);

                var testList = new List<TestCaseData>();

                foreach (var s in testScripts)
                {
                    var interpreter = new AphidInterpreter();
                    interpreter.Loader.SearchPaths.Add(aphidDir.FullName);
                    
                    interpreter.Interpret(@"
                        using Components.Aphid.Tests.Integration;
                        isFoo = AphidTests.IsFoo;
                        is9 = AphidTests.Is9;
                    ");

                    interpreter.Interpret(File.ReadAllText(s.FullName));

                    var tests = interpreter.CurrentScope.Keys
                        .SkipWhile(x => x != "tests")
                        .Skip(1)
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
            var n = funcName[0].ToString().ToUpper() + funcName.Substring(1);
            var digits = n.Where(char.IsDigit).ToArray();

            return n.Insert(digits.Any() ? n.IndexOf(digits[0]) : n.Length, "Test");
        }
    }
}
