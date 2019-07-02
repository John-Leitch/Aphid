namespace BuiltInLibrary.Library.Core
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ClrSerializer()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "clrSerializer",
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
                new CallExpression(
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "rootScope",
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
                                    new StringExpression(
                                        "'$parent'"
                                    )
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
                            new UnaryOperatorExpression(
                                AphidTokenType.usingKeyword,
                                new BinaryOperatorExpression(
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
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Generic",
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
                                        "Linq",
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
                                    "Components",
                                    new List<IdentifierExpression>
                                    {
                                    }
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
                                        "TypeSystem",
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
                                new IdentifierExpression(
                                    "toArray",
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
                                        "Enumerable",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ToArray",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "toStr",
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "toInt",
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
                                        "Convert",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ToInt32",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "format",
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
                                        "string",
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "camelCase",
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
                                            "s",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new TernaryOperatorExpression(
                                                AphidTokenType.ConditionalOperator,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "s",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Length",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.GreaterThanOperator,
                                                    new NumberExpression(
                                                        0
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new ArrayAccessExpression(
                                                                new IdentifierExpression(
                                                                    "s",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new NumberExpression(
                                                                        0
                                                                    ),
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
                                                    AphidTokenType.AdditionOperator,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "s",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Substring",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new NumberExpression(
                                                                1
                                                            ),
                                                        }
                                                    )
                                                ),
                                                new StringExpression(
                                                    "''"
                                                )
                                            ),
                                            false
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "highlight",
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
                                            AphidTokenType.retKeyword,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new ImplicitArgumentExpression(
                                                            AphidTokenType.ImplicitArgumentOperator
                                                        ),
                                                        AphidTokenType.BinaryOrOperator,
                                                        new IdentifierExpression(
                                                            "toStr",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
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
                                            false
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "clrSerializer",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ObjectExpression(
                                    new List<BinaryOperatorExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "maxDepth",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new NumberExpression(
                                                1
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "map",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "clrObj",
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
                                                                    "internal",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "mapCore",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.newKeyword,
                                                                    new CallExpression(
                                                                        new ArrayAccessExpression(
                                                                            new IdentifierExpression(
                                                                                "List",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "Object",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "internal",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "nextRefTable",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "clrObj",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "serialize",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "map",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.CompositionOperator,
                                                new IdentifierExpression(
                                                    "toStr",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dump",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "map",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.CompositionOperator,
                                                new IdentifierExpression(
                                                    "highlight",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dumpe",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "map",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.CompositionOperator,
                                                new IdentifierExpression(
                                                    "highlight",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "internal",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new ObjectExpression(
                                                new List<BinaryOperatorExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "nextRefTable",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.newKeyword,
                                                                        new CallExpression(
                                                                            new ArrayAccessExpression(
                                                                                new IdentifierExpression(
                                                                                    "Dictionary",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "Object",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new IdentifierExpression(
                                                                                        "Object",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.newKeyword,
                                                                                    new CallExpression(
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "ReferenceEqualityComparer",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "Object",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    false
                                                                                ),
                                                                            }
                                                                        ),
                                                                        false
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "genericEnumerable",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Type",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "GetType",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'System.Collections.Generic.IEnumerable`1'"
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "error",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new ObjectExpression(
                                                            new List<BinaryOperatorExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "id",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new NumberExpression(
                                                                        0
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "verbosity",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new NumberExpression(
                                                                        1
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "next",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new FunctionExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "msg",
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
                                                                                    new IdentifierExpression(
                                                                                        "format",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'clrDump Error #{1:n0}: {0}'"
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "msg",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "toInt",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.IncrementOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "id",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    true
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "maxDepth",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new FunctionExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "d",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "d",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
                                                                                        new PartialFunctionExpression(
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "format",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new TernaryOperatorExpression(
                                                                                                        AphidTokenType.ConditionalOperator,
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "verbosity",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                            new NumberExpression(
                                                                                                                1
                                                                                                            )
                                                                                                        ),
                                                                                                        new StringExpression(
                                                                                                            "'Max depth of {0} reached'"
                                                                                                        ),
                                                                                                        new StringExpression(
                                                                                                            "'Max depth reached'"
                                                                                                        )
                                                                                                    ),
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new IdentifierExpression(
                                                                                        "next",
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
                                                                    new IdentifierExpression(
                                                                        "getValue",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new FunctionExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "t",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "p",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new BinaryOperatorExpression(
                                                                                    new CallExpression(
                                                                                        new IdentifierExpression(
                                                                                            "format",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new StringExpression(
                                                                                                "'Call to {0}{1}GetValue failed{2}{3}'"
                                                                                            ),
                                                                                            new TernaryOperatorExpression(
                                                                                                AphidTokenType.ConditionalOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "verbosity",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                    new NumberExpression(
                                                                                                        4
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "t",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "FullName",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                    new StringExpression(
                                                                                                        "'.'"
                                                                                                    )
                                                                                                ),
                                                                                                new TernaryOperatorExpression(
                                                                                                    AphidTokenType.ConditionalOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "verbosity",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                        new NumberExpression(
                                                                                                            3
                                                                                                        )
                                                                                                    ),
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "t",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "Name",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        AphidTokenType.AdditionOperator,
                                                                                                        new StringExpression(
                                                                                                            "'.'"
                                                                                                        )
                                                                                                    ),
                                                                                                    new StringExpression(
                                                                                                        "''"
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            new TernaryOperatorExpression(
                                                                                                AphidTokenType.ConditionalOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "verbosity",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                    new NumberExpression(
                                                                                                        2
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "p",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "Name",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                    new StringExpression(
                                                                                                        "'.'"
                                                                                                    )
                                                                                                ),
                                                                                                new StringExpression(
                                                                                                    "''"
                                                                                                )
                                                                                            ),
                                                                                            new TernaryOperatorExpression(
                                                                                                AphidTokenType.ConditionalOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "verbosity",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                    new NumberExpression(
                                                                                                        1
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new StringExpression(
                                                                                                        "', '"
                                                                                                    ),
                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                    new CallExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "camelCase",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "e",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "message",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new StringExpression(
                                                                                                    "''"
                                                                                                )
                                                                                            ),
                                                                                            new TernaryOperatorExpression(
                                                                                                AphidTokenType.ConditionalOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "verbosity",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                    new NumberExpression(
                                                                                                        5
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new StringExpression(
                                                                                                        "'\\r\\n'"
                                                                                                    ),
                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "e",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "exception",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    )
                                                                                                ),
                                                                                                new StringExpression(
                                                                                                    "''"
                                                                                                )
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new IdentifierExpression(
                                                                                        "next",
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
                                                            },
                                                            null
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "mapCore",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "depth",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "traversed",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "references",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "clrObj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "dprint",
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
                                                                                        "Linq",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                false
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "umsg",
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
                                                                                new PatternMatchingExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new ImplicitArgumentsExpression(
                                                                                            AphidTokenType.ImplicitArgumentsOperator
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Count",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<PatternExpression>
                                                                                    {
                                                                                        new PatternExpression(
                                                                                            new StringExpression(
                                                                                                "''"
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new NumberExpression(
                                                                                                    0
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new PatternExpression(
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new ImplicitArgumentExpression(
                                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                                        ),
                                                                                                        AphidTokenType.CustomOperator319,
                                                                                                        new StringExpression(
                                                                                                            "''"
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
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new NumberExpression(
                                                                                                    1
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new PatternExpression(
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "format",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new ImplicitArgumentExpression(
                                                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                                                ),
                                                                                                                AphidTokenType.CustomOperator319,
                                                                                                                new StringExpression(
                                                                                                                    "''"
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
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new ImplicitArgumentsExpression(
                                                                                                            AphidTokenType.ImplicitArgumentsOperator
                                                                                                        ),
                                                                                                        AphidTokenType.PipelineOperator,
                                                                                                        new PartialFunctionExpression(
                                                                                                            new CallExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "skip",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                new List<AphidExpression>
                                                                                                                {
                                                                                                                    new NumberExpression(
                                                                                                                        1
                                                                                                                    ),
                                                                                                                }
                                                                                                            )
                                                                                                        )
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "format",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'{0}[Depth: ~Cyan~{1}~R~] ~Magenta~{2}~R~: {3}'"
                                                                                        ),
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.newKeyword,
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "string",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new StringExpression(
                                                                                                        "' '"
                                                                                                    ),
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "depth",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "int",
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
                                                                                            false
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "depth",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new TernaryOperatorExpression(
                                                                                            AphidTokenType.ConditionalOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "clrObj",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.NotEqualOperator,
                                                                                                new NullExpression(
                                                                                                )
                                                                                            ),
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "clrObj",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "GetType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new StringExpression(
                                                                                                "'null'"
                                                                                            )
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "umsg",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "Cli",
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
                                                                new IfExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.NotOperator,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.definedKeyword,
                                                                            new IdentifierExpression(
                                                                                "traceClrDump",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            true
                                                                        ),
                                                                        false
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "dprint",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new FunctionExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "dprint",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'mapCore started'"
                                                                        ),
                                                                    }
                                                                ),
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "clrObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new NullExpression(
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new NullExpression(
                                                                            ),
                                                                            false
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "t",
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
                                                                                "clrObj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "GetType",
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
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "t",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "IsPrimitive",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.OrOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "t",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "IsEnum",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            AphidTokenType.OrOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "t",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.EqualityOperator,
                                                                                new IdentifierExpression(
                                                                                    "Decimal",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        AphidTokenType.OrOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "t",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.EqualityOperator,
                                                                            new IdentifierExpression(
                                                                                "string",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new IdentifierExpression(
                                                                                "clrObj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IfExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "depth",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.GreaterThanOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "clrSerializer",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "maxDepth",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "dprint",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'~Yellow~Max depth reached~R~'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.retKeyword,
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "clrSerializer",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "maxDepth",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.BinaryOrOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "error",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "maxDepth",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    false
                                                                                ),
                                                                            },
                                                                            null
                                                                        ),
                                                                    }
                                                                ),
                                                                new IfExpression(
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "isCycle",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "depth",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "traversed",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "clrObj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "dprint",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'~Yellow~Cyclical property detected, mapCore finished~R~'"
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "references",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "get_Item",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "clrObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new IdentifierExpression(
                                                                                "clrObj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "traversed",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Add",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "clrObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "dprint",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'~Cyan~{0:n0}~R~ objects traversed'"
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "traversed",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Count",
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
                                                                                "t",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.NotEqualOperator,
                                                                            new IdentifierExpression(
                                                                                "string",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.AndOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "t",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.NotEqualOperator,
                                                                            new IdentifierExpression(
                                                                                "AphidObject",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "cpy",
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
                                                                            new NullExpression(
                                                                            )
                                                                        ),
                                                                        new IfExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "t",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "GetInterfaces",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AnyOperator,
                                                                                new FunctionExpression(
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                    },
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.retKeyword,
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new ImplicitArgumentExpression(
                                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "IsGenericType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AndOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new ImplicitArgumentExpression(
                                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "GetGenericTypeDefinition",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.EqualityOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "genericEnumerable",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "dprint",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'Serializing IEnumerable[T]'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpy",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.AssignmentOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "clrObj",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.BinaryOrOperator,
                                                                                        new IdentifierExpression(
                                                                                            "toArray",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                            },
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IfExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "t",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "GetInterface",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "IEnumerable",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.NotEqualOperator,
                                                                                        new NullExpression(
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "dprint",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new StringExpression(
                                                                                                    "'Serializing IEnumerable'"
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "cpy",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.AssignmentOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "clrObj",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
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
                                                                                                            new ImplicitArgumentExpression(
                                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                                            ),
                                                                                                            false
                                                                                                        ),
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                    },
                                                                                    null
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new IfExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "cpy",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.NotEqualOperator,
                                                                                new NullExpression(
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "l",
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
                                                                                            new ArrayAccessExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "List",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IdentifierExpression(
                                                                                                        "Object",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        false
                                                                                    )
                                                                                ),
                                                                                new ForEachExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpy",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new BinaryOperatorExpression(
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "mapCore",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "depth",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.AdditionOperator,
                                                                                                        new NumberExpression(
                                                                                                            1
                                                                                                        )
                                                                                                    ),
                                                                                                    new IdentifierExpression(
                                                                                                        "traversed",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new IdentifierExpression(
                                                                                                        "references",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new ImplicitArgumentExpression(
                                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.BinaryOrOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "l",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "Add",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                    },
                                                                                    null
                                                                                ),
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "references",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Add",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "clrObj",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "l",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.retKeyword,
                                                                                    new IdentifierExpression(
                                                                                        "l",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    false
                                                                                ),
                                                                            },
                                                                            null
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "mappedObj",
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
                                                                        },
                                                                        null
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "references",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Add",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "clrObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new IdentifierExpression(
                                                                            "mappedObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                new ForEachExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "clrObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "GetType",
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
                                                                                "GetProperties",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "dprint",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'Reading property {0}.{1}'"
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "p",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "DeclaringType",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "p",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "success",
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
                                                                            new BooleanExpression(
                                                                                false
                                                                            )
                                                                        ),
                                                                        new IdentifierExpression(
                                                                            "val",
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
                                                                        new TryExpression(
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "val",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.AssignmentOperator,
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "p",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "GetValue",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "clrObj",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "success",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.AssignmentOperator,
                                                                                    new BooleanExpression(
                                                                                        true
                                                                                    )
                                                                                ),
                                                                            },
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "dprint",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'~Yellow~Dump Error: {0}~R~'"
                                                                                        ),
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "e",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "message",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "val",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.AssignmentOperator,
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "error",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "getValue",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "t",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new IdentifierExpression(
                                                                                                "p",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new IdentifierExpression(
                                                                                                "e",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    )
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
                                                                                new IdentifierExpression(
                                                                                    "success",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "mapCore",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "depth",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.AdditionOperator,
                                                                                            new NumberExpression(
                                                                                                1
                                                                                            )
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "traversed",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "references",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "val",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "val",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "dprint",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'{0} reading property {1}.{2}~R~'"
                                                                                ),
                                                                                new TernaryOperatorExpression(
                                                                                    AphidTokenType.ConditionalOperator,
                                                                                    new IdentifierExpression(
                                                                                        "success",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new StringExpression(
                                                                                        "'~Green~Succeeded'"
                                                                                    ),
                                                                                    new StringExpression(
                                                                                        "'~Red~Failed'"
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "p",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "DeclaringType",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "p",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new ArrayAccessExpression(
                                                                                new IdentifierExpression(
                                                                                    "mappedObj",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "p",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Name",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new IdentifierExpression(
                                                                                "r",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    new IdentifierExpression(
                                                                        "p",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "dprint",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'mapCore finished'"
                                                                        ),
                                                                    }
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new IdentifierExpression(
                                                                        "mappedObj",
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
                                                        new IdentifierExpression(
                                                            "isCycle",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "depth",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "traversed",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "clrObj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "traversed",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.AnyOperator,
                                                                        new FunctionExpression(
                                                                            new List<AphidExpression>
                                                                            {
                                                                            },
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.retKeyword,
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "Object",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "ReferenceEquals",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                            ),
                                                                                            new IdentifierExpression(
                                                                                                "clrObj",
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "isAttached",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "serializer",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "serializer",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "MapClrObject",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.NotEqualOperator,
                                                                        new NullExpression(
                                                                        )
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "attach",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "serializer",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "serializer",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "MapClrObject",
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
                                                                                "x",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "d",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "t",
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
                                                                                    new IdentifierExpression(
                                                                                        "mapCore",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "d",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.newKeyword,
                                                                                            new CallExpression(
                                                                                                new ArrayAccessExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "List",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new List<AphidExpression>
                                                                                                    {
                                                                                                        new IdentifierExpression(
                                                                                                            "Object",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "nextRefTable",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "x",
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
                                                        )
                                                    ),
                                                },
                                                null
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "enableClrDump",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new LoadScriptExpression(
                                                        new StringExpression(
                                                            "'System/Config'"
                                                        )
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.definedKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "aphidConfig",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "useClrSerializeForDump",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                true
                                                            ),
                                                            AphidTokenType.AndOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "aphidConfig",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "useClrSerializeForDump",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "aphid",
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
                                                                    new StringExpression(
                                                                        "'$aphid'"
                                                                    )
                                                                )
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "s",
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
                                                                        "aphid",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Serializer",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            new IfExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "s",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.BinaryOrOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "internal",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "isAttached",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    AphidTokenType.EqualityOperator,
                                                                    new BooleanExpression(
                                                                        false
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "s",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.BinaryOrOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "internal",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "attach",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                },
                                                                null
                                                            ),
                                                        },
                                                        null
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.definedKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "aphidConfig",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "useClrSerializeForReplOut",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                true
                                                            ),
                                                            AphidTokenType.AndOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "aphidConfig",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "useClrSerializeForReplOut",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IfExpression(
                                                                new BinaryOperatorExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "rootScope",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dumpSerializer",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        true
                                                                    ),
                                                                    AphidTokenType.EqualityOperator,
                                                                    new BooleanExpression(
                                                                        false
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
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
                                                                            new IdentifierExpression(
                                                                                "rootScope",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dumpSerializer",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SerializingFormatter",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "CreateSerializer",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "aphid",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                },
                                                                null
                                                            ),
                                                            new IfExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "rootScope",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dumpSerializer",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.BinaryOrOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "internal",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "isAttached",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    AphidTokenType.EqualityOperator,
                                                                    new BooleanExpression(
                                                                        false
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "rootScope",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dumpSerializer",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.BinaryOrOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "internal",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "attach",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                },
                                                                null
                                                            ),
                                                        },
                                                        null
                                                    ),
                                                }
                                            )
                                        ),
                                    },
                                    null
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "clrSerializer",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "enableClrDump",
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
                    new List<AphidExpression>
                    {
                    }
                ),
            }
;
        }
    }
}
