#define APHID_FRAME_ADD_DATA
#define APHID_FRAME_CATCH_POP
//using AphidCodeGenerator;
using Components;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
using Components.Aphid.UI.Formatters;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Threading;
using static Components.Aphid.UI.Formatters.SyntaxHighlightingFormatter;

namespace AphidUI.ViewModels
{
    public partial class AphidReplViewModel
    {
        public const string NoValue = "Expression has been evaluated and has no value";

        private const string IsReplName = "isRepl", ViewModelName = "$replViewModel";

        [ThreadStatic]
        private static List<Task> _dumpTasks;

        private List<string> _codeHistory = new List<string>();

        private int _codeHistoryIndex = 0, _maxQueueSize = 32;

        private Thread _interpreterThread, _autoSaveThread;

        private Action _callback;

        private AutoResetEvent _interpreterReset = new AutoResetEvent(false);

        private object _autoSaveSync = new object();

        private int _autoSaveTimer = 250;

        private AutoResetEvent _autoSaveEvent = new AutoResetEvent(false);

        private bool _shouldSave = false;

        private Func<AphidObject> _createScope;

        private Lazy<string[]> _configProperties;

        protected static List<Task> DumpTasks => _dumpTasks ?? (_dumpTasks = new List<Task>());

        public CodeViewer CodeViewer { get; }

        public AphidInterpreter Interpreter { get; private set; } = new AphidInterpreter();

        //public AphidObject RootScope { get; set; }

        public ObservableCollection<VariableViewModel> Variables { get; } = new ObservableCollection<VariableViewModel>();

        public ObservableCollection<ExpressionViewModel> Expressions { get; } = new ObservableCollection<ExpressionViewModel>();

        public AphidReplViewModel(CodeViewer outputTextBox)
        {
            _configProperties = new Lazy<string[]>(() => GetType()
                .GetMembers()
                .Where(x => x.GetCustomAttributes(typeof(SettingAttribute), true).Length > 0)
                .Select(x => x.Name)
                .ToArray());

            //var type = new DynamicDataClassExtractor<AphidReplViewModel, SettingAttribute>().InstantiatePopulated(this, "AphidUIConfig");
            //using (var s = new MemoryStream())
            //{
            //    var serializer = new XmlSerializer(type.GetType());
            //    serializer.Serialize(s, type);
            //    s.Position = 0;
            //    var type2= serializer.Deserialize(s);
            //}

            Code = "";
            Status = "Ready";
            IsMultiLine = false;
            IsExecuting = false;
            LineOptionVisibility = Visibility.Visible;
            CodeViewer = outputTextBox;
            CodeViewer.Document.Blocks.Clear();
            Expressions.CollectionChanged += Expressions_CollectionChanged;
            InitInterpreter();
            PropertyChanged += AphidReplViewModel_PropertyChanged;
        }

        private void AphidReplViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            //type2.Members
            //    .Add(new CodeMemberProperty { Attributes = MemberAttributes.Public });

            //var asm = AppDomain.CurrentDomain.DefineDynamicAssembly(
            //    new AssemblyName("DynamicConfig"),
            //    AssemblyBuilderAccess.Run);

            //var module = asm.DefineDynamicModule("DynamicConfig");

            //var type = module.DefineType(
            //    "AphidUISettings",
            //    TypeAttributes.Public | TypeAttributes.Class);

            //type.DefineDefaultConstructor(MethodAttributes.Public);

            //table.Select(x => type.DefineProperty(x.Key, PropertyAttributes. x.PropertyType))
            //type.DefineProperty(

            if (IsControlInitialized && _configProperties.Value.Contains(e.PropertyName))
            {
                lock (_autoSaveSync)
                {
                    _shouldSave = true;
                }

                _autoSaveEvent.Set();

                if (_autoSaveThread == null)
                {
                    _autoSaveThread = new Thread(AutoSave) { IsBackground = true };
                    _autoSaveThread.Start();
                }
            }
        }

        private void AutoSave()
        {
            while (true)
            {
                _autoSaveEvent.WaitOne();

                lock (_autoSaveSync)
                {
                    if (!_shouldSave)
                    {
                        continue;
                    }

                    _shouldSave = false;
                }

                Thread.Sleep(_autoSaveTimer);
            }
        }

