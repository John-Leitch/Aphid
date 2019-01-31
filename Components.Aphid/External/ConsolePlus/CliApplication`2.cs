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
    public abstract class CliApplication<TArgs, TConfig> : CliApplication<TArgs>
        where TArgs : class, new()
        where TConfig : new()
    {
        public TConfig Config { get; private set; }

        public override void Launch()
        {
            var asmPath = Assembly.GetEntryAssembly().Location;
            var name = Path.GetFileNameWithoutExtension(asmPath);

            using (var s = File.OpenRead(PathHelper.GetExecutingPath(name + ".xml")))
            {
                Config = XmlObject.Deserialize<TConfig>(s);
            }

            base.Launch();
        }
    }
}
