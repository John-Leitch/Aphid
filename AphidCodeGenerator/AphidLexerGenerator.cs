using System;
using System.CodeDom;
using System.IO;

namespace AphidCodeGenerator
{
    class AphidLexerGenerator : IAphidCodeObject
    {
        public string CodeFile
        {
            get { { return @"Lexer\AphidLexer.cs"; } }
        }

        public System.CodeDom.CodeObject CreateCodeObject()
        {
            return LexerHelper.GenerateLexerCompileUnit("Aphid.alx");
        }
    }
}
