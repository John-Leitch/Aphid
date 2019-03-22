using System;
using System.Linq;

namespace Components
{
    public static class EnvironmentHelper
    {
        private const string architectureVariable = "PROCESSOR_ARCHITECTURE",
            _amd64 = "amd64",
            _x86 = "x86";

        public static string GetArgString() => Environment
                .GetCommandLineArgs()
                .Select(x => !x.Any(char.IsWhiteSpace) ? x : "\"" + x + "\"")
                .Join(" ");

        public static string GetArchitecture() =>
            Environment.GetEnvironmentVariable(architectureVariable);

        public static bool IsX86() => GetArchitecture().ToLower() == _x86;

        public static bool IsAmd64() => GetArchitecture().ToLower() == _amd64;
    }
}
