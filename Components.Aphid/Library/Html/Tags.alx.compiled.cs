namespace BuiltInLibrary.Library.Html
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Tags()
        {
            return             new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "html",
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
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "html",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "tags",
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
                                        }
                                    ),
                                    false
                                )
                            ),
                            new BinaryOperatorExpression(
                                new BinaryOperatorExpression(
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "html",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "tags",
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
                                AphidTokenType.CustomOperator229,
                                new ArrayExpression(
                                    new List<AphidExpression>
                                    {
                                        new StringExpression(
                                            "\"a\""
                                        ),
                                        new StringExpression(
                                            "\"abbr\""
                                        ),
                                        new StringExpression(
                                            "\"address\""
                                        ),
                                        new StringExpression(
                                            "\"area\""
                                        ),
                                        new StringExpression(
                                            "\"article\""
                                        ),
                                        new StringExpression(
                                            "\"aside\""
                                        ),
                                        new StringExpression(
                                            "\"audio\""
                                        ),
                                        new StringExpression(
                                            "\"b\""
                                        ),
                                        new StringExpression(
                                            "\"base\""
                                        ),
                                        new StringExpression(
                                            "\"bdi\""
                                        ),
                                        new StringExpression(
                                            "\"bdo\""
                                        ),
                                        new StringExpression(
                                            "\"blockquote\""
                                        ),
                                        new StringExpression(
                                            "\"body\""
                                        ),
                                        new StringExpression(
                                            "\"br\""
                                        ),
                                        new StringExpression(
                                            "\"button\""
                                        ),
                                        new StringExpression(
                                            "\"canvas\""
                                        ),
                                        new StringExpression(
                                            "\"caption\""
                                        ),
                                        new StringExpression(
                                            "\"cite\""
                                        ),
                                        new StringExpression(
                                            "\"code\""
                                        ),
                                        new StringExpression(
                                            "\"col\""
                                        ),
                                        new StringExpression(
                                            "\"colgroup\""
                                        ),
                                        new StringExpression(
                                            "\"data\""
                                        ),
                                        new StringExpression(
                                            "\"datalist\""
                                        ),
                                        new StringExpression(
                                            "\"dd\""
                                        ),
                                        new StringExpression(
                                            "\"del\""
                                        ),
                                        new StringExpression(
                                            "\"details\""
                                        ),
                                        new StringExpression(
                                            "\"dfn\""
                                        ),
                                        new StringExpression(
                                            "\"dialog\""
                                        ),
                                        new StringExpression(
                                            "\"div\""
                                        ),
                                        new StringExpression(
                                            "\"dl\""
                                        ),
                                        new StringExpression(
                                            "\"dt\""
                                        ),
                                        new StringExpression(
                                            "\"em\""
                                        ),
                                        new StringExpression(
                                            "\"embed\""
                                        ),
                                        new StringExpression(
                                            "\"fieldset\""
                                        ),
                                        new StringExpression(
                                            "\"figcaption\""
                                        ),
                                        new StringExpression(
                                            "\"figure\""
                                        ),
                                        new StringExpression(
                                            "\"footer\""
                                        ),
                                        new StringExpression(
                                            "\"form\""
                                        ),
                                        new StringExpression(
                                            "\"h1\""
                                        ),
                                        new StringExpression(
                                            "\"h2\""
                                        ),
                                        new StringExpression(
                                            "\"h3\""
                                        ),
                                        new StringExpression(
                                            "\"h4\""
                                        ),
                                        new StringExpression(
                                            "\"h5\""
                                        ),
                                        new StringExpression(
                                            "\"h6\""
                                        ),
                                        new StringExpression(
                                            "\"head\""
                                        ),
                                        new StringExpression(
                                            "\"header\""
                                        ),
                                        new StringExpression(
                                            "\"hgroup\""
                                        ),
                                        new StringExpression(
                                            "\"hr\""
                                        ),
                                        new StringExpression(
                                            "\"html\""
                                        ),
                                        new StringExpression(
                                            "\"i\""
                                        ),
                                        new StringExpression(
                                            "\"iframe\""
                                        ),
                                        new StringExpression(
                                            "\"img\""
                                        ),
                                        new StringExpression(
                                            "\"input\""
                                        ),
                                        new StringExpression(
                                            "\"ins\""
                                        ),
                                        new StringExpression(
                                            "\"kbd\""
                                        ),
                                        new StringExpression(
                                            "\"keygen\""
                                        ),
                                        new StringExpression(
                                            "\"label\""
                                        ),
                                        new StringExpression(
                                            "\"legend\""
                                        ),
                                        new StringExpression(
                                            "\"li\""
                                        ),
                                        new StringExpression(
                                            "\"link\""
                                        ),
                                        new StringExpression(
                                            "\"main\""
                                        ),
                                        new StringExpression(
                                            "\"map\""
                                        ),
                                        new StringExpression(
                                            "\"mark\""
                                        ),
                                        new StringExpression(
                                            "\"math\""
                                        ),
                                        new StringExpression(
                                            "\"menu\""
                                        ),
                                        new StringExpression(
                                            "\"menuitem\""
                                        ),
                                        new StringExpression(
                                            "\"meta\""
                                        ),
                                        new StringExpression(
                                            "\"meter\""
                                        ),
                                        new StringExpression(
                                            "\"nav\""
                                        ),
                                        new StringExpression(
                                            "\"noscript\""
                                        ),
                                        new StringExpression(
                                            "\"object\""
                                        ),
                                        new StringExpression(
                                            "\"ol\""
                                        ),
                                        new StringExpression(
                                            "\"optgroup\""
                                        ),
                                        new StringExpression(
                                            "\"option\""
                                        ),
                                        new StringExpression(
                                            "\"output\""
                                        ),
                                        new StringExpression(
                                            "\"p\""
                                        ),
                                        new StringExpression(
                                            "\"param\""
                                        ),
                                        new StringExpression(
                                            "\"picture\""
                                        ),
                                        new StringExpression(
                                            "\"pre\""
                                        ),
                                        new StringExpression(
                                            "\"progress\""
                                        ),
                                        new StringExpression(
                                            "\"q\""
                                        ),
                                        new StringExpression(
                                            "\"rb\""
                                        ),
                                        new StringExpression(
                                            "\"rp\""
                                        ),
                                        new StringExpression(
                                            "\"rt\""
                                        ),
                                        new StringExpression(
                                            "\"rtc\""
                                        ),
                                        new StringExpression(
                                            "\"ruby\""
                                        ),
                                        new StringExpression(
                                            "\"s\""
                                        ),
                                        new StringExpression(
                                            "\"samp\""
                                        ),
                                        new StringExpression(
                                            "\"script\""
                                        ),
                                        new StringExpression(
                                            "\"section\""
                                        ),
                                        new StringExpression(
                                            "\"select\""
                                        ),
                                        new StringExpression(
                                            "\"slot\""
                                        ),
                                        new StringExpression(
                                            "\"small\""
                                        ),
                                        new StringExpression(
                                            "\"source\""
                                        ),
                                        new StringExpression(
                                            "\"span\""
                                        ),
                                        new StringExpression(
                                            "\"strong\""
                                        ),
                                        new StringExpression(
                                            "\"style\""
                                        ),
                                        new StringExpression(
                                            "\"sub\""
                                        ),
                                        new StringExpression(
                                            "\"summary\""
                                        ),
                                        new StringExpression(
                                            "\"sup\""
                                        ),
                                        new StringExpression(
                                            "\"svg\""
                                        ),
                                        new StringExpression(
                                            "\"table\""
                                        ),
                                        new StringExpression(
                                            "\"tbody\""
                                        ),
                                        new StringExpression(
                                            "\"td\""
                                        ),
                                        new StringExpression(
                                            "\"template\""
                                        ),
                                        new StringExpression(
                                            "\"textarea\""
                                        ),
                                        new StringExpression(
                                            "\"tfoot\""
                                        ),
                                        new StringExpression(
                                            "\"th\""
                                        ),
                                        new StringExpression(
                                            "\"thead\""
                                        ),
                                        new StringExpression(
                                            "\"time\""
                                        ),
                                        new StringExpression(
                                            "\"title\""
                                        ),
                                        new StringExpression(
                                            "\"tr\""
                                        ),
                                        new StringExpression(
                                            "\"track\""
                                        ),
                                        new StringExpression(
                                            "\"u\""
                                        ),
                                        new StringExpression(
                                            "\"ul\""
                                        ),
                                        new StringExpression(
                                            "\"var\""
                                        ),
                                        new StringExpression(
                                            "\"video\""
                                        ),
                                        new StringExpression(
                                            "\"wbr\""
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
