using System;
using System.Diagnostics;

namespace Components
{
    public struct MutableLazy<T>
    {
        private readonly Func<T> _create;
        private T _value;

        public bool IsValueCreated { get; private set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public T Value
        {
            get
            {
                if (IsValueCreated)
                {
                    return _value;
                }

                _value = _create();
                IsValueCreated = true;

                return _value;
            }
        }

        public MutableLazy(T value)
        {
            _create = null;
            IsValueCreated = true;
            _value = value;
        }

        public MutableLazy(Func<T> create)
        {
            _create = create;
            IsValueCreated = false;
            _value = default;
        }

        public static implicit operator MutableLazy<T>(T value) => new MutableLazy<T>(value);

        public static implicit operator T(MutableLazy<T> value) => value.Value;
    }
}
