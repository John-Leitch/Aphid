namespace BuiltInLibrary.Library.Data
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Trees()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "objTree",
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
                new IdentifierExpression(
                    "stringTree",
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
                                    "objTree",
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
                                                "fromArrays",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "arrays",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "root",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "arrays",
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
                                                                    new IdentifierExpression(
                                                                        "root",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new ImplicitArgumentExpression(
                                                                        AphidTokenType.ImplicitArgumentOperator
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
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "r",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.AssignmentOperator,
                                                                                    new TernaryOperatorExpression(
                                                                                        AphidTokenType.ConditionalOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.definedKeyword,
                                                                                                new ArrayAccessExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "r",
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
                                                                                                true
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                        new BinaryOperatorExpression(
                                                                                            new ArrayAccessExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "r",
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
                                                                                            AphidTokenType.AssignmentOperator,
                                                                                            new ObjectExpression(
                                                                                                new List<BinaryOperatorExpression>
                                                                                                {
                                                                                                },
                                                                                                null
                                                                                            )
                                                                                        ),
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "r",
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
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                false
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "root",
                                                            new List<IdentifierExpression>
                                                            {
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
                                    "stringTree",
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
                                                "fromObjTree",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "root",
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
                                                                    "stringTree",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "create",
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
                                                                                "node",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new StringExpression(
                                                                                "'root'"
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "children",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "root",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new FunctionExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "n",
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
                                                                                    "n",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "node",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            false
                                                                        ),
                                                                    }
                                                                ),
                                                                new FunctionExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "n",
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
                                                                                        new IdentifierExpression(
                                                                                            "n",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "children",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Keys",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.SelectOperator,
                                                                                new FunctionExpression(
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "k",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    },
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.retKeyword,
                                                                                            new ObjectExpression(
                                                                                                new List<BinaryOperatorExpression>
                                                                                                {
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "node",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.ColonOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "k",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "children",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.ColonOperator,
                                                                                                        new ArrayAccessExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "n",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "children",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                                new IdentifierExpression(
                                                                                                                    "k",
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
                                                                                            false
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            false
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
                                                "fromArrays",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "objTree",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "fromArrays",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.CompositionOperator,
                                                new IdentifierExpression(
                                                    "fromObjTree",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "create",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "root",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "dumpNode",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "getChildren",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
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
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "createCore",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "root",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new IdentifierExpression(
                                                                "dumpNode",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new IdentifierExpression(
                                                                "getChildren",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new IdentifierExpression(
                                                                "sb",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new NumberExpression(
                                                                0
                                                            ),
                                                            new ArrayExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                }
                                                            ),
                                                            new BooleanExpression(
                                                                true
                                                            ),
                                                        }
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "sb",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
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
                                                        false
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "createCore",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "node",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "dumpNode",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "getChildren",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "sb",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "indent",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "depths",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "lastChild",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new NumberExpression(
                                                                0
                                                            ),
                                                            AphidTokenType.RangeOperator,
                                                            new IdentifierExpression(
                                                                "indent",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.SelectOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "i",
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
                                                                                "sb",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Append",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new TernaryOperatorExpression(
                                                                                AphidTokenType.ConditionalOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "ai",
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
                                                                                                "i",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.EqualityOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "indent",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MinusOperator,
                                                                                                new NumberExpression(
                                                                                                    1
                                                                                                )
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.AndOperator,
                                                                                    new IdentifierExpression(
                                                                                        "lastChild",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new StringExpression(
                                                                                    "\"└\""
                                                                                ),
                                                                                new TernaryOperatorExpression(
                                                                                    AphidTokenType.ConditionalOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "hd",
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
                                                                                                    new UnaryOperatorExpression(
                                                                                                        AphidTokenType.PostfixCountOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "depths",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        false
                                                                                                    ),
                                                                                                    AphidTokenType.GreaterThanOperator,
                                                                                                    new NumberExpression(
                                                                                                        0
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.AndOperator,
                                                                                            new IdentifierExpression(
                                                                                                "ai",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AndOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.PostfixLastOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "depths",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                false
                                                                                            ),
                                                                                            AphidTokenType.EqualityOperator,
                                                                                            new IdentifierExpression(
                                                                                                "i",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new StringExpression(
                                                                                        "\"├\""
                                                                                    ),
                                                                                    new TernaryOperatorExpression(
                                                                                        AphidTokenType.ConditionalOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "hd",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.AndOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "depths",
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
                                                                                                                    "i",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            false
                                                                                                        ),
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                        new StringExpression(
                                                                                            "\"│\""
                                                                                        ),
                                                                                        new StringExpression(
                                                                                            "\" \""
                                                                                        )
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "node",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.BinaryOrOperator,
                                                            new IdentifierExpression(
                                                                "dumpNode",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.BinaryOrOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "sb",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "AppendLine",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "nodes",
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
                                                                    "node",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.BinaryOrOperator,
                                                                new IdentifierExpression(
                                                                    "getChildren",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.SelectOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "c",
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
                                                                            "createCore",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "c",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "dumpNode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "getChildren",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "sb",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "indent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AdditionOperator,
                                                                                new NumberExpression(
                                                                                    1
                                                                                )
                                                                            ),
                                                                            new TernaryOperatorExpression(
                                                                                AphidTokenType.ConditionalOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "lc",
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
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.PostfixLastOperator,
                                                                                            new IdentifierExpression(
                                                                                                "nodes",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                        AphidTokenType.BinaryOrOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "c",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Equals",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "depths",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "aq",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "concat",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "depths",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new ArrayExpression(
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "indent",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "lc",
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
