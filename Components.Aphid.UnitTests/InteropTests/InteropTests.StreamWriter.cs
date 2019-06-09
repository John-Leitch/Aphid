using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    public partial class InteropTests
    {
        [Test]
        public void StreamWriterTest() =>
            Assert9(@"
                using System;
                using System.IO;

                var s = new MemoryStream();
                var w = new StreamWriter(s);
                w.Write('*********');
                w.Flush();
                
                ret s.Position;
            ");

        [Test]
        public void StreamWriterTest2() =>
            Assert9(@"
                using System;
                using System.IO;

                var s = new MemoryStream();
                var w = new StreamWriter(s);
                w.Write('****************');
                w.Flush();
                s.Position = 9;

                ret s.Position;
            ");

        [Test]
        public void StreamWriterTest3() =>
            Assert9(@"
                using System;
                using System.IO;

                var w = new StreamWriter(new MemoryStream());
                w.Write('****************');
                w.Flush();
                w.BaseStream.Position = 9;

                ret w.BaseStream.Position;
            ");

        [Test]
        public void StreamWriterTest4() =>
            AssertFoo(@"
                using System;
                using System.IO;

                var s = new MemoryStream();
                var w = new StreamWriter(s);
                w.Write('foo');
                w.Flush();
                Console.WriteLine('Stream position: {0}', s.Position);
                s.Position = 0;
                var r = new StreamReader(s);
                var v = r.ReadToEnd();
                Console.WriteLine('Value: {0}', v);

                ret v;
            ");

        [Test]
        public void StreamWriterPartialVarCallTest() =>
            AssertFoo(@"
                using System;
                using System.IO;

                var s = new MemoryStream();
                var w = new StreamWriter(s);
                var f = @w.Write('f{0}');
                f('oo');
                w.Flush();
                s.Position = 0;
                var r = new StreamReader(s);
                var v = r.ReadToEnd();
                
                ret v;
            ");

        [Test]
        public void StreamWriterPartialPipelineTest() =>
            AssertFoo(@"
                using System;
                using System.IO;

                var s = new MemoryStream();
                var w = new StreamWriter(s);
                'oo' @w.Write('f{0}');
                w.Flush();
                s.Position = 0;
                var r = new StreamReader(s);
                var v = r.ReadToEnd();
                
                ret v;
            ");
    }
}
