using System.IO;
using System.Reflection;

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
