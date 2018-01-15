using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static class ArgLexer
    {
        private enum ArgLexerState
        {
            InArg,
            InQuotedArg,
            InEscapeChar,
        }

        public static string[] Tokenize(string args)
        {
            var argList = new List<string>();

            ArgLexerState state = ArgLexerState.InArg, lastState = ArgLexerState.InArg;
            var buffer = new StringBuilder();

            for (int i = 0; i < args.Length; i++)
            {
                var c = args[i];

                switch (state)
                {
                    case ArgLexerState.InEscapeChar:
                        switch (c)
                        {
                            case '"':
                                buffer.Append(c);
                                state = lastState;
                                break;

                            default:
                                throw new InvalidOperationException();
                        }

                        break;

                    default:
                        switch (c)
                        {
                            case ' ':
                                switch (state)
                                {
                                    case ArgLexerState.InArg:
                                        if (buffer.Length != 0)
                                        {
                                            argList.Add(buffer.ToString());
                                        }

                                        buffer.Clear();
                                        break;

                                    case ArgLexerState.InQuotedArg:
                                        buffer.Append(' ');
                                        break;

                                    default:
                                        throw new InvalidOperationException();
                                }
                                break;

                            case '"':
                                switch (state)
                                {
                                    case ArgLexerState.InArg:
                                        if (buffer.Length != 0)
                                        {
                                            argList.Add(buffer.ToString());
                                        }

                                        buffer.Clear();
                                        state = ArgLexerState.InQuotedArg;
                                        break;

                                    case ArgLexerState.InQuotedArg:
                                        if (buffer.Length != 0)
                                        {
                                            argList.Add(buffer.ToString());
                                        }

                                        buffer.Clear();
                                        state = ArgLexerState.InArg;
                                        break;
                                }

                                break;

                            case '^':
                                lastState = state;
                                state = ArgLexerState.InEscapeChar;
                                break;

                            default:
                                buffer.Append(c);
                                break;
                        }

                        break;
                }
            }

            if (buffer.Length != 0)
            {
                switch (state)
                {
                    case ArgLexerState.InArg:
                        argList.Add(buffer.ToString());
                        break;

                    default:
                        throw new InvalidOperationException();
                }
            }

            return argList.ToArray();
        }
    }
}
