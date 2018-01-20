using Components.Aphid.Compiler;
using System.IO;
using System.Linq;

namespace AphidCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            new PluginLoader()
                .Load<IAphidCodeObject>()
                .Select(x => new
                {
                    File = x.CodeFile,
                    Code = CSharpHelper.GenerateCode(x.CreateCodeObject())
                })
                .Iter(x => File.WriteAllText(Path.Combine(args[0], x.File), x.Code));            
        }
    }
}
