using Components.Aphid.Library;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidFrame
    {
        private AphidSerializer _serializer = new AphidSerializer();

        private Lazy<string> _name;

        public AphidExpression Expression { get; set; }

        public string Name
        {
            get { return _name != null ? _name.Value : null; }
        }

        public IEnumerable<object> Arguments { get; private set; }

        public AphidFrame(AphidExpression expression, Lazy<string> name)
            : this(expression, name, new object[0])
        {
        }

        public AphidFrame(AphidExpression expression, Lazy<string> name, IEnumerable<object> arguments)
        {
            Expression = expression;
            _name = name;
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
            if (value == null)
            {
                return "null";
            }

            var aphidObj = value as AphidObject;

            if (aphidObj != null)
            {
                return aphidObj.Any() ? 
                    _serializer.Serialize(aphidObj) : 
                    aphidObj.Value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
