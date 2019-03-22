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
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();

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

        private static void Serialize(Stream stream, T element) => _formatter.Serialize(stream, element);

        private static T Deserialize(Stream stream) => (T)_formatter.Deserialize(stream);

        public IEnumerable<T> ReadUnsafe(Expression<Func<T, bool>> predicate) => ReadUnsafe().Where(predicate.Compile());//var key = predicate.ToString();//var results = ReadUnsafe().Where(predicate.Compile()).ToArray();//throw new NotImplementedException();
    }
}
