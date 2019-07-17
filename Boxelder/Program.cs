using Components.Aphid.Compiler;

namespace Boxelder
{
    internal class Program
    {
        private static void Main(string[] args) => new StringCompilerCli(
                "Boxelder",
                "Python",
                "py",
                new AphidPythonEmitter(),
                isText: false)
                .Compile();
    }
}
