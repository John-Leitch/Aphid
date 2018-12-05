using LanguageServer.Parameters.TextDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServer
{
    public class TextDocumentChangedEventArgs : EventArgs
    {
        private readonly TextDocumentItem _document;

        public TextDocumentChangedEventArgs(TextDocumentItem document)
        {
            _document = document;
        }

        public TextDocumentItem Document => _document;
    }
}
