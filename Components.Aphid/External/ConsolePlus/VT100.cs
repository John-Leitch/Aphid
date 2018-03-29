﻿using Components.PInvoke;
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
        private static object _sync = new object();

        public const string Reset = "\x1b[0m";

        public static bool IsEnabled { get; private set; }

        public static string Rgb(bool bg, byte r, byte g, byte b)
        {
            return string.Format(
                "\x1b[{0}8;2;{1};{2};{3}m",
                bg ? 4 : 3,
                r,
                g,
                b);
        }

        public static string Foreground(byte[] rgb)
        {
            return Rgb(false, rgb[0], rgb[1], rgb[2]);
        }

        public static string Foreground(byte r, byte g, byte b)
        {
            return Rgb(false, r, g, b);
        }

        public static string Background(byte[] rgb)
        {
            return Rgb(true, rgb[0], rgb[1], rgb[2]);
        }

        public static string Background(byte r, byte g, byte b)
        {
            return Rgb(true, r, g, b);
        }

        public static void Enable()
        {
            var handle = Kernel32.GetStdHandle(Win32.STD_OUTPUT_HANDLE);

            if (handle == Win32.INVALID_HANDLE_VALUE)
            {
                throw CreateException("Kernel32!GetStdHandle()");
            }

            int mode;

            if (!Kernel32.GetConsoleMode(handle, out mode))
            {
                throw CreateException("kernel32!GetConsoleMode()");
            }

            if (!Kernel32.SetConsoleMode(handle, mode | 0x4))
            {
                throw CreateException("kernel32!SetConsoleMode()");
            }
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
                    VT100.Foreground(x.Key),
                    background ?
                        VT100.Background(
                            (byte)~x.Key[0],
                            (byte)~x.Key[1],
                            (byte)~x.Key[2]) :
                        "",
                    x.Value,
                    VT100.Reset))
                .Join(" ");

            Console.WriteLine(str);
        }

        static void TestVT100()
        {
            Enable();

            char c = '-';

            Func<char> nextChar = () =>
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
            };

            for (var x = 0; x < 100; x++)
            {
                for (int i = 0; i < 255; i++)
                {
                    Console.Write(
                        VT100.Background((byte)i, 0, (byte)(0xff - i)) +
                        VT100.Foreground((byte)(0xff - i), 0, (byte)i) + nextChar());
                }

                for (int i = 0; i < 255; i++)
                {
                    Console.Write(
                        VT100.Background((byte)(0xff - i), 0, (byte)i) +
                        VT100.Foreground((byte)i, 0, (byte)(0xff - i)) + nextChar());
                }
            }

            Console.ReadLine();
        }
    }
}