using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Components.Cypress;

namespace Components.External.ConsolePlus
{
    public static class CliApplication
    {
        private const string _titleTimeFormat = "MM/dd/yy hh:mm:ss tt";

        public static void SetTitle() => SetTitle(name: null);

        public static void SetTitle(string name) => SetTitle(name, showHeader: true);

        public static void SetTitle(bool showHeader) => SetTitle(name: null, showHeader: true);

        public static void SetTitle(string name, bool showHeader) => SetTitle(name, showHeader, headerStyle: null);

        public static void SetTitle(
            string name = null,
            bool showHeader = true,
            string headerStyle = null)
        {
            var title = GetTitle(name);
            Console.Title = title;

            if (showHeader)
            {
                Cli.WriteHeader(title, headerStyle ?? Cli.DefaultHeaderStyle);
            }
        }

        public static string GetTitle(string name = null)
        {
            var asm = Assembly.GetEntryAssembly();
            var asmName = asm.GetName();
            var bitness = Environment.Is64BitProcess ? "64" : "32";

            var flags = new StringBuilder();
#if DEBUG
            flags.Append(" DEBUG");
#endif

#if TRACE
            flags.Append(" TRACE");
#endif

            var baseTitle = $"{name ?? asmName.Name} {asmName.Version} {bitness}-bit{flags}";

            DateTime linkTime;

            var title = (linkTime = asm.GetLinkTimeUtc()) == default ?
                baseTitle :
                $"{baseTitle} {linkTime.ToEasternStandardTime().ToString(_titleTimeFormat)}";

            return !Debugger.IsAttached ? title : $"{title} (under debugger)";
        }
    }
}
