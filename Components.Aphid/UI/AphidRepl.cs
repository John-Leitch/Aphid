using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidRepl
    {
        private bool _isSerializerShared = false;

        private AphidSerializer _serializer;

        public AphidSerializer Serializer
        {
            get { return _serializer; }
            set
            {
                _serializer = value;
                _isSerializerShared = false;
            }
        }

        public AphidInterpreter Interpreter { get; set; }

        public List<AphidExpression> Prologue { get; set; }

        public List<AphidExpression> Epilogue { get; set; }

        public AphidRepl()
            : this(null)
        {
        }

        public AphidRepl(AphidInterpreter interpreter)
            : this(interpreter, null)
        {
        }

        public AphidRepl(AphidInterpreter interpreter, AphidSerializer serializer)
        {
            Interpreter = interpreter ?? new AphidInterpreter();
            Serializer = serializer ?? new AphidSerializer(Interpreter) { IgnoreSpecialVariables = true, };
            Prologue = new List<AphidExpression>();
            Epilogue = new List<AphidExpression>();
        }

        public void Run()
        {
            if (Interpreter == null)
            {
                Interpreter = new AphidInterpreter();
            }

            using (var console = new AphidAutocompleteConsole(Interpreter))
            {
                while (true)
                {
                    var isDumpDefined = Interpreter.CurrentScope.IsDefined(AphidName.DumpSerializer);

                    if (!_isSerializerShared || !isDumpDefined)
                    {
                        if (isDumpDefined)
                        {
                            Interpreter.CurrentScope.Remove(AphidName.DumpSerializer);
                        }

                        Interpreter.CurrentScope.Add(
                            AphidName.DumpSerializer,
                            new AphidObject(Serializer));

                        Interpreter.CurrentScope.Add(
                            "prologue",
                            new AphidObject(Prologue));

                        Interpreter.CurrentScope.Add(
                            "epilogue",
                            new AphidObject(Epilogue));

                        _isSerializerShared = true;
                    }

                    string code;

                    if (!Debugger.IsAttached)
                    {
                        try
                        {
                            code = console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Cli.WriteCriticalErrorMessage(
                                "Internal error encountered in autocomplete console:\r\n{0}",
                                e.Message);

                            if (e is ReflectionTypeLoadException)
                            {
                                var loaderExceptions = ((ReflectionTypeLoadException)e).LoaderExceptions;

                                Cli.WriteCriticalErrorMessage(
                                    "Loader exceptions:\r\n{0}",
                                    loaderExceptions.Select(x => x.Message).JoinLines());
                            }

                            continue;
                        }
                    }
                    else
                    {
                        code = console.ReadLine();
                    }

                    if (!Debugger.IsAttached)
                    {
                        RunBlock(Prologue, handleExceptions: true);
                        AphidCli.TryAction(Interpreter, code, () => RunCode(code));
                        RunBlock(Epilogue, handleExceptions: true);
                    }
                    else
                    {
                        var backup = Interpreter.SetIsInTryCatchFinally(true);
                        RunBlock(Prologue, handleExceptions: false);
                        RunCode(code);
                        RunBlock(Epilogue, handleExceptions: false);
                        Interpreter.SetIsInTryCatchFinally(backup);
                    }

                    Interpreter.ResetState();
                }
            }
        }

        private void RunBlock(List<AphidExpression> block, bool handleExceptions)
        {
            if (block != null)
            {
                if (handleExceptions)
                {
                    AphidCli.TryAction(
                        Interpreter,
                        block
                            .Select(x => x.Code)
                            .Where(x => x != null)
                            .FirstOrDefault(),
                        () => Interpreter.Interpret(block));
                }
                else
                {
                    Interpreter.Interpret(block);
                }
            }
        }

        private void RunCode(string code)
        {
            if (code.Trim() == "")
            {
                return;
            }

            var lexer = new AphidLexer(code);
            var tokens = lexer.GetTokens();
            var exp = AphidParser.ParseExpression(tokens, code);
            var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
            new AphidCodeVisitor(code).VisitExpression(retExp);
            Interpreter.Interpret(retExp);
            var value = Interpreter.GetReturnValue();

            if (value != null && (value.Value != null || value.Any()))
            {
                var o = (Serializer != null ? Serializer : new AphidSerializer(Interpreter))
                        .Serialize(value);

                Console.WriteLine(AphidCli.Highlight(o));
            }
        }
    }
}
