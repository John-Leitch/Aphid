using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public class ObjectStatementAttributes
    {
        [AphidAttribute("class")]
        public bool IsClass { get; set; }
    }
}
