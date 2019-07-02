namespace BuiltInLibrary.Library.Gui
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> NodeMon()
        {
            return             new List<AphidExpression>
            {
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
                            "'LiveCharts'"
                        ),
                    }
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
                            "'LiveCharts.Geared'"
                        ),
                    }
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
                            "'LiveCharts.Wpf'"
                        ),
                    }
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "LiveCharts",
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
                            "LiveCharts",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Configurations",
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
                            "LiveCharts",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Geared",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "sleepTime",
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
                        1000
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "maxValues",
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
                        100
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "nodes",
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
                            new StringExpression(
                                "'node1'"
                            ),
                            new StringExpression(
                                "'node2'"
                            ),
                            new StringExpression(
                                "'node3'"
                            ),
                            new StringExpression(
                                "'node4'"
                            ),
                            new StringExpression(
                                "'node6'"
                            ),
                        }
                    )
                ),
                new ObjectExpression(
                    new List<BinaryOperatorExpression>
                    {
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "CounterValue",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "CounterValue",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Ticks",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Int64",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Ticks",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Int64",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                    },
                    new IdentifierExpression(
                        "RuntimeMetrics",
                        new List<IdentifierExpression>
                        {
                            new IdentifierExpression(
                                "class",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        }
                    )
                ),
                new ObjectExpression(
                    new List<BinaryOperatorExpression>
                    {
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "CpuChartValues",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "CpuChartValues",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "RamChartValues",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "RamChartValues",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "LastCpuPct",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "LastCpuPct",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "LastRamPct",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "LastRamPct",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "ActiveNodes",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Int32",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "ActiveNodes",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Int32",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Nodes",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Nodes",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Cores",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Cores",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Ram",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Ram",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AxisMin",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "AxisMin",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AxisMax",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "AxisMax",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AxisStep",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "AxisStep",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AxisUnit",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "AxisUnit",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Double",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                    },
                    new IdentifierExpression(
                        "LiveChart",
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
                                "Decimal",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "RuntimeMetricsViewModel",
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
                                "viewModelLoader",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "loadFor",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "RuntimeMetrics",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "ChartViewModel",
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
                                "viewModelLoader",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "loadFor",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "LiveChart",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "unwrap",
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
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "mapper",
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
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new ArrayAccessExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Mappers",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Xy",
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
                                                                0
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
                                                                "RuntimeMetricsViewModel",
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
                                                "Invoke",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new NullExpression(
                                            ),
                                            new ArrayExpression(
                                                new List<AphidExpression>
                                                {
                                                }
                                            ),
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "X",
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
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new ImplicitArgumentExpression(
                                                            AphidTokenType.ImplicitArgumentOperator
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Ticks",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
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
                                                false
                                            ),
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Y",
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
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new ImplicitArgumentExpression(
                                                    AphidTokenType.ImplicitArgumentOperator
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "CounterValue",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.PipelineOperator,
                                            new IdentifierExpression(
                                                "unwrap",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
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
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "Charting",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "For",
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
                                            0
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
                                            "RuntimeMetricsViewModel",
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
                            "Invoke",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new NullExpression(
                        ),
                        new ArrayExpression(
                            new List<AphidExpression>
                            {
                                new IdentifierExpression(
                                    "mapper",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "SeriesOrientation",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "All",
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
                    new IdentifierExpression(
                        "chartVM",
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
                                "ChartViewModel",
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
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Nodes",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new NumberExpression(
                        0
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Cores",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new NumberExpression(
                        0
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Ram",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new NumberExpression(
                        0
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "CpuChartValues",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new UnaryOperatorExpression(
                        AphidTokenType.newKeyword,
                        new CallExpression(
                            new ArrayAccessExpression(
                                new IdentifierExpression(
                                    "GearedValues",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "RuntimeMetricsViewModel",
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
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "RamChartValues",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new UnaryOperatorExpression(
                        AphidTokenType.newKeyword,
                        new CallExpression(
                            new ArrayAccessExpression(
                                new IdentifierExpression(
                                    "GearedValues",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "RuntimeMetricsViewModel",
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
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AxisStep",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "TimeSpan",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "FromSeconds",
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
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Ticks",
                                new List<IdentifierExpression>
                                {
                                }
                            )
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
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "chartVM",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "AxisUnit",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "TimeSpan",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "TicksPerSecond",
                                new List<IdentifierExpression>
                                {
                                }
                            )
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
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "_setAxisLimits",
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
                                "now",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "ahead",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            new IdentifierExpression(
                                "behind",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "chartVM",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AxisMax",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "now",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.AdditionOperator,
                                    new NumberExpression(
                                        10000000
                                    )
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "chartVM",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "AxisMin",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "now",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MinusOperator,
                                    new NumberExpression(
                                        600000000
                                    )
                                )
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "fillerTicks",
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
                                "DateTime",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "UtcNow",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Ticks",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "filler",
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
                                new NumberExpression(
                                    0
                                ),
                                AphidTokenType.RangeOperator,
                                new IdentifierExpression(
                                    "maxValues",
                                    new List<IdentifierExpression>
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
                                    "Reverse",
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
                                        "fillerVM",
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
                                                "RuntimeMetricsViewModel",
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
                                            "fillerVM",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "CounterValue",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.AssignmentOperator,
                                    new NumberExpression(
                                        0
                                    )
                                ),
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "fillerVM",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Ticks",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.AssignmentOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "fillerTicks",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MinusOperator,
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "sleepTime",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MultiplicationOperator,
                                                new NumberExpression(
                                                    10000
                                                )
                                            ),
                                            AphidTokenType.MultiplicationOperator,
                                            new ImplicitArgumentExpression(
                                                AphidTokenType.ImplicitArgumentOperator
                                            )
                                        )
                                    )
                                ),
                                new UnaryOperatorExpression(
                                    AphidTokenType.retKeyword,
                                    new IdentifierExpression(
                                        "fillerVM",
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
                new CallExpression(
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "chartVM",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "CpuChartValues",
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
                    ),
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "filler",
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
                                "chartVM",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "RamChartValues",
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
                    ),
                    new List<AphidExpression>
                    {
                        new IdentifierExpression(
                            "filler",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                    }
                ),
                new CallExpression(
                    new IdentifierExpression(
                        "_setAxisLimits",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    new List<AphidExpression>
                    {
                        new BinaryOperatorExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "DateTime",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "UtcNow",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Ticks",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                    }
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "createNodeMon",
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
                                    "lm",
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
                                            "wpf",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "loadXaml",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'<UserControl xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n                    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n                    xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" \r\n                    xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"\r\n                    xmlns:lvc=\"clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf\"\r\n                    xmlns:geared=\"clr-namespace:LiveCharts.Geared;assembly=LiveCharts.Geared\"\r\n                    mc:Ignorable=\"d\"\r\n                    d:DesignHeight=\"300\" d:DesignWidth=\"300\">\r\n            <Grid>\r\n                <Grid.RowDefinitions>\r\n                    <RowDefinition Height=\"Auto\"></RowDefinition>\r\n                    <RowDefinition Height=\"*\"></RowDefinition>\r\n                    <RowDefinition Height=\"Auto\"></RowDefinition>\r\n                </Grid.RowDefinitions>\r\n                <lvc:CartesianChart\r\n                    Grid.Row=\"1\"\r\n                    AnimationsSpeed=\"00:00:00.3\"\r\n                    DisableAnimations=\"False\"\r\n                    Hoverable=\"False\"\r\n                    DataTooltip=\"{x:Null}\">\r\n                    <lvc:CartesianChart.Resources>\r\n                        <Style TargetType=\"{x:Type geared:GLineSeries}\">\r\n                            <Setter Property=\"PointGeometry\" Value=\"{x:Null}\" />\r\n                            <Setter Property=\"LineSmoothness\" Value=\"0.1\" />\r\n                            <Setter Property=\"AreaLimit\" Value=\"-1\" />\r\n                            <Setter Property=\"StrokeThickness\" Value=\"2\" />                    \r\n                        </Style>\r\n                    </lvc:CartesianChart.Resources>\r\n                    <lvc:CartesianChart.Series>\r\n                        <geared:GLineSeries Values=\"{Binding CpuChartValues}\" Stroke=\"#F34336\" />\r\n                        <geared:GLineSeries Values=\"{Binding RamChartValues}\" Stroke=\"#4336F3\" />\r\n                    </lvc:CartesianChart.Series>\r\n                    <lvc:CartesianChart.AxisX>\r\n                        <lvc:Axis ShowLabels=\"False\">\r\n                            <lvc:Axis.Separator>\r\n                                <lvc:Separator Step=\"{Binding AxisStep}\" />\r\n                            </lvc:Axis.Separator>\r\n                        </lvc:Axis>\r\n                    </lvc:CartesianChart.AxisX>\r\n                    <lvc:CartesianChart.AxisY>\r\n                        <lvc:Axis MaxValue=\"102\" MinValue=\"0\" ShowLabels=\"True\">\r\n                            <lvc:Axis.Separator>\r\n                                <lvc:Separator Step=\"10\" />\r\n                            </lvc:Axis.Separator>\r\n                        </lvc:Axis>\r\n                    </lvc:CartesianChart.AxisY>\r\n                </lvc:CartesianChart>\r\n                <Grid Grid.Row=\"2\">\r\n                    <Grid.Resources>\r\n                        <Style TargetType=\"TextBlock\">\r\n                            <Setter Property=\"FontSize\" Value=\"16\" />\r\n                        </Style>\r\n                        <Style TargetType=\"Grid\">\r\n                            <Setter Property=\"VerticalAlignment\" Value=\"Center\" />\r\n                            <Setter Property=\"Margin\" Value=\"0, 0, 0, 8\" />\r\n                        </Style>\r\n                        <Style x:Key=\"ValueText\" TargetType=\"TextBlock\">\r\n                            <Setter Property=\"Margin\" Value=\"0, 0, 30, 0\" />\r\n                            <Setter Property=\"Foreground\" Value=\"#303030\" />\r\n                            <Setter Property=\"HorizontalAlignment\" Value=\"Right\" />\r\n                            <Setter Property=\"VerticalAlignment\" Value=\"Center\" />\r\n                            <Setter Property=\"FontSize\" Value=\"16\" />\r\n                        </Style>\r\n                    </Grid.Resources>\r\n                    <Grid.ColumnDefinitions>\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"95\" />\r\n                        <ColumnDefinition Width=\"Auto\" />\r\n                        <ColumnDefinition Width=\"69\" />\r\n                        <ColumnDefinition Width=\"*\" />\r\n                    </Grid.ColumnDefinitions>\r\n                    <TextBlock Grid.Column=\"0\" Margin=\"10,0,0,0\" Opacity=\".4\">Nodes</TextBlock>\r\n                    <TextBlock Grid.Column=\"1\" Style=\"{StaticResource ValueText}\" Margin=\"10, 0, 30, 0\">\r\n                        <TextBlock.Text>\r\n                            <MultiBinding StringFormat=\"{}{0}/{1}\">\r\n                                <Binding Path=\"ActiveNodes\" />\r\n                                <Binding Path=\"Nodes\" />\r\n                            </MultiBinding>\r\n                        </TextBlock.Text>\r\n                    </TextBlock>\r\n                    <TextBlock Grid.Column=\"2\" Opacity=\".4\">Cores</TextBlock>\r\n                    <TextBlock Grid.Column=\"3\" Style=\"{StaticResource ValueText}\" Margin=\"10, 0, 30, 0\"\r\n                            Text=\"{Binding Cores, StringFormat=\\\\{0:#\\\\,##0\\\\}}\" />\r\n                    <TextBlock Grid.Column=\"4\" Opacity=\".4\">CPU</TextBlock>\r\n                    <TextBlock Grid.Column=\"5\" Style=\"{StaticResource ValueText}\"\r\n                            Text=\"{Binding LastCpuPct, StringFormat=\\\\{0\\\\,8:N2\\\\}%}\" />\r\n                    <TextBlock Grid.Column=\"6\" Opacity=\".4\">RAM</TextBlock>\r\n                    <TextBlock Grid.Column=\"7\" Style=\"{StaticResource ValueText}\" Margin=\"0,0,0,0\"                       \r\n                            Text=\"{Binding LastRamPct, StringFormat=\\\\{0\\\\,8:N2\\\\}% }\" />\r\n                    <TextBlock Grid.Column=\"8\"  Style=\"{StaticResource ValueText}\" Margin=\"4,0,0,0\"\r\n                            HorizontalAlignment=\"Left\"\r\n                            Foreground=\"#303030\" Text=\"{Binding Ram, StringFormat= (\\\\{0:N2\\\\}GB Total)}\" />\r\n                    \r\n                </Grid>\r\n            </Grid>\r\n        </UserControl>\r\n    '"
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "lm",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "DataContext",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "chartVM",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new IdentifierExpression(
                                    "lm",
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
                        "createNodeMonWindow",
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
                                            "wpf",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "createAppAsync",
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
                                                        "w",
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
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "w",
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
                                                    new StringExpression(
                                                        "'Node Monitor'"
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "BorderThickness",
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
                                                                "Thickness",
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
                                                        false
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "WindowStyle",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "WindowStyle",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ToolWindow",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Topmost",
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
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
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
                                                            "createNodeMon",
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
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Width",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new NumberExpression(
                                                        600
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "w",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Height",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new NumberExpression(
                                                        300
                                                    )
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
                        "startNodeMonServices",
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
                                        "'Starting'"
                                    ),
                                }
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "startBackgroundThread",
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
                                            "f",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
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
                                                        new IdentifierExpression(
                                                            "f",
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
                                                    "t",
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
                                                    "t",
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
                                        new UnaryOperatorExpression(
                                            AphidTokenType.retKeyword,
                                            new IdentifierExpression(
                                                "t",
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
                                    new IdentifierExpression(
                                        "System",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Net",
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
                                            "Net",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "Sockets",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    )
                                ),
                                false
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'TcpListener'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "TcpListener",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'HashSet'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "HashSet",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'AutoResetEvent'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "AutoResetEvent",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'BinaryReader'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "BinaryReader",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'Thread'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "Thread",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'Convert'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "Convert",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new ArrayAccessExpression(
                                    new ThisExpression(
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "'DateTime'"
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new IdentifierExpression(
                                    "DateTime",
                                    new List<IdentifierExpression>
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
                                new BooleanExpression(
                                    true
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "listenerThread",
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
                                        "startBackgroundThread",
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
                                                    new IdentifierExpression(
                                                        "tcpListener",
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
                                                                "TcpListener",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "IPAddress",
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
                                                                new NumberExpression(
                                                                    52300
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    )
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "tcpListener",
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
                                                    new IdentifierExpression(
                                                        "nodesConnected",
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
                                                                    "HashSet",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "String",
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
                                                        "aggrTicks",
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
                                                        "aggrCpu",
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
                                                        "aggrRam",
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
                                                        "sendReset",
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
                                                                "AutoResetEvent",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "resumeReset",
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
                                                                "AutoResetEvent",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "nodesReady",
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
                                                                    "HashSet",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "String",
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
                                                        "aggrThread",
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
                                                            "startBackgroundThread",
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
                                                                    new WhileExpression(
                                                                        new BooleanExpression(
                                                                            true
                                                                        ),
                                                                        new List<AphidExpression>
                                                                        {
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "cpuVM",
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
                                                                                            "RuntimeMetricsViewModel",
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
                                                                                    "ramVM",
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
                                                                                            "RuntimeMetricsViewModel",
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
                                                                                        "sendReset",
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
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "an",
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
                                                                                        "nodesReady",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpuVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Ticks",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "aggrTicks",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.DivisionOperator,
                                                                                    new IdentifierExpression(
                                                                                        "an",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ramVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Ticks",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpuVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "Ticks",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
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
                                                                                        "nodesConnected",
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
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpuVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CounterValue",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "aggrCpu",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.DivisionOperator,
                                                                                    new IdentifierExpression(
                                                                                        "c",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ramVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CounterValue",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "aggrRam",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.DivisionOperator,
                                                                                    new IdentifierExpression(
                                                                                        "c",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "aggrTicks",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new NumberExpression(
                                                                                    0
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "aggrCpu",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new NumberExpression(
                                                                                    0
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "aggrRam",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new NumberExpression(
                                                                                    0
                                                                                )
                                                                            ),
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "nodesReady",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
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
                                                                                        "chartVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "ActiveNodes",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new IdentifierExpression(
                                                                                    "an",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "chartVM",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "CpuChartValues",
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
                                                                                        "cpuVM",
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
                                                                                            "chartVM",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "RamChartValues",
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
                                                                                        "ramVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "chartVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "LastCpuPct",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "cpuVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CounterValue",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new BinaryOperatorExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "chartVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "LastRamPct",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                                AphidTokenType.AssignmentOperator,
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "ramVM",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "CounterValue",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                )
                                                                            ),
                                                                            new IfExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "chartVM",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "CpuChartValues",
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
                                                                                    AphidTokenType.GreaterThanOperator,
                                                                                    new IdentifierExpression(
                                                                                        "maxValues",
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
                                                                                                    "chartVM",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "CpuChartValues",
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
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new IdentifierExpression(
                                                                                                    "chartVM",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "RamChartValues",
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
                                                                                },
                                                                                null
                                                                            ),
                                                                            new CallExpression(
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "resumeReset",
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
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                        }
                                                    )
                                                ),
                                                new WhileExpression(
                                                    new BooleanExpression(
                                                        true
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "client",
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
                                                                        "tcpListener",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "AcceptTcpClient",
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
                                                                "clientThread",
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
                                                                    "startBackgroundThread",
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
                                                                                new IdentifierExpression(
                                                                                    "stream",
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
                                                                                            "client",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "GetStream",
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
                                                                                    "reader",
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
                                                                                            "BinaryReader",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "stream",
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
                                                                                new UnaryOperatorExpression(
                                                                                    AphidTokenType.newKeyword,
                                                                                    new CallExpression(
                                                                                        new IdentifierExpression(
                                                                                            "BinaryWriter",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new IdentifierExpression(
                                                                                                "stream",
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
                                                                                    "blob",
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
                                                                                            "reader",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "ReadString",
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
                                                                            new IdentifierExpression(
                                                                                "nodeName",
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
                                                                            new LockExpression(
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new IdentifierExpression(
                                                                                        "nodesConnected",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                },
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "blob",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
                                                                                        new IdentifierExpression(
                                                                                            "print",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "nodeInfo",
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
                                                                                                "blob",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.PipelineOperator,
                                                                                            new IdentifierExpression(
                                                                                                "deserialize",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "nodeName",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.AssignmentOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "nodeInfo",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "name",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new CallExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "nodesConnected",
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
                                                                                                "nodeName",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "chartVM",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Nodes",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                        new NumberExpression(
                                                                                            1
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "chartVM",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Cores",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "nodeInfo",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "cores",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "chartVM",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Ram",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new BinaryOperatorExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new BinaryOperatorExpression(
                                                                                                        new IdentifierExpression(
                                                                                                            "nodeInfo",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        ),
                                                                                                        AphidTokenType.MemberOperator,
                                                                                                        new IdentifierExpression(
                                                                                                            "memory",
                                                                                                            new List<IdentifierExpression>
                                                                                                            {
                                                                                                            }
                                                                                                        )
                                                                                                    ),
                                                                                                    AphidTokenType.DivisionOperator,
                                                                                                    new NumberExpression(
                                                                                                        1024
                                                                                                    )
                                                                                                ),
                                                                                                AphidTokenType.DivisionOperator,
                                                                                                new NumberExpression(
                                                                                                    1024
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.DivisionOperator,
                                                                                            new NumberExpression(
                                                                                                1024
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                }
                                                                            ),
                                                                            new WhileExpression(
                                                                                new BooleanExpression(
                                                                                    true
                                                                                ),
                                                                                new List<AphidExpression>
                                                                                {
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "cpu",
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
                                                                                                        "reader",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "ReadInt16",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.DivisionOperator,
                                                                                            new NumberExpression(
                                                                                                100
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "ram",
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
                                                                                                        "reader",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "ReadInt16",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.DivisionOperator,
                                                                                            new NumberExpression(
                                                                                                100
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "ticks",
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
                                                                                                    "DateTime",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.MemberOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "UtcNow",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Ticks",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "tries",
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
                                                                                            "trySleep",
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
                                                                                            100
                                                                                        )
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "maxTries",
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
                                                                                                    "sleepTime",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                AphidTokenType.DivisionOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "trySleep",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            ),
                                                                                            AphidTokenType.MultiplicationOperator,
                                                                                            new NumberExpression(
                                                                                                2
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    new WhileExpression(
                                                                                        new BooleanExpression(
                                                                                            true
                                                                                        ),
                                                                                        new List<AphidExpression>
                                                                                        {
                                                                                            new LockExpression(
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IdentifierExpression(
                                                                                                        "nodesReady",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                },
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IfExpression(
                                                                                                        new CallExpression(
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "nodesReady",
                                                                                                                    new List<IdentifierExpression>
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
                                                                                                                new IdentifierExpression(
                                                                                                                    "nodeName",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
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
                                                                                                                                "nodesConnected",
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
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new IdentifierExpression(
                                                                                                                                "nodesReady",
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
                                                                                                                    AphidTokenType.OrOperator,
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "tries",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.GreaterThanOrEqualOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "maxTries",
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
                                                                                                                                "sendReset",
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
                                                                                                                            new IdentifierExpression(
                                                                                                                                "resumeReset",
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
                                                                                                                    new CallExpression(
                                                                                                                        new BinaryOperatorExpression(
                                                                                                                            new IdentifierExpression(
                                                                                                                                "nodesReady",
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
                                                                                                                                "nodeName",
                                                                                                                                new List<IdentifierExpression>
                                                                                                                                {
                                                                                                                                }
                                                                                                                            ),
                                                                                                                        }
                                                                                                                    ),
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "aggrCpu",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "cpu",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "aggrRam",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "ram",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    new BinaryOperatorExpression(
                                                                                                                        new IdentifierExpression(
                                                                                                                            "aggrTicks",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        ),
                                                                                                                        AphidTokenType.PlusEqualOperator,
                                                                                                                        new IdentifierExpression(
                                                                                                                            "ticks",
                                                                                                                            new List<IdentifierExpression>
                                                                                                                            {
                                                                                                                            }
                                                                                                                        )
                                                                                                                    ),
                                                                                                                    new BreakExpression(
                                                                                                                    ),
                                                                                                                },
                                                                                                                null
                                                                                                            ),
                                                                                                        },
                                                                                                        new List<AphidExpression>
                                                                                                        {
                                                                                                            new CallExpression(
                                                                                                                new BinaryOperatorExpression(
                                                                                                                    new IdentifierExpression(
                                                                                                                        "nodesReady",
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
                                                                                                                        "nodeName",
                                                                                                                        new List<IdentifierExpression>
                                                                                                                        {
                                                                                                                        }
                                                                                                                    ),
                                                                                                                }
                                                                                                            ),
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "aggrCpu",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.PlusEqualOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "cpu",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "aggrRam",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.PlusEqualOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "ram",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            new BinaryOperatorExpression(
                                                                                                                new IdentifierExpression(
                                                                                                                    "aggrTicks",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                ),
                                                                                                                AphidTokenType.PlusEqualOperator,
                                                                                                                new IdentifierExpression(
                                                                                                                    "ticks",
                                                                                                                    new List<IdentifierExpression>
                                                                                                                    {
                                                                                                                    }
                                                                                                                )
                                                                                                            ),
                                                                                                            new BreakExpression(
                                                                                                            ),
                                                                                                        }
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                            new UnaryOperatorExpression(
                                                                                                AphidTokenType.IncrementOperator,
                                                                                                new IdentifierExpression(
                                                                                                    "tries",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                ),
                                                                                                true
                                                                                            ),
                                                                                            new CallExpression(
                                                                                                new BinaryOperatorExpression(
                                                                                                    new IdentifierExpression(
                                                                                                        "Thread",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                    AphidTokenType.MemberOperator,
                                                                                                    new IdentifierExpression(
                                                                                                        "Sleep",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    )
                                                                                                ),
                                                                                                new List<AphidExpression>
                                                                                                {
                                                                                                    new IdentifierExpression(
                                                                                                        "trySleep",
                                                                                                        new List<IdentifierExpression>
                                                                                                        {
                                                                                                        }
                                                                                                    ),
                                                                                                }
                                                                                            ),
                                                                                        }
                                                                                    ),
                                                                                    new BinaryOperatorExpression(
                                                                                        new BinaryOperatorExpression(
                                                                                            new NumberExpression(
                                                                                                1
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
                                                                                                    "ToByte",
                                                                                                    new List<IdentifierExpression>
                                                                                                    {
                                                                                                    }
                                                                                                )
                                                                                            )
                                                                                        ),
                                                                                        AphidTokenType.PipelineOperator,
                                                                                        new BinaryOperatorExpression(
                                                                                            new IdentifierExpression(
                                                                                                "writer",
                                                                                                new List<IdentifierExpression>
                                                                                                {
                                                                                                }
                                                                                            ),
                                                                                            AphidTokenType.MemberOperator,
                                                                                            new IdentifierExpression(
                                                                                                "Write",
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
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new LoadScriptExpression(
                                new StringExpression(
                                    "'Core/Threading'"
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "tryConnectNode",
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
                                            "node",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "System",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Net",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Sockets",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            false
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "node",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.BinaryOrOperator,
                                            new IdentifierExpression(
                                                "connectNode",
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
                                    "connectNode",
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
                                        new LoadScriptExpression(
                                            new StringExpression(
                                                "'Remoting/Remote'"
                                            )
                                        ),
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
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "remote",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "connect",
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
                                                    new NumberExpression(
                                                        21042
                                                    ),
                                                }
                                            )
                                        ),
                                        new TryExpression(
                                            new List<AphidExpression>
                                            {
                                                new UsingExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "c",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "socket",
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
                                                                    "c",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "eval",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new StringExpression(
                                                                    "\"\r\n                    #'Std';\r\n                    #'System/Process';\r\n                    Process.Start(\r\n                        'cmd.exe',\r\n                        '/c start aphid64 * #\\\\'std\\\\'; #\\\\'remoting/remote\\\\'; remote.listen(0x5231).listenThread.Join();');\r\n\r\n                    exit();\r\n                \""
                                                                ),
                                                            }
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
                                                            "'Expected error: {0}'"
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
                                                ),
                                            },
                                            null
                                        ),
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
                                                        "remote",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "connect",
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
                                                    new NumberExpression(
                                                        21042
                                                    ),
                                                }
                                            )
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "c",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "eval",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new StringExpression(
                                                                    "\"\r\n            using System.Threading;\r\n            \r\n            var cpuCounterThread = new Thread(@{\r\n                #'Std';\r\n                #'System/Machine';\r\n                \r\n                using System.Diagnostics;\r\n                using System.Net.Sockets;\r\n                \r\n                var memory = machine.getMemory();\r\n                var cores = machine.getLogicalProcessorCount();\r\n                var name = Environment.MachineName;\r\n                var text = {name, cores, memory} |> serialize;\r\n                \r\n                var client = new TcpClient();\r\n                client.Connect('\""
                                                                ),
                                                                AphidTokenType.AdditionOperator,
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "Environment",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "MachineName",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            AphidTokenType.AdditionOperator,
                                                            new StringExpression(
                                                                "\"', 52300);\r\n                var stream = client.GetStream();\r\n                var reader = new BinaryReader(stream);\r\n                var writer = new BinaryWriter(stream);\r\n                text |> writer.Write;\r\n                                \r\n                try {\r\n                    var cpuCounter = new PerformanceCounter('Processor', '% Processor Time', '_Total');\r\n                    var ramCounter = new PerformanceCounter('Memory', 'Available MBytes');\r\n                    var _toShort = Convert.ToInt16;\r\n                    var _write = writer.Write;\r\n                    var _delay = Thread.Sleep;\r\n                    var _nextCpu = cpuCounter.NextValue;\r\n                    var _nextRam = ramCounter.NextValue;\r\n                    var _readByte = reader.ReadByte;\r\n\r\n                    while(true) {\r\n                        writer.Write(_toShort(_nextCpu() * 100));\r\n                        writer.Write(_toShort((memory - _nextRam() * 0x100000) / memory * 100 * 100));\r\n                        _delay(\""
                                                            )
                                                        ),
                                                        AphidTokenType.AdditionOperator,
                                                        new IdentifierExpression(
                                                            "sleepTime",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AdditionOperator,
                                                    new StringExpression(
                                                        "\");\r\n                        _readByte();\r\n                    }\r\n                } catch {\r\n                    exit();\r\n                }\r\n            });\r\n\r\n            cpuCounterThread.IsBackground = true;\r\n            cpuCounterThread.Start();\r\n        \""
                                                    )
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "nodes",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.CustomOperator238,
                                new IdentifierExpression(
                                    "tryConnectNode",
                                    new List<IdentifierExpression>
                                    {
                                    }
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
                    )
                ),
            }
;
        }
    }
}
