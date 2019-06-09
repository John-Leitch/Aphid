namespace Components.Aphid.UnitTests.Shared
{
    public class ValueUpdateEventArgs<TValue> : ValueEventArgs<TValue>
    {
        public TValue OldValue { get; private set; }

        public bool CanCancel { get; private set; }

        public ValueUpdateEventArgs(TValue oldValue, TValue value, bool canCancel, bool canChange)
            : base(value, canChange)
        {
            OldValue = oldValue;
            CanCancel = canCancel;
        }
    }
}
