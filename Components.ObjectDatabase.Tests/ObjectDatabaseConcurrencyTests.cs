using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static NUnit.Framework.Assert;
using BinDB = Components.ObjectDatabase.ObjectDatabase<object>;

namespace Components.ObjectDatabase.Tests
{
    [TestFixture(Category = "ObjectDatabaseConcurrency"), Parallelizable(ParallelScope.All)]
    public partial class ObjectDatabaseConcurrencyTests : ObjectDatabaseTestBase
    {
        [Test]
        public void TestConcurrentCreateReadManyUnique(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestConcurrency(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                pageSize,
                i =>
                {
                    var w = Context.NextWidget();
                    w.X += i;

                    return w;
                });

        [Test]
        public void TestConcurrentCreateReadManyUniqueVarLen(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestConcurrency(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                pageSize,
                i =>
                {
                    var w = Context.NextWidget();
                    w.Message = new string('A', i * 10);

                    return w;
                });

        [Test]
        public void TestConcurrentCreateReadManyUniqueVarLenWithParent(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestConcurrency(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                pageSize,
                i =>
                {
                    var p = Context.NextWidget();
                    var w = Context.NextWidget();
                    w.Message = new string('A', i * 10);
                    w.Parent = p;

                    return w;
                });

        [Test]
        public void TestConcurrentUpdate([PageSize] int pageSize) =>
            TestConcurrency(
                true,
                true,
                false,
                pageSize,
                i =>
                {
                    var w = Context.NextWidget();
                    w.X += i;

                    return w;
                },
                checkContains: false,
                noFragmentation: pageSize == 0x100 || pageSize == 0x2000 || pageSize == 0x200000,
                (db, widget, i) => widget
                    .Do(x => x.Message = $"Async_{i}")
                    .Do(x => x.Context.As<BinDB>(y => y.Update(x))),
                (db, widgets) =>
                    AreEqual(db.Count(), widgets.Distinct(x => x.Message).Count()));

        protected void TestConcurrency(
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            int pageSize,
            Func<int, Widget> createWidget,
            bool checkContains = true,
            bool noFragmentation = true,
            Action<BinDB, Widget, int> concurrentAction = null,
            Action<BinDB, List<Widget>> finalize = null,
            int count = 0x100)
        {
            var dbFile = Context.NextDBName();

            BinDB nextDb() => BinaryObjectDatabase
                .OpenFile(dbFile)
                .Set(setEntityMetaData, trackEntities, false, pageSize)
                .Do(x => x.AssertNoFragmentation());

            var dbs = Enumerable.Range(0, 8).Select(x => nextDb()).ToArray();

            try
            {
                BinDB getDB() => dbs.TakeRandom();

                void For(Action<int> action) => Parallel.For(0, count, action);

                For(i => getDB().Create(createWidget(i).Do(y => y.X = i)));
                dbs.For(x => x.IsReadOnly = isReadOnly);

                List<Widget> getRows() => getDB().ReadUnsafe().Cast<Widget>().ToList();
                var rows = getRows();

                if (concurrentAction != null)
                {
                    For(i => concurrentAction(getDB(), rows[i], i));
                }

                finalize?.Invoke(getDB(), getRows());

                AreEqual(count, rows.Distinct(x => x.X).Count());
                AreEqual(count, rows.Count());

                if (checkContains)
                {
                    Contains(Widget, rows);
                }

                var rows2 = getRows().OrderBy(x => x.Message).ToList();
                var rows3 = getRows().OrderBy(x => x.Message).ToList();
                CollectionAssert.AreEqual(rows2, rows3);

                getDB().ReadMemoryManagerUnsafe()
                    .Do(x => AreEqual(count, x.Allocations.Count))
                    .DoIf(noFragmentation, x => x.AssertNoFragmentation(), x => x.AssertFragmentation());
            }
            finally
            {
                dbs.For(x => x.Dispose());
                File.Delete(dbFile);
                File.Delete(Path.ChangeExtension(dbFile, "odm"));
            }
        }
    }
}
