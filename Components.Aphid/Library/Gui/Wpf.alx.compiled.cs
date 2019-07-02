namespace BuiltInLibrary.Library.Gui
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Wpf()
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
                            "Windows",
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
                                "Windows",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Controls",
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
                                "Windows",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Data",
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
                                "Windows",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Markup",
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
                                "Windows",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Media",
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
                                "Windows",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Input",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.loadKeyword,
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
                            "Xml",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new IdentifierExpression(
                    "wpf",
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
                    "bind",
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
                                AphidTokenType.loadKeyword,
                                new IdentifierExpression(
                                    "PresentationFramework",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                false
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.loadKeyword,
                                new IdentifierExpression(
                                    "PresentationCore",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                false
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.loadKeyword,
                                new IdentifierExpression(
                                    "WindowsBase",
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
                                        "TypeSystem",
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
                                        "Text",
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
                                        "Threading",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "wpf",
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
                                                "loadXaml",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "xamlString",
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
                                                                "x",
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
                                                                            "StringReader",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "xamlString",
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
                                                                        "XmlReader",
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
                                                                )
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "x",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.PipelineOperator,
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "XamlReader",
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
                                                                false
                                                            ),
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "saveXaml",
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
                                                    new IfExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "obj",
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
                                                                AphidTokenType.throwKeyword,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.newKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "ArgumentException",
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
                                                                false
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "settings",
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
                                                                    "XmlWriterSettings",
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "settings",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Indent",
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
                                                                "settings",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "OmitXmlDeclaration",
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
                                                                "settings",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "NewLineOnAttributes",
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
                                                                "settings",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ConformanceLevel",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "ConformanceLevel",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Fragment",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    new UsingExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "sw",
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
                                                                        "StringWriter",
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
                                                        new List<AphidExpression>
                                                        {
                                                            new UsingExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "writer",
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
                                                                                "XmlWriter",
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
                                                                            new IdentifierExpression(
                                                                                "sw",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "settings",
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
                                                                            "sm",
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
                                                                                    "XamlDesignerSerializationManager",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "writer",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            false
                                                                        )
                                                                    ),
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "sm",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "XamlWriterMode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.AssignmentOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "XamlWriterMode",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Expression",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        )
                                                                    ),
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "XamlWriter",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "Save",
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
                                                                            new IdentifierExpression(
                                                                                "sm",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "sw",
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
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "createApp",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "init",
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
                                                                new TernaryOperatorExpression(
                                                                    AphidTokenType.ConditionalOperator,
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
                                                                        AphidTokenType.GreaterThanOperator,
                                                                        new NumberExpression(
                                                                            0
                                                                        )
                                                                    ),
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "createAppAsync",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "init",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "createAppAsync",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "waitForExit",
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
                                                "createXamlAppAsync",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "loadXaml",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "init",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new IfExpression(
                                                        new UnaryOperatorExpression(
                                                            AphidTokenType.NotOperator,
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.definedKeyword,
                                                                new IdentifierExpression(
                                                                    "loadXaml",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                true
                                                            ),
                                                            false
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.throwKeyword,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.newKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "InvalidOperationException",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new StringExpression(
                                                                                "'loadXaml() not defined.'"
                                                                            ),
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                                false
                                                            ),
                                                        },
                                                        null
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "app",
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
                                                                "createAppAsync",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "init",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "setContent",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.retKeyword,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "app",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "invoke",
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
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new TryExpression(
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "app",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "window",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "Content",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AssignmentOperator,
                                                                                                new CallExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "loadXaml",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new List<AphidExpression>
                                                                                                    {
                                                                                                        new IdentifierExpression(
                                                                                                            "app",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
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
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "printError",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new StringExpression(
                                                                                                        "'Error loading XAML: {0}\\r\\n{1}'"
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
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "e",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "exception",
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
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "app",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "bindKeyAsync",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Key",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "F5",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new IdentifierExpression(
                                                                "setContent",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "setContent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                        }
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "app",
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
                                                "createAppAsync",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "init",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "consoleHidden",
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
                                                                        "GetCommandLineArgs",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
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
                                                                            new StringExpression(
                                                                                "'-console'"
                                                                            )
                                                                        ),
                                                                        false
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "consoleHidden",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new BooleanExpression(
                                                                    false
                                                                )
                                                            ),
                                                            new IfExpression(
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.NotOperator,
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "console",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "exists",
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
                                                                new List<AphidExpression>
                                                                {
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "console",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "show",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                },
                                                                null
                                                            ),
                                                        },
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "consoleHidden",
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "console",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "hide",
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
                                                                "'Creating WPF window'"
                                                            ),
                                                        }
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "wpfApp",
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
                                                    new IdentifierExpression(
                                                        "dataGrid",
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
                                                        new IdentifierExpression(
                                                            "printInfo",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'Creating reset event'"
                                                            ),
                                                        }
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "uiInitReset",
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
                                                                    "ManualResetEvent",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BooleanExpression(
                                                                        false
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        )
                                                    ),
                                                    new TryExpression(
                                                        new List<AphidExpression>
                                                        {
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "wpfApp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "uiThread",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.AssignmentOperator,
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.newKeyword,
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "Thread",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new FunctionExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new ThisExpression(
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new DynamicMemberExpression(
                                                                                                    new StringExpression(
                                                                                                        "'$aphid'"
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "SetIsInTryCatchFinally",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new BooleanExpression(
                                                                                                true
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "app",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.newKeyword,
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "Application",
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "window",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.newKeyword,
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "Window",
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "exThread",
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
                                                                                                    "Thread",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
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
                                                                                                                            "wpfApp",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "app",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "add_DispatcherUnhandledException",
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
                                                                                                                            new UsingExpression(
                                                                                                                                new UnaryOperatorExpression(
                                                                                                                                    AphidTokenType.newKeyword,
                                                                                                                                    new CallExpression(
                                                                                                                                        new IdentifierExpression(
                                                                                                                                            "CrossProcessLock",
                                                                                                                                            new List<IdentifierExpression>
                                                                                                                                            {
                                                                                                                                            }
                                                                                                                                        ),
                                                                                                                                        new List<AphidExpression>
                                                                                                                                        {
                                                                                                                                            new StringExpression(
                                                                                                                                                "'AphidWpfEx'"
                                                                                                                                            ),
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    false
                                                                                                                                ),
                                                                                                                                new List<AphidExpression>
                                                                                                                                {
                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                        new IdentifierExpression(
                                                                                                                                            "ex",
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
                                                                                                                                                    "e",
                                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                                    {
                                                                                                                                                    }
                                                                                                                                                ),
                                                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                                                new IdentifierExpression(
                                                                                                                                                    "Exception",
                                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                                    {
                                                                                                                                                    }
                                                                                                                                                )
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.BinaryOrOperator,
                                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                                new IdentifierExpression(
                                                                                                                                                    "ExceptionHelper",
                                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                                    {
                                                                                                                                                    }
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
                                                                                                                                    new CallExpression(
                                                                                                                                        new BinaryOperatorExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "Cli",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.MemberOperator,
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "WriteHeader",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            )
                                                                                                                                        ),
                                                                                                                                        new List<AphidExpression>
                                                                                                                                        {
                                                                                                                                            new StringExpression(
                                                                                                                                                "'Unhandled Dispatcher Exception'"
                                                                                                                                            ),
                                                                                                                                            new StringExpression(
                                                                                                                                                "'~White~~|Red~'"
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
                                                                                                                                            new BinaryOperatorExpression(
                                                                                                                                                new CallExpression(
                                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                                        new IdentifierExpression(
                                                                                                                                                            "ex",
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
                                                                                                                                                AphidTokenType.BinaryOrOperator,
                                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                                    new IdentifierExpression(
                                                                                                                                                        "Cli",
                                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                                        {
                                                                                                                                                        }
                                                                                                                                                    ),
                                                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                                                    new IdentifierExpression(
                                                                                                                                                        "Escape",
                                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                                        {
                                                                                                                                                        }
                                                                                                                                                    )
                                                                                                                                                )
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
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    new CallExpression(
                                                                                                                                        new BinaryOperatorExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "Cli",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.MemberOperator,
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "WriteSubheader",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            )
                                                                                                                                        ),
                                                                                                                                        new List<AphidExpression>
                                                                                                                                        {
                                                                                                                                            new StringExpression(
                                                                                                                                                "'Unhandled Dispatcher Dump'"
                                                                                                                                            ),
                                                                                                                                            new StringExpression(
                                                                                                                                                "'~White~~|Red~'"
                                                                                                                                            ),
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    new CallExpression(
                                                                                                                                        new BinaryOperatorExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "AphidCli",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.MemberOperator,
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "DumpException",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            )
                                                                                                                                        ),
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
                                                                                                                                                    "Exception",
                                                                                                                                                    new List<IdentifierExpression>
                                                                                                                                                    {
                                                                                                                                                    }
                                                                                                                                                )
                                                                                                                                            ),
                                                                                                                                            new TernaryOperatorExpression(
                                                                                                                                                AphidTokenType.ConditionalOperator,
                                                                                                                                                new UnaryOperatorExpression(
                                                                                                                                                    AphidTokenType.definedKeyword,
                                                                                                                                                    new BinaryOperatorExpression(
                                                                                                                                                        new IdentifierExpression(
                                                                                                                                                            "ex",
                                                                                                                                                            new List<IdentifierExpression>
                                                                                                                                                            {
                                                                                                                                                            }
                                                                                                                                                        ),
                                                                                                                                                        AphidTokenType.MemberOperator,
                                                                                                                                                        new IdentifierExpression(
                                                                                                                                                            "Interpreter",
                                                                                                                                                            new List<IdentifierExpression>
                                                                                                                                                            {
                                                                                                                                                            }
                                                                                                                                                        )
                                                                                                                                                    ),
                                                                                                                                                    true
                                                                                                                                                ),
                                                                                                                                                new BinaryOperatorExpression(
                                                                                                                                                    new IdentifierExpression(
                                                                                                                                                        "ex",
                                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                                        {
                                                                                                                                                        }
                                                                                                                                                    ),
                                                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                                                    new IdentifierExpression(
                                                                                                                                                        "Interpreter",
                                                                                                                                                        new List<IdentifierExpression>
                                                                                                                                                        {
                                                                                                                                                        }
                                                                                                                                                    )
                                                                                                                                                ),
                                                                                                                                                new TernaryOperatorExpression(
                                                                                                                                                    AphidTokenType.ConditionalOperator,
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
                                                                                                                                                                "Interpreter",
                                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                                {
                                                                                                                                                                }
                                                                                                                                                            )
                                                                                                                                                        ),
                                                                                                                                                        true
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
                                                                                                                                                            "Interpreter",
                                                                                                                                                            new List<IdentifierExpression>
                                                                                                                                                            {
                                                                                                                                                            }
                                                                                                                                                        )
                                                                                                                                                    ),
                                                                                                                                                    new NullExpression(
                                                                                                                                                    )
                                                                                                                                                )
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
                                                                                                                                        }
                                                                                                                                    ),
                                                                                                                                    new CallExpression(
                                                                                                                                        new BinaryOperatorExpression(
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "Cli",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            ),
                                                                                                                                            AphidTokenType.MemberOperator,
                                                                                                                                            new IdentifierExpression(
                                                                                                                                                "WriteSubheader",
                                                                                                                                                new List<IdentifierExpression>
                                                                                                                                                {
                                                                                                                                                }
                                                                                                                                            )
                                                                                                                                        ),
                                                                                                                                        new List<AphidExpression>
                                                                                                                                        {
                                                                                                                                            new StringExpression(
                                                                                                                                                "'Unhandled Dispatcher Output Complete'"
                                                                                                                                            ),
                                                                                                                                            new StringExpression(
                                                                                                                                                "'~White~~|Red~'"
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
                                                                                                                                        }
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
                                                                                            ),
                                                                                            false
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "exThread",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "IsBackground",
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
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "exThread",
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
                                                                                        }
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "invoke",
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
                                                                                                new CallExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "wpfApp",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "window",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "Dispatcher",
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
                                                                                                        new FunctionExpression(
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                            },
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "result",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    AphidTokenType.AssignmentOperator,
                                                                                                                    new CallExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "func",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        new List<AphidExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
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
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "invokeAsync",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "wpfApp",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "window",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "Dispatcher",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "InvokeAsync",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "shutdown",
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
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.retKeyword,
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "wpfApp",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "invoke",
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
                                                                                                                        "wpfApp",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    AphidTokenType.MemberOperator,
                                                                                                                    new IdentifierExpression(
                                                                                                                        "app",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                ),
                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "Shutdown",
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "wpfApp",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "createDataGrid",
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
                                                                                                new UnaryOperatorExpression(
                                                                                                    AphidTokenType.retKeyword,
                                                                                                    new CallExpression(
                                                                                                        new BinaryOperatorExpression(
                                                                                                            new IdentifierExpression(
                                                                                                                "wpf",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                            AphidTokenType.MemberOperator,
                                                                                                            new IdentifierExpression(
                                                                                                                "createDataGrid",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new IdentifierExpression(
                                                                                                                "wpfApp",
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
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "uiInitReset",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Set",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "wpfApp",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "app",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Run",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "wpfApp",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "window",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "wpfApp",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "app",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Shutdown",
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
                                                                    false
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
                                                                        "'Creating thread'"
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "wpfApp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "uiThread",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "IsBackground",
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
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "wpfApp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "uiThread",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "SetApartmentState",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "ApartmentState",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "STA",
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
                                                                        "wpfApp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "waitForExit",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "wpfApp",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "uiThread",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Join",
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
                                                                                "wpfApp",
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
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "wpfApp",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "uiThread",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
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
                                                                }
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
                                                                        "'Waiting for WPF to initialize'"
                                                                    ),
                                                                }
                                                            ),
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "uiInitReset",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "WaitOne",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                }
                                                            ),
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
                                                                    AphidTokenType.GreaterThanOperator,
                                                                    new NumberExpression(
                                                                        0
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "wpfApp",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "invoke",
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
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new UnaryOperatorExpression(
                                                                                        AphidTokenType.retKeyword,
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "init",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new IdentifierExpression(
                                                                                                    "wpfApp",
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
                                                                },
                                                                null
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "wpfApp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "bindKeyAsync",
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
                                                                            "key",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "wpfApp",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "window",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "add_PreviewKeyDown",
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
                                                                                        new IfExpression(
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
                                                                                                        "Key",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.EqualityOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "key",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            new List<AphidExpression>
                                                                                            {
                                                                                                new CallExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "action",
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
                                                                                ),
                                                                            }
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "wpfApp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "bindKeyAsync",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "Key",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "F6",
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
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.retKeyword,
                                                                                new TernaryOperatorExpression(
                                                                                    AphidTokenType.ConditionalOperator,
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "consoleHidden",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.NotOperator,
                                                                                            new IdentifierExpression(
                                                                                                "consoleHidden",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            false
                                                                                        )
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "console",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "hide",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "console",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "show",
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
                                                                                false
                                                                            ),
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "wpfApp",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "setMain",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "wpfApp",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "window",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "add_Closed",
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
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "exit",
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
                                                                            }
                                                                        ),
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new IdentifierExpression(
                                                                                "wpfApp",
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
                                                                new IdentifierExpression(
                                                                    "printSuccess",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'Initialization complete'"
                                                                    ),
                                                                }
                                                            ),
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.retKeyword,
                                                                new IdentifierExpression(
                                                                    "wpfApp",
                                                                    new List<IdentifierExpression>
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
                                                                    new IdentifierExpression(
                                                                        "uiInitReset",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Dispose",
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
                                                "createAppFromXaml",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "xaml",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "init",
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
                                                                new TernaryOperatorExpression(
                                                                    AphidTokenType.ConditionalOperator,
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
                                                                        AphidTokenType.GreaterThanOperator,
                                                                        new NumberExpression(
                                                                            1
                                                                        )
                                                                    ),
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "createAppFromXamlAsync",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "xaml",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new IdentifierExpression(
                                                                                "init",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    ),
                                                                    new CallExpression(
                                                                        new IdentifierExpression(
                                                                            "createAppFromXamlAsync",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new IdentifierExpression(
                                                                                "xaml",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "waitForExit",
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
                                                "createAppFromXamlAsync",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "xaml",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "init",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "fn",
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
                                                                AphidTokenType.GreaterThanOperator,
                                                                new NumberExpression(
                                                                    1
                                                                )
                                                            ),
                                                            new IdentifierExpression(
                                                                "init",
                                                                new List<IdentifierExpression>
                                                                {
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
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new CallExpression(
                                                            new IdentifierExpression(
                                                                "createAppAsync",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new FunctionExpression(
                                                                    new List<AphidExpression>
                                                                    {
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new ImplicitArgumentExpression(
                                                                                        AphidTokenType.ImplicitArgumentOperator
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "window",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Content",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "xaml",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "XamlReader",
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
                                                                        new CallExpression(
                                                                            new IdentifierExpression(
                                                                                "fn",
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
                                                "createDataGrid",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "app",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
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
                                                                "'Creating datagrid'"
                                                            ),
                                                        }
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "app",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "invoke",
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
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new UnaryOperatorExpression(
                                                                            AphidTokenType.retKeyword,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "DataGrid",
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
                                                "bindingMode",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "BindingMode",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "TwoWay",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dataGrid",
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
                                                            "addTextColumn",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "dataGrid",
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
                                                                    "binding",
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
                                                                                    "dataGrid",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Dispatcher",
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
                                                                            new FunctionExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "col",
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
                                                                                                    "DataGridTextColumn",
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
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "col",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Header",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
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
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "col",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Binding",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new UnaryOperatorExpression(
                                                                                            AphidTokenType.newKeyword,
                                                                                            new CallExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "Binding",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IdentifierExpression(
                                                                                                        "binding",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            false
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "col",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "Binding",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Mode",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new IdentifierExpression(
                                                                                            "bindingMode",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "dataGrid",
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
                                                                                                "col",
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
                                                                    false
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "addButtonColumn",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.ColonOperator,
                                                        new FunctionExpression(
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "dataGrid",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "header",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "content",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "width",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "handler",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "isTextContent",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "content",
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
                                                                    )
                                                                ),
                                                                new IdentifierExpression(
                                                                    "template",
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
                                                                    new IdentifierExpression(
                                                                        "isTextContent",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "template",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new UnaryOperatorExpression(
                                                                                AphidTokenType.newKeyword,
                                                                                new CallExpression(
                                                                                    new IdentifierExpression(
                                                                                        "DataTemplate",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "Button",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                false
                                                                            )
                                                                        ),
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "template",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.AssignmentOperator,
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "XamlReader",
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
                                                                                        new StringExpression(
                                                                                            "'\r\n                        <DataTemplate\r\n                            xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n                            xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n                            DataType=\"Button\">\r\n                            <DataTemplate.Resources>\r\n                                <Style TargetType=\"{{x:Type Button}}\">\r\n                                    <Setter Property=\"ContentTemplate\">\r\n                                        <Setter.Value>\r\n                                            <DataTemplate>\r\n                                                {0}\r\n                                            </DataTemplate>\r\n                                        </Setter.Value>\r\n                                    </Setter>\r\n                                </Style>\r\n                            </DataTemplate.Resources>\r\n                        </DataTemplate>\r\n                    '"
                                                                                        ),
                                                                                        AphidTokenType.CustomOperator214,
                                                                                        new TernaryOperatorExpression(
                                                                                            AphidTokenType.ConditionalOperator,
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "content",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.NotEqualOperator,
                                                                                                new NullExpression(
                                                                                                )
                                                                                            ),
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "content",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.PipelineOperator,
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "XamlWriter",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "Save",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            new StringExpression(
                                                                                                "''"
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "dgTemplateColumn",
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
                                                                                "DataGridTemplateColumn",
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
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "dgTemplateColumn",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Header",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new IdentifierExpression(
                                                                        "header",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "dgTemplateColumn",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "CellTemplate",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new IdentifierExpression(
                                                                        "template",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "buttonFactory",
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
                                                                                "FrameworkElementFactory",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "Button",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                        false
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "template",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "VisualTree",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.AssignmentOperator,
                                                                    new IdentifierExpression(
                                                                        "buttonFactory",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new IfExpression(
                                                                    new IdentifierExpression(
                                                                        "isTextContent",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "buttonFactory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "SetValue",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "Button",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "ContentProperty",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "content",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                    },
                                                                    null
                                                                ),
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "width",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "buttonFactory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "SetValue",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "Button",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "WidthProperty",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "width",
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
                                                                                            "ToDouble",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                    },
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "buttonFactory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "SetValue",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "FrameworkElement",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "HorizontalAlignmentProperty",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "HorizontalAlignment",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Center",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "handler",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.PipelineOperator,
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "wpf",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "routedEventHandler",
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
                                                                                    "buttonFactory",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "AddHandler",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "Button",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "ClickEvent",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        )
                                                                    )
                                                                ),
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "dataGrid",
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
                                                                            "dgTemplateColumn",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "eventHandler",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "delegateType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "func",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "wrapper",
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
                                                                    "AphidFunctionWrapper",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new ThisExpression(
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new DynamicMemberExpression(
                                                                            new StringExpression(
                                                                                "'$aphid'"
                                                                            )
                                                                        )
                                                                    ),
                                                                    new IdentifierExpression(
                                                                        "func",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "paramTypes",
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
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "delegateType",
                                                                                new List<IdentifierExpression>
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
                                                                            new StringExpression(
                                                                                "'Invoke'"
                                                                            ),
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "GetParameters",
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
                                                                                "ParameterType",
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
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new ArrayAccessExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "wrapper",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Call",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Members",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new NumberExpression(
                                                                                    2
                                                                                ),
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "MakeGenericMethod",
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
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "paramTypes",
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
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "paramTypes",
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
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "CreateDelegate",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "delegateType",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "wrapper",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Call",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Target",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "routedEventHandler",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "handler",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "wrapper",
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
                                                                    "AphidFunctionWrapper",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new BinaryOperatorExpression(
                                                                        new ThisExpression(
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new DynamicMemberExpression(
                                                                            new StringExpression(
                                                                                "'$aphid'"
                                                                            )
                                                                        )
                                                                    ),
                                                                    new IdentifierExpression(
                                                                        "handler",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            false
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new ArrayAccessExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "wrapper",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Call",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "Members",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new NumberExpression(
                                                                                    2
                                                                                ),
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "MakeGenericMethod",
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
                                                                                new IdentifierExpression(
                                                                                    "Object",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new IdentifierExpression(
                                                                                    "RoutedEventArgs",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "CreateDelegate",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "RoutedEventHandler",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "wrapper",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "Call",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Target",
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
                                    },
                                    null
                                )
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
                                        "Collections",
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
                                        "Reflection",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "bind",
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
                                                "toViewModel",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "viewModelType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "context",
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
                                                            new TernaryOperatorExpression(
                                                                AphidTokenType.ConditionalOperator,
                                                                new BinaryOperatorExpression(
                                                                    new CallExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "context",
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
                                                                    AphidTokenType.NotEqualOperator,
                                                                    new IdentifierExpression(
                                                                        "AphidObject",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new IdentifierExpression(
                                                                    "typeToViewModel",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "objToViewModel",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "viewModelType",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new IdentifierExpression(
                                                                    "context",
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
                                                "collectionType",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new IdentifierExpression(
                                                            "ObservableCollection",
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
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "GetGenericTypeDefinition",
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
                                                "typeToViewModel",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "viewModelType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "context",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "ctxType",
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
                                                                    "context",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "vm",
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
                                                                    "viewModelType",
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "viewModelType",
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
                                                                                    "Name",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.NotEqualOperator,
                                                                            new StringExpression(
                                                                                "'ViewModelDataSource'"
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
                                                                    new ImplicitArgumentExpression(
                                                                        AphidTokenType.ImplicitArgumentOperator
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
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "contextProp",
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
                                                                                "ctxType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "GetProperty",
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
                                                                    )
                                                                ),
                                                                new IfExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "contextProp",
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "contextPropValue",
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
                                                                                        "contextProp",
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
                                                                                    new IdentifierExpression(
                                                                                        "context",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            )
                                                                        ),
                                                                        new IfExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.NotOperator,
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
                                                                                                "PropertyType",
                                                                                                new List<IdentifierExpression>
                                                                                                {
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
                                                                                AphidTokenType.OrOperator,
                                                                                new BinaryOperatorExpression(
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
                                                                                                    "PropertyType",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "GetGenericTypeDefinition",
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
                                                                                    new IdentifierExpression(
                                                                                        "collectionType",
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
                                                                                            "p",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "SetValue",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "vm",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new IdentifierExpression(
                                                                                            "contextPropValue",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "vm",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "add_PropertyChanged",
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
                                                                                                new IfExpression(
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
                                                                                                                "PropertyName",
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
                                                                                                                    "'Property ~Cyan~{0}~R~'"
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
                                                                                                                        "PropertyName",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    )
                                                                                                                ),
                                                                                                            }
                                                                                                        ),
                                                                                                        new CallExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "contextProp",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.MemberOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "SetValue",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            new List<AphidExpression>
                                                                                                            {
                                                                                                                new IdentifierExpression(
                                                                                                                    "context",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
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
                                                                                                                            "GetValue",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    new List<AphidExpression>
                                                                                                                    {
                                                                                                                        new IdentifierExpression(
                                                                                                                            "vm",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                    }
                                                                                                                ),
                                                                                                            }
                                                                                                        ),
                                                                                                    },
                                                                                                    null
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                    }
                                                                                ),
                                                                            },
                                                                            new List<AphidExpression>
                                                                            {
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
                                                                                            "SetValue",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new List<AphidExpression>
                                                                                    {
                                                                                        new IdentifierExpression(
                                                                                            "vm",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new CallExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "Activator",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "CreateInstance",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
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
                                                                                                        "PropertyType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new TernaryOperatorExpression(
                                                                                                    AphidTokenType.ConditionalOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "contextPropValue",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.NotEqualOperator,
                                                                                                        new NullExpression(
                                                                                                        )
                                                                                                    ),
                                                                                                    new ArrayExpression(
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new IdentifierExpression(
                                                                                                                "contextPropValue",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            ),
                                                                                                        }
                                                                                                    ),
                                                                                                    new ArrayExpression(
                                                                                                        new List<AphidExpression>
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
                                                                    },
                                                                    null
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "vm",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ViewModelDataSource",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "context",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "vm",
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
                                                "objToViewModel",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "viewModelType",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "context",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "vm",
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
                                                                    "viewModelType",
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "viewModelType",
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
                                                                                    "Name",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            AphidTokenType.NotEqualOperator,
                                                                            new StringExpression(
                                                                                "'ViewModelDataSource'"
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
                                                                    new ImplicitArgumentExpression(
                                                                        AphidTokenType.ImplicitArgumentOperator
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
                                                                new IfExpression(
                                                                    new UnaryOperatorExpression(
                                                                        AphidTokenType.definedKeyword,
                                                                        new ArrayAccessExpression(
                                                                            new IdentifierExpression(
                                                                                "context",
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
                                                                        true
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
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
                                                                                    "SetValue",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new IdentifierExpression(
                                                                                    "vm",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                new ArrayAccessExpression(
                                                                                    new IdentifierExpression(
                                                                                        "context",
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
                                                                            }
                                                                        ),
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "vm",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "add_PropertyChanged",
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
                                                                                        new IfExpression(
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
                                                                                                        "PropertyName",
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
                                                                                                            "'Property ~Cyan~{0}~R~'"
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
                                                                                                                "PropertyName",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                    }
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new ArrayAccessExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "context",
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
                                                                                                    AphidTokenType.AssignmentOperator,
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
                                                                                                                "GetValue",
                                                                                                                new List<IdentifierExpression>
                                                                                                                {
                                                                                                                }
                                                                                                            )
                                                                                                        ),
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new IdentifierExpression(
                                                                                                                "vm",
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
                                                                                    }
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
                                                                "vm",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ViewModelDataSource",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "context",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "vm",
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
                                                "maxFanDepth",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new NumberExpression(
                                                5
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "fanPaths",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "type",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "base",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new IdentifierExpression(
                                                        "depth",
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
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.PostfixCountOperator,
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new ImplicitArgumentExpression(
                                                                                                AphidTokenType.ImplicitArgumentOperator
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "GetIndexParameters",
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
                                                                                AphidTokenType.EqualityOperator,
                                                                                new NumberExpression(
                                                                                    0
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
                                                                        new ObjectExpression(
                                                                            new List<BinaryOperatorExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "assoc",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.ColonOperator,
                                                                                    new CallExpression(
                                                                                        new IdentifierExpression(
                                                                                            "createAssoc",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "type",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
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
                                                                                            new BinaryOperatorExpression(
                                                                                                new TernaryOperatorExpression(
                                                                                                    AphidTokenType.ConditionalOperator,
                                                                                                    new UnaryOperatorExpression(
                                                                                                        AphidTokenType.definedKeyword,
                                                                                                        new IdentifierExpression(
                                                                                                            "base",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        true
                                                                                                    ),
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "base",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.AdditionOperator,
                                                                                                        new StringExpression(
                                                                                                            "'.'"
                                                                                                        )
                                                                                                    ),
                                                                                                    new StringExpression(
                                                                                                        "''"
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AdditionOperator,
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
                                                                                                )
                                                                                            ),
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
                                                                                            ),
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
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
                                                                                                    ),
                                                                                                    AphidTokenType.NotEqualOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "string",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AndOperator,
                                                                                                new BinaryOperatorExpression(
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
                                                                                                    ),
                                                                                                    AphidTokenType.BinaryOrOperator,
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "IEnumerable",
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
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "properties",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.ColonOperator,
                                                                                    new TernaryOperatorExpression(
                                                                                        AphidTokenType.ConditionalOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new ThisExpression(
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new DynamicMemberExpression(
                                                                                                            new StringExpression(
                                                                                                                "'$parent'"
                                                                                                            )
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "d",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.AssignmentOperator,
                                                                                                new TernaryOperatorExpression(
                                                                                                    AphidTokenType.ConditionalOperator,
                                                                                                    new UnaryOperatorExpression(
                                                                                                        AphidTokenType.definedKeyword,
                                                                                                        new IdentifierExpression(
                                                                                                            "depth",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        true
                                                                                                    ),
                                                                                                    new IdentifierExpression(
                                                                                                        "depth",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    new NumberExpression(
                                                                                                        0
                                                                                                    )
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.LessThanOperator,
                                                                                            new IdentifierExpression(
                                                                                                "maxFanDepth",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        new CallExpression(
                                                                                            new IdentifierExpression(
                                                                                                "fanPaths",
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
                                                                                                        "PropertyType",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "assoc",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "MemberPath",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "d",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.AdditionOperator,
                                                                                                    new NumberExpression(
                                                                                                        1
                                                                                                    )
                                                                                                ),
                                                                                            }
                                                                                        ),
                                                                                        new ArrayExpression(
                                                                                            new List<AphidExpression>
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
                                                "flattenPaths",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "paths",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "flattenPathsCore",
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
                                                                    "paths2",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            },
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "paths2",
                                                                        new List<IdentifierExpression>
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
                                                                                    "assoc",
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
                                                                                        "assoc",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new IfExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "assoc",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "IsNavigation",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "copy",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "associationPaths",
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
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "copy",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "flattenedPaths",
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
                                                                                }
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
                                                                                    new IdentifierExpression(
                                                                                        "properties",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.PipelineOperator,
                                                                                new IdentifierExpression(
                                                                                    "flattenPathsCore",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
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
                                                            "flattenedPaths",
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
                                                                            "ViewModelAssociation",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "associationPaths",
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
                                                                            "ViewModelAssociation",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "paths",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new IdentifierExpression(
                                                            "flattenPathsCore",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new ObjectExpression(
                                                            new List<BinaryOperatorExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "associationPaths",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new IdentifierExpression(
                                                                        "associationPaths",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "flattenedPaths",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.ColonOperator,
                                                                    new IdentifierExpression(
                                                                        "flattenedPaths",
                                                                        new List<IdentifierExpression>
                                                                        {
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "createAssoc",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.ColonOperator,
                                            new FunctionExpression(
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "parent",
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
                                                        "path",
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
                                                        "isNavigation",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                },
                                                new List<AphidExpression>
                                                {
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "assoc",
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
                                                                    "ViewModelAssociation",
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
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assoc",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ParentViewModel",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "parent",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assoc",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "MemberName",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assoc",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "MemberPath",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "path",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assoc",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "MemberType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assoc",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "IsNavigation",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new IdentifierExpression(
                                                            "isNavigation",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new UnaryOperatorExpression(
                                                        AphidTokenType.retKeyword,
                                                        new IdentifierExpression(
                                                            "assoc",
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
                            new ObjectExpression(
                                new List<BinaryOperatorExpression>
                                {
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "ParentViewModel",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "ParentViewModel",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "MemberName",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "string",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "MemberName",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "string",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "MemberPath",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "string",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "MemberPath",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "string",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "MemberType",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "MemberType",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "MemberViewModel",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "MemberViewModel",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "IsNavigation",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "Boolean",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        AphidTokenType.ColonOperator,
                                        new IdentifierExpression(
                                            "IsNavigation",
                                            new List<IdentifierExpression>
                                            {
                                                new IdentifierExpression(
                                                    "Boolean",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        )
                                    ),
                                },
                                new IdentifierExpression(
                                    "ViewModelAssociation",
                                    new List<IdentifierExpression>
                                    {
                                        new IdentifierExpression(
                                            "class",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "of",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "Type",
                                            new List<IdentifierExpression>
                                            {
                                            }
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
