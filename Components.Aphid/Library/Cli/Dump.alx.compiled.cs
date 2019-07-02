namespace BuiltInLibrary.Library.Cli
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Dump()
        {
            return             new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "stdScope",
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
                    new ThisExpression(
                    )
                ),
                new IfExpression(
                    new UnaryOperatorExpression(
                        AphidTokenType.NotOperator,
                        new UnaryOperatorExpression(
                            AphidTokenType.definedKeyword,
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "stdScope",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "dump",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            true
                        ),
                        false
                    ),
                    new List<AphidExpression>
                    {
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "stdScope",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "dump",
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
                                        "o",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                },
                                new List<AphidExpression>
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
                                                    "External",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "ConsolePlus",
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
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "o",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.BinaryOrOperator,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new ThisExpression(
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new StringExpression(
                                                                "'$aphid'"
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Serializer",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Serialize",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                )
                                            ),
                                            AphidTokenType.BinaryOrOperator,
                                            new TernaryOperatorExpression(
                                                AphidTokenType.ConditionalOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "VT100",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "IsEnabled",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
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
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
                                                            new ImplicitArgumentExpression(
                                                                AphidTokenType.ImplicitArgumentOperator
                                                            ),
                                                            false
                                                        ),
                                                    }
                                                )
                                            )
                                        ),
                                        AphidTokenType.BinaryOrOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "Console",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "WriteLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        )
                                    ),
                                }
                            )
                        ),
                    },
                    null
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "dumpe",
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
                        },
                        new List<AphidExpression>
                        {
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
                            new BinaryOperatorExpression(
                                new ImplicitArgumentExpression(
                                    AphidTokenType.ImplicitArgumentOperator
                                ),
                                AphidTokenType.PipelineOperator,
                                new IdentifierExpression(
                                    "dump",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Environment",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Exit",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new NumberExpression(
                                        0
                                    ),
                                }
                            ),
                        }
                    )
                ),
            }
;
        }
    }
}
