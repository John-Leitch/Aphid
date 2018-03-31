using Components;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class AphidHdlArgs
    {
        [CliArg(
            "-i",
            "-input",
            "/i",
            "/input",
            IsRequired = true,
            IsInputFile = true,
            ValueName = "Input file",
            Description = "The Aphid input file.")]
        public FileInfo InputFile { get; set; }

        [CliArg(
            "-o",
            "-output",
            "/o",
            "/output",
            ValueName = "Output path",
            IsRequired = false,
            Description = "Output path where Verilog files are emitted. Defaults to the path of the input file.")]
        public string OutputPath { get; set; }        
    }
}
