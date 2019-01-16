using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    [DataContract]
    public class Table<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private readonly Func<TValue> _createValue = null;

        [DataMember]
        private Dictionary<TKey, TValue> _table = new Dictionary<TKey, TValue>();

        [IgnoreDataMember]
        public Dictionary<TKey, TValue>.KeyCollection Keys
        {
            get { return _table.Keys; }
        }

        [IgnoreDataMember]
        public Dictionary<TKey, TValue>.ValueCollection Values
        {
            get { return _table.Values; }
        }

        public Table()
        {
        }

        public Table(Dictionary<TKey, TValue> dictionary) =>
            _table = dictionary.ToDictionary(x => x.Key, x => x.Value);

        public Table(Func<TValue> createValue) =>
            _createValue = createValue;

        public TValue this[TKey key]
        {
            get
            {
                if (!_table.TryGetValue(key, out var a))
                {
                    _table.Add(key, a = _createValue == null ?  default : _createValue());
                }

                return a;
            }
            set
            {
                if (!_table.ContainsKey(key))
                {
                    _table.Add(key, value);
                }
                else
                {
                    _table[key] = value;
                }
            }
        }

        public Dictionary<TKey, TValue> GetDictionary() => _table;

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _table.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_table).GetEnumerator();

        public static Table<TKey, TValue> Convert(Dictionary<TKey, TValue> dictionary) => new Table<TKey, TValue>() { _table = dictionary };
    }
}
