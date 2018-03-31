using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.External.ConsolePlus
{
    /// <summary>
    /// An enumeration that represents the state of the lexer.
    /// </summary>
    public enum CliLexerState
    {
        /// <summary>
        /// Represents the text reading state
        /// </summary>
        ReadingText,

        /// <summary>
        /// Represents the beginning of the token reading state
        /// </summary>
        ReadingTokenBeginning,

        /// <summary>
        /// Represents the token reading state
        /// </summary>
        ReadingToken,
    }
}
