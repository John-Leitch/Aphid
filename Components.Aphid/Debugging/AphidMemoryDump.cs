using Components.Cypress;
using Components.External;
using Components.External.ConsolePlus;
using System;

namespace Components.Aphid.Debugging
{
    public static class AphidMemoryDump
    {
        public static string Create()
        {
            var f = CreateName();

            try
            {
                MemoryDump.Create(f);
                Cli.WriteCriticalErrorMessage($"Created memory dump '{f}'.");

                return f;
            }
            catch
            {
                Cli.WriteCriticalErrorMessage($"Failed creating memory dump '{f}'.");

                return null;
            }
        }

        public static string CreateName() =>
            PathHelper.GetEntryPath($"AphidMemory-{Guid.NewGuid().ToString()}.dmp");
    }
}
