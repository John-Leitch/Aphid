namespace Components
{

    public static partial class ArgLexer
    {
        private enum ArgLexerState
        {
            InArg,
            InQuotedArg,
            InEscapeChar,
        }
    }
}
