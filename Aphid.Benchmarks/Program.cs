using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;
using Components.External;
using System.Reflection;
using System.IO;
using System.Threading;
using Components.External.ConsolePlus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using Components.Aphid.Interpreter;

namespace Aphid.Benchmarks
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var exe = PathHelper.GetEntryPath("NBench.Runner.exe");
            
        //    var runnerArgs = new[]
        //    {
        //        Assembly.GetEntryAssembly().Location,
        //        "--concurrent",
        //        "true",
        //        //"--output",
        //        //".\\"
        //    };

        //    var domain = AppDomain.CreateDomain("RunnerDomain");
        //    domain.ExecuteAssembly(exe, runnerArgs);
        //    AppDomain.Unload(domain);
        //    //var ArgLockingMemoizer
        //}

        static void Main(string[] args) => BenchmarkSwitcher
            .FromAssembly(typeof(Program).Assembly)
            .Run(args);
    }
}
