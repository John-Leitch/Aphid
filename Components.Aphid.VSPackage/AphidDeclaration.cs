using Microsoft.VisualStudio.Language.Intellisense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    public readonly struct AphidDeclaration
    {
        public readonly string Name;

        public readonly string Description;

        public readonly string DisplayText;

        public readonly StandardGlyphGroup Glyph;

        public AphidDeclaration(string name, string description, string displayText, StandardGlyphGroup glyph)
        {
            Name = name;
            Description = description;
            DisplayText = displayText;
            Glyph = glyph;
        }

        public AphidDeclaration(string name, StandardGlyphGroup glyph)
            : this(name, null, name, glyph)
        {
        }
    }
}
