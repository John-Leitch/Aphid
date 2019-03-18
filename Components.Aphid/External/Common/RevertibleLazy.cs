using System;

namespace Components
{
    public class RevertibleLazy<T>
    {
        private readonly Func<T> _valueFactory;

        private Lazy<T> _lazy;

        public bool IsValueCreated => _lazy.IsValueCreated;

        public T Value => _lazy.Value;

        public RevertibleLazy(Func<T> valueFactory) => _lazy = new Lazy<T>(_valueFactory = valueFactory);

        public void Revert() => _lazy = new Lazy<T>(_valueFactory);
    }
}
