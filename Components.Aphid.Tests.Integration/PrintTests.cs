using Components.Aphid.Tests.Integration.Shared;
using NUnit.Framework;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidPrint"), Parallelizable(ParallelScope.Self)]
    public class PrintTests : AphidTests
    {
        [Test]
        public void TestPrint()
        {
            AssertTrue(@"
                using Components.External.ConsolePlus;
                //tracePrint;
                #'Std';
                #'Meta';
                
                print(null);
                print(null, null);
                print(null, null, null, null, null, null, null, null, null, null, null, null, null, null);

                print();

                print('foo');
                print('{0}');

                print('test format arg == null', this);
                print('Test single format arg == null', null);

                print([  ], 1);
                print([ 'Foo: {0}' ], 1);
                print([ 'Foo: {0}', 'bar: {0}' ], 1);

                print({ x: 10, y: 20 });
                print(this);

                print(1..4);
                print(1..4->@()({ x: 10, y: 20 }));

                print('C: {0}', 1..10);
                print('foo {0} test', 'bar');
                print('foo test', 'bar');
                print('foo {0} test {1} 2 {2} {3} {4}', 'bar', 1, 2, 3, 4);

                exp = ""print('long {0} test {1} 2 {2} {3} {4}', 'bar', 1"" + "", 2, 3, 4"" * 128 + "")"";
                print(exp);
                exp |> evalExp;

                exp = ""print('long {0} test {1} 2 {2} {3} {4}"" + (5..100->@format(""{{{0}}}"") @join(' ')) + ""', 'bar', "" + (5..128->@format(""{0}"") @join(', ')) + "")"";
                print(exp);
                exp |> evalExp;

                null == true |> print;

                ret true;
            ");
        }
    }
}
