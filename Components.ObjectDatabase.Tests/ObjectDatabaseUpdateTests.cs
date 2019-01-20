using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;
using static NUnit.Framework.Assert;

namespace Components.ObjectDatabase.Tests
{
    [TestFixture(Category = "ObjectDatabaseUpdate"), Parallelizable(ParallelScope.All)]
    public partial class ObjectDatabaseUpdateTests : ObjectDatabaseTestBase
    {
        [Test, ObjectDatabaseSetup]
        public void TestUpdatePositionChange(
            [Values] bool setEntityMetaData,
            [PageSize] int pageSize)
        {
            DB.TrackEntities = true;
            var first = NextWidget();
            DB.Create(first);
            DB.Create(NextWidget());
            long[] readOffsets() => DB.ReadUnsafe().Cast<Widget>().Select(x => x.Offset).ToArray();

            var offsets = readOffsets();
            Debug.Write(offsets.Length);
            AreEqual(2, offsets.Length);

            if (setEntityMetaData)
            {
                AreEqual(0, offsets[0]);
                AreNotEqual(0, offsets[1]);
            }

            Widget readFirst() => DB.ReadUnsafe().OfType<Widget>().First();
            var widget = readFirst();
            widget.Message = new string('A', 0x200000);
            DB.Update(widget);

            var offsets2 = readOffsets();
            AreEqual(offsets2.Length, 2);

            if (setEntityMetaData)
            {
                AreNotEqual(0, offsets2[0]);
                AreNotEqual(0, offsets2[1]);
                AreNotEqual(offsets[0], offsets2[0]);
                AreNotEqual(offsets[1], offsets2[0]);
            }

            var updated = readFirst();

            if (setEntityMetaData)
            {
                AreNotEqual(first.Offset, updated.Offset);
                AreEqual(widget.Offset, updated.Offset);
            }

            AreNotEqual(first.Message, updated.Message);
            AreEqual(widget.Message, updated.Message);
        }



        //public void RunTest(
        //    bool setEntityMetaData,
        //    bool trackEntities,
        //    bool isReadOnly,
        //    int pageSize) =>
        //    DB
        //        .Set(setEntityMetaData, trackEntities, false, pageSize)
        //        .Do(x => x.Create(Context.NextWidget()))
        //        .Do(x => x.IsReadOnly = isReadOnly)
        //        .Do(x => x.ReadUnsafe().For(y => AreEqual(Widget, y)))
        //        .Do(x => x.AssertNoFragmentation());
    }
}
