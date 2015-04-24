using System;

namespace AphidUI.ViewModels
{
    public class ExpressionViewModel : ViewModel
    {
        public event EventHandler ExpressionChanged;

        private string _expression;

        public string Expression
        {
            get { return _expression; }
            set
            {
                SetProperty(ref _expression, value);

                if (ExpressionChanged != null)
                {
                    ExpressionChanged(this, new EventArgs());
                }
            }
        }

        private object _value;

        public object Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
    }
}
