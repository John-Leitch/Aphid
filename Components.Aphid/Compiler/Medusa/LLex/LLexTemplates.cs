using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.Compiler.Medusa.LLex {
    
    
    public partial class LLexTemplates {
        
        private static LexerTemplateDelegate _LexerTemplate;
        
        public static LexerTemplateDelegate LexerTemplate {
            get {
                if ((LLexTemplates._LexerTemplate == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_3ba97e3b84cffa9ec49ee1579d5be040());
                }
                return LLexTemplates._LexerTemplate;
            }
            set {
                LLexTemplates._LexerTemplate = value;
            }
        }
        
        public delegate string LexerTemplateDelegate();
    }
}

namespace Components.Aphid.Compiler.Medusa.LLex {
    
    
    public partial class LLexTemplates {
        
        private static CaseTemplateDelegate _CaseTemplate;
        
        public static CaseTemplateDelegate CaseTemplate {
            get {
                if ((LLexTemplates._CaseTemplate == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_3ba97e3b84cffa9ec49ee1579d5be040());
                }
                return LLexTemplates._CaseTemplate;
            }
            set {
                LLexTemplates._CaseTemplate = value;
            }
        }
        
        public delegate string CaseTemplateDelegate();
    }
}

namespace Components.Aphid.Compiler.Medusa.LLex {
    
    
    public partial class LLexTemplates {
        
        private static StateTemplateDelegate _StateTemplate;
        
        public static StateTemplateDelegate StateTemplate {
            get {
                if ((LLexTemplates._StateTemplate == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_3ba97e3b84cffa9ec49ee1579d5be040());
                }
                return LLexTemplates._StateTemplate;
            }
            set {
                LLexTemplates._StateTemplate = value;
            }
        }
        
        public delegate string StateTemplateDelegate();
    }
}

namespace Components.Aphid.Compiler.Medusa.LLex {
    
    
    public partial class LLexTemplates {
        
        private static RootStateTemplateDelegate _RootStateTemplate;
        
        public static RootStateTemplateDelegate RootStateTemplate {
            get {
                if ((LLexTemplates._RootStateTemplate == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_3ba97e3b84cffa9ec49ee1579d5be040());
                }
                return LLexTemplates._RootStateTemplate;
            }
            set {
                LLexTemplates._RootStateTemplate = value;
            }
        }
        
        public delegate string RootStateTemplateDelegate();
    }
}

namespace Components.Aphid.Compiler.Medusa.LLex {
    
    
    public partial class LLexTemplates {
        
        private static AddTokenTemplateDelegate _AddTokenTemplate;
        
        public static AddTokenTemplateDelegate AddTokenTemplate {
            get {
                if ((LLexTemplates._AddTokenTemplate == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_3ba97e3b84cffa9ec49ee1579d5be040());
                }
                return LLexTemplates._AddTokenTemplate;
            }
            set {
                LLexTemplates._AddTokenTemplate = value;
            }
        }
        
        public delegate string AddTokenTemplateDelegate();
    }
}

