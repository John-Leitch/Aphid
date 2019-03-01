using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeContext
    {
        public HashSet<string> Imports { get; }

        public string[] Path { get; }

        public bool IsType { get; }

        public bool IsResolved { get; set; }

        public ReaderWriterLockSlim ImportsLock { get; }

        public InteropTypeContext(
            HashSet<string> imports,
            string[] path,
            bool isType,
            ReaderWriterLockSlim importsLock)
        {
            Imports = imports;
            Path = path;
            IsType = isType;
            ImportsLock = importsLock;
        }
    }
}
