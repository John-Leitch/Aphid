using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class AphidHdlApplication : CliApplication<AphidHdlArgs>
    {
        private static void Compile(string filename, string outputPath)
        {
            var dir = Path.GetDirectoryName(Path.GetFullPath(filename));
            Directory.SetCurrentDirectory(dir);
            Cli.WriteLine("Compiling ~Cyan~{0}~R~", filename);
            List<AphidExpression> ast;
            var code = File.ReadAllText(filename);

            try
            {
                ast = AphidParser.Parse(code, useImplicitReturns: false);
            }
            catch (AphidParserException e)
            {
                Console.WriteLine(ParserErrorMessage.Create(code, e, true));
                Console.ReadKey();

                return;
            }

            var emitter = new AphidVerilogEmitter();

            //var mutatorGroup = new AphidMutatorGroup();

            foreach (var m in new AphidMutator[]
            {
                new IncludeMutator(dir, false),
                new AphidMacroMutator(),
                new ConstantFoldingMutator(),
                new ForUnrollMutator(),
                new DynamicIdentifierMutator(),
            })
            {
                ast = m.MutateRecursively(ast);
            }

            //ast = mutatorGroup.MutateRecursively(ast);
            var verilog = emitter.Emit(ast);
            var outFile = Path.GetFileNameWithoutExtension(filename) + ".v";

            if (outputPath == null)
            {
                outputPath = Path.GetDirectoryName(filename);
            }

            outFile = Path.Combine(outputPath, outFile);
            Cli.WriteLine("Writing Verilog to ~Cyan~{0}~R~", outFile);
            File.WriteAllText(outFile, verilog);
            Cli.WriteLine("~Green~Done~R~");
        }

        public override void Main(AphidHdlArgs args)
        {
            Compile(args.InputFile.FullName, args.OutputPath);
        }
    }
}
