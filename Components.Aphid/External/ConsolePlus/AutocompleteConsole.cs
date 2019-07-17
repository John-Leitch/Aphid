using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.ConsoleKey;
using static System.Diagnostics.Process;

namespace Components.External.ConsolePlus
{
    public class AutocompleteConsole
    {
        private ConsoleGraphics _gfx;

        private readonly string _prompt;

        private readonly List<string> _history = new List<string>();

        private bool _autocompleteActive, _forceAutocomplete;

        private int
            _autocompleteLeft,
            _autocompleteTop,
            _autocompleteWidth,
            _autoCompleteHeight,
            _autocompleteIndex,
            _oldLeft,
            _oldTop,
            _cursorIndex,
            _historyIndex;

        private string _consoleBuffer = "", _searchBuffer;        

        private Autocomplete[] _matches = Array.Empty<Autocomplete>();

        public int MaxHistoryCount { get; set; } = 100;

        public int MaxListSize { get; set; } = 10;

        public string TabValue { get; set; } = "    ";

        public IScanner Scanner { get; }

        public ISyntaxHighlighter Highlighter { get; }

        public IAutocompletionSource Source { get; }

        public bool UseNativeApi { get; }

        public AutocompleteConsole(
            string prompt,
            IScanner scanner,
            ISyntaxHighlighter highlighter,
            IAutocompletionSource sources,
            bool useNativeApi)
        {
            _prompt = prompt;
            Scanner = scanner;
            Highlighter = highlighter;
            Source = sources;
            
            if (UseNativeApi = (useNativeApi &&
                GetCurrentProcess().MainWindowHandle != IntPtr.Zero))
            {
                _gfx = new ConsoleGraphics();
                _gfx.Init();
            }
        }

        public string ReadLine()
        {
            DrawText(skipAutocomplete: true);

            while (true)
            {
                var k = ReadKey(true);

                if (_autocompleteActive)
                {
                    _autocompleteActive = false;

                    if (!UseNativeApi)
                    {
                        Erase(
                            _autocompleteLeft,
                            _autocompleteTop,
                            _autocompleteWidth,
                            _autoCompleteHeight);
                    }
                    else
                    {
                        NativeErase(
                            _autocompleteLeft,
                            _autocompleteTop,
                            _autocompleteWidth,
                            _autoCompleteHeight);
                    }
                }

                if (k.Modifiers == ConsoleModifiers.Control &&
                    k.Key == Spacebar)
                {
                    _forceAutocomplete = true;
                    UpdateAutocomplete();
                    continue;
                }
                else if (k.Key != UpArrow && k.Key != DownArrow)
                {
                    _historyIndex = -1;
                    _forceAutocomplete = false;
                }

                switch (k.Key)
                {
                    case LeftArrow:
                        InterpretHorizontalArrow(left: true);
                        break;

                    case RightArrow:
                        InterpretHorizontalArrow(left: false);
                        break;

                    case UpArrow:
                        InterpretVerticalArrow(up: true);
                        break;

                    case DownArrow:
                        InterpretVerticalArrow(up: false);
                        break;

                    case Tab:
                        InterpretTab();
                        break;

                    case Home:
                        InterpretHome();
                        break;

                    case End:
                        InterpretEnd();
                        break;

                    case Enter:
                        return InterpretEnter();

                    case Backspace:
                        InterpretBackspace();
                        break;

                    case Delete:
                        InterpretDelete();
                        break;

                    default:
                        InterpretOther(k);
                        break;
                }
            }
        }

        private void InterpretHorizontalArrow(bool left)
        {
            if ((left && _cursorIndex > 0) ||
                (!left && _cursorIndex < _consoleBuffer.Length))
            {
                _cursorIndex += left ? -1 : 1;
                SetCursor();
            }
        }

        private void InterpretVerticalArrow(bool up)
        {
            if (_matches.Length == 0)
            {
                SetHistoryValue(up);
            }
            else
            {
                if (up && _autocompleteIndex > 0)
                {
                    _autocompleteIndex--;
                }
                else if (!up && _autocompleteIndex < _matches.Length - 1)
                {
                    _autocompleteIndex++;
                }

                UpdateAutocomplete(clearMatches: false);
            }
        }

