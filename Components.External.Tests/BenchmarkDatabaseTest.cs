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
                x => x.ReadUnsafe().First().Do(NotNull).Do(y =>
                y.ToString()));


        //[Test]
        //public void TestCreateRead()
        //{
        //    DB.Create(Context.NextWidget());
        //    var rows = DB.ReadUnsafe();
        //    AreEqual(Widget, rows.First());
        //    AreEqual(Widget, rows.Last());
        //    DB.AssertNoFragmentation();
        //}

        //[Test]
        //public void TestCreateReadManyUnique(
        //    [Values] bool setEntityMetaData,
        //    [Values] bool trackEntities,
        //    [Values] bool isReadOnly) =>
        //    TestCreateReadManyUniqueCore(
        //        setEntityMetaData,
        //        trackEntities,
        //        isReadOnly,
        //        i =>
        //        {
        //            var w = Context.NextWidget();
        //            w.X += i;

        //            return w;
        //        });

        //[Test]
        //public void TestCreateReadManyUniqueVarLen(
        //    [Values] bool setEntityMetaData,
        //    [Values] bool trackEntities,
        //    [Values] bool isReadOnly) =>
        //    TestCreateReadManyUniqueCore(
        //        setEntityMetaData,
        //        trackEntities,
        //        isReadOnly,
        //        i =>
        //        {
        //            var w = Context.NextWidget();
        //            w.Message = new string('A', i * 10);

        //            return w;
        //        });

        //[Test]
        //public void TestCreateReadManyUniqueVarLenWithParent(
        //    [Values] bool setEntityMetaData,
        //    [Values] bool trackEntities,
        //    [Values] bool isReadOnly) =>
        //    TestCreateReadManyUniqueCore(
        //        setEntityMetaData,
        //        trackEntities,
        //        isReadOnly,
        //        i =>
        //        {
        //            var p = Context.NextWidget();
        //            var w = Context.NextWidget();
        //            w.Message = new string('A', i * 10);
        //            w.Parent = p;

        //            return w;
        //        });

        //public void TestCreateReadManyUniqueCore(
        //    bool setEntityMetaData,
        //    bool trackEntities,
        //    bool isReadOnly,
        //    Func<int, Widget> createWidget)
        //{
        //    DB.SetEntityMetaData = setEntityMetaData;
        //    DB.TrackEntities = trackEntities;            
        //    DB.AssertNoFragmentation();
        //    var count = 0x10;

        //    for (var i = 0; i < count; i++)
        //    {
        //        DB.Create(createWidget(i));
        //    }

        //    DB.IsReadOnly = isReadOnly;
        //    var rows = DB.ReadUnsafe();
        //    AreNotEqual(Widget, rows.First());
        //    AreEqual(Widget, rows.Last());
        //    AreEqual(count, rows.Count());

        //    DB.ReadMemoryManagerUnsafe()
        //        .Do(x => AreEqual(count, x.Allocations.Count))
        //        .Do(x => x.AssertNoFragmentation());
        //}
    }
}
