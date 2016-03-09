using System;
using System.Collections.Generic;
using System.Threading;

namespace Components
{
    public class Memoizer<TArg, TResult>
    {
        private Dictionary<TArg, TResult> _cache = new Dictionary<TArg, TResult>();

        public TResult Call(Func<TArg, TResult> func, TArg arg)
        {
            TResult val;

            Monitor.Enter(_cache);
            if (!_cache.TryGetValue(arg, out val))
            {
                Monitor.Exit(_cache);
                val = func(arg);
                Monitor.Enter(_cache);
                _cache.Add(arg, val);
            }
            Monitor.Exit(_cache);

            return val;
        }

        public void Clear()
        {
            _cache.Clear();
        }
    }
}
