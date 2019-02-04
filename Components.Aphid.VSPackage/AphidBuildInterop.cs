using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.VSPackage {
    
    
    public partial class AphidBuildInterop {
        
        private static CompileDelegate _Compile;
        
        public static CompileDelegate Compile {
            get {
                if ((AphidBuildInterop._Compile == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_bc79b1c90375a7efa721519452f6737c());
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
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ByteCode_bc79b1c90375a7efa721519452f6737c()
        {
            return             new List<AphidExpression>
            {
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta/Code/Compiler'"
                    )
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
                            "VSPackage",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidBuildInterop",
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
                            "Compile",
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
                                "path",
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
                                "input",
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
                                "namespace",
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
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "aphidCompiler",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "compileCode",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "namespace",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "input",
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
            }
;
        }
    }
}


