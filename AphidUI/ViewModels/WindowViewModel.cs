using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace AphidUI.ViewModels
{
    public class AphidReplViewModel : ViewModel
    {
        public const string NoValue = "Expression has been evaluated and has no value";

        private const string IsReplName = "isRepl", ViewModelName = "$replViewModel";

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

        private bool _isExecuting;

        [PropertyChanged]
        public bool IsExecuting
        {
            get { return _isExecuting; }
            set
            {
                _isExecuting = value;

                RunVisibility = value ? Visibility.Collapsed : Visibility.Visible;
                StopVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        [PropertyChanged]
        public string Code { get; set; }

        [PropertyChanged]
        public string Output { get; set; }

        private bool _isMultiLine;

        [PropertyChanged]
        public bool IsMultiLine
        {
            get { return _isMultiLine; }
            set
            {
                _isMultiLine = value;
                ExpressionVisibility = value ? Visibility.Collapsed : Visibility.Visible;
                StatementsVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        [PropertyChanged]
        public Visibility ExpressionVisibility { get; set; }

        [PropertyChanged]
        public Visibility StatementsVisibility { get; set; }

        [PropertyChanged]
        public Visibility RunVisibility { get; set; }

        [PropertyChanged]
        public Visibility StopVisibility { get; set; }

        [PropertyChanged]
        public Visibility LineOptionVisibility { get; set; }

        [PropertyChanged]
        public string Status { get; set; }

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
            Code = "";
            Status = "Ready";
            IsMultiLine = false;
            IsExecuting = false;
            LineOptionVisibility = Visibility.Visible;
            _codeViewer = outputTextBox;
            _codeViewer.Document.Blocks.Clear();
            _expressions.CollectionChanged += Expressions_CollectionChanged;
            InitInterpreter();
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
                Value = x.Value.Value,
            }))
            {
                InvokeDispatcher(() => Variables.Add(v));
            }
        }

        [AphidInteropFunction("dump", PassInterpreter = true, UnwrapParameters = false)]
        public static void Dump(AphidInterpreter interpreter, AphidObject obj)
        {
            AphidObject vmObj;
            interpreter.CurrentScope.TryResolve(ViewModelName, out vmObj);
            var vm = (AphidReplViewModel)vmObj.Value;
            var serializer = new AphidSerializer() { IgnoreFunctions = false };

            vm._codeViewer.Dispatcher.Invoke(() =>
            {
                if (obj != null)
                {
                    vm._codeViewer.AppendCode(serializer.Serialize(obj));
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
            _interpreter.CurrentScope.Add(IsReplName, new AphidObject(true));
        }

        private void InitInterpreter()
        {
            AddIsRepl();
            LoadLibrary();

            _interpreter.CurrentScope.Add(ViewModelName, new AphidObject(this));
        }

        private void ExecuteExpression()
        {
            if (string.IsNullOrEmpty(Code))
            {
                return;
            }

            AddHistoricalCode();

            var tokens = new AphidLexer(Code + " ").GetTokens();

            if (!tokens.Any(x => x.TokenType == AphidTokenType.EndOfStatement))
            {
                tokens.Add(new AphidToken(AphidTokenType.EndOfStatement, "", 0));
            }

            List<Components.Aphid.Parser.AphidExpression> ast = null;

            try
            {
                ast = new AphidParser(tokens).Parse();
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() => _codeViewer.AppendParserException(Code, ex));

                return;
            }

            if (ast.Count != 1)
            {
                throw new InvalidOperationException();
            }

            var exp = ast.First();
            var unary = exp as UnaryOperatorExpression;

            if (unary == null ||
                unary.Operator != AphidTokenType.retKeyword)
            {
                ast.Clear();
                ast.Add(new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    exp));
            }



            try
            {
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

            var retVal = _interpreter.GetReturnValue();

            var serializer = new AphidSerializer() { IgnoreFunctions = false };

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

            var tokens = new AphidLexer(Code).GetTokens();

            List<Components.Aphid.Parser.AphidExpression> ast = null;

            try
            {
                ast = new AphidParser(tokens).Parse();
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() =>
                    _codeViewer.AppendParserException(Code, ex));

                return;
            }

            try
            {
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

            _interpreterThread = new Thread(() =>
            {
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

                    if (callback != null)
                    {
                        callback();
                    }
                });

            });

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

            var retVal = new AphidSerializer() { IgnoreFunctions = false }
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
