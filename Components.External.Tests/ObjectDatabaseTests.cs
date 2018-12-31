using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static NUnit.Framework.Assert;
using System.Threading;
using Components.IO;
using static System.IO.File;
using System;
using BinDB = Components.ObjectDatabase.ObjectDatabase<object>;

namespace Components.External.Tests
{
    [TestFixture(Category = "ObjectDatabase"), Parallelizable(ParallelScope.All)]
    public partial class ObjectDatabaseTests : ObjectDatabaseTestBase
    {
        [Test]
        public void TestWidgetHashCode() => NotZero(Context.NextWidget().GetHashCode());

        [Test]
        public void TestOpen() => IsTrue(DB.IsOpened);

        [Test]
        public void TestCreate() => DB.Create(Context.NextWidget());

        [Test]
        public void TestCreateRead()
        {
            DB.Create(Context.NextWidget());
            var rows = DB.ReadUnsafe();
            AreEqual(Widget, rows.First());
            AreEqual(Widget, rows.Last());
            DB.AssertNoFragmentation();
        }

        [Test]
        public void TestCreateReadManyUnique(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestCreateReadManyUniqueCore(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                i =>
                {
                    var w = Context.NextWidget();
                    w.X += i;

                    return w;
                });

        [Test]
        public void TestCreateReadManyUniqueVarLen(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestCreateReadManyUniqueCore(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                i =>
                {
                    var w = Context.NextWidget();
                    w.Message = new string('A', i * 10);

                    return w;
                });

        [Test]
        public void TestCreateReadManyUniqueVarLenWithParent(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestCreateReadManyUniqueCore(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                i =>
                {
                    var p = Context.NextWidget();
                    var w = Context.NextWidget();
                    w.Message = new string('A', i * 10);
                    w.Parent = p;

                    return w;
                });

        public void TestCreateReadManyUniqueCore(
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            Func<int, Widget> createWidget)
        {
            DB.SetEntityMetaData = setEntityMetaData;
            DB.TrackEntities = trackEntities;            
            DB.AssertNoFragmentation();
            var count = 0x10;

            for (var i = 0; i < count; i++)
            {
                DB.Create(createWidget(i));
            }

            DB.IsReadOnly = isReadOnly;
            var rows = DB.ReadUnsafe();
            AreNotEqual(Widget, rows.First());
            AreEqual(Widget, rows.Last());
            AreEqual(count, rows.Count());

            DB.ReadMemoryManagerUnsafe()
                .Do(x => AreEqual(count, x.Allocations.Count))
                .Do(x => x.AssertNoFragmentation());
        }
    }
}
