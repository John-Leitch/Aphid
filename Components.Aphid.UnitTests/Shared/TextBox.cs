using System;

namespace Components.Aphid.UnitTests.Shared
{
    public class TextBox : UIComponent
    {
        public event EventHandler<ValueUpdateEventArgs<string>>
            OnValueChanging,
            OnValueChanged;

        public TextBox()
            : base()
        {

        }

        public TextBox(string name)
            : base(name)
        {
        }

        private string _value;

        public string Value
        {
            get => _value;
            set => SetValue(value);
        }

        private int _maxLength;

        public int MaxLength
        {
            get => _maxLength;
            set => _maxLength = value;
        }

        private void SetValue(string value)
        {
            var oldValue = _value;

            OnValueChanging?.Invoke(
                this,
                new ValueUpdateEventArgs<string>(
                    oldValue,
                    value,
                    canCancel: true,
                    canChange: true));

            _value = value;

            OnValueChanged?.Invoke(
                this,
                new ValueUpdateEventArgs<string>(oldValue, value, canCancel: false, canChange: false));
        }
    }
}
