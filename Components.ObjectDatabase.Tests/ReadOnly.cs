using NUnit.Framework;
using System.Linq;

namespace Components.ObjectDatabase.Tests
{
    [TestFixture(Category = "ObjectDatabaseReadOnly"), Parallelizable(ParallelScope.All)]
    public partial class ReadOnly : ObjectDatabaseTestBase
    {
        [Test]
        public void TestIsReadOnly(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    pageSize,
                    x => x.Create(Context.NextWidget()));

        [Test]
        public void TestIsReadOnlyWriteMemoryManager(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    pageSize,
                    x => x.WriteMemoryManagerUnsafe(x.ReadMemoryManagerUnsafe()));

        [Test]
        public void TestIsReadOnlyUpdate(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) => DB
            .Do(x => x.Create(Context.NextWidget()))
            .Do(x => CatchReadOnlyFault(
                setEntityMetaData,
                x.TrackEntities = isReadOnly ? trackEntities : true,
                isReadOnly,
                pageSize,
                y => y.Update(y.ReadUnsafe().First())));

        [Test]
        public void TestIsReadOnlyCommitMemoryManager(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [PageSize] int pageSize) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    pageSize,
                    x => x.CommitMemoryManager());
    }
}
