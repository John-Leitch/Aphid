using System.Collections.Generic;

namespace Components.External.ConsolePlus
{
    public readonly struct Autocomplete
    {
        public readonly string View, Text;

        public Autocomplete(string view, string text)
        {
            View = view;
            Text = text;
        }

        public override bool Equals(object obj) =>
            obj is Autocomplete ac ? View == ac.View && Text == ac.Text : false;

        public override int GetHashCode() =>
            ((1772380982 + View.GetHashCode()) * -1521134295) - Text.GetHashCode();

        public static bool operator ==(in Autocomplete autocomplete1, in Autocomplete autocomplete2) =>
            autocomplete1.Equals(autocomplete2);

        public static bool operator !=(in Autocomplete autocomplete1, in Autocomplete autocomplete2) =>
            !(autocomplete1 == autocomplete2);
    }
}
