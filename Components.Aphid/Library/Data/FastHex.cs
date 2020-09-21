
                namespace Components
                {
                    using System;
                    using System.Collections.Generic;

                    public static class FastHex
                    {
                        public static byte[] Parse(string hex)
                        {
                            var chars = hex.ToCharArray();
                            var len = chars.Length;
                            var buffer = new byte[len / 2];
                            var j = 0;

                            for (var i = 0; i < len; i+= 2)
                            {
                                switch (chars[i])
                                {
                                    case '0':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x00; break;
                                            case '1': buffer[j++] = 0x01; break;
                                            case '2': buffer[j++] = 0x02; break;
                                            case '3': buffer[j++] = 0x03; break;
                                            case '4': buffer[j++] = 0x04; break;
                                            case '5': buffer[j++] = 0x05; break;
                                            case '6': buffer[j++] = 0x06; break;
                                            case '7': buffer[j++] = 0x07; break;
                                            case '8': buffer[j++] = 0x08; break;
                                            case '9': buffer[j++] = 0x09; break;
                                            case 'A': case 'a': buffer[j++] = 0x0a; break;
                                            case 'B': case 'b': buffer[j++] = 0x0b; break;
                                            case 'C': case 'c': buffer[j++] = 0x0c; break;
                                            case 'D': case 'd': buffer[j++] = 0x0d; break;
                                            case 'E': case 'e': buffer[j++] = 0x0e; break;
                                            case 'F': case 'f': buffer[j++] = 0x0f; break;
                                        }
                                        break;
                                    case '1':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x10; break;
                                            case '1': buffer[j++] = 0x11; break;
                                            case '2': buffer[j++] = 0x12; break;
                                            case '3': buffer[j++] = 0x13; break;
                                            case '4': buffer[j++] = 0x14; break;
                                            case '5': buffer[j++] = 0x15; break;
                                            case '6': buffer[j++] = 0x16; break;
                                            case '7': buffer[j++] = 0x17; break;
                                            case '8': buffer[j++] = 0x18; break;
                                            case '9': buffer[j++] = 0x19; break;
                                            case 'A': case 'a': buffer[j++] = 0x1a; break;
                                            case 'B': case 'b': buffer[j++] = 0x1b; break;
                                            case 'C': case 'c': buffer[j++] = 0x1c; break;
                                            case 'D': case 'd': buffer[j++] = 0x1d; break;
                                            case 'E': case 'e': buffer[j++] = 0x1e; break;
                                            case 'F': case 'f': buffer[j++] = 0x1f; break;
                                        }
                                        break;
                                    case '2':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x20; break;
                                            case '1': buffer[j++] = 0x21; break;
                                            case '2': buffer[j++] = 0x22; break;
                                            case '3': buffer[j++] = 0x23; break;
                                            case '4': buffer[j++] = 0x24; break;
                                            case '5': buffer[j++] = 0x25; break;
                                            case '6': buffer[j++] = 0x26; break;
                                            case '7': buffer[j++] = 0x27; break;
                                            case '8': buffer[j++] = 0x28; break;
                                            case '9': buffer[j++] = 0x29; break;
                                            case 'A': case 'a': buffer[j++] = 0x2a; break;
                                            case 'B': case 'b': buffer[j++] = 0x2b; break;
                                            case 'C': case 'c': buffer[j++] = 0x2c; break;
                                            case 'D': case 'd': buffer[j++] = 0x2d; break;
                                            case 'E': case 'e': buffer[j++] = 0x2e; break;
                                            case 'F': case 'f': buffer[j++] = 0x2f; break;
                                        }
                                        break;
                                    case '3':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x30; break;
                                            case '1': buffer[j++] = 0x31; break;
                                            case '2': buffer[j++] = 0x32; break;
                                            case '3': buffer[j++] = 0x33; break;
                                            case '4': buffer[j++] = 0x34; break;
                                            case '5': buffer[j++] = 0x35; break;
                                            case '6': buffer[j++] = 0x36; break;
                                            case '7': buffer[j++] = 0x37; break;
                                            case '8': buffer[j++] = 0x38; break;
                                            case '9': buffer[j++] = 0x39; break;
                                            case 'A': case 'a': buffer[j++] = 0x3a; break;
                                            case 'B': case 'b': buffer[j++] = 0x3b; break;
                                            case 'C': case 'c': buffer[j++] = 0x3c; break;
                                            case 'D': case 'd': buffer[j++] = 0x3d; break;
                                            case 'E': case 'e': buffer[j++] = 0x3e; break;
                                            case 'F': case 'f': buffer[j++] = 0x3f; break;
                                        }
                                        break;
                                    case '4':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x40; break;
                                            case '1': buffer[j++] = 0x41; break;
                                            case '2': buffer[j++] = 0x42; break;
                                            case '3': buffer[j++] = 0x43; break;
                                            case '4': buffer[j++] = 0x44; break;
                                            case '5': buffer[j++] = 0x45; break;
                                            case '6': buffer[j++] = 0x46; break;
                                            case '7': buffer[j++] = 0x47; break;
                                            case '8': buffer[j++] = 0x48; break;
                                            case '9': buffer[j++] = 0x49; break;
                                            case 'A': case 'a': buffer[j++] = 0x4a; break;
                                            case 'B': case 'b': buffer[j++] = 0x4b; break;
                                            case 'C': case 'c': buffer[j++] = 0x4c; break;
                                            case 'D': case 'd': buffer[j++] = 0x4d; break;
                                            case 'E': case 'e': buffer[j++] = 0x4e; break;
                                            case 'F': case 'f': buffer[j++] = 0x4f; break;
                                        }
                                        break;
                                    case '5':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x50; break;
                                            case '1': buffer[j++] = 0x51; break;
                                            case '2': buffer[j++] = 0x52; break;
                                            case '3': buffer[j++] = 0x53; break;
                                            case '4': buffer[j++] = 0x54; break;
                                            case '5': buffer[j++] = 0x55; break;
                                            case '6': buffer[j++] = 0x56; break;
                                            case '7': buffer[j++] = 0x57; break;
                                            case '8': buffer[j++] = 0x58; break;
                                            case '9': buffer[j++] = 0x59; break;
                                            case 'A': case 'a': buffer[j++] = 0x5a; break;
                                            case 'B': case 'b': buffer[j++] = 0x5b; break;
                                            case 'C': case 'c': buffer[j++] = 0x5c; break;
                                            case 'D': case 'd': buffer[j++] = 0x5d; break;
                                            case 'E': case 'e': buffer[j++] = 0x5e; break;
                                            case 'F': case 'f': buffer[j++] = 0x5f; break;
                                        }
                                        break;
                                    case '6':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x60; break;
                                            case '1': buffer[j++] = 0x61; break;
                                            case '2': buffer[j++] = 0x62; break;
                                            case '3': buffer[j++] = 0x63; break;
                                            case '4': buffer[j++] = 0x64; break;
                                            case '5': buffer[j++] = 0x65; break;
                                            case '6': buffer[j++] = 0x66; break;
                                            case '7': buffer[j++] = 0x67; break;
                                            case '8': buffer[j++] = 0x68; break;
                                            case '9': buffer[j++] = 0x69; break;
                                            case 'A': case 'a': buffer[j++] = 0x6a; break;
                                            case 'B': case 'b': buffer[j++] = 0x6b; break;
                                            case 'C': case 'c': buffer[j++] = 0x6c; break;
                                            case 'D': case 'd': buffer[j++] = 0x6d; break;
                                            case 'E': case 'e': buffer[j++] = 0x6e; break;
                                            case 'F': case 'f': buffer[j++] = 0x6f; break;
                                        }
                                        break;
                                    case '7':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x70; break;
                                            case '1': buffer[j++] = 0x71; break;
                                            case '2': buffer[j++] = 0x72; break;
                                            case '3': buffer[j++] = 0x73; break;
                                            case '4': buffer[j++] = 0x74; break;
                                            case '5': buffer[j++] = 0x75; break;
                                            case '6': buffer[j++] = 0x76; break;
                                            case '7': buffer[j++] = 0x77; break;
                                            case '8': buffer[j++] = 0x78; break;
                                            case '9': buffer[j++] = 0x79; break;
                                            case 'A': case 'a': buffer[j++] = 0x7a; break;
                                            case 'B': case 'b': buffer[j++] = 0x7b; break;
                                            case 'C': case 'c': buffer[j++] = 0x7c; break;
                                            case 'D': case 'd': buffer[j++] = 0x7d; break;
                                            case 'E': case 'e': buffer[j++] = 0x7e; break;
                                            case 'F': case 'f': buffer[j++] = 0x7f; break;
                                        }
                                        break;
                                    case '8':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x80; break;
                                            case '1': buffer[j++] = 0x81; break;
                                            case '2': buffer[j++] = 0x82; break;
                                            case '3': buffer[j++] = 0x83; break;
                                            case '4': buffer[j++] = 0x84; break;
                                            case '5': buffer[j++] = 0x85; break;
                                            case '6': buffer[j++] = 0x86; break;
                                            case '7': buffer[j++] = 0x87; break;
                                            case '8': buffer[j++] = 0x88; break;
                                            case '9': buffer[j++] = 0x89; break;
                                            case 'A': case 'a': buffer[j++] = 0x8a; break;
                                            case 'B': case 'b': buffer[j++] = 0x8b; break;
                                            case 'C': case 'c': buffer[j++] = 0x8c; break;
                                            case 'D': case 'd': buffer[j++] = 0x8d; break;
                                            case 'E': case 'e': buffer[j++] = 0x8e; break;
                                            case 'F': case 'f': buffer[j++] = 0x8f; break;
                                        }
                                        break;
                                    case '9':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0x90; break;
                                            case '1': buffer[j++] = 0x91; break;
                                            case '2': buffer[j++] = 0x92; break;
                                            case '3': buffer[j++] = 0x93; break;
                                            case '4': buffer[j++] = 0x94; break;
                                            case '5': buffer[j++] = 0x95; break;
                                            case '6': buffer[j++] = 0x96; break;
                                            case '7': buffer[j++] = 0x97; break;
                                            case '8': buffer[j++] = 0x98; break;
                                            case '9': buffer[j++] = 0x99; break;
                                            case 'A': case 'a': buffer[j++] = 0x9a; break;
                                            case 'B': case 'b': buffer[j++] = 0x9b; break;
                                            case 'C': case 'c': buffer[j++] = 0x9c; break;
                                            case 'D': case 'd': buffer[j++] = 0x9d; break;
                                            case 'E': case 'e': buffer[j++] = 0x9e; break;
                                            case 'F': case 'f': buffer[j++] = 0x9f; break;
                                        }
                                        break;
                                    case 'A': case 'a':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xa0; break;
                                            case '1': buffer[j++] = 0xa1; break;
                                            case '2': buffer[j++] = 0xa2; break;
                                            case '3': buffer[j++] = 0xa3; break;
                                            case '4': buffer[j++] = 0xa4; break;
                                            case '5': buffer[j++] = 0xa5; break;
                                            case '6': buffer[j++] = 0xa6; break;
                                            case '7': buffer[j++] = 0xa7; break;
                                            case '8': buffer[j++] = 0xa8; break;
                                            case '9': buffer[j++] = 0xa9; break;
                                            case 'A': case 'a': buffer[j++] = 0xaa; break;
                                            case 'B': case 'b': buffer[j++] = 0xab; break;
                                            case 'C': case 'c': buffer[j++] = 0xac; break;
                                            case 'D': case 'd': buffer[j++] = 0xad; break;
                                            case 'E': case 'e': buffer[j++] = 0xae; break;
                                            case 'F': case 'f': buffer[j++] = 0xaf; break;
                                        }
                                        break;
                                    case 'B': case 'b':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xb0; break;
                                            case '1': buffer[j++] = 0xb1; break;
                                            case '2': buffer[j++] = 0xb2; break;
                                            case '3': buffer[j++] = 0xb3; break;
                                            case '4': buffer[j++] = 0xb4; break;
                                            case '5': buffer[j++] = 0xb5; break;
                                            case '6': buffer[j++] = 0xb6; break;
                                            case '7': buffer[j++] = 0xb7; break;
                                            case '8': buffer[j++] = 0xb8; break;
                                            case '9': buffer[j++] = 0xb9; break;
                                            case 'A': case 'a': buffer[j++] = 0xba; break;
                                            case 'B': case 'b': buffer[j++] = 0xbb; break;
                                            case 'C': case 'c': buffer[j++] = 0xbc; break;
                                            case 'D': case 'd': buffer[j++] = 0xbd; break;
                                            case 'E': case 'e': buffer[j++] = 0xbe; break;
                                            case 'F': case 'f': buffer[j++] = 0xbf; break;
                                        }
                                        break;
                                    case 'C': case 'c':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xc0; break;
                                            case '1': buffer[j++] = 0xc1; break;
                                            case '2': buffer[j++] = 0xc2; break;
                                            case '3': buffer[j++] = 0xc3; break;
                                            case '4': buffer[j++] = 0xc4; break;
                                            case '5': buffer[j++] = 0xc5; break;
                                            case '6': buffer[j++] = 0xc6; break;
                                            case '7': buffer[j++] = 0xc7; break;
                                            case '8': buffer[j++] = 0xc8; break;
                                            case '9': buffer[j++] = 0xc9; break;
                                            case 'A': case 'a': buffer[j++] = 0xca; break;
                                            case 'B': case 'b': buffer[j++] = 0xcb; break;
                                            case 'C': case 'c': buffer[j++] = 0xcc; break;
                                            case 'D': case 'd': buffer[j++] = 0xcd; break;
                                            case 'E': case 'e': buffer[j++] = 0xce; break;
                                            case 'F': case 'f': buffer[j++] = 0xcf; break;
                                        }
                                        break;
                                    case 'D': case 'd':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xd0; break;
                                            case '1': buffer[j++] = 0xd1; break;
                                            case '2': buffer[j++] = 0xd2; break;
                                            case '3': buffer[j++] = 0xd3; break;
                                            case '4': buffer[j++] = 0xd4; break;
                                            case '5': buffer[j++] = 0xd5; break;
                                            case '6': buffer[j++] = 0xd6; break;
                                            case '7': buffer[j++] = 0xd7; break;
                                            case '8': buffer[j++] = 0xd8; break;
                                            case '9': buffer[j++] = 0xd9; break;
                                            case 'A': case 'a': buffer[j++] = 0xda; break;
                                            case 'B': case 'b': buffer[j++] = 0xdb; break;
                                            case 'C': case 'c': buffer[j++] = 0xdc; break;
                                            case 'D': case 'd': buffer[j++] = 0xdd; break;
                                            case 'E': case 'e': buffer[j++] = 0xde; break;
                                            case 'F': case 'f': buffer[j++] = 0xdf; break;
                                        }
                                        break;
                                    case 'E': case 'e':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xe0; break;
                                            case '1': buffer[j++] = 0xe1; break;
                                            case '2': buffer[j++] = 0xe2; break;
                                            case '3': buffer[j++] = 0xe3; break;
                                            case '4': buffer[j++] = 0xe4; break;
                                            case '5': buffer[j++] = 0xe5; break;
                                            case '6': buffer[j++] = 0xe6; break;
                                            case '7': buffer[j++] = 0xe7; break;
                                            case '8': buffer[j++] = 0xe8; break;
                                            case '9': buffer[j++] = 0xe9; break;
                                            case 'A': case 'a': buffer[j++] = 0xea; break;
                                            case 'B': case 'b': buffer[j++] = 0xeb; break;
                                            case 'C': case 'c': buffer[j++] = 0xec; break;
                                            case 'D': case 'd': buffer[j++] = 0xed; break;
                                            case 'E': case 'e': buffer[j++] = 0xee; break;
                                            case 'F': case 'f': buffer[j++] = 0xef; break;
                                        }
                                        break;
                                    case 'F': case 'f':
                                        switch (chars[i + 1]) {
                                            case '0': buffer[j++] = 0xf0; break;
                                            case '1': buffer[j++] = 0xf1; break;
                                            case '2': buffer[j++] = 0xf2; break;
                                            case '3': buffer[j++] = 0xf3; break;
                                            case '4': buffer[j++] = 0xf4; break;
                                            case '5': buffer[j++] = 0xf5; break;
                                            case '6': buffer[j++] = 0xf6; break;
                                            case '7': buffer[j++] = 0xf7; break;
                                            case '8': buffer[j++] = 0xf8; break;
                                            case '9': buffer[j++] = 0xf9; break;
                                            case 'A': case 'a': buffer[j++] = 0xfa; break;
                                            case 'B': case 'b': buffer[j++] = 0xfb; break;
                                            case 'C': case 'c': buffer[j++] = 0xfc; break;
                                            case 'D': case 'd': buffer[j++] = 0xfd; break;
                                            case 'E': case 'e': buffer[j++] = 0xfe; break;
                                            case 'F': case 'f': buffer[j++] = 0xff; break;
                                        }
                                        break;
                                }
                            }

                            return buffer;
                        }
                    }
                }
            