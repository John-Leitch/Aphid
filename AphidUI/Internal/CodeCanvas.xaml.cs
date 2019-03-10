using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AphidUI.Internal
{
    /// <summary>
    /// Interaction logic for CodeTextBox.xaml
    /// </summary>
    public partial class CodeCanvas : UserControl
    {
        public event RoutedEventHandler TextChanged;

        private GlyphTypeface glyphFace;

        private List<List<TextCell>> _document = new List<List<TextCell>> { new List<TextCell>() };

        private int _currentRow = 0, _currentColumn = 0;

        private double _cellWidth = 8, _cellHeight = 12;

        private bool _acceptsReturn;

        public bool AcceptsReturn
        {
            get => _acceptsReturn;
            set => LineBorder.Visibility = (_acceptsReturn = value) ?
                Visibility.Visible : Visibility.Collapsed;
        }

        public string Text { get; private set; }

        public CodeCanvas()
        {
            InitializeComponent();

            AcceptsReturn = false;
            FontFamily = new FontFamily("Lucida console");
            FontSize = 12;

            DependencyPropertyDescriptor
                .FromProperty(FontSizeProperty, typeof(CodeCanvas))
                .AddValueChanged(this, FontSizeChanged);

            DependencyPropertyDescriptor
                .FromProperty(FontFamilyProperty, typeof(CodeCanvas))
                .AddValueChanged(this, FontFamilyChanged);

            FontSizeChanged(this, EventArgs.Empty);
            FontFamilyChanged(this, EventArgs.Empty);
        }

        private void SetGlyphFace()
        {
            if (!FontFamily
                .GetTypefaces()
                .FirstOrDefault()
                .TryGetGlyphTypeface(out glyphFace))
            {
                throw new InvalidOperationException();
            }
        }

        #region Caret Methods

        private void MoveCaretUp()
        {
            if (_currentRow == 0)
            {
                return;
            }
            else if (_currentColumn >= _document[--_currentRow].Count)
            {
                MoveCaretEnd();
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretDown()
        {
            if (_currentRow == _document.Count - 1)
            {
                return;
            }
            else if (_currentColumn >= _document[++_currentRow].Count)
            {
                MoveCaretEnd();
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretLeft()
        {
            if (_currentColumn > 0)
            {
                _currentColumn--;
            }
            else if (_currentRow != 0)
            {
                _currentRow--;
                MoveCaretEnd();
            }
            else
            {
                return;
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretRight()
        {
            var row = _document[_currentRow];

            if (_currentColumn < row.Count - 1)
            {
                _currentColumn++;
            }
            else if (_currentRow < _document.Count - 1)
            {
                _currentRow++;
                _currentColumn = 0;
                MoveCaretHome();
            }
            else if (_currentColumn != row.Count)
            {
                _currentColumn++;
            }
            else
            {
                return;
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretPage(bool up)
        {
            var viewer = (ScrollViewer)Parent;
            var rows = (int)Math.Ceiling(viewer.ActualHeight / _cellHeight);
            var nextRow = up ? _currentRow - rows : _currentRow + rows;

            _currentRow = up ?
                (nextRow >= 0 ? nextRow : 0) :
                (nextRow < _document.Count ? nextRow : _document.Count - 1);

            viewer.ScrollToVerticalOffset(Canvas.GetTop(_caret) + (viewer.ActualHeight / 2));
            var row = _document[_currentRow];

            if (_currentColumn >= row.Count)
            {
                _currentColumn = row.Count - 1;
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretHome()
        {
            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                _currentRow = 0;
            }

            var row = _document[_currentRow];

            if (row.Count == 0)
            {
                _currentColumn = 0;
            }
            else if (_currentColumn != 0)
            {
                var cells = row.Take(_currentColumn).ToArray();
                var homeIndex = 0;

                for (int i = 0; i < cells.Length; i++)
                {
                    if (!char.IsWhiteSpace(cells[i].Char))
                    {
                        homeIndex = i;
                        break;
                    }
                }

                _currentColumn = homeIndex;
            }
            else
            {
                var homeIndex = 0;

                for (int i = 0; i < row.Count; i++)
                {
                    if (!char.IsWhiteSpace(row[i].Char))
                    {
                        homeIndex = i;
                        break;
                    }
                }

                _currentColumn = homeIndex;
            }

            if (_currentColumn == 0)
            {
                ((ScrollViewer)Parent).ScrollToHorizontalOffset(0);
            }

            MoveCaretToCurrentCell();
        }

        private void MoveCaretEnd()
        {
            var row = _document[_currentRow];

            if (row.Count == 0)
            {
                _currentColumn = 0;
            }
            else
            {
                _currentColumn = _currentRow == _document.Count - 1 ?
                    row.Count :
                    row.Count - 1;
            }

            MoveCaretToCurrentCell();
        }

        private void SetCaretPosition(double x, double y)
        {
            Canvas.SetLeft(_caret, x * _cellWidth);
            var top = y * _cellHeight;
            Canvas.SetTop(_caret, top);
            Canvas.SetTop(LineBorder, top);
            _caret.BringIntoView();
        }

        private void MoveCaretToCurrentCell()
        {
            DebugHelper.Trace();
            SetCaretPosition(_currentColumn, _currentRow);
        }

        #endregion

        private TextCellType GetTokenColor(in AphidToken t)
        {
            switch (t.TokenType)
            {
                case AphidTokenType.String:
                case AphidTokenType.Number:
                case AphidTokenType.HexNumber:
                    return TextCellType.Literal;

                case AphidTokenType.Identifier:
                    return TextCellType.Identifier;

                case AphidTokenType.breakKeyword:
                case AphidTokenType.catchKeyword:
                case AphidTokenType.defaultKeyword:
                case AphidTokenType.definedKeyword:
                case AphidTokenType.deleteKeyword:
                case AphidTokenType.elseKeyword:
                case AphidTokenType.extendKeyword:
                case AphidTokenType.falseKeyword:
                case AphidTokenType.finallyKeyword:
                case AphidTokenType.forKeyword:
                case AphidTokenType.ifKeyword:
                case AphidTokenType.inKeyword:
                case AphidTokenType.nullKeyword:
                case AphidTokenType.retKeyword:
                case AphidTokenType.switchKeyword:
                case AphidTokenType.thisKeyword:
                case AphidTokenType.trueKeyword:
                case AphidTokenType.tryKeyword:
                case AphidTokenType.whileKeyword:

                case AphidTokenType.FunctionOperator:
                case AphidTokenType.LoadLibraryOperator:
                case AphidTokenType.LoadScriptOperator:
                case AphidTokenType.PatternMatchingOperator:
                    return TextCellType.Keyword;

                case AphidTokenType.AdditionOperator:
                case AphidTokenType.AndOperator:
                case AphidTokenType.AssignmentOperator:
                case AphidTokenType.BinaryAndOperator:
                case AphidTokenType.BinaryOrOperator:
                case AphidTokenType.ColonOperator:
                case AphidTokenType.ComplementOperator:
                case AphidTokenType.DecrementOperator:
                case AphidTokenType.DivisionEqualOperator:
                case AphidTokenType.DivisionOperator:
                case AphidTokenType.EqualityOperator:
                case AphidTokenType.GreaterThanOperator:
                case AphidTokenType.GreaterThanOrEqualOperator:
                case AphidTokenType.IncrementOperator:
                case AphidTokenType.LessThanOperator:
                case AphidTokenType.LessThanOrEqualOperator:
                case AphidTokenType.MinusEqualOperator:
                case AphidTokenType.MinusOperator:
                case AphidTokenType.ModulusEqualOperator:
                case AphidTokenType.ModulusOperator:
                case AphidTokenType.MultiplicationEqualOperator:
                case AphidTokenType.MultiplicationOperator:
                case AphidTokenType.NotEqualOperator:
                case AphidTokenType.NotOperator:
                case AphidTokenType.OrEqualOperator:
                case AphidTokenType.OrOperator:
                case AphidTokenType.PipelineOperator:
                case AphidTokenType.PlusEqualOperator:
                case AphidTokenType.XorEqualOperator:
                case AphidTokenType.XorOperator:
                case AphidTokenType.MemberOperator:
                    return TextCellType.Operator;

                case AphidTokenType.LeftBrace:
                case AphidTokenType.RightBrace:
                case AphidTokenType.LeftBracket:
                case AphidTokenType.RightBracket:
                case AphidTokenType.LeftParenthesis:
                case AphidTokenType.RightParenthesis:
                    return TextCellType.Delimiter;

                case AphidTokenType.Comment:
                    return TextCellType.Comment;

                default:
                    return TextCellType.Text;
            }
        }

        private Color GetColor(TextCellType b)
        {
            switch (b)
            {
                case TextCellType.Keyword:
                    //return Colors.Blue;
                    return Color.FromRgb(0, 0, 255);

                case TextCellType.Literal:
                    return Colors.DarkRed;

                case TextCellType.Identifier:
                    //return Colors.DarkOliveGreen;
                    return Color.FromRgb(85, 85, 0);

                case TextCellType.Unknown:
                    return Colors.Red;

                case TextCellType.Comment:
                    return Colors.DarkGreen;

                default:
                    return Colors.Black;
            }
        }

        private GlyphRun BuildGlyphRun(int column, int line, char c)
        {
            var paddingTop = FontSize / 3;
            var glyphs = new GlyphRun();
            ISupportInitialize isi = glyphs;
            isi.BeginInit();
            glyphs.GlyphTypeface = glyphFace;
            glyphs.FontRenderingEmSize = FontSize;
            glyphs.Characters = new[] { c };
            var codePoint = (int)c;
            var glyphIndex = glyphFace.CharacterToGlyphMap[codePoint];
            var glyphWidth = glyphFace.AdvanceWidths[glyphIndex];
            glyphs.GlyphIndices = new ushort[] { glyphIndex };
            glyphs.AdvanceWidths = new double[] { glyphWidth * FontSize };
            _cellWidth = glyphWidth * FontSize;
            _cellHeight = (glyphFace.Baseline * FontSize) + paddingTop;

            glyphs.BaselineOrigin = new Point(
                glyphWidth * FontSize * column,
                (glyphFace.Baseline * FontSize * (line + 1)) + (paddingTop * line));

            isi.EndInit();

            return glyphs;
        }

        private void MoveCaretIntoDocument()
        {
            DebugHelper.Trace();

            if (_currentRow > _document.Count - 1)
            {
                _currentRow = _document.Count - 1;
            }

            if (_currentColumn > _document[_currentRow].Count - 1)
            {
                MoveCaretEnd();
            }
        }

        private void CreateDocument(List<AphidToken> tokens)
        {
            DebugHelper.Trace();

            _document = new List<List<TextCell>>();
            var currentLine = new List<TextCell>();
            _document.Add(currentLine);

            foreach (var token in tokens)
            {
                for (int x = 0; x < token.Lexeme.Length; x++)
                {
                    switch (token.Lexeme[x])
                    {
                        case '\r':
                            throw new InvalidOperationException();

                        //case '\n':
                        //    currentLine = new List<TextCell>();
                        //    _document.Add(currentLine);    
                        //    break;

                        default:
                            currentLine.Add(
                                new TextCell(
                                    token.Index + x,
                                    GetTokenColor(token),
                                    token.Lexeme[x]));

                            if (token.Lexeme[x] == '\n')
                            {
                                currentLine = new List<TextCell>();
                                _document.Add(currentLine);
                            }

                            break;
                    }
                }
            }

            MoveCaretIntoDocument();
        }

        private void UpdateDocument()
        {
            DebugHelper.Trace();

            if (double.IsNaN(ActualWidth) || double.IsNaN(ActualHeight))
            {
                return;
            }

            TextChanged?.Invoke(this, new RoutedEventArgs());
            InvalidateVisual();
        }

        private void HandlePrintableKey(KeyEventArgs e)
        {
            DebugHelper.Trace();
            var key = KeyHelper.GetCharFromKey(e.Key, out var isControlKey).ToString();

            if (isControlKey)
            {
                return;
            }

            var isNewLine = false;
            var row = _document[_currentRow];

            var cell = _currentColumn != row.Count ? row[_currentColumn] :
                _currentColumn != 0 ? new TextCell(row[_currentColumn - 1].Index + 1) :
                _document.Count == 1 ? new TextCell() :
                new TextCell(_document[_currentRow - 1].Last().Index + 1);

            switch (key)
            {
                case "\r":
                case "\n":
                case "\r\n":
                    if (!AcceptsReturn)
                    {
                        return;
                    }

                    key = "\n";
                    isNewLine = true;
                    break;

                case "\t":
                    key = "    ";
                    _currentColumn += 3;
                    break;
            }

            Text = Text != null ? Text.Insert(cell.Index, key) : key;

            if (!isNewLine)
            {
                _currentColumn++;
            }
            else
            {
                _currentColumn = 0;
                _currentRow++;
            }

            MoveCaretToCurrentCell();
            UpdateDocument();
            e.Handled = true;
        }

        private void SetDefaultSize()
        {
            DebugHelper.Trace();
            Width = 0;
            Height = BuildGlyphRun(0, 0, 'A').BaselineOrigin.Y;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            DebugHelper.Trace();

            if (glyphFace == null)
            {
                return;
            }
            else if (string.IsNullOrEmpty(Text))
            {
                _currentColumn = 0;
                _currentRow = 0;
                MoveCaretToCurrentCell();
                SetDefaultSize();
                CreateDocument(new List<AphidToken>());

                return;
            }

            CreateDocument(AphidLexer.GetAllTokens(Text));
            double greatestX = 0, greatestY = 0;

            for (int y = 0; y < _document.Count; y++)
            {
                for (int x = 0; x < _document[y].Count; x++)
                {
                    var cell = _document[y][x];

                    if (cell.Char == '\n')
                    {
                        continue;
                    }

                    var glyph = BuildGlyphRun(x, y, cell.Char);
                    drawingContext.DrawGlyphRun(new SolidColorBrush(GetColor(cell.Type)), glyph);
                    var x2 = glyph.BaselineOrigin.X + _cellWidth;

                    if (x2 > greatestX)
                    {
                        greatestX = x2;
                    }

                    if (glyph.BaselineOrigin.Y > greatestY)
                    {
                        //greatestY = glyph.BaselineOrigin.Y + 20;
                        greatestY = glyph.BaselineOrigin.Y;
                    }
                }
            }

            var caretY = Canvas.GetTop(_caret) + _caret.Height;

            if (caretY > greatestY)
            {
                greatestY = caretY;
            }

            Width = greatestX;
            Height = greatestY;
        }

        public void SetText(string text)
        {
            DebugHelper.Trace();

            if (text == null)
            {
                text = "";
            }

            var t = text
                .Replace("\r\n", "\n")
                .Replace('\r', '\n')
                .Replace("\t", "    ");

            if (t != Text)
            {
                Text = t;
                UpdateDocument();
            }
        }

        private void FontFamilyChanged(object o, EventArgs e)
        {
            DebugHelper.Trace();
            SetGlyphFace();
        }

        private void FontSizeChanged(object o, EventArgs e)
        {
            DebugHelper.Trace();
            var fontSize = ((Control)o).FontSize;
            LineBorder.Height = (_caret.Height = fontSize) + 4;
            LineBorder.Margin = new Thickness(-2, -2, 0, 0);
            _caret.Width = fontSize / 10;
        }

        public void UpdateSize()
        {
            DebugHelper.Trace();
            Canvas.Width = ActualWidth;
            Canvas.Height = ActualHeight;

            ScrollViewer viewer;

            if ((viewer = Parent as ScrollViewer) == null &&
                (viewer = (Parent as FrameworkElement).Parent as ScrollViewer) == null)
            {
                throw new InvalidOperationException();
            }

            var viewerWidth = viewer.ActualWidth - SystemParameters.VerticalScrollBarWidth - 2;

            if (viewerWidth > Canvas.Width)
            {
                LineBorder.Width = viewerWidth;
                Canvas.Width = viewerWidth;
            }
            else
            {
                LineBorder.Width = Canvas.Width + 4;
            }

            if (viewer.ActualHeight > Canvas.Height)
            {
                Canvas.Height = viewer.ActualHeight;
            }

            MoveCaretToCurrentCell();
        }

        public void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            DebugHelper.Trace();

            switch (e.Key)
            {
                case Key.LeftShift:
                case Key.RightShift:
                case Key.LeftAlt:
                case Key.RightAlt:
                case Key.LeftCtrl:
                case Key.RightCtrl:
                case Key.CapsLock:
                case Key.LWin:
                case Key.RWin:
                    return;

                case Key.Up:
                    MoveCaretUp();
                    e.Handled = true;
                    break;

                case Key.Down:
                    MoveCaretDown();
                    e.Handled = true;
                    break;

                case Key.Left:
                    MoveCaretLeft();
                    e.Handled = true;
                    break;

                case Key.Right:
                    MoveCaretRight();
                    e.Handled = true;
                    break;

                case Key.PageUp:
                    MoveCaretPage(true);
                    e.Handled = true;
                    break;

                case Key.PageDown:
                    MoveCaretPage(false);
                    e.Handled = true;
                    break;

                case Key.Home:
                    MoveCaretHome();
                    e.Handled = true;
                    break;

                case Key.End:
                    if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                    {
                        _currentRow = _document.Count - 1;
                    }

                    MoveCaretEnd();
                    e.Handled = true;
                    break;

                case Key.Back:
                    if (_currentColumn == 0)
                    {
                        if (_currentRow == 0)
                        {
                            return;
                        }

                        _currentRow--;
                        _currentColumn = _document[_currentRow].Count;
                    }

                    var cell = _document[_currentRow][_currentColumn - 1];
                    Text = Text.Remove(cell.Index, 1);
                    _currentColumn--;
                    MoveCaretToCurrentCell();
                    UpdateDocument();
                    e.Handled = true;
                    break;

                case Key.Delete:
                    var row = _document[_currentRow];

                    if (_currentColumn < row.Count)
                    {
                        cell = row[_currentColumn];
                        Text = Text.Remove(cell.Index, 1);
                        UpdateDocument();
                    }

                    break;

                default:
                    if (((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control) ||
                        ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt))
                    {
                        return;
                    }

                    HandlePrintableKey(e);
                    break;
            }
        }

        public void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DebugHelper.Trace();
            var point = e.GetPosition((IInputElement)sender);
            _currentColumn = (int)Math.Floor(Math.Max(point.X + 4, 0f) / _cellWidth);
            _currentRow = (int)Math.Floor(Math.Max(point.Y, 0f) / _cellHeight);

            if (_currentRow >= _document.Count)
            {
                _currentRow = _document.Count - 1;
            }

            if (_currentColumn >= _document[_currentRow].Count)
            {
                MoveCaretEnd();
            }

            MoveCaretToCurrentCell();
            Keyboard.Focus(Canvas);
            e.Handled = true;
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DebugHelper.Trace();
            UpdateSize();
        }
    }
}