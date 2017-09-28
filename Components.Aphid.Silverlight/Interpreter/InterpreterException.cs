using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class InterpreterException : Exception
    {
        public string Message { get; set; }

        public AphidToken Token { get; set; }

        public InterpreterException()
        {
        }

        public InterpreterException(string message, AphidToken token)
        {
            Message = message;
            Token = token;
        }

        public override string ToString()
        {
            return string.Format("{0} at {1}", Message, Token);
        }
    }
}
