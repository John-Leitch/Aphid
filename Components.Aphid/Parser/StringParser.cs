using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public static class StringParser
    {
        public static string Parse(string value)
        {
            var delim = value[0];
            var s = value.Substring(1);
            s = s.Remove(s.Length - 1);
            var sb = new StringBuilder();

            var state = 0;

            byte b = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];

                switch (state)
                {
                    case 0:
                        switch (c)
                        {
                            case '\\':
                                state = 1;
                                break;

                            default:
                                sb.Append(c);
                                break;
                        }
                        break;

                    case 1:
                        switch (c)
                        {
                            case '\\':
                                sb.Append('\\');
                                state = 0;
                                break;

                            case 'r':
                                sb.Append('\r');
                                state = 0;
                                break;

                            case 'n':
                                sb.Append('\n');
                                state = 0;
                                break;

                            case 't':
                                sb.Append('\t');
                                state = 0;
                                break;

                            case '"':
                            case '\'':
                                if (c != delim)
                                {
                                    throw new InvalidOperationException();
                                }

                                sb.Append(delim);
                                state = 0;
                                break;

                            case 'x':
                                state = 2;
                                break;

                            default:
                                throw new InvalidOperationException("Invalid escape sequence");
                        }
                        break;

                    case 2:
                        switch (c)
                        {
                            case '0':
                                b = 0x00;
                                state = 3;
                                break;

                            case '1':
                                b = 0x10;
                                state = 3;
                                break;

                            case '2':
                                b = 0x20;
                                state = 3;
                                break;

                            case '3':
                                b = 0x30;
                                state = 3;
                                break;

                            case '4':
                                b = 0x40;
                                state = 3;
                                break;

                            case '5':
                                b = 0x50;
                                state = 3;
                                break;

                            case '6':
                                b = 0x60;
                                state = 3;
                                break;

                            case '7':
                                b = 0x70;
                                state = 3;
                                break;

                            case '8':
                                b = 0x80;
                                state = 3;
                                break;

                            case '9':
                                b = 0x90;
                                state = 3;
                                break;

                            case 'a':
                            case 'A':
                                b = 0xa0;
                                state = 3;
                                break;

                            case 'b':
                            case 'B':
                                b = 0xb0;
                                state = 3;
                                break;

                            case 'c':
                            case 'C':
                                b = 0xc0;
                                state = 3;
                                break;

                            case 'd':
                            case 'D':
                                b = 0xd0;
                                state = 3;
                                break;

                            case 'e':
                            case 'E':
                                b = 0xe0;
                                state = 3;
                                break;

                            case 'f':
                            case 'F':
                                b = 0xf0;
                                state = 3;
                                break;

                            default:
                                throw new InvalidOperationException();
                        }
                        break;

                    case 3:
                        switch (c)
                        {
                            case '0':
                                sb.Append((char)(b | 0x00));
                                state = 0;
                                break;

                            case '1':
                                sb.Append((char)(b | 0x01));
                                state = 0;
                                break;

                            case '2':
                                sb.Append((char)(b | 0x02));
                                state = 0;
                                break;

                            case '3':
                                sb.Append((char)(b | 0x03));
                                state = 0;
                                break;

                            case '4':
                                sb.Append((char)(b | 0x04));
                                state = 0;
                                break;

                            case '5':
                                sb.Append((char)(b | 0x05));
                                state = 0;
                                break;

                            case '6':
                                sb.Append((char)(b | 0x06));
                                state = 0;
                                break;

                            case '7':
                                sb.Append((char)(b | 0x07));
                                state = 0;
                                break;

                            case '8':
                                sb.Append((char)(b | 0x08));
                                state = 0;
                                break;

                            case '9':
                                sb.Append((char)(b | 0x09));
                                state = 0;
                                break;

                            case 'a':
                            case 'A':
                                sb.Append((char)(b | 0x0a));
                                state = 0;
                                break;

                            case 'b':
                            case 'B':
                                sb.Append((char)(b | 0x0b));
                                state = 0;
                                break;

                            case 'c':
                            case 'C':
                                sb.Append((char)(b | 0x0c));
                                state = 0;
                                break;

                            case 'd':
                            case 'D':
                                sb.Append((char)(b | 0x0d));
                                state = 0;
                                break;

                            case 'e':
                            case 'E':
                                sb.Append((char)(b | 0x0e));
                                state = 0;
                                break;

                            case 'f':
                            case 'F':
                                sb.Append((char)(b | 0x0f));
                                state = 0;
                                break;
                        }

                        break;

                    default:
                        throw new InvalidOperationException();
                }
            }

            return sb.ToString();
        }
    }
}
