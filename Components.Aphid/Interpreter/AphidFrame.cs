using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidFrame
    {
        public string Name { get; set; }

        public AphidFunction Function { get; private set; }

        public bool IsAphid
        {
            get { return Function != null; }
        }

        public AphidInteropFunction InteropFunction { get; private set; }

        public bool IsInterop
        {
            get { return InteropFunction != null; }
        }

        public bool HasFunction
        {
            get { return Function != null || InteropFunction != null; }
        }

        public IEnumerable<AphidObject> Arguments { get; private set; }

        public IEnumerable<object> UnwrappedArguments { get; private set; }

        public bool IsUnwrapped
        {
            get { return UnwrappedArguments != null; }
        }

        private AphidFrame(string name, IEnumerable<AphidObject> arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public AphidFrame(string name, AphidFunction function, IEnumerable<AphidObject> arguments)
            : this(name, arguments)
        {
            Function = function;
        }

        public AphidFrame(string name, AphidInteropFunction function, IEnumerable<AphidObject> arguments)
            : this(name, arguments)
        {
            InteropFunction = function;
        }

        public AphidFrame(string name, AphidInteropFunction function, IEnumerable<object> arguments)
            : this(name, null)
        {
            InteropFunction = function;
            UnwrappedArguments = arguments;
        }

        public AphidFrame(
            string name,
            AphidFunction function,
            AphidInteropFunction interopFunction,
            IEnumerable<AphidObject> arguments,
            IEnumerable<object> unwrappedArguments)
        {
            Name = name;
            Function = function;
            InteropFunction = interopFunction;
            Arguments = arguments;
            UnwrappedArguments = unwrappedArguments;
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool showParamNames)
        {
            return HasFunction ?
                string.Format("{0}({1})", Name, CreateArgString(showParamNames)) :
                Name;
        }

        private string CreateArgString(bool showParamNames)
        {
            IEnumerable<string> args = IsUnwrapped ?
                UnwrappedArguments.Select(x => x.ToString()) : 
                Arguments.Select(x => x.Value == null ? x.ToString() : x.Value.ToString());

            if (showParamNames && IsAphid)
            {
                args = args.Select((x, i) => string.Format(
                    "{0}: {1}", 
                    Function.Args[i], 
                    x));
            }

            return string.Join(", ", args);
        }        
    }
}
