using Components.Aphid.Lexer;
using Components.Aphid.UI;
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

namespace AphidUI
{
    /// <summary>
    /// Interaction logic for CodeViewer.xaml
    /// </summary>
    public partial class CodeViewer : RichTextBox
    {
        public string Code
        {
            get => (string)GetValue(CodeProperty);
            set => SetValue(CodeProperty, value);
        }

        public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(
            "Code",
            typeof(string),
            typeof(CodeViewer),
            new PropertyMetadata(
                null,
                (sender, args) => ((CodeViewer)sender).SetCode((string)args.NewValue)));

        public CodeViewer() => InitializeComponent();

        public void Clear() => Document.Blocks.Clear();

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

        public void AppendCode(Paragraph paragraph, string code)
        {
            code = code.Replace("\r\n", "\n").Replace("\r", "\n") + " ";
            var tokens = new AphidLexer(code).GetAllTokens();

            foreach (var t in tokens)
            {
                var run = new Run(t.Lexeme)
                {
                    Foreground = new SolidColorBrush(GetColor(t.TokenType))
                };

                paragraph.Inlines.Add(run);
            }

            Document.Blocks.Add(paragraph);

            ScrollToEnd();
        }

        private SolidColorBrush GetSyntaxBrush(byte[] rgbBytes) => rgbBytes != null ?
            new SolidColorBrush(Color.FromRgb(rgbBytes[0], rgbBytes[1], rgbBytes[2])) :
            null;

        public void AppendCode(string code) => AppendCode(new Paragraph(), code);

        public void SetCode(string code)
        {
            Clear();
            AppendCode(code);
        }

        public void AppendOutput(string output)
        {
            var paragraph = new Paragraph();

            paragraph.Inlines.Add(new Run(output));

            Document.Blocks.Add(paragraph);
        }

        public void AppendOutput(string code, string output, bool isError = false)
        {
            var paragraph = new Paragraph();
            AppendCode(paragraph, code);
            paragraph.Inlines.Add(new Run("=> ") { FontWeight = FontWeights.ExtraBlack });

            if (isError)
            {
                paragraph.Inlines.Add(new Run(output));
            }
            else
            {
                AppendCode(paragraph, output);
            }

            Document.Blocks.Add(paragraph);
            ScrollToEnd();
        }

        public void AppendException(string code, string label, Exception e) =>
            AppendOutput(code, string.Format("{0}: {1}", label, e.Message), isError: true);

        public void AppendParserException(string code, Exception e) =>
            AppendException(code, "Parser error", e);
    }
}
