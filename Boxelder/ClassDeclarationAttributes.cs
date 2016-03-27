using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public class ClassDeclarationAttributes
    {
        [AphidAttribute("class")]
        public bool IsClass { get; set; }

        [AphidAttribute("iter")]
        public bool IsIter { get; set; }

        [AphidAttribute("init")]
        public bool IsAutoInit { get; set; }
    }
}
