using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration
{
    public class AphidTests
    {
        protected virtual bool LoadStd { get { return false; } }

        protected virtual bool LoadReflection { get { return false; } }

        protected virtual string PrefixScript(string script)
        {
            var includes = "";

            if (LoadStd)
            {
                includes += "#'Std'; ";
            }

            if (LoadReflection)
            {
                includes += "#'Reflection'; ";
            }

            return includes + script;
        }

        private AphidObject Execute(string script)
        {
            script = PrefixScript(script);

            var interpreter = new AphidInterpreter();
            interpreter.Loader.SearchPaths.Add(Path.Combine(Environment.CurrentDirectory, "Library"));
            interpreter.Interpret(script);
            return interpreter.GetReturnValue();
        }

        protected List<AphidToken> GetTokens(string script)
        {
            return new AphidLexer(script).GetAllTokens();
        }

        protected void AssertTokens(string script, AphidToken[] tokens)
        {
            var tokens2 = GetTokens(script);
            Assert.AreEqual(tokens.Length, tokens2.Count);

            for (int i = 0; i < tokens.Length; i++)
            {
                Assert.AreEqual(tokens[i].TokenType, tokens2[i].TokenType);

                if (tokens[i].Lexeme != null)
                {
                    Assert.AreEqual(tokens[i].Lexeme, tokens2[i].Lexeme);
                }
            }
        }

        protected AphidToken Token(AphidTokenType type, string lexeme)
        {
            return new AphidToken(type, lexeme, 0);
        }

        protected AphidToken Token(AphidTokenType type)
        {
            return Token(type, null);
        }

        protected void AssertEquals(object expected, string script)
        {
            Assert.AreEqual(expected, Execute(script).Value);
        }

        protected void AssertFoo(string script)
        {
            AssertEquals("foo", script);
        }

        protected void Assert9(string script)
        {
            AssertEquals(9m, script);
        }

        protected void AssertTrue(string script)
        {
            AssertEquals(true, script);
        }

        protected void AssertFalse(string script)
        {
            AssertEquals(false, script);
        }

        private string CreateStatement(string expression)
        {
            return string.Format("ret {0};", expression);
        }

        protected void AssertExpEquals(object expected, string expression)
        {
            AssertEquals(expected, CreateStatement(expression));
        }

        protected void AssertExpFoo(string expression)
        {
            AssertFoo(CreateStatement(expression));
        }

        protected void AssertExp9(string expression)
        {
            Assert9(CreateStatement(expression));
        }

        protected void AssertExpTrue(string expression)
        {
            AssertTrue(CreateStatement(expression));
        }

        protected void AssertExpFalse(string expression)
        {
            AssertFalse(CreateStatement(expression));
        }
    }
}
