using System;
using System.Configuration;
using System.Linq;
using AS = Components.Aphid.UI.AphidSettings;
using static System.IO.Path;
using LB = Components.MutableLazy<bool>;
using LI = Components.MutableLazy<int>;
using LS = Components.MutableLazy<string>;
using LA = Components.MutableLazy<string[]>;

namespace Components.Aphid.UI
{
    // Todo:
    // *Wire up
    // *generate class from INI file.
    // *Save embedded default config to disk if none present.
    public class AphidConfig : DefaultSingleton<AphidConfig>
    {
        public const string FileName = "Components.Aphid.dll.config";

        private static readonly Lazy<Configuration> _config = new Lazy<Configuration>(LoadConfig);

        private LS
            _sourcePath = GetSetting(AS.SourcePath);

        private LB
            _strictMode = GetBool(AS.StrictMode, true),
            _saveErrors = GetBool(AS.SaveErrors, false),
            _stackTraceParams = GetBool(AS.StackTraceParams, false),
            _showErrorExpression = GetBool(AS.ShowErrorExpression, false),
            _showErrorStatement = GetBool(AS.ShowErrorStatement, false),
            _showErrorFrameExcerpts = GetBool(AS.ShowErrorFrameExcerpts, true),
            _showErrorScope = GetBool(AS.ShowErrorScope, false),
            _showErrorFileList = GetBool(AS.ShowErrorFileList, false),
            _showClrStack = GetBool(AS.ShowClrStack, false),
            _scriptCaching = GetBool(AS.ScriptCaching, false),
            _ignoreDebugger = GetBool(AS.IgnoreDebugger, false),
            _requestDebugger = GetBool(AS.RequestDebugger, false);

        private LI
            _stackTraceParamsMax = GetInt32(AS.StackTraceParamsMax, 100),
            _frameExcerptsMax = GetInt32(AS.FrameExcerptsMax, 4),
            _frameExcerptLines = GetInt32(AS.FrameExcerptLines, 12);

        private LA _imports = GetArray(AS.AutoImport, Array.Empty<string>());
        private LA _includes = GetArray(AS.AutoInclude, Array.Empty<string>());

        public string[] Imports { get => _imports.Value; set => _imports = value; }
        public bool StrictMode { get => _strictMode.Value; set => _strictMode = value; }
        public bool SaveErrors { get => _saveErrors.Value; set => _saveErrors = value; }
        public bool StackTraceParams { get => _stackTraceParams.Value; set => _stackTraceParams = value; }
        public int StackTraceParamsMax { get => _stackTraceParamsMax.Value; set => _stackTraceParamsMax = value; }
        public bool ShowErrorExpression { get => _showErrorExpression.Value; set => _showErrorExpression = value; }
        public bool ShowErrorStatement { get => _showErrorStatement.Value; set => _showErrorStatement = value; }
        public bool ShowErrorFrameExcerpts { get => _showErrorFrameExcerpts.Value; set => _showErrorFrameExcerpts = value; }
        public int FrameExcerptsMax { get => _frameExcerptsMax.Value; set => _frameExcerptsMax = value; }
        public int FrameExcerptLines { get => _frameExcerptLines.Value; set => _frameExcerptLines = value; }
        public bool ShowErrorScope { get => _showErrorScope.Value; set => _showErrorScope = value; }
        public bool ShowErrorFileList { get => _showErrorFileList.Value; set => _showErrorFileList = value; }
        public bool ScriptCaching { get => _scriptCaching.Value; set => _scriptCaching = value; }
        public bool IgnoreDebugger { get => _ignoreDebugger.Value; set => _ignoreDebugger = value; }
        public bool RequestDebugger { get => _requestDebugger.Value; set => _requestDebugger = value; }
        public string SourcePath { get => _sourcePath.Value; set => _sourcePath = value; }
        public bool ExceptionHandlingClrStack { get => _showClrStack.Value; set => _showClrStack = value; }        
        public bool ReplShowHelpArgWarning { get; set; }
        public bool ReplJit { get; set; }
        public bool ReplLoggingInput { get; set; }
        public bool ReplLoggingOutput { get; set; }
        public bool ReplLoggingCombined { get; set; }
        public bool ConsoleAsync { get; set; }

        private static LB GetBool(string name, bool defaultValue = false) =>
            _config.Value != null ?
                new LB(() => GetSetting(name)
                    .If(string.IsNullOrEmpty, x => defaultValue)
                    .Else(Convert.ToBoolean)) :
                new LB(() => defaultValue);

        private static LI GetInt32(string name, int defaultValue = 0) =>
            _config.Value != null ?
                new LI(() => GetSetting(name)
                    .If(string.IsNullOrEmpty, x => defaultValue)
                    .Else(int.Parse)) :
                new LI(() => defaultValue);

        private static LA GetArray(string name, string[] defaultValue = null) =>
            _config.Value != null ?
                new LA(() =>
                    (GetSetting(name) ?? "")
                        .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray()) :
                new LA(() => defaultValue);

        private static string GetSetting(string name) =>
            _config.Value.AppSettings.Settings[name]?.Value;

        //private static string GetSettingOverride(string name) =>
        //    Environment.GetCommandLineArgs

        private static Configuration LoadConfig()
        {
            //try
            //{
            var l = typeof(AphidConfig).Assembly.Location;
            string path = l != null ? Combine(GetDirectoryName(l), FileName) : FileName;
            return ConfigurationManager.OpenMappedExeConfiguration(
                new ExeConfigurationFileMap { ExeConfigFilename = path },
                ConfigurationUserLevel.None);
            //}
            //catch
            //{
            //    return null;
            //}
        }
    }
}
