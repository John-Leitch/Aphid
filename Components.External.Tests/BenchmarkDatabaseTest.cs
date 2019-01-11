using Components;
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
using System.Reflection;
using Components.Aphid.Parser;
using Components.ObjectDatabase;

namespace Components.External.Tests
{
    [TestFixture(Category = "BenchmarkDatabase"), Parallelizable(ParallelScope.All)]
    public partial class BenchmarkDatabaseTest : ObjectDatabaseTestBase
    {
        private string _dbFile = PathHelper.GetExecutingPath("Databases\\history.db");

        private Assembly Resolve(object sender, ResolveEventArgs args) =>
            args.Name.StartsWith("Components.Aphid") ? typeof(AphidExpression).Assembly : null;

        [OneTimeSetUp]
        public void SetupAppDomain() => AppDomain.CurrentDomain.AssemblyResolve += Resolve;

        [OneTimeTearDown]
        public void TearDownAppDomain() => AppDomain.CurrentDomain.AssemblyResolve -= Resolve;

        private BinDB TestBenchmarkDB(
            bool useUnsafeMemoryManager,
            bool setEntityMetaData,
            bool trackEntities,
            bool isReadOnly,
            Action<BinDB> action) =>
            BinaryObjectDatabase
                .OpenFile(_dbFile, useUnsafeMemoryManager)
                .Set(setEntityMetaData, trackEntities, isReadOnly)
                .Do(action);

        [Test]
        public void TestOpenBenchmarkDB(
            [Values] bool useUnsafeMemoryManager,
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestBenchmarkDB(useUnsafeMemoryManager, setEntityMetaData, trackEntities, isReadOnly, x => { });

        [Test]
        public void TestReadFirstBenchmarkDB(
            [Values] bool useUnsafeMemoryManager,
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestBenchmarkDB(
                useUnsafeMemoryManager,
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                x => x.ReadUnsafe().First().Do(NotNull).Do(y => y.ToString()));

        [Test]
        public void TestReadCountBenchmarkDB(
            [Values] bool useUnsafeMemoryManager,
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly) =>
            TestBenchmarkDB(
                useUnsafeMemoryManager,
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                x => x.ReadUnsafe().Count().Do(y => AreEqual(y, x.Count())));

        [Test]
        public void TestSkipCountBenchmarkDB(
            [Values] bool useUnsafeMemoryManager,
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [Values(0, 1, 10, 1000000)] int skip) =>
            TestBenchmarkDB(
                useUnsafeMemoryManager,
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                x => x.SkipUnsafe(skip).Count().Do(y => AreEqual(y, Max(0, x.Count() - skip))));
    }
}
