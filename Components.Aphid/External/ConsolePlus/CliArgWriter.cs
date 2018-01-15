using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public static class CliArgWriter
    {
        private const string
            _optionalDelimterLeft = "[",
            _optionalDelimterRight = "]",
            _valueDelimterLeft = "",
            _valueDelimterRight = "";

        private static string GetReset(string value)
        {
            return !string.IsNullOrEmpty(value) ? "~R~" : "";
        }

        private static string CreateArg(CliArgAttribute arg, string argStyle, string valueStyle, string delimiterStyle, bool useOptionalDelimiters = true)
        {
            var name = arg.Names.First();
            
            if (!string.IsNullOrEmpty(arg.ValueName))
            {
                return string.Format(
                    "{10}{6}{11}{0}{1}{2} {10}{8}{11}{3}{4}{5}{10}{9}{11}{10}{7}{11}",
                    argStyle,
                    name,
                    GetReset(argStyle),
                    valueStyle,
                    arg.ValueName,
                    GetReset(valueStyle),
                    arg.IsRequired || !useOptionalDelimiters ? "" : Cli.Escape(_optionalDelimterLeft),
                    arg.IsRequired || !useOptionalDelimiters ? "" : Cli.Escape(_optionalDelimterRight),
                    Cli.Escape(_valueDelimterLeft),
                    Cli.Escape(_valueDelimterRight),
                    delimiterStyle,
                    GetReset(delimiterStyle));
            }
            else
            {
                return string.Format(
                    "{5}{3}{6}{0}{1}{2}{5}{4}{6}",
                    argStyle,
                    name,
                    GetReset(argStyle),
                    arg.IsRequired || !useOptionalDelimiters ? "" : Cli.Escape(_optionalDelimterLeft),
                    arg.IsRequired || !useOptionalDelimiters ? "" : Cli.Escape(_optionalDelimterRight),
                    delimiterStyle,
                    GetReset(delimiterStyle));
            }
        }

        private static string CreateArgDescription(
            CliArgAttribute arg, 
            string argStyle, 
            string valueStyle, 
            string delimiterStyle)
        {
            var name = arg.Names.First();
            
            var argStr = CreateArg(
                arg, argStyle, 
                valueStyle, 
                delimiterStyle, 
                useOptionalDelimiters: false);

            var requiredStr = arg.IsRequired ? " ~DarkYellow~(Required)~R~" : "";

            return string.Format("~Cyan~{0}~R~{2}\r\n{1}\r\n", argStr, arg.Description, requiredStr);
        }

        private static string[] CreateArgStrings(
            CliArgAttribute[] args,
            string argStyle,
            string argValueStyle,
            string delimiterStyle)
        {
            return args
                .Select(x => CreateArg(x, argStyle, argValueStyle, delimiterStyle))
                .ToArray();
        }

        private static string CreateArgString(
            CliArgAttribute[] args,
            string argStyle,
            string argValueStyle,
            string delimiterStyle)
        {
            var requiredArgs = args.Where(x => x.IsRequired).ToArray();
            var optionalArgs = args.Where(x => !x.IsRequired).ToArray();

            var argStrings = CreateArgStrings(requiredArgs, argStyle, argValueStyle, delimiterStyle)
                .Concat(CreateArgStrings(optionalArgs, argStyle, argValueStyle, delimiterStyle));

            var argStr = string.Join(" ", argStrings);

            return argStr;
        }

        public static void WriteArguments<TArgs>(
            string argStyle = "~Cyan~",
            string argValueStyle = "~White~~|DarkBlue~",
            string delimiterStyle = "~White~")
            where TArgs : new()
        {
            var arguments = CliArgReader.GetAllAttributes<TArgs>();
            var argStr = CreateArgString(arguments, argStyle, argValueStyle, delimiterStyle);
            Cli.WriteSubheader("Arguments", "~|Blue~~White~");
            Cli.WriteLine();

            var cmdStr = string.Format(
                "{0} {1}",
                Path.GetFileName(Assembly.GetEntryAssembly().Location),
                argStr);

            Cli.WriteLine(cmdStr);

            Cli.WriteLine();
            Cli.WriteSubheader("Argument Details", "~|Blue~~White~");
            Cli.WriteLine();

            var args = arguments
                .Select(x => CreateArgDescription(x, argStyle, argValueStyle, delimiterStyle))
                .ToArray();

            foreach (var a in args)
            {
                Cli.WriteLine(a);
            }                
        }
    }
}
