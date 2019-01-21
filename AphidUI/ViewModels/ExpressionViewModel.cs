using System;

namespace AphidUI.ViewModels
{
    public partial class ExpressionViewModel
    {
        public event EventHandler ExpressionChanged;

        private string _expression;

        public string Expression
        {
            get => _expression;
            set
            {
                SetProperty(ref _expression, value);
                ExpressionChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
