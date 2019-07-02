namespace BuiltInLibrary.Library.Data
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> SQlite()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "sqlite",
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
                        "fromEpoch",
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
                                        new IdentifierExpression(
                                            "x",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.BinaryOrOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "DateTimeOffset",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "FromUnixTimeSeconds",
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
                                                        new ImplicitArgumentExpression(
                                                            AphidTokenType.ImplicitArgumentOperator
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ToLocalTime",
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
                new CallExpression(
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'system/nuget'"
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "nuget",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "reference",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "'System.Data.SQLite.Core'"
                                    ),
                                }
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
                                            "Data",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "SQLite",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "sqlite",
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
                                                "escape",
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
                                                        new BinaryOperatorExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.newKeyword,
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "SQLiteCommandBuilder",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
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
                                                                                "QuoteIdentifier",
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
                                                },
                                                null
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "connection",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new NullExpression(
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "version",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new NumberExpression(
                                                3
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dateTimeFormat",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new StringExpression(
                                                "'CurrentCulture'"
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dateTimeFormatValues",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                    new NullExpression(
                                                    ),
                                                    new StringExpression(
                                                        "'ms'"
                                                    ),
                                                    new StringExpression(
                                                        "'Ticks'"
                                                    ),
                                                    new StringExpression(
                                                        "'CurrentCulture'"
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
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "file",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "connection",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.newKeyword,
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "SQLiteConnection",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new ArrayExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new StringExpression(
                                                                                            "'Data Source=\"{0}\"'"
                                                                                        ),
                                                                                        AphidTokenType.CustomOperator214,
                                                                                        new ImplicitArgumentExpression(
                                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                                        )
                                                                                    ),
                                                                                    new TernaryOperatorExpression(
                                                                                        AphidTokenType.ConditionalOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "version",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.NotEqualOperator,
                                                                                            new NullExpression(
                                                                                            )
                                                                                        ),
                                                                                        new BinaryOperatorExpression(
                                                                                            new StringExpression(
                                                                                                "'version={0}'"
                                                                                            ),
                                                                                            AphidTokenType.CustomOperator214,
                                                                                            new IdentifierExpression(
                                                                                                "version",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new NullExpression(
                                                                                        )
                                                                                    ),
                                                                                    new TernaryOperatorExpression(
                                                                                        AphidTokenType.ConditionalOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "dateTimeFormat",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.NotEqualOperator,
                                                                                            new NullExpression(
                                                                                            )
                                                                                        ),
                                                                                        new BinaryOperatorExpression(
                                                                                            new StringExpression(
                                                                                                "'datetimeformat={0}'"
                                                                                            ),
                                                                                            AphidTokenType.CustomOperator214,
                                                                                            new IdentifierExpression(
                                                                                                "dateTimeFormat",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new NullExpression(
                                                                                        )
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            AphidTokenType.WhereOperator,
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
                                                                                            AphidTokenType.NotEqualOperator,
                                                                                            new NullExpression(
                                                                                            )
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
                                                                                        "';'"
                                                                                    ),
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        )
                                                    ),
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "connection",
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
                                                        }
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "sqlite",
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
                                                "getRows",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "tableName",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "cmd",
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
                                                                    "connection",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "CreateCommand",
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
                                                                "cmd",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "CommandText",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new BinaryOperatorExpression(
                                                            new StringExpression(
                                                                "'SELECT * FROM '"
                                                            ),
                                                            AphidTokenType.AdditionOperator,
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "escape",
                                                                        new List<IdentifierExpression>
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
                                                                    new IdentifierExpression(
                                                                        "tableName",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "printQuery",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'Executing ~Cyan~{0}~R~'"
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "cmd",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "CommandText",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                        }
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
                                                                    "byte",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "MakeArrayType",
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
                                                    new TryExpression(
                                                        new List<AphidExpression>
                                                        {
                                                            new UsingExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "rows",
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
                                                                                "cmd",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "ExecuteReader",
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
                                                                new List<AphidExpression>
                                                                {
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.retKeyword,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "rows",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.SelectOperator,
                                                                            new FunctionExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "r",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "o",
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
                                                                                            new NumberExpression(
                                                                                                0
                                                                                            ),
                                                                                            AphidTokenType.RangeOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "r",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "FieldCount",
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
                                                                                            },
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
                                                                                                                "r",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "GetName",
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
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new ArrayAccessExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "o",
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
                                                                                                                "GetValue",
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
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "vt",
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
                                                                                                            new ArrayAccessExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                        new IdentifierExpression(
                                                                                                            "vt",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.EqualityOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "t",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    new List<AphidExpression>
                                                                                                    {
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
                                                                                                            new ArrayAccessExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                            )
                                                                                                        ),
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new ArrayAccessExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "v",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.BinaryOrOperator,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "Encoding",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "ASCII",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "GetString",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                )
                                                                                                            )
                                                                                                        ),
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new ArrayAccessExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.AdditionOperator,
                                                                                                                        new StringExpression(
                                                                                                                            "'__unicode'"
                                                                                                                        )
                                                                                                                    ),
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.AssignmentOperator,
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "v",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.BinaryOrOperator,
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "Encoding",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "Unicode",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "GetString",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                )
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
                                                                                                                    "vt",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.EqualityOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "int",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            AphidTokenType.OrOperator,
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "vt",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.EqualityOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "long",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            )
                                                                                                        ),
                                                                                                        AphidTokenType.AndOperator,
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new ArrayAccessExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                            AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                            new NumberExpression(
                                                                                                                500000000
                                                                                                            )
                                                                                                        )
                                                                                                    ),
                                                                                                    new List<AphidExpression>
                                                                                                    {
                                                                                                        new ForEachExpression(
                                                                                                            new ArrayExpression(
                                                                                                                new List<AphidExpression>
                                                                                                                {
                                                                                                                    new ArrayExpression(
                                                                                                                        new List<AphidExpression>
                                                                                                                        {
                                                                                                                            new StringExpression(
                                                                                                                                "'seconds'"
                                                                                                                            ),
                                                                                                                            new NumberExpression(
                                                                                                                                1
                                                                                                                            ),
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    new ArrayExpression(
                                                                                                                        new List<AphidExpression>
                                                                                                                        {
                                                                                                                            new StringExpression(
                                                                                                                                "'ms'"
                                                                                                                            ),
                                                                                                                            new NumberExpression(
                                                                                                                                1000
                                                                                                                            ),
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    new ArrayExpression(
                                                                                                                        new List<AphidExpression>
                                                                                                                        {
                                                                                                                            new StringExpression(
                                                                                                                                "'ticks'"
                                                                                                                            ),
                                                                                                                            new NumberExpression(
                                                                                                                                10000000
                                                                                                                            ),
                                                                                                                        }
                                                                                                                    ),
                                                                                                                }
                                                                                                            ),
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                                new TryExpression(
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new ArrayAccessExpression(
                                                                                                                                new IdentifierExpression(
                                                                                                                                    "o",
                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                    {
                                                                                                                                    }
                                                                                                                                ),
                                                                                                                                new List<AphidExpression>
                                                                                                                                {
                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                        new BinaryOperatorExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "n",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.AdditionOperator,
                                                                                                                                            new StringExpression(
                                                                                                                                                "'__epoch_'"
                                                                                                                                            )
                                                                                                                                        ),
                                                                                                                                        AphidTokenType.AdditionOperator,
                                                                                                                                        new ArrayAccessExpression(
                                                                                                                                            new ImplicitArgumentExpression(
                                                                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                                                                            ),
                                                                                                                                            new List<AphidExpression>
                                                                                                                                            {
                                                                                                                                                new NumberExpression(
                                                                                                                                                    0
                                                                                                                                                ),
                                                                                                                                            }
                                                                                                                                        )
                                                                                                                                    ),
                                                                                                                                }
                                                                                                                            ),
                                                                                                                            AphidTokenType.AssignmentOperator,
                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                        new ArrayAccessExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "o",
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
                                                                                                                                        AphidTokenType.DivisionOperator,
                                                                                                                                        new ArrayAccessExpression(
                                                                                                                                            new ImplicitArgumentExpression(
                                                                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                                                                            ),
                                                                                                                                            new List<AphidExpression>
                                                                                                                                            {
                                                                                                                                                new NumberExpression(
                                                                                                                                                    1
                                                                                                                                                ),
                                                                                                                                            }
                                                                                                                                        )
                                                                                                                                    ),
                                                                                                                                    AphidTokenType.BinaryOrOperator,
                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                        new IdentifierExpression(
                                                                                                                                            "DateTimeOffset",
                                                                                                                                            new List<IdentifierExpression>
                                                                                                                                            {
                                                                                                                                            }
                                                                                                                                        ),
                                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                                        new IdentifierExpression(
                                                                                                                                            "FromUnixTimeSeconds",
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
                                                                                                                                                    new ImplicitArgumentExpression(
                                                                                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                                                                                    ),
                                                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                                                    new IdentifierExpression(
                                                                                                                                                        "ToLocalTime",
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
                                                                                                                            )
                                                                                                                        ),
                                                                                                                    },
                                                                                                                    null,
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                    },
                                                                                                                    null
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
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.retKeyword,
                                                                                        new IdentifierExpression(
                                                                                            "o",
                                                                                            new List<IdentifierExpression>
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
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new ObjectExpression(
                                                                    new List<BinaryOperatorExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "error",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "e",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "query",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "cmd",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "CommandText",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                false
                                                            ),
                                                        },
                                                        null
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "getSchema",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "tableName",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "table",
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
                                                                    "connection",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "GetSchema",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "tableName",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "cols",
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
                                                                "table",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Columns",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new BinaryOperatorExpression(
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "table",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Select",
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
                                                                        "r",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "o",
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
                                                                            new NumberExpression(
                                                                                0
                                                                            ),
                                                                            AphidTokenType.RangeOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "cols",
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new ArrayAccessExpression(
                                                                                            new IdentifierExpression(
                                                                                                "o",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new BinaryOperatorExpression(
                                                                                                    new ArrayAccessExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "cols",
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
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "ColumnName",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new ArrayAccessExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "r",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "ItemArray",
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
                                                                                        )
                                                                                    ),
                                                                                    false
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.retKeyword,
                                                                        new IdentifierExpression(
                                                                            "o",
                                                                            new List<IdentifierExpression>
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "getTables",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new PartialFunctionExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "getSchema",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Tables'"
                                                        ),
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
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
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
                                                                        "file",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "connection",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "FileName",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "schema",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "getTables",
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
                                                                    new IdentifierExpression(
                                                                        "tables",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "schema",
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
                                                                                                    "TABLE_TYPE",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.EqualityOperator,
                                                                                            new StringExpression(
                                                                                                "'table'"
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
                                                                                                "TABLE_NAME",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.BinaryOrOperator,
                                                                                        new IdentifierExpression(
                                                                                            "getRows",
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
                                                            },
                                                            null
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
;
        }
    }
}
