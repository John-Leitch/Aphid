using Components.PInvoke;
using System;

namespace Components.External.ConsolePlus
{
    public class ConsoleGraphics
    {
        private IntPtr _stdOut;

        private SmallRect _writeRegion;

        public Coord BufferCoords { get; set; }

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

            //for (var cursorX = 0; cursorX < CanvasWidth; cursorX++)
            //{
            //    for (var cursorY = 0; cursorY < CanvasHeight; cursorY++)
            //    {
            //        Canvas[cursorY, cursorX] = new CharInfo
            //        {
            //            Attributes = CharAttributes.BACKGROUND_BLUE,
            //            Char = new CharUnion { AsciiChar = 0x41 }
            //        };
            //    }
            //}
        }

        public void UpdateCanvas()
        {
            CanvasWidth = Console.WindowWidth;
            CanvasHeight = Console.WindowHeight;
            Canvas = new CharInfo[CanvasHeight, CanvasWidth];
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

            var xEnd = x + width;
            var yEnd = y + height;

            if (brush != null && asciiChar != null)
            {
                for (var cursorX = x; cursorX < xEnd; cursorX++)
                {
                    for (var cursorY = y; cursorY < yEnd; cursorY++)
                    {
                        Canvas[cursorY, cursorX].Char.AsciiChar = (byte)asciiChar;
                        Canvas[cursorY, cursorX].Attributes = (CharAttributes)brush;
                    }
                }
            }
            else if (brush != null)
            {
                for (var cursorX = x; cursorX < xEnd; cursorX++)
                {
                    for (var cursorY = y; cursorY < yEnd; cursorY++)
                    {
                        Canvas[cursorY, cursorX].Attributes = (CharAttributes)brush;
                    }
                }
            }
            else if (asciiChar != null)
            {
                for (var cursorX = x; cursorX < xEnd; cursorX++)
                {
                    for (var cursorY = y; cursorY < yEnd; cursorY++)
                    {
                        Canvas[cursorY, cursorX].Char.AsciiChar = (byte)asciiChar;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

            SetArea(x, y, width, height);
            //_writeRegion = new SmallRect(x, y, (short)(x + width - 1), (short)(y + height - 1));
            //BufferCoords = new Coord(x, y);
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

        public void SetArea(short x, short y, short width, short height)
        {
            SetWriteRegion(x, y, width, height);
            //BufferCoords = new Coord((short)(Console.WindowLeft + x), (short)(Console.WindowTop + y));
            BufferCoords = new Coord(x, y);
        }

        public void SetWriteRegion(short x, short y, short width, short height) =>
            _writeRegion = new SmallRect(x, y, (short)(x + width - 1), (short)(y + height - 1));

        public void Render()
        {
            if (!Kernel32.WriteConsoleOutput(
                _stdOut,
                Canvas,
                new Coord((short)CanvasWidth, (short)CanvasHeight),
                BufferCoords,
                ref _writeRegion))
            {
                Win32.ThrowWin32Exception();
            }
        }
    }
}
