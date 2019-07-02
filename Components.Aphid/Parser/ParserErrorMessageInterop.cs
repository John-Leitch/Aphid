using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static FromExpressionDelegate _FromExpression;
        
        public static FromExpressionDelegate FromExpression {
            get {
                if ((ParserErrorMessage._FromExpression == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._FromExpression;
            }
            set {
                ParserErrorMessage._FromExpression = value;
            }
        }
        
        public delegate string FromExpressionDelegate(string code, AphidParserException exception, bool highlight);
    }
}

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static AppendFilenameDelegate _AppendFilename;
        
        public static AppendFilenameDelegate AppendFilename {
            get {
                if ((ParserErrorMessage._AppendFilename == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._AppendFilename;
            }
            set {
                ParserErrorMessage._AppendFilename = value;
            }
        }
        
        public delegate System.Text.StringBuilder AppendFilenameDelegate(System.Text.StringBuilder sb, AphidParserException exception);
    }
}

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static FromTokenDelegate _FromToken;
        
        public static FromTokenDelegate FromToken {
            get {
                if ((ParserErrorMessage._FromToken == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._FromToken;
            }
            set {
                ParserErrorMessage._FromToken = value;
            }
        }
        
        public delegate string FromTokenDelegate(string code, AphidParserException exception, bool highlight);
    }
}

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static AppendPositionAndExcerptDelegate _AppendPositionAndExcerpt;
        
        public static AppendPositionAndExcerptDelegate AppendPositionAndExcerpt {
            get {
                if ((ParserErrorMessage._AppendPositionAndExcerpt == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._AppendPositionAndExcerpt;
            }
            set {
                ParserErrorMessage._AppendPositionAndExcerpt = value;
            }
        }
        
        public delegate System.Text.StringBuilder AppendPositionAndExcerptDelegate(System.Text.StringBuilder sb, string code, int index, bool highlight);
    }
}

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static AppendPositionDelegate _AppendPosition;
        
        public static AppendPositionDelegate AppendPosition {
            get {
                if ((ParserErrorMessage._AppendPosition == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._AppendPosition;
            }
            set {
                ParserErrorMessage._AppendPosition = value;
            }
        }
        
        public delegate System.Text.StringBuilder AppendPositionDelegate(System.Text.StringBuilder sb, string code, int index, bool highlight);
    }
}

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static AppendExcerptDelegate _AppendExcerpt;
        
        public static AppendExcerptDelegate AppendExcerpt {
            get {
                if ((ParserErrorMessage._AppendExcerpt == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca());
                }
                return ParserErrorMessage._AppendExcerpt;
            }
            set {
                ParserErrorMessage._AppendExcerpt = value;
            }
        }
        
        public delegate System.Text.StringBuilder AppendExcerptDelegate(System.Text.StringBuilder sb, string code, int index, bool highlight);
    }
}

