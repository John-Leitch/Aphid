using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    public class Cache<TKey, TValue> : IEnumerable<KeyValuePair<TKey,TValue>>
    {
        private readonly Func<TKey, TValue> _createValue;

        private readonly Dictionary<TKey, TValue> _values = new Dictionary<TKey, TValue>();

        public Cache(Func<TKey, TValue> createValue) => _createValue = createValue;

        public TValue this[TKey key]
        {
            get
            {
                if (!_values.TryGetValue(key, out var value))
                {
                    _values.Add(key, value = _createValue(key));
                }

                return value;
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _values.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => ((IEnumerable)_values).GetEnumerator();
    }
}
