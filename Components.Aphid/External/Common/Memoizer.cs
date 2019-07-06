using System;
using System.Collections.Generic;

namespace Components.External
{
    public class Memoizer<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache;

        public Memoizer() => _cache = new Dictionary<TArg, TResult>();

        public Memoizer(IEqualityComparer<TArg> comparer) => _cache = new Dictionary<TArg, TResult>(comparer);

        public TResult Call(Func<TArg, TResult> func, TArg arg)
        {
            lock (_cache)
            {
                if (!_cache.TryGetValue(arg, out var val))
                {
                    _cache.Add(arg, val = func(arg));
                }

                return val;
            }
        }

        public TResult Overwite(Func<TArg, TResult> func, TArg arg)
        {
            lock (_cache)
            {
                return _cache[arg] = func(arg);
            }
        }

        public void Remove(TArg arg)
        {
            lock (_cache)
            {
                _cache.Remove(arg);
            }
        }

        public void Clear() => _cache.Clear();
    }
}
