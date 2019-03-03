using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Package;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    public class AphidDeclarations : Declarations
    {
        private readonly string _text;

        private AphidDeclaration[] _declarations;

        private readonly AphidAuthoringScope _scope;

        public AphidDeclarations(AphidAuthoringScope scope, string text)
        {
            _scope = scope;
            _text = text;
            SetDeclarations(text);
        }

        private void SetDeclarations(string text)
        {
            IEnumerable<AphidDeclaration> decls = new[]
            {
                new AphidDeclaration("break", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("catch", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("default", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("defined", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("delete", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("else", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("extend", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("false", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("finally", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("for", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("if", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("in", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("null", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("ret", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("switch", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("this", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("true", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("try", StandardGlyphGroup.GlyphKeyword),
                new AphidDeclaration("while", StandardGlyphGroup.GlyphKeyword),
            };

            if (_scope.Identifiers != null)
            {
                var ids = _scope.Identifiers
                    .Select(x => new AphidDeclaration(x, StandardGlyphGroup.GlyphGroupVariable));

                decls = decls.Concat(ids);
            }

            if (text != null)
            {
                decls = decls.Where(x => x.DisplayText.Contains(text));
            }
            else
            {
                decls = decls.Where(x => x.Glyph != StandardGlyphGroup.GlyphKeyword);
            }

            _declarations = decls.OrderBy(x => x.DisplayText).ToArray();

            Debug.WriteLine("Declaration count: {0}", _declarations.Length);
        }

        public override int GetCount()
        {
            return _declarations.Length;
        }

        public override string GetDescription(int index)
        {
            return _declarations[index].Description;
        }

        public override string GetDisplayText(int index)
        {
            return _declarations[index].DisplayText;
        }

        public override int GetGlyph(int index)
        {
            return (int)_declarations[index].Glyph;
        }

        public override string GetName(int index)
        {
            return index > -1 ? _declarations[index].Name : null;
        }
    }
}
