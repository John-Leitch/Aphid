using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Tests.Integration.Shared
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
            get { return _value; }
            set { SetValue(value); }
        }

        private int _maxLength;

        public int MaxLength
        {
            get { return _maxLength; }
            set { _maxLength = value; }
        }

        private void SetValue(string value)
        {
            var oldValue = _value;

            if (OnValueChanging != null)
            {
                OnValueChanging(
                    this,
                    new ValueUpdateEventArgs<string>(
                        oldValue,
                        value,
                        canCancel: true,
                        canChange: true));
            }
            
            _value = value;

            if (OnValueChanged != null)
            {
                OnValueChanged(
                    this,
                    new ValueUpdateEventArgs<string>(
                        oldValue,
                        value,
                        canCancel: false,
                        canChange: false));
            }
        }
    }
}
