﻿#define TRACE_SCRIPTED_TESTS
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System.Collections;
using Components.External.ConsolePlus;
using static NUnit.Framework.Assert;

namespace Components.Aphid.UnitTests.Shared
{
    [Parallelizable(ParallelScope.All)]
    public class AphidTests : IDisposable
    {
        public event EventHandler<InterpreterEventArgs> InterpreterCreated;

        private ThreadLocal<AphidInterpreter> _nextInterpreter = new ThreadLocal<AphidInterpreter>();

        private static readonly object _cachedStdNodesSync = new object();

        private static List<AphidExpression> _cachedStdNodes;

        private static readonly AphidExpression _cachedUsing = new UnaryOperatorExpression(
            AphidTokenType.usingKeyword,
            new IdentifierExpression("System"));

        private static readonly List<AphidExpression> _cachedUsingBlock = new List<AphidExpression>
        {
            new UnaryOperatorExpression(AphidTokenType.usingKeyword, new IdentifierExpression("System"))
        };

        private static readonly List<AphidExpression> _cachedUsingIncludeBlock = new List<AphidExpression>
        {
            new UnaryOperatorExpression(AphidTokenType.usingKeyword, new IdentifierExpression("System")),
            new UnaryOperatorExpression(AphidTokenType.LoadScriptOperator, new StringExpression("'Std.alx'")),
        };

        private static TextWriterTraceListener _listener = new TextWriterTraceListener(@"Tests.log");

        public virtual bool LoadStd => false;

        static AphidTests() => Initialize();

        public AphidTests() => Initialize();

        [Conditional("TRACE_SCRIPTED_TESTS")]
        protected static void Initialize()
        {
            if (!Trace.Listeners.Contains(_listener))
            {
                Trace.Listeners.Add(_listener);
                Trace.AutoFlush = true;
                Cli.UseTrace = true;
                WriteInfoMessage("Initialize called");
            }
        }

        [Conditional("TRACE_SCRIPTED_TESTS")]
        public static void WriteInfoMessage(string message) => Cli.WriteInfoMessage(message);

        [Conditional("TRACE_SCRIPTED_TESTS")]
        public static void WriteQueryMessage(string message) => Cli.WriteQueryMessage(message);

        [Conditional("TRACE_SCRIPTED_TESTS")]
        public static void WriteSuccessMessage(string message) => Cli.WriteSuccessMessage(message);

        public virtual List<AphidExpression> ParseScript(AphidInterpreter interpreter, string script)
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

        private static List<AphidExpression> PreprocessAst(List<AphidExpression> ast)
        {
            var stage1 = new PartialOperatorMutator().MutateRecursively(ast);
            var stage2 = new AphidMacroMutator().MutateRecursively(stage1);
            var stage3 = new AphidPreprocessorDirectiveMutator().MutateRecursively(stage2);

            return stage3;
        }

        public AphidInterpreter GetNextInterpreter()
        {
            lock (_nextInterpreter)
            {
                return _nextInterpreter.Value ??
                    (_nextInterpreter.Value = new AphidInterpreter());
            }
        }

        public AphidObject Execute(string script)
        {
            AphidInterpreter interpreter;

            lock (_nextInterpreter)
            {
                var created = _nextInterpreter.IsValueCreated;

                interpreter = _nextInterpreter.Value ??
                    new AphidInterpreter().Do(_ => created = true);

                if (created)
                {
                    InterpreterCreated?.Invoke(this, new InterpreterEventArgs(interpreter));
                }

                _nextInterpreter.Value = null;
            }

            interpreter.Loader.SearchPaths.Add(Path.Combine(Environment.CurrentDirectory, "Library"));
            interpreter.Interpret(ParseScript(interpreter, script));
            return interpreter.GetReturnValue();
        }

        public void Execute(string script, Action<AphidObject> action) =>
            action(Execute(script));

        public void Is(string script, Func<AphidObject, bool> predicate) =>
            IsTrue(predicate(Execute(script)));

        public void Is<TValue>(string script, Func<TValue, bool> predicate) =>
            IsTrue(predicate((TValue)Execute(script).Value));

        public static List<AphidToken> GetTokens(string script) =>
            new AphidLexer(script).GetAllTokens();

        public static void AssertTokens(string script, AphidToken[] tokens)
        {
            var tokens2 = GetTokens(script);
            AreEqual(tokens.Length, tokens2.Count);

            for (var i = 0; i < tokens.Length; i++)
            {
                AreEqual(tokens[i].TokenType, tokens2[i].TokenType);

                if (tokens[i].Lexeme != null)
                {
                    AreEqual(tokens[i].Lexeme, tokens2[i].Lexeme);
                }
            }
        }

        public static AphidToken Token(AphidTokenType type, string lexeme) => new AphidToken(type, lexeme, 0);

        public static AphidToken Token(AphidTokenType type) => Token(type, null);

        public static void IsFalse(bool value) =>
            Assert.IsFalse(value);
        
        public static void IsTrue(bool value) =>
            Assert.IsTrue(value);
        
        public static void IsFoo(object value) => 
            AreEqual("foo", value);
        
        public static void Is9(object value) => 
            AreEqual(9m, value);
        
        public static void IsNull(object value) =>
            Assert.IsNull(value);
        
        public static void NotNull(object value) =>
            Assert.NotNull(value);
        
        public static void IsFail(Action action) => 
            IsThrow<AssertionException>(action);

        public static void AllFail(params Action[] actions) =>
            actions.Do(CollectionAssert.IsNotEmpty).Iter(IsFail);

        public static Exception IsThrow(Action action) => Catch(() => action());

        public static Exception[] AllThrow(params Action[] actions) =>
            actions.Do(CollectionAssert.IsNotEmpty).Select(IsThrow).ToArray();

        public static TException IsThrow<TException>(Action action)
            where TException : Exception =>
            Catch<TException>(() => action());

        public static TException[] AllThrow<TException>(
            params Action[] actions)
            where TException : Exception =>
            actions.Do(CollectionAssert.IsNotEmpty).Select(IsThrow<TException>).ToArray();

        public void AssertEquals(object expected, string script) =>
            AreEqual(expected, Execute(script).Value);

        public void AssertFoo(string script) =>
            AssertEquals("foo", script);
        
        public void Assert9(string script) =>
            AssertEquals(9m, script);
        
        public void AssertTrue(string script) =>
            AssertEquals(true, script);
        
        public void AssertFalse(string script) =>
            AssertEquals(false, script);

        private static string CreateStatement(string expression) =>
            string.Format("ret {0};", expression);

        public void AssertExpEquals(object expected, string expression) =>
            AssertEquals(expected, CreateStatement(expression));

        public void AssertExpFoo(string expression) =>
            AssertFoo(CreateStatement(expression));

        public void AssertExp9(string expression) =>
            Assert9(CreateStatement(expression));

        public void AssertExpTrue(string expression) =>
            AssertTrue(CreateStatement(expression));

        public void AssertExpFalse(string expression) =>
            AssertFalse(CreateStatement(expression));

        public void AssertCollectionIs<TElement>(string script, params TElement[] expected) =>
            CollectionAssert.AreEqual(expected, (IEnumerable)Execute(script).Value);

        public virtual void Dispose()
        {
            WriteSuccessMessage("Dispose called");
            Trace.Listeners.Remove(_listener);

            using (_listener)
            {
                _listener = null;
            }
        }
    }
}
