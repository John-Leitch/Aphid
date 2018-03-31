using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    // Todo:
    // *Wire up
    // *generate class from INI file.
    // *Save embedded default config to disk if none present.
    public class AphidConfig : Singleton<AphidConfig>
    {
        public string[] Imports { get; set; }

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
    }
}
