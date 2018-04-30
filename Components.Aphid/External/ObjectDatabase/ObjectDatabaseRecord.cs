
namespace Components.ObjectDatabase
{
    public class ObjectDatabaseRecord<T>
    {
        public T Value { get; private set; }

        public long Offset { get; private set; }

        public IDatabaseContext<T> Context { get; private set; }

        public ObjectDatabaseRecord(T value, long offset, IDatabaseContext<T> context)
        {
            Value = value;
            Offset = offset;
            Context = context;
        }
    }
}
