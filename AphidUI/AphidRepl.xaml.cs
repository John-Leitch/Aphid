using AphidUI.ViewModels;
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
    /// Interaction logic for AphidReply.xaml
    /// </summary>
    public partial class AphidRepl : UserControl
    {
        public event EventHandler ExecutionCompleted;

        AphidReplViewModel _viewModel;

        public AphidReplViewModel ViewModel
        {
            get { return _viewModel; }
        }

        public static readonly DependencyProperty IsMultiLineProperty = DependencyProperty.Register(
          "IsMultiLine", typeof(bool), typeof(AphidRepl), new PropertyMetadata(false, IsMultiLineChanged));

        public bool IsMultiLine
        {
            get { return (bool)GetValue(IsMultiLineProperty); }
            set { SetValue(IsMultiLineProperty, value); }
        }

        public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(
            "Code", typeof(string), typeof(AphidRepl), new PropertyMetadata(CodeChanged));

        public string Code
        {
            get { return (string)GetValue(CodeProperty); }
            set { SetValue(CodeProperty, value); }
        }

        private bool _lineOptionsVisible;

        public bool LineOptionsVisible
        {
            get { return _lineOptionsVisible; }
            set 
            {
                _lineOptionsVisible = value;

                _viewModel.LineOptionVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public AphidRepl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = _viewModel = new AphidReplViewModel(OutputTextBox2);
            LineOptionsVisible = true;
            KeyDown += MainWindow_KeyDown;
            ExpressionTextBox.PreviewKeyDown += InputTextBox_KeyDown;
            RunMenuItem.Click += (o, e) => _viewModel.Execute(ExecutionCallback);
            StopMenuItem.Click += (o, e) => _viewModel.Stop();            
            ClearMenuItem.Click += (o, e) => _viewModel.ClearConsole();
            ResetMenuItem.Click += (o, e) => _viewModel.Reset();
            _viewModel.IsControlInitialized = true;
            _viewModel.PropertyChanged += vm_PropertyChanged;
        }

        private void ExecutionCallback()
        {
            if (ExecutionCompleted != null)
            {
                ExecutionCompleted(this, new EventArgs());
            }
        }

        public void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F5:
                    _viewModel.Execute(ExecutionCallback);
                    break;
            }
        }   

        public void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var tb = (CodeTextBox)sender;

            switch (e.Key)
            {
                case Key.Enter:
                    _viewModel.Execute(() =>
                    {
                        tb.Focus();
                        Keyboard.Focus(tb);
                        //tb.ScrollToEnd();
                    });
                    break;

                case Key.Up:
                    _viewModel.SetPreviousCode();
                    //tb.ScrollToEnd();
                    break;

                case Key.Down:
                    _viewModel.SetNextCode();
                    //tb.ScrollToEnd();
                    break;
            }
        }

        void vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Code")
            {
                if (_viewModel.Code != Code)
                {
                    SetValue(CodeProperty, _viewModel.Code);
                }
            }
        }

        public static void IsMultiLineChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var viewer = (AphidRepl)sender;
            viewer._viewModel.IsMultiLine = (bool)args.NewValue;
        }

        public static void CodeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var viewer = (AphidRepl)sender;

            if ((string)args.OldValue == (string)args.NewValue)
            {
                return;
            }

            viewer._viewModel.Code = (string)args.NewValue;
        }

        private void StatementsTextBox_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            StatementsTextBox.MaxHeight = Math.Max(0, (CodeRow.MaxHeight = Math.Max(0, ActualHeight - 40)) - 8);
        }
    }
}
