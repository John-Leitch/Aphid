using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidFrame : AphidRuntimeComponent
    {
        private AphidSerializer _serializer;

        private Lazy<string> _name;

        public AphidObject Scope { get; set; }

        public AphidExpression Expression { get; set; }

        public string Name
        {
            get { return _name != null ? _name.Value : null; }
        }

        public IEnumerable<object> Arguments { get; private set; }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            Lazy<string> name)
            : this(interpreter, scope, expression, name, new object[0])
        {
        }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            Lazy<string> name,
            IEnumerable<object> arguments)
            : base(interpreter)
        {
            Scope = scope;
            Expression = expression;
            _name = name;
            Arguments = arguments;
            _serializer = new AphidSerializer(interpreter);
        }

        public override string ToString()
        {
            return ToString(true);
        }

        public string ToString(bool showParams)
        {
            return showParams ?
                string.Format("{0}({1})", Name, CreateParamTupleString()) :
                Name;
        }

        private string CreateParamTupleString()
        {
            // Todo: get param names
            return string.Join(", ", Arguments.Select((x, i) => GetArgumentType(x)));
        }
        
        private string GetArgumentType(object argument)
        {
            if (argument == null)
            {
                return AphidType.Null;
            }

            var t = argument.GetType();
            var n = AphidAlias.Resolve(t);

            return n != null && n != AphidType.Unknown ? n : t.FullName;
        }

        private string CreateArgString()
        {
            return string.Join(", ", Arguments.Select(CreateObjectString));
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
                    aphidObj.Value != null ? aphidObj.Value.ToString() :
                    "null";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