namespace Components.Aphid.Compiler.Medusa.LLex
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ByteCode_3ba97e3b84cffa9ec49ee1579d5be040()
        {
            return             new List<AphidExpression>
            {
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Components",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Aphid",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Compiler",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Medusa",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "LLex",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "trim",
                        new List<IdentifierExpression>
                        {
                            new IdentifierExpression(
                                "var",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "x",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "x",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Trim",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'\\r\\n'"
                                        ),
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "LLexTemplates",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "LexerTemplate",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'\r\n    //------------------------------------------------------------------------------\r\n    // <auto-generated>\r\n    //     This code was generated by llex.\r\n    // </auto-generated>\r\n    //------------------------------------------------------------------------------\r\n\r\n    #pragma warning disable 0162\r\n\r\n    namespace {LexerNamespace}\r\n    {\r\n        using System;\r\n        using System.Collections.Generic;\r\n\r\n        [global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"llex\", \"1\")]\r\n        public enum {TokenType} : short\r\n        {\r\n            {Enums}\r\n        }\r\n\r\n        [global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"llex\", \"1\")]\r\n        public readonly partial struct {Token}\r\n        {\r\n            public readonly {TokenType} TokenType;\r\n            public readonly string Lexeme;\r\n            public readonly int Index;\r\n\r\n            public {Token}({TokenType} tokenType, string lexeme, int index)\r\n            {\r\n                TokenType = tokenType;\r\n                Lexeme = lexeme;\r\n                Index = index;\r\n            }\r\n                \r\n            public override string ToString()\r\n            {\r\n                return string.Format(\"[{0}] {1}: {2}\", Index, TokenType, Lexeme);\r\n            }\r\n\r\n            public bool IsKeyword()\r\n            {\r\n                return {IsKeyword};\r\n            }\r\n        }\r\n\r\n        [global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"llex\", \"1\")]\r\n        public partial class {Lexer}\r\n        {\r\n            private string text = \"\";\r\n\r\n            public string Text\r\n            {\r\n                get { return text; }\r\n                set \r\n                { \r\n                    text = value;\r\n                    lastIndex = text.Length - 1;\r\n                }\r\n            }\r\n\r\n            int lastIndex = -1;\r\n\r\n            int charIndex = -1;\r\n\r\n            int mode = 0;\r\n\r\n            int state = 0;\r\n\r\n            char currentChar = (char)0;\r\n\r\n            public {Lexer}()\r\n            {\r\n            }\r\n\r\n            public {Lexer}(string text)\r\n            {\r\n                Text = text;\r\n            }\r\n\r\n            bool NextChar()\r\n            {\r\n                if (charIndex < lastIndex)\r\n                {\r\n                    currentChar = text[++charIndex];\r\n                    return true;\r\n                }\r\n\r\n                return false;\r\n            }\r\n\r\n            private {TokenType} GetToken()\r\n            {\r\n                {Root}\r\n\r\n                return {TokenType}.EndOfFile;\r\n            }\r\n\r\n            public List<{Token}> GetTokens()\r\n            {\r\n                charIndex = -1;\r\n\r\n                {TokenType} tokenType;\r\n\r\n                int lastIndex = -1;\r\n\r\n                var tokens = new List<{Token}>();\r\n\r\n                while ((tokenType = GetToken()) != {TokenType}.EndOfFile)\r\n                {\r\n                    {Body}\r\n\r\n                    lastIndex = charIndex;                \r\n                }\r\n\r\n                return tokens;\r\n            }\r\n\r\n            public List<{Token}> GetAllTokens()\r\n            {\r\n                charIndex = -1;\r\n\r\n                {TokenType} tokenType;\r\n\r\n                int lastIndex = -1;\r\n\r\n                var tokens = new List<{Token}>();\r\n\r\n                while ((tokenType = GetToken()) != {TokenType}.EndOfFile)\r\n                {\r\n                    {AllBody}\r\n\r\n                    lastIndex = charIndex;                \r\n                }\r\n\r\n                return tokens;\r\n            }\r\n        }\r\n    }\r\n    #pragma warning restore 0162\r\n'"
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new IdentifierExpression(
                                        "trim",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "LLexTemplates",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "CaseTemplate",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'\r\n    {{Cases}}\r\n        {{States}}\r\n        {{Body}}\r\n'"
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new IdentifierExpression(
                                        "trim",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "LLexTemplates",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "StateTemplate",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'\r\n    if (charIndex < lastIndex)\r\n    {\r\n        currentChar = text[++charIndex];\r\n\r\n        switch (currentChar)\r\n        {\r\n            {{States}}\r\n        }\r\n\r\n        PreviousChar();\r\n    }\r\n'"
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new IdentifierExpression(
                                        "trim",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "LLexTemplates",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "RootStateTemplate",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'\r\n    if (charIndex < lastIndex)\r\n    {\r\n        currentChar = text[++charIndex];\r\n\r\n        switch (currentChar)\r\n        {\r\n            {{States}}\r\n        }\r\n\r\n        return {TokenType}.Unknown;\r\n    }\r\n'"
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new IdentifierExpression(
                                        "trim",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "LLexTemplates",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AddTokenTemplate",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'\r\n    var index = lastIndex + 1;\r\n    var lexeme = text.Substring(index, charIndex - lastIndex);\r\n\r\n    tokens.Add(new {Token}(tokenType, lexeme, index));\r\n'"
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new IdentifierExpression(
                                        "trim",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
            }
;
        }
    }
}


