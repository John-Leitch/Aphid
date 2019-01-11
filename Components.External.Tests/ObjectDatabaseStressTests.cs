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
    [TestFixture(Category = "ObjectDatabaseStressTest"),
        Parallelizable(ParallelScope.None),
        Explicit("High memory usage")]
    public partial class ObjectDatabaseStressTests : ObjectDatabaseTestBase
    {
        private readonly string _message = new string('A', 100 * 0x100000);

        [Test]
        public void TestCreateReadManyStressTest(
            [Values] bool setEntityMetaData,
            [Values] bool trackEntities,
            [Values] bool isReadOnly,
            [Values(0x2000, 0x200000)] int pageSize) =>
            TestCreateReadManyUniqueCore(
                setEntityMetaData,
                trackEntities,
                isReadOnly,
                pageSize,
                i =>
                {
                    var p = Context.NextWidget();
                    var w = Context.NextWidget();
                    w.Message = string.Intern(_message);
                    w.Parent = p;

                    return w;
                },
                count: 26,
                performEqualityChecks: false);

        
    }
}
