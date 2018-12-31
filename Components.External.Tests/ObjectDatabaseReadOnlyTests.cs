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
    [TestFixture(Category = "ObjectDatabaseReadOnly"), Parallelizable(ParallelScope.All)]
    public partial class ObjectDatabaseReadOnlyTests : ObjectDatabaseTestBase
    {
        [Test]
        public void TestIsReadOnly(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    x => x.Create(Context.NextWidget()));

        [Test]
        public void TestIsReadOnlyWriteMemoryManager(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    x => x.WriteMemoryManagerUnsafe(x.ReadMemoryManagerUnsafe()));

        [Test]
        public void TestIsReadOnlyUpdate(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) => DB
            .Do(x => x.Create(Context.NextWidget()))
            .Do(x => CatchReadOnlyFault(
                setEntityMetaData,
                x.TrackEntities = isReadOnly ? trackEntities : true,
                isReadOnly,
                y => y.Update(y.ReadUnsafe().First())));

        [Test]
        public void TestIsReadOnlyCommitMemoryManager(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
                CatchReadOnlyFault(
                    setEntityMetaData,
                    trackEntities,
                    isReadOnly,
                    x => x.CommitMemoryManager());

        private void CatchReadOnlyFault(
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            Action<BinDB> action) => DB
            .Set(setEntityMetaData, trackEntities, isReadOnly: isReadOnly)
            .If(isReadOnly, x => Catch<InvalidOperationException>(() => action(x)))
            .Else(x => x.Do(y => y.ReadMemoryManagerUnsafe().AssertNoFragmentation()).Do(action));
    }
}
