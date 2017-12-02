using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization; // needed for defining exception .ctors
using Microsoft.Cci;
using Microsoft.Cci.MutableCodeModel;
using System.ComponentModel;

namespace ILWeave
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: ILWeave [Assembly]");

                return 1;
            }

            string tmpDir, newName, newPdb;

            using (var host = new PeReader.DefaultHost())
            {
                Console.WriteLine(string.Format("Loading module {0}", args[0]));

                var module = host.LoadUnitFrom(args[0]) as IModule;

                if (module == null || module is Dummy)
                {
                    Console.WriteLine("{0} is not a PE file containing a CLR assembly, or an error occurred when loading it.", args[0]);

                    return 1;
                }

                //module = new MetadataDeepCopier(host).Copy(module);
                PdbReader pdbReader = null;
                var pdbFile = Path.ChangeExtension(module.Location, "pdb");

                if (File.Exists(pdbFile))
                {
                    using (var pdbStream = File.OpenRead(pdbFile))
                    {
                        pdbReader = new PdbReader(pdbStream, host);
                    }
                }
                else
                {
                    Console.WriteLine("Could not load the PDB file for '" + module.Name.Value + "' . Proceeding anyway.");
                }
                using (pdbReader)
                {
                    var localScopeProvider = pdbReader == null ? null : new ILGenerator.LocalScopeProvider(pdbReader);

                    try
                    {
                        module = PropertyChangedWeaver.RewriteModule(
                            host,
                            localScopeProvider,
                            pdbReader,
                            module);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("Error: {0}", e);
                        Environment.Exit(5);
                    }

                    tmpDir = Directory.CreateDirectory(Path.GetRandomFileName()).FullName;
                    newName = Path.Combine(tmpDir, Path.GetFileName(args[0]));

                    using (var peStream = File.Create(newName))
                    {
                        newPdb = Path.ChangeExtension(newName, ".pdb");

                        using (var pdbWriter = new PdbWriter(newPdb, pdbReader))
                        {
                            PeWriter.WritePeToStream(module, host, peStream, pdbReader, localScopeProvider, pdbWriter);
                        }
                    }
                }
            }

            var dst = Path.GetDirectoryName(args[0]);

            foreach (var s in Directory.GetFiles(tmpDir))
            {
                File.Copy(s, Path.Combine(dst, Path.GetFileName(s)), true);
            }

            Directory.Delete(tmpDir, true);

            return 0;
        }
    }
}
