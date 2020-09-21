using System;
using System.Collections.Generic;

namespace Mantispid
{
    public class SymbolTable<TValue>
    {
        private readonly Dictionary<string, TValue> _table = new Dictionary<string, TValue>();

        private readonly Func<TValue> _init;

        public SymbolTable<TValue> Parent { get; }

        public bool TryResolve(string key, out TValue value) => _table.TryGetValue(key, out value) ? true : Parent != null ? Parent.TryResolve(key, out value) : false;

        public void Add(string key, TValue value) => _table.Add(key, value);

        public SymbolTable(Func<TValue> init, SymbolTable<TValue> parent)
        {
            _init = init;
            Parent = parent;
        }

        public SymbolTable(SymbolTable<TValue> parent)
            : this(null, parent)
        {
        }

        public SymbolTable()
            : this(null, null)
        {
        }

        public SymbolTable<TValue> ToChild() => new SymbolTable<TValue>(_init, this);
    }
}
