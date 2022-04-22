﻿using Components;
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
using Components.Aphid.UI.Colors;
using RgbBrushMemoizer = Components.External.Memoizer<(byte, byte, byte), System.Windows.Media.SolidColorBrush>;
using Components.Aphid.Wpf;
using static Components.Aphid.Wpf.BrushHelper;
using System.Threading;

namespace AphidUI
{

    /// <summary>
    /// Interaction logic for CodeViewer.xaml
    /// </summary>
    public partial class CodeViewer : RichTextBox
    {
        private IAphidTokenColorTheme _theme = new DefaultAphidColorTheme();

        private Task _scrollTask;

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

        public CodeViewer()
        {
            Loaded += (o, e) =>
            {
                Document.Background = FromRgb(_theme.Background);
                Document.Foreground = FromRgb(_theme.Foreground);
            };
            InitializeComponent();
        }

        public void Add(Block item) => Document.Invoke(() => Document.Blocks.Add(item));

        public void Clear() => Document.Invoke(Document.Blocks.Clear);

        public async Task AddAsync(Block item) => await Document.Async(() => Document.Blocks.Add(item));

        public async Task ClearAsync() => await Document.Async(Document.Blocks.Clear);

        public void QueueScrollToEnd()
        {
            if (_scrollTask == null || _scrollTask.IsCompleted)
            {
                _scrollTask = Task.Delay(10).ContinueWith(_ => this.Run(ScrollToEnd));
            }
        }

        private Paragraph AddBlock() => AddBlock(null);

        private Paragraph AddBlock(string text) => Document.Sync(() => AddBlockCore(text));

        private async Task AddBLockAsync() => await AddBlockAsync(null);

        private async Task AddBlockAsync(string text) => await Document.Run(() => AddBlockCore(text));

        private Paragraph AddBlockCore(string text) => NextBlock(text).Do(Add);

        private Paragraph NextBlock() => NextBlock(null);

        private Paragraph NextBlock(string text) =>
            (text != null ? new Paragraph(new Run(text)) : new Paragraph())
            .Do(x => x.Background = FromRgb(_theme.Background));

        public void SetCode(string code) =>
            ThreadPool.QueueUserWorkItem(async x =>
            {
                var colored = Highlight(code);
                Document.Invoke(() =>
                {
                    using (Document.DisableProcessing())
                    {
                        Document.Blocks.Clear();

                        AddParagraphRuns(null, colored, scrollToEnd: false);
                    }
                });
            });

        public static Task<IEnumerable<ColoredText>> HighlightAsync(string code) => Task.Run(() => Highlight(code));

        public void AppendCode(IEnumerable<ColoredText> coloredText) =>
            AppendCode(null, coloredText, scrollToEnd: true);

        public void AppendCode(Paragraph paragraph, IEnumerable<ColoredText> coloredText) =>
            AppendCode(paragraph, coloredText, scrollToEnd: true);

        private void AppendCode(Paragraph paragraph, IEnumerable<ColoredText> coloredText, bool scrollToEnd)
        {
            using (Document.DisableProcessing())
            {
                AddParagraphRuns(paragraph, coloredText, scrollToEnd);                
            }
        }

        private void AddParagraphRuns(Paragraph paragraph, IEnumerable<ColoredText> coloredText, bool scrollToEnd)
        {
            var p = paragraph ?? new Paragraph();
            p.Inlines.AddRange(coloredText.Select(CreateRun));

            if (p.Parent == null)
            {
                Document.Blocks.Add(p);
            }

            if (scrollToEnd)
            {
                QueueScrollToEnd();
            }
        }

        private Run CreateRun(ColoredText t) => new Run(t.Text)
        {
            Foreground = FromRgb(t.ForegroundRgb),
            Background = FromRgb(t.BackgroundRgb ?? _theme.Background)
        };

        public async Task AppendOutputAsync(string output) => await AddBlockAsync(output).ContinueWith(x => QueueScrollToEnd());

        public void AppendColoredOutput(IEnumerable<ColoredText> output) => AppendCode(AddBlock(), output);

        public void AppendColoredOutput(IEnumerable<ColoredText> code, IEnumerable<ColoredText> output)
        {
            var b = AddBlock();
            AppendCode(b, code);
            b.Async(() => b.Inlines.Add(new Run(" => ") { FontWeight = FontWeights.ExtraBlack, Foreground = FromRgb(_theme.GetColor(AphidTokenType.Text)) }));
            AppendCode(b, output);
        }

        public void AppendOutput(string code, string output, bool isError = false) =>
            AppendColoredOutput(
                Highlight(code),
                //!isError ? Highlight(output) : new[] { new ColoredText(SystemColor.Red, "\r\n" + output) });
                (!isError ? Highlight(output) : ErrorHighlightingFormatter.Highlight(output)));

        private static IEnumerable<ColoredText> FormatSuffixedLabel(IEnumerable<ColoredText> x, string tag) => x
            .TakeWhile(y => !y.Text.Contains(tag))
            .Reverse()
            .SkipWhile(y => y.Text.All(char.IsWhiteSpace))
            .Reverse()
            .Concat(x
                .SkipWhile(y => !y.Text.Contains(tag))
                .Skip(1)
                .SkipWhile(y => y.Text.All(char.IsWhiteSpace)));

        public void AppendException(
            string code,
            string label,
            Exception e,
            AphidInterpreter interpreter) =>
            AppendOutput(
                code,
                string.Format("{0}:\r\n\r\n{1}", label, Redirect(() => DumpException(e, interpreter))),
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