        private void InterpretTab()
        {
            string remaining = null;

            if (_matches.Length == 1)
            {
                remaining = _matches[0].Text;
            }
            else if (_matches.Length > 1)
            {
                remaining = _matches[_autocompleteIndex].Text;
            }
            else
            {
                _consoleBuffer = _consoleBuffer.Insert(_cursorIndex, TabValue);
                _cursorIndex += TabValue.Length;
            }

            if (remaining != null)
            {
                if (!string.IsNullOrEmpty(_searchBuffer))
                {
                    remaining = remaining.Substring(_searchBuffer.Length);
                }

                _consoleBuffer = _consoleBuffer.Insert(_cursorIndex, remaining);
                _cursorIndex += remaining.Length;
                _searchBuffer = "";
            }

            DrawText();
        }

        private void InterpretHome()
        {
            _cursorIndex = 0;
            SetCursor();
        }

        private void InterpretEnd()
        {
            _cursorIndex = _consoleBuffer.Length;
            SetCursor();
        }

        private string InterpretEnter()
        {
            WriteLine();

            var value = _consoleBuffer;

            if (value.Trim() != "" &&
                (_history.Count == 0 || _history[0] != value))
            {
                _history.Insert(0, value);

                if (_history.Count > MaxHistoryCount)
                {
                    _history.Remove(_history.Last());
                }
            }

            _consoleBuffer = "";
            _cursorIndex = 0;
            _searchBuffer = "";

            return value;
        }

        private void InterpretBackspace()
        {
            if (_consoleBuffer.Length == 0 || _cursorIndex == 0)
            {
                return;
            }

            EraseChar(--_cursorIndex);
        }

        private void InterpretDelete()
        {
            if (_consoleBuffer.Length == 0 || _cursorIndex == _consoleBuffer.Length)
            {
                return;
            }

            EraseChar(_cursorIndex);
        }

        private void InterpretOther(ConsoleKeyInfo k)
        {
            if (k.KeyChar < 0x20 || k.KeyChar > 0x7f)
            {
                return;
            }

            var keyStr = k.KeyChar.ToString();
            _consoleBuffer = _consoleBuffer.Insert(_cursorIndex, keyStr);
            _cursorIndex++;
            DrawText();
            SetCursor();
        }

        private void DrawText(bool skipAutocomplete = false)
        {
            var backup = CursorVisible;
            CursorVisible = false;
            var sb = new StringBuilder(string.Format("\r{0}", _prompt));

            foreach (var t in Highlighter.Highlight(_consoleBuffer))
            {
                VT100.Append(sb, t);
            }

            Write(sb.ToString());

            if (!skipAutocomplete)
            {
                UpdateAutocomplete();
            }

            CursorVisible = backup;
        }

        private void BackupCursor()
        {
            _oldLeft = CursorLeft;
            _oldTop = CursorTop;
        }

        private void RestoreCursor() => SetCursorPosition(_oldLeft, _oldTop);

        private void Erase(int left, int top, int width, int height)
        {
            var backup = CursorVisible;
            CursorVisible = false;
            BackupCursor();
            var line = new string(' ', width);

            for (var i = 0; i < height; i++)
            {
                var t = top + i;

                if (t >= BufferHeight)
                {
                    continue;
                }
                
                SetCursorPosition(left, t);
                Write(line);
            }

            RestoreCursor();
            CursorVisible = backup;
        }

        private void NativeErase(int left, int top, int width, int height)
        {
            if (_gfx.CanvasWidth != WindowWidth || _gfx.CanvasHeight != WindowHeight)
            {
                _gfx.UpdateCanvas();
            }

            _gfx.SetWriteRegion((short)left, (short)top, (short)width, (short)height);
            _gfx.Render();
        }

        private void UpdateAutocomplete() => UpdateAutocomplete(clearMatches: true);

        private void UpdateAutocomplete(bool clearMatches)
        {
            if (clearMatches)
            {
                var curText = _cursorIndex == _consoleBuffer.Length ?
                    _consoleBuffer :
                    _consoleBuffer.Remove(_cursorIndex);

                var tokens = Scanner.Tokenize(curText).ToArray();

                var matches = Source.GetWords(
                    _consoleBuffer,
                    _cursorIndex,
                    _forceAutocomplete,
                    out _searchBuffer);

                if ((!_forceAutocomplete && tokens.Length == 0) || matches == null)
                {
                    _matches = Array.Empty<Autocomplete>();

                    return;
                }

                _matches = matches.ToArray();
            }

            if (_matches.Length != 0)
            {
                DrawAutocomplete();
            }
            else
            {
                _searchBuffer = "";
            }
        }

