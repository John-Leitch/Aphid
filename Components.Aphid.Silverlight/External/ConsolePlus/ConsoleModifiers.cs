
using System.Runtime.Serialization;
namespace Silverlight.System
{
    // Summary:
    //     Represents the SHIFT, ALT, and CTRL modifier keys on a keyboard.
    [DataContract]
    //[Flags]
    public enum ConsoleModifiers
    {
        // Summary:
        //     The left or right ALT modifier key.
        Alt = 1,
        //
        // Summary:
        //     The left or right SHIFT modifier key.
        Shift = 2,
        //
        // Summary:
        //     The left or right CTRL modifier key.
        Control = 4,
    }
}
