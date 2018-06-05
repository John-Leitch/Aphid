using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;


namespace AphidUI.ViewModels
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ByteCode_221ad5a3a1876e7a60e51ed97b2b3efd()
        {
            return             new List<AphidExpression>
            {
                new FunctionExpression(
                    new List<AphidExpression>
                    {
                    },
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "ViewModel",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        new UnaryOperatorExpression(
                            AphidTokenType.usingKeyword,
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "System",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Windows",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            false
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AphidUI",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ViewModels",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new TernaryOperatorExpression(
                            AphidTokenType.ConditionalOperator,
                            new IdentifierExpression(
                                "hide",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "Visibility",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Collapsed",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "Visibility",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Visible",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            )
                        ),
                        new TernaryOperatorExpression(
                            AphidTokenType.ConditionalOperator,
                            new IdentifierExpression(
                                "show",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "Visibility",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Visible",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "Visibility",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Collapsed",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            )
                        ),
                        new ObjectExpression(
                            new List<BinaryOperatorExpression>
                            {
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "IsControlInitialized",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "bool",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "IsControlInitialized",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "bool",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "IsExecuting",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "IsExecuting",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "RunVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "hide",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "RunVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "hide",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "StopVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "show",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "StopVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "show",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "IsMultiLine",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "IsMultiLine",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ExpressionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "hide",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "ExpressionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "hide",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "StatementsVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "show",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "StatementsVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "show",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Code",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "string",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Code",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "string",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Output",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Output",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Status",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Status",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ExpressionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "Visibility",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "ExpressionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "Visibility",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "StatementsVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "StatementsVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "RunVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "RunVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "StopVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "StopVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "LineOptionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "LineOptionVisibility",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                            },
                            new IdentifierExpression(
                                "AphidReplViewModel",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "class",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new ObjectExpression(
                            new List<BinaryOperatorExpression>
                            {
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Name",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "string",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Name",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "string",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Value",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "object",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Value",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "object",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                            },
                            new IdentifierExpression(
                                "VariableViewModel",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "class",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new ObjectExpression(
                            new List<BinaryOperatorExpression>
                            {
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Value",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "object",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.ColonOperator,
                                    new IdentifierExpression(
                                        "Value",
                                        new List<IdentifierExpression>
                                        {
                                            new IdentifierExpression(
                                                "object",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    )
                                ),
                            },
                            new IdentifierExpression(
                                "ExpressionViewModel",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "class",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                    }
                ),
            }
;
        }
    }
}

namespace AphidUI.ViewModels
{
    using System.Windows;
    public partial class AphidReplViewModel : System.ComponentModel.INotifyPropertyChanged
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
        

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(callerName));
            }
        }

        protected void SetProperty<T>(
            ref T property,
            T value,
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            property = value;
            InvokePropertyChanged(callerName);
        }
    }

    public partial class VariableViewModel : System.ComponentModel.INotifyPropertyChanged
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
        

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(callerName));
            }
        }

        protected void SetProperty<T>(
            ref T property,
            T value,
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            property = value;
            InvokePropertyChanged(callerName);
        }
    }

    public partial class ExpressionViewModel : System.ComponentModel.INotifyPropertyChanged
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
        

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(callerName));
            }
        }

        protected void SetProperty<T>(
            ref T property,
            T value,
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            property = value;
            InvokePropertyChanged(callerName);
        }
    }

}

