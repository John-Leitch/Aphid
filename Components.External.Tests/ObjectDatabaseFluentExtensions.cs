using Components.ObjectDatabase;

namespace Components.External.Tests
{
    public static class ObjectDatabaseFluentExtensions
    {
        public static ObjectDatabase<TElement> Set<TElement>(
            this ObjectDatabase<TElement> db,
            bool setEntityMetaData = false,
            bool trackEntities = false,
            bool isReadOnly = false) => db
            .Do(x => x.SetEntityMetaData = setEntityMetaData)
            .Do(x => x.TrackEntities = trackEntities)
            .Do(x => x.IsReadOnly = isReadOnly);
    }
}
