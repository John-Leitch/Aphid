using Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class ParserGeneratorConfig : Singleton<ParserGeneratorConfig>
    {
        public string TokenType { get; private set; }

        public string BaseClass { get; private set; }

        public string NodeType { get; private set; }

        public string[] Namespace { get; private set; }

        public string ParserClass { get; private set; }

        public bool IsAstMutable { get; private set; }

        public string ExceptionClass
        {
            get { return ParserClass + "Exception"; }
        }

        public string ExpressionContextClass
        {
            get { return BaseClass + "Context"; }
        }

        public string HelperClass
        {
            get { return BaseClass + "Helper"; }
        }

        public ParserGeneratorConfig(
            string tokenType,
            string baseClass,
            string nodeType,
            string[] @namespace,
            string parserclass,
            bool isAstMutable)
        {
            TokenType = tokenType;
            BaseClass = baseClass;
            NodeType = nodeType;
            Namespace = @namespace;
            ParserClass = parserclass;
            IsAstMutable = isAstMutable;
        }
    }
}
