namespace BuiltInLibrary.Library
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> Cli()
        {
            return             new List<AphidExpression>
            {
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
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli\\\\Print'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli\\\\Console'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli\\\\Dump'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli\\\\Out'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Cli\\\\Repl'"
                    )
                ),
            }
;
        }
    }
}
