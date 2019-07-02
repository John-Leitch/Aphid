namespace BuiltInLibrary.Library.Cli
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Repl()
        {
            return             new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "repl",
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
                    new ObjectExpression(
                        new List<BinaryOperatorExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "run",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "scope",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "aphidScope",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "a",
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
                                                    "aphidScope",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new DynamicMemberExpression(
                                                    new StringExpression(
                                                        "'$aphid'"
                                                    )
                                                )
                                            )
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new IdentifierExpression(
                                                        "a",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                AphidTokenType.AndOperator,
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new IdentifierExpression(
                                                        "scope",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "a",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "SetInitialScope",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "scope",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "r",
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
                                            new TernaryOperatorExpression(
                                                AphidTokenType.ConditionalOperator,
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new IdentifierExpression(
                                                        "a",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.newKeyword,
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "AphidRepl",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "a",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    false
                                                ),
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.newKeyword,
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "AphidRepl",
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
                                            )
                                        ),
                                        new TryExpression(
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "r",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Run",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                ),
                                            },
                                            null,
                                            null,
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "r",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Dispose",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                        },
                        null
                    )
                ),
            }
;
        }
    }
}
