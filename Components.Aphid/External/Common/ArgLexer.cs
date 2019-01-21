using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public enum ArgTokenType
    {
        Unknown,
        Arg,
        QuotedArg,
    }

    public class ArgToken
    {
        public ArgTokenType Type { get; set; }

        public int Offset { get; set; }

        public int EndOffset { get; set; }

        public string Lexeme { get; set; }

        public string Value { get; set; }

        public ArgToken(ArgTokenType type, int offset, int endOffset, string lexeme, string value)
        {
            Type = type;
            Offset = offset;
            EndOffset = endOffset;
            Lexeme = lexeme;
            Value = value;
        }

        public override string ToString() =>
            $"[{Type}] {Offset:x4}-{EndOffset:x4} {Lexeme}: {Value}";
    }

    public static class ArgLexer
    {
        private enum ArgLexerState
        {
            InArg,
            InQuotedArg,
            InEscapeChar,
        }

        public static List<ArgToken> GetTokenInfo(string args)
        {
            var argList = new List<ArgToken>();

            ArgLexerState state = ArgLexerState.InArg, lastState = ArgLexerState.InArg;
            var buffer = new StringBuilder();
            var offset = -1;
            var i = 0;

            void add(int nextOffset)
            {
                var end = i + nextOffset;

                if (buffer.Length > 0)
                {
                    argList.Add(
                        new ArgToken(
                            state == ArgLexerState.InArg ? ArgTokenType.Arg : ArgTokenType.QuotedArg,
                            offset,
                            end,
                            args.Substring(offset, end - offset),
                            buffer.ToString()));

                    buffer.Clear();
                }

                offset = end;
            }

            for (i = 0; i < args.Length; i++)
            {
                var c = args[i];

                if (offset == -1)
                {
                    offset = i;
                }

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
                                        add(1);
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
                                        add(0);
                                        state = ArgLexerState.InQuotedArg;
                                        break;

                                    case ArgLexerState.InQuotedArg:
                                        add(1);
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
                        add(0);
                        break;

                    default:
                        throw new InvalidOperationException();
                }
            }

            return argList;
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
