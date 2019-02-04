using Components;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static NUnit.Framework.Assert;

namespace Components.ObjectDatabase.Tests
{
    [TestFixture(Category = "ObjectDatabaseUpdate"), Parallelizable(ParallelScope.All)]
    public partial class Update : ObjectDatabaseTestBase
    {
        private readonly string s1 = "Hello world",
            s2 = new string('A', 0x100000);

        private T ReadFirst<T>() => DB.ReadUnsafe().Cast<T>().First();

        private Widget ReadFirstWidget() => ReadFirst<Widget>();

        private void AssertFirstMessage(string message) => AreEqual(message, ReadFirstWidget().Message);

        private void AssertCount(int count)
        {
            AreEqual(count, DB.Count());
            AreEqual(count, DB.ReadUnsafe().Count());
        }

        [Test, ObjectDatabaseSetup]
        public void TestUpdate(
            [Values] bool setEntityMetaData,
            [PageSize] int pageSize)
        {
            DB.TrackEntities = true;
            var x = NextWidget();
            x.Message = s1;
            DB.Create(x);
            AssertFirstMessage(s1);
            AssertCount(1);
            var x2 = ReadFirstWidget();
            x2.Message = s2;
            DB.Update(x2);
            AssertFirstMessage(s2);
            AssertCount(1);
        }

        [Test, ObjectDatabaseSetup]
        public void TestUpdatePositionChange(
            [Values] bool setEntityMetaData,
            [PageSize] int pageSize)
        {
            DB.TrackEntities = true;
            //DB.UpdateMemoryManager(x => x.PageSize = pageSize);
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

        [Test, ObjectDatabaseSetup]
        public void TestUpdateMixed(
            [Values] bool setEntityMetaData,
            [PageSize] int pageSize)
        {
            DB.TrackEntities = true;
            var x = new List<string>();
            DB.Create(x);
            AssertCount(1);
            x = ReadFirst<List<string>>();
            AreEqual(0, x.Count);
            x.Add(s1);
            DB.Update(x);
            AssertCount(1);
            x = ReadFirst<List<string>>();
            AreEqual(1, x.Count);
            DB.Create(s1);
            AssertCount(2);
            DB.Create(s2);
            AssertCount(3);
            CollectionAssert.AreEqual(new string[] { s1, s2 }, DB.ReadUnsafe().OfType<string>());
            x = new List<string>();
            x.Add("foo");
            x.Add("bar");
            DB.Create(x);
            var lists = DB.ReadUnsafe().OfType<List<string>>();
            AreEqual(2, lists.Count());
            AreEqual(1, lists.First().Count());
            AreEqual(2, lists.Last().Count());
        }
    }
}
