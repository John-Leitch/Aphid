using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Interpreter
{
    public readonly struct AphidFrame
    {
        private readonly object _argument;

        private readonly IEnumerable<object> _arguments;

        //private readonly AphidSerializer _serializer;

        private readonly string _name;

        private readonly Lazy<string> _lazyName;

        public readonly AphidObject Scope;

        public readonly AphidExpression Expression;

        public string Name => _name ?? _lazyName?.Value;

        public IEnumerable<object> Arguments => _arguments ?? new[] { _argument };

        public readonly AphidInterpreter Interpreter;

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            Lazy<string> name)
        {
            Scope = scope;
            Expression = expression;
            _name = null;
            _lazyName = name;
            _argument = null;
            _arguments = Array.Empty<object>();
            //_serializer = new AphidSerializer(interpreter);
            Interpreter = interpreter;
        }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            string name,
            IEnumerable<object> arguments)
        {
            Scope = scope;
            Expression = expression;
            _name = name;
            _lazyName = null;
            _argument = null;
            _arguments = arguments;
            //_serializer = new AphidSerializer(interpreter);
            Interpreter = interpreter;
        }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            string name)
        {
            Scope = scope;
            Expression = expression;
            _name = name;
            _lazyName = null;
            _argument = null;
            _arguments = Array.Empty<object>();
            //_serializer = new AphidSerializer(interpreter);
            Interpreter = interpreter;
        }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            Lazy<string> name,
            IEnumerable<object> arguments)
        {
            Scope = scope;
            Expression = expression;
            _name = null;
            _lazyName = name;
            _argument = null;
            _arguments = arguments;
            //_serializer = new AphidSerializer(interpreter);
            Interpreter = interpreter;
        }

        public AphidFrame(
            AphidInterpreter interpreter,
            AphidObject scope,
            AphidExpression expression,
            Lazy<string> name,
            object argument)
        {
            Scope = scope;
            Expression = expression;
            _name = null;
            _lazyName = name;
            _argument = argument;
            _arguments = null;
            //_serializer = new AphidSerializer(interpreter);
            Interpreter = interpreter;
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
            Arguments != null ?
                string.Join(
                    ", ",
                    Arguments.Select((x, i) => GetArgumentType(x, useFullNames))) :
            "";

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

        private string CreateArgString() =>
            string.Join(", ", Arguments.Select(CreateObjectString));

        private string CreateObjectString(object value)
        {
            switch (value)
            {
                case null:
                    return "null";
                case AphidObject aphidObj:
                    return Interpreter.Serializer.Serialize(aphidObj);
                default:
                    return value.ToString();
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AphidFrame))
            {
                return false;
            }

            var frame = (AphidFrame)obj;
            return //EqualityComparer<AphidSerializer>.Default.Equals(_serializer, frame._serializer) &&
                   EqualityComparer<Lazy<string>>.Default.Equals(_lazyName, frame._lazyName) &&
                   EqualityComparer<AphidObject>.Default.Equals(Scope, frame.Scope) &&
                   EqualityComparer<AphidExpression>.Default.Equals(Expression, frame.Expression) &&
                   EqualityComparer<IEnumerable<object>>.Default.Equals(Arguments, frame.Arguments) &&
                   EqualityComparer<AphidInterpreter>.Default.Equals(Interpreter, frame.Interpreter);
        }

        public override int GetHashCode()
        {
            var hashCode = 1404356713;
            //hashCode = (hashCode * -1521134295) + EqualityComparer<AphidSerializer>.Default.GetHashCode(_serializer);
            hashCode = (hashCode * -1521134295) + EqualityComparer<Lazy<string>>.Default.GetHashCode(_lazyName);
            hashCode = (hashCode * -1521134295) + EqualityComparer<AphidObject>.Default.GetHashCode(Scope);
            hashCode = (hashCode * -1521134295) + EqualityComparer<AphidExpression>.Default.GetHashCode(Expression);
            hashCode = (hashCode * -1521134295) + EqualityComparer<IEnumerable<object>>.Default.GetHashCode(Arguments);
            hashCode = (hashCode * -1521134295) + EqualityComparer<AphidInterpreter>.Default.GetHashCode(Interpreter);
            return hashCode;
        }

        public static bool operator ==(in AphidFrame frame1, in AphidFrame frame2) => frame1.Equals(frame2);

        public static bool operator !=(in AphidFrame frame1, in AphidFrame frame2) => !(frame1 == frame2);
    }
}
