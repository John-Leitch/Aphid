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
        private static Lazy<Configuration> _config = new Lazy<Configuration>(() =>
            ConfigurationManager.OpenExeConfiguration(
                typeof(AphidConfig).Assembly.Location));

        private Lazy<bool> _strictMode = GetBool(AphidSettings.StrictMode),
            _saveErrors = GetBool(AphidSettings.SaveErrors);

        public string[] Imports { get; set; }

        public bool ExceptionHandlingDisabled { get; set; }

        public bool ExceptionHandlingClrStack { get; set; }

        public bool ReplShowHelpArgWarning { get; set; }

        public bool ReplJit { get; set; }

        public bool ReplLoggingInput { get; set; }

        public bool ReplLoggingOutput { get; set; }

        public bool ReplLoggingCombined { get; set; }

        public bool ConsoleAsync { get; set; }

        public bool StrictMode
        {
            get { return _strictMode.Value; }
        }

        public bool SaveErrors
        {
            get { return _saveErrors.Value; }
        }

        public AphidConfig()
            : base()
        {

        }

        private static Lazy<bool> GetBool(string name)
        {
            return new Lazy<bool>(() => Convert.ToBoolean(GetSetting(name)));
        }

        private static string GetSetting(string name)
        {
            var setting = _config.Value.AppSettings.Settings[name];

            return setting != null ? setting.Value : null;
        }
    }
}
