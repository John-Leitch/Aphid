using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static class EnvironmentHelper
    {
        private const string architectureVariable = "PROCESSOR_ARCHITECTURE",
            _amd64 = "amd64",
            _x86 = "x86";

        public static string GetArgString()
        {
            return Environment
                .GetCommandLineArgs()
                .Select(x => !x.Any(Char.IsWhiteSpace) ? x : "\"" + x + "\"")
                .Join(" ");
        }

        public static string GetArchitecture()
        {
            return Environment.GetEnvironmentVariable(architectureVariable);
        }

        public static bool IsX86()
        {
            return GetArchitecture().ToLower() == _x86;
        }

        public static bool IsAmd64()
        {
            return GetArchitecture().ToLower() == _amd64;
        }
    }
}
