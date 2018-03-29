﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class ConsoleAutocomplete
    {
        private int
            _autocompleteLeft,
            _autocompleteTop,
            _autocompleteWidth,
            _autoCompleteHeight,
            _autocompleteIndex,
            _oldLeft,
            _oldTop,
            _cursorIndex = 0;

        private string _consoleBuffer = "";

        private bool _autocompleteActive = false;

        private Autocomplete[] _matches = new Autocomplete[0];

        private string _searchBuffer;

        private string _prompt;

        private bool _forceAutocomplete;

        private int _historyIndex = 0;

        private List<string> _history = new List<string>();

        public IScanner Scanner { get; private set; }

        public ISyntaxHighlighter Highlighter { get; private set; }

        public IAutocompletionSource Source { get; private set; }

        public Func<int> GetMaxResults { get; set; }

        public int MaxHistoryCount { get; set; }

        public ConsoleAutocomplete(
            string prompt,
            IScanner scanner,
            ISyntaxHighlighter highlighter,
            IAutocompletionSource sources)
        {
            GetMaxResults = () => Console.WindowHeight - 6;
            MaxHistoryCount = 100;
            _prompt = prompt;
            Scanner = scanner;
            Highlighter = highlighter;
            Source = sources;
        }

        public string ReadLine()
        {
            DrawText();

            while (true)
            {
                var k = Console.ReadKey(true);

                if (_autocompleteActive)
                {
                    _autocompleteActive = false;

                    Erase(
                        _autocompleteLeft,
                        _autocompleteTop,
                        _autocompleteWidth,
                        _autoCompleteHeight);
                }

                if (k.Modifiers == ConsoleModifiers.Control &&
                    k.Key == ConsoleKey.Spacebar)
                {
                    _forceAutocomplete = true;
                    CheckAutocomplete();
                    continue;
                }
                else if (k.Key != ConsoleKey.UpArrow &&
                    k.Key != ConsoleKey.DownArrow)
                {
                    _historyIndex = -1;
                    _forceAutocomplete = false;
                }

                switch (k.Key)
                {
                    case ConsoleKey.Backspace:
                        InterpretBackspace();
                        break;

                    case ConsoleKey.LeftArrow:
                        if (_cursorIndex > 0)
                        {
                            _cursorIndex--;
                            SetCursor();
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (_cursorIndex < _consoleBuffer.Length)
                        {
                            _cursorIndex++;
                            SetCursor();
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (_matches.Length == 0)
                        {
                            SetHistoryValue(up: true);
                        }
                        else
                        {
                            if (_autocompleteIndex > 0)
                            {
                                _autocompleteIndex--;
                            }

                            CheckAutocomplete();
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (_matches.Length == 0)
                        {
                            SetHistoryValue(up: false);
                        }
                        else
                        {
                            if (_autocompleteIndex < _matches.Length - 1)
                            {
                                _autocompleteIndex++;
                            }
                        }

                        CheckAutocomplete();
                        break;

                    case ConsoleKey.Tab:
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
                            _consoleBuffer += "    ";
                            _cursorIndex += "    ".Length;
                        }

                        if (remaining != null)
                        {
                            if (!string.IsNullOrEmpty(_searchBuffer))
                            {
                                remaining = remaining.Substring(_searchBuffer.Length);
                            }

                            _consoleBuffer += remaining;
                            _cursorIndex += remaining.Length;
                            _searchBuffer = "";
                        }

                        DrawText();
                        break;

                    case ConsoleKey.Home:
                        _cursorIndex = 0;
                        SetCursor();
                        break;

                    case ConsoleKey.End:
                        _cursorIndex = _consoleBuffer.Length;
                        SetCursor();
                        break;

                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        var value = _consoleBuffer;
                        _history.Insert(0, value);

                        if (_history.Count > MaxHistoryCount)
                        {
                            _history.Remove(_history.Last());
                        }

                        _consoleBuffer = "";
                        _cursorIndex = 0;
                        _searchBuffer = "";

                        return value;

                    default:
                        var keyStr = k.KeyChar.ToString();
                        _consoleBuffer = _consoleBuffer.Insert(_cursorIndex, keyStr);
                        _cursorIndex++;
                        DrawText();
                        SetCursor();
                        break;
                }
            }
        }

        private void DrawText(bool skipAutocomplete = false)
        {
            var backup = Console.CursorVisible;
            Console.CursorVisible = false;
            var bg = Console.BackgroundColor;
            var fg = Console.ForegroundColor;

            var sb = new StringBuilder(string.Format("\r{0}", _prompt));

            foreach (var t in Highlighter.Highlight(_consoleBuffer))
            {
                if (t.ForegroundRgb != null)
                {
                    sb.Append(VT100.Foreground(t.ForegroundRgb));
                }

                if (t.BackgroundRgb != null)
                {
                    sb.Append(VT100.Background(t.BackgroundRgb));
                }

                sb.Append(t.Text);
                sb.Append(VT100.Reset);
                //Console.ForegroundColor = t.Color;
                
            }

            Console.Write(sb.ToString());

            //Console.ForegroundColor = fg;
            //Console.BackgroundColor = bg;

            if (!skipAutocomplete)
            {
                CheckAutocomplete();
            }

            Console.CursorVisible = backup;
        }

        private void BackupCursor()
        {
            _oldLeft = Console.CursorLeft;
            _oldTop = Console.CursorTop;
        }

        private void RestoreCursor()
        {
            Console.SetCursorPosition(_oldLeft, _oldTop);
        }

        private void Erase(int left, int top, int width, int height)
        {
            var backup = Console.CursorVisible;
            Console.CursorVisible = false;
            BackupCursor();
            var line = new string(' ', width);

            for (int i = 0; i < height; i++)
            {
                var t = top + i;

                if (t >= Console.BufferHeight)
                {
                    continue;
                }

                Console.SetCursorPosition(left, t);
                Console.Write(line);
            }

            RestoreCursor();
            Console.CursorVisible = backup;
        }

        private void CheckAutocomplete()
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
                return;
            }

            //ScannerToken lastToken;

            //if (tokens.Length != 0 &&
            //    (lastToken = tokens[tokens.Length - 1]).Type == ScannerTokenType.Identifier &&
            //    lastToken.Index + lastToken.Lexeme.Length == _cursorIndex)
            //{
            //    matches = matches.Where(x =>
            //        x != lastToken.Lexeme &&
            //        x.StartsWith(lastToken.Lexeme));

            //    _searchBuffer = lastToken.Lexeme;
            //}
            //else if(!_forceAutocomplete)
            //{
            //    _searchBuffer = "";
            //    return;
            //}

            _matches = matches.ToArray();

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

            var oldTop = Console.CursorTop;
            _autocompleteWidth = _matches.Length != 0 ? _matches.Max(x => Cli.StyleEscape(x.View).Length) : 0;
            _autocompleteActive = true;
            _autocompleteLeft = _cursorIndex + _prompt.Length + 0 - _searchBuffer.Length;

            //if (_searchBuffer != "" ||
            //    (_consoleBuffer.Length > 0 &&
            //    char.IsWhiteSpace(_consoleBuffer[_consoleBuffer.Length - 1])))
            //{
            //    _autocompleteLeft--;
            //}

            _autocompleteTop = Console.CursorTop + 1;
            //_autocompleteWidth = 0;
            _autoCompleteHeight = _matches.Length < GetMaxResults() ?
                _matches.Length :
                GetMaxResults() + 1;

            int tmpLeft = Console.CursorLeft, tmpRight = Console.CursorTop;

            var linesNeeded = _autoCompleteHeight + Console.CursorTop + 1 - Console.BufferHeight;
            var t = Console.CursorTop;

            if (linesNeeded > 0)
            {
                oldTop -= linesNeeded;
                t -= linesNeeded;
            }

            for (int i = 0; i < linesNeeded; i++)
            {
                Console.WriteLine();
            }

            Console.SetCursorPosition(tmpLeft, t);

            var entryNum = -1;
            var linesDrawn = 0;

            foreach (var n in _matches)
            {
                entryNum++;

                if (Cli.StyleEscape(n.View).Length > _autocompleteWidth)
                {
                    _autocompleteWidth = Cli.StyleEscape(n.View).Length;
                }

                if (_autocompleteIndex - entryNum > GetMaxResults() ||
                    linesDrawn > GetMaxResults())
                {
                    continue;
                }

                var top = Console.CursorTop + 1;
                Console.SetCursorPosition(_autocompleteLeft, top);
                var format = _autocompleteIndex == entryNum ?
                        "~White~~|Blue~{0}~R~" :
                        "~Black~~|White~{0}~R~";

                Cli.Write(format, n.View + new string(' ', _autocompleteWidth - Cli.StyleEscape(n.View).Length));
                linesDrawn++;
            }

            Console.SetCursorPosition(_prompt.Length + _cursorIndex, oldTop);
        }

        private void SetCursor()
        {
            Console.SetCursorPosition(_prompt.Length + _cursorIndex, Console.CursorTop);
        }

        private void InterpretBackspace()
        {
            if (_consoleBuffer.Length == 0)
            {
                return;
            }

            _consoleBuffer = _consoleBuffer.Remove(--_cursorIndex, 1);
            Console.CursorVisible = false;

            Console.SetCursorPosition(
                _prompt.Length + _consoleBuffer.Length,
                Console.CursorTop);

            Console.Write(" ");
            DrawText();

            Console.SetCursorPosition(
                _prompt.Length + _cursorIndex,
                Console.CursorTop);

            Console.CursorVisible = true;
        }

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
                Erase(
                    _prompt.Length,
                    Console.CursorTop,
                    _consoleBuffer.Length,
                    1);
            }

            _consoleBuffer = historyVal;
            _cursorIndex = _consoleBuffer.Length;
            DrawText(skipAutocomplete: true);
            SetCursor();
        }
    }
}
