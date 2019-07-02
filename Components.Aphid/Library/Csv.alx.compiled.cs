namespace BuiltInLibrary.Library
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Csv()
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
                        "_lp",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new IdentifierExpression(
                        "print",
                        new List<IdentifierExpression>
                        {
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "_lp",
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
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "csvLexerState",
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
                                    "starting",
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
                                    "inString",
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
                                    "endString",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new NumberExpression(
                                    2
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "inValue",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new NumberExpression(
                                    3
                                )
                            ),
                        },
                        null
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "fixCsvLine",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "line",
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "state",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "csvLexerState",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "starting",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "lexer",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "line",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "ToCharArray",
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
                                    "sb",
                                    new List<IdentifierExpression>
                                    {
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
                            new WhileExpression(
                                new UnaryOperatorExpression(
                                    AphidTokenType.NotOperator,
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
                                    ),
                                    false
                                ),
                                new List<AphidExpression>
                                {
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "token",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "lexer",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "token",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        )
                                    ),
                                    new CallExpression(
                                        new IdentifierExpression(
                                            "_lp",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new StringExpression(
                                                "'Scanning \\'{0}\\''"
                                            ),
                                            new IdentifierExpression(
                                                "token",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    new SwitchExpression(
                                        new IdentifierExpression(
                                            "state",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<SwitchCase>
                                        {
                                            new SwitchCase(
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "csvLexerState",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "starting",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "_lp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'[?] Scanning element start'"
                                                            ),
                                                        }
                                                    ),
                                                    new SwitchExpression(
                                                        new IdentifierExpression(
                                                            "token",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<SwitchCase>
                                                        {
                                                            new SwitchCase(
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'\"'"
                                                                    ),
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "_lp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'[+] matched string start'"
                                                                            ),
                                                                        }
                                                                    ),
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
                                                                            new IdentifierExpression(
                                                                                "token",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "state",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "csvLexerState",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "inString",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                }
                                                            ),
                                                            new SwitchCase(
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "','"
                                                                    ),
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "_lp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'[+] matched empty value'"
                                                                            ),
                                                                        }
                                                                    ),
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
                                                                            new StringExpression(
                                                                                "'\"\",'"
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                        },
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_lp",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'[+] matched value start'"
                                                                    ),
                                                                }
                                                            ),
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
                                                                    new StringExpression(
                                                                        "'\"'"
                                                                    ),
                                                                }
                                                            ),
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
                                                                    new IdentifierExpression(
                                                                        "token",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "state",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "csvLexerState",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "inValue",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                }
                                            ),
                                            new SwitchCase(
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "csvLexerState",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "inString",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "_lp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'[?] Scanning string'"
                                                            ),
                                                        }
                                                    ),
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
                                                            new IdentifierExpression(
                                                                "token",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "token",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.EqualityOperator,
                                                            new StringExpression(
                                                                "'\"'"
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_lp",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'[+] matched end string'"
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "state",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "csvLexerState",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "endString",
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
                                            new SwitchCase(
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "csvLexerState",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "endString",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "_lp",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'[?] Scanning end string'"
                                                            ),
                                                        }
                                                    ),
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
                                                            new IdentifierExpression(
                                                                "token",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "token",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.EqualityOperator,
                                                            new StringExpression(
                                                                "','"
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_lp",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'[+] matched comma'"
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "state",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "csvLexerState",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "starting",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                        },
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
                                                                        "'Expected comma'"
                                                                    ),
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                }
                                            ),
                                            new SwitchCase(
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "csvLexerState",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "inValue",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "token",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.NotEqualOperator,
                                                            new StringExpression(
                                                                "','"
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_lp",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'[+] matched value token'"
                                                                    ),
                                                                }
                                                            ),
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
                                                                    new IdentifierExpression(
                                                                        "token",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                        },
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_lp",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'[+] matched end string'"
                                                                    ),
                                                                }
                                                            ),
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
                                                                    new StringExpression(
                                                                        "'\"'"
                                                                    ),
                                                                }
                                                            ),
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
                                                                    new IdentifierExpression(
                                                                        "token",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "state",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "csvLexerState",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "starting",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                }
                                            ),
                                        },
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
                                                        "'Unknown lexer state'"
                                                    ),
                                                }
                                            ),
                                        }
                                    ),
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
                                                "next",
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
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "state",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.EqualityOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "csvLexerState",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "inValue",
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
                                            new StringExpression(
                                                "'\"'"
                                            ),
                                        }
                                    ),
                                },
                                null
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
                        "parseCsvFile",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "csvFile",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
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
                                        "'Parsing CSV file'"
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "rows",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "csvFile",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
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
                                                                    3
                                                                ),
                                                            }
                                                        )
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
                                                                "'[{0}]'"
                                                            ),
                                                        }
                                                    )
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
                                                                new IdentifierExpression(
                                                                    "x",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new StringExpression(
                                                                    "',\\r\\n'"
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
                                                        false
                                                    ),
                                                }
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
                                                        "'[{0}]'"
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "names",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayAccessExpression(
                                    new IdentifierExpression(
                                        "rows",
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "csvObj",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "rows",
                                            new List<IdentifierExpression>
                                            {
                                            }
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
                                                            "names",
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "c",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
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
                                                        ),
                                                        new TryExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "c",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Decimal",
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
                                                                            new IdentifierExpression(
                                                                                "c",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                            },
                                                            null,
                                                            new List<AphidExpression>
                                                            {
                                                                new TryExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "c",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "DateTime",
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
                                                                                    new IdentifierExpression(
                                                                                        "c",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
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
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "o",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new DynamicMemberExpression(
                                                                    new ArrayAccessExpression(
                                                                        new IdentifierExpression(
                                                                            "names",
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
                                                            AphidTokenType.AssignmentOperator,
                                                            new IdentifierExpression(
                                                                "c",
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
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "csvObj",
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
                        "parseCsvLines",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "csvLines",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
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
                                        "'Parsing CSV file'"
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "rows",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "csvLines",
                                                    new List<IdentifierExpression>
                                                    {
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
                                                                "'[{0}]'"
                                                            ),
                                                        }
                                                    )
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
                                                                new IdentifierExpression(
                                                                    "x",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new StringExpression(
                                                                    "',\\r\\n'"
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
                                                        false
                                                    ),
                                                }
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
                                                        "'[{0}]'"
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "names",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new ArrayAccessExpression(
                                    new IdentifierExpression(
                                        "rows",
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "csvObj",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "rows",
                                            new List<IdentifierExpression>
                                            {
                                            }
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
                                                            "names",
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "c",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
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
                                                        ),
                                                        new TryExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "c",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "Decimal",
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
                                                                            new IdentifierExpression(
                                                                                "c",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                            },
                                                            null,
                                                            new List<AphidExpression>
                                                            {
                                                                new TryExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "c",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "DateTime",
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
                                                                                    new IdentifierExpression(
                                                                                        "c",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
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
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "o",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new DynamicMemberExpression(
                                                                    new ArrayAccessExpression(
                                                                        new IdentifierExpression(
                                                                            "names",
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
                                                            AphidTokenType.AssignmentOperator,
                                                            new IdentifierExpression(
                                                                "c",
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
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "csvObj",
                                    new List<IdentifierExpression>
                                    {
                                    }
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
