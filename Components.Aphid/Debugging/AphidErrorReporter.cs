using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public static class AphidErrorReporter
    {
        private static object _sync = new object();

        private static bool _isEnabledSet;

        private static bool _isEnabled;

        public static bool IsEnabled
        {
            get
            {
                lock (_sync)
                {
                    if (!_isEnabledSet)
                    {
                        _isEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["saveErrors"]);
                        _isEnabledSet = true;
                    }
                }

                return _isEnabled;
            }
        }

        public static bool IsInitialized { get; private set; }

        public static void Init()
        {
            lock (_sync)
            {
                if (!IsInitialized)
                {
                    if (IsEnabled)
                    {
                        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
                    }
                    
                    IsInitialized = true;
                }
            }
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            SaveErrorInformation((Exception)e.ExceptionObject);
        }

        public static void SaveErrorInformation(Exception o)
        {
            SaveErrorInformation(o, null);
        }

        public static void SaveErrorInformation(Exception o, AphidInterpreter interpreter)
        {
            lock (_sync)
            {
                if (IsEnabled)
                {
                    SaveErrorInformationCore(o, interpreter);
                }
            }
        }

        private static void SaveErrorInformationCore(Exception o, AphidInterpreter interpreter)
        {
            var dumpFile = AphidMemoryDump.Create();
            AphidLoadScriptException ale;
            AphidRuntimeException are;
            AphidInterpreter exInterpreter = null;

            if ((ale = o as AphidLoadScriptException) != null)
            {
                exInterpreter = ale.Interpreter;
                AphidCli.DumpException(ale, ale.Interpreter);
            }
            else if ((are = o as AphidRuntimeException) != null)
            {
                exInterpreter = are.Interpreter;
                AphidCli.DumpException(are, are.Interpreter);
            }
            else
            {
                AphidCli.DumpException(o, null);
            }

            var i = exInterpreter ?? interpreter;

            if (dumpFile != null && i != null)
            {
                File.WriteAllText(
                    Path.ChangeExtension(dumpFile, "alxd"),
                    new AphidSerializer(i).Serialize(i.CurrentScope));
            }

            Environment.Exit(0xbad02);
        }
    }
}
