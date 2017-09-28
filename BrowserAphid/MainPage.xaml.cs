using Components.Aphid.Interpreter;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BrowserAphid
{
    public partial class MainPage : UserControl
    {
        private AphidInterpreter _aphid;

        public MainPage()
        {
            InitializeComponent();

            _aphid = new AphidInterpreter();
            
            OutText.Text += "Ready\r\n";
            
        }

        public object Print(AphidInterpreter i, object[] args)
        {
            var strArgs = args.Select(ValueHelper.Unwrap).ToList();
            OutText.Text += string.Format("{0}{1}", strArgs[0], "");
            return null;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OutText.Text += "ExecutingScript\r\n";
            

            try
            {
                _aphid.CurrentScope.Clear();
                _aphid.Loader.LoadLibrary<StandardLibrary>(_aphid.CurrentScope);
                _aphid.CurrentScope["print"] = new AphidObject(new AphidInteropFunction(Print));
                _aphid.Interpret(CodeText.Text);
            }
            catch (AphidParserException e2)
            {
                OutText.Text += ParserErrorMessage.Create(CodeText.Text, e2) + "\r\n";
            }
            catch (AphidRuntimeException e2)
            {
                OutText.Text += "Aphid runtime exception\r\n" + e2.StackTrace + "\r\n";
            }
            catch (Exception e2)
            {
                OutText.Text += ".NET runtime exception\r\n" + e2.Message + e2.StackTrace + "\r\n";
            }
        }

        private void Button_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