namespace Components.Aphid.Parser
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ByteCode_37b23a98bc84ab0bcae3d96e99e0b1ca()
        {
            return             new List<AphidExpression>
            {
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
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
                            "Parser",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
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
                            "Lexer",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
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
                            "UI",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
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
                                "UI",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Formatters",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "System",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "System",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Text",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Std'"
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "ParserErrorMessage",
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
                            "FromExpression",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "code",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "exception",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidParserException",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "highlight",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "bool",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sb",
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
                                new UnaryOperatorExpression(
                                    AphidTokenType.newKeyword,
                                    new CallExpression(
                                        new IdentifierExpression(
                                            "StringBuilder",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    false
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Append",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exception",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.CustomOperator316,
                                            new IdentifierExpression(
                                                "Message",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.CustomOperator313,
                                        new StringExpression(
                                            "'Unexpected parser error '"
                                        )
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "exp",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "exception",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.CustomOperator316,
                                    new IdentifierExpression(
                                        "Expression",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ParserErrorMessage",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendFilename",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "exception",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ParserErrorMessage",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendPositionAndExcerpt",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exp",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.CustomOperator316,
                                            new IdentifierExpression(
                                                "Code",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.CustomOperator313,
                                        new IdentifierExpression(
                                            "code",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "exp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.CustomOperator316,
                                        new IdentifierExpression(
                                            "Index",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new IdentifierExpression(
                                        "highlight",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "sb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
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
                            "ParserErrorMessage",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "StringBuilder",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendFilename",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "sb",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "StringBuilder",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "exception",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidParserException",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exception",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.CustomOperator316,
                                            new IdentifierExpression(
                                                "Expression",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.CustomOperator316,
                                        new IdentifierExpression(
                                            "Filename",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.PipelineOperator,
                                    new PartialFunctionExpression(
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "sb",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "AppendFormat",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new PatternMatchingExpression(
                                                    new ImplicitArgumentExpression(
                                                        AphidTokenType.ImplicitArgumentOperator
                                                    ),
                                                    new List<PatternExpression>
                                                    {
                                                        new PatternExpression(
                                                            new StringExpression(
                                                                "\"\""
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new NullExpression(
                                                                ),
                                                            }
                                                        ),
                                                        new PatternExpression(
                                                            new StringExpression(
                                                                "\" in script '{0}'\""
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                            }
                                        )
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
                            "ParserErrorMessage",
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
                            "FromToken",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "code",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "exception",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidParserException",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "highlight",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "bool",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sb",
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
                                new UnaryOperatorExpression(
                                    AphidTokenType.newKeyword,
                                    new CallExpression(
                                        new IdentifierExpression(
                                            "StringBuilder",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    false
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendFormat",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "\"Unexpected {0} '{1}'\""
                                    ),
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exception",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "UnexpectedToken",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "TokenType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "ToString",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "ToLower",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exception",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "UnexpectedToken",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Lexeme",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                }
                            ),
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "exception",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ExpectedToken",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.NotEqualOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "AphidTokenType",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "None",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "sb",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "AppendFormat",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new StringExpression(
                                                "\" expected {0}\""
                                            ),
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "exception",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "ExpectedToken",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                        }
                                    ),
                                },
                                null
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ParserErrorMessage",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendPositionAndExcerpt",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "code",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exception",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "UnexpectedToken",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Index",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new IdentifierExpression(
                                        "highlight",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "sb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
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
                            "ParserErrorMessage",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "StringBuilder",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendPositionAndExcerpt",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "sb",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "StringBuilder",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "code",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "index",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "int",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "highlight",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "bool",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "ParserErrorMessage",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "AppendPosition",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "ParserErrorMessage",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "AppendExcerpt",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                    }
                                ),
                                AphidTokenType.SelectOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new CallExpression(
                                                new ImplicitArgumentExpression(
                                                    AphidTokenType.ImplicitArgumentOperator
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "sb",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "code",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "index",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "highlight",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            ),
                                            false
                                        ),
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "sb",
                                    new List<IdentifierExpression>
                                    {
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
                            "ParserErrorMessage",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "StringBuilder",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendPosition",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "sb",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "StringBuilder",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "code",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "index",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "int",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "highlight",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "bool",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "line",
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
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "TokenHelper",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "GetIndexPosition",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "code",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new IdentifierExpression(
                                                    "index",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        )
                                    ),
                                    AphidTokenType.NotEqualOperator,
                                    new NullExpression(
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "sb",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "AppendFormat",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new StringExpression(
                                                "\" on line {0:n0}, column {1:n0}, \""
                                            ),
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "line",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Item1",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.AdditionOperator,
                                                new NumberExpression(
                                                    1
                                                )
                                            ),
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "line",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Item2",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                        }
                                    ),
                                },
                                new List<AphidExpression>
                                {
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "sb",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new StringExpression(
                                                "'at '"
                                            ),
                                        }
                                    ),
                                }
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendFormat",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "'offset {0:n0} '"
                                    ),
                                    new IdentifierExpression(
                                        "index",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "sb",
                                    new List<IdentifierExpression>
                                    {
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
                            "ParserErrorMessage",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "StringBuilder",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendExcerpt",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "sb",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "StringBuilder",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "code",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "index",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "int",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "highlight",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "bool",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "e",
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
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "TokenHelper",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "GetCodeExcerpt",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "code",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "index",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new NumberExpression(
                                            4
                                        ),
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "String",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "IsNullOrEmpty",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "e",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "sb",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new BinaryOperatorExpression(
                                        new TernaryOperatorExpression(
                                            AphidTokenType.ConditionalOperator,
                                            new IdentifierExpression(
                                                "highlight",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "SyntaxHighlightingFormatter",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Format",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "e",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            ),
                                            new IdentifierExpression(
                                                "e",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.PipelineOperator,
                                        new PartialFunctionExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "sb",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "AppendFormat",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new StringExpression(
                                                        "'\r\n\r\n{0}\r\n'"
                                                    ),
                                                }
                                            )
                                        )
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


