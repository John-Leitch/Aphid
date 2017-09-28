#region Assembly mscorlib.dll, v4.0.0.0
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\mscorlib.dll
#endregion

using System;
using System.Runtime.Serialization;
using Console = Silverlight.System.Console;
using ConsoleCancelEventArgs = Silverlight.System.ConsoleCancelEventArgs;
using ConsoleCancelEventHandler = Silverlight.System.ConsoleCancelEventHandler;
using ConsoleColor = Silverlight.System.ConsoleColor;
using ConsoleKey = Silverlight.System.ConsoleKey;
using ConsoleKeyInfo = Silverlight.System.ConsoleKeyInfo;
using ConsoleModifiers = Silverlight.System.ConsoleModifiers;
using ConsoleSpecialKey = Silverlight.System.ConsoleSpecialKey;

namespace Silverlight.System
{
    // Summary:
    //     Describes the console key that was pressed, including the character represented
    //     by the console key and the state of the SHIFT, ALT, and CTRL modifier keys.
    [DataContract]
    public struct ConsoleKeyInfo
    {
        //
        // Summary:
        //     Initializes a new instance of the System.ConsoleKeyInfo structure using the
        //     specified character, console key, and modifier keys.
        //
        // Parameters:
        //   keyChar:
        //     The Unicode character that corresponds to the key parameter.
        //
        //   key:
        //     The console key that corresponds to the keyChar parameter.
        //
        //   shift:
        //     true to indicate that a SHIFT key was pressed; otherwise, false.
        //
        //   alt:
        //     true to indicate that an ALT key was pressed; otherwise, false.
        //
        //   control:
        //     true to indicate that a CTRL key was pressed; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The numeric value of the key parameter is less than 0 or greater than 255.
        public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { throw new NotImplementedException(); }

        // Summary:
        //     Indicates whether the specified System.ConsoleKeyInfo objects are not equal.
        //
        // Parameters:
        //   a:
        //     The first object to compare.
        //
        //   b:
        //     The second object to compare.
        //
        // Returns:
        //     true if a is not equal to b; otherwise, false.
        public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Indicates whether the specified System.ConsoleKeyInfo objects are equal.
        //
        // Parameters:
        //   a:
        //     The first object to compare.
        //
        //   b:
        //     The second object to compare.
        //
        // Returns:
        //     true if a is equal to b; otherwise, false.
        public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b) { throw new NotImplementedException(); }

        // Summary:
        //     Gets the console key represented by the current System.ConsoleKeyInfo object.
        //
        // Returns:
        //     A value that identifies the console key that was pressed.
        public ConsoleKey Key { get; }
        //
        // Summary:
        //     Gets the Unicode character represented by the current System.ConsoleKeyInfo
        //     object.
        //
        // Returns:
        //     An object that corresponds to the console key represented by the current
        //     System.ConsoleKeyInfo object.
        public char KeyChar { get; }
        //
        // Summary:
        //     Gets a bitwise combination of System.ConsoleModifiers values that specifies
        //     one or more modifier keys pressed simultaneously with the console key.
        //
        // Returns:
        //     A bitwise combination of the enumeration values. There is no default value.
        public ConsoleModifiers Modifiers { get; }

        // Summary:
        //     Gets a value indicating whether the specified System.ConsoleKeyInfo object
        //     is equal to the current System.ConsoleKeyInfo object.
        //
        // Parameters:
        //   obj:
        //     An object to compare to the current System.ConsoleKeyInfo object.
        //
        // Returns:
        //     true if obj is equal to the current System.ConsoleKeyInfo object; otherwise,
        //     false.
        public bool Equals(ConsoleKeyInfo obj) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Gets a value indicating whether the specified object is equal to the current
        //     System.ConsoleKeyInfo object.
        //
        // Parameters:
        //   value:
        //     An object to compare to the current System.ConsoleKeyInfo object.
        //
        // Returns:
        //     true if value is a System.ConsoleKeyInfo object and is equal to the current
        //     System.ConsoleKeyInfo object; otherwise, false.
        public override bool Equals(object value) { throw new NotImplementedException(); }
        //
        // Summary:
        //     Returns the hash code for the current System.ConsoleKeyInfo object.
        //
        // Returns:
        //     A 32-bit signed integer hash code.
        public override int GetHashCode() { throw new NotImplementedException(); }
    }
}