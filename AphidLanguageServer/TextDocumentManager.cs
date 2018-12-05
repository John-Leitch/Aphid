using LanguageServer.Parameters;
using LanguageServer.Parameters.TextDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServer
{
    public class TextDocumentManager
    {
        private readonly List<TextDocumentItem> _all = new List<TextDocumentItem>();
        public IReadOnlyList<TextDocumentItem> All => _all;

        public void Add(TextDocumentItem document)
        {
            if (_all.Any(x => x.uri == document.uri))
            {
                return;
            }
            _all.Add(document);
            OnChanged(document);
        }

        public void Change(Uri uri, long version, TextDocumentContentChangeEvent[] changeEvents)
        {
            var index = _all.FindIndex(x => x.uri == uri);
            if (index < 0)
            {
                return;
            }
            var document = _all[index];
            if (document.version >= version)
            {
                return;
            }
            foreach(var ev in changeEvents)
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
                var startPos = GetPosition(document.text, (int)ev.range.start.line, (int)ev.range.start.character);
                var endPos = GetPosition(document.text, (int)ev.range.end.line, (int)ev.range.end.character);
                var newText = document.text.Substring(0, startPos) + ev.text + document.text.Substring(endPos);
                document.text = newText;
            }
            else
            {
                document.text = ev.text;
            }
        }

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

        public void Remove(Uri uri)
        {
            var index = _all.FindIndex(x => x.uri == uri);
            if (index < 0)
            {
                return;
            }
            _all.RemoveAt(index);
        }

        public event EventHandler<TextDocumentChangedEventArgs> Changed;

        protected virtual void OnChanged(TextDocumentItem document)
        {
            Changed?.Invoke(this, new TextDocumentChangedEventArgs(document));
        }
    }
}
