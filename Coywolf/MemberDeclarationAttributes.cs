using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coywolf
{
    public class MemberDeclarationAttributes
    {
        [AphidAttribute("abstract")]
        public bool IsAbstract { get; set; }

        [AphidAttribute("private")]
        public bool IsPrivate { get; set; }

        [AphidAttribute("protected")]
        public bool IsProtected { get; set; }

        [AphidAttribute("public")]
        public bool IsPublic { get; set; }

        [AphidAttribute("func")]
        public bool IsFunction { get; set; }
    }
}
