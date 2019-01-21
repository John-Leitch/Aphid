
namespace Components.ObjectDatabase
{
    public class ObjectDatabaseRecord<T>
    {
        public T Entity { get; }

        public long Offset { get; private set; }

        public IDatabaseContext<T> Context { get; }

        public ObjectDatabaseRecord(T entity, long offset, IDatabaseContext<T> context)
        {
            Entity = entity;
            Offset = offset;
            Context = context;
        }

        public void UpdateOffset(long offset)
        {
            Offset = offset;

            if (Entity is IObjectDatabaseEntity dbEntity)
            {
                dbEntity.Offset = offset;
            }
        }
    }
}
