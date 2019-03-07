using LanguageServer.Parameters;
using LanguageServer.Parameters.TextDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidLanguageServer
{
    public class TextDocumentManager
    {
        public event EventHandler<TextDocumentChangedEventArgs> Changed;

        private Dictionary<Uri, TextDocumentItem> _documents = new Dictionary<Uri, TextDocumentItem>();

        public IEnumerable<TextDocumentItem> All => _documents.Values;

        public void Add(TextDocumentItem document)
        {
            if (_documents.ContainsKey(document.uri))
            {
                return;
            }

            _documents.Add(document.uri, document);            
            OnChanged(document);
        }

        public void Change(Uri uri, long version, TextDocumentContentChangeEvent[] changeEvents)
        {
            if (!_documents.TryGetValue(uri, out var document) ||
                document.version >= version)
            {
                return;
            }

            foreach (var ev in changeEvents)
            {
                Apply(document, ev);
            }

            document.version = version;
            OnChanged(document);
        }

        private void Apply(TextDocumentItem document, TextDocumentContentChangeEvent ev)
        {
            if (ev.range != null)
            {
                var startPos = GetPosition(document, ev.range.start);
                var endPos = GetPosition(document, ev.range.end);
                document.text = document.text.Substring(0, startPos) + ev.text + document.text.Substring(endPos);
            }
            else
            {
                document.text = ev.text;
            }
        }

        private static int GetPosition(TextDocumentItem document, Position position) =>
            GetPosition(document.text, (int)position.line, (int)position.character);

        private static int GetPosition(string text, int line, int character)
        {
            var pos = 0;

            for (; 0 <= line; line--)
            {
                var lf = text.IndexOf('\n', pos);
                if (lf < 0)
                {
                    return text.Length;
                }
                pos = lf + 1;
            }

            var linefeed = text.IndexOf('\n', pos);
            var max = 0;

            if (linefeed < 0)
            {
                max = text.Length;
            }
            else if (linefeed > 0 && text[linefeed - 1] == '\r')
            {
                max = linefeed - 1;
            }
            else
            {
                max = linefeed;
            }

            pos += character;

            return (pos < max) ? pos : max;
        }

        public void Remove(Uri uri) => _documents.Remove(uri);

        protected virtual void OnChanged(TextDocumentItem document) =>
            Changed?.Invoke(this, new TextDocumentChangedEventArgs(document));
    }
}
