using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    [TestFixture(Category = "AphidLexer"), Parallelizable(ParallelScope.Self)]
    public class LexerTests : AphidTests
    {
        [Test]
        public void NumberTest()
        {
            AssertTokens(
                "0",
                new[] { Token(AphidTokenType.Number, "0") });
        }

        [Test]
        public void NumberTest2()
        {
            AssertTokens(
                "1",
                new[] { Token(AphidTokenType.Number, "1") });
        }

        [Test]
        public void NumberTest3()
        {
            AssertTokens(
                "10",
                new[] { Token(AphidTokenType.Number, "10") });
        }

        [Test]
        public void NumberTest4()
        {
            AssertTokens(
                "0.1",
                new[] { Token(AphidTokenType.Number, "0.1") });
        }

        [Test]
        public void NumberTest5()
        {
            AssertTokens(
                "1.0",
                new[] { Token(AphidTokenType.Number, "1.0") });
        }

        [Test]
        public void NumberTest6()
        {
            AssertTokens(
                "1.00",
                new[] { Token(AphidTokenType.Number, "1.00") });
        }

        [Test]
        public void NumberTest7()
        {
            AssertTokens(
                "1.00.",
                new[] 
                {
                    Token(AphidTokenType.Number, "1.00"),
                    Token(AphidTokenType.MemberOperator),
                });
        }

        [Test]
        public void NumberTest8()
        {
            AssertTokens(
                "1..",
                new[] 
                { 
                    Token(AphidTokenType.Number, "1"),
                    Token(AphidTokenType.RangeOperator)
                });
        }
    }
}
