using AphidUI.Internal;
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
    /// Interaction logic for CodeEditor.xaml
    /// </summary>
    public partial class CodeTextBox : UserControl
    {
        private CodeCanvas _codeCanvas;

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(CodeTextBox),
                new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTextChanged)));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var v = (string)e.NewValue;
            var t = (CodeTextBox)d;
            
            if (t.TextBox.Text != v)
            {
                t.TextBox.SetText(v);
            }
        }

        public static readonly DependencyProperty AcceptsReturnProperty = DependencyProperty.Register(
                "AcceptsReturn",
                typeof(bool),
                typeof(CodeTextBox),
                new FrameworkPropertyMetadata(false, new PropertyChangedCallback(OnAcceptsReturnChanged)));

        public bool AcceptsReturn
        {
            get { return (bool)GetValue(AcceptsReturnProperty); }
            set { SetValue(AcceptsReturnProperty, value); }
        }

        public static void OnAcceptsReturnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var t = (CodeTextBox)d;
            var b = (bool)e.NewValue;

            t.SetScrollBarVisibility();
            t._codeCanvas.AcceptsReturn = b;
        }

        public CodeTextBox()
        {
            InitializeComponent();
            _codeCanvas = Viewer.Content as CodeCanvas;

            if (_codeCanvas == null)
            {
                var border = Viewer.Content as Border;

                _codeCanvas = border.Child as CodeCanvas;

                if (_codeCanvas == null)
                {
                    throw new InvalidOperationException();
                }
            }

            _codeCanvas.TextChanged += CodeEditor_TextChanged;
            Viewer.PreviewKeyDown += _codeCanvas.UserControl_KeyDown;
            SetScrollBarVisibility();
            //SizeChanged += _codeCanvas.UserControl_SizeChanged;
        }

        private void SetScrollBarVisibility()
        {
            Viewer.HorizontalScrollBarVisibility = AcceptsReturn ? ScrollBarVisibility.Auto : ScrollBarVisibility.Hidden;
            Viewer.VerticalScrollBarVisibility = AcceptsReturn ? ScrollBarVisibility.Visible : ScrollBarVisibility.Hidden;
        }

        void CodeEditor_TextChanged(object sender, RoutedEventArgs e)
        {
            SetValue(TextProperty, _codeCanvas.Text);
            //Text = _codeCanvas.Text;
        }

        private void Viewer_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var width = Viewer.ActualWidth - 30;

            if (_codeCanvas.ActualWidth > width)
            {
                _codeCanvas.Width = width;
            }
        }        
    }
}
