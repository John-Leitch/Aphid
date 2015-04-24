using System;
using System.CodeDom;
using System.IO;

namespace AphidCodeGenerator
{
    class AphidObjectLexerGenerator : IAphidCodeObject
    {
        public string CodeFile
        {
            get { { return @"Lexer\AphidObjectLexer.cs"; } }
        }

        public System.CodeDom.CodeObject CreateCodeObject()
        {
            return LexerHelper.GenerateLexerCompileUnit("AphidObject.alx");
        }
    }
}
