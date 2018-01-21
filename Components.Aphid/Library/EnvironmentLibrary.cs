using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Components.Aphid.Library
{
    public class EnvironmentLibrary
    {
        [AphidInteropFunction("env.expand")]
        public static string EnvExpand(string str)
        {
            return Environment.ExpandEnvironmentVariables(str);
        }

        private static string[] _envArgs;

        public static void SetEnvArgs(bool skipFirst = false)
        {
            _envArgs = Environment.GetCommandLineArgs();

            if (skipFirst)
            {
                _envArgs = _envArgs.Skip(1).ToArray();
            }
        }

        [AphidInteropFunction("env.args", UnwrapParameters = false)]
        public static List<AphidObject> EnvArgs()
        {
            if (_envArgs == null)
            {
                SetEnvArgs();
            }

            return _envArgs.Select(x => new AphidObject(x)).ToList();
        }

        [AphidInteropFunction("env.kill", UnwrapParameters = false, PassInterpreter = true)]
        public static void Kill(AphidInterpreter interpreter, AphidObject process)
        {
            if (process.Value is int)
            {
                Process.GetProcessById((int)process.Value).Kill();
            }
            else if (process.Value is string)
            {
                foreach (var p in Process.GetProcessesByName((string)process.Value))
                {
                    p.Kill();
                    p.WaitForExit();
                }
            }
            else
            {
                throw interpreter.CreateRuntimeException(
                    "Invalid process id: {0}",
                    process.Value);
            }
        }

        [AphidInteropFunction("env.execInternal", UnwrapParameters = false)]
        private static AphidObject Exec(AphidObject exeObj, AphidObject argsObj, AphidObject optionsObj)
        {
            string exe = (string)exeObj.Value, args = argsObj != null ? (string)argsObj.Value : null;

            var opt = optionsObj != null ?
                optionsObj.ConvertTo<ExecOptions>() :
                new ExecOptions();

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(exe, args)
                {
                    RedirectStandardOutput = opt.RedirectOutput,
                    RedirectStandardError = opt.RedirectOutput,
                    UseShellExecute = !opt.RedirectOutput,
                }
            };

            if (!string.IsNullOrEmpty(opt.Working))
            {
                process.StartInfo.WorkingDirectory = opt.Working;
                process.StartInfo.UseShellExecute = false;
            }

            var sb = new StringBuilder();

            DataReceivedEventHandler handler = (o, e) =>
            {
                lock (sb)
                {
                    sb.AppendLine(e.Data);
                }
            };

            if (opt.RedirectOutput)
            {
                process.OutputDataReceived += handler;
                process.ErrorDataReceived += handler;
            }

            process.Start();

            if (opt.RedirectOutput)
            {
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }

            if (opt.RedirectOutput || opt.WaitForExit)
            {
                process.WaitForExit();

                var retVal = new AphidObject();
                retVal.Add("exitCode", new AphidObject((decimal)process.ExitCode));

                if (opt.RedirectOutput)
                {
                    retVal.Add("output", new AphidObject(sb.ToString()));
                }

                return retVal;
            }
            else
            {
                return null;
            }
        }

        [AphidInteropFunction("env.exit")]
        public static void Exit(decimal exitCode)
        {
            Environment.Exit((int)exitCode);
        }

        [AphidInteropFunction("env.processes")]
        public static List<AphidObject> GetProcesses()
        {
            return Process
                .GetProcesses()
                .Select(x => new AphidObject() 
                { 
                    { "id", new AphidObject((decimal)x.Id) }, 
                    { "name", new AphidObject(x.ProcessName) } 
                })
                .ToList();
        }
    }
}
