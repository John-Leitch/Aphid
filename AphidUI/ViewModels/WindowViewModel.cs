//using AphidCodeGenerator;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
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

        public ObservableCollection<VariableViewModel> Variables { get; } = new ObservableCollection<VariableViewModel>();

        public ObservableCollection<ExpressionViewModel> Expressions { get; } = new ObservableCollection<ExpressionViewModel>();

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
            CodeViewer = outputTextBox;
            CodeViewer.Document.Blocks.Clear();
            Expressions.CollectionChanged += Expressions_CollectionChanged;
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
            InvokeDispatcher(Variables.Clear);

            foreach (var v in Interpreter.CurrentScope.Select(x => new VariableViewModel()
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
            interpreter.CurrentScope.TryResolve(ViewModelName, out var vmObj);

            var serialized = AphidCli
                .CreateSerializer(interpreter)
                .Serialize(interpreter.ValueHelper.Wrap(obj));

            var vm = (AphidReplViewModel)vmObj.Value;

            vm.CodeViewer.Dispatcher.Invoke(() =>
            {
                if (obj != null)
                {
                    vm.CodeViewer.AppendCode(serialized);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            });
        }

        private void LoadLibrary() =>
            Interpreter.Loader.LoadLibrary<AphidReplViewModel>(Interpreter.CurrentScope);

        private void AddIsRepl() =>
            Interpreter.CurrentScope.Add(IsReplName, AphidObject.True);

        private void InitInterpreter()
        {
            Interpreter = new AphidInterpreter();
            Interpreter.CurrentScope.Add(ViewModelName, AphidObject.Scalar(this));
            AddIsRepl();
            LoadLibrary();            
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

            List<AphidExpression> ast = null;

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
                InvokeDispatcher(() => CodeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendException(Code, "Internal parser exception (please report)", ex));

                return;
            }

            var exp = ast.First();

            if (!(exp is UnaryOperatorExpression unary) ||
                unary.Operator != AphidTokenType.retKeyword)
            {
                ast.Clear();
                var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
                retExp.Code = exp.Code;
                retExp.Index = exp.Index;
                retExp.Length = exp.Length;
                ast.Add(retExp);
            }

            try
            {
                Interpreter.ResetState();
                Interpreter.TakeOwnership();
                Interpreter.Interpret(ast);
            }
            catch (AphidRuntimeException ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendException(Code, "Runtime error", ex));

                return;
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendException(Code, ".NET Runtime error", ex));
            }

            var serialized = AphidCli
                .CreateSerializer(Interpreter)
                .Serialize(Interpreter.GetReturnValue());

            InvokeDispatcher(() => CodeViewer.AppendOutput(Code, serialized));
            UpdateVariables();
            ExecuteWatchExpressions();
        }

        private void InvokeDispatcher(Action action) => CodeViewer.Dispatcher.Invoke(action);

        private void ExecuteStatements()
        {
            ResetInterpreter();

            InvokeDispatcher(() =>
            {
                CodeViewer.Document.Blocks.Clear();
                CodeViewer.AppendOutput("Running script...");
            });

            if (string.IsNullOrEmpty(Code))
            {
                return;
            }

            List<AphidExpression> ast = null;

            try
            {
                ast = AphidParser.Parse(Code);
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendException(Code, "Internal parser exception (please report)", ex));

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
                InvokeDispatcher(() => CodeViewer.AppendException(Code, "Runtime error", ex));

                return;
            }
            catch (AphidParserException ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendParserException(Code, ex));

                return;
            }
            catch (Exception ex)
            {
                InvokeDispatcher(() => CodeViewer.AppendException(Code, "Internal error", ex));
            }

            UpdateVariables();
            ExecuteWatchExpressions();

            InvokeDispatcher(() =>
            {
                CodeViewer.AppendOutput("Done");
                CodeViewer.ScrollToEnd();
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
                CodeViewer.AppendOutput("Stopped");
                CodeViewer.ScrollToEnd();
                Status = "Script stopped";
            });

            IsExecuting = false;
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

            var retVal = new AphidSerializer(Interpreter) { IgnoreFunctions = false }
                .Serialize(Interpreter.GetReturnValue());

            InvokeDispatcher(() => vm.Value = retVal);
        }

        private void ExecuteWatchExpressions()
        {
            foreach (var exp in Expressions)
            {
                ExecuteWatchExpression(exp);
            }
        }

        public void ClearCode() => Code = "";
        public void ClearConsole() => CodeViewer.Document.Blocks.Clear();
        public void ResetInterpreter() => InitInterpreter();

        public void Reset()
        {
            Code = "";
            CodeViewer.Document.Blocks.Clear();
            Variables.Clear();
        }
    }
}