        private void Expressions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ExpressionViewModel i in e.NewItems)
                {
                    i.ExpressionChanged += Item_ExpressionChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (ExpressionViewModel i in e.OldItems)
                {
                    i.ExpressionChanged -= Item_ExpressionChanged;
                }
            }
        }

        private async void Item_ExpressionChanged(object sender, EventArgs e) =>
            await ExecuteWatchExpressionAsync((ExpressionViewModel)sender);

        private void AddHistoricalCode()
        {
            _codeHistory.Add(Code);

            if (_codeHistory.Count > _maxQueueSize)
            {
                _codeHistory.RemoveAt(0);
            }

            _codeHistoryIndex = _codeHistory.Count;
        }

        private string GetHistoricalCode(Func<bool> changeAndCheck, Func<int> resetIndex)
        {
            if (_codeHistory.Count == 0)
            {
                return null;
            }
            else if (changeAndCheck())
            {
                _codeHistoryIndex = resetIndex();
            }

            return _codeHistory[_codeHistoryIndex];
        }

        private string GetPreviousCode() =>
            GetHistoricalCode(
                () => (--_codeHistoryIndex) == -1,
                () => _codeHistory.Count - 1);

        public void SetPreviousCode() => Code = GetPreviousCode();

        private string GetNextCode() =>
            GetHistoricalCode(
                () => (++_codeHistoryIndex) >= _codeHistory.Count,
                () => _codeHistoryIndex = 0);

        public void SetNextCode() => Code = GetNextCode();

        private void UpdateVariables()
        {
            var variables = Interpreter.CurrentScope
                .Select(x => new VariableViewModel()
                {
                    Name = x.Key,
                    Value = x.Value?.Value,
                })
                .ToArray();

            CodeViewer.BeginInvoke(() =>
            {
                Variables.Clear();
                variables.For(Variables.Add);
            });
        }

        [AphidInteropFunction("dump", PassInterpreter = true, UnwrapParameters = false)]
        public static void Dump(AphidInterpreter interpreter, object obj) =>
            SerializingFormatter
                .Format(interpreter, obj)
                .Then(CodeViewer.HighlightAsync)
                .ContinueWith(x =>
                    interpreter.CurrentScope
                        .Resolve(interpreter, ViewModelName)
                        .Get<AphidReplViewModel>()
                        .CodeViewer
                        .AppendColoredOutput(x.Result))
                .Do(DumpTasks.Add);

        private static Task WaitDumpTasksAsync() =>
            Task.Run(() =>
            {
                Task.WaitAll(DumpTasks.ToArray());
                DumpTasks.Clear();
            });

        private void LoadLibrary() =>
            Interpreter.Loader.LoadLibrary<AphidReplViewModel>(Interpreter.CurrentScope);

        private void AddIsRepl() =>
            Interpreter.CurrentScope.Add(IsReplName, AphidObject.InternedTrue);

        private void InitInterpreter()
        {
            Interpreter = new AphidInterpreter(
                _createScope == null ? AphidObject.Complex() :
                _createScope() ?? AphidObject.Complex());

            Interpreter.CurrentScope.Add(ViewModelName, AphidObject.Scalar(this));
            AddIsRepl();
            LoadLibrary();
        }

        public void SetCreateScope(Func<AphidObject> createScope)
        {
            _createScope = createScope;
            ResetInterpreter();
        }

        private List<AphidExpression> ParseRetExpression(string code)
        {
            var (formattedCode, allTokens) = FormatExpression(code);

            List<AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(allTokens, formattedCode);

                if (ast.Count != 1)
                {
                    throw new AphidParserException("Unexpected expression", ast[1]);
                }
            }
            catch (AphidParserException ex)
            {
                CodeViewer.AppendParserException(formattedCode, ex);

                return null;
            }
            catch (Exception ex)
            {
                CodeViewer.AppendException(formattedCode, "Internal parser exception (please report)", ex, Interpreter);

                return null;
            }

            var exp = ast[0];

            if (!(exp is UnaryOperatorExpression unary) ||
                unary.Operator != AphidTokenType.retKeyword)
            {
                ast.Clear();
                ast.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, exp)
                    .WithPositionFrom(exp));
            }

            return ast;
        }

        private async void ExecuteExpression(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return;
            }

            AddHistoricalCode();

            var ast = ParseRetExpression(code);

            if (ast == null)
            {
                return;
            }

            try
            {
                try
                {
                    Interpreter.ResetState();
                    Interpreter.TakeOwnership();

#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                    try
                    {
#endif
                        Interpreter.Interpret(ast);
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                    }
#endif
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;

#if APHID_FRAME_CATCH_POP
                            Interpreter.PopQueuedFrames();
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, Interpreter);
                            e.Data.Add(AphidName.FramesKey, Interpreter.GetRawStackTrace());
#endif
                        }

                        throw;
                    }
