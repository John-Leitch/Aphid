namespace BuiltInLibrary.Library.Debugging
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> NativeDebugging()
        {
            return             new List<AphidExpression>
            {
                new IdentifierExpression(
                    "scanMemory",
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
                    "debugCommand",
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
                    "catchExceptions",
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
                            new UnaryOperatorExpression(
                                AphidTokenType.usingKeyword,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "Components",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Cypress",
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
                                        "Components",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "PInvoke",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
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
                                    new IdentifierExpression(
                                        "System",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ComponentModel",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "catchExceptions",
                                    new List<IdentifierExpression>
                                    {
                                    }
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
                                            "callback",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dbg",
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
                                                        "NativeDebugger",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dbg",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "add_DebugEventReceived",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new FunctionExpression(
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "sender",
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
                                                        new SwitchExpression(
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
                                                                        "DebugEvent",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "dwDebugEventCode",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<SwitchCase>
                                                            {
                                                                new SwitchCase(
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EXCEPTION_DEBUG_EVENT",
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
                                                                                "print",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new StringExpression(
                                                                                    "'Exception: ~Red~{0}~R~'"
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "e",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "callback",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
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
                                                                            "'Debug event: {0}'"
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                ),
                                                            }
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
                                                                        "DebugEvent",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "ContinueUnhandled",
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
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dbg",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "StartProcess",
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
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "dbg",
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
                                    "debugCommand",
                                    new List<IdentifierExpression>
                                    {
                                    }
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
                                            "eventMap",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "debugGlobals",
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
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.NotOperator,
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.definedKeyword,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    true
                                                ),
                                                false
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new IdentifierExpression(
                                                        "eventMap",
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
                                            new UnaryOperatorExpression(
                                                AphidTokenType.newKeyword,
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "AphidFunction",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new ArrayExpression(
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'sender'"
                                                                    ),
                                                                    new StringExpression(
                                                                        "'e'"
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
                                                                    "ToArray",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
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
                                                                            "AphidExpression",
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
                                                        ),
                                                        new ThisExpression(
                                                        ),
                                                    }
                                                ),
                                                false
                                            )
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "exception",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EXCEPTION_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "exception",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "createThread",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "CREATE_THREAD_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "createThread",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "createProcess",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "CREATE_PROCESS_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "createProcess",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "exitThread",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EXIT_THREAD_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "exitThread",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "exitProcess",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "EXIT_PROCESS_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "exitProcess",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "loadDll",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "LOAD_DLL_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "loadDll",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "outputDebugSring",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "OUTPUT_DEBUG_STRING_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "outputDebugSring",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "ripEvent",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "RIP_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "ripEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "debugGlobals",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "eventMap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "unloadDll",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
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
                                                                                    "DebugEvent",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dwDebugEventCode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.EqualityOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "DebugEventType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "UNLOAD_DLL_DEBUG_EVENT",
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
                                                                                        "debugGlobals",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "eventMap",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "unloadDll",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "sender",
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
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "handler",
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
                                                            "AddRange",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "handler",
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
                                                    "Add",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new ArrayAccessExpression(
                                                    new BinaryOperatorExpression(
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
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
                                                                                "DebugEvent",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "ContinueUnhandled",
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
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dbg",
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
                                                        "NativeDebugger",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dbg",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "add_DebugEventReceived",
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
                                                new IdentifierExpression(
                                                    "dbg",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "StartProcess",
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
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "dbg",
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
                                    "scanMemory",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "memory",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "start",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "end",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "step",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "start",
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
                                                        "start",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new IdentifierExpression(
                                                    "start",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new NumberExpression(
                                                    0
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "end",
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
                                                        "end",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new IdentifierExpression(
                                                    "end",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new NumberExpression(
                                                    2147418112
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "step",
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
                                                        "step",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    true
                                                ),
                                                new IdentifierExpression(
                                                    "step",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new NumberExpression(
                                                    4096
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "intPtrType",
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
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new StringExpression(
                                                        "'System.IntPtr'"
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "blocks",
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
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
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
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "start",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new DoWhileExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "i",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.LessThanOrEqualOperator,
                                                new IdentifierExpression(
                                                    "end",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "addr",
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
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "Convert",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ToInt64",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "mem",
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
                                                            AphidTokenType.newKeyword,
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "IntPtr",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "addr",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "memory",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ReadMemoryInfo",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    )
                                                ),
                                                new IfExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "mem",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Protect",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            AphidTokenType.NotEqualOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "AllocationProtect",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "None",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.AndOperator,
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "mem",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Protect",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.BinaryAndOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "AllocationProtect",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "PAGE_NOACCESS",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            AphidTokenType.NotEqualOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "AllocationProtect",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "PAGE_NOACCESS",
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
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "blocks",
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
                                                                                "address",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "addr",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "region",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.ColonOperator,
                                                                            new IdentifierExpression(
                                                                                "mem",
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "endOfRegion",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "mem",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "AllocationBase",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "ToInt64",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "mem",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "RegionSize",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "ToInt64",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        new IfExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "addr",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.LessThanOperator,
                                                                new IdentifierExpression(
                                                                    "endOfRegion",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "i",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new IdentifierExpression(
                                                                        "endOfRegion",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "mem",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "RegionSize",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "ToInt64",
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
                                                                        new NumberExpression(
                                                                            0
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "i",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PlusEqualOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "mem",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "RegionSize",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "ToInt64",
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
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "i",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PlusEqualOperator,
                                                                            new IdentifierExpression(
                                                                                "step",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
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
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "mem",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "RegionSize",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "ToInt64",
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
                                                                new NumberExpression(
                                                                    0
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "i",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.PlusEqualOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "mem",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "RegionSize",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "ToInt64",
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
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "i",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.PlusEqualOperator,
                                                                    new IdentifierExpression(
                                                                        "step",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                            }
                                                        ),
                                                    }
                                                ),
                                            }
                                        ),
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
                                                    "'Done'"
                                                ),
                                            }
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "blocks",
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
