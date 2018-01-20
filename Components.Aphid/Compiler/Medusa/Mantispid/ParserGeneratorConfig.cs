using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class ParserGeneratorConfig
    {
        public string TokenType { get; private set; }

        public string BaseClass { get; private set; }

        public string NodeType { get; private set; }

        public string[] Namespace { get; private set; }

        public string ParserClass { get; private set; }

        public string ExceptionClass
        {
            get { return ParserClass + "Exception"; }
        }

        public ParserGeneratorConfig(
            string tokenType,
            string baseClass,
            string nodeType,
            string[] @namespace,
            string parserclass)
        {
            TokenType = tokenType;
            BaseClass = baseClass;
            NodeType = nodeType;
            Namespace = @namespace;
            ParserClass = parserclass;
        }
    }
}
