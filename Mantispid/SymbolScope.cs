using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class SymbolScope<TValue>
    {
        public SymbolTable<TValue> Table { get; private set; }

        public void EnterChildScope()
        {
            Table = Table.ToChild();
        }

        public void LeaveChildScope()
        {
            Table = Table.Parent;
        }

        public SymbolScope(Func<TValue> init)
        {
            Table = new SymbolTable<TValue>(init, null);
        }

        public SymbolScope()
            : this(null)
        {
        }
    }
}
