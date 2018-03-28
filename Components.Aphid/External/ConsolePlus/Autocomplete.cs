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
    }
}
