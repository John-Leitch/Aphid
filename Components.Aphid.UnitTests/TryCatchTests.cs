using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidTryCatch"), Parallelizable(ParallelScope.All)]
    public class TryCatchTests : AphidTests
    {
        [Test]
        public void TryCatchNoFaultTest() =>
            Assert9(@"
                try {
                    1/1;                    
                } catch (err) {
                    ret 0;
                }

                ret 9;
            ");

        [Test]
        public void TryCatchReturnFromTryBlockTest() =>
            Assert9(@"
                try {
                    1/1;                    
                    ret 9;
                } catch (err) {
                    ret 0;
                }

                ret 0;                
            ");

        [Test]
        public void TryCatchReturnFromCatchBlockTest() =>
            Assert9(@"
                try {
                    1/0;
                } catch (err) {
                    ret 9;
                }

                ret 0;                
            ");

        [Test]
        public void TryCatchReturnFromArgFreeCatchBlockTest() =>
            Assert9(@"
                try {
                    1/0;
                } catch {
                    ret 9;
                }

                ret 0;                
            ");

        [Test]
        public void TryCatchDivideByZeroMessageTest() =>
            AssertTrue(@"
                try {
                    1/0;
                } catch(e) {
                    ret e.message.Contains('divide by');
                }

                ret 0;                
            ");

        [Test]
        public void TryCatchExceptionStackTraceNameTest() =>
            AssertTrue(@"
                var foo = @() 1/0;

                try {
                    foo();
                } catch(e) {
                    ret e.stack.Contains('foo');
                }

                ret false;                
            ");

        [Test]
        public void TryCatchExceptionStackTraceMultiNameTest() =>
            AssertTrue(@"
                var foo = @() 1/0;
                var bar = @() foo();

                try {
                    bar();
                } catch(e) {
                    ret e.stack.Contains('foo') && e.stack.Contains('bar');
                }

                ret false;                
            ");

        [Test]
        public void TryCatchExceptionStackTraceStaleNameTest() =>
            AssertTrue(@"
                var stale = @() 1/1;
                var foo = @() 1/0;
                var bar = @{
                    stale();
                    foo();
                };

                try {
                    bar();
                } catch(e) {
                    ret e.stack.Contains('foo') &&
                        e.stack.Contains('bar') &&
                        !e.stack.Contains('stale');
                }

                ret false;
            ");

        [Test]
        public void TryCatchNestingExceptionStackTraceStaleNameTest() =>
            AssertTrue(@"
                #'meta';
                var stale = @() 1/1;
                var foo = @() 1/0;
                var bar = @{
                    stale();
                    foo();
                };

                var success = false;

                try {
                    try {
                        bar();
                    } catch(e) {
                        success =
                            e.stack.Contains('foo') &&
                            e.stack.Contains('bar') &&
                            !e.stack.Contains('stale');
                    }
                } catch(e) {
                    success =
                        success &&
                        !e.stack.Contains('foo') &&
                        !e.stack.Contains('bar') &&
                        !e.stack.Contains('stale');
                }

                success = success && frames().Length == 1;

                ret success;
            ");
    }
}
