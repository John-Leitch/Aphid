namespace Components.ObjectDatabase
{
    public static class BinaryObjectDatabase
    {
        public static BinaryObjectDatabase<object> OpenFile() => OpenFile<object>();

        public static BinaryObjectDatabase<object> OpenFile(string filename) => OpenFile<object>(filename);

        public static BinaryObjectDatabase<object> OpenFile(string filename, bool useUnsafeMemoryManager) => OpenFile<object>(filename, useUnsafeMemoryManager);

        public static BinaryObjectDatabase<T> OpenFile<T>()
        {
            var db = new BinaryObjectDatabase<T>();
            db.Open();

            return db;
        }

        public static BinaryObjectDatabase<T> OpenFile<T>(string filename)
        {
            var db = new BinaryObjectDatabase<T>(filename);
            db.Open();

            return db;
        }

        public static BinaryObjectDatabase<T> OpenFile<T>(string filename, bool useUnsafeMemoryManager)
        {
            var db = new BinaryObjectDatabase<T>(filename, useUnsafeMemoryManager);
            db.Open();

            return db;
        }
    }
}
