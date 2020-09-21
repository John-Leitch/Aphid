using System;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Library.Net.Http
{
    public class HttpMessagePart
    {
        private readonly Dictionary<string, List<string>> _fieldDictionary = new Dictionary<string, List<string>>();

        protected Dictionary<string, List<string>> FieldDictionary => _fieldDictionary;

        public void ParseFields(string fields, bool skipFirstLine)
        {
            IEnumerable<string> f = fields.Split(new[] { "\r\n" }, StringSplitOptions.None);

            if (skipFirstLine)
            {
                f = f.Skip(1);
            }

            foreach (var v in f)
            {
                var fvp = v.Split(':');

                SetField(fvp[0], fvp[1].Trim());
            }
        }

        public void ClearField(string field)
        {
            if (_fieldDictionary.ContainsKey(field))
            {
                _fieldDictionary[field].Clear();
            }
        }

        public List<string> GetField(string field)
        {
            if (!_fieldDictionary.TryGetValue(field, out var values))
            {
                values = new List<string>();
                _fieldDictionary.Add(field, values);
            }

            return values;
        }

        public bool HasField(string field) => GetField(field).Count > 0;

        public void SetField(string field, string value) => GetField(field).Add(value);

        public void SetField(string field, int value) => SetField(field, value.ToString());

        public void SetField(string field, long value) => SetField(field, value.ToString());

        public bool FieldContains(string field, string value) => GetField(field).Contains(value);

        public void ResetField(string field, string value)
        {
            ClearField(field);
            SetField(field, value);
        }

        public void ResetField(string field, int value)
        {
            ClearField(field);
            SetField(field, value);
        }

        public void ResetField(string field, long value)
        {
            ClearField(field);
            SetField(field, value);
        }

        public bool TryGetInt(string field, out int value)
        {
            value = 0;
            var values = GetField(field);

            return values.Count != 0 ? int.TryParse(values[0], out value) : false;
        }

        public string GetAttributeString() => string.Join(
                "\r\n",
                FieldDictionary
                    .Select(x => x.Key + ": " + string.Join(",", x.Value)));
    }
}

