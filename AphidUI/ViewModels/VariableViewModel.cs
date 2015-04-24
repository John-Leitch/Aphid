using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidUI.ViewModels
{
    public class VariableViewModel : ViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private object _value;

        public object Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
    }
}
