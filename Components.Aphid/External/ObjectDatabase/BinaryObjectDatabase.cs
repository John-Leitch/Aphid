using Components.External;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Components.ObjectDatabase
{
    public class BinaryObjectDatabase<T> : ObjectDatabase<T>
    {
        private static BinaryFormatter _formatter = new BinaryFormatter();

        public BinaryObjectDatabase()
            : this(PathHelper.GetExecutingPath(typeof(T).FullName + ".odb"))
        {
        }

        public BinaryObjectDatabase(string filename)
            : this(filename, false)
        {
        }

        public BinaryObjectDatabase(string filename, bool useUnsafeMemoryManager)
            : base(filename, Serialize, Deserialize, useUnsafeMemoryManager)
        {
        }

        private static void Serialize(Stream stream, T element)
        {
            _formatter.Serialize(stream, element);
        }

        private static T Deserialize(Stream stream)
        {
            return (T)_formatter.Deserialize(stream);
        }

        public class ObjectDatabaseExpressionCacheEntry
        {
            public DateTime CacheTime { get; set; }

            public long Offset { get; set; }

            public ObjectDatabaseExpressionCacheEntry()
            {
            }

            public ObjectDatabaseExpressionCacheEntry(DateTime cacheTime, long offset)
            {
                CacheTime = cacheTime;
                Offset = offset;
            }
        }

        public class ExpressionCacheTable : Dictionary<Expression<Func<T, bool>>, IEnumerable<ObjectDatabaseExpressionCacheEntry>>
        {
        }

        public class ObjectDatabaseExpressionCache
        {
            private ExpressionCacheTable _table = new ExpressionCacheTable();


        }

        public IEnumerable<T> ReadUnsafe(Expression<Func<T, bool>> predicate)
        {
            var key = predicate.ToString();

            

            var results = ReadUnsafe().Where(predicate.Compile()).ToArray();

            throw new NotImplementedException();
        }
    }

    public static class BinaryObjectDatabase
    {
        public static BinaryObjectDatabase<object> OpenFile()
        {
            return OpenFile<object>();
        }

        public static BinaryObjectDatabase<object> OpenFile(string filename)
        {
            return OpenFile<object>(filename);
        }

        public static BinaryObjectDatabase<object> OpenFile(string filename, bool useUnsafeMemoryManager)
        {
            return OpenFile<object>(filename, useUnsafeMemoryManager);
        }

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
