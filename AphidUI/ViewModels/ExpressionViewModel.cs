using System;

namespace AphidUI.ViewModels
{
    public partial class ExpressionViewModel : ViewModelBase
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
    }
}
