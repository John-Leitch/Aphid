using Components.PInvoke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class ConsoleGraphics
    {
        private IntPtr _stdOut;

        private SmallRect _writeRegion;

        private Coord _bufferCoords;

        public int CanvasWidth { get; set; }

        public int CanvasHeight { get; set; }

        public CharInfo[,] Canvas { get; set; }

        public bool IsInitialized { get; private set; }

        public ConsoleGraphics()
            : this(Console.WindowWidth, Console.WindowHeight)
        {
        }

        public ConsoleGraphics(int canvasWidth, int canvasHeight)
        {
            CanvasWidth = canvasWidth;
            CanvasHeight = canvasHeight;
            Canvas = new CharInfo[CanvasHeight, CanvasWidth];
        }

        public void Init()
        {
            if (IsInitialized)
            {
                throw new InvalidOperationException();
            }

            _stdOut = Kernel32.GetStdHandle(Win32.STD_OUTPUT_HANDLE);

            if (!Kernel32.GetConsoleMode(_stdOut, out var mode))
            {
                Win32.ThrowWin32Exception();
            }

            //mode &= ~ConsoleMode.ENABLE_PROCESSED_OUTPUT |
            //ConsoleMode.DISABLE_NEWLINE_AUTO_RETURN

            mode |= ConsoleMode.ENABLE_VIRTUAL_TERMINAL_PROCESSING;

            if (!Kernel32.SetConsoleMode(_stdOut, mode))
            {
                Win32.ThrowWin32Exception();
            }

            IsInitialized = true;

            for (var cursorY = 0; cursorY < CanvasWidth; cursorY++)
            {
                for (var cursorX = 0; cursorX < CanvasHeight; cursorX++)
                {
                    Canvas[cursorX, cursorY] = new CharInfo();
                }
            }
        }

        public void DrawRectangle(
            short x,
            short y,
            short width,
            short height,
            CharAttributes brush) => DrawRectangleCore(x, y, width, height, brush, null);

        public void DrawRectangle(
            short x,
            short y,
            short width,
            short height,
            char asciiChar) => DrawRectangleCore(x, y, width, height, null, asciiChar);

        public void DrawRectangle(
            short x,
            short y,
            short width,
            short height,
            CharAttributes brush,
            char asciiChar) => DrawRectangleCore(x, y, width, height, brush, asciiChar);

        private void DrawRectangleCore(
            short x,
            short y,
            short width,
            short height,
            CharAttributes? brush,
            char? asciiChar)
        {
            if (!IsInitialized)
            {
                throw new InvalidOperationException();
            }

            if (brush != null && asciiChar != null)
            {
                for (var cursorY = 0; cursorY < CanvasWidth; cursorY++)
                {
                    for (var cursorX = 0; cursorX < CanvasHeight; cursorX++)
                    {
                        Canvas[cursorX, cursorY].Char.AsciiChar = (byte)asciiChar;
                        Canvas[cursorX, cursorY].Attributes = (CharAttributes)brush;
                    }
                }
            }
            else if (brush != null)
            {
                for (var cursorY = 0; cursorY < CanvasWidth; cursorY++)
                {
                    for (var cursorX = 0; cursorX < CanvasHeight; cursorX++)
                    {
                        Canvas[cursorX, cursorY].Attributes = (CharAttributes)brush;
                    }
                }
            }
            else if (asciiChar != null)
            {
                for (var cursorY = 0; cursorY < CanvasWidth; cursorY++)
                {
                    for (var cursorX = 0; cursorX < CanvasHeight; cursorX++)
                    {
                        Canvas[cursorX, cursorY].Char.AsciiChar = (byte)asciiChar;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

            _writeRegion = new SmallRect(x, y, (short)(x + width - 1), (short)(y + height - 1));
            _bufferCoords = new Coord(x, y);
        }

        public void Paint(short x, short y, CharAttributes brush) => Canvas[y, x].Attributes = brush;

        public void Write(short x, short y, string text) => WriteCore(x, y, text, null);

        public void Write(short x, short y, string text, CharAttributes brush) => WriteCore(x, y, text, brush);

        private void WriteCore(short x, short y, string text, CharAttributes? brush)
        {
            for (var i = 0; i < text.Length; i++)
            {
                Canvas[y, x + i].Char.AsciiChar = (byte)text[i];

                if (brush != null)
                {
                    Canvas[y, x + i].Attributes = (CharAttributes)brush;
                }
            }
        }

        public void Render()
        {
            if (!Kernel32.WriteConsoleOutput(
                _stdOut,
                Canvas,
                new Coord((short)CanvasWidth, (short)CanvasHeight),
                _bufferCoords,
                ref _writeRegion))
            {
                Win32.ThrowWin32Exception();
            }
        }
    }
}
