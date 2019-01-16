using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        public void TestConcurrentUpdate([Values] bool setEntityMetaData, [PageSize] int pageSize) =>
            TestConcurrency(
                setEntityMetaData,
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
                noFragmentation: pageSize == 0x2000 || pageSize == 0x200000,
                (db, widget, i) =>
                    widget.Do(x => x.Message = $"Async_{i}").Do(db.Update),
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
            var db = DB;
            db.UpdateMemoryManager(x => x.PageSize = pageSize);            
            db.SetEntityMetaData = setEntityMetaData;
            db.TrackEntities = trackEntities;
            db.AssertNoFragmentation();

            void For(Action<int> action) => Parallel.For(0, count, action);
            
            For(i => db.Create(createWidget(i).Do(y => y.X = i)));
            db.IsReadOnly = isReadOnly;

            List<Widget> getRows() => db.ReadUnsafe().Cast<Widget>().ToList();
            var rows = getRows();

            if (concurrentAction != null)
            {
                For(i => concurrentAction(db, rows[i], i));
            }

            finalize?.Invoke(db, getRows());

            AreEqual(count, rows.Distinct(x => x.X).Count());
            AreEqual(count, rows.Count());

            if (checkContains)
            {
                Contains(Widget, rows);
            }

            CollectionAssert.AreEqual(rows, getRows());

            db.ReadMemoryManagerUnsafe()
                .Do(x => AreEqual(count, x.Allocations.Count))
                .DoIf(noFragmentation, x => x.AssertNoFragmentation(), x => x.AssertFragmentation());
        }
    }
}
