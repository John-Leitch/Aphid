using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.Parser {
    
    
    public partial class ParserErrorMessage {
        
        private static FromExpressionDelegate _FromExpression;
        
        public static FromExpressionDelegate FromExpression {
            get {
                if ((ParserErrorMessage._FromExpression == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_c30ca71051b15c3d6b7fe56936b22b37());
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
                /* Test */
                using global::Components.Aphid.Lexer;
                using global::Components.Aphid.Parser;
                using System;
                using System.Collections.Generic;
            
                public static partial class AphidCompilerResources
                {
                    
                    /*fmt*/

                    public static List<AphidExpression> ByteCode_c30ca71051b15c3d6b7fe56936b22b37() =>
                        ByteCode_c30ca71051b15c3d6b7fe56936b22b37Lazy.Value;

                    //private static readonly List<AphidExpression> _empty = new List<AphidExpression>();                    

                    private static System.Lazy<List<AphidExpression>> ByteCode_c30ca71051b15c3d6b7fe56936b22b37Lazy =>
                        new System.Lazy<List<AphidExpression>>(() =>
                            new List<AphidExpression>
{
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new BinaryOperatorExpression(
                new IdentifierExpression(
                    "Components",
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Aphid",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Parser",
                _IdentifierExpressions
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
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Aphid",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Lexer",
                _IdentifierExpressions
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
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Aphid",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "UI",
                _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    AphidTokenType.MemberOperator,
                    new IdentifierExpression(
                        "Aphid",
                        _IdentifierExpressions
                    )
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "UI",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Formatters",
                _IdentifierExpressions
            )
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new IdentifierExpression(
            "System",
            _IdentifierExpressions
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "System",
                _IdentifierExpressions
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Text",
                _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "FromExpression",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "exception",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "AphidParserException",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "highlight",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "bool",
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new UnaryOperatorExpression(
                        AphidTokenType.newKeyword,
                        new CallExpression(
                            new IdentifierExpression(
                                "StringBuilder",
                                _IdentifierExpressions
                            ),
                            _AphidExpressions
                        ),
                        false
                    )
                ),
                new CallExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Append",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "exception",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.CustomOperator316,
                                new IdentifierExpression(
                                    "Message",
                                    _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "exception",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.CustomOperator316,
                        new IdentifierExpression(
                            "Expression",
                            _IdentifierExpressions
                        )
                    )
                ),
                new CallExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "ParserErrorMessage",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendFilename",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        new IdentifierExpression(
                            "exception",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new CallExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "ParserErrorMessage",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendPositionAndExcerpt",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "exp",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.CustomOperator316,
                                new IdentifierExpression(
                                    "Code",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.CustomOperator313,
                            new IdentifierExpression(
                                "code",
                                _IdentifierExpressions
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "exp",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.CustomOperator316,
                            new IdentifierExpression(
                                "Index",
                                _IdentifierExpressions
                            )
                        ),
                        new IdentifierExpression(
                            "highlight",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    new CallExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "sb",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ToString",
                                _IdentifierExpressions
                            )
                        ),
                        _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "StringBuilder",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "AppendFilename",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "exception",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "AphidParserException",
                            _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.CustomOperator316,
                                new IdentifierExpression(
                                    "Expression",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.CustomOperator316,
                            new IdentifierExpression(
                                "Filename",
                                _IdentifierExpressions
                            )
                        ),
                        AphidTokenType.PipelineOperator,
                        new PartialFunctionExpression(
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "sb",
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AppendFormat",
                                        _IdentifierExpressions
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
                                                    _NullExpression,
                                                }
                                            ),
                                            new PatternExpression(
                                                new StringExpression(
                                                    "\" in script '{0}'\""
                                                ),
                                                _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "FromToken",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "exception",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "AphidParserException",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "highlight",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "bool",
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new UnaryOperatorExpression(
                        AphidTokenType.newKeyword,
                        new CallExpression(
                            new IdentifierExpression(
                                "StringBuilder",
                                _IdentifierExpressions
                            ),
                            _AphidExpressions
                        ),
                        false
                    )
                ),
                new CallExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendFormat",
                            _IdentifierExpressions
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
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "UnexpectedToken",
                                                    _IdentifierExpressions
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "TokenType",
                                                _IdentifierExpressions
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    _AphidExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "ToLower",
                                    _IdentifierExpressions
                                )
                            ),
                            _AphidExpressions
                        ),
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "exception",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "UnexpectedToken",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Lexeme",
                                _IdentifierExpressions
                            )
                        ),
                    }
                ),
                new IfExpression(
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "exception",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ExpectedToken",
                                _IdentifierExpressions
                            )
                        ),
                        AphidTokenType.NotEqualOperator,
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AphidTokenType",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "None",
                                _IdentifierExpressions
                            )
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sb",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "AppendFormat",
                                    _IdentifierExpressions
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
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ExpectedToken",
                                        _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendPositionAndExcerpt",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        new IdentifierExpression(
                            "code",
                            _IdentifierExpressions
                        ),
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "exception",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "UnexpectedToken",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Index",
                                _IdentifierExpressions
                            )
                        ),
                        new IdentifierExpression(
                            "highlight",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    new CallExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "sb",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ToString",
                                _IdentifierExpressions
                            )
                        ),
                        _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "StringBuilder",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "AppendPositionAndExcerpt",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "code",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "index",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "int",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "highlight",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "bool",
                            _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "AppendPosition",
                                    _IdentifierExpressions
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "ParserErrorMessage",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "AppendExcerpt",
                                    _IdentifierExpressions
                                )
                            ),
                        }
                    ),
                    AphidTokenType.SelectOperator,
                    new FunctionExpression(
                        _AphidExpressions,
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
                                            _IdentifierExpressions
                                        ),
                                        new IdentifierExpression(
                                            "code",
                                            _IdentifierExpressions
                                        ),
                                        new IdentifierExpression(
                                            "index",
                                            _IdentifierExpressions
                                        ),
                                        new IdentifierExpression(
                                            "highlight",
                                            _IdentifierExpressions
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
                        _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "StringBuilder",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "AppendPosition",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "code",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "index",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "int",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "highlight",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "bool",
                            _IdentifierExpressions
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
                                        _IdentifierExpressions
                                    ),
                                }
                            ),
                            AphidTokenType.AssignmentOperator,
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "TokenHelper",
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetIndexPosition",
                                        _IdentifierExpressions
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "code",
                                        _IdentifierExpressions
                                    ),
                                    new IdentifierExpression(
                                        "index",
                                        _IdentifierExpressions
                                    ),
                                }
                            )
                        ),
                        AphidTokenType.NotEqualOperator,
                        _NullExpression
                    ),
                    new List<AphidExpression>
                    {
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sb",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "AppendFormat",
                                    _IdentifierExpressions
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
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Item1",
                                            _IdentifierExpressions
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
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Item2",
                                        _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "Append",
                                    _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AppendFormat",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new StringExpression(
                            "'offset {0:n0} '"
                        ),
                        new IdentifierExpression(
                            "index",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    new IdentifierExpression(
                        "sb",
                        _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "StringBuilder",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "AppendExcerpt",
                _IdentifierExpressions
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
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "code",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "index",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "int",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "highlight",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "bool",
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new CallExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "TokenHelper",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "GetCodeExcerpt",
                                _IdentifierExpressions
                            )
                        ),
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "code",
                                _IdentifierExpressions
                            ),
                            new IdentifierExpression(
                                "index",
                                _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "IsNullOrEmpty",
                                    _IdentifierExpressions
                                )
                            ),
                            new List<AphidExpression>
                            {
                                new IdentifierExpression(
                                    "e",
                                    _IdentifierExpressions
                                ),
                            }
                        ),
                        new IdentifierExpression(
                            "sb",
                            _IdentifierExpressions
                        ),
                        new BinaryOperatorExpression(
                            new TernaryOperatorExpression(
                                AphidTokenType.ConditionalOperator,
                                new IdentifierExpression(
                                    "highlight",
                                    _IdentifierExpressions
                                ),
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "SyntaxHighlightingFormatter",
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Format",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "e",
                                            _IdentifierExpressions
                                        ),
                                    }
                                ),
                                new IdentifierExpression(
                                    "e",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.PipelineOperator,
                            new PartialFunctionExpression(
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "sb",
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "AppendFormat",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'\\r\\n\\r\\n{0}\\r\\n'"
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

                        );

                    
                        //private static readonly List<IdentifierExpression> _IdentifierExpressions = new List<IdentifierExpression>();
                    
                        //private static readonly List<AphidExpression> _AphidExpressions = new List<AphidExpression>();
                    

                    
                        private static readonly NullExpression _NullExpression = new NullExpression();
                    
                    
                
                }
            }
            

