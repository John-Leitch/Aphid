using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Net.Http
{
    public class FieldValuePair
    {
        public string Field { get; set; }

        public string Value { get; set; }

        public FieldValuePair()
        {
        }

        public FieldValuePair(string field, string value)
        {
            Field = field;
            Value = value;
        }
    }
}
