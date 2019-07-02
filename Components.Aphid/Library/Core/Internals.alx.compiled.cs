namespace BuiltInLibrary.Library.Core
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Internals()
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
                            "Interpreter",
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
                            "Threading",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
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
                    new TernaryOperatorExpression(
                        AphidTokenType.ConditionalOperator,
                        new UnaryOperatorExpression(
                            AphidTokenType.definedKeyword,
                            new BinaryOperatorExpression(
                                new ThisExpression(
                                ),
                                AphidTokenType.MemberOperator,
                                new DynamicMemberExpression(
                                    new StringExpression(
                                        "'$aphid'"
                                    )
                                )
                            ),
                            true
                        ),
                        new BinaryOperatorExpression(
                            new ThisExpression(
                            ),
                            AphidTokenType.MemberOperator,
                            new DynamicMemberExpression(
                                new StringExpression(
                                    "'$aphid'"
                                )
                            )
                        ),
                        new NullExpression(
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "getBlock",
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
                                        new ThisExpression(
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new DynamicMemberExpression(
                                            new StringExpression(
                                                "'$parent'"
                                            )
                                        )
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new DynamicMemberExpression(
                                        new StringExpression(
                                            "'$block'"
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
                        "parseArgsFor",
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
                                    "q",
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
                                    new IdentifierExpression(
                                        "getArgQueue",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new ImplicitArgumentsExpression(
                                            AphidTokenType.ImplicitArgumentsOperator
                                        ),
                                        AphidTokenType.PipelineOperator,
                                        new PartialFunctionExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "Enumerable",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Concat",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new TernaryOperatorExpression(
                                                        AphidTokenType.ConditionalOperator,
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.definedKeyword,
                                                            new BinaryOperatorExpression(
                                                                new ThisExpression(
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new DynamicMemberExpression(
                                                                    new StringExpression(
                                                                        "'$script'"
                                                                    )
                                                                )
                                                            ),
                                                            true
                                                        ),
                                                        new ArrayExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new ArrayExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'.alx'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'.exe'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "''"
                                                                            ),
                                                                        }
                                                                    ),
                                                                    AphidTokenType.SelectOperator,
                                                                    new FunctionExpression(
                                                                        new List<AphidExpression>
                                                                        {
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new ThisExpression(
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new DynamicMemberExpression(
                                                                                                new StringExpression(
                                                                                                    "'$script'"
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
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
                                                                                    AphidTokenType.PipelineOperator,
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
                                                                                                                    "'{0}{1}'"
                                                                                                                ),
                                                                                                                new ImplicitArgumentExpression(
                                                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                                                ),
                                                                                                                new IdentifierExpression(
                                                                                                                    "e",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
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
                                                            }
                                                        ),
                                                        new ArrayExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                }
                                            )
                                        )
                                    ),
                                    AphidTokenType.PipelineOperator,
                                    new PartialFunctionExpression(
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "Enumerable",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Concat",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new ArrayExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new ArrayExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "''"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'32'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'64'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'.debug'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'32.debug'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'64.debug'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'.binarytrace'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'.binarytrace32'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'.binarytrace64'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'ui'"
                                                                            ),
                                                                            new StringExpression(
                                                                                "'-debug'"
                                                                            ),
                                                                        }
                                                                    ),
                                                                    AphidTokenType.SelectOperator,
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
                                                                                new StringExpression(
                                                                                    "'aphid{0}'"
                                                                                ),
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                AphidTokenType.SelectManyOperator,
                                                                new FunctionExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new ArrayExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new ImplicitArgumentExpression(
                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new ImplicitArgumentExpression(
                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                        ),
                                                                                        AphidTokenType.AdditionOperator,
                                                                                        new StringExpression(
                                                                                            "'portable'"
                                                                                        )
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.SelectManyOperator,
                                                            new FunctionExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.retKeyword,
                                                                        new ArrayExpression(
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new ImplicitArgumentExpression(
                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                    ),
                                                                                    AphidTokenType.AdditionOperator,
                                                                                    new StringExpression(
                                                                                        "'.exe'"
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        false
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                            }
                                        )
                                    )
                                ),
                                AphidTokenType.SelectOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new ImplicitArgumentExpression(
                                                AphidTokenType.ImplicitArgumentOperator
                                            ),
                                            AphidTokenType.BinaryOrOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "q",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "matchPath",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "q",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "args",
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
                        "getArgQueue",
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
                                    "args",
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
                                                "Queue",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "ArgToken",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "Environment",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "CommandLine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "ArgLexer",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "GetTokenInfo",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                )
                                            ),
                                        }
                                    ),
                                    false
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "v",
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
                                            new TernaryOperatorExpression(
                                                AphidTokenType.ConditionalOperator,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "args",
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
                                                    AphidTokenType.GreaterThanOperator,
                                                    new NumberExpression(
                                                        0
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "args",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Peek",
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
                                                        "Value",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
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
                                    "matchPath",
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
                                                "argPath",
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
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "v",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
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
                                                                AphidTokenType.PipelineOperator,
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
                                                            false
                                                        ),
                                                    }
                                                ),
                                                AphidTokenType.CustomOperator317,
                                                new NullExpression(
                                                )
                                            )
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new ImplicitArgumentsExpression(
                                                    AphidTokenType.ImplicitArgumentsOperator
                                                ),
                                                AphidTokenType.AnyOperator,
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "p",
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
                                                                    "p",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AnyOperator,
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
                                                                                AphidTokenType.EqualityOperator,
                                                                                new IdentifierExpression(
                                                                                    "argPath",
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
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "args",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Dequeue",
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
                                                    new BooleanExpression(
                                                        true
                                                    ),
                                                    false
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new BooleanExpression(
                                                        false
                                                    ),
                                                    false
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new ObjectExpression(
                                    new List<BinaryOperatorExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "args",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new IdentifierExpression(
                                                "args",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "matchPath",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new IdentifierExpression(
                                                "matchPath",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                    },
                                    null
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "env",
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
                                    "expand",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Environment",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ExpandEnvironmentVariables",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "get",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Environment",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetEnvironmentVariable",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "set",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Environment",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "SetEnvironmentVariable",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "vars",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Environment",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "GetEnvironmentVariables",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "__test",
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
                                        new GatorCloseExpression(
                                        ),
                                        new TextExpression(
                                            "\r\n        #'Testing\\\\AopTest';        \r\n        \r\n        _te = macro(@(n, p) {\r\n            expand group;\r\n            isTrue; @{ ('%{0}%' :: n) | env.expand ~= p };\r\n            isFalse; @{ n | env.expand ~= p };\r\n\r\n            get group;\r\n            isTrue;\r\n            @{ n | env.get ~= p };\r\n            @{ 'BadFake' | env.get == null };\r\n            \r\n            isFalse;\r\n            @{ ('BadFake' | env.get) ?? 'BadFake' ~= p };\r\n\r\n            vars group;\r\n            isTrue; @{ env.vars() =?@()$_.Key.ToLower() == n.ToLower() };\r\n            isFalse; @{ !(env.vars() =?@()$_.Key.ToLower() == n.ToLower()) };\r\n        });\r\n\r\n        _te('SystemDrive', '^[a-zA-Z]:$');\r\n        _te('WinDir', '^[a-zA-Z]:(\\\\\\\\[a-zA-Z0-9]+)*$');        \r\n    "
                                        ),
                                        new GatorOpenExpression(
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
