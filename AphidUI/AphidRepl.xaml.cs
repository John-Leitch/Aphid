using AphidUI.ViewModels;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AphidUI
{
    /// <summary>
    /// Interaction logic for AphidReply.xaml
    /// </summary>
    public partial class AphidRepl : UserControl
    {
        public event EventHandler ExecutionCompleted;

        public AphidReplViewModel ViewModel { get; }

        public static readonly DependencyProperty IsMultiLineProperty = DependencyProperty.Register(
            nameof(IsMultiLine),
            typeof(bool),
            typeof(AphidRepl),
            new PropertyMetadata(
                false,
                (o, e) => ((AphidRepl)o).ViewModel.IsMultiLine = (bool)e.NewValue));

        public bool IsMultiLine
        {
            get => (bool)GetValue(IsMultiLineProperty);
            set => SetValue(IsMultiLineProperty, value);
        }

        public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(
            nameof(Code),
            typeof(string),
            typeof(AphidRepl),
            new PropertyMetadata((o, e) =>
            {
                if ((string)e.OldValue != (string)e.NewValue)
                {
                    ((AphidRepl)o).ViewModel.Code = (string)e.NewValue;
                }
            }));

        public string Code
        {
            get => (string)GetValue(CodeProperty);
            set => SetValue(CodeProperty, value);
        }

        private bool _lineOptionsVisible;

        public bool LineOptionsVisible
        {
            get => _lineOptionsVisible;
            set => ViewModel.LineOptionVisibility = (_lineOptionsVisible = value) ?
                Visibility.Visible :
                Visibility.Collapsed;
        }

        public AphidRepl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = ViewModel = new AphidReplViewModel(OutputTextBox2);
            LineOptionsVisible = true;

            StatementsTextBox.SizeChanged += (o, e) =>
                StatementsTextBox.MaxHeight = Math.Max(
                    0,
                    CodeRow.MaxHeight = Math.Max(0, ActualHeight - 40)) - 8;

            RunMenuItem.Click += (o, e) => ViewModel.Execute(ExecutionCallback);
            StopMenuItem.Click += (o, e) => ViewModel.Stop();
            ClearMenuItem.Click += (o, e) => ViewModel.ClearConsole();
            ResetMenuItem.Click += (o, e) => ViewModel.Reset();
            ExpressionTextBox.PreviewKeyDown += InputTextBox_KeyDown;

            KeyDown += (o, e) =>
            {
                if (e.Key == Key.F5)
                {
                    ViewModel.Execute(ExecutionCallback);
                }
            };
                        
            ViewModel.IsControlInitialized = true;

            ViewModel.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == nameof(Code) && ViewModel.Code != Code)
                {
                    SetValue(CodeProperty, ViewModel.Code);
                };
            };
        }

        private void ExecutionCallback() => ExecutionCompleted?.Invoke(this, new EventArgs());

        public void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var tb = (CodeTextBox)sender;

            switch (e.Key)
            {
                case Key.Enter:
                    ViewModel.Execute(() =>
                    {
                        tb.Focus();
                        Keyboard.Focus(tb);
                        //tb.ScrollToEnd();
                    });
                    break;

                case Key.Up:
                    ViewModel.SetPreviousCode();
                    //tb.ScrollToEnd();
                    break;

                case Key.Down:
                    ViewModel.SetNextCode();
                    //tb.ScrollToEnd();
                    break;
            }
        }
    }
}
