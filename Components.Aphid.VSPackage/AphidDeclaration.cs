using Microsoft.VisualStudio.Language.Intellisense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    
    public class AphidDeclaration
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string DisplayText { get; set; }

        public StandardGlyphGroup Glyph { get; set; }

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
