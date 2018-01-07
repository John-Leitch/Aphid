using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidTryCatch")]
    public class TryCatchTests : AphidTests
    {
        [Test]
        public void TryCatch()
        {
            Assert9(@"
                try {
                    1/1;                    
                } catch (err) {
                    ret 0;
                }

                ret 9;
            ");
        }

        [Test]
        public void TryCatch2()
        {
            Assert9(@"
                try {
                    1/1;                    
                    ret 9;
                } catch (err) {
                    ret 0;
                }

                ret 0;                
            ");
        }

        [Test]
        public void TryCatch3()
        {
            Assert9(@"
                try {
                    1/0;
                } catch (err) {
                    ret 9;
                }

                ret 0;                
            ");
        }

        [Test]
        public void TryCatch4()
        {
            Assert9(@"
                try {
                    1/0;
                } catch {
                    ret 9;
                }

                ret 0;                
            ");
        }

        [Test]
        public void TryCatchMessageTest()
        {
            AssertTrue(@"
                try {
                    1/0;
                } catch(e) {
                    ret e.message.Contains('divide by');
                }

                ret 0;                
            ");
        }

        [Test]
        public void TryCatchStackTest()
        {
            AssertTrue(@"
                foo = @() 1/0;

                try {
                    foo();
                } catch(e) {
                    ret e.stack.Contains('foo');
                }

                ret false;                
            ");
        }

        [Test]
        public void TryCatchStackTest2()
        {
            AssertTrue(@"
                foo = @() 1/0;
                bar = @() foo();

                try {
                    bar();
                } catch(e) {
                    ret e.stack.Contains('foo') && e.stack.Contains('bar');
                }

                ret false;                
            ");
        }
    }
}
