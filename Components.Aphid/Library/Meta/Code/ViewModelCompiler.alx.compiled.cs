namespace BuiltInLibrary.Library.Meta.Code
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ViewModelCompiler()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "viewModel",
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
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'Meta\\\\Code\\\\Generation\\\\StringEmitter'"
                                )
                            ),
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'Meta\\\\Code\\\\Syntax\\\\CodeDom'"
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
                                        "Lexer",
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
                                        "Parser",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "e",
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
                                    "strEmitter",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "inNamespace",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BooleanExpression(
                                    false
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "inClass",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BooleanExpression(
                                    false
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "classAspects",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ObjectExpression(
                                    new List<BinaryOperatorExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "public",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BooleanExpression(
                                                true
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "partial",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BooleanExpression(
                                                true
                                            )
                                        ),
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "propertyAspects",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ObjectExpression(
                                    new List<BinaryOperatorExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "public",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BooleanExpression(
                                                true
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "silent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BooleanExpression(
                                                false
                                            )
                                        ),
                                    },
                                    null
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "aliases",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new NullExpression(
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "boolConverter",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "boolConverterNames",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "lastPropertyName",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new NullExpression(
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "lastOnChangeName",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new NullExpression(
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "onChangeMap",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "onChangeStatements",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "imports",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitUnaryOperatorExpression",
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
                                            "exp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "exp",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Operator",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.EqualityOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "AphidTokenType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "usingKeyword",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "e",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "imports",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "add",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Operand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitBinaryOperatorExpression",
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
                                            "exp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "isStatement",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new IdentifierExpression(
                                                "isStatement",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IfExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Operator",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.EqualityOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "AphidTokenType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "AssignmentOperator",
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
                                                                    AphidTokenType.NotOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "exp",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "lhs",
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
                                                                                "isId",
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
                                                                AphidTokenType.OrOperator,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.NotOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "exp",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "lhs",
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
                                                                                "oneAttr",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "alias",
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
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "fatal",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'Expected id with alias attr on lhs of exp: {0}'"
                                                                        ),
                                                                        new IdentifierExpression(
                                                                            "exp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new ArrayAccessExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "e",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "aliases",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "key",
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
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "exp",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "lhs",
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
                                                                                                "id",
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
                                                                            }
                                                                        ),
                                                                        true
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "fatal",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'Alias {0} already defined'"
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "key",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new ArrayAccessExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "e",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "aliases",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "key",
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
                                                                                        "StringParser",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Parse",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "exp",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "rhs",
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
                                                                                }
                                                                            )
                                                                        ),
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new NullExpression(
                                                                            ),
                                                                            false
                                                                        ),
                                                                    }
                                                                ),
                                                            }
                                                        ),
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                        new IfExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "exp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Operator",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.NotEqualOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "AphidTokenType",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "MemberOperator",
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
                                                                        "fatal",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'Invalid op: {0}'"
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "exp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Operator",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                ),
                                                            },
                                                            null
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "parts",
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
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "GetChildren",
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
                                                    new IdentifierExpression(
                                                        "badParts",
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
                                                            "parts",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.WhereOperator,
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
                                                                                "Type",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.NotEqualOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "AphidExpressionType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "IdentifierExpression",
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
                                                new IfExpression(
                                                    new BinaryOperatorExpression(
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.PostfixCountOperator,
                                                            new IdentifierExpression(
                                                                "badParts",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                        AphidTokenType.NotEqualOperator,
                                                        new NumberExpression(
                                                            0
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "fatal",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'Invalid namespace decl: {0}'"
                                                                ),
                                                                new IdentifierExpression(
                                                                    "exp",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "parts",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.SelectOperator,
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
                                                                            "Identifier",
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
                                                    AphidTokenType.AggregateOperator,
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
                                                                "y",
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
                                                                                "x",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AdditionOperator,
                                                                            new StringExpression(
                                                                                "'.'"
                                                                            )
                                                                        ),
                                                                        AphidTokenType.AdditionOperator,
                                                                        new IdentifierExpression(
                                                                            "y",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new IdentifierExpression(
                                                                        "beginNamespace",
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
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "emitExpression",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "LeftOperand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new BooleanExpression(
                                                            false
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Operator",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "opStr",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "binary",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "get",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new IdentifierExpression(
                                                        "append",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "emitExpression",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "RightOperand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new BooleanExpression(
                                                            false
                                                        ),
                                                    }
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitTernaryOperatorExpression",
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
                                            "exp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "isStatement",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "exp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Operator",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidTokenType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ConditionalOperator",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.OrOperator,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "FirstOperand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidExpressionType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "IdentifierExpression",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "fatal",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Invalid exp: {0}'"
                                                        ),
                                                        new IdentifierExpression(
                                                            "exp",
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
                                                "n",
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "exp",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "FirstOperand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Identifier",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
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
                                            )
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "boolConverterNames",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "add",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "n",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "boolConverter",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new DynamicMemberExpression(
                                                    new IdentifierExpression(
                                                        "n",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "exp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "SecondOperand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "exp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ThirdOperand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                }
                                            )
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new IdentifierExpression(
                                                    "traceVMCompiler",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new ObjectExpression(
                                                            new List<BinaryOperatorExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "boolConverterNames",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new IdentifierExpression(
                                                                        "boolConverterNames",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "boolConverter",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new IdentifierExpression(
                                                                        "boolConverter",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                            },
                                                            null
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new IdentifierExpression(
                                                            "serialize",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new PartialFunctionExpression(
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "print",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'[+] Bool converters updated: {0}'"
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "beginStatement",
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
                                            "object",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "isStatement",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "beginNamespace",
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
                                            "ns",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new IdentifierExpression(
                                                "inNamespace",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "endNamespace",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                ),
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "append",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'\\r\\n'"
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'namespace {0}\\r\\n{{\\r\\n'"
                                                ),
                                                new IdentifierExpression(
                                                    "ns",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "indent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "e",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "imports",
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
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "append",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "margin",
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
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "append",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'using '"
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "emitExpression",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "i",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new BooleanExpression(
                                                                false
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "append",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "';\\r\\n'"
                                                            ),
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "e",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "imports",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Clear",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "e",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "aliases",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                "inNamespace",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BooleanExpression(
                                                true
                                            )
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "endNamespace",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "unindent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'}\\r\\n'"
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "inNamespace",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BooleanExpression(
                                                false
                                            )
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "beginClass",
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
                                            "object",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lastPropertyName",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new NullExpression(
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lastOnChangeName",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new NullExpression(
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "onChangeMap",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "onChangeStatements",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "inClass",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BooleanExpression(
                                                true
                                            )
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "margin",
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
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "classAspects",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "public",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "append",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'public '"
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "classAspects",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "partial",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "append",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'partial '"
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'class {0} : System.ComponentModel.INotifyPropertyChanged\\r\\n'"
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "object",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Identifier",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Identifier",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "margin",
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
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'{\\r\\n'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "indent",
                                                new List<IdentifierExpression>
                                                {
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitObjectExpression",
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
                                            "object",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "isStatement",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "beginClass",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "object",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new IdentifierExpression(
                                                    "isStatement",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "object",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Pairs",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.SelectOperator,
                                            new IdentifierExpression(
                                                "emitProperty",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "onChangeMap",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.SelectOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "m",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "appendLine",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new StringExpression(
                                                                        "'private void '"
                                                                    ),
                                                                    AphidTokenType.AdditionOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "m",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "func",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new StringExpression(
                                                                    "'()'"
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "appendLine",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'{'"
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "indent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                        }
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "onChangeStatements",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.WhereOperator,
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
                                                                                    "func",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.EqualityOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "m",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "func",
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
                                                        AphidTokenType.SelectOperator,
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "c",
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
                                                                            "boolConverter",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new DynamicMemberExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "s",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "converter",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        )
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "append",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "margin",
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
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "append",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'{0} = {1} ? '"
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "s",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dst",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "s",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "condition",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "emitExpression",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new ArrayAccessExpression(
                                                                            new IdentifierExpression(
                                                                                "c",
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
                                                                        new BooleanExpression(
                                                                            false
                                                                        ),
                                                                    }
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "append",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "' : '"
                                                                        ),
                                                                    }
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "emitExpression",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new ArrayAccessExpression(
                                                                            new IdentifierExpression(
                                                                                "c",
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
                                                                        ),
                                                                        new BooleanExpression(
                                                                            false
                                                                        ),
                                                                    }
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "append",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "';\\r\\n'"
                                                                        ),
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "unindent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "appendLine",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'}'"
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "appendLine",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "''"
                                                            ),
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "endClass",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "object",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new IdentifierExpression(
                                                    "isStatement",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "endClass",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "unindent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'\r\n        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;\r\n\r\n        protected void InvokePropertyChanged(\r\n            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)\r\n        {\r\n            if (PropertyChanged != null)\r\n            {\r\n                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(callerName));\r\n            }\r\n        }\r\n\r\n        protected void SetProperty<T>(\r\n            ref T property,\r\n            T value,\r\n            [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)\r\n        {\r\n            property = value;\r\n            InvokePropertyChanged(callerName);\r\n        }'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'\\r\\n{0}}}\\r\\n\\r\\n'"
                                                ),
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "margin",
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
                                            new IdentifierExpression(
                                                "inClass",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BooleanExpression(
                                                false
                                            )
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitProperty",
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
                                            "p",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lhs",
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
                                                    "p",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "LeftOperand",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                    "lhs",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Attributes",
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
                                                        "a",
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
                                                AphidTokenType.EqualityOperator,
                                                new NumberExpression(
                                                    1
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IfExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new IdentifierExpression(
                                                            "traceVMCompiler",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        true
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new ArrayAccessExpression(
                                                                new IdentifierExpression(
                                                                    "a",
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
                                                            AphidTokenType.PipelineOperator,
                                                            new PartialFunctionExpression(
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "print",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'[?] Checking for bool converter \"{0}\"'"
                                                                        ),
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                    },
                                                    null
                                                ),
                                                new IfExpression(
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "boolConverterNames",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "contains",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new ArrayAccessExpression(
                                                                    new IdentifierExpression(
                                                                        "a",
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
                                                                    "Identifier",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IfExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.definedKeyword,
                                                                new IdentifierExpression(
                                                                    "traceVMCompiler",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                true
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new ArrayAccessExpression(
                                                                        new IdentifierExpression(
                                                                            "a",
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
                                                                    AphidTokenType.PipelineOperator,
                                                                    new PartialFunctionExpression(
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "print",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'[+] Bool converter found with name \"{0}\"'"
                                                                                ),
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
                                                                    "onChangeStatements",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "add",
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
                                                                                "func",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "lastOnChangeName",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "dst",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "lhs",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Identifier",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "condition",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "lastPropertyName",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "converter",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "a",
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
                                                                                    "Identifier",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                            }
                                                        ),
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
                                                            new NullExpression(
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
                                                "attrs",
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
                                                    "lhs",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new IdentifierExpression(
                                                    "parseAttributes",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "name",
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
                                                    "lhs",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Identifier",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "field",
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
                                                new StringExpression(
                                                    "'_'"
                                                ),
                                                AphidTokenType.AdditionOperator,
                                                new IdentifierExpression(
                                                    "name",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "margin",
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
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'private '"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "attrs",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "' '"
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "field",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
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
                                                            "RightOperand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Type",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.NotEqualOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "AphidExpressionType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "IdentifierExpression",
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
                                                        "append",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "' = '"
                                                        ),
                                                    }
                                                ),
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "emitExpression",
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
                                                                "RightOperand",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "';\\r\\n\\r\\n'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "margin",
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
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "attrs",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "access",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "' '"
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "attrs",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "' '"
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "name",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "append",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'\\r\\n'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'{'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "indent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'get'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'{'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "indent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new StringExpression(
                                                            "'return '"
                                                        ),
                                                        AphidTokenType.AdditionOperator,
                                                        new IdentifierExpression(
                                                            "field",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "';'"
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "unindent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'}'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'set'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'{'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "indent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "field",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "' = value;'"
                                                    )
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "onChangeName",
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
                                                    new StringExpression(
                                                        "'On'"
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new IdentifierExpression(
                                                        "name",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.AdditionOperator,
                                                new StringExpression(
                                                    "'Changed'"
                                                )
                                            )
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "onChangeMap",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "add",
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
                                                                "prop",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.ColonOperator,
                                                            new IdentifierExpression(
                                                                "name",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "func",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.ColonOperator,
                                                            new IdentifierExpression(
                                                                "onChangeName",
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
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "onChangeName",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "'();'"
                                                    )
                                                ),
                                            }
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.NotOperator,
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "e",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "propertyAspects",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "silent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    false
                                                ),
                                                AphidTokenType.AndOperator,
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.NotOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "attrs",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "silent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    false
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "appendLine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new StringExpression(
                                                                    "'InvokePropertyChanged(\"'"
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new IdentifierExpression(
                                                                    "name",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AdditionOperator,
                                                            new StringExpression(
                                                                "'\");'"
                                                            )
                                                        ),
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "unindent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'}'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "unindent",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "appendLine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'}\\r\\n'"
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lastPropertyName",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "name",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lastOnChangeName",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "onChangeName",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "e",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "emitEnd",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new IdentifierExpression(
                                                "inClass",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "endClass",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new IdentifierExpression(
                                                "inNamespace",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "endNamespace",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                ),
                                            },
                                            null
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "lastAttrTree",
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "parseAttributes",
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
                                            "exp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "exp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Attributes",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Count",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.EqualityOperator,
                                                new NumberExpression(
                                                    0
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new IdentifierExpression(
                                                        "lastAttrTree",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    false
                                                ),
                                            },
                                            null
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lexer",
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
                                                        new IdentifierExpression(
                                                            "exp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Attributes",
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
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Identifier",
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
                                                AphidTokenType.PipelineOperator,
                                                new IdentifierExpression(
                                                    "getLexer",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "resolveAlias",
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
                                                        "name",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.definedKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "e",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "aliasTypes",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    true
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.definedKeyword,
                                                                    new ArrayAccessExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "aliasTypes",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    true
                                                                )
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new ArrayAccessExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "aliasTypes",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "code",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "typeExp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                AphidTokenType.PipelineOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "code",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "cs",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            new TernaryOperatorExpression(
                                                                AphidTokenType.ConditionalOperator,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.definedKeyword,
                                                                    new ArrayAccessExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "aliases",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    true
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new ArrayAccessExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "e",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "aliases",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
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
                                                                            )
                                                                        ),
                                                                        AphidTokenType.PipelineOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "code",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "typeExp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "code",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "cs",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new IdentifierExpression(
                                                                    "name",
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
                                                "attrTree",
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
                                                            "access",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "lexer",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "oneOrNone",
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
                                                                        new StringExpression(
                                                                            "'private'"
                                                                        ),
                                                                        new StringExpression(
                                                                            "'public'"
                                                                        ),
                                                                    }
                                                                ),
                                                                new StringExpression(
                                                                    "'public'"
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "baseType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new BinaryOperatorExpression(
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "lexer",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "take",
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
                                                            new IdentifierExpression(
                                                                "resolveAlias",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "list",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "lexer",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "match",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'list'"
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new TernaryOperatorExpression(
                                                            AphidTokenType.ConditionalOperator,
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.NotOperator,
                                                                new IdentifierExpression(
                                                                    "list",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                false
                                                            ),
                                                            new IdentifierExpression(
                                                                "baseType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new StringExpression(
                                                                    "'ObservableCollection<{0}>'"
                                                                ),
                                                                AphidTokenType.CustomOperator214,
                                                                new IdentifierExpression(
                                                                    "baseType",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "silent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "lexer",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "match",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'silent'"
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
                                                        AphidTokenType.ColonOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "lexer",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "eos",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lastAttrTree",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "attrTree",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "attrTree",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            false
                                        ),
                                    }
                                )
                            ),
                            new CallExpression(
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                    },
                                    new List<AphidExpression>
                                    {
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
                                                        "Colletions",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "viewModel",
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
                                                            "setText",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "sb",
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
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "text",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "typeSuffix",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new StringExpression(
                                                            "'ViewModel'"
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "buildForType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "type",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "code",
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
                                                                            "fromType",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                "type",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "results",
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
                                                                                "csharp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "compileAsm",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "code",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "vmType",
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
                                                                    new ArrayAccessExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "results",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CompiledAssembly",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "GetTypes",
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
                                                                                0
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new IdentifierExpression(
                                                                        "vmType",
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
                                                            "buildForTypes",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "types",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "code",
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
                                                                            new IdentifierExpression(
                                                                                "types",
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
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "fromType",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "namespace",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new ImplicitArgumentExpression(
                                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                                ),
                                                                                            }
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
                                                                                        "'\\r\\n\\r\\n'"
                                                                                    ),
                                                                                }
                                                                            )
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "results",
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
                                                                                "csharp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "compileAsm",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "code",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "vmTypes",
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "results",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "CompiledAssembly",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "GetTypes",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new IdentifierExpression(
                                                                        "vmTypes",
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
                                                            "buildForObject",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "name",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "object",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "code",
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
                                                                            "fromObject",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "object",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "results",
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
                                                                                "csharp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "compileAsm",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "code",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "vmType",
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
                                                                    new ArrayAccessExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "results",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CompiledAssembly",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "GetTypes",
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
                                                                                0
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new IdentifierExpression(
                                                                        "vmType",
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
                                                            "compileCode",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "code",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "aliasTypes",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "text",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Clear",
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
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "code",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new IdentifierExpression(
                                                                                "parse",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.PipelineOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "preprocessor",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "transform",
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
                                                                                    new IdentifierExpression(
                                                                                        "compileAst",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new ImplicitArgumentExpression(
                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "aliasTypes",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "e",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "text",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "compileFile",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new BinaryOperatorExpression(
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
                                                            ),
                                                            AphidTokenType.CompositionOperator,
                                                            new IdentifierExpression(
                                                                "compileCode",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "compileAst",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "ast",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "aliasTypes",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "visitor",
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
                                                                            "createVisitor",
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
                                                                        new IdentifierExpression(
                                                                            "visitor",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "functionExp",
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
                                                                                "func",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IfExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "func",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "Body",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "Count",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.EqualityOperator,
                                                                                            new NumberExpression(
                                                                                                0
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.OrOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new ArrayAccessExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "func",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "Body",
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
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "isId",
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
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.OrOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new ArrayAccessExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "func",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "Body",
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
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "id",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.NotEqualOperator,
                                                                                        new StringExpression(
                                                                                            "'ViewModel'"
                                                                                        )
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
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "func",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Body",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "RemoveAt",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "func",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Body",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "e",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "emit",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "visitor",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "e",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new IdentifierExpression(
                                                                        "e",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new IfExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new IdentifierExpression(
                                                                            "aliasTypes",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        true
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "visitor",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "e",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "aliasTypes",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new IdentifierExpression(
                                                                                "aliasTypes",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "ast",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "visitor",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "visit",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "e",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "return",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "text",
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
                                                            "fromTypeWith",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "type",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "propNames",
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
                                                                            "fromTypeExcept",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                "type",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "type",
                                                                                                    new List<IdentifierExpression>
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
                                                                                        AphidTokenType.SelectOperator,
                                                                                        new FunctionExpression(
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "___p_op_2",
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
                                                                                                            "___p_op_2",
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
                                                                                                    false
                                                                                                ),
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.WhereOperator,
                                                                                    new FunctionExpression(
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                        },
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.retKeyword,
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.NotOperator,
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "propNames",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "contains",
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
                                                                                                        }
                                                                                                    ),
                                                                                                    false
                                                                                                ),
                                                                                                false
                                                                                            ),
                                                                                        }
                                                                                    )
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
                                                                                        "ToList",
                                                                                        new List<IdentifierExpression>
                                                                                        {
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "fromType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "type",
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
                                                                            "fromTypeExcept",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                "type",
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
                                                            "fromTypeExcept",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "type",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "ignore",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "typeMap",
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
                                                                        "props",
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
                                                                                "type",
                                                                                new List<IdentifierExpression>
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
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.definedKeyword,
                                                                                new IdentifierExpression(
                                                                                    "ignore",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                true
                                                                            ),
                                                                            AphidTokenType.AndOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "ignore",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.NotEqualOperator,
                                                                                new NullExpression(
                                                                                )
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "props",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.WhereOperator,
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
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "ignore",
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
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new ImplicitArgumentExpression(
                                                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                                                        ),
                                                                                                                        AphidTokenType.EqualityOperator,
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
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    AphidTokenType.OrOperator,
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new ImplicitArgumentExpression(
                                                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                                                        ),
                                                                                                                        AphidTokenType.EqualityOperator,
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                    new IdentifierExpression(
                                                                                                                                        "type",
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
                                                                                                                            AphidTokenType.AdditionOperator,
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
                                                                                                                            )
                                                                                                                        )
                                                                                                                    )
                                                                                                                ),
                                                                                                                AphidTokenType.OrOperator,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new ImplicitArgumentExpression(
                                                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                                                    ),
                                                                                                                    AphidTokenType.EqualityOperator,
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                new IdentifierExpression(
                                                                                                                                    "type",
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
                                                                                                                        AphidTokenType.AdditionOperator,
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
                                                                                                                        )
                                                                                                                    )
                                                                                                                )
                                                                                                            ),
                                                                                                            false
                                                                                                        ),
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                        false
                                                                                    ),
                                                                                }
                                                                            )
                                                                        ),
                                                                        new IdentifierExpression(
                                                                            "props",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "typeMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new BinaryOperatorExpression(
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
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
                                                                                new BinaryOperatorExpression(
                                                                                    new ImplicitArgumentExpression(
                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "PropertyType",
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
                                                                        AphidTokenType.definedKeyword,
                                                                        new IdentifierExpression(
                                                                            "traceVMCompiler",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        true
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "printInfo",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'Created map: '"
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "typeMap",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new IdentifierExpression(
                                                                                "dump",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "fromMap",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "namespace",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "type",
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
                                                                            new IdentifierExpression(
                                                                                "typeMap",
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
                                                            "fromObject",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "name",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "aphidObject",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "map",
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
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "aphidObject",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new BinaryOperatorExpression(
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "map",
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
                                                                                new IdentifierExpression(
                                                                                    "Object",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new IfExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new IdentifierExpression(
                                                                            "traceVMCompiler",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        true
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "printInfo",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'Created map: '"
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "typeMap",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new IdentifierExpression(
                                                                                "dump",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "fromMap",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "map",
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
                                                            "fromMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "namespace",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "name",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "typeMap",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "i",
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
                                                                    "e",
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "usingStmts",
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
                                                                        AphidTokenType.DistinctOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "typeMap",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
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
                                                                                            },
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.retKeyword,
                                                                                                    new ArrayAccessExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "typeMap",
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
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.SelectOperator,
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
                                                                                                new TernaryOperatorExpression(
                                                                                                    AphidTokenType.ConditionalOperator,
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
                                                                                                                "IsAssignableFrom",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new CallExpression(
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "x",
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
                                                                                                        }
                                                                                                    ),
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "x",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "Namespace",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    new PatternMatchingExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "i",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.AssignmentOperator,
                                                                                                            new CallExpression(
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "x",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "LastIndexOf",
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
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<PatternExpression>
                                                                                                        {
                                                                                                            new PatternExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "x",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                new List<AphidExpression>
                                                                                                                {
                                                                                                                    new UnaryOperatorExpression(
                                                                                                                        AphidTokenType.MinusOperator,
                                                                                                                        new NumberExpression(
                                                                                                                            1
                                                                                                                        ),
                                                                                                                        false
                                                                                                                    ),
                                                                                                                }
                                                                                                            ),
                                                                                                            new PatternExpression(
                                                                                                                new CallExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "x",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "Remove",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                        new IdentifierExpression(
                                                                                                                            "i",
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
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                false
                                                                                            ),
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.WhereOperator,
                                                                                new FunctionExpression(
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "___p_op_3",
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
                                                                                                    "___p_op_3",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
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
                                                                                            "'using {0};'"
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        false
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "aliases",
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
                                                                        "aliasMap",
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
                                                                        "aliasIndex",
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
                                                                    new NumberExpression(
                                                                        0
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "aliasTypes",
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
                                                                        "addAlias",
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
                                                                                "type",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IfExpression(
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.definedKeyword,
                                                                                    new ArrayAccessExpression(
                                                                                        new IdentifierExpression(
                                                                                            "aliasMap",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "n",
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
                                                                                                            "type",
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
                                                                                                )
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    true
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.retKeyword,
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "aliasMap",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "n",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        false
                                                                                    ),
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "key",
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
                                                                                            new StringExpression(
                                                                                                "'alias{0}'"
                                                                                            ),
                                                                                            AphidTokenType.CustomOperator214,
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.IncrementOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "aliasIndex",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                true
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "aliases",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "key",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new IdentifierExpression(
                                                                                            "n",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "aliasMap",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "n",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new IdentifierExpression(
                                                                                            "key",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "aliasTypes",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "key",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new IdentifierExpression(
                                                                                            "type",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.retKeyword,
                                                                                        new IdentifierExpression(
                                                                                            "key",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        false
                                                                                    ),
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "resolveType",
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
                                                                                "t",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IfExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.NotOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "t",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "IsGenericType",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        false
                                                                                    ),
                                                                                    AphidTokenType.AndOperator,
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.NotOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "t",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "IsArray",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        false
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.retKeyword,
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
                                                                                        false
                                                                                    ),
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IfExpression(
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
                                                                                                        "IsArray",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AndOperator,
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.NotOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "e",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.AssignmentOperator,
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
                                                                                                                        "GetElementType",
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
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "IsArray",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    false
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.AndOperator,
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.NotOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "e",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "IsGenericType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                false
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.retKeyword,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "e",
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
                                                                                                        "' list'"
                                                                                                    )
                                                                                                ),
                                                                                                false
                                                                                            ),
                                                                                        },
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IfExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "e",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.AssignmentOperator,
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
                                                                                                                new StringExpression(
                                                                                                                    "'IEnumerable`1'"
                                                                                                                ),
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.NotEqualOperator,
                                                                                                    new NullExpression(
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IfExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.NotOperator,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "e",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.AssignmentOperator,
                                                                                                                        new ArrayAccessExpression(
                                                                                                                            new CallExpression(
                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                    new IdentifierExpression(
                                                                                                                                        "e",
                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                        {
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                                    new IdentifierExpression(
                                                                                                                                        "GetGenericArguments",
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
                                                                                                                                    0
                                                                                                                                ),
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "IsGenericType",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                ),
                                                                                                                false
                                                                                                            ),
                                                                                                            AphidTokenType.AndOperator,
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.NotOperator,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "e",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "IsArray",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                ),
                                                                                                                false
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.retKeyword,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "e",
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
                                                                                                                        "' list'"
                                                                                                                    )
                                                                                                                ),
                                                                                                                false
                                                                                                            ),
                                                                                                        },
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.retKeyword,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new CallExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "addAlias",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        new List<AphidExpression>
                                                                                                                        {
                                                                                                                            new IdentifierExpression(
                                                                                                                                "e",
                                                                                                                                new List<IdentifierExpression>
                                                                                                                                {
                                                                                                                                }
                                                                                                                            ),
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                                    new StringExpression(
                                                                                                                        "' list'"
                                                                                                                    )
                                                                                                                ),
                                                                                                                false
                                                                                                            ),
                                                                                                        }
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
                                                                                                                    new StringExpression(
                                                                                                                        "'IEnumerable'"
                                                                                                                    ),
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.NotEqualOperator,
                                                                                                            new NullExpression(
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.retKeyword,
                                                                                                                new StringExpression(
                                                                                                                    "'Object list'"
                                                                                                                ),
                                                                                                                false
                                                                                                            ),
                                                                                                        },
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new UnaryOperatorExpression(
                                                                                                                AphidTokenType.retKeyword,
                                                                                                                new CallExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "addAlias",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                        new IdentifierExpression(
                                                                                                                            "t",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                    }
                                                                                                                ),
                                                                                                                false
                                                                                                            ),
                                                                                                        }
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "members",
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
                                                                                new IdentifierExpression(
                                                                                    "typeMap",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
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
                                                                                            new BinaryOperatorExpression(
                                                                                                new CallExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "resolveType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new List<AphidExpression>
                                                                                                    {
                                                                                                        new ArrayAccessExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "typeMap",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                                new IdentifierExpression(
                                                                                                                    "x",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                            }
                                                                                                        ),
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.AdditionOperator,
                                                                                                new StringExpression(
                                                                                                    "' '"
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.AdditionOperator,
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
                                                                                        "'{0},\\r\\n'"
                                                                                    ),
                                                                                }
                                                                            )
                                                                        )
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "beginOut",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new GatorCloseExpression(
                                                                ),
                                                                new TextExpression(
                                                                    "\r\n                @{\r\n                    ViewModel;\r\n                    \r\n                    using System;\r\n                    using System.Collections;\r\n                    using System.Collections.Generic;\r\n                    using System.Collections.ObjectModel;\r\n\r\n                    "
                                                                ),
                                                                new GatorOpenExpression(
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "usingStmts",
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
                                                                            new GatorCloseExpression(
                                                                            ),
                                                                            new GatorEmitExpression(
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                )
                                                                            ),
                                                                            new GatorOpenExpression(
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new GatorCloseExpression(
                                                                ),
                                                                new TextExpression(
                                                                    "\r\n                \r\n                    "
                                                                ),
                                                                new GatorEmitExpression(
                                                                    new IdentifierExpression(
                                                                        "namespace",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new TextExpression(
                                                                    ";\r\n\r\n                    "
                                                                ),
                                                                new GatorOpenExpression(
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "aliases",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new GatorCloseExpression(
                                                                            ),
                                                                            new TextExpression(
                                                                                "\r\n                    alias "
                                                                            ),
                                                                            new GatorEmitExpression(
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                )
                                                                            ),
                                                                            new TextExpression(
                                                                                " = \""
                                                                            ),
                                                                            new GatorEmitExpression(
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "aliases",
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
                                                                            ),
                                                                            new TextExpression(
                                                                                "\";"
                                                                            ),
                                                                            new GatorOpenExpression(
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new GatorCloseExpression(
                                                                ),
                                                                new TextExpression(
                                                                    "\r\n\r\n                    class "
                                                                ),
                                                                new GatorEmitExpression(
                                                                    new IdentifierExpression(
                                                                        "name",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new GatorEmitExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "viewModel",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "typeSuffix",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new TextExpression(
                                                                    "\r\n                    {\r\n                        Object ViewModelDataSource,\r\n                        \r\n                        "
                                                                ),
                                                                new GatorOpenExpression(
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "members",
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
                                                                            new GatorCloseExpression(
                                                                            ),
                                                                            new TextExpression(
                                                                                "\r\n                        "
                                                                            ),
                                                                            new GatorEmitExpression(
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                                )
                                                                            ),
                                                                            new GatorOpenExpression(
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                new GatorCloseExpression(
                                                                ),
                                                                new TextExpression(
                                                                    "\r\n                    }\r\n                }\r\n                "
                                                                ),
                                                                new GatorOpenExpression(
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "endOut",
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
                                                                                "ToString",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "compileCode",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "s",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "aliasTypes",
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
