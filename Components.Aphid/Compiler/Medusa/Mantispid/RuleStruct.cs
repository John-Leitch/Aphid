using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class RuleStruct
    {
        public string Name { get; private set; }

        public string BaseName { get; private set; }

        public ParserIdentifier[] Properties { get; private set; }

        public RuleStruct(string name, string baseName, ParserIdentifier[] properties)
        {
            Name = name;
            BaseName = baseName;
            Properties = properties;
        }
    }
}
