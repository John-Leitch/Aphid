using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Package;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.Language.Intellisense.StandardGlyphGroup;

namespace Components.Aphid.VSPackage
{
    public class AphidDeclarations : Declarations
    {
        private readonly string _text;

        private readonly AphidDeclaration[] _declarations;

        private readonly AphidAuthoringScope _scope;

        public AphidDeclarations(AphidAuthoringScope scope, string text)
        {
            _scope = scope;
            _text = text;
            
            IEnumerable<AphidDeclaration> decls = new[]
            {
                new AphidDeclaration("break", GlyphKeyword),
                new AphidDeclaration("catch", GlyphKeyword),
                new AphidDeclaration("default", GlyphKeyword),
                new AphidDeclaration("defined", GlyphKeyword),
                new AphidDeclaration("delete", GlyphKeyword),
                new AphidDeclaration("else", GlyphKeyword),
                new AphidDeclaration("extend", GlyphKeyword),
                new AphidDeclaration("false", GlyphKeyword),
                new AphidDeclaration("finally", GlyphKeyword),
                new AphidDeclaration("for", GlyphKeyword),
                new AphidDeclaration("if", GlyphKeyword),
                new AphidDeclaration("in", GlyphKeyword),
                new AphidDeclaration("null", GlyphKeyword),
                new AphidDeclaration("ret", GlyphKeyword),
                new AphidDeclaration("switch", GlyphKeyword),
                new AphidDeclaration("this", GlyphKeyword),
                new AphidDeclaration("true", GlyphKeyword),
                new AphidDeclaration("try", GlyphKeyword),
                new AphidDeclaration("while", GlyphKeyword),
            };

            if (_scope.Identifiers != null)
            {
                var ids = _scope.Identifiers
                    .Select(x => new AphidDeclaration(x, GlyphGroupVariable));

                decls = decls.Concat(ids);
            }

            if (text != null)
            {
                decls = decls.Where(x => x.DisplayText.Contains(text));
            }
            else
            {
                decls = decls.Where(x => x.Glyph != GlyphKeyword);
            }

            _declarations = decls.OrderBy(x => x.DisplayText).ToArray();

            Debug.WriteLine("Declaration count: {0}", _declarations.Length);
        }

        public override int GetCount() =>
            _declarations.Length;

        public override string GetDescription(int index) =>
            _declarations[index].Description;

        public override string GetDisplayText(int index) =>
            _declarations[index].DisplayText;

        public override int GetGlyph(int index) =>
            (int)_declarations[index].Glyph;

        public override string GetName(int index) =>
            index > -1 ? _declarations[index].Name : null;
    }
}
