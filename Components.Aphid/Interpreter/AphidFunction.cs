using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidFunction
    {
        public string[] Args { get; set; }

        public List<AphidExpression> Body { get; set; }

        public AphidObject ParentScope { get; set; }

        public AphidFunction Clone()
        {
            return new AphidFunction()
            {
                Args = Args,
                Body = Body,
                ParentScope = ParentScope,
            };
        }
    }
}
