using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf
{
    public class ObjectStatementAttributes
    {
        [AphidAttribute("class")]
        public bool IsClass { get; set; }

        [AphidAttribute("abstract")]
        public bool IsAbstract { get; set; }

        [AphidAttribute("interface")]
        public bool IsInterface { get; set; }
    }
}
