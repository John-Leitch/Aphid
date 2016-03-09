using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    class Program
    {
        private static void Main(string[] args)
        {
            new StringCompilerCli(
                "Boxelder", 
                "Python", 
                "py", 
                new AphidPythonEmitter(), 
                args)
                .Compile();
        }        
    }
}
