namespace BuiltInLibrary.Library.Interop
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Com()
        {
            return             new List<AphidExpression>
            {
                new ExtendExpression(
                    new IdentifierExpression(
                        "__ComObject",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    new ObjectExpression(
                        new List<BinaryOperatorExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "get",
                                    new List<IdentifierExpression>
                                    {
                                        new IdentifierExpression(
                                            "dynamic",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "obj",
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
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
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
                                                AphidTokenType.EqualityOperator,
                                                new NumberExpression(
                                                    1
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new TryExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "__ComObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "InvokeMember",
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
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "BindingFlags",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "GetField",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'GetProperty'"
                                                                                    ),
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
                                                                            new NullExpression(
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new NullExpression(
                                                                    ),
                                                                    new IdentifierExpression(
                                                                        "obj",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new ArrayExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    },
                                                    null,
                                                    new List<AphidExpression>
                                                    {
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "__ComObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "InvokeMember",
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
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "BindingFlags",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "InvokeMethod",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new NullExpression(
                                                                    ),
                                                                    new IdentifierExpression(
                                                                        "obj",
                                                                        new List<IdentifierExpression>
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
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "aq",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "skip",
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
                                                                        )
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    },
                                                    null
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "__ComObject",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "InvokeMember",
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
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "BindingFlags",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "InvokeMethod",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new NullExpression(
                                                            ),
                                                            new IdentifierExpression(
                                                                "obj",
                                                                new List<IdentifierExpression>
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "aq",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "skip",
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
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                    false
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
