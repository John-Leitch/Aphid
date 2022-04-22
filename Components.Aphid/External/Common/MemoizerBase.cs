using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External
{
    public abstract class MemoizerBase<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache = new Dictionary<TArg, TResult>();

        protected abstract TResult Create(TArg arg);

        public TResult Call(TArg arg)
        {
            lock (_cache)
            {
                if (!_cache.TryGetValue(arg, out var val))
                {
                    _cache.Add(arg, val = Create(arg));
                }

                return val;
            }
        }

        public TResult Overwite(TArg arg)
        {
            lock (_cache)
            {
                return _cache[arg] = Create(arg);
            }
        }

        public void Remove(TArg arg)
        {
            lock (_cache)
            {
                _cache.Remove(arg);
            }
        }

        public void Clear()
        {
            lock (_cache)
            {
                _cache.Clear();
            }
        }
    }
}
