namespace BuiltInLibrary.Library.Data
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Xml()
        {
            return             new List<AphidExpression>
            {
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
                                "Xml",
                                new List<IdentifierExpression>
                                {
                                }
                            )
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
                                "Xml",
                                new List<IdentifierExpression>
                                {
                                }
                            )
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
                    new BinaryOperatorExpression(
                        new ThisExpression(
                        ),
                        AphidTokenType.MemberOperator,
                        new DynamicMemberExpression(
                            new StringExpression(
                                "'$scope'"
                            )
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "xdoc",
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
                                    "open",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "XDocument",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Load",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "read",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "XDocument",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Load",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "parse",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "XDocument",
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
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "fromString",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "XDocument",
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
                                )
                            ),
                        },
                        null
                    )
                ),
                new IdentifierExpression(
                    "xsd",
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
                                    "xsd",
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
                                                "path",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new StringExpression(
                                                "'C:\\\\Program Files (x86)\\\\Microsoft SDKs\\\\Windows\\\\v10.0A\\\\bin\\\\NETFX 4.7.2 Tools\\\\xsd.exe'"
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "generateDataSet",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "name",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "ns",
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
                                                                "Diagnostics",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        false
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
                                                                    "'/d /l:CS \"{0}.xsd\" /eld /n:{1}'"
                                                                ),
                                                                new IdentifierExpression(
                                                                    "name",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "ns",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
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
                                                                new IdentifierExpression(
                                                                    "Process",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Start",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "path",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "args",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
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
                                                                "WaitForExit",
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "extendXElement",
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
                                        new ExtendExpression(
                                            new IdentifierExpression(
                                                "XElement",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new ObjectExpression(
                                                new List<BinaryOperatorExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "descendants",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new TernaryOperatorExpression(
                                                                            AphidTokenType.ConditionalOperator,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.definedKeyword,
                                                                                new IdentifierExpression(
                                                                                    "name",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                true
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "XName",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Get",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Descendants",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Descendants",
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "descendant",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "element",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "descendants",
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
                                                                                "Enumerable",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Single",
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
                                                            "elements",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new TernaryOperatorExpression(
                                                                            AphidTokenType.ConditionalOperator,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.definedKeyword,
                                                                                new IdentifierExpression(
                                                                                    "name",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                true
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "XName",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Get",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Elements",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Elements",
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "element",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "XName",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Get",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            )
                                                                        ),
                                                                        AphidTokenType.PipelineOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "element",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Element",
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
                                                            "val",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.definedKeyword,
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            true
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "element",
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
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Value",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "element",
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "dec",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.definedKeyword,
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            true
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "element",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "element",
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
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Value",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
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
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "element",
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
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
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
                                                            "int",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.definedKeyword,
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            true
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "element",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "element",
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
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Value",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Int32",
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
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "element",
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
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "Int32",
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
                                                            "date",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.definedKeyword,
                                                                            new IdentifierExpression(
                                                                                "name",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            true
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "element",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "element",
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
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Value",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
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
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "element",
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
                                                                            ),
                                                                            AphidTokenType.PipelineOperator,
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
                                                            "attr",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "element",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new TernaryOperatorExpression(
                                                                        AphidTokenType.ConditionalOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "XName",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Get",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Attribute",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            AphidTokenType.NotEqualOperator,
                                                                            new NullExpression(
                                                                            )
                                                                        ),
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "name",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.PipelineOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "XName",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "Get",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "element",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Attribute",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
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
                                                            "dispatch",
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
                                                                    "element",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "action",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
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
                                                                        "element",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new ForEachExpression(
                                                                    new ArrayExpression(
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "e",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "attr",
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
                                                                                    "elements",
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
                                                                                    "descendants",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
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
                                                                                        new CallExpression(
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "action",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
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
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "a",
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
                                                                                            "string",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    AphidTokenType.OrOperator,
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
                                                                                        AphidTokenType.GreaterThanOperator,
                                                                                        new NumberExpression(
                                                                                            0
                                                                                        )
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.retKeyword,
                                                                                    new IdentifierExpression(
                                                                                        "a",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    false
                                                                                ),
                                                                            },
                                                                            null
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new NullExpression(
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
                                        new ExtendExpression(
                                            new IdentifierExpression(
                                                "XElement",
                                                new List<IdentifierExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "list",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            ),
                                            new ObjectExpression(
                                                new List<BinaryOperatorExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "map",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "elements",
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
                                                                        new IdentifierExpression(
                                                                            "elements",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                                },
                                                null
                                            )
                                        ),
                                        new ExtendExpression(
                                            new IdentifierExpression(
                                                "XDocument",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new ObjectExpression(
                                                new List<BinaryOperatorExpression>
                                                {
                                                },
                                                null
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "_p",
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
                                                "print",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "_p",
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
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new ThisExpression(
                                                    ),
                                                    AphidTokenType.PipelineOperator,
                                                    new IdentifierExpression(
                                                        "keys",
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
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "k",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
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
                                                                        "'$ext'"
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
                                                        "k",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new ImplicitArgumentExpression(
                                                            AphidTokenType.ImplicitArgumentOperator
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new PartialFunctionExpression(
                                                            new CallExpression(
                                                                new IdentifierExpression(
                                                                    "_p",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'Importing extension method ~Magenta~{0}~R~'"
                                                                    ),
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "p",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new DynamicMemberExpression(
                                                                new ImplicitArgumentExpression(
                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new BinaryOperatorExpression(
                                                            new ThisExpression(
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new DynamicMemberExpression(
                                                                new ImplicitArgumentExpression(
                                                                    AphidTokenType.ImplicitArgumentOperator
                                                                )
                                                            )
                                                        )
                                                    ),
                                                }
                                            )
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "initXml",
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
                                                "xdExtend",
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
                                                        "extendXElement",
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
                                                new PartialFunctionExpression(
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "ast",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "firstNode",
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
                                                                        "n",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "n",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "isExt",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "XDocument",
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
                                                    )
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "extendXElement",
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
                                                                new PartialFunctionExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "ast",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "firstNode",
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
                                                                                        "n",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
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
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "n",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "isExt",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "XElement",
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
                                                                    )
                                                                )
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
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "pairs",
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
                                                            "ext",
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
                                                                            "p",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "argList",
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
                                                                    "ast",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "block",
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
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
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
                                                                        "args",
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
                                                                "argList",
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
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "funcBody",
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
                                                                    "ast",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "block",
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
                                                                "funcBody",
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
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "ast",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "return",
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
                                                                                "ast",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "call",
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
                                                                                        "ast",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "member",
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
                                                                                                "ast",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "member",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new ArrayAccessExpression(
                                                                                                new CallExpression(
                                                                                                    new BinaryOperatorExpression(
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
                                                                                                            "args",
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
                                                                                            ),
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "ast",
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
                                                                                                    new StringExpression(
                                                                                                        "'Root'"
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "ast",
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
                                                                                                "ext",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "argList",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.newKeyword,
                                                                new CallExpression(
                                                                    new IdentifierExpression(
                                                                        "FunctionExpression",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
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
                                                                                    "args",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new IdentifierExpression(
                                                                            "funcBody",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                false
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new PartialFunctionExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "ast",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "pair",
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
                                                                                    "ast",
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
                                                                                    "ext",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "xdExtend",
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
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "pairs",
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
                                                                "Add",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                }
                                            )
                                        ),
                                    }
                                )
                            ),
                            new CallExpression(
                                new IdentifierExpression(
                                    "initXml",
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
                                    "extendXElement",
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
                    new List<AphidExpression>
                    {
                    }
                ),
            }
;
        }
    }
}