        private void DrawAutocomplete()
        {
            if (_autocompleteIndex >= _matches.Length)
            {
                _autocompleteIndex = 0;
            }

            var oldTop = CursorTop;

            _autocompleteWidth = _matches.Length != 0 ?
                _matches.Max(x => Cli.EraseStyles(x.View).Length) : 0;

            var maxWidth =
                WindowWidth -
                _prompt.Length -
                _cursorIndex +
                _searchBuffer.Length -
                1;

            if (maxWidth < 0)
            {
                maxWidth = 0;
            }

            if (_autocompleteWidth > maxWidth)
            {
                _autocompleteWidth = maxWidth;
            }

            _autocompleteActive = true;
            _autocompleteLeft = _cursorIndex + _prompt.Length + 0 - _searchBuffer.Length;
            _autocompleteTop = CursorTop + 1;

            _autoCompleteHeight = _matches.Length < GetMaxResults() ?
                _matches.Length :
                GetMaxResults() + 1;

            if (maxWidth < _autocompleteWidth)
            {
                _autocompleteWidth = maxWidth;
            }

            var tmpLeft = CursorLeft;

            var linesNeeded = _autoCompleteHeight + CursorTop + 1 - BufferHeight;
            var t = CursorTop;

            if (linesNeeded > 0)
            {
                oldTop -= linesNeeded;
                t -= linesNeeded;
                Write(new string('\n', linesNeeded));
            }

            
            //for (var i = 0; i < linesNeeded; i++)
            //{
            //    WriteLine();
            //}

            SetCursorPosition(tmpLeft, t);

            var entryNum = -1;
            var linesDrawn = 0;

            foreach (var n in _matches)
            {
                entryNum++;

                if (_autocompleteIndex - entryNum > GetMaxResults() ||
                    linesDrawn > GetMaxResults())
                {
                    continue;
                }

                var top = CursorTop + 1;
                SetCursorPosition(_autocompleteLeft, top);

                if (_autocompleteIndex != entryNum)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Blue;
                }

                // Hack, until Cli tokenizer is rewritten and exposed
                // so string can be scanned and truncated precisely.
                var viewLen = Cli.EraseStyles(n.View).Length;
                var viewStr = viewLen <= maxWidth ? n.View : n.View.Remove(maxWidth);
                var space = _autocompleteWidth - (viewLen <= maxWidth ? viewLen : maxWidth);
                Write(viewStr + (space > 0 ? new string(' ', space) : ""));
                linesDrawn++;
            }

            ResetColor();
            SetCursorPosition(_prompt.Length + _cursorIndex, oldTop);
        }

        private void SetCursor() =>
            SetCursorPosition(_prompt.Length + _cursorIndex, CursorTop);

        private void SetHistoryValue(bool up)
        {
            int index;

            if (up && _history.Count - 1 > _historyIndex)
            {
                index = ++_historyIndex;
            }
            else if (!up && _historyIndex > 0)
            {
                index = --_historyIndex;
            }
            else
            {
                return;
            }

            var historyVal = _history[index];

            if (_consoleBuffer.Length > historyVal.Length)
            {
                Erase(_prompt.Length, CursorTop, _consoleBuffer.Length, 1);
            }

            _consoleBuffer = historyVal;
            _cursorIndex = _consoleBuffer.Length;
            DrawText(skipAutocomplete: true);
            SetCursor();
        }

        private void EraseChar(int index)
        {
            _consoleBuffer = _consoleBuffer.Remove(index, 1);
            CursorVisible = false;

            SetCursorPosition(
                _prompt.Length + _consoleBuffer.Length,
                CursorTop);

            Write(" ");
            DrawText();

            SetCursorPosition(
                _prompt.Length + _cursorIndex,
                CursorTop);

            CursorVisible = true;
        }

        private int GetMaxResults() => Math.Min(WindowHeight - 6, MaxListSize);

        private int GetMaxWidth() => WindowWidth - _autocompleteLeft - 1;
    }
}
