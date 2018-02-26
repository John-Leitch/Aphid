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
        private Func<TKey, TValue> _createValue;

        private Dictionary<TKey, TValue> _values = new Dictionary<TKey, TValue>();

        public Cache(Func<TKey, TValue> createValue)
        {
            _createValue = createValue;
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;

                if (!_values.TryGetValue(key, out value))
                {
                    _values.Add(key, value = _createValue(key));
                }

                return value;
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_values).GetEnumerator();
        }
    }
}