#endif
                }
                catch (AphidRuntimeException ex)
                {
                    CodeViewer.AppendException(code, "Runtime error", ex, Interpreter);

                    return;
                }
                catch (AphidParserException ex)
                {
                    CodeViewer.AppendParserException(code, ex);

                    return;
                }
                catch (Exception ex)
                {
                    CodeViewer.AppendException(code, ".NET Runtime error", ex, Interpreter);

                    return;
                }

                var serialized = SerializingFormatter
                    .CreateSerializer(Interpreter)
                    .Serialize(Interpreter.GetReturnValue());

                await WaitDumpTasksAsync();

                await CodeViewer.Async(() =>
                    CodeViewer.AppendColoredOutput(
                        Highlight(code),
                        Highlight(serialized)));
            }
            finally
            {
                UpdateVariables();
                await ExecuteWatchExpressionsAsync();
            }
        }

        private static (string, List<AphidToken>) FormatExpression(string code)
        {
            var formattedCode = code;
            var tokens = AphidLexer.GetTokens(code);

            if (!tokens.Any(x => x.TokenType == AphidTokenType.EndOfStatement))
            {
                //var allTokens = AphidLexer.GetTokens(code);

                if (tokens.Count > 0)
                {
                    var t = tokens[tokens.Count - 1];
                    formattedCode = code.Insert(t.Index + t.Lexeme.Length, ";");
                }

                //Hackier tranformation algorithm:
                //formattedCode = string.Format(
                //    "{0}{1};",
                //    code,
                //    allTokens
                //        .Where(x =>
                //            x.TokenType != AphidTokenType.WhiteSpace ||
                //            x.Lexeme.Contains('\n'))
                //        .LastOrDefault()
                //        .If(x =>
                //            x.TokenType == AphidTokenType.Comment &&
                //            x.Lexeme.Trim().StartsWith("//"),
                //            x => "\r\n")
                //        .Else(x => ""));

                tokens = AphidLexer.GetTokens(formattedCode);
            }

            return (formattedCode, tokens);
        }

        private async void ExecuteStatements(string code)
        {
            ResetInterpreter();
            await CodeViewer.Document.BeginInvoke(CodeViewer.Document.Blocks.Clear);
            CodeViewer.AppendOutput("Running script...");

            if (string.IsNullOrEmpty(code))
            {
                return;
            }

            List<AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(code);
            }
            catch (AphidParserException ex)
            {
                CodeViewer.AppendParserException(code, ex);

                return;
            }
            catch (Exception ex)
            {
                CodeViewer.AppendException(code, "Internal parser exception (please report)", ex, Interpreter);

                return;
            }

            try
            {
                try
                {
                    Interpreter.ResetState();
                    Interpreter.TakeOwnership();

#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                    try
                    {
#endif
                        Interpreter.Interpret(ast);
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                    }
#endif
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                    catch (Exception e)
#else
                    catch
#endif
                    {
                        if (e.Source != AphidName.DebugInterpreter)
                        {
                            e.Source = AphidName.DebugInterpreter;

#if APHID_FRAME_CATCH_POP
                            Interpreter.PopQueuedFrames();
#endif

#if APHID_FRAME_ADD_DATA
                            e.Data.Add(AphidName.Interpreter, Interpreter);
                            e.Data.Add(AphidName.FramesKey, Interpreter.GetRawStackTrace());
#endif
                        }

                        throw;
                    }
#endif
                }
                catch (AphidRuntimeException ex)
                {
                    CodeViewer.AppendRuntimeException(code, ex, Interpreter);

                    return;
                }
                catch (AphidParserException ex)
                {
                    CodeViewer.AppendParserException(code, ex);

                    return;
                }
                catch (Exception ex)
                {
                    CodeViewer.AppendException(code, ".NET runtime error", ex, Interpreter);

                    return;
                }



            }
            finally
            {
                UpdateVariables();
            }

            await ExecuteWatchExpressionsAsync();
            await WaitDumpTasksAsync();

            CodeViewer.AppendOutput("Done");
        }

        public void Execute(Action callback = null)
        {
            lock (this)
            {
                IsExecuting = true;
                Status = "Running script...";

                if (_interpreterThread == null)
                {
                    CreateInterpreterThread();
                }

                _callback = callback;
                _interpreterReset.Set();
            }
        }

        private void CreateInterpreterThread()
        {
            _interpreterThread = new Thread(() =>
            {
                while (true)
                {
                    _interpreterReset.WaitOne();

                    if (IsMultiLine)
                    {
                        ExecuteStatements(Code);
                    }
                    else
                    {
                        var c = Code;
                        CodeViewer.BeginInvoke(() => Code = "");
                        ExecuteExpression(c);
                    }

                    CodeViewer.BeginInvoke(() =>
                    {
                        Status = "Done";
                        IsExecuting = false;
                        _callback?.Invoke();
                    });
                }
            })
            {
                IsBackground = true
            };

            _interpreterThread.Start();
        }

        public void Stop()
        {
            IsExecuting = false;

            Task.Run(() =>
            {
                if (_interpreterThread != null)
                {
                    try
                    {
                        _interpreterThread.Abort();
                    }
                    catch { }

                    _interpreterThread = null;
                }

                CodeViewer.AppendOutput("Stopped");
                CodeViewer.BeginInvoke(() => Status = "Script stopped");
            });
        }

        //private Task ExecuteWatchExpressionAsync(ExpressionViewModel vm) =>
        //    Task.Run(() => ExecuteWatchExpression(vm));

        private async Task ExecuteWatchExpressionAsync(ExpressionViewModel vm)
        {
            string msg = null;

            try
            {
                Interpreter.ResetState();
                Interpreter.TakeOwnership();

#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                try
                {
#endif

                    var ast = ParseRetExpression(vm.Expression);

                    if (ast == null)
                    {
                        return;
                    }

                    Interpreter.Interpret(ast);
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
                }
#endif
#if APHID_FRAME_ADD_DATA || APHID_FRAME_CATCH_POP
#if APHID_FRAME_ADD_DATA
                catch (Exception e)
#else
                catch
#endif
                {
                    if (e.Source != AphidName.DebugInterpreter)
                    {
                        e.Source = AphidName.DebugInterpreter;

#if APHID_FRAME_CATCH_POP
                        Interpreter.PopQueuedFrames();
#endif

#if APHID_FRAME_ADD_DATA
                        e.Data.Add(AphidName.Interpreter, Interpreter);
                        e.Data.Add(AphidName.FramesKey, Interpreter.GetRawStackTrace());
#endif
                    }

                    throw;
                }
#endif

            }
            catch (AphidRuntimeException e)
            {
                msg = AphidCli.Redirect(() => AphidCli.DumpException(e, Interpreter));
            }
            catch (AphidParserException e)
            {
                msg = AphidCli.Redirect(() => AphidCli.DumpException(e, vm.Expression));
            }
            catch (Exception e)
            {
                msg = AphidCli.Redirect(() => AphidCli.DumpException(e, Interpreter));
            }
            
            await DumpFormatAsync(vm, msg);
            //    )
            //CodeViewer.Run(
            //    x => vm.Value = x,
            //    )

        }

        private async Task DumpFormatAsync(ExpressionViewModel vm, string msg) =>
            //if ()
            //{
            //    return ;
            //}

            //var retVal = SerializingFormatter.Format(
            //    Interpreter,
            //    true,
            //    Interpreter.GetReturnValue(),
            //    ignoreNull: false,
            //    ignoreClrObj: false,
            //    scopes: AphidObject.GetScopeAncestors(Interpreter.CurrentScope));
            //return CodeViewer.Run(() => vm.Value = retVal);


            await CodeViewer.Run(
                x => vm.Value = x,
                await (msg != null ?
                    (Func<Task<string>>)(() => Task.FromResult(msg)) :
                    (() => Task.Run(
                        () => SerializingFormatter.Format(
                            Interpreter,
                            true,
                            Interpreter.GetReturnValue(),
                            ignoreNull: false,
                            ignoreClrObj: false,
                            scopes: AphidObject
                                .GetScopeAncestors(Interpreter.CurrentScope)))))());

        //private void ExecuteWatchExpressions() => Expressions
        //    .Select(ExecuteWatchExpressionAsync);

        private async Task ExecuteWatchExpressionsAsync()
        {
            foreach (var e in Expressions)
            {
                await ExecuteWatchExpressionAsync(e);
            }
        }

        public void ClearCode() => Code = "";

        public void ClearConsole()
        {
            CodeViewer.Document.BeginInvoke(() =>
            {
                //using (CodeViewer.Document.DisableProcessing())
                //{
                CodeViewer.Document.Blocks.Clear();
                //}
            });
        }

        public void ResetInterpreter() => InitInterpreter();

        public void Reset()
        {
            Code = "";
            CodeViewer.Document.Blocks.Clear();
            Variables.Clear();
        }
    }
}
