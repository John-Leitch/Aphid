using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Lexer
{
    public partial class AphidLexer
    {
        public void SetCodeMode()
        {
            mode = 0;
        }

        public void SetTextMode()
        {
            mode = 1;
        }
    }
}
