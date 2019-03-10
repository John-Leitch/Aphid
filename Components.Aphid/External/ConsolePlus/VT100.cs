using Components.PInvoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public static class VT100
    {
        public const string Reset = "\x1b[0m";

        public static bool IsEnabled { get; private set; }

        public static string GetString(IEnumerable<ColoredText> coloredTextCollection)
        {
            var sb = new StringBuilder();

            foreach (var ct in coloredTextCollection)
            {
                Append(sb, ct);
            }

            return sb.ToString();
        }

        public static string GetString(ColoredText coloredText) =>
            Append(new StringBuilder(), coloredText).ToString();

        public static StringBuilder Append(StringBuilder sb, ColoredText coloredText)
        {
            if (IsEnabled)
            {
                if (coloredText.ForegroundRgb != null)
                {
                    sb.Append(Foreground(coloredText.ForegroundRgb));
                }

                if (coloredText.BackgroundRgb != null)
                {
                    sb.Append(Background(coloredText.BackgroundRgb));
                }

                sb.Append(coloredText.Text);
                sb.Append(Reset);
            }
            else
            {
                sb.Append(coloredText.Text);
            }

            return sb;
        }

        public static string Rgb(bool bg, byte r, byte g, byte b) =>
            $"\x1b[{((bg ? 4 : 3).ToString())}8;2;{r.ToString()};{g.ToString()};{b.ToString()}m";

        public static string Foreground(byte[] rgb) =>
            Rgb(false, rgb[0], rgb[1], rgb[2]);

        public static string Foreground(byte r, byte g, byte b) =>
            Rgb(false, r, g, b);

        public static string Background(byte[] rgb) =>
            Rgb(true, rgb[0], rgb[1], rgb[2]);

        public static string Background(byte r, byte g, byte b) =>
            Rgb(true, r, g, b);

        public static bool TryEnable()
        {
            try
            {
                Enable();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Enable()
        {
            var handle = Kernel32.GetStdHandle(Win32.STD_OUTPUT_HANDLE);

            if (handle == Win32.INVALID_HANDLE_VALUE)
            {
                throw CreateException("Kernel32!GetStdHandle()");
            }
            else if (!Kernel32.GetConsoleMode(handle, out var mode))
            {
                throw CreateException("kernel32!GetConsoleMode()");
            }
            else if (!Kernel32.SetConsoleMode(handle, mode | ConsoleMode.ENABLE_VIRTUAL_TERMINAL_PROCESSING))
            {
                throw CreateException("kernel32!SetConsoleMode()");
            }

            IsEnabled = true;
        }

        private static InvalidOperationException CreateException(string id)
        {
            var code = Marshal.GetLastWin32Error();
            var win32Exception = new Win32Exception(code);

            var msg = string.Format(
                "{0} failed with error code {1}: {2}",
                id,
                code,
                win32Exception.Message.ToCharArray());

            return new InvalidOperationException(msg, win32Exception);
        }

        public static void DumpColors(bool background = false)
        {
            Enable();

            var str = typeof(SystemColor)
                .GetFields()
                .Where(x => x.FieldType == typeof(byte[]))
                .ToDictionary(x => (byte[])x.GetValue(null), x => x.Name)
                .OrderBy(x =>
                    x.Key[0] << 0x10 |
                    x.Key[1] << 0x8 |
                    x.Key[2])
                .Select(x => string.Format(
                    "{0}{1}{2}{3}",
                    Foreground(x.Key),
                    background ? LogBackground(x.Key) : "",
                    x.Value,
                    Reset))
                .Join(" ");

            Console.WriteLine(str);
        }

        private static string LogBackground(byte[] background)
        {
            var bg = Background(
                (byte)~background[0],
                (byte)~background[1],
                (byte)~background[2]);

            return bg + bg.Replace("\x1b", "");
        }

        public static string Escape(string s) => s.Replace("\x1b", "\\x1b");

        public static void TestVT100()
        {
            Enable();

            var c = '-';

            char nextChar()
            {
                if (c == '-')
                {
                    c = '\\';
                }
                else if (c == '\\')
                {
                    c = '|';
                }
                else if (c == '|')
                {
                    c = '/';
                }
                else if (c == '/')
                {
                    c = '-';
                }

                return c;
            }

            for (var x = 0; x < 100; x++)
            {
                for (var i = 0; i < 255; i++)
                {
                    Console.Write(
                        Background((byte)i, 0, (byte)(0xff - i)) +
                        Foreground((byte)(0xff - i), 0, (byte)i) + nextChar().ToString());
                }

                for (var i = 0; i < 255; i++)
                {
                    Console.Write(
                        Background((byte)(0xff - i), 0, (byte)i) +
                        Foreground((byte)i, 0, (byte)(0xff - i)) + nextChar().ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
