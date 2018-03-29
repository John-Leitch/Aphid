﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class RevertibleLazy<T>
    {
        private Func<T> _valueFactory;

        private Lazy<T> _lazy;

        public bool IsValueCreated
        {
            get { return _lazy.IsValueCreated; }
        }

        public T Value
        {
            get { return _lazy.Value; }
        }

        public RevertibleLazy(Func<T> valueFactory)
        {
            _lazy = new Lazy<T>(_valueFactory = valueFactory);
        }

        public void Revert()
        {
            _lazy = new Lazy<T>(_valueFactory);
        }
    }
}