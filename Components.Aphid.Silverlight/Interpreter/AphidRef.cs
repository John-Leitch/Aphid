using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidRef
    {
        public string Name { get; set; }

        public AphidObject Object { get; set; }

        public AphidObject Get()
        {
            return Object[Name];
        }
    }
}
