namespace BuiltInLibrary.Library.Gui
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> DynamicUI()
        {
            return             new List<AphidExpression>
            {
                new LoadScriptExpression(
                    new StringExpression(
                        "'System/Process'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'System/Nuget'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta/Code/Compiler'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta/Code/ViewModelCompiler'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Gui/Wpf'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Gui/OxyPlot'"
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
                            "'Loading Nuget references'"
                        ),
                    }
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "asms",
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
                        new ArrayExpression(
                            new List<AphidExpression>
                            {
                                new StringExpression(
                                    "'Extended.Wpf.Toolkit'"
                                ),
                                new StringExpression(
                                    "'System.Windows.Controls.DataVisualization.Toolkit'"
                                ),
                            }
                        ),
                        AphidTokenType.SelectManyOperator,
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
                        )
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
                            "'Done loading references: {0}'"
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "asms",
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
                    }
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "dynamicViewType",
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
                                    "control",
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
                                    "dataGrid",
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
                                    "barGraph",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new NumberExpression(
                                    100
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
                                "ViewType",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "int",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "ViewType",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "int",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Name",
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
                                "Name",
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
                                "Columns",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "list",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Columns",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "list",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Associations",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "list",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "Associations",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "string",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    new IdentifierExpression(
                                        "list",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "LoadData",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidFunction",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "LoadData",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidFunction",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "ViewModelType",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Type",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                            AphidTokenType.ColonOperator,
                            new IdentifierExpression(
                                "ViewModelType",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Type",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            )
                        ),
                    },
                    new IdentifierExpression(
                        "DynamicView",
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
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "loadDocking",
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
                                            "'\r\n    <Grid\r\n        xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n        xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n        xmlns:xcad=\"http://schemas.xceed.com/wpf/xaml/avalondock\"\r\n        xmlns:xctk=\"http://schemas.xceed.com/wpf/xaml/toolkit\"\r\n        xmlns:s=\"clr-namespace:System;assembly=mscorlib\"\r\n        xmlns:dg=\"clr-namespace:System.Windows.Controls;assembly=PresentationFramework\"\r\n        xmlns:dg2=\"clr-namespace:Xceed.Wpf.DataGrid;assembly=Xceed.Wpf.DataGrid\"\r\n        xmlns:xcdg=\"http://schemas.xceed.com/wpf/xaml/datagrid\">\r\n        <xcad:DockingManager AllowMixedOrientation=\"True\"\r\n                        BorderBrush=\"Black\"                        \r\n                        BorderThickness=\"1\">\r\n            <!--<xcad:DockingManager.LayoutItemContainerStyle>\r\n                <Style TargetType=\"{x:Type xcad:LayoutItem}\">\r\n                    <Setter Property=\"Title\" Value=\"{Binding Model.Title}\" />\r\n                    <Setter Property=\"CloseCommand\" Value=\"{Binding Model.CloseCommand}\" />\r\n                    <Setter Property=\"CanClose\" Value=\"{Binding Model.CanClose}\" />\r\n                </Style>\r\n            </xcad:DockingManager.LayoutItemContainerStyle>-->\r\n            <!--<xcad:DockingManager.DocumentHeaderTemplate>\r\n                <DataTemplate>\r\n                    <StackPanel Orientation=\"Horizontal\">\r\n                        <Image Source=\"{Binding IconSource}\" Margin=\"0,0,4,0\" />\r\n                        <TextBlock Text=\"{Binding Title}\" />\r\n                    </StackPanel>\r\n                </DataTemplate>\r\n            </xcad:DockingManager.DocumentHeaderTemplate>-->\r\n            <xcad:LayoutRoot x:Name=\"_layoutRoot\">\r\n                <xcad:LayoutPanel Orientation=\"Horizontal\">\r\n                    <xcad:LayoutAnchorablePane DockWidth=\"200\">\r\n                        <xcad:LayoutAnchorable ContentId=\"properties\"\r\n                                Title=\"Properties\"\r\n                                CanHide=\"False\"\r\n                                CanClose=\"False\"\r\n                                AutoHideWidth=\"240\">\r\n                            <xctk:PropertyGrid NameColumnWidth=\"110\"\r\n                                            SelectedObject=\"{Binding SelectedItem}\"\r\n                                            AutoGenerateProperties=\"True\"\r\n                                            IsReadOnly=\"True\" />\r\n                        </xcad:LayoutAnchorable>\r\n                    </xcad:LayoutAnchorablePane>\r\n                    <xcad:LayoutDocumentPaneGroup>\r\n                        <xcad:LayoutDocumentPane x:Name=\"DocPane\">\r\n                            <!--<xcad:LayoutDocument ContentId=\"document1\"\r\n                                Title=\"Document 1\"\r\n                                    IsActive=\"True\">\r\n                                <Grid>\r\n                                    <Grid.RowDefinitions>\r\n                                        <RowDefinition Height=\"20\" />\r\n                                        <RowDefinition />\r\n                                        </Grid.RowDefinitions>\r\n                                        <TextBox IsReadOnly=\"True\" Text=\"{Binding Filename}\" />\r\n                                        <dg:DataGrid x:Name=\"DataGrid\" Grid.Row=\"1\"\r\n                                                    IsReadOnly=\"True\"\r\n                                                    SelectedItem=\"{Binding SelectedItem}\"\r\n                                                    ItemsSource=\"{Binding Records}\">\r\n                                        </dg:DataGrid>\r\n                                    </Grid>\r\n\r\n                                </xcad:LayoutDocument>-->\r\n                            </xcad:LayoutDocumentPane>\r\n                        </xcad:LayoutDocumentPaneGroup>\r\n                </xcad:LayoutPanel>\r\n                <xcad:LayoutRoot.LeftSide>\r\n                    <xcad:LayoutAnchorSide>\r\n                        <xcad:LayoutAnchorGroup>\r\n                            <xcad:LayoutAnchorable Title=\"Agenda\"\r\n                                        ContentId=\"agenda\">\r\n                                <TextBlock Text=\"Agenda Content\"\r\n                                    Margin=\"10\"\r\n                                    FontSize=\"18\"\r\n                                    FontWeight=\"Black\"\r\n                                    TextWrapping=\"Wrap\" />\r\n                                    </xcad:LayoutAnchorable>\r\n                                    <xcad:LayoutAnchorable Title=\"Contacts\"\r\n                                        ContentId=\"contacts\">\r\n                                <TextBlock Text=\"Contacts Content\"\r\n                                    Margin=\"10\"\r\n                                    FontSize=\"18\"\r\n                                    FontWeight=\"Black\"\r\n                                    TextWrapping=\"Wrap\" />\r\n                            </xcad:LayoutAnchorable>\r\n                        </xcad:LayoutAnchorGroup>\r\n                    </xcad:LayoutAnchorSide>\r\n                </xcad:LayoutRoot.LeftSide>\r\n            </xcad:LayoutRoot>\r\n        </xcad:DockingManager>\r\n    </Grid>\r\n'"
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
                        "viewModelLoader",
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
                                    "vmTable",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new UnaryOperatorExpression(
                                    AphidTokenType.newKeyword,
                                    new CallExpression(
                                        new ArrayAccessExpression(
                                            new IdentifierExpression(
                                                "Dictionary",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "Type",
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
                                    "assocTable",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new UnaryOperatorExpression(
                                    AphidTokenType.newKeyword,
                                    new CallExpression(
                                        new ArrayAccessExpression(
                                            new IdentifierExpression(
                                                "Dictionary",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "Type",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
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
                                    "loadFor",
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
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "vmTable",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "ContainsKey",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "type",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "vmTable",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "get_Item",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "type",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                        }
                                                    ),
                                                    false
                                                ),
                                            },
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
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "viewModel",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "buildForType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new StringExpression(
                                                                "'AphidUI.ViewModels'"
                                                            ),
                                                            new IdentifierExpression(
                                                                "type",
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
                                                            "vmTable",
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
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new IdentifierExpression(
                                                            "v",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "assocs",
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
                                                                "v",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.PipelineOperator,
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "bind",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "fanPaths",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "bind",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "flattenPaths",
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
                                                            "assocTable",
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
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "assocs",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "flattenedPaths",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                    }
                                                ),
                                                new UnaryOperatorExpression(
                                                    AphidTokenType.retKeyword,
                                                    new IdentifierExpression(
                                                        "v",
                                                        new List<IdentifierExpression>
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
                        },
                        null
                    )
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "viewController",
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
                                    "table",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new UnaryOperatorExpression(
                                    AphidTokenType.newKeyword,
                                    new CallExpression(
                                        new ArrayAccessExpression(
                                            new IdentifierExpression(
                                                "Dictionary",
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
                                                new IdentifierExpression(
                                                    "DynamicView",
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
                                    "app",
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
                                    "autobind",
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
                                    "init",
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
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "app",
                                                new List<IdentifierExpression>
                                                {
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
                                                        "createAppAsync",
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
                                                "wait",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "app",
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
                                                            AphidTokenType.usingKeyword,
                                                            new BinaryOperatorExpression(
                                                                new BinaryOperatorExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "Xceed",
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
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "AvalonDock",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Layout",
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
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "docking",
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
                                                                    "loadDocking",
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
                                                            new IdentifierExpression(
                                                                "docking",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "pane",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "docking",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "FindName",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new StringExpression(
                                                                        "'DocPane'"
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
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "pane",
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
                                    "wait",
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
                                    "addView",
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
                                            "columns",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "associations",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "loadData",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "rowType",
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
                                                        "DynamicView",
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
                                                    "ViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dynamicViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "control",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                    "Name",
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
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "associations",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "view",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Associations",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new IdentifierExpression(
                                                                        "associations",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "associations",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.SelectOperator,
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
                                                                "Associations",
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
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "columns",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "view",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new IdentifierExpression(
                                                                        "columns",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "columns",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.SelectOperator,
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
                                                    )
                                                ),
                                            },
                                            null
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
                                                    "LoadData",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "loadData",
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
                                                    "ViewModelType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                        "rowType",
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
                                                    "table",
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
                                                    new IdentifierExpression(
                                                        "view",
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
                                                new IdentifierExpression(
                                                    "view",
                                                    new List<IdentifierExpression>
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
                                    "addBarGraphView",
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
                                            "loadData",
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
                                                        "DynamicView",
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
                                                    "ViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dynamicViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "barGraph",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                    "Name",
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
                                                    "view",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "LoadData",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "loadData",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
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
                                                    "Add",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "view",
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
                                                new IdentifierExpression(
                                                    "view",
                                                    new List<IdentifierExpression>
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
                                    "addListView",
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
                                            "columns",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "associations",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "loadData",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "rowType",
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
                                                        "DynamicView",
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
                                                    "ViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dynamicViewType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "dataGrid",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                    "Name",
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
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "associations",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "view",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Associations",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new IdentifierExpression(
                                                                        "associations",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "associations",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.SelectOperator,
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
                                                                "Associations",
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
                                                    )
                                                ),
                                            },
                                            null
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "columns",
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
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "view",
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
                                                                new UnaryOperatorExpression(
                                                                    AphidTokenType.PostfixCountOperator,
                                                                    new IdentifierExpression(
                                                                        "columns",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    false
                                                                ),
                                                            }
                                                        ),
                                                        false
                                                    )
                                                ),
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "columns",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.SelectOperator,
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
                                                    )
                                                ),
                                            },
                                            null
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
                                                    "LoadData",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new IdentifierExpression(
                                                "loadData",
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
                                                    "ViewModelType",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
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
                                                        "rowType",
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
                                                    "table",
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
                                                    new IdentifierExpression(
                                                        "view",
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
                                                new IdentifierExpression(
                                                    "view",
                                                    new List<IdentifierExpression>
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
                                    "navigate",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "view",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "navContext",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "dynView",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "view",
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
                                                    new BinaryOperatorExpression(
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "view",
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
                                                            "DynamicView",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "view",
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
                                                            "string",
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
                                                        "fatal",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Expected argument view to be of type string or DynamicView'"
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
                                                                new IdentifierExpression(
                                                                    "view",
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
                                                    new List<AphidExpression>
                                                    {
                                                        new IfExpression(
                                                            new UnaryOperatorExpression(
                                                                AphidTokenType.NotOperator,
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
                                                                            "ContainsKey",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "view",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                false
                                                            ),
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
                                                                        new BinaryOperatorExpression(
                                                                            new StringExpression(
                                                                                "'Could not find DynamicView with key {0}'"
                                                                            ),
                                                                            AphidTokenType.CustomOperator214,
                                                                            new IdentifierExpression(
                                                                                "view",
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
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
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
                                                                        "get_Item",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "view",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                    },
                                                    new List<AphidExpression>
                                                    {
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new IdentifierExpression(
                                                                "view",
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
                                                            new CallExpression(
                                                                new PatternMatchingExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "dynView",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "ViewType",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<PatternExpression>
                                                                    {
                                                                        new PatternExpression(
                                                                            new IdentifierExpression(
                                                                                "renderDataGrid",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "dynamicViewType",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "dataGrid",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                        new PatternExpression(
                                                                            new IdentifierExpression(
                                                                                "renderBarGraph",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                                new BinaryOperatorExpression(
                                                                                    new IdentifierExpression(
                                                                                        "dynamicViewType",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    ),
                                                                                    AphidTokenType.MemberOperator,
                                                                                    new IdentifierExpression(
                                                                                        "barGraph",
                                                                                        new List<IdentifierExpression>
                                                                                        {
                                                                                        }
                                                                                    )
                                                                                ),
                                                                            }
                                                                        ),
                                                                    }
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "dynView",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    new IdentifierExpression(
                                                                        "navContext",
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
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "renderDataGrid",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "dynView",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "navContext",
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
                                                    "'Rendering DataGrid view'"
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "dg",
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
                                                        "app",
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
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "wpf",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "bindingMode",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "BindingMode",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "OneWay",
                                                    new List<IdentifierExpression>
                                                    {
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
                                                    "'Configuring DataGrid columns'"
                                                ),
                                            }
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "dynView",
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
                                                AphidTokenType.NotEqualOperator,
                                                new NullExpression(
                                                )
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
                                                            "'Adding specified columns'"
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "dg",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "AutoGenerateColumns",
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
                                                            "dynView",
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
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "wpf",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dataGrid",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "addTextColumn",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "dg",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new ImplicitArgumentExpression(
                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                        ),
                                                                        new ImplicitArgumentExpression(
                                                                            AphidTokenType.ImplicitArgumentOperator
                                                                        ),
                                                                    }
                                                                ),
                                                                false
                                                            ),
                                                        }
                                                    )
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
                                                            "'Auto-generating columns'"
                                                        ),
                                                    }
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dg",
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
                                                            "dg",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "AutoGenerateColumns",
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
                                                    "'Checking for dynamic view associations'"
                                                ),
                                            }
                                        ),
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "dynView",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Associations",
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
                                                    new IdentifierExpression(
                                                        "printInfo",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new StringExpression(
                                                            "'Configuring dynamic view association columns'"
                                                        ),
                                                    }
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "dynView",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Associations",
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
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "wpf",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "dataGrid",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "addButtonColumn",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new IdentifierExpression(
                                                                            "dg",
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
                                                                        new CallExpression(
                                                                            new BinaryOperatorExpression(
                                                                                new IdentifierExpression(
                                                                                    "icons",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                ),
                                                                                AphidTokenType.MemberOperator,
                                                                                new IdentifierExpression(
                                                                                    "openView",
                                                                                    new List<IdentifierExpression>
                                                                                    {
                                                                                    }
                                                                                )
                                                                            ),
                                                                            new List<AphidExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        new NullExpression(
                                                                        ),
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
                                                                                new CallExpression(
                                                                                    new BinaryOperatorExpression(
                                                                                        new IdentifierExpression(
                                                                                            "viewController",
                                                                                            new List<IdentifierExpression>
                                                                                            {
                                                                                            }
                                                                                        ),
                                                                                        AphidTokenType.MemberOperator,
                                                                                        new IdentifierExpression(
                                                                                            "navigate",
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
                                                                                                "sender",
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
                                            },
                                            null
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
                                                    "'Loading view data'"
                                                ),
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "vmData",
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
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new IdentifierExpression(
                                                    "navContext",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "navContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "LoadData",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "LoadData",
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
                                                    "'Binding view data'"
                                                ),
                                            }
                                        ),
                                        new IfExpression(
                                            new IdentifierExpression(
                                                "autobind",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "dg",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ItemsSource",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "vmData",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.SelectOperator,
                                                            new PartialFunctionExpression(
                                                                new CallExpression(
                                                                    new BinaryOperatorExpression(
                                                                        new IdentifierExpression(
                                                                            "bind",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        ),
                                                                        AphidTokenType.MemberOperator,
                                                                        new IdentifierExpression(
                                                                            "typeToViewModel",
                                                                            new List<IdentifierExpression>
                                                                            {
                                                                            }
                                                                        )
                                                                    ),
                                                                    new List<AphidExpression>
                                                                    {
                                                                        new BinaryOperatorExpression(
                                                                            new IdentifierExpression(
                                                                                "dynView",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            ),
                                                                            AphidTokenType.MemberOperator,
                                                                            new IdentifierExpression(
                                                                                "ViewModelType",
                                                                                new List<IdentifierExpression>
                                                                                {
                                                                                }
                                                                            )
                                                                        ),
                                                                    }
                                                                )
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
                                                                "AsEnumerable",
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
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "dg",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ItemsSource",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "addDoc",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "dynView",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new IdentifierExpression(
                                                    "dg",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
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
                                                    "'Done rendering DataGrid view'"
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "renderBarGraph",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "dynView",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "navContext",
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
                                                    "'Rendering BarGraph view'"
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
                                                    "'Loading view data'"
                                                ),
                                            }
                                        ),
                                        new IdentifierExpression(
                                            "vmData",
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
                                            new UnaryOperatorExpression(
                                                AphidTokenType.definedKeyword,
                                                new IdentifierExpression(
                                                    "navContext",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                true
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "navContext",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.PipelineOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "LoadData",
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
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "dynView",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "LoadData",
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
                                                    "'Creating plot view control'"
                                                ),
                                            }
                                        ),
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
                                            new CallExpression(
                                                new IdentifierExpression(
                                                    "createLinearBarModel",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "vmData",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "grid",
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
                                                        "Grid",
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
                                                        "grid",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Children",
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
                                                    "view",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "addDoc",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "dynView",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new IdentifierExpression(
                                                    "grid",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
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
                                                    "'Done rendering BarGraph view'"
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "addDoc",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                AphidTokenType.ColonOperator,
                                new FunctionExpression(
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "dynView",
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
                                    },
                                    new List<AphidExpression>
                                    {
                                        new UnaryOperatorExpression(
                                            AphidTokenType.usingKeyword,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Xceed",
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
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "AvalonDock",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Layout",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            false
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
                                                    "'Creating layout document for pane'"
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "doc",
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
                                                        "LayoutDocument",
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
                                                    "doc",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dynView",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "doc",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "ContentId",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "dynView",
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
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "doc",
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
                                            new IdentifierExpression(
                                                "content",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "doc",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "IsActive",
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
                                            new IdentifierExpression(
                                                "printInfo",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new StringExpression(
                                                    "'Adding layout document to pane'"
                                                ),
                                            }
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "pane",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Children",
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
                                                    "doc",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        ),
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "doc",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "IsActive",
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
                                                    "'Pane successfully updated'"
                                                ),
                                            }
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "icons",
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
                                                "openView",
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
                                                                    "'\r\n            <Viewbox \r\n                xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"  \r\n                xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"  \r\n                xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"  \r\n                xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"\r\n                Width=\"16\" Height=\"16\">\r\n                <Rectangle Width=\"16\" Height=\"16\">\r\n                    <Rectangle.Fill>\r\n                        <DrawingBrush>\r\n                            <DrawingBrush.Drawing>\r\n                                <DrawingGroup>\r\n                                    <DrawingGroup.Children>\r\n                                        <GeometryDrawing Brush=\"#00FFFFFF\" Geometry=\"F1M16,16L0,16 0,0 16,0z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF6F6F6\" Geometry=\"F1M1.9998,-0.000199999999999534L2.8548,0.9998 -0.000199999999999978,0.9998 -0.000199999999999978,15.9998 15.9998,15.9998 15.9998,0.9998 7.8528,0.9998 6.9998,-0.000199999999999534z\" />\r\n                                        <GeometryDrawing Brush=\"#FF414141\" Geometry=\"F1M8.7046,2L9.5566,3 13.9996,3 13.9996,14 1.9996,14 1.9996,8.649C1.6266,8.47,1.2866,8.235,0.999599999999999,7.942L0.999599999999999,15 14.9996,15 14.9996,2z\" />\r\n                                        <GeometryDrawing Brush=\"#FF414141\" Geometry=\"F1M4,11L6,11 6,12 4,12z M7,11L9,11 9,12 7,12z M7,9L9,9 9,10 7,10z M10,11L12,11 12,12 10,12z M10,9L12,9 12,10 10,10z M10,7L12,7 12,8 10,8z M13,13L13,4 9.586,4 7,7 9,7 9,8 7,8 7,7 6,7 6,8 5,8 5,9 6,9 6,10 4,10 4,9 3.5,9C3.329,9,3.165,8.973,3,8.949L3,13z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M6,7L5,7 5,8 6,8z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M14,14L14,3 9.557,3 10,3.52 9.586,4 13,4 13,13 3,13 3,8.949C2.646,8.898,2.312,8.798,2,8.649L2,14z\" />\r\n                                        <GeometryDrawing Brush=\"#FF00529C\" Geometry=\"F1M6,1L4,1 5.988,3 3.5,3C2.119,3 1,4.119 1,5.5 1,6.881 2.119,8 3.5,8L4,8 4,7 3.5,7C2.673,7 2,6.327 2,5.5 2,4.673 2.673,4 3.5,4L6.013,4 4,6 6,6 8.5,3.515z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M5.0004,8.9998L3.9994,8.9998 3.9994,9.9998 6.0004,9.9998 6.0004,8.9998z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M5,8L6,8 6,7 5,7z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M7,12L9,12 9,10.999 7,10.999z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M7,8L9,8 9,7 7,7z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M4,12L6.001,12 6.001,10.999 4,10.999z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M10,12L12,12 12,10.999 10,10.999z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M7,10L9,10 9,9 7,9z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M10,8L12,8 12,7 10,7z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M10,10L12,10 12,9 10,9z\" />\r\n                                        <GeometryDrawing Brush=\"#FFF0EFF1\" Geometry=\"F1M9.5566,3L9.9996,3.52 9.5856,4 12.9996,4 12.9996,13 2.9996,13 2.9996,8.949C2.6466,8.898,2.3116,8.798,1.9996,8.649L1.9996,14 13.9996,14 13.9996,3z\" />\r\n                                    </DrawingGroup.Children>\r\n                                </DrawingGroup>\r\n                            </DrawingBrush.Drawing>\r\n                        </DrawingBrush>\r\n                    </Rectangle.Fill>\r\n                </Rectangle>            \r\n            </Viewbox>\r\n        '"
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
                        },
                        null
                    )
                ),
            }
;
        }
    }
}
