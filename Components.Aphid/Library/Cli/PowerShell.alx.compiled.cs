namespace BuiltInLibrary.Library.Cli
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> PowerShell()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "psContext",
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
                        "initPSInterop",
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
                                    "psAsm",
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
                                    AphidTokenType.loadKeyword,
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
                                                "Management",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Automation",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    false
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.usingKeyword,
                                new IdentifierExpression(
                                    "System",
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
                                        "ObjectModel",
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
                                            "Management",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Automation",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "psContext",
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
                                                "psAsm",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new IdentifierExpression(
                                                "psAsm",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "psCollection",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new ArrayAccessExpression(
                                                new IdentifierExpression(
                                                    "Collection",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "PSObject",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "engine",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "PowerShell",
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
                                                ),
                                                new List<AphidExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "exec",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "command",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "engine",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "AddScript",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "command",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    new TryExpression(
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "engine",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Invoke",
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
                                                                            "psContext",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "importPSObject",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                false
                                                            ),
                                                        },
                                                        null,
                                                        null,
                                                        new List<AphidExpression>
                                                        {
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "engine",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Commands",
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
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "execSelect",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "command",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "selector",
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
                                                                    "command",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.PipelineOperator,
                                                                new IdentifierExpression(
                                                                    "exec",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.SelectOperator,
                                                            new IdentifierExpression(
                                                                "selector",
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
                                                "execWhere",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "command",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "predicate",
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
                                                                    "command",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.PipelineOperator,
                                                                new IdentifierExpression(
                                                                    "exec",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.WhereOperator,
                                                            new IdentifierExpression(
                                                                "predicate",
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
                                                "unwrap",
                                                new List<IdentifierExpression>
                                                {
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
                                                                        "obj",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.NotEqualOperator,
                                                                    new NullExpression(
                                                                    )
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "obj",
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
                                                                    AphidTokenType.EqualityOperator,
                                                                    new IdentifierExpression(
                                                                        "PSObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "obj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "BaseObject",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new IdentifierExpression(
                                                                "obj",
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
                                                "fastImport",
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
                                                "importPSObject",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "psObj",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "tracePSInterop",
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
                                                            new BinaryOperatorExpression(
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.definedKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psContext",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "tracePSInterop",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "var",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                    true
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "tracePSInterop",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "var",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            new FunctionExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "fmt",
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
                                                                                "print",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'{0} Trace: ~Magenta~{1}~R~'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'PSInterop'"
                                                                                ),
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
                                                                                                "'[Nothing]'"
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new NumberExpression(
                                                                                                    0
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new PatternExpression(
                                                                                            new IdentifierExpression(
                                                                                                "fmt",
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
                                                                                                    new IdentifierExpression(
                                                                                                        "fmt",
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
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                        false
                                                                    ),
                                                                }
                                                            ),
                                                            new FunctionExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
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
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psObj",
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
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "tracePSInterop",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'importPSObject returning null'"
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
                                                        new List<AphidExpression>
                                                        {
                                                            new IfExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "t",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "psObj",
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
                                                                    AphidTokenType.NotEqualOperator,
                                                                    new IdentifierExpression(
                                                                        "PSObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IfExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new ArrayAccessExpression(
                                                                                        new IdentifierExpression(
                                                                                            "IEnumerable",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "PSObject",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
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
                                                                                    new IdentifierExpression(
                                                                                        "t",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            AphidTokenType.OrOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new ArrayAccessExpression(
                                                                                        new IdentifierExpression(
                                                                                            "IEnumerable",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "AphidObject",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
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
                                                                                    new IdentifierExpression(
                                                                                        "t",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "tracePSInterop",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'importPSObject recursing'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "psObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.SelectOperator,
                                                                                    new IdentifierExpression(
                                                                                        "importPSObject",
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
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "tracePSInterop",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'importPSObject returning non-PSObject'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new IdentifierExpression(
                                                                                    "psObj",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                        }
                                                                    ),
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                    new IfExpression(
                                                                        new IdentifierExpression(
                                                                            "fastImport",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new TernaryOperatorExpression(
                                                                                    AphidTokenType.ConditionalOperator,
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.definedKeyword,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "psObj",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "BaseObject",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        true
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "psObj",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "BaseObject",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new IdentifierExpression(
                                                                                        "psObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                false
                                                                            ),
                                                                        },
                                                                        null
                                                                    ),
                                                                }
                                                            ),
                                                        }
                                                    ),
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "isPSInterop",
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
                                                                        "psObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new IdentifierExpression(
                                                                        "psObj",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "TypeNames",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "TypeNames",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "Properties",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Properties",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "Methods",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Methods",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "Members",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Members",
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
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psObj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Properties",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
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
                                                                        new PatternMatchingExpression(
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
                                                                            new List<PatternExpression>
                                                                            {
                                                                                new PatternExpression(
                                                                                    new BooleanExpression(
                                                                                        false
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'BaseName'"
                                                                                        ),
                                                                                        new StringExpression(
                                                                                            "'VersionInfo'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new PatternExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new CallExpression(
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
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "StartsWith",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new StringExpression(
                                                                                                        "'get_'"
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            false
                                                                                        ),
                                                                                        AphidTokenType.AndOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new CallExpression(
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
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "StartsWith",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new StringExpression(
                                                                                                        "'set_'"
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            false
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
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.SelectOperator,
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
                                                                new TryExpression(
                                                                    new List<AphidExpression>
                                                                    {
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
                                                                                    "Value",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
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
                                                                                "tracePSInterop",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new StringExpression(
                                                                                        "'Error copying {0}: {1}'"
                                                                                    ),
                                                                                    AphidTokenType.CustomOperator214,
                                                                                    new ArrayExpression(
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
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psObj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Methods",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.WhereOperator,
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
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.retKeyword,
                                                                        new BinaryOperatorExpression(
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.NotOperator,
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "m",
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
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "StartsWith",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'get_'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            ),
                                                                            AphidTokenType.AndOperator,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.NotOperator,
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "m",
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
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "StartsWith",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "'set_'"
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
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
                                                                    "m",
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
                                                                                "o",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new DynamicMemberExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "m",
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
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "m",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Invoke",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "restorePSObject",
                                                new List<IdentifierExpression>
                                                {
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
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "tracePSInterop",
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
                                                            new BinaryOperatorExpression(
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.definedKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psContext",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "tracePSInterop",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "var",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                    true
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "tracePSInterop",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "var",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            new FunctionExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "fmt",
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
                                                                                "print",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'{0} Trace: ~Magenta~{1}~R~'"
                                                                                ),
                                                                                new StringExpression(
                                                                                    "'PSInterop'"
                                                                                ),
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
                                                                                                "'[Nothing]'"
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new NumberExpression(
                                                                                                    0
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new PatternExpression(
                                                                                            new IdentifierExpression(
                                                                                                "fmt",
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
                                                                                                    new IdentifierExpression(
                                                                                                        "fmt",
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
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                        false
                                                                    ),
                                                                }
                                                            ),
                                                            new FunctionExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                },
                                                                new List<AphidExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "tracePSInterop",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'Restoring'"
                                                            ),
                                                        }
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "obj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.NotEqualOperator,
                                                                new NullExpression(
                                                                )
                                                            ),
                                                            AphidTokenType.AndOperator,
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "obj",
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
                                                                AphidTokenType.EqualityOperator,
                                                                new IdentifierExpression(
                                                                    "PSObject",
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
                                                                    "tracePSInterop",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'No action needed'"
                                                                    ),
                                                                }
                                                            ),
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new IdentifierExpression(
                                                                    "obj",
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
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psContext",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "isImportedPSObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "obj",
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
                                                                            "tracePSInterop",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'Returning psObject property'"
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.retKeyword,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "obj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "psObject",
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
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "isCollection",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "obj",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AndOperator,
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
                                                                                            "Any",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "obj",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.AndOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "psContext",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "isImportedPSObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new ArrayAccessExpression(
                                                                                        new IdentifierExpression(
                                                                                            "obj",
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
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "tracePSInterop",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'Recursing'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "obj",
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
                                                                                                        "psObject",
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
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new CallExpression(
                                                                                new IdentifierExpression(
                                                                                    "tracePSInterop",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new StringExpression(
                                                                                        "'No action needed 2'"
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new IdentifierExpression(
                                                                                    "obj",
                                                                                    new List<IdentifierExpression>
                                                                                    {
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
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "isImportedPSObj",
                                                new List<IdentifierExpression>
                                                {
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
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "obj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.NotEqualOperator,
                                                                        new NullExpression(
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AndOperator,
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "obj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "isPSInterop",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        true
                                                                    )
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "obj",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "isPSInterop",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            AphidTokenType.AndOperator,
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.definedKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "obj",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "psObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                true
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "isCommandInternal",
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
                                            "command",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "isApplication",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "tracePS",
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
                                                new BinaryOperatorExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "var",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        true
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "tracePS",
                                                            new List<IdentifierExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "var",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "fmt",
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
                                                                    "print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'{0} Trace: ~Magenta~{1}~R~'"
                                                                    ),
                                                                    new StringExpression(
                                                                        "'PS'"
                                                                    ),
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
                                                                                    "'[Nothing]'"
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        0
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new PatternExpression(
                                                                                new IdentifierExpression(
                                                                                    "fmt",
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
                                                                                        new IdentifierExpression(
                                                                                            "fmt",
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
                                                                                new List<AphidExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    }
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
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
                                            new TernaryOperatorExpression(
                                                AphidTokenType.ConditionalOperator,
                                                new IdentifierExpression(
                                                    "isApplication",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new StringExpression(
                                                    "'application'"
                                                ),
                                                new StringExpression(
                                                    "'command'"
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "command",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new PartialFunctionExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'checking for {0}: {1}'"
                                                        ),
                                                        new IdentifierExpression(
                                                            "name",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "ps",
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
                                                    "command",
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
                                                                new IdentifierExpression(
                                                                    "isApplication",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new StringExpression(
                                                                    "'[bool](Get-Command {0} -CommandType Application -ErrorAction SilentlyContinue)'"
                                                                ),
                                                                new StringExpression(
                                                                    "'[bool](Get-Command {0} -ErrorAction SilentlyContinue)'"
                                                                )
                                                            ),
                                                        }
                                                    )
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "ps",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new PartialFunctionExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Running command to perform check: {0}'"
                                                        ),
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "ps",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "psContext",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "engine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "AddScript",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
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
                                        new TryExpression(
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "r",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Invoke",
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
                                            },
                                            null,
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new BooleanExpression(
                                                        false
                                                    ),
                                                    false
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Commands",
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
                                            }
                                        ),
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
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "r",
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
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "r",
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
                                                        "BaseObject",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new BooleanExpression(
                                                    false
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "r",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new PartialFunctionExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Is {0}: {1}'"
                                                        ),
                                                        new IdentifierExpression(
                                                            "name",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                )
                                            )
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "r",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "isCommand",
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
                                            "command",
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
                                                        "psContext",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "isCommandInternal",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "command",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new BooleanExpression(
                                                        false
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
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "isApplication",
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
                                            "command",
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
                                                        "psContext",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "isCommandInternal",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "command",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new BooleanExpression(
                                                        true
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
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "execPositional",
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
                                            "parts",
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
                                                            "parts",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.EqualityOperator,
                                                        new NullExpression(
                                                        )
                                                    ),
                                                    AphidTokenType.OrOperator,
                                                    new BinaryOperatorExpression(
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.PostfixCountOperator,
                                                            new IdentifierExpression(
                                                                "parts",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                        AphidTokenType.EqualityOperator,
                                                        new NumberExpression(
                                                            0
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.OrOperator,
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "parts",
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
                                                    AphidTokenType.EqualityOperator,
                                                    new NullExpression(
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "tracePS",
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
                                                new BinaryOperatorExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "var",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        true
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "tracePS",
                                                            new List<IdentifierExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "var",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "fmt",
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
                                                                    "print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'{0} Trace: ~Magenta~{1}~R~'"
                                                                    ),
                                                                    new StringExpression(
                                                                        "'PS'"
                                                                    ),
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
                                                                                    "'[Nothing]'"
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        0
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new PatternExpression(
                                                                                new IdentifierExpression(
                                                                                    "fmt",
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
                                                                                        new IdentifierExpression(
                                                                                            "fmt",
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
                                                                                new List<AphidExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    }
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "result",
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
                                                            "parts",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new IdentifierExpression(
                                                            "parts",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "isItem",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new BooleanExpression(
                                                            false
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
                                                        new BooleanExpression(
                                                            true
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
                                                        new NullExpression(
                                                        )
                                                    ),
                                                },
                                                null
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "parts",
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
                                            AphidTokenType.PipelineOperator,
                                            new PartialFunctionExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Checking if is command or application: {0} of type {1}'"
                                                        ),
                                                        new ArrayAccessExpression(
                                                            new IdentifierExpression(
                                                                "parts",
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
                                                    }
                                                )
                                            )
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "parts",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "isApplication",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.OrOperator,
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "parts",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "isCommand",
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
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Preparing application {0}'"
                                                        ),
                                                        new ArrayAccessExpression(
                                                            new IdentifierExpression(
                                                                "parts",
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
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "result",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "isCommand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BooleanExpression(
                                                        true
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "applicationCommand",
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
                                                                    "parts",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.SelectOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "restorePSObject",
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
                                                                        new TernaryOperatorExpression(
                                                                            AphidTokenType.ConditionalOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.NotOperator,
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "string",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "IsNullOrEmpty",
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
                                                                                AphidTokenType.AndOperator,
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new ImplicitArgumentExpression(
                                                                                                    AphidTokenType.ImplicitArgumentOperator
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
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Contains",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new StringExpression(
                                                                                            "' '"
                                                                                        ),
                                                                                    }
                                                                                )
                                                                            ),
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
                                                                                        "'\"{0}\"'"
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Replace",
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
                                                                                            new StringExpression(
                                                                                                "'`\"'"
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new ImplicitArgumentExpression(
                                                                                AphidTokenType.ImplicitArgumentOperator
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
                                                                            new IdentifierExpression(
                                                                                "x",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AdditionOperator,
                                                                            new StringExpression(
                                                                                "' '"
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
                                                    )
                                                ),
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Executing application command {0}'"
                                                        ),
                                                        new IdentifierExpression(
                                                            "applicationCommand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "result",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "obj",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "applicationCommand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "pipe",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    )
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new IfExpression(
                                                    new BinaryOperatorExpression(
                                                        new ArrayAccessExpression(
                                                            new IdentifierExpression(
                                                                "parts",
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "isCommand",
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
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'Executing command {0}'"
                                                                ),
                                                                new ArrayAccessExpression(
                                                                    new IdentifierExpression(
                                                                        "parts",
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
                                                            }
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "result",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "isCommand",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BooleanExpression(
                                                                true
                                                            )
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "result",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "isApplication",
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
                                                                    "result",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "obj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "parts",
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "psContext",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "restorePSObject",
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
                                                                                    "psContext",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "pipe",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "parts",
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
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                AphidTokenType.PipelineOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "importPSObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                        new IfExpression(
                                                            new BinaryOperatorExpression(
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new IdentifierExpression(
                                                                        "parts",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                                AphidTokenType.GreaterThanOperator,
                                                                new NumberExpression(
                                                                    1
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "error",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new StringExpression(
                                                                        "'Unknown command'"
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "tracePS",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "result",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "error",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "obj",
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
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "success",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new IdentifierExpression(
                                                                        "result",
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
                                                            new IdentifierExpression(
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'Getting PS item {0}'"
                                                                ),
                                                                new ArrayAccessExpression(
                                                                    new IdentifierExpression(
                                                                        "parts",
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
                                                            }
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "result",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "obj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BinaryOperatorExpression(
                                                                new ArrayAccessExpression(
                                                                    new IdentifierExpression(
                                                                        "parts",
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "getItem",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                        new IfExpression(
                                                            new BinaryOperatorExpression(
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "obj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
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
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "isItem",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new BooleanExpression(
                                                                        true
                                                                    )
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "isItem",
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
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "obj",
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
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "error",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new StringExpression(
                                                                        "'Unknown command'"
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "success",
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
                                                            }
                                                        ),
                                                        new IfExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "obj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new IdentifierExpression(
                                                                        "isCollection",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.PostfixCountOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "result",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "obj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        false
                                                                    ),
                                                                    AphidTokenType.EqualityOperator,
                                                                    new NumberExpression(
                                                                        1
                                                                    )
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "tracePS",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new StringExpression(
                                                                            "'Unwrapping PS item'"
                                                                        ),
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "result",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "obj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new ArrayAccessExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "result",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "obj",
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
                                                                    )
                                                                ),
                                                            },
                                                            null
                                                        ),
                                                    }
                                                ),
                                            }
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "result",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "getItem",
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
                                            "path",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "tracePS",
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
                                                new BinaryOperatorExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "var",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        true
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "tracePS",
                                                            new List<IdentifierExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "var",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "fmt",
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
                                                                    "print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'{0} Trace: ~Magenta~{1}~R~'"
                                                                    ),
                                                                    new StringExpression(
                                                                        "'PS'"
                                                                    ),
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
                                                                                    "'[Nothing]'"
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        0
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new PatternExpression(
                                                                                new IdentifierExpression(
                                                                                    "fmt",
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
                                                                                        new IdentifierExpression(
                                                                                            "fmt",
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
                                                                                new List<AphidExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    }
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
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
                                        new TryExpression(
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "tracePS",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new StringExpression(
                                                                "'Invoking Get-Item {0}'"
                                                            ),
                                                            AphidTokenType.CustomOperator214,
                                                            new ArrayExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "path",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new StringExpression(
                                                        "'Get-Item'"
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "engine",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "AddCommand",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "path",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "engine",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "AddArgument",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "r",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Invoke",
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
                                            },
                                            new IdentifierExpression(
                                                "e",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "r",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new NullExpression(
                                                    )
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Commands",
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
                                            }
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "r",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "execNamed",
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
                                            "command",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "params",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "command",
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
                                                "command",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "psContext",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "engine",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "AddCommand",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "params",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new IdentifierExpression(
                                                    "keys",
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
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "engine",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "AddParameter",
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "params",
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
                                                            }
                                                        ),
                                                        false
                                                    ),
                                                }
                                            )
                                        ),
                                        new TryExpression(
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Invoke",
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
                                            },
                                            null,
                                            null,
                                            new List<AphidExpression>
                                            {
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Commands",
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
                                            }
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "r",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "outString",
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
                                            "obj",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "tracePS",
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
                                                new BinaryOperatorExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "psContext",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "tracePS",
                                                                new List<IdentifierExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "var",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        true
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "tracePS",
                                                            new List<IdentifierExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "var",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "fmt",
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
                                                                    "print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'{0} Trace: ~Magenta~{1}~R~'"
                                                                    ),
                                                                    new StringExpression(
                                                                        "'PS'"
                                                                    ),
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
                                                                                    "'[Nothing]'"
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new NumberExpression(
                                                                                        0
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new PatternExpression(
                                                                                new IdentifierExpression(
                                                                                    "fmt",
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
                                                                                        new IdentifierExpression(
                                                                                            "fmt",
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
                                                                                new List<AphidExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                    }
                                                ),
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "obj",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new NullExpression(
                                                    )
                                                ),
                                                AphidTokenType.AndOperator,
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "isCollection",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "obj",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "obj",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "obj",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.SelectOperator,
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "aphid",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "ValueHelper",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Unwrap",
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
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new ObjectExpression(
                                                        new List<BinaryOperatorExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "InputObject",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.ColonOperator,
                                                                new IdentifierExpression(
                                                                    "obj",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                        },
                                                        null
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new PartialFunctionExpression(
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "psContext",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "execNamed",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "'Out-String'"
                                                                ),
                                                            }
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.PipelineOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "aq",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "first",
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
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "pipe",
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
                                            "script",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "pipelineInput",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new UsingExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "p",
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
                                                                    "psContext",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "engine",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Runspace",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "CreatePipeline",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "checkedOutput",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "writeAsync",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "handler",
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
                                                                "o",
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
                                                            new TryExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                    new IfExpression(
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.NotOperator,
                                                                            new IdentifierExpression(
                                                                                "checkedOutput",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            false
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IfExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "o",
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
                                                                                        0
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
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "pso",
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
                                                                                            "writeAsync",
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
                                                                                                            "pso",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.AssignmentOperator,
                                                                                                        new CallExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "o",
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
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.NotEqualOperator,
                                                                                                    new NullExpression(
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AndOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "pso",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "BaseObject",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.NotEqualOperator,
                                                                                                    new NullExpression(
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.AndOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new CallExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "pso",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "BaseObject",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
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
                                                                                                AphidTokenType.EqualityOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "string",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "checkedOutput",
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
                                                                            ),
                                                                        },
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IfExpression(
                                                                                new IdentifierExpression(
                                                                                    "writeAsync",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "o",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "NonBlockingRead",
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
                                                                                                                        "BaseObject",
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
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "Cli",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "StyleEscape",
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
                                                                                                            AphidTokenType.AdditionOperator,
                                                                                                            new StringExpression(
                                                                                                                "'\\r\\n'"
                                                                                                            )
                                                                                                        ),
                                                                                                        false
                                                                                                    ),
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.SelectOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "shell",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "out",
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
                                                                },
                                                                new IdentifierExpression(
                                                                    "e",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "e",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Cli",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "StyleEscape",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        AphidTokenType.PipelineOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "shell",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "out",
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
                                                    )
                                                ),
                                                new CallExpression(
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
                                                                "Output",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "add_DataReady",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "handler",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new CallExpression(
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
                                                                "Error",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "add_DataReady",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "handler",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new IfExpression(
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.definedKeyword,
                                                        new IdentifierExpression(
                                                            "pipelineInput",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        true
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new CallExpression(
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
                                                                        "Input",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Write",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "pipelineInput",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        ),
                                                        new CallExpression(
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
                                                                        "Commands",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
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
                                                                    "script",
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
                                                                        "Commands",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "AddScript",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "script",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new TryExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.retKeyword,
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
                                                                        "Invoke",
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
                                                    },
                                                    null,
                                                    null,
                                                    new List<AphidExpression>
                                                    {
                                                        new CallExpression(
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
                                                                        "Commands",
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
                                        "psContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "pipeDump",
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
                                            "script",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "pipelineInput",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "result",
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
                                                    new IdentifierExpression(
                                                        "pipelineInput",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "pipe",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "script",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new IdentifierExpression(
                                                            "pipelineInput",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "psContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "pipe",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "script",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
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
                                                        "result",
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
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "result",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "shell",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "dumpObject",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "shell",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "out",
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
                                )
                            ),
                            new ExtendExpression(
                                new IdentifierExpression(
                                    "PSObject",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new ObjectExpression(
                                    new List<BinaryOperatorExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "funcHandler",
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
                                                        "psObj",
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
                                                    new IdentifierExpression(
                                                        "method",
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
                                                        "methods",
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
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "argTypes",
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
                                                                "args",
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
                                                                            new BinaryOperatorExpression(
                                                                                new ImplicitArgumentExpression(
                                                                                    AphidTokenType.ImplicitArgumentOperator
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
                                                                        false
                                                                    ),
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psObj",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "BaseObject",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.NotEqualOperator,
                                                                    new NullExpression(
                                                                    )
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new IdentifierExpression(
                                                                    "method",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "psObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "BaseObject",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
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
                                                                            "GetMethod",
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
                                                                        new IdentifierExpression(
                                                                            "argTypes",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                AphidTokenType.NotEqualOperator,
                                                                new NullExpression(
                                                                )
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "method",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Invoke",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "psObj",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "BaseObject",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
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
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.PostfixCountOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "methods",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "psObj",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "BaseObject",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
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
                                                                                    "GetMethods",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.WhereOperator,
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
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Name",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.EqualityOperator,
                                                                                        new IdentifierExpression(
                                                                                            "name",
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
                                                                false
                                                            ),
                                                            AphidTokenType.NotEqualOperator,
                                                            new NumberExpression(
                                                                0
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new ArrayAccessExpression(
                                                                                new IdentifierExpression(
                                                                                    "methods",
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
                                                                                "Invoke",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
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
                                                                    AphidTokenType.PipelineOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "psContext",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "importPSObject",
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
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "psObj",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "BaseObject",
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
                                                                    AphidTokenType.NotEqualOperator,
                                                                    new NullExpression(
                                                                    )
                                                                ),
                                                                AphidTokenType.AndOperator,
                                                                new IdentifierExpression(
                                                                    "method",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "psObj",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "BaseObject",
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
                                                                            "GetMethod",
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
                                                                        new IdentifierExpression(
                                                                            "argTypes",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                AphidTokenType.NotEqualOperator,
                                                                new NullExpression(
                                                                )
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "method",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Invoke",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "psObj",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "BaseObject",
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
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "fatal",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new StringExpression(
                                                                    "'Could not find PowerShell object method with name \"{0}\".'"
                                                                ),
                                                                AphidTokenType.CustomOperator214,
                                                                new ArrayExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "name",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "toAphidObject",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "psContext",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "importPSObject",
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
                        }
                    )
                ),
                new CallExpression(
                    new IdentifierExpression(
                        "initPSInterop",
                        new List<IdentifierExpression>
                        {
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
