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

namespace Components.Aphid.Tests.Integration.Shared
{
    [TestFixture(Category = "ScriptedTests")]
    public class ScriptedTests : AphidTests
    {
        private static readonly List<AphidExpression> _prologueAst = AphidParser.Parse(@"
            using Components.Aphid.Tests.Integration;
            using Components.Aphid.Tests.Integration.Shared;
            var isTrue = AphidTests.IsTrue;
            var isFalse = AphidTests.IsFalse;
            var isFoo = AphidTests.IsFoo;
            var is9 = AphidTests.Is9;
            var isNull = AphidTests.IsNull;
            var notNull = AphidTests.NotNull;
            var isThrow = AphidTests.IsThrow;
        ");

        private static readonly DirectoryInfo _aphidDirectory = new FileInfo(typeof(AphidTests).Assembly.Location).Directory;

        private static readonly string[] _ignoreScripts = new[] { "test.alx", "testbase.alx", "aoptest.alx" };

        private static IEnumerable Tests => _aphidDirectory
            .GetDirectories("ScriptedTests")
            .Single()
            .GetFiles("*.alx", SearchOption.AllDirectories)
            .Except(x => _ignoreScripts.Contains(x.Name.ToLower()))
            .AsParallel()
            .WithDegreeOfParallelism(Environment.ProcessorCount)
            .WithMergeOptions(ParallelMergeOptions.NotBuffered)
            .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
            .SelectMany(s =>
            {
                WriteQueryMessage($"Caching {s.FullName}");
                var interpreter = new AphidInterpreter();
                interpreter.Loader.SearchPaths.Add(_aphidDirectory.FullName);
                interpreter.Loader.SearchPaths.Add(s.Directory.FullName);
                interpreter.Interpret(_prologueAst);
                var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray());
                var ast = cache.Read(s.FullName);

                WriteQueryMessage($"Interpreting {s.FullName}");
                interpreter.Interpret(ast);

                WriteQueryMessage($"Tests in {s.FullName} ready");
                var scope = interpreter.CurrentScope;

                return interpreter.CurrentScope
                    .SkipWhile(y => y.Key != "tests")
                    .Skip(1)
                    .Member(y => y.Value.Value)
                    .Is<AphidFunction>()
                    .Select(y => (s: y.Key, interpreter, s.Name));
            })
            .Select(x => new TestCaseData(x.interpreter, x.s)
                .SetCategory(Path.GetFileNameWithoutExtension(x.Name))
                .SetName(FormatTestName(x.s)))
            .AsSequential();

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

        [Test, TestCaseSource("Tests"), Parallelizable(ParallelScope.Self)]
        public void RunTestScript(AphidInterpreter interpreter, string funcName)
        {
            WriteQueryMessage($"Calling {funcName} method");
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
    }
}
