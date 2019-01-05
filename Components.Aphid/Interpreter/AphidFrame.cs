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

        private readonly Lazy<string> _name;

        public AphidObject Scope { get; set; }

        public AphidExpression Expression { get; set; }

        public string Name
        {
            get { return _name?.Value; }
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

        public override string ToString() => ToString(true);

        public string ToString(bool showParams, bool useFullNames = true) =>
            showParams ?
                string.Format(
                    "{0}({1})",
                    Name,
                    CreateParamTupleString(useFullNames)) :
                Name;

        public string CreateParamTupleString(bool useFullNames) =>
            // Todo: get param names
            string.Join(
                ", ",
                Arguments.Select((x, i) => GetArgumentType(x, useFullNames)));

        private static string GetArgumentType(object argument, bool useFullNames)
        {
            if (argument == null)
            {
                return AphidType.Null;
            }

            var t = argument.GetType();
            var n = AphidAlias.Resolve(t);

            return n != null && n != AphidType.Unknown ? n :
                (useFullNames ? t.FullName : t.Name);
        }

        private string CreateArgString() => string.Join(", ", Arguments.Select(CreateObjectString));

        private string CreateObjectString(object value)
        {
            switch (value)
            {
                case null:
                    return "null";
                case AphidObject aphidObj:
                    return _serializer.Serialize(aphidObj);
                default:
                    return value.ToString();
            }
        }
    }
}
