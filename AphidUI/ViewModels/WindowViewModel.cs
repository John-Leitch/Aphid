//using AphidCodeGenerator;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Documents;

namespace AphidUI.ViewModels
{
    public partial class AphidReplViewModel : ViewModelBase
    {
        public const string NoValue = "Expression has been evaluated and has no value";

        private const string IsReplName = "isRepl", ViewModelName = "$replViewModel";

        private Lazy<string[]> _configProperties;

        private CodeViewer _codeViewer;

        public CodeViewer CodeViewer
        {
            get { return _codeViewer; }
        }

        private AphidInterpreter _interpreter = new AphidInterpreter();

        public AphidInterpreter Interpreter
        {
            get { return _interpreter; }
        }

        private List<string> _codeHistory = new List<string>();

        private int _codeHistoryIndex = 0;

        private int _maxQueueSize = 32;

        private Thread _interpreterThread;

        private Action _callback;

        private AutoResetEvent _interpreterReset = new AutoResetEvent(false);

        private Thread _autoSaveThread;

        private object _autoSaveSync = new object();

        private int _autoSaveTimer = 250;

        private AutoResetEvent _autoSaveEvent = new AutoResetEvent(false);

        private bool _shouldSave = false;

        private ObservableCollection<VariableViewModel> _variables = new ObservableCollection<VariableViewModel>();

        public ObservableCollection<VariableViewModel> Variables
        {
            get { return _variables; }
        }

        private ObservableCollection<ExpressionViewModel> _expressions = new ObservableCollection<ExpressionViewModel>();

        public ObservableCollection<ExpressionViewModel> Expressions
        {
            get { return _expressions; }
        }

        public AphidReplViewModel(CodeViewer outputTextBox)
        {
            _configProperties = new Lazy<string[]>(() => GetType()
                .GetMembers()
                .Where(x => x.GetCustomAttributes(typeof(SettingAttribute), true).Any())
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
            _codeViewer = outputTextBox;
            _codeViewer.Document.Blocks.Clear();
            _expressions.CollectionChanged += Expressions_CollectionChanged;
            InitInterpreter();
            PropertyChanged += AphidReplViewModel_PropertyChanged;
        }

        void AphidReplViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
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


                var root = AphidObject.Complex();

                //foreach (var nvp in table)
                //{
                //    root.Add(nvp.Key, new AphidObject(nvp.Value));
                //}







                //var reuslt = new AphidSerializer().Serialize(root);


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

        private void Item_ExpressionChanged(object sender, EventArgs e)
        {
            ExecuteWatchExpression((ExpressionViewModel)sender);
        }

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
            if (!_codeHistory.Any())
            {
                return null;
            }
            else if (changeAndCheck())
            {
                _codeHistoryIndex = resetIndex();
            }

            return _codeHistory[_codeHistoryIndex];
        }

        private string GetPreviousCode()
        {
            return GetHistoricalCode(
                () => (--_codeHistoryIndex) == -1,
                () => _codeHistory.Count - 1);
        }

        public void SetPreviousCode()
        {
            Code = GetPreviousCode();
        }

        private string GetNextCode()
        {
            return GetHistoricalCode(
                () => (++_codeHistoryIndex) >= _codeHistory.Count,
                () => _codeHistoryIndex = 0);
        }

        public void SetNextCode()
        {
            Code = GetNextCode();
        }

        private void UpdateVariables()
        {
            InvokeDispatcher(Variables.Clear);

            foreach (var v in _interpreter.CurrentScope.Select(x => new VariableViewModel()
            {
                Name = x.Key,
                Value = x.Value != null ? x.Value.Value : null,
            }))
            {
                InvokeDispatcher(() => Variables.Add(v));
            }
        }

        [AphidInteropFunction("dump", PassInterpreter = true, UnwrapParameters = false)]
        public static void Dump(AphidInterpreter interpreter, object obj)
        {
            AphidObject vmObj;
            interpreter.CurrentScope.TryResolve(ViewModelName, out vmObj);
            var vm = (AphidReplViewModel)vmObj.Value;
            var serializer = new AphidSerializer(interpreter) { IgnoreFunctions = false };
            var ao = interpreter.ValueHelper.Wrap(obj);

            vm._codeViewer.Dispatcher.Invoke(() =>
            {
                if (obj != null)
                {
                    vm._codeViewer.AppendCode(serializer.Serialize(ao));
                }
                else
                {
                    throw new InvalidOperationException();
                }
            });
        }

        private void LoadLibrary()
        {
            _interpreter.Loader.LoadLibrary<AphidReplViewModel>(_interpreter.CurrentScope);
        }

        private void AddIsRepl()
        {
            _interpreter.CurrentScope.Add(IsReplName, AphidObject.Scalar(true));
        }

        private void InitInterpreter()
        {
            AddIsRepl();
            LoadLibrary();

            _interpreter.CurrentScope.Add(ViewModelName, AphidObject.Scalar(this));
        }

