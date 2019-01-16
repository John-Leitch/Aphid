using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static NUnit.Framework.Assert;
using static System.IO.File;
using BinDB = Components.ObjectDatabase.ObjectDatabase<object>;

namespace Components.ObjectDatabase.Tests
{
    public class ObjectDatabaseTestBase
    {
        private ThreadLocal<ObjectDatabaseTestContext> _context =
            new ThreadLocal<ObjectDatabaseTestContext>(() =>
                new ObjectDatabaseTestContext());

        public ObjectDatabaseTestContext Context => _context.Value;

        public BinDB DB => Context.CurrentDB;

        public Widget Widget => Context.CurrentWidget;

        [SetUp]
        public void Setup() => Context.NextDB();

        [TearDown]
        public Task TearDown() => Task.Factory.StartNew(x => x.As<BinDB>(Cleanup), DB);

        private void Cleanup(BinDB x) => x
            .Do(y => y.Dispose())
            .Do(y => new[] { y.Filename, y.MemoryManagerFilename }.For(Delete));

        protected void TestCreateReadManyUniqueCore(
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            int pageSize,
            Func<int, Widget> createWidget,
            int count = 0x10,
            bool performEqualityChecks = true)
        {
            DB.ReadMemoryManagerUnsafe().Do(x => x.PageSize = pageSize).Do(DB.WriteMemoryManagerUnsafe);
            DB.SetEntityMetaData = setEntityMetaData;
            DB.TrackEntities = trackEntities;
            DB.AssertNoFragmentation();

            for (var i = 0; i < count; i++)
            {
                DB.Create(createWidget(i));
            }

            DB.IsReadOnly = isReadOnly;
            var rows = DB.ReadUnsafe();

            if (performEqualityChecks)
            {
                AreNotEqual(Widget, rows.First());
                AreEqual(Widget, rows.Last());
                AreEqual(count, rows.Count());
            }
            else
            {
                rows.Count();
            }

            DB.ReadMemoryManagerUnsafe()
                .Do(x => AreEqual(count, x.Allocations.Count))
                .Do(x => x.AssertNoFragmentation());
        }

        protected void CatchReadOnlyFault(
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            int pageSize,
            Action<BinDB> action) => DB
            .Set(setEntityMetaData, trackEntities, isReadOnly: isReadOnly, pageSize: pageSize)
            .If(isReadOnly, x => Catch<InvalidOperationException>(() => action(x)))
            .Else(x => x.Do(y => y.ReadMemoryManagerUnsafe().AssertNoFragmentation()).Do(action));
    }
}
