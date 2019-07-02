namespace BuiltInLibrary.Library.Cli
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Out()
        {
            return             new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "strOut",
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
                                "func",
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
                                        "IO",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
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
                                    new ThisExpression(
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new DynamicMemberExpression(
                                        new StringExpression(
                                            "'$aphid'"
                                        )
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "prev",
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
                                        "a",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Out",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
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
                            new UsingExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "sw",
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
                                                "StringWriter",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "sb",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        false
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "a",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Out",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new IdentifierExpression(
                                            "sw",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new CallExpression(
                                        new IdentifierExpression(
                                            "func",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "a",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Out",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "prev",
                                    new List<IdentifierExpression>
                                    {
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
                            "Collections",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "outStack",
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
                                "Stack",
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
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "beginOut",
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
                                        "IO",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
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
                                    new ThisExpression(
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new DynamicMemberExpression(
                                        new StringExpression(
                                            "'$aphid'"
                                        )
                                    )
                                )
                            ),
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sw",
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
                                            "StringWriter",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "sb",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    false
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "outStack",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Push",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new ObjectExpression(
                                        new List<BinaryOperatorExpression>
                                        {
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "prev",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.ColonOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "a",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Out",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                )
                                            ),
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "sb",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.ColonOperator,
                                                new IdentifierExpression(
                                                    "sb",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "sw",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.ColonOperator,
                                                new IdentifierExpression(
                                                    "sw",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                        },
                                        null
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "a",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Out",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "sw",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "endOut",
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
                                    new ThisExpression(
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new DynamicMemberExpression(
                                        new StringExpression(
                                            "'$aphid'"
                                        )
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "ctx",
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
                                            "outStack",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Pop",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "a",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Out",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ctx",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "prev",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "ctx",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "sw",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
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
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "ctx",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "sb",
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
