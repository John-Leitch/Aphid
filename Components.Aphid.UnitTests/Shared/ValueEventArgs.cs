using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests.Shared
{
    public class ValueEventArgs<TValue> : EventArgs
    {
        public TValue Value { get; private set; }

        public bool CanChange { get; private set; }

        public ValueEventArgs(TValue value, bool canChange)
        {
            Value = value;
            CanChange = canChange;
        }

        public void ChangeValue(TValue value)
        {
            if (!CanChange)
            {
                throw new InvalidOperationException("Cannot change value.");
            }

            Value = value;
        }
    }
}
