using LanguageServer.Parameters.TextDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidLanguageServer
{
    public class TextDocumentChangedEventArgs : EventArgs
    {
        public TextDocumentChangedEventArgs(TextDocumentItem document) => Document = document;

        public TextDocumentItem Document { get; }
    }
}
