using Components.Aphid.Lexer;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(AphidLexer))]
    public partial class AphidLexerTests
    {
        [PexMethod(MaxConstraintSolverTime = 10, MaxRuns = 10000, ObserveChoices = true, Timeout = 240)]
        public static void TokenizeAll(
            [PexAssumeUnderTest]AphidLexer lexer,
            [PexAssumeUnderTest]string code
        )
        {
            lexer.Text = code;
            lexer.GetAllTokens();

            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, String, Boolean)
        }

        [PexMethod(MaxConstraintSolverTime = 10, MaxRuns = 10000, ObserveChoices = true, Priority = int.MaxValue, ThreadApartmentState = Microsoft.Pex.Framework.Settings.PexApartmentState.MTA, Timeout = 240, MaxRunsWithoutNewTests = 200)]
        public static void Tokenize(
            [PexAssumeUnderTest]AphidLexer lexer,
            [PexAssumeUnderTest]string code
        )
        {
            lexer.Text = code;
            lexer.GetTokens();

            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, String, Boolean)
        }

        [PexMethod(MaxConstraintSolverTime = 10, MaxRuns = 10000, ObserveChoices = true, Priority = int.MaxValue, ThreadApartmentState = Microsoft.Pex.Framework.Settings.PexApartmentState.MTA, Timeout = 240)]
        public static void TokenizeDocument(
            [PexAssumeUnderTest]AphidLexer lexer,
            [PexAssumeUnderTest]string code
        )
        {
            lexer.SetTextMode();
            lexer.Text = code;
            lexer.GetTokens();

            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, String, Boolean)
        }

        [PexMethod(MaxConstraintSolverTime = 10, MaxRuns = 10000, ObserveChoices = true, Priority = int.MaxValue, ThreadApartmentState = Microsoft.Pex.Framework.Settings.PexApartmentState.MTA, Timeout = 240)]
        public static void TokenizeDocumentAll(
            [PexAssumeUnderTest]AphidLexer lexer,
            [PexAssumeUnderTest]string code
        )
        {
            lexer.SetTextMode();
            lexer.Text = code;
            lexer.GetAllTokens();

            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, String, Boolean)
        }

    }
}
