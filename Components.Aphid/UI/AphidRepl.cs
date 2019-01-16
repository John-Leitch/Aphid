using Components.Aphid.Debugging;
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
using System.Threading;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public partial class AphidRepl
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

        public static object RunThreadSync { get; set; } = new object();

        public static Thread RunThread { get; set; }        

        public AphidRepl()
            : this(new AphidInterpreter())
        {
        }

        public AphidRepl(AphidInterpreter interpreter)
            : this(interpreter, AphidCli.CreateSerializer(interpreter))
        {
        }

        public AphidRepl(AphidInterpreter interpreter, AphidSerializer serializer)
        {
            Interpreter = interpreter;
            Serializer = serializer;
            Prologue = new List<AphidExpression>();
            Epilogue = new List<AphidExpression>();
        }

        public void Run()
        {
            Init();

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
                            AphidObject.Scalar(Serializer));

                        Interpreter.CurrentScope.Add(
                            "prologue",
                            AphidObject.Scalar(Prologue));

                        Interpreter.CurrentScope.Add(
                            "epilogue",
                            AphidObject.Scalar(Epilogue));

                        _isSerializerShared = true;
                    }

                    string code;

                    if (AphidErrorHandling.HandleErrors)
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

                            AphidErrorReporter.SaveErrorInformation(e, Interpreter);

                            if (e is ReflectionTypeLoadException le)
                            {
                                Cli.WriteCriticalErrorMessage(
                                    "Loader exceptions:\r\n{0}",
                                    le.LoaderExceptions.Select(x => x.Message).JoinLines());
                            }

                            continue;
                        }
                    }
                    else
                    {
                        code = console.ReadLine();
                    }

                    RunCancellableThread(code);
                    Interpreter.ResetState();
                }
            }
        }

        private void RunCancellableThread(string code)
        {
            lock (RunThreadSync)
            {
                RunThread = new Thread(() =>
                {
                    Interpreter.TakeOwnership();

                    if (AphidErrorHandling.HandleErrors)
                    {
                        Interpreter.SetIsInTryCatchFinally(true);
                        RunBlock(Prologue, handleExceptions: true);
                        AphidCli.TryAction(Interpreter, code, () => RunCode(code));
                        RunBlock(Epilogue, handleExceptions: true);
                    }
                    else
                    {
                        RunBlock(Prologue, handleExceptions: false);
                        RunCode(code);
                        RunBlock(Epilogue, handleExceptions: false);
                    }
                });

                RunThread.Start();
            }

            RunThread.Join();

            if (AphidCli.IsAborting)
            {
                AphidCli.IsAborting = false;

                if (Console.CursorLeft != 0)
                {
                    Console.CursorLeft = 0;
                    Console.CursorTop++;                    
                }

                Console.ResetColor();

                if (VT100.IsEnabled)
                {
                    Console.Write(VT100.Reset);
                }

                AphidCli.WriteMessage(ConsoleColor.Yellow, '!', "Execution interrupted by Ctrl+C");
            }

            lock (RunThreadSync)
            {
                RunThread = null;
            }
        }

        private void RunBlock(List<AphidExpression> block, bool handleExceptions)
        {
            if (block != null && block.Any())
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
            var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp)
                .WithPositionFrom(exp);

            //new AphidCodeVisitor(code).VisitExpression(retExp);
            //Interpreter.TakeOwnership();
            Interpreter.Interpret(retExp);
            var value = Interpreter.GetReturnValue();

            if (value != null &&
                (value.IsComplex || (value.IsScalar && value.Value != null)))
            {
                Console.WriteLine(
                    AphidCli.Highlight(
                        AphidCli.DumpValue(
                            Interpreter,
                            Serializer ?? new AphidSerializer(Interpreter),
                            value,
                            ignoreNull: false,
                            ignoreClrObj: false)));
            }

            //if (value != null && (value.Value != null || value.Any()))
            //{
            //    var o = (Serializer != null ? Serializer : new AphidSerializer(Interpreter))
            //            .Serialize(value);

            //    Console.WriteLine(AphidCli.Highlight(o));
            //}
        }
    }
}
