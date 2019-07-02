namespace BuiltInLibrary.Library
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Std()
        {
            return             new List<AphidExpression>
            {
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "Components",
                        new List<IdentifierExpression>
                        {
                        }
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
                new LoadLibraryExpression(
                    new StringExpression(
                        "'Components.Aphid.Library.StandardLibrary'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\Internals'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta\\\\Reflection'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\Operators'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\Enums'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\Linq'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\Async'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'String'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'List'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Conversion'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Query'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core\\\\ClrSerializer'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Math'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'IO'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Debugging\\\\Dbg'"
                    )
                ),
            }
;
        }
    }
}
