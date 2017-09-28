#region Assembly mscorlib.dll, v4.0.0.0
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\mscorlib.dll
#endregion

using System;
using System.Runtime.Serialization;

namespace Silverlight.System
{
    // Summary:
    //     Provides data for the System.Console.CancelKeyPress event. This class cannot
    //     be inherited.
    [DataContract]
    public sealed class ConsoleCancelEventArgs : EventArgs
    {
        // Summary:
        //     Gets or sets a value that indicates whether simultaneously pressing the System.ConsoleModifiers.Control
        //     modifier key and the System.ConsoleKey.C console key (Ctrl+C) or the Ctrl+Break
        //     keys terminates the current process. The default is false, which terminates
        //     the current process.
        //
        // Returns:
        //     true if the current process should resume when the event handler concludes;
        //     false if the current process should terminate. The default value is false;
        //     the current process terminates when the event handler returns. If true, the
        //     current process continues.
        public bool Cancel { get; set; }
        //
        // Summary:
        //     Gets the combination of modifier and console keys that interrupted the current
        //     process.
        //
        // Returns:
        //     One of the enumeration values that specifies the key combination that interrupted
        //     the current process. There is no default value.
        public ConsoleSpecialKey SpecialKey { get; }
    }
}
