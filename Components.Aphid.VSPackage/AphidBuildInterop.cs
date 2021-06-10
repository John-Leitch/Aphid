using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.VSPackage {
    
    
    public partial class AphidBuildInterop {
        
        private static CompileDelegate _Compile;
        
        public static CompileDelegate Compile {
            get {
                if ((AphidBuildInterop._Compile == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_2f0f0c4cd802a69c613461c6f0091e01());
                }
                return AphidBuildInterop._Compile;
            }
            set {
                AphidBuildInterop._Compile = value;
            }
        }
        
        public delegate string CompileDelegate(string path, string input, string @namespace);
    }
}


            namespace Components.Aphid.VSPackage
            {
                /* Test */
                using global::Components.Aphid.Lexer;
                using global::Components.Aphid.Parser;
                using System;
                using System.Collections.Generic;
            
                public static partial class AphidCompilerResources
                {
                    
                    /*fmt*/

                    public static List<AphidExpression> ByteCode_2f0f0c4cd802a69c613461c6f0091e01() =>
                        ByteCode_2f0f0c4cd802a69c613461c6f0091e01Lazy.Value;

                    private static readonly List<AphidExpression> _empty = new List<AphidExpression>();                    

                    private static System.Lazy<List<AphidExpression>> ByteCode_2f0f0c4cd802a69c613461c6f0091e01Lazy =>
                        new System.Lazy<List<AphidExpression>>(() =>
                            new List<AphidExpression>
{
    new LoadScriptExpression(
        new StringExpression(
            "'std'"
        )
    ),
    new LoadScriptExpression(
        new StringExpression(
            "'meta/code/Compiler'"
        )
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
                "VSPackage",
                _IdentifierExpressions
            )
        ),
        false
    ),
    new CallExpression(
        new IdentifierExpression(
            "print",
            _IdentifierExpressions
        ),
        new List<AphidExpression>
        {
            new StringExpression(
                "'foo'"
            ),
        }
    ),
    new BinaryOperatorExpression(
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "AphidBuildInterop",
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
                "Compile",
                _IdentifierExpressions
            )
        ),
        AphidTokenType.AssignmentOperator,
        new FunctionExpression(
            new List<AphidExpression>
            {
                new IdentifierExpression(
                    "path",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "input",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
                new IdentifierExpression(
                    "namespace",
                    new List<IdentifierExpression>
                    {
                        new IdentifierExpression(
                            "string",
                            _IdentifierExpressions
                        ),
                    }
                ),
            },
            new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "preprocessor",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "inlineScripts",
                            _IdentifierExpressions
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BooleanExpression(
                        true
                    )
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.retKeyword,
                    new CallExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "aphidCompiler",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "compileCode",
                                _IdentifierExpressions
                            )
                        ),
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "namespace",
                                _IdentifierExpressions
                            ),
                            new IdentifierExpression(
                                "input",
                                _IdentifierExpressions
                            ),
                        }
                    ),
                    false
                ),
            }
        )
    ),
}

                        );

                    
                        private static readonly List<IdentifierExpression> _IdentifierExpressions = new List<IdentifierExpression>();
                    

                    
                    
                
                }
            }
            

