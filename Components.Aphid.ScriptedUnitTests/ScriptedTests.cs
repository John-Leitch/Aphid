#define ALL_SCRIPTS
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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.UnitTests.Shared
{
    [TestFixture(Category = "ScriptedTests"), Parallelizable(ParallelScope.Self)]
    public class ScriptedTests : AphidTests
    {
        private static readonly List<AphidExpression> _prologueAst = AphidParser.Parse(@"
            using Components.Aphid.UnitTests;
            using Components.Aphid.UnitTests.Shared;
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

        private static IEnumerable<TestCaseData> Tests => _tests.Value.Memoize();

#if ALL_SCRIPTS
        private static Lazy<IEnumerable<TestCaseData>> _tests = new Lazy<IEnumerable<TestCaseData>>(() =>
            _aphidDirectory
                .GetDirectories("ScriptedTests")
                .Single()
                .GetFiles("*.alx", SearchOption.AllDirectories)
                .Where(x => x.Extension.Equals(".alx", StringComparison.OrdinalIgnoreCase))
                .Except(x => _ignoreScripts.Contains(x.Name.ToLower()))
                .AsParallel()
                .WithDegreeOfParallelism(Environment.ProcessorCount)
                .WithMergeOptions(ParallelMergeOptions.NotBuffered)
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .SelectMany(GetTestsCasesFromFiles));
#else
        private static readonly string _asmName = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);

        private static readonly string _targetScript =
            _asmName.Count(x => x == '.') < 3 ?
                null :
                _asmName
                    .SubstringAtIndexOf('.', 1)
                    .SubstringAtIndexOf('.', 1)
                    .SubstringAtIndexOf('.', 1);

        private static Lazy<IEnumerable<TestCaseData>> _tests =
            new Lazy<IEnumerable<TestCaseData>>(() =>
            {
                if (_targetScript == null)
                {
                    WriteInfoMessage($"No target script for assembly {_asmName}");
                    return Array.Empty<TestCaseData>();
                }
                else
                {
                    WriteQueryMessage($"Finding companion scripts for assembly {_asmName}");
                    return _aphidDirectory
                        .GetDirectories("ScriptedTests")
                        .Single()
                        .GetFiles($"{_targetScript}.alx", SearchOption.AllDirectories)
                        .Where(x => x.Extension.Equals(".alx", StringComparison.OrdinalIgnoreCase))
                        .Except(x => _ignoreScripts.Contains(x.Name.ToLower()))
                        .AsParallel()
                        .WithDegreeOfParallelism(Environment.ProcessorCount)
                        .WithMergeOptions(ParallelMergeOptions.NotBuffered)
                        .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                        .SelectMany(GetTestsCasesFromFiles);
                }
            });
#endif

        private static IEnumerable<TestCaseData> GetTestsCasesFromFiles(FileInfo file) =>
            new Variations<bool>(new[] { true, false }, 3, GenerateOption.WithRepetition)
            .SelectMany(flags =>
            {
                var (strictMode, cacheInlining, disableConstantFolding) =
                    (flags[0], flags[1], flags[2]);

                WriteQueryMessage($"Caching {file.FullName}");
                var interpreter = new AphidInterpreter() { StrictMode = strictMode };
                interpreter.Loader.SearchPaths.Add(_aphidDirectory.FullName);
                interpreter.Loader.SearchPaths.Add(file.Directory.FullName);
                interpreter.Interpret(_prologueAst);                
                var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray());
                interpreter.Loader.DisableConstantFolding = cache.DisableConstantFolding = disableConstantFolding;
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
                    .Select(y => (Name: y.Key, interpreter, Func: (AphidFunction)y.Value.Value, Filename: file.Name))
                    .Select(x =>
                        new TestCaseData(x.interpreter, x.Name, x.Func)
                            .SetCategory(x.Filename)
                            .SetArgDisplayNames(
                                x.Name,
                                strictMode ? "StrictMode" : "NoStrictMode",
                                cacheInlining ? "CacheInlining" : "NoCacheInlining",
                                disableConstantFolding ? "NoConstantFolding" : "ConstantFolding")
                            .SetDescription(FormatTestName(x.Name, strictMode, cacheInlining)))
                            //.SetCategory(Path.GetFileNameWithoutExtension(x.Filename))
                            //.SetName($"{FormatTestName(x.Name, strictMode, cacheInlining)}({{2}}, {{3}})"));
                            //.SetName($"{FormatTestName(x.Name, strictMode, cacheInlining)}"));
                            ;

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

        [Test, TestCaseSource("Tests")]
        public void RunTestScript(AphidInterpreter interpreter, string funcName, AphidFunction function)
        {
            WriteQueryMessage($"Calling {funcName} method");
            interpreter.TakeOwnership();
            //var result = interpreter.CallFunction(funcName);
            var result = interpreter.CallFunction(function);

            if (result != null && result.Value != null && result.Value.GetType() == typeof(bool))
            {
                var sb = new StringBuilder(string.Format("Function {0} returned false.", funcName));

                if (interpreter.CurrentScope.TryResolve("lastException", out var lastException) &&
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
