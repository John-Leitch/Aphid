using Components.Aphid.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidFrame
    {
        private AphidSerializer _serializer = new AphidSerializer();

        public string Name { get; set; }

        public IEnumerable<object> Arguments { get; private set; }

        public AphidFrame(string name)
            : this(name, new object[0])
        {
        }

        public AphidFrame(string name, IEnumerable<object> arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool showParamNames)
        {
            return string.Format(
                "{0}({1})",
                Name,
                CreateArgString());
        }

        private string CreateArgString()
        {
            var args = Arguments.Select(CreateObjectString);

            return string.Join(", ", args);
        }

        private string CreateObjectString(object value)
        {
            
            var aphidObj = value as AphidObject;

            return aphidObj != null ?
                _serializer.Serialize(aphidObj) :
                value.ToString();
        }
    }
}
