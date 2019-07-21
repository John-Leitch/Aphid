using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public class IdentifierStatementAttributes
    {
        [AphidAttribute("var")]
        public bool IsVar { get; set; }

        [AphidAttribute("throw")]
        public bool IsThrow { get; set; }        
    }
}
