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

namespace AphidUI
{
    public static class TaskExtension
    {
        public static async void ContinueWith(this Task task, Action continuationAction) =>
            await task.ContinueWith(_ => continuationAction());
    }
}
