using Components.IO;
using System.Linq;
using static NUnit.Framework.Assert;
using Odb = Components.ObjectDatabase.ObjectDatabase<object>;

namespace Components.ObjectDatabase.Tests
{
    public static class ObjectDatabaseTestExtensions
    {
        public static void AssertNoFragmentation(this Odb db) =>
            AssertNoFragmentation(db.ReadMemoryManagerUnsafe());

        public static void AssertNoFragmentation(this MemoryManager mm) =>
            IsEmpty(mm.Bitmap.Do(IsNotEmpty).SkipWhile(y => y).SkipWhile(y => !y));

        public static void AssertFragmentation(this Odb db) =>
            AssertFragmentation(db.ReadMemoryManagerUnsafe());

        public static void AssertFragmentation(this MemoryManager mm) =>
            IsNotEmpty(mm.Bitmap.Do(IsNotEmpty).SkipWhile(y => y).SkipWhile(y => !y));

        public static bool HasNoFragmentation(this Odb db) =>
            HasNoFragmentation(db.ReadMemoryManagerUnsafe());

        public static bool HasNoFragmentation(this MemoryManager mm) =>
            mm.Bitmap.SkipWhile(y => y).SkipWhile(y => !y).None();

        public static bool HasFragmentation(this Odb db) =>
            HasFragmentation(db.ReadMemoryManagerUnsafe());

        public static bool HasFragmentation(this MemoryManager mm) =>
            !mm.HasNoFragmentation();
    }
}
