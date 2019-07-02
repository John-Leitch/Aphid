namespace BuiltInLibrary.Library
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Math()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "permutations",
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
                                    "toName",
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
                                                    AphidTokenType.AdditionOperator,
                                                    new NumberExpression(
                                                        97
                                                    )
                                                ),
                                                false
                                            ),
                                        }
                                    ),
                                    AphidTokenType.CompositionOperator,
                                    new FunctionExpression(
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "___p_op_1",
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
                                                        "___p_op_1",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.BinaryOrOperator,
                                                    new BinaryOperatorExpression(
                                                        new ImplicitArgumentExpression(
                                                            AphidTokenType.ImplicitArgumentOperator
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "char",
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "permutations",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "sets",
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
                                                    AphidTokenType.PostfixCountOperator,
                                                    new IdentifierExpression(
                                                        "sets",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    false
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "count",
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
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new ArrayExpression(
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new NumberExpression(
                                                                                                        0
                                                                                                    ),
                                                                                                    AphidTokenType.RangeOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "count",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MinusOperator,
                                                                                                        new NumberExpression(
                                                                                                            1
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
                                                                                                                        AphidTokenType.BinaryOrOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "toName",
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
                                                                                                            "'sets[{0}]-<@({1})'"
                                                                                                        ),
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                        new ArrayExpression(
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "count",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MinusOperator,
                                                                                                        new NumberExpression(
                                                                                                            1
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
                                                                                                                    new IdentifierExpression(
                                                                                                                        "format",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                        new StringExpression(
                                                                                                                            "'sets[{0}]->@({1}) [{2}]'"
                                                                                                                        ),
                                                                                                                        new ImplicitArgumentExpression(
                                                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                                                        ),
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new ImplicitArgumentExpression(
                                                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                                                            ),
                                                                                                                            AphidTokenType.BinaryOrOperator,
                                                                                                                            new IdentifierExpression(
                                                                                                                                "toName",
                                                                                                                                new List<IdentifierExpression>
                                                                                                                                {
                                                                                                                                }
                                                                                                                            )
                                                                                                                        ),
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                    new NumberExpression(
                                                                                                                                        0
                                                                                                                                    ),
                                                                                                                                    AphidTokenType.RangeOperator,
                                                                                                                                    new IdentifierExpression(
                                                                                                                                        "count",
                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                        {
                                                                                                                                        }
                                                                                                                                    )
                                                                                                                                ),
                                                                                                                                AphidTokenType.SelectOperator,
                                                                                                                                new IdentifierExpression(
                                                                                                                                    "toName",
                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                    {
                                                                                                                                    }
                                                                                                                                )
                                                                                                                            ),
                                                                                                                            AphidTokenType.PipelineOperator,
                                                                                                                            new PartialFunctionExpression(
                                                                                                                                new CallExpression(
                                                                                                                                    new IdentifierExpression(
                                                                                                                                        "join",
                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                        {
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    new List<AphidExpression>
                                                                                                                                    {
                                                                                                                                        new StringExpression(
                                                                                                                                            "', '"
                                                                                                                                        ),
                                                                                                                                    }
                                                                                                                                )
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
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new PartialFunctionExpression(
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "join",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "' '"
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            )
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
                                                                                    new StringExpression(
                                                                                        "'@(sets) {0}'"
                                                                                    ),
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new IdentifierExpression(
                                                                        "evalExp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.PipelineOperator,
                                                                new FunctionExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "x",
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
                                                                                    "sets",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.BinaryOrOperator,
                                                                                new IdentifierExpression(
                                                                                    "x",
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
                                            false
                                        ),
                                    }
                                )
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
