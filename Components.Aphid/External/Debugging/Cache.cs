﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Components.Cypress
{
    public class Cache<TKey, TValue> : IEnumerable<KeyValuePair<TKey,TValue>>
    {
        private readonly Func<TKey, TValue> _createValue;

        private readonly Dictionary<TKey, TValue> _values = new();

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

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_values).GetEnumerator();
    }
}
