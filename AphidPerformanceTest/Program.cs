using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidPerformanceTest
{
    public class PerfTest
    {
        public string Name { get; set; }

        public string Prologue { get; set; }

        public string Body { get; set; }

        public int Iterations { get; set; }

        public PerfTest()
        {
        }

        public PerfTest(string name, string body, int iterations)
        {
            Name = name;
            Body = body;
            Iterations = iterations;
        }

        public PerfTest(string name, string prologue, string body, int iterations)
            : this(name, body, iterations)
        {
            Prologue = prologue;
        }
    }

    class Program
    {
        private static PerfTest[] _tests = new []
        {
            new PerfTest("increment", "z=0;", "z++;", 1000000),
            new PerfTest("varSet", "z=0;", "z = 1;", 1000000),
            new PerfTest("call", "foo=@() { };", "foo();", 1000000),
            new PerfTest("interopCall", "#'Std';", "str(1);", 1000000),
            new PerfTest("std import", "#'Std';", 1000),
        };

        static void RunTest(PerfTest test, int iterations)
        {
            var interpreter = new AphidInterpreter();

            if (test.Prologue != null)
            {
                interpreter.Interpret(test.Prologue);
            }

            var ast = new AphidParser(new AphidLexer(test.Body).GetTokens()).Parse();

            for (int i = 0; i < iterations; i++)
            {
                interpreter.Interpret(ast);
            }
        }

        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            foreach (var test in _tests)
            {
                RunTest(test, 1);
            }

            foreach (var test in _tests)
            {
                Console.Write("Running {0} test {1:n0} times... ", test.Name, test.Iterations);
                var sw = new Stopwatch();
                sw.Start();
                RunTest(test, test.Iterations);
                sw.Stop();
                Console.WriteLine("finished in {0:n0}ms", sw.ElapsedMilliseconds);
            }
        }
    }
}
