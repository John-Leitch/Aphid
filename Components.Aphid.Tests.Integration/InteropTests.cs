using NUnit.Framework;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidInterop")]
    public class InteropTests : AphidTests
    {
        [Test]
        public void StaticTest1()
        {
            AssertExp9("%%System.Math.Sqrt(81)");
        }

        [Test]
        public void StaticTest2()
        {
            Assert9(@"
                %%import System;
                ret %%Math.Sqrt(81);
            ");
        }

        [Test, Ignore("Will be fixed when params is supported.")]
        public void StaticArgTest1()
        {
            AssertExpFoo("%%System.String.Format('foo')");
        }

        [Test]
        public void StaticArgTest2()
        {
            AssertExpFoo("%%System.String.Format('f{0}o', 'o')");
        }

        [Test]
        public void StaticArgTest3()
        {
            AssertExpFoo("%%System.String.Format('{0}o{1}', 'f', 'o')");
        }

        [Test]
        public void StaticArgTest4()
        {
            AssertFoo(@"
                x = 'f';
                y = 'o';
                ret %%System.String.Format('{0}o{1}', x, y);
            ");
        }

        [Test]
        public void StaticArgTest5()
        {
            AssertFoo(@"
                %%import System;
                x=['f','o'];
                ret %%String.Format('{0}o{1}', x[0], x[1]);
            ");
        }

        [Test]
        public void StaticArgTest6()
        {
            AssertFoo(@"
                x=['f','o'];
                ret %%string.Format('{0}o{1}', x[0], x[1]);
            ");
        }

        [Test]
        public void InstanceTest1()
        {
            Assert9(@"
                %%import System;
                %%import System.IO;

                s = %%new MemoryStream();
                w = %%new StreamWriter(s);
                w.Write('*********');
                w.Flush();
                
                ret s.Position;
            ");
        }

        [Test]
        public void InstanceTest2()
        {
            Assert9(@"
                %%import System;
                %%import System.IO;

                s = %%new MemoryStream();
                w = %%new StreamWriter(s);
                w.Write('****************');
                w.Flush();
                s.Position = 9;

                ret s.Position;
            ");
        }

        [Test]
        public void InstanceTest3()
        {
            Assert9(@"
                %%import System;
                %%import System.IO;

                w = %%new StreamWriter(%%new MemoryStream());
                w.Write('****************');
                w.Flush();
                w.BaseStream.Position = 9;

                ret w.BaseStream.Position;
            ");
        }

        [Test]
        public void InstanceTest4()
        {
            AssertFoo(@"
                %%import System;
                %%import System.IO;

                s = %%new MemoryStream();
                w = %%new StreamWriter(s);
                w.Write('foo');
                w.Flush();
                %%Console.WriteLine('Stream position: {0}', s.Position);
                s.Position = 0;
                r = %%new StreamReader(s);
                v = r.ReadToEnd();
                %%Console.WriteLine('Value: {0}', v);

                ret v;
            ");
        }

        [Test]
        public void GenericTest1()
        {
            Assert9(@"
                %%import System.Linq;

                ret %%Enumerable.Range(0, 9) %%Enumerable.Count;
            ");
        }

        [Test]
        public void GenericTest2()
        {
            Assert9(@"
                %%import System.Linq;

                ret %%Enumerable.Range(0, 10) %%Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest3()
        {
            AssertFoo(@"
                %%import System.Linq;

                ret [ 'foo', 'bar', 'a', 'b' ] %%Enumerable.First;
            ");
        }


        [Test]
        public void GenericTest4()
        {
            AssertFoo(@"
                %%import System.Linq;

                ret [ 'bar', 'a', 'b', 'foo' ] %%Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest5()
        {
            AssertFoo(@"
                %%import System.Linq;
                
                ret %%Enumerable.Skip([ 'bar', 'a', 'foo', 'b' ], 2)
                    %%Enumerable.First;
            ");
        }

        [Test]
        public void GenericTest6()
        {
            AssertFoo(@"
                %%import System.Linq;
                
                ret %%Enumerable.Take([ 'bar', 'a', 'foo', 'b' ], 3)
                    %%Enumerable.Last;
            ");
        }

        [Test]
        public void GenericTest7()
        {
            Assert9(@"
                %%import System.Linq;
                
                ret %%Enumerable.Skip([ 0, 1, 9, 10 ], 2)
                    %%Enumerable.First;
            ");
        }

        [Test]
        public void GenericTest8()
        {
            Assert9(@"
                %%import System.Linq;
                
                ret %%Enumerable.Take([ 0, 1, 9, 10 ], 3)
                    %%Enumerable.Last;
            ");
        }
    }
}
