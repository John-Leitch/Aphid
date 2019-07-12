using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    public class AphidAuthoringScope : AuthoringScope
    {
        public string[] Identifiers { get; set; }

        public override string GetDataTipText(int line, int col, out TextSpan span)
        {
            span = new Microsoft.VisualStudio.TextManager.Interop.TextSpan();
            return null;
        }

        public override Declarations GetDeclarations(IVsTextView view, int line, int col, TokenInfo info, ParseReason reason)
        {
            Debug.WriteLine("GetDeclarations token type: {0}", info.Type);

            string t = null;

            if (info.Type != TokenType.Delimiter)
            {
                info.Type = TokenType.Keyword;
                view.GetTextStream(line, col - (info.EndIndex - info.StartIndex + 1), line, col, out t);
                
                Debug.WriteLine("GetDeclarations text: {0}", t);
            }
            
            return new AphidDeclarations(this, t);
        }

        public override Methods GetMethods(int line, int col, string name) => null;

        public override string Goto(VSConstants.VSStd97CmdID cmd, IVsTextView textView, int line, int col, out TextSpan span)
        {
            span = new Microsoft.VisualStudio.TextManager.Interop.TextSpan();

            return null;
        }
    }
}
