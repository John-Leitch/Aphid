using Components;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using Components.Aphid.UI.Formatters;
using Components.External;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Components.Aphid.UI.Formatters.SyntaxHighlightingFormatter;
using static Components.Aphid.UI.AphidCli;

namespace AphidUI
{

    /// <summary>
    /// Interaction logic for CodeViewer.xaml
    /// </summary>
    public partial class CodeViewer : RichTextBox
    {
        private Task _scrollTask;

        private Memoizer<ColoredText, (SolidColorBrush, SolidColorBrush)> _colorMemoizer = new Memoizer<ColoredText, (SolidColorBrush, SolidColorBrush)>();

        public string Code
        {
            get => (string)GetValue(CodeProperty);
            set => SetValue(CodeProperty, value);
        }

        public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(
            nameof(Code),
            typeof(string),
            typeof(CodeViewer),
            new PropertyMetadata(
                null,
                (sender, args) => ((CodeViewer)sender).SetCode((string)args.NewValue)));

        public CodeViewer() => InitializeComponent();

        public void Add(Block item) => Document.Async(() => Document.Blocks.Add(item));

        public void Clear() => Document.Async(Document.Blocks.Clear);

        private Color GetColor(AphidTokenType tokenType)
        {
            switch (tokenType)
            {
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
                    return Colors.Blue;

                case AphidTokenType.String:
                case AphidTokenType.Number:
                case AphidTokenType.HexNumber:
                    return Colors.DarkRed;

                case AphidTokenType.Identifier:
                    return Colors.DarkOliveGreen;

                case AphidTokenType.Unknown:
                    return Colors.Red;

                default:
                    return Colors.Black;
            }
        }

        public void QueueScrollToEnd()
        {
            if (_scrollTask == null || _scrollTask.IsCompleted)
            {
                _scrollTask = Task.Delay(10).ContinueWith(_ => this.Run(ScrollToEnd));
            }
        }

        

        private SolidColorBrush GetBrush(byte[] rgbBytes) => rgbBytes != null ?
            new SolidColorBrush(Color.FromRgb(rgbBytes[0], rgbBytes[1], rgbBytes[2])) :
            null;

        private Paragraph AddBlock() => AddBlock(null);

        private Paragraph AddBlock(string text) => Document.Sync(() => AddBlockCore(text));

        private Task BeginAddBlock() => BeginAddBlock(null);

        private Task BeginAddBlock(string text) => Document.Run(() => AddBlockCore(text));

        private Paragraph AddBlockCore(string text) => NextBlock(text).Do(Add);

        private Paragraph NextBlock() => NextBlock(null);

        private Paragraph NextBlock(string text) =>
            text != null ? new Paragraph(new Run(text)) : new Paragraph();

        public async void SetCode(string code)
        {
            Clear();
            var colored = await HighlightAsync(code);
            AppendCode(colored);
        }

        public static Task<IEnumerable<ColoredText>> HighlightAsync(string code) => Task.Run(() => Highlight(code));

        public void AppendCode(IEnumerable<ColoredText> coloredText) => AppendCode(null, coloredText);

        public void AppendCode(Paragraph paragraph, IEnumerable<ColoredText> coloredText) =>
            Document
               .Run(() =>
                {
                    var p = paragraph ?? new Paragraph().Do(Document.Blocks.Add);

                    //using (paragraph.Dispatcher.DisableProcessing())
                    //{
                    foreach (var t in coloredText)
                    {
                        var (fg, bg) = _colorMemoizer.Call(x => (GetBrush(x.ForegroundRgb), GetBrush(x.BackgroundRgb)), t);
                        p.Inlines.Add(new Run(t.Text) { Foreground = fg, Background = bg });
                    }
                    //}

                    QueueScrollToEnd();
                });

        public void AppendOutput(string output) => BeginAddBlock(output).ContinueWith(QueueScrollToEnd);

        public void AppendColoredOutput(IEnumerable<ColoredText> output) => AppendCode(AddBlock(), output);

        public void AppendColoredOutput(IEnumerable<ColoredText> code, IEnumerable<ColoredText> output)
        {
            var b = AddBlock();
            AppendCode(b, code);
            b.Async(() => b.Inlines.Add(new Run(" => ") { FontWeight = FontWeights.ExtraBlack }));
            AppendCode(b, output);
        }

        public void AppendOutput(string code, string output, bool isError = false) =>
            AppendColoredOutput(
                Highlight(code),
                !isError ? Highlight(output) : new[] { new ColoredText(SystemColor.Red, output) });

        public void AppendException(
            string code,
            string label,
            Exception e,
            AphidInterpreter interpreter) =>
            AppendOutput(
                code,
                string.Format("{0}: {1}", label, Redirect(() => DumpException(e, interpreter))),
                isError: true);

        public void AppendRuntimeException(
            string code,
            AphidRuntimeException e,
            AphidInterpreter interpreter) =>
            AppendOutput(code, Redirect(() => DumpException(e, interpreter)), isError: true);

        public void AppendParserException(string code, AphidParserException e) =>
            AppendOutput(code, Redirect(() => DumpException(e, code)), isError: true);
    }
}
