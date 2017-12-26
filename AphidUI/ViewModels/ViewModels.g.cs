using System.Windows;
namespace AphidUI.ViewModels
{
    public partial class AphidReplViewModel
    {
        private bool _IsControlInitialized;

        public bool IsControlInitialized
        {
            get
            {
                return _IsControlInitialized;
            }
            set
            {
                _IsControlInitialized = value;
                OnIsControlInitializedChanged();
                InvokePropertyChanged("IsControlInitialized");
            }
        }

        private bool _IsExecuting;

        public bool IsExecuting
        {
            get
            {
                return _IsExecuting;
            }
            set
            {
                _IsExecuting = value;
                OnIsExecutingChanged();
                InvokePropertyChanged("IsExecuting");
            }
        }

        private bool _IsMultiLine;

        public bool IsMultiLine
        {
            get
            {
                return _IsMultiLine;
            }
            set
            {
                _IsMultiLine = value;
                OnIsMultiLineChanged();
                InvokePropertyChanged("IsMultiLine");
            }
        }

        private string _Code;

        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
                OnCodeChanged();
                InvokePropertyChanged("Code");
            }
        }

        private string _Output;

        public string Output
        {
            get
            {
                return _Output;
            }
            set
            {
                _Output = value;
                OnOutputChanged();
                InvokePropertyChanged("Output");
            }
        }

        private string _Status;

        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
                OnStatusChanged();
                InvokePropertyChanged("Status");
            }
        }

        private Visibility _ExpressionVisibility;

        public Visibility ExpressionVisibility
        {
            get
            {
                return _ExpressionVisibility;
            }
            set
            {
                _ExpressionVisibility = value;
                OnExpressionVisibilityChanged();
                InvokePropertyChanged("ExpressionVisibility");
            }
        }

        private Visibility _StatementsVisibility;

        public Visibility StatementsVisibility
        {
            get
            {
                return _StatementsVisibility;
            }
            set
            {
                _StatementsVisibility = value;
                OnStatementsVisibilityChanged();
                InvokePropertyChanged("StatementsVisibility");
            }
        }

        private Visibility _RunVisibility;

        public Visibility RunVisibility
        {
            get
            {
                return _RunVisibility;
            }
            set
            {
                _RunVisibility = value;
                OnRunVisibilityChanged();
                InvokePropertyChanged("RunVisibility");
            }
        }

        private Visibility _StopVisibility;

        public Visibility StopVisibility
        {
            get
            {
                return _StopVisibility;
            }
            set
            {
                _StopVisibility = value;
                OnStopVisibilityChanged();
                InvokePropertyChanged("StopVisibility");
            }
        }

        private Visibility _LineOptionVisibility;

        public Visibility LineOptionVisibility
        {
            get
            {
                return _LineOptionVisibility;
            }
            set
            {
                _LineOptionVisibility = value;
                OnLineOptionVisibilityChanged();
                InvokePropertyChanged("LineOptionVisibility");
            }
        }

        private void OnIsControlInitializedChanged()
        {
        }
        
        private void OnIsExecutingChanged()
        {
            RunVisibility = IsExecuting ? Visibility.Collapsed : Visibility.Visible;
            StopVisibility = IsExecuting ? Visibility.Visible : Visibility.Collapsed;
        }
        
        private void OnIsMultiLineChanged()
        {
            ExpressionVisibility = IsMultiLine ? Visibility.Collapsed : Visibility.Visible;
            StatementsVisibility = IsMultiLine ? Visibility.Visible : Visibility.Collapsed;
        }
        
        private void OnCodeChanged()
        {
        }
        
        private void OnOutputChanged()
        {
        }
        
        private void OnStatusChanged()
        {
        }
        
        private void OnExpressionVisibilityChanged()
        {
        }
        
        private void OnStatementsVisibilityChanged()
        {
        }
        
        private void OnRunVisibilityChanged()
        {
        }
        
        private void OnStopVisibilityChanged()
        {
        }
        
        private void OnLineOptionVisibilityChanged()
        {
        }
        
    }
    public partial class VariableViewModel
    {
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnNameChanged();
                InvokePropertyChanged("Name");
            }
        }

        private object _Value;

        public object Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                OnValueChanged();
                InvokePropertyChanged("Value");
            }
        }

        private void OnNameChanged()
        {
        }
        
        private void OnValueChanged()
        {
        }
        
    }
    public partial class ExpressionViewModel
    {
        private object _Value;

        public object Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                OnValueChanged();
                InvokePropertyChanged("Value");
            }
        }

        private void OnValueChanged()
        {
        }
        
    }
}
