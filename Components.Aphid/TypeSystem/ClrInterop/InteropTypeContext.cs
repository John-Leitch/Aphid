using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeContext
    {
        public HashSet<string> Imports { get; private set; }

        public string[] Path { get; private set; }

        public HashSet<string> PathHashSet { get; private set; }

        public bool IsType { get; private set; }

        public bool IsResolved { get; set; }

        public InteropTypeContext(HashSet<string> imports, string[] path, bool isType)
        {
            Imports = imports;
            Path = path;
            PathHashSet = new HashSet<string>(path);
            IsType = isType;
        }
    }
}
