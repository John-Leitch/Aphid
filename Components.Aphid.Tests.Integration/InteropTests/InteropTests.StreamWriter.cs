using Components.Aphid.Tests.Integration.Shared;
using Components.Aphid.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Tests.Integration
{
    public partial class InteropTests
    {
        [Test]
        public void StreamWriterTest()
        {
            Assert9(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('*********');
                w.Flush();
                
                ret s.Position;
            ");
        }

        [Test]
        public void StreamWriterTest2()
        {
            Assert9(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('****************');
                w.Flush();
                s.Position = 9;

                ret s.Position;
            ");
        }

        [Test]
        public void StreamWriterTest3()
        {
            Assert9(@"
                using System;
                using System.IO;

                w = new StreamWriter(new MemoryStream());
                w.Write('****************');
                w.Flush();
                w.BaseStream.Position = 9;

                ret w.BaseStream.Position;
            ");
        }

        [Test]
        public void StreamWriterTest4()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                w.Write('foo');
                w.Flush();
                Console.WriteLine('Stream position: {0}', s.Position);
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                Console.WriteLine('Value: {0}', v);

                ret v;
            ");
        }

        [Test]
        public void StreamWriterPartialVarCallTest()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                f = @w.Write('f{0}');
                f('oo');
                w.Flush();
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                
                ret v;
            ");
        }

        [Test]
        public void StreamWriterPartialPipelineTest()
        {
            AssertFoo(@"
                using System;
                using System.IO;

                s = new MemoryStream();
                w = new StreamWriter(s);
                'oo' @w.Write('f{0}');
                w.Flush();
                s.Position = 0;
                r = new StreamReader(s);
                v = r.ReadToEnd();
                
                ret v;
            ");
        }
    }
}
