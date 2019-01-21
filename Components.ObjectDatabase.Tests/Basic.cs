using NUnit.Framework;
using System;
using System.Linq;
using static NUnit.Framework.Assert;

namespace Components.ObjectDatabase.Tests
{
    [TestFixture(Category = "ObjectDatabase"), Parallelizable(ParallelScope.All)]
    public partial class Basic : ObjectDatabaseTestBase
    {
        [Test]
        public void TestWidgetHashCode() => NotZero(Context.NextWidget().GetHashCode());

        [Test]
        public void TestOpen(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) => DB
            .Set(setEntityMetaData, trackEntities, isReadOnly, pageSize)
            .Do(x => IsTrue(x.IsOpened));

        [Test]
        public void TestClosed(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) => DB
            .Set(setEntityMetaData, trackEntities, isReadOnly, pageSize)
            .Do(x => x.Dispose())
            .Do(x => IsFalse(x.IsOpened));

        [Test]
        public void TestCreate(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) => DB
            .Set(setEntityMetaData, trackEntities, isReadOnly, pageSize)
            .Do(x =>
                new Action(() => x.Create(Context.NextWidget()))
                .DoIf(isReadOnly, y => Catch(() => y()), y => y()));

        [Test]
        public void TestCreateRead(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            DB
                .Set(setEntityMetaData, trackEntities, false, pageSize)
                .Do(x => x.Create(Context.NextWidget()))
                .Do(x => x.IsReadOnly = isReadOnly)
                .Do(x => x.ReadUnsafe().For(y => AreEqual(Widget, y)))
                .Do(x => x.AssertNoFragmentation());

        [Test]
        public void TestCreateReadManyUnique(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestCreateReadManyUniqueCore(
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
        public void TestCreateReadManyUniqueVarLen(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestCreateReadManyUniqueCore(
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
        public void TestCreateReadManyUniqueVarLenWithParent(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
            TestCreateReadManyUniqueCore(
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
        
    }
}
