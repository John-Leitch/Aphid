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

        private Lazy<string[]> _configProperties;

        public CodeViewer CodeViewer { get; }

        public AphidInterpreter Interpreter { get; private set; } = new AphidInterpreter();

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

        private void Item_ExpressionChanged(object sender, EventArgs e) =>
            ExecuteWatchExpression((ExpressionViewModel)sender);

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
                        .AppendColoredOutput(x.Result));

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

        private void ExecuteExpression(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return;
            }

            AddHistoricalCode();
            var formattedCode = code + " ";
            var tokens = AphidLexer.GetTokens(formattedCode);

            if (!tokens.Any(x => x.TokenType == AphidTokenType.EndOfStatement))
            {
                formattedCode += "\r\n;";
                tokens = AphidLexer.GetTokens(formattedCode);
                //tokens.Add(new AphidToken(AphidTokenType.EndOfStatement, "", 0));
                //code += ";";
            }

            List<AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(tokens, formattedCode);

                if (ast.Count != 1)
                {
                    throw new AphidParserException("Unexpected expression", ast[1]);
                }
            }
            catch (AphidParserException ex)
            {
                CodeViewer.AppendParserException(Code, ex);

                return;
            }
            catch (Exception ex)
            {
                CodeViewer.AppendException(Code, "Internal parser exception (please report)", ex, Interpreter);

                return;
            }

            var exp = ast[0];

            if (!(exp is UnaryOperatorExpression unary) ||
                unary.Operator != AphidTokenType.retKeyword)
            {
                ast.Clear();
                ast.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, exp)
                {
                    Code = exp.Code,
                    Index = exp.Index,
                    Length = exp.Length
                });
            }

            try
            {
                Interpreter.ResetState();
                Interpreter.TakeOwnership();
                Interpreter.Interpret(ast);
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
            }

            var serialized = SerializingFormatter
                .CreateSerializer(Interpreter)
                .Serialize(Interpreter.GetReturnValue());

            CodeViewer.AppendColoredOutput(
                Highlight(code), 
                Highlight(serialized));

            UpdateVariables();
            ExecuteWatchExpressions();
        }

        private void ExecuteStatements(string code)
        {
            ResetInterpreter();
            CodeViewer.Document.BeginInvoke(CodeViewer.Document.Blocks.Clear);
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
                Interpreter.ResetState();
                Interpreter.TakeOwnership();
                Interpreter.Interpret(ast);
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
                CodeViewer.AppendException(code, "Internal error", ex, Interpreter);
            }

            UpdateVariables();
            ExecuteWatchExpressions();
            CodeViewer.AppendOutput("Done");
        }

        public void Execute(Action callback = null)
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

        private void ExecuteWatchExpression(ExpressionViewModel vm)
        {
            try
            {
                Interpreter.ResetState();
                Interpreter.TakeOwnership();
                Interpreter.Interpret("ret " + vm.Expression + ";");
            }
            catch (AphidRuntimeException e)
            {
                var msg = AphidCli.Redirect(() => AphidCli.DumpException(e, Interpreter));
                CodeViewer.BeginInvoke(() => vm.Value = msg);

                return;
            }
            catch (AphidParserException e)
            {
                var msg = AphidCli.Redirect(() => AphidCli.DumpException(e, vm.Expression));
                CodeViewer.BeginInvoke(() => vm.Value = msg);

                return;
            }
            catch (Exception e)
            {
                var msg = AphidCli.Redirect(() => AphidCli.DumpException(e, Interpreter));
                CodeViewer.BeginInvoke(() => vm.Value = msg);

                return;
            }

            var retVal = SerializingFormatter.Format(
                Interpreter,
                true,
                Interpreter.GetReturnValue(),
                ignoreNull: false,
                ignoreClrObj: false,
                scopes: AphidObject.GetScopeAncestors(Interpreter.CurrentScope));

            CodeViewer.Async(() => vm.Value = retVal);
        }

        private void ExecuteWatchExpressions() => Expressions.For(ExecuteWatchExpression);

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
