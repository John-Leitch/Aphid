using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            OutputPanel.Controls.Clear();
            Console.WriteLine("Running Aphid");
            var interpreter = new AphidInterpreter();
            interpreter.CurrentScope.Add("root", ValueHelper.Wrap(OutputPanel));
            
            try
            {
                interpreter.Interpret(CodeTextBox.Text);
            }
            catch (AphidParserException exception)
            {
                Console.WriteLine("Parser exception\r\n");
                Console.WriteLine(ParserErrorMessage.Create(CodeTextBox.Text, exception));
            }
            catch (AphidRuntimeException exception)
            {
                Console.WriteLine("Unexpected runtime exception\r\n\r\n{0}\r\n", exception.Message);
                DumpStackTrace(interpreter);
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    "Unexpected exception\r\n\r\n{0}\r\n",
                    ExceptionHelper.Unwrap(exception).Message);

                DumpStackTrace(interpreter);
            }
            //CodeTextBox.Text
        }

        private void DumpStackTrace(AphidInterpreter interpreter)
        {
            var trace = interpreter.GetStackTrace();
            var i = 0;
            Cli.WriteSubheader("Stack Trace", "~|Blue~~White~");

            foreach (var frame in trace)
            {
                Cli.WriteLine("[~White~{0:x4}~R~] {1}", i++, frame.ToString(true));
            }

            Cli.WriteLine();
        }
    }
}
