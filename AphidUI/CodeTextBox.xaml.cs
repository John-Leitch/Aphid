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
                nameof(Text),
                typeof(string),
                typeof(CodeTextBox),
                new FrameworkPropertyMetadata(
                    null,
                    (o, e) =>
                    {
                        var v = (string)e.NewValue;
                        var t = (CodeTextBox)o;

                        if (t.TextBox.Text != v)
                        {
                            t.TextBox.SetText(v);
                        }
                    }));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty AcceptsReturnProperty = DependencyProperty.Register(
                nameof(AcceptsReturn),
                typeof(bool),
                typeof(CodeTextBox),
                new FrameworkPropertyMetadata(
                    false,
                    (o, e) =>
                    {
                        var t = (CodeTextBox)o;
                        t.SetScrollBarVisibility();
                        t._codeCanvas.AcceptsReturn = (bool)e.NewValue;
                    }));

        public bool AcceptsReturn
        {
            get => (bool)GetValue(AcceptsReturnProperty);
            set => SetValue(AcceptsReturnProperty, value);
        }

        public CodeTextBox()
        {
            InitializeComponent();

            if ((_codeCanvas = Viewer.Content as CodeCanvas) == null &&
                (_codeCanvas = ((Border)Viewer.Content).Child as CodeCanvas) == null)
            {
                throw new InvalidOperationException(
                    "CodeTextBox could not find CodeCanvas.");
            }

            _codeCanvas.TextChanged += (o, e) => SetValue(TextProperty, _codeCanvas.Text);
            Viewer.PreviewKeyDown += _codeCanvas.UserControl_KeyDown;
            SetScrollBarVisibility();
        }

        private void SetScrollBarVisibility()
        {
            Viewer.HorizontalScrollBarVisibility = AcceptsReturn ?
                ScrollBarVisibility.Auto : ScrollBarVisibility.Hidden;

            Viewer.VerticalScrollBarVisibility = AcceptsReturn ?
                ScrollBarVisibility.Visible : ScrollBarVisibility.Hidden;
        }

        private void ViewerSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var width = Viewer.ActualWidth - 30;

            if (_codeCanvas.ActualWidth > width)
            {
                _codeCanvas.Width = width;
            }
        }        
    }
}