        private void ExecuteExpression()
        {
            if (string.IsNullOrEmpty(Code))
            {
                return;
            }

            AddHistoricalCode();
            var code = Code + " ";
            var tokens = new AphidLexer(code).GetTokens();

            if (!tokens.Any(x => x.TokenType == AphidTokenType.EndOfStatement))
            {
                code += "\r\n;";
                tokens = new AphidLexer(code).GetTokens();
                //tokens.Add(new AphidToken(AphidTokenType.EndOfStatement, "", 0));
                //code += ";";
            }

            List<Components.Aphid.Parser.AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(tokens, code);

                if (ast.Count != 1)
                {
                    throw new AphidParserException("Unexpected expression", ast[1]);
                }
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() => _codeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => _codeViewer.AppendException(Code, "Internal parser exception (please report)", ex));

                return;
            }

            var exp = ast.First();
            var unary = exp as UnaryOperatorExpression;

            if (unary == null ||
                unary.Operator != AphidTokenType.retKeyword)
            {
                ast.Clear();

                var retExp = new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    exp);

                retExp.Code = exp.Code;
                retExp.Index = exp.Index;
                retExp.Length = exp.Length;
                ast.Add(retExp);
            }

            try
            {
                _interpreter.ResetState();
                _interpreter.TakeOwnership();
                _interpreter.Interpret(ast);
            }
            catch (AphidRuntimeException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendException(Code, "Runtime error", ex));

                return;
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendException(Code, ".NET Runtime error", ex));
            }

            var retVal = _interpreter.GetReturnValue();

            var serializer = new AphidSerializer(_interpreter) { IgnoreFunctions = false };

            InvokeDispatcher(() =>
                _codeViewer.AppendOutput(Code, serializer.Serialize(retVal)));

            UpdateVariables();
            ExecuteWatchExpressions();
        }

        private void InvokeDispatcher(Action action)
        {

            _codeViewer.Dispatcher.Invoke(action);
        }

        private void ExecuteStatements()
        {
            ResetInterpreter();
            InvokeDispatcher(() =>
            {
                _codeViewer.Document.Blocks.Clear();
                _codeViewer.AppendOutput("Running script...");
            });

            if (string.IsNullOrEmpty(Code))
            {
                return;
            }

            List<Components.Aphid.Parser.AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(Code);
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => _codeViewer.AppendException(Code, "Internal parser exception (please report)", ex));

                return;
            }

            try
            {
                _interpreter.ResetState();
                _interpreter.TakeOwnership();
                _interpreter.Interpret(ast);
            }
            catch (AphidRuntimeException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendException(Code, "Runtime error", ex));

                return;
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendException(Code, "Internal error", ex));
            }

            UpdateVariables();
            ExecuteWatchExpressions();

            InvokeDispatcher(() =>
            {
                _codeViewer.AppendOutput("Done");
                _codeViewer.ScrollToEnd();
            });
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
                        ExecuteStatements();
                    }
                    else
                    {
                        ExecuteExpression();
                        InvokeDispatcher(() => Code = "");
                    }

                    InvokeDispatcher(() =>
                    {
                        Status = "Done";
                        IsExecuting = false;

                        if (_callback != null)
                        {
                            _callback();
                        }
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
            if (_interpreterThread != null)
            {
                try
                {
                    _interpreterThread.Abort();
                }
                catch { }
            }

            InvokeDispatcher(() =>
            {
                _codeViewer.AppendOutput("Stopped");
                _codeViewer.ScrollToEnd();
                Status = "Script stopped";
            });

            IsExecuting = false;
        }

        private void ExecuteWatchExpression(ExpressionViewModel vm)
        {
            try
            {
                _interpreter.ResetState();
                _interpreter.TakeOwnership();
                _interpreter.Interpret("ret " + vm.Expression + ";");
            }
            catch (AphidRuntimeException e)
            {
                InvokeDispatcher(() => vm.Value = "Runtime exception: " + e.Message);

                return;
            }
            catch (AphidParserException e)
            {
                InvokeDispatcher(() => vm.Value = "Parser exception: " + e.Message);

                return;
            }
            catch (Exception e)
            {
                InvokeDispatcher(() => vm.Value = ".NET runtime exception: " + e.Message);

                return;
            }

            var retVal = new AphidSerializer(_interpreter) { IgnoreFunctions = false }
                .Serialize(_interpreter.GetReturnValue());

            InvokeDispatcher(() => vm.Value = retVal);
        }

        private void ExecuteWatchExpressions()
        {
            foreach (var exp in _expressions)
            {
                ExecuteWatchExpression(exp);
            }
        }

        public void ClearCode()
        {
            Code = "";
        }

        public void ClearConsole()
        {
            _codeViewer.Document.Blocks.Clear();
        }

        public void ResetInterpreter()
        {
            _interpreter = new AphidInterpreter();
            InitInterpreter();
        }

        public void Reset()
        {
            Code = "";
            _codeViewer.Document.Blocks.Clear();
            _variables.Clear();
        }
    }
}
