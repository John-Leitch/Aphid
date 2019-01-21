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
        public string TokenType { get; }

        public string BaseClass { get; }

        public string NodeType { get; }

        public string[] Namespace { get; }

        public string ParserClass { get; }

        public bool IsAstMutable { get; }

        public string ExceptionClass => ParserClass + "Exception";

        public string ExpressionContextClass => BaseClass + "Context";

        public string HelperClass => BaseClass + "Helper";

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
