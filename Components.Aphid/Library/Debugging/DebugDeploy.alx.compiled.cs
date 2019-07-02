namespace BuiltInLibrary.Library.Debugging
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> DebugDeploy()
        {
            return             new List<AphidExpression>
            {
                new CallExpression(
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                        },
                        new List<AphidExpression>
                        {
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
                                        "Diagnostics",
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
                                        "Reflection",
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
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'Std'"
                                )
                            ),
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'System/Process'"
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "dv",
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
                                            "deployVerbosity",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    new IdentifierExpression(
                                        "deployVerbosity",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new NumberExpression(
                                        1
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "_print",
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
                                        new IdentifierExpression(
                                            "dv",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new NumberExpression(
                                            0
                                        )
                                    ),
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
                                    "scriptDir",
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
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "Assembly",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "GetExecutingAssembly",
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
                                            "Location",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.PipelineOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "io",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "up",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "searchPaths",
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
                                                    "string",
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
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "AphidConfig",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Current",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "SourcePath",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.NotEqualOperator,
                                    new NullExpression(
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "searchPaths",
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
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "AphidConfig",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Current",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "SourcePath",
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
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new UnaryOperatorExpression(
                                        AphidTokenType.definedKeyword,
                                        new IdentifierExpression(
                                            "aphidSource",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "aphidSource",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new NullExpression(
                                        )
                                    )
                                ),
                                new List<AphidExpression>
                                {
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "searchPaths",
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
                                                "aphidSource",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                },
                                null
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "searchPaths",
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
                                        "scriptDir",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new IdentifierExpression(
                                "src",
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
                            new ForEachExpression(
                                new IdentifierExpression(
                                    "searchPaths",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "cur",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.PipelineOperator,
                                        new PartialFunctionExpression(
                                            new CallExpression(
                                                new IdentifierExpression(
                                                    "_print",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new StringExpression(
                                                        "'Script dir: ~Green~{0}~R~'"
                                                    ),
                                                }
                                            )
                                        )
                                    ),
                                    new DoWhileExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "cur",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.AssignmentOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "cur",
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
                                                            "up",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                )
                                            ),
                                            AphidTokenType.NotEqualOperator,
                                            new NullExpression(
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "search",
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
                                                            "io",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "join",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "cur",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new StringExpression(
                                                            "'Components.Aphid'"
                                                        ),
                                                        new StringExpression(
                                                            "'Library'"
                                                        ),
                                                        new StringExpression(
                                                            "'Std.alx'"
                                                        ),
                                                    }
                                                )
                                            ),
                                            new IfExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "dv",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.GreaterThanOperator,
                                                    new NumberExpression(
                                                        1
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "search",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new PartialFunctionExpression(
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'Checking dir: ~Cyan~{0}~R~'"
                                                                    ),
                                                                }
                                                            )
                                                        )
                                                    ),
                                                },
                                                null
                                            ),
                                            new IfExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "search",
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
                                                            "file",
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
                                                            "src",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "search",
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
                                                                    "up",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "src",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new PartialFunctionExpression(
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_print",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'Found source dir: ~Green~{0}~R~'"
                                                                    ),
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BreakExpression(
                                                    ),
                                                },
                                                null
                                            ),
                                        }
                                    ),
                                    new IfExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "src",
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
                                            new BreakExpression(
                                            ),
                                        },
                                        null
                                    ),
                                },
                                new IdentifierExpression(
                                    "cur",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "src",
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
                                            "_print",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new StringExpression(
                                                "'~Yellow~Could not find library dir~R~'"
                                            ),
                                        }
                                    ),
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "Environment",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Exit",
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
                                    ),
                                },
                                null
                            ),
                            new CallExpression(
                                new IdentifierExpression(
                                    "_print",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "'[~Green~+~R~] Updating standard headers'"
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "dst",
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
                                        "scriptDir",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.CustomOperator185,
                                    new StringExpression(
                                        "'Library'"
                                    )
                                )
                            ),
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
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'xcopy /e /s /d /y \"{0}\\\\*.alx\" \"{1}\"'"
                                    ),
                                    AphidTokenType.CustomOperator214,
                                    new ArrayExpression(
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "src",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new IdentifierExpression(
                                                "dst",
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
                                    "printInfo",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "'Executing command ~Cyan~{0}~R~'"
                                    ),
                                    new IdentifierExpression(
                                        "cmd",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "res",
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
                                    AphidTokenType.CustomOperator224,
                                    new IdentifierExpression(
                                        "cmd",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    false
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "res",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "exitCode",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.NotEqualOperator,
                                    new NumberExpression(
                                        0
                                    )
                                ),
                                AphidTokenType.CustomOperator040,
                                new BinaryOperatorExpression(
                                    new StringExpression(
                                        "'Fatal error, xcopy exited with code ~Yellow~{0}~R~ (~Yellow~0x{0:x8}~R~)'"
                                    ),
                                    AphidTokenType.CustomOperator214,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "res",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "exitCode",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    )
                                )
                            ),
                            new CallExpression(
                                new IdentifierExpression(
                                    "_print",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new StringExpression(
                                        "'Done'"
                                    ),
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
