using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.Parser {
    
    
    public partial class AphidByteCodeCache {
        
        private static CompileAstToBytesDelegate _CompileAstToBytes;
        
        public static CompileAstToBytesDelegate CompileAstToBytes {
            get {
                if ((AphidByteCodeCache._CompileAstToBytes == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_1dbb56881cdd987eea05a4de1af605a0());
                }
                return AphidByteCodeCache._CompileAstToBytes;
            }
            set {
                AphidByteCodeCache._CompileAstToBytes = value;
            }
        }
        
        public delegate System.Array CompileAstToBytesDelegate(System.Collections.IEnumerable block);
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

                    public static List<AphidExpression> ByteCode_1dbb56881cdd987eea05a4de1af605a0() =>
                        ByteCode_1dbb56881cdd987eea05a4de1af605a0Lazy.Value;

                    private static readonly List<AphidExpression> _empty = new List<AphidExpression>();                    

                    private static System.Lazy<List<AphidExpression>> ByteCode_1dbb56881cdd987eea05a4de1af605a0Lazy =>
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
    new BinaryOperatorExpression(
        new BinaryOperatorExpression(
            new BinaryOperatorExpression(
                new IdentifierExpression(
                    "AphidConfig",
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Current",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "ScriptCaching",
                _IdentifierExpressions
            )
        ),
        AphidTokenType.AssignmentOperator,
        new BooleanExpression(
            false
        )
    ),
    new LoadScriptExpression(
        new StringExpression(
            "'Std'"
        )
    ),
    new LoadScriptExpression(
        new StringExpression(
            "'Meta/Code/Compiler'"
        )
    ),
    new BinaryOperatorExpression(
        new BinaryOperatorExpression(
            new BinaryOperatorExpression(
                new IdentifierExpression(
                    "AphidConfig",
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Current",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "ScriptCaching",
                _IdentifierExpressions
            )
        ),
        AphidTokenType.AssignmentOperator,
        new BooleanExpression(
            true
        )
    ),
    new BinaryOperatorExpression(
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "AphidByteCodeCache",
                new List<IdentifierExpression>
                {
                    new IdentifierExpression(
                        "export",
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "Array",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "CompileAstToBytes",
                _IdentifierExpressions
            )
        ),
        AphidTokenType.AssignmentOperator,
        new FunctionExpression(
            new List<AphidExpression>
            {
                new IdentifierExpression(
                    "block",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "IEnumerable",
                            _IdentifierExpressions
                        ),
                    }
                ),
            },
            new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "name",
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
                        new StringExpression(
                            "'AphidLibrary.Compiled'"
                        ),
                        AphidTokenType.AdditionOperator,
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "Guid",
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "NewGuid",
                                                    _IdentifierExpressions
                                                )
                                            ),
                                            _AphidExpressions
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
                                    "Replace",
                                    _IdentifierExpressions
                                )
                            ),
                            new List<AphidExpression>
                            {
                                new StringExpression(
                                    "'-'"
                                ),
                                new StringExpression(
                                    "''"
                                ),
                            }
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "cs",
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
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "csharp",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "fromAst",
                                    _IdentifierExpressions
                                )
                            ),
                            new List<AphidExpression>
                            {
                                new IdentifierExpression(
                                    "name",
                                    _IdentifierExpressions
                                ),
                                new StringExpression(
                                    "'GetAst'"
                                ),
                                new IdentifierExpression(
                                    "block",
                                    _IdentifierExpressions
                                ),
                            }
                        ),
                        AphidTokenType.PipelineOperator,
                        new FunctionExpression(
                            _AphidExpressions,
                            new List<AphidExpression>
                            {
                                new UnaryOperatorExpression(
                                    AphidTokenType.retKeyword,
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new ImplicitArgumentExpression(
                                                AphidTokenType.ImplicitArgumentOperator
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
                    )
                ),
                new CallExpression(
                    new IdentifierExpression(
                        "printInfo",
                        _IdentifierExpressions
                    ),
                    new List<AphidExpression>
                    {
                        new StringExpression(
                            "'Compiling CS'"
                        ),
                    }
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "csharp",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "params",
                            _IdentifierExpressions
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new CallExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "csharp",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "createDefaultParams",
                                _IdentifierExpressions
                            )
                        ),
                        _AphidExpressions
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "csharp",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "params",
                                _IdentifierExpressions
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GenerateInMemory",
                            _IdentifierExpressions
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BooleanExpression(
                        false
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "csFile",
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
                        new IdentifierExpression(
                            "getEntryPath",
                            _IdentifierExpressions
                        ),
                        new List<AphidExpression>
                        {
                            new StringExpression(
                                "'library'"
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "name",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.AdditionOperator,
                                new StringExpression(
                                    "'.cs'"
                                )
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "cs",
                        _IdentifierExpressions
                    ),
                    AphidTokenType.PipelineOperator,
                    new PartialFunctionExpression(
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "io",
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "out",
                                        _IdentifierExpressions
                                    )
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "text",
                                    _IdentifierExpressions
                                )
                            ),
                            new List<AphidExpression>
                            {
                                new IdentifierExpression(
                                    "csFile",
                                    _IdentifierExpressions
                                ),
                            }
                        )
                    )
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "csharp",
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "compileAsmFromFiles",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new ArrayExpression(
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "csFile",
                                                    _IdentifierExpressions
                                                ),
                                            }
                                        ),
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "CompiledAssembly",
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Location",
                                _IdentifierExpressions
                            )
                        ),
                        AphidTokenType.PipelineOperator,
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "io",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "bytes",
                                _IdentifierExpressions
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

                    
                        private static readonly List<IdentifierExpression> _IdentifierExpressions = new List<IdentifierExpression>();
                    
                        private static readonly List<AphidExpression> _AphidExpressions = new List<AphidExpression>();
                    

                    
                    
                
                }
            }
            

