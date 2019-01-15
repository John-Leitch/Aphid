using Combinatorics.Collections;
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
            .SelectMany(GetTestsCasesFromFiles)
            .AsSequential()
            .ToArray();

        private static IEnumerable<TestCaseData> GetTestsCasesFromFiles(FileInfo file) =>
            new Variations<bool>(new[] { true, false }, 2, GenerateOption.WithRepetition)
            .SelectMany(flags =>
            {
                var (strictMode, cacheInlining) = (flags[0], flags[1]);
                WriteQueryMessage($"Caching {file.FullName}");
                var interpreter = new AphidInterpreter();
                interpreter.Loader.SearchPaths.Add(_aphidDirectory.FullName);
                interpreter.Loader.SearchPaths.Add(file.Directory.FullName);
                interpreter.Interpret(_prologueAst);                
                var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray());
                interpreter.Loader.InlineCachedScripts = cache.InlineScripts = cacheInlining;
                
                var ast = cache.Read(file.FullName);

                WriteQueryMessage($"Interpreting {file.FullName}");
                interpreter.Interpret(ast);

                WriteQueryMessage($"Tests in {file.FullName} ready");
                var scope = interpreter.CurrentScope;
                
                return interpreter.CurrentScope
                    .SkipWhile(y => y.Key != "tests")
                    .Skip(1)
                    .Member(y => y.Value.Value)
                    .Is<AphidFunction>()
                    .Select(y => (Name: y.Key, interpreter, Filename: file.Name))
                    .Select(x =>
                        new TestCaseData(x.interpreter, x.Name, strictMode, cacheInlining)
                            .SetCategory(Path.GetFileNameWithoutExtension(x.Filename))
                            .SetName(FormatTestName(x.Name, strictMode, cacheInlining)));
            });

        private static string FormatTestName(string funcName, bool strictMode, bool cacheInlining)
        {
            var sb = new StringBuilder(FormatTestNameCore(funcName));
            void append(bool flag, string name) => sb.Append(flag ? $"_{name}" : "");
            append(strictMode, "Strict");
            append(cacheInlining, "CacheInlining");

            return sb.ToString();
        }

        private static string FormatTestNameCore(string funcName)
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
        public void RunTestScript(
            AphidInterpreter interpreter,
            string funcName,
            bool strictMode,
            bool cacheInlining)
        {
            WriteQueryMessage($"Calling {funcName} method");
            interpreter.TakeOwnership();
            interpreter.StrictMode = strictMode;
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
