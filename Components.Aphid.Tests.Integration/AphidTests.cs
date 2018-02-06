using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Dynamic;
using Components.Aphid.Parser;

namespace Components.Aphid.Tests.Integration
{
    [Parallelizable(ParallelScope.All)]
    public class AphidTests : DynamicObject
    {
        private static object _cachedStdNodesSync = new object();

        private static string _cachedStdFilename;

        private static string _cachedStdText;

        private static List<AphidExpression> _cachedStdNodes;

        private static AphidExpression _cachedUsing = new UnaryOperatorExpression(
            AphidTokenType.usingKeyword,
            new IdentifierExpression("System"));

        private static List<AphidExpression> _cachedUsingBlock = new List<AphidExpression>
        {
            new UnaryOperatorExpression(
                AphidTokenType.usingKeyword,
                new IdentifierExpression("System"))
        };

        private static List<AphidExpression> _cachedUsingIncludeBlock = new List<AphidExpression>
        {
            new UnaryOperatorExpression(
                AphidTokenType.usingKeyword,
                new IdentifierExpression("System")),
            new UnaryOperatorExpression(
                AphidTokenType.LoadScriptOperator,
                new StringExpression("'Std.alx'")),
        };

        protected virtual bool LoadStd { get { return false; } }

        protected virtual List<AphidExpression> ParseScript(AphidInterpreter interpreter, string script)
        {
            List<AphidExpression> initNodes = null;
            
            if (LoadStd)
            {
                lock (_cachedStdNodesSync)
                {
                    if (_cachedStdNodes == null)
                    {
                        var stdFile = interpreter.Loader.FindScriptFile(null, "Std.alx");
                        _cachedStdNodes = PreprocessAst(AphidParser.ParseFile(stdFile));
                        _cachedStdNodes.Add(_cachedUsing);
                    }

                    initNodes = _cachedStdNodes;
                }
            }
            else
            {
                initNodes = _cachedUsingBlock;
            }

            return initNodes.Concat(PreprocessAst(AphidParser.Parse(script))).ToList();
        }

        private List<AphidExpression> PreprocessAst(List<AphidExpression> ast)
        {
            var stage1 = new PartialOperatorMutator().MutateRecursively(ast);
            var stage2 = new AphidMacroMutator().MutateRecursively(stage1);
            var stage3 = new AphidIdDirectiveMutator().MutateRecursively(stage2);

            return stage3;
        }

        private AphidObject Execute(string script)
        {
            var interpreter = new AphidInterpreter();
            interpreter.Loader.SearchPaths.Add(Path.Combine(Environment.CurrentDirectory, "Library"));

            var ast = ParseScript(interpreter, script);
            interpreter.Interpret(ast);
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

        protected void Assert9(string script, params object[] args)
        {
            FormatScript();
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

        private void FormatScript()
        {
            //ProfileOperationResult result;



            //var frame = new StackTrace().GetFrame(1);
            //DkmThread.Create(
            //Microsoft.VisualStudio.Debugger.CallStack.DkmStackWalkContext.Create(
            //frame.GetNativeOffset()
            //var method = frame.GetMethod();
            //var parms = method.GetParameters();




            //Console.WriteLine(result);

            //var result2 = Microsoft.VisualStudio.Profiler.DataCollection.NameProfile("FOOO", ProfileLevel.Thread, 1);
            //var x = Interlocked.Increment(ref i);
            //Debug.Print("Marking {0}", x);
            //var result2 = Microsoft.VisualStudio.Profiler.DataCollection.CommentMarkProfile(x, "FormatScript");
            //var result2 = Microsoft.VisualStudio.Profiler.DataCollection.MarkProfile(x);



            //if (result2 != MarkOperationResult.OK)
            //{
            //    throw new NotImplementedException("MarkProfile failed: " + result2.ToString());
            //}

            //var result3 = DataCollection.MarkProfile(1);
            //if (result3 != MarkOperationResult.OK)
            //{
            //    throw new NotImplementedException("Mark failed: " + result3.ToString());
            //}
            //var args = parms[1]. as object[];

            //if (args == null || !args.Any())
            //{
            //    return;
            //}

            //var script = parms.GetValue(0) as string;
        }

        ~AphidTests()
        {
            //var result2 = DataCollection.StopProfile(
            //    ProfileLevel.Process,
            //    DataCollection.CurrentId);

            //if (result2 != ProfileOperationResult.OK)
            //{
            //    throw new NotImplementedException(result2.ToString());
            //}
        }
    }
}
