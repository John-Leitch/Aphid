using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public class FunctionDeclarationAttributes
    {
        [AphidAttribute("static")]
        public bool IsStatic { get; set; }
    }
}
