using System;
using System.Configuration;
using System.Linq;
using AS = Components.Aphid.UI.AphidSettings;
using static System.IO.Path;
using LB = System.Lazy<bool>;
using LI = System.Lazy<int>;
using LA = System.Lazy<string[]>;

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

        private readonly LB
            _strictMode = GetBool(AS.StrictMode, true),
            _saveErrors = GetBool(AS.SaveErrors, false),
            _stackTraceParams = GetBool(AS.StackTraceParams, false),
            _showErrorExpression = GetBool(AS.ShowErrorExpression, false),
            _showErrorStatement = GetBool(AS.ShowErrorStatement, false),
            _showErrorFrameExcerpts = GetBool(AS.ShowErrorFrameExcerpts, true),
            _showErrorScope = GetBool(AS.ShowErrorScope, false),
            _showErrorFileList = GetBool(AS.ShowErrorFileList, false),
            _scriptCaching = GetBool(AS.ScriptCaching, false),
            _ignoreDebugger = GetBool(AS.IgnoreDebugger, false);

        private readonly LI
            _stackTraceParamsMax = GetInt32(AS.StackTraceParamsMax, 100),
            _frameExcerptsMax = GetInt32(AS.FrameExcerptsMax, 4),
            _frameExcerptLines = GetInt32(AS.FrameExcerptLines, 12);

        private readonly LA _imports = GetArray(AS.AutoImport, Array.Empty<string>());
        private readonly LA _includes = GetArray(AS.AutoInclude, Array.Empty<string>());

        public string[] Imports => _imports.Value;
        public bool StrictMode => _strictMode.Value;
        public bool SaveErrors => _saveErrors.Value;
        public bool StackTraceParams => _stackTraceParams.Value;
        public int StackTraceParamsMax => _stackTraceParamsMax.Value;
        public bool ShowErrorExpression => _showErrorExpression.Value;
        public bool ShowErrorStatement => _showErrorStatement.Value;
        public bool ShowErrorFrameExcerpts => _showErrorFrameExcerpts.Value;
        public int FrameExcerptsMax => _frameExcerptsMax.Value;
        public int FrameExcerptLines => _frameExcerptLines.Value;
        public bool ShowErrorScope => _showErrorScope.Value;
        public bool ShowErrorFileList => _showErrorFileList.Value;
        public bool ScriptCaching => _scriptCaching.Value;
        public bool IgnoreDebugger => _ignoreDebugger.Value;
        public bool ExceptionHandlingDisabled { get; set; }
        public bool ExceptionHandlingClrStack { get; set; }
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

        private static Configuration LoadConfig()
        {
            //try
            //{
                var l = typeof(AphidConfig).Assembly.Location;
                string path;

                if (l != null)
                {
                    path = Combine(GetDirectoryName(l), FileName);
                }
                else
                {
                    path = FileName;
                }

                return ConfigurationManager.OpenMappedExeConfiguration(
                    new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = path
                    },
                    ConfigurationUserLevel.None);
            //}
            //catch
            //{
            //    return null;
            //}
        }
    }
}
