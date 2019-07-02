namespace BuiltInLibrary.Library.Gui
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> LaunchNodeMon()
        {
            return             new List<AphidExpression>
            {
                new LoadScriptExpression(
                    new StringExpression(
                        "'Std'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'DynamicUI'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'NodeMon'"
                    )
                ),
                new CallExpression(
                    new IdentifierExpression(
                        "createNodeMonWindow",
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
                        "startNodeMonServices",
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
;
        }
    }
}
