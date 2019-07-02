namespace BuiltInLibrary.Library
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> IO()
        {
            return             new List<AphidExpression>
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
                            "IO",
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
                new BinaryOperatorBodyExpression(
                    AphidTokenType.CustomOperator185,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "lhs",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "rhs",
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
                                        "lhs",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.PipelineOperator,
                                    new PartialFunctionExpression(
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "io",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "end",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "rhs",
                                                    new List<IdentifierExpression>
                                                    {
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
                new BinaryOperatorBodyExpression(
                    AphidTokenType.CustomOperator262,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "path",
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
                                        "path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.BinaryOrOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "io",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "full",
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
                new BinaryOperatorBodyExpression(
                    AphidTokenType.CustomOperator259,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "path",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "pattern",
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
                                            "Directory",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "EnumerateFiles",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "path",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new TernaryOperatorExpression(
                                            AphidTokenType.ConditionalOperator,
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new IdentifierExpression(
                                                    "pattern",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                true
                                            ),
                                            new IdentifierExpression(
                                                "pattern",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new StringExpression(
                                                "'*'"
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "SearchOption",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "TopDirectoryOnly",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorBodyExpression(
                    AphidTokenType.CustomOperator209,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "path",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "pattern",
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
                                            "Directory",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "EnumerateFiles",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "path",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new TernaryOperatorExpression(
                                            AphidTokenType.ConditionalOperator,
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new IdentifierExpression(
                                                    "pattern",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                true
                                            ),
                                            new IdentifierExpression(
                                                "pattern",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new StringExpression(
                                                "'*'"
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "SearchOption",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "AllDirectories",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
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
                        "io",
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
                                    "dir",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Directory",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Exists",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "file",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Exists",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "cd",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "path",
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
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new IdentifierExpression(
                                                        "path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Directory",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "SetCurrentDirectory",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "path",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Directory",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "GetCurrentDirectory",
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
                                            false
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "files",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Directory",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "EnumerateFiles",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "dirs",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Directory",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "EnumerateDirectories",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "all",
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
                                                "files",
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
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
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
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
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
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
                                                                            new ArrayAccessExpression(
                                                                                new ImplicitArgumentsExpression(
                                                                                    AphidTokenType.ImplicitArgumentsOperator
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        1
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new NumberExpression(
                                                                            2
                                                                        ),
                                                                    }
                                                                ),
                                                                new PatternExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.throwKeyword,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.newKeyword,
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "ArgumentException",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'io.all.files() expects one to three arguments'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        false
                                                                    ),
                                                                    new List<AphidExpression>
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
                                                "dirs",
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
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
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
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
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
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
                                                                            new ArrayAccessExpression(
                                                                                new ImplicitArgumentsExpression(
                                                                                    AphidTokenType.ImplicitArgumentsOperator
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        1
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new NumberExpression(
                                                                            2
                                                                        ),
                                                                    }
                                                                ),
                                                                new PatternExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.throwKeyword,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.newKeyword,
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "ArgumentException",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'io.all.dirs() expects one to three arguments'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        false
                                                                    ),
                                                                    new List<AphidExpression>
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
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "find",
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
                                                "files",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
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
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new ImplicitArgumentExpression(
                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateFiles",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new ArrayAccessExpression(
                                                                                new ImplicitArgumentsExpression(
                                                                                    AphidTokenType.ImplicitArgumentsOperator
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        1
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new ImplicitArgumentExpression(
                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new NumberExpression(
                                                                            2
                                                                        ),
                                                                    }
                                                                ),
                                                                new PatternExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.throwKeyword,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.newKeyword,
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "ArgumentException",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'io.find.files() expects one to three arguments'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        false
                                                                    ),
                                                                    new List<AphidExpression>
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
                                                "dirs",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'*'"
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
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
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            ),
                                                                            new ImplicitArgumentExpression(
                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Directory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EnumerateDirectories",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new ArrayAccessExpression(
                                                                                new ImplicitArgumentsExpression(
                                                                                    AphidTokenType.ImplicitArgumentsOperator
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        1
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new ImplicitArgumentExpression(
                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "SearchOption",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AllDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new NumberExpression(
                                                                            2
                                                                        ),
                                                                    }
                                                                ),
                                                                new PatternExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.throwKeyword,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.newKeyword,
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "ArgumentException",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'io.find.dirs() expects one to three arguments'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        false
                                                                    ),
                                                                    new List<AphidExpression>
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
                                                "file",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'*'"
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
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
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ArrayAccessExpression(
                                                                                    new ImplicitArgumentsExpression(
                                                                                        AphidTokenType.ImplicitArgumentsOperator
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new NumberExpression(
                                                                                            1
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new NumberExpression(
                                                                                2
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new PatternExpression(
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.throwKeyword,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ArgumentException",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'io.find.files() expects one to three arguments'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Enumerable",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Single",
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
                                                "dir",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'*'"
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
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
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ArrayAccessExpression(
                                                                                    new ImplicitArgumentsExpression(
                                                                                        AphidTokenType.ImplicitArgumentsOperator
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new NumberExpression(
                                                                                            1
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new NumberExpression(
                                                                                2
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new PatternExpression(
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.throwKeyword,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ArgumentException",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'io.find.dirs() expects one to three arguments'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Enumerable",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Single",
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
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "first",
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
                                                "file",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'*'"
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
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
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateFiles",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ArrayAccessExpression(
                                                                                    new ImplicitArgumentsExpression(
                                                                                        AphidTokenType.ImplicitArgumentsOperator
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new NumberExpression(
                                                                                            1
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new NumberExpression(
                                                                                2
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new PatternExpression(
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.throwKeyword,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ArgumentException",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'io.find.file() expects zero to two arguments'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Enumerable",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "FirstOrDefault",
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
                                                "dir",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "pattern",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "path",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'*'"
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
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
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'.'"
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Directory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "EnumerateDirectories",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ArrayAccessExpression(
                                                                                    new ImplicitArgumentsExpression(
                                                                                        AphidTokenType.ImplicitArgumentsOperator
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new NumberExpression(
                                                                                            1
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "SearchOption",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "AllDirectories",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new NumberExpression(
                                                                                2
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new PatternExpression(
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.throwKeyword,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ArgumentException",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'io.find.dir() expects zero to two arguments'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Enumerable",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "FirstOrDefault",
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
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "bytes",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ReadAllBytes",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "lines",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ReadAllLines",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "text",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ReadAllText",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "txt",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "text",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "out",
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
                                                "bytes",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "WriteAllBytes",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lines",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "WriteAllLines",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "text",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "WriteAllText",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "txt",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new IdentifierExpression(
                                                "text",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "append",
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
                                                            "text",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "File",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "AppendAllText",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "txt",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new IdentifierExpression(
                                                            "text",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "line",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "line",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "file",
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
                                                                            "text",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "line",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AdditionOperator,
                                                                                new StringExpression(
                                                                                    "'\\r\\n'"
                                                                                )
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "file",
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
                                                            "lines",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "File",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "AppendAllLines",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                },
                                                null
                                            )
                                        ),
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "add",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "out",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "append",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "del",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Delete",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "rd",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Directory",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Delete",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "len",
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
                                            new BinaryOperatorExpression(
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.newKeyword,
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "FileInfo",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new ImplicitArgumentExpression(
                                                                AphidTokenType.ImplicitArgumentOperator
                                                            ),
                                                        }
                                                    ),
                                                    false
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Length",
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
                                    "size",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "len",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "parent",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetDirectoryName",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "up",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "parent",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "name",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetFileName",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "base",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetFileNameWithoutExtension",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "full",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetFullPath",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "attrs",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetAttributes",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "ext",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "pathOrExt",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "newExt",
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
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new IdentifierExpression(
                                                        "pathOrExt",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new TernaryOperatorExpression(
                                                    AphidTokenType.ConditionalOperator,
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new IdentifierExpression(
                                                            "newExt",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        true
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Path",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "ChangeExtension",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "newExt",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "pathOrExt",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Path",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "GetExtension",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "pathOrExt",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.throwKeyword,
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.newKeyword,
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "ArgumentException",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'Function io.ext() expects one or two arguments'"
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    ),
                                                    false
                                                )
                                            ),
                                            false
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "tmp",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetTempPath",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "rnd",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetTempFileName",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "copy",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Copy",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "cp",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "copy",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "move",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Move",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "mov",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "move",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "mv",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "move",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "created",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetCreationTime",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "date",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "created",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "accessed",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetLastAccessTime",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "last",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "accessed",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "modified",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "File",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetLastWriteTime",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "touched",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "modified",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "drives",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Directory",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetLogicalDrives",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "append",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "rhs",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "lhs",
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
                                                        "Path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Combine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "lhs",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "rhs",
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
                                    "suffix",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "append",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "tail",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "append",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "end",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "append",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "pre",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "lhs",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "rhs",
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
                                                        "Path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Combine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "lhs",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "rhs",
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
                                    "prefix",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "pre",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "prepend",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "pre",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "head",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "pre",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "start",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "pre",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "concat",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Path",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Combine",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "join",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new IdentifierExpression(
                                    "concat",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "local",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "f",
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
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.newKeyword,
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "Uri",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "f",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    false
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "___p_op_0",
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
                                                                    "___p_op_0",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "IsFile",
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
                                            false
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "remote",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "f",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new UnaryOperatorExpression(
                                                AphidTokenType.NotOperator,
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "local",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "f",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
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
                                    "open",
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
                                                "create",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Create",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "read",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "OpenRead",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "write",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "OpenWrite",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "share",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "path",
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
                                                                    "File",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Open",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "path",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "FileMode",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "OpenOrCreate",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "FileAccess",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "ReadWrite",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "FileShare",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "ReadWrite",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
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
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "File",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "AppendText",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                    },
                                    null
                                )
                            ),
                        },
                        null
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "isDir",
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
                            "io",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "dir",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "isFile",
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
                            "io",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "file",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "dirExists",
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
                            "io",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "dir",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "fileExists",
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
                            "io",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "file",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    )
                ),
            }
;
        }
    }
}
