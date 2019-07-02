namespace BuiltInLibrary.Library.Gui
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> OxyPlot()
        {
            return             new List<AphidExpression>
            {
                new BinaryOperatorExpression(
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
                                "'OxyPlot.Core'"
                            ),
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
                new BinaryOperatorExpression(
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
                                "'OxyPlot.Wpf'"
                            ),
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
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "OxyPlot",
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
                            "OxyPlot",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Axes",
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
                            "OxyPlot",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Series",
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
                            "OxyPlot",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Wpf",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "createLinearBarModel",
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
                                "values",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "title",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "seriesTitle",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "xTitle",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "yTitle",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "model",
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
                                            "PlotModel",
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
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new UnaryOperatorExpression(
                                        AphidTokenType.definedKeyword,
                                        new IdentifierExpression(
                                            "title",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "title",
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
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "model",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Title",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new IdentifierExpression(
                                            "title",
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
                                    "linearAxis1",
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
                                            "LinearAxis",
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
                                        "linearAxis1",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Position",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "AxisPosition",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Bottom",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                )
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "model",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Axes",
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
                                        "linearAxis1",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "linearAxis2",
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
                                            "LinearAxis",
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
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "model",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Axes",
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
                                        "linearAxis2",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "series",
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
                                            "LinearBarSeries",
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
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new UnaryOperatorExpression(
                                        AphidTokenType.definedKeyword,
                                        new IdentifierExpression(
                                            "seriesTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "seriesTitle",
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
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "series",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Title",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new IdentifierExpression(
                                            "seriesTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                },
                                null
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "FillColor",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "OxyColor",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "FromArgb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new NumberExpression(
                                            69
                                        ),
                                        new NumberExpression(
                                            76
                                        ),
                                        new NumberExpression(
                                            175
                                        ),
                                        new NumberExpression(
                                            80
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "StrokeThickness",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new NumberExpression(
                                    1
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "StrokeColor",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "OxyColor",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "FromArgb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new NumberExpression(
                                            255
                                        ),
                                        new NumberExpression(
                                            76
                                        ),
                                        new NumberExpression(
                                            175
                                        ),
                                        new NumberExpression(
                                            80
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "NegativeFillColor",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "OxyColor",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "FromArgb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new NumberExpression(
                                            69
                                        ),
                                        new NumberExpression(
                                            191
                                        ),
                                        new NumberExpression(
                                            54
                                        ),
                                        new NumberExpression(
                                            12
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "NegativeStrokeColor",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "OxyColor",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "FromArgb",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new NumberExpression(
                                            255
                                        ),
                                        new NumberExpression(
                                            191
                                        ),
                                        new NumberExpression(
                                            54
                                        ),
                                        new NumberExpression(
                                            12
                                        ),
                                    }
                                )
                            ),
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new UnaryOperatorExpression(
                                        AphidTokenType.definedKeyword,
                                        new IdentifierExpression(
                                            "xTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "xTitle",
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
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "series",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "XAxis",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Title",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new IdentifierExpression(
                                            "xTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                },
                                null
                            ),
                            new IfExpression(
                                new BinaryOperatorExpression(
                                    new UnaryOperatorExpression(
                                        AphidTokenType.definedKeyword,
                                        new IdentifierExpression(
                                            "yTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        true
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "yTitle",
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
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "series",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "YAxis",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Title",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.AssignmentOperator,
                                        new IdentifierExpression(
                                            "yTitle",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                },
                                null
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
                                            "Threading",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Tasks",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
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
                                new NumberExpression(
                                    0
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "values",
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
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "series",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Points",
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
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.newKeyword,
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "DataPoint",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.IncrementOperator,
                                                                new IdentifierExpression(
                                                                    "i",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                true
                                                            ),
                                                            new ImplicitArgumentExpression(
                                                                AphidTokenType.ImplicitArgumentOperator
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
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "model",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Series",
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
                                        "series",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new IdentifierExpression(
                                        "createPlotView",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "model",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new UnaryOperatorExpression(
                                            AphidTokenType.newKeyword,
                                            new CallExpression(
                                                new IdentifierExpression(
                                                    "PlotController",
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
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "createPlotView",
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
                                "model",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "controller",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "view",
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
                                            "PlotView",
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
                                        "view",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Model",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "model",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "view",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Controller",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "controller",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "view",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                false
                            ),
                        }
                    )
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
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "createBoundPlotView",
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
                            new IdentifierExpression(
                                "modelPath",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "controllerPath",
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
                                        new StringExpression(
                                            "'\r\n    <Grid xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n        xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n        xmlns:oxy=\"clr-namespace:OxyPlot.Wpf;assembly=OxyPlot.Wpf\">\r\n        <oxy:PlotView x:Name=\"{0}\" Model=\"{{Binding {1}}}\" Controller=\"{{Binding {2}}}\"/>\r\n    </Grid>\r\n'"
                                        ),
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
