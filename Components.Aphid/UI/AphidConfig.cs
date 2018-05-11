using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    // Todo:
    // *Wire up
    // *generate class from INI file.
    // *Save embedded default config to disk if none present.
    public class AphidConfig : DefaultSingleton<AphidConfig>
    {
        private static Lazy<Configuration> _config = new Lazy<Configuration>(LoadConfig);

        private Lazy<bool>
            _strictMode = GetBool(AphidSettings.StrictMode, defaultValue: true),
            _saveErrors = GetBool(AphidSettings.SaveErrors, defaultValue: false),
            _stackTraceParams = GetBool(AphidSettings.StackTraceParams, defaultValue: false);

        private Lazy<string[]>
            _imports = GetArray(AphidSettings.AutoImport, defaultValue: new string[0]),
            _includes = GetArray(AphidSettings.AutoInclude, defaultValue: new string[0]);

        public string[] Imports
        {
            get { return _imports.Value; }
        }

        public bool StrictMode
        {
            get { return _strictMode.Value; }
        }

        public bool SaveErrors
        {
            get { return _saveErrors.Value; }
        }

        public bool StackTraceParams
        {
            get { return _stackTraceParams.Value; }
        }

        public bool ExceptionHandlingDisabled { get; set; }

        public bool ExceptionHandlingClrStack { get; set; }

        public bool ReplShowHelpArgWarning { get; set; }

        public bool ReplJit { get; set; }

        public bool ReplLoggingInput { get; set; }

        public bool ReplLoggingOutput { get; set; }

        public bool ReplLoggingCombined { get; set; }

        public bool ConsoleAsync { get; set; }

        public AphidConfig()
            : base()
        {

        }

        private static Lazy<bool> GetBool(string name, bool defaultValue = false)
        {
            return _config.Value != null ?
                new Lazy<bool>(() => Convert.ToBoolean(GetSetting(name))) :
                new Lazy<bool>(() => defaultValue);
        }

        private static Lazy<string[]> GetArray(string name, string[] defaultValue = null)
        {
            return _config.Value != null ? 
                new Lazy<string[]>(() => (GetSetting(name) ?? "")
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray()) :
                new Lazy<string[]>(() => defaultValue);
        }

        private static string GetSetting(string name)
        {
            var setting = _config.Value.AppSettings.Settings[name];

            return setting != null ? setting.Value : null;
        }

        private static Configuration LoadConfig()
        {
            try
            {
                return ConfigurationManager.OpenExeConfiguration(
                    typeof(AphidConfig).Assembly.Location);
            }
            catch
            {
                return null;
            }
        }
    }
}
