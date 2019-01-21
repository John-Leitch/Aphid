using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public struct Autocomplete
    {
        public string View, Text;

        public Autocomplete(string view, string text)
        {
            View = view;
            Text = text;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Autocomplete))
            {
                return false;
            }

            var autocomplete = (Autocomplete)obj;
            return View == autocomplete.View &&
                   Text == autocomplete.Text;
        }

        public override int GetHashCode()
        {
            var hashCode = 1772380982;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(View);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Text);
            return hashCode;
        }

        public static bool operator ==(Autocomplete autocomplete1, Autocomplete autocomplete2) => autocomplete1.Equals(autocomplete2);

        public static bool operator !=(Autocomplete autocomplete1, Autocomplete autocomplete2) => !(autocomplete1 == autocomplete2);
    }
}
