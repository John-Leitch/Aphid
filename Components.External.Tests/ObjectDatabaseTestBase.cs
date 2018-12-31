//using static NUnit.Framework.CollectionAssert;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using BinDB = Components.ObjectDatabase.BinaryObjectDatabase<object>;
using static System.IO.File;
using System;

namespace Components.External.Tests
{
    public class ObjectDatabaseTestBase
    {
        private ThreadLocal<ObjectDatabaseTestContext> _context =
            new ThreadLocal<ObjectDatabaseTestContext>(() =>
                new ObjectDatabaseTestContext().Do(x => x.NextDB()));

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
    }
}
