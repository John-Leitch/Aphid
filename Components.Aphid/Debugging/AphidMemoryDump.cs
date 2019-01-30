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
            try
            {
                var f = PathHelper.GetExecutingPath(
                    string.Format("AphidMemory-{0}.dmp", Guid.NewGuid()));

                MemoryDump.Create(f);
                Cli.WriteCriticalErrorMessage("Created memory dump '{0}'.", f);

                return f;
            }
            catch
            {
                Cli.WriteCriticalErrorMessage("Failed creating memory dump.");

                return null;
            }
        }
    }
}
