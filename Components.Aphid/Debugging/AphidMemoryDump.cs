using Components.Cypress;
using Components.External;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public static class AphidMemoryDump
    {
        public static string Create()
        {
            var f = PathHelper.GetEntryPath($"AphidMemory-{Guid.NewGuid()}.dmp");

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
    }
}
