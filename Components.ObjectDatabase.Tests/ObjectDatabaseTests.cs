using NUnit.Framework;
using System.Linq;
using static NUnit.Framework.Assert;

namespace Components.ObjectDatabase.Tests
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
