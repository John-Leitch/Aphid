
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "BY";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(53.4605 - lat) + Math.Abs(23.8823 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(53.5904 - lat) + Math.Abs(24.2478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88168 - lat) + Math.Abs(23.65545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0985 - lat) + Math.Abs(28.3331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8926 - lat) + Math.Abs(30.024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2168 - lat) + Math.Abs(27.8561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0131 - lat) + Math.Abs(25.3443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5974 - lat) + Math.Abs(24.9828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9432 - lat) + Math.Abs(27.425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1984 - lat) + Math.Abs(24.0115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3579 - lat) + Math.Abs(28.2207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1504 - lat) + Math.Abs(24.8153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0119 - lat) + Math.Abs(28.4843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0114 - lat) + Math.Abs(27.2695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8198 - lat) + Math.Abs(27.8685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4192 - lat) + Math.Abs(26.548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0052 - lat) + Math.Abs(28.0272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8141 - lat) + Math.Abs(29.1522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3994 - lat) + Math.Abs(29.0048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4255 - lat) + Math.Abs(28.157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37091 - lat) + Math.Abs(23.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.72136 - lat) + Math.Abs(25.79894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1492 - lat) + Math.Abs(25.3112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7534 - lat) + Math.Abs(28.1555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.1904 - lat) + Math.Abs(30.2049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9805 - lat) + Math.Abs(29.9925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7102 - lat) + Math.Abs(26.5228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4914 - lat) + Math.Abs(26.9111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.3945 - lat) + Math.Abs(26.6305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.83333 - lat) + Math.Abs(30.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5591 - lat) + Math.Abs(31.1794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7777 - lat) + Math.Abs(27.9389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1561 - lat) + Math.Abs(24.4513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2512 - lat) + Math.Abs(29.8288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0892 - lat) + Math.Abs(26.5266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9698 - lat) + Math.Abs(27.6685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4627 - lat) + Math.Abs(27.2137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.179 - lat) + Math.Abs(28.6158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9479 - lat) + Math.Abs(27.893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0683 - lat) + Math.Abs(27.735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5263 - lat) + Math.Abs(26.3125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1587 - lat) + Math.Abs(25.9075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4087 - lat) + Math.Abs(29.6955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0672 - lat) + Math.Abs(26.9902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5175 - lat) + Math.Abs(25.8429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2533 - lat) + Math.Abs(28.8193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9253 - lat) + Math.Abs(27.3815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03474 - lat) + Math.Abs(24.09829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8517 - lat) + Math.Abs(26.395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6329 - lat) + Math.Abs(29.7389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4092 - lat) + Math.Abs(30.7246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4785 - lat) + Math.Abs(26.7434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2142 - lat) + Math.Abs(26.0377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89115 - lat) + Math.Abs(26.84597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0402 - lat) + Math.Abs(28.267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7985 - lat) + Math.Abs(27.4132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7267 - lat) + Math.Abs(27.4606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6292 - lat) + Math.Abs(27.229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5194 - lat) + Math.Abs(29.5988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8329 - lat) + Math.Abs(23.6598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.51301 - lat) + Math.Abs(26.19381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2201 - lat) + Math.Abs(26.401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4798 - lat) + Math.Abs(26.3957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5969 - lat) + Math.Abs(30.071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0249 - lat) + Math.Abs(28.0894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7496 - lat) + Math.Abs(28.0115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0274 - lat) + Math.Abs(27.5597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0869 - lat) + Math.Abs(25.3163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0087 - lat) + Math.Abs(27.8866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4429 - lat) + Math.Abs(31.0014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15519 - lat) + Math.Abs(23.6329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2131 - lat) + Math.Abs(30.2877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6014 - lat) + Math.Abs(24.7465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6344 - lat) + Math.Abs(26.1855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.3689 - lat) + Math.Abs(27.4686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8108 - lat) + Math.Abs(29.7086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8313 - lat) + Math.Abs(27.5343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0101 - lat) + Math.Abs(27.441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7867 - lat) + Math.Abs(28.0186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7396 - lat) + Math.Abs(27.5037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7876 - lat) + Math.Abs(27.5415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86322 - lat) + Math.Abs(24.89357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5983 - lat) + Math.Abs(27.8621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2351 - lat) + Math.Abs(26.6494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9058 - lat) + Math.Abs(28.8135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28411 - lat) + Math.Abs(24.40721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0934 - lat) + Math.Abs(30.0495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3617 - lat) + Math.Abs(30.3916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9674 - lat) + Math.Abs(27.0562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1554 - lat) + Math.Abs(27.2412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5297 - lat) + Math.Abs(28.2467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.556 - lat) + Math.Abs(24.4573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5248 - lat) + Math.Abs(27.8303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8066 - lat) + Math.Abs(28.8698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4879 - lat) + Math.Abs(28.7856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8482 - lat) + Math.Abs(29.1491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4235 - lat) + Math.Abs(27.8301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1229 - lat) + Math.Abs(26.0951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0686 - lat) + Math.Abs(27.2179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1289 - lat) + Math.Abs(28.4921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.11676 - lat) + Math.Abs(26.83263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8042 - lat) + Math.Abs(29.4176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7216 - lat) + Math.Abs(24.1836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8397 - lat) + Math.Abs(27.3917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0147 - lat) + Math.Abs(28.11049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7335 - lat) + Math.Abs(28.3857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.61378 - lat) + Math.Abs(25.95537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0651 - lat) + Math.Abs(27.695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1891 - lat) + Math.Abs(26.1299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3011 - lat) + Math.Abs(28.6386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5081 - lat) + Math.Abs(30.4172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5359 - lat) + Math.Abs(26.8238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.644 - lat) + Math.Abs(28.8801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4542 - lat) + Math.Abs(26.7301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.88389 - lat) + Math.Abs(30.52028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9162 - lat) + Math.Abs(27.2009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9567 - lat) + Math.Abs(30.2496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.66192 - lat) + Math.Abs(29.15016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1032 - lat) + Math.Abs(30.9837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.30441 - lat) + Math.Abs(26.78209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2189 - lat) + Math.Abs(26.6779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.644 - lat) + Math.Abs(25.2027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6104 - lat) + Math.Abs(27.0733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5318 - lat) + Math.Abs(28.5987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5942 - lat) + Math.Abs(25.8191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7961 - lat) + Math.Abs(29.5004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.9102 - lat) + Math.Abs(26.708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5652 - lat) + Math.Abs(26.7314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2172 - lat) + Math.Abs(29.512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8789 - lat) + Math.Abs(26.9371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0185 - lat) + Math.Abs(31.7217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3138 - lat) + Math.Abs(25.6072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9794 - lat) + Math.Abs(30.4592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.2232 - lat) + Math.Abs(27.4609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4544 - lat) + Math.Abs(26.467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6222 - lat) + Math.Abs(27.6281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9 - lat) + Math.Abs(27.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2173 - lat) + Math.Abs(27.476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7776 - lat) + Math.Abs(30.1765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.6274 - lat) + Math.Abs(30.3082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0495 - lat) + Math.Abs(29.2456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4122 - lat) + Math.Abs(24.5387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.509 - lat) + Math.Abs(28.147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7905 - lat) + Math.Abs(24.074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3167 - lat) + Math.Abs(26.854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9168 - lat) + Math.Abs(30.3449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7788 - lat) + Math.Abs(27.5948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7522 - lat) + Math.Abs(26.0603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7985 - lat) + Math.Abs(28.0048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.0516 - lat) + Math.Abs(26.3103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8814 - lat) + Math.Abs(28.699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0388 - lat) + Math.Abs(26.2656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2472 - lat) + Math.Abs(26.8047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7823 - lat) + Math.Abs(27.8434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9458 - lat) + Math.Abs(30.7953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1013 - lat) + Math.Abs(30.2639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2796 - lat) + Math.Abs(28.7649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2064 - lat) + Math.Abs(27.8512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.0247 - lat) + Math.Abs(30.797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.88333 - lat) + Math.Abs(25.29972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7862 - lat) + Math.Abs(28.3288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.339 - lat) + Math.Abs(25.9867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7125 - lat) + Math.Abs(31.717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3178 - lat) + Math.Abs(29.1374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2497 - lat) + Math.Abs(29.7968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7132 - lat) + Math.Abs(27.2886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3118 - lat) + Math.Abs(26.2916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3291 - lat) + Math.Abs(30.1929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2438 - lat) + Math.Abs(27.0758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26494 - lat) + Math.Abs(24.42398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3353 - lat) + Math.Abs(31.3999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8522 - lat) + Math.Abs(27.1698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5387 - lat) + Math.Abs(30.9173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3525 - lat) + Math.Abs(32.0514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7583 - lat) + Math.Abs(25.1554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9865 - lat) + Math.Abs(27.7982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1301 - lat) + Math.Abs(30.8016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3506 - lat) + Math.Abs(31.1121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5648 - lat) + Math.Abs(26.1406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3221 - lat) + Math.Abs(30.2897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1516 - lat) + Math.Abs(27.0913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.6593 - lat) + Math.Abs(29.2684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1503 - lat) + Math.Abs(29.8794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.944 - lat) + Math.Abs(27.7823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4611 - lat) + Math.Abs(30.0018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2138 - lat) + Math.Abs(24.3564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9747 - lat) + Math.Abs(30.1513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6079 - lat) + Math.Abs(31.9586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4923 - lat) + Math.Abs(29.3356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0635 - lat) + Math.Abs(26.6321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2693 - lat) + Math.Abs(29.4752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8911 - lat) + Math.Abs(29.9552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4086 - lat) + Math.Abs(32.578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.51746 - lat) + Math.Abs(28.95645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9266 - lat) + Math.Abs(31.4779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5643 - lat) + Math.Abs(31.1364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.55757 - lat) + Math.Abs(23.80525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0898 - lat) + Math.Abs(30.2962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.40013 - lat) + Math.Abs(23.81 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1323 - lat) + Math.Abs(29.3257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9299 - lat) + Math.Abs(25.7727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8864 - lat) + Math.Abs(26.7432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.709 - lat) + Math.Abs(25.3401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1451 - lat) + Math.Abs(25.5365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4167 - lat) + Math.Abs(27.2958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6884 - lat) + Math.Abs(23.8258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2862 - lat) + Math.Abs(30.9863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4345 - lat) + Math.Abs(30.9754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.1384 - lat) + Math.Abs(27.6905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.758 - lat) + Math.Abs(26.43 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5215 - lat) + Math.Abs(27.1385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4624 - lat) + Math.Abs(29.9845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1893 - lat) + Math.Abs(30.6231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3247 - lat) + Math.Abs(26.0107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3121 - lat) + Math.Abs(26.538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8183 - lat) + Math.Abs(30.7001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2585 - lat) + Math.Abs(26.0144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0601 - lat) + Math.Abs(29.9184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.903 - lat) + Math.Abs(28.6845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0868 - lat) + Math.Abs(28.8567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1159 - lat) + Math.Abs(25.5773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7829 - lat) + Math.Abs(27.6407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6832 - lat) + Math.Abs(27.138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4631 - lat) + Math.Abs(25.4068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6786 - lat) + Math.Abs(27.94 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5716 - lat) + Math.Abs(30.691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1192 - lat) + Math.Abs(31.0939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7906 - lat) + Math.Abs(27.4505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1874 - lat) + Math.Abs(25.1597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1571 - lat) + Math.Abs(30.4601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75 - lat) + Math.Abs(23.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8918 - lat) + Math.Abs(27.7667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4089 - lat) + Math.Abs(31.3237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5676 - lat) + Math.Abs(28.2076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0566 - lat) + Math.Abs(27.2161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7352 - lat) + Math.Abs(30.2625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7059 - lat) + Math.Abs(28.4313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21948 - lat) + Math.Abs(23.74043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5689 - lat) + Math.Abs(31.3831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9164 - lat) + Math.Abs(30.9179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8098 - lat) + Math.Abs(30.9717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8584 - lat) + Math.Abs(29.1608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.521 - lat) + Math.Abs(30.2454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5314 - lat) + Math.Abs(24.9786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8536 - lat) + Math.Abs(30.2671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7179 - lat) + Math.Abs(30.5701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09755 - lat) + Math.Abs(23.68775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6413 - lat) + Math.Abs(27.0418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.787 - lat) + Math.Abs(30.2677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3785 - lat) + Math.Abs(26.6581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.3171 - lat) + Math.Abs(26.1376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.851 - lat) + Math.Abs(27.7139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8693 - lat) + Math.Abs(27.7005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9541 - lat) + Math.Abs(29.6255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.196 - lat) + Math.Abs(24.0166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.342 - lat) + Math.Abs(29.2736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5269 - lat) + Math.Abs(28.1732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.72406 - lat) + Math.Abs(25.49709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8391 - lat) + Math.Abs(28.9879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9994 - lat) + Math.Abs(29.7141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4731 - lat) + Math.Abs(25.1784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.80128 - lat) + Math.Abs(25.16711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7316 - lat) + Math.Abs(28.0577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2279 - lat) + Math.Abs(28.505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1327 - lat) + Math.Abs(26.0139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4784 - lat) + Math.Abs(30.3159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1384 - lat) + Math.Abs(29.2214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.421 - lat) + Math.Abs(25.936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2038 - lat) + Math.Abs(24.7863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.4207 - lat) + Math.Abs(30.2909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7115 - lat) + Math.Abs(30.6176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.813 - lat) + Math.Abs(30.3769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8653 - lat) + Math.Abs(30.5597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9854 - lat) + Math.Abs(30.36 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21611 - lat) + Math.Abs(24.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25028 - lat) + Math.Abs(26.79944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12139 - lat) + Math.Abs(26.07278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.51528 - lat) + Math.Abs(30.40528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.36389 - lat) + Math.Abs(30.39472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.69889 - lat) + Math.Abs(31.71417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.74998 - lat) + Math.Abs(27.33338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7275 - lat) + Math.Abs(28.4325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9833 - lat) + Math.Abs(27.8384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9753 - lat) + Math.Abs(27.8586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9094 - lat) + Math.Abs(27.3069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8211 - lat) + Math.Abs(27.4522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8191 - lat) + Math.Abs(27.5215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7662 - lat) + Math.Abs(27.3347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7817 - lat) + Math.Abs(27.4346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7969 - lat) + Math.Abs(27.7967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5871 - lat) + Math.Abs(27.0535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6404 - lat) + Math.Abs(27.9199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.6238 - lat) + Math.Abs(27.8977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3474 - lat) + Math.Abs(26.6895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3973 - lat) + Math.Abs(31.071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0022 - lat) + Math.Abs(27.6754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2698 - lat) + Math.Abs(27.1067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0024 - lat) + Math.Abs(27.7108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0072 - lat) + Math.Abs(27.6963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0036 - lat) + Math.Abs(27.5669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.07598 - lat) + Math.Abs(28.00698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.95295 - lat) + Math.Abs(30.38278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.04059 - lat) + Math.Abs(28.19813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.73937 - lat) + Math.Abs(27.69276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7766 - lat) + Math.Abs(30.3497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Indura", "03", 53.4605, 23.8823);
case 1: return new CityInfo("Skidel’", "03", 53.5904, 24.2478);
case 2: return new CityInfo("Znamenka", "01", 51.88168, 23.65545);
case 3: return new CityInfo("Horad Zhodzina", "05", 54.0985, 28.3331);
case 4: return new CityInfo("Zhlobin", "02", 52.8926, 30.024);
case 5: return new CityInfo("Zhytkavichy", "02", 52.2168, 27.8561);
case 6: return new CityInfo("Zhirovichi", "03", 53.0131, 25.3443);
case 7: return new CityInfo("Zhaludok", "03", 53.5974, 24.9828);
case 8: return new CityInfo("Zhdanovichy", "05", 53.9432, 27.425);
case 9: return new CityInfo("Zhabinka", "01", 52.1984, 24.0115);
case 10: return new CityInfo("Zyembin", "05", 54.3579, 28.2207);
case 11: return new CityInfo("Zel’va", "03", 53.1504, 24.8153);
case 12: return new CityInfo("Zyalyony Bor", "05", 54.0119, 28.4843);
case 13: return new CityInfo("Zaslawye", "05", 54.0114, 27.2695);
case 14: return new CityInfo("Zamostochye", "05", 53.8198, 27.8685);
case 15: return new CityInfo("Zalyessye", "03", 54.4192, 26.548);
case 16: return new CityInfo("Zabalotstsye", "05", 54.0052, 28.0272);
case 17: return new CityInfo("Yel’sk", "02", 51.8141, 29.1522);
case 18: return new CityInfo("Yalizava", "06", 53.3994, 29.0048);
case 19: return new CityInfo("Yazna", "07", 55.4255, 28.157);
case 20: return new CityInfo("Vysokaye", "01", 52.37091, 23.37083);
case 21: return new CityInfo("Vselyub", "03", 53.72136, 25.79894);
case 22: return new CityInfo("Voranava", "03", 54.1492, 25.3112);
case 23: return new CityInfo("Valyevachy", "05", 53.7534, 28.1555);
case 24: return new CityInfo("Vitebsk", "07", 55.1904, 30.2049);
case 25: return new CityInfo("Vishow", "06", 53.9805, 29.9925);
case 26: return new CityInfo("Vishnyeva", "03", 54.7102, 26.5228);
case 27: return new CityInfo("Vilyeyka", "05", 54.4914, 26.9111);
case 28: return new CityInfo("Vidzy", "07", 55.3945, 26.6305);
case 29: return new CityInfo("Veyno", "06", 53.83333, 30.38333);
case 30: return new CityInfo("Vyetka", "02", 52.5591, 31.1794);
case 31: return new CityInfo("Vyerkhnyadzvinsk", "07", 55.7777, 27.9389);
case 32: return new CityInfo("Volkovysk", "03", 53.1561, 24.4513);
case 33: return new CityInfo("Vasilyevichy", "02", 52.2512, 29.8288);
case 34: return new CityInfo("Valozhyn", "05", 54.0892, 26.5266);
case 35: return new CityInfo("Valer’yanovo", "05", 53.9698, 27.6685);
case 36: return new CityInfo("Uzda", "05", 53.4627, 27.2137);
case 37: return new CityInfo("Ushachy", "07", 55.179, 28.6158);
case 38: return new CityInfo("Urechcha", "05", 52.9479, 27.893);
case 39: return new CityInfo("Turaw", "02", 52.0683, 27.735);
case 40: return new CityInfo("Turets", "03", 53.5263, 26.3125);
case 41: return new CityInfo("Traby", "03", 54.1587, 25.9075);
case 42: return new CityInfo("Talachyn", "07", 54.4087, 29.6955);
case 43: return new CityInfo("Tsimkavichy", "05", 53.0672, 26.9902);
case 44: return new CityInfo("Tsyelyakhany", "01", 52.5175, 25.8429);
case 45: return new CityInfo("Tatarka", "06", 53.2533, 28.8193);
case 46: return new CityInfo("Tarasovo", "05", 53.9253, 27.3815);
case 47: return new CityInfo("Svislach", "03", 53.03474, 24.09829);
case 48: return new CityInfo("Svir", "05", 54.8517, 26.395);
case 49: return new CityInfo("Svyetlahorsk", "02", 52.6329, 29.7389);
case 50: return new CityInfo("Surazh", "07", 55.4092, 30.7246);
case 51: return new CityInfo("Stowbtsy", "05", 53.4785, 26.7434);
case 52: return new CityInfo("Stalovichy", "01", 53.2142, 26.0377);
case 53: return new CityInfo("Stolin", "01", 51.89115, 26.84597);
case 54: return new CityInfo("Staryya Darohi", "05", 53.0402, 28.267);
case 55: return new CityInfo("Budsław", "05", 54.7985, 27.4132);
case 56: return new CityInfo("Starobin", "05", 52.7267, 27.4606);
case 57: return new CityInfo("Stan’kava", "05", 53.6292, 27.229);
case 58: return new CityInfo("Sasnovy Bor", "02", 52.5194, 29.5988);
case 59: return new CityInfo("Sapotskin", "03", 53.8329, 23.6598);
case 60: return new CityInfo("Soly", "03", 54.51301, 26.19381);
case 61: return new CityInfo("Snow", "05", 53.2201, 26.401);
case 62: return new CityInfo("Smarhon’", "03", 54.4798, 26.3957);
case 63: return new CityInfo("Smolyany", "07", 54.5969, 30.071);
case 64: return new CityInfo("Horad Smalyavichy", "05", 54.0249, 28.0894);
case 65: return new CityInfo("Smilavichy", "05", 53.7496, 28.0115);
case 66: return new CityInfo("Slutsk", "05", 53.0274, 27.5597);
case 67: return new CityInfo("Slonim", "03", 53.0869, 25.3163);
case 68: return new CityInfo("Slabada", "05", 54.0087, 27.8866);
case 69: return new CityInfo("Slawharad", "06", 53.4429, 31.0014);
case 70: return new CityInfo("Skoki", "01", 52.15519, 23.6329);
case 71: return new CityInfo("Shklow", "06", 54.2131, 30.2877);
case 72: return new CityInfo("Shchuchyn", "03", 53.6014, 24.7465);
case 73: return new CityInfo("Shchorsy", "03", 53.6344, 26.1855);
case 74: return new CityInfo("Sharkawshchyna", "07", 55.3689, 27.4686);
case 75: return new CityInfo("Syanno", "07", 54.8108, 29.7086);
case 76: return new CityInfo("Syenitsa", "05", 53.8313, 27.5343);
case 77: return new CityInfo("Syomkava", "05", 54.0101, 27.441);
case 78: return new CityInfo("Sarachy", "05", 52.7867, 28.0186);
case 79: return new CityInfo("Samakhvalavichy", "05", 53.7396, 27.5037);
case 80: return new CityInfo("Salihorsk", "05", 52.7876, 27.5415);
case 81: return new CityInfo("Ruzhany", "01", 52.86322, 24.89357);
case 82: return new CityInfo("Rudzyensk", "05", 53.5983, 27.8621);
case 83: return new CityInfo("Rudawka", "05", 53.2351, 26.6494);
case 84: return new CityInfo("Rasony", "07", 55.9058, 28.8135);
case 85: return new CityInfo("Ross’", "03", 53.28411, 24.40721);
case 86: return new CityInfo("Rahachow", "02", 53.0934, 30.0495);
case 87: return new CityInfo("Rechytsa", "02", 52.3617, 30.3916);
case 88: return new CityInfo("Rakaw", "05", 53.9674, 27.0562);
case 89: return new CityInfo("Radashkovichy", "05", 54.1554, 27.2412);
case 90: return new CityInfo("Pukhavichy", "05", 53.5297, 28.2467);
case 91: return new CityInfo("Pruzhany", "01", 52.556, 24.4573);
case 92: return new CityInfo("Prawdzinski", "05", 53.5248, 27.8303);
case 93: return new CityInfo("Paplavy", "05", 53.8066, 28.8698);
case 94: return new CityInfo("Polatsk", "07", 55.4879, 28.7856);
case 95: return new CityInfo("Pahost", "05", 53.8482, 29.1491);
case 96: return new CityInfo("Plyeshchanitsy", "05", 54.4235, 27.8301);
case 97: return new CityInfo("Pinsk", "01", 52.1229, 26.0951);
case 98: return new CityInfo("Pyatryshki", "05", 54.0686, 27.2179);
case 99: return new CityInfo("Pyetrykaw", "02", 52.1289, 28.4921);
case 100: return new CityInfo("Pastavy", "07", 55.11676, 26.83263);
case 101: return new CityInfo("Parychy", "02", 52.8042, 29.4176);
case 102: return new CityInfo("Azyory", "03", 53.7216, 24.1836);
case 103: return new CityInfo("Azyartso", "05", 53.8397, 27.3917);
case 104: return new CityInfo("Osveya", "07", 56.0147, 28.11049);
case 105: return new CityInfo("Ostrovy", "05", 53.7335, 28.3857);
case 106: return new CityInfo("Astravyets", "03", 54.61378, 25.95537);
case 107: return new CityInfo("Astrashytski Haradok", "05", 54.0651, 27.695);
case 108: return new CityInfo("Asnyezhytsy", "01", 52.1891, 26.1299);
case 109: return new CityInfo("Asipovichy", "06", 53.3011, 28.6386);
case 110: return new CityInfo("Orsha", "07", 54.5081, 30.4172);
case 111: return new CityInfo("Opsa", "07", 55.5359, 26.8238);
case 112: return new CityInfo("Aktsyabrski", "02", 52.644, 28.8801);
case 113: return new CityInfo("Novy Svyerzhan’", "05", 53.4542, 26.7301);
case 114: return new CityInfo("Kadino", "06", 53.88389, 30.52028);
case 115: return new CityInfo("Novosel’ye", "05", 53.9162, 27.2009);
case 116: return new CityInfo("Novoye Pashkovo", "06", 53.9567, 30.2496);
case 117: return new CityInfo("Novolukoml’", "07", 54.66192, 29.15016);
case 118: return new CityInfo("Novaya Huta", "02", 52.1032, 30.9837);
case 119: return new CityInfo("Nasilava", "05", 54.30441, 26.78209);
case 120: return new CityInfo("Nyasvizh", "05", 53.2189, 26.6779);
case 121: return new CityInfo("Nyakhachava", "01", 52.644, 25.2027);
case 122: return new CityInfo("Nyehorelaye", "05", 53.6104, 27.0733);
case 123: return new CityInfo("Navapolatsk", "07", 55.5318, 28.5987);
case 124: return new CityInfo("Novogrudok", "03", 53.5942, 25.8191);
case 125: return new CityInfo("Narowlya", "02", 51.7961, 29.5004);
case 126: return new CityInfo("Narach", "05", 54.9102, 26.708);
case 127: return new CityInfo("Narach", "05", 54.5652, 26.7314);
case 128: return new CityInfo("Myshkavichy", "06", 53.2172, 29.512);
case 129: return new CityInfo("Myadzyel", "05", 54.8789, 26.9371);
case 130: return new CityInfo("Mstsislaw", "06", 54.0185, 31.7217);
case 131: return new CityInfo("Motal’", "01", 52.3138, 25.6072);
case 132: return new CityInfo("Mastok", "06", 53.9794, 30.4592);
case 133: return new CityInfo("Mosar", "07", 55.2232, 27.4609);
case 134: return new CityInfo("Mir", "03", 53.4544, 26.467);
case 135: return new CityInfo("Myory", "07", 55.6222, 27.6281);
case 136: return new CityInfo("Minsk", "04", 53.9, 27.56667);
case 137: return new CityInfo("Mikashevichy", "01", 52.2173, 27.476);
case 138: return new CityInfo("Myazhysyatki", "06", 53.7776, 30.1765);
case 139: return new CityInfo("Myezhava", "07", 54.6274, 30.3082);
case 140: return new CityInfo("Mazyr", "02", 52.0495, 29.2456);
case 141: return new CityInfo("Mosty", "03", 53.4122, 24.5387);
case 142: return new CityInfo("Mar’’ina Horka", "05", 53.509, 28.147);
case 143: return new CityInfo("Malaryta", "01", 51.7905, 24.074);
case 144: return new CityInfo("Maladzyechna", "05", 54.3167, 26.854);
case 145: return new CityInfo("Mahilyow", "06", 53.9168, 30.3449);
case 146: return new CityInfo("Machulishchy", "05", 53.7788, 27.5948);
case 147: return new CityInfo("Lyubcha", "03", 53.7522, 26.0603);
case 148: return new CityInfo("Lyuban’", "05", 52.7985, 28.0048);
case 149: return new CityInfo("Lyntupy", "07", 55.0516, 26.3103);
case 150: return new CityInfo("Lyepyel’", "07", 54.8814, 28.699);
case 151: return new CityInfo("Lyakhavichy", "01", 53.0388, 26.2656);
case 152: return new CityInfo("Luninyets", "01", 52.2472, 26.8047);
case 153: return new CityInfo("Luhavaya Slabada", "05", 53.7823, 27.8434);
case 154: return new CityInfo("Loyew", "02", 51.9458, 30.7953);
case 155: return new CityInfo("Lotva", "06", 54.1013, 30.2639);
case 156: return new CityInfo("Loshnitsa", "05", 54.2796, 28.7649);
case 157: return new CityInfo("Lahoysk", "05", 54.2064, 27.8512);
case 158: return new CityInfo("Lyozna", "07", 55.0247, 30.797);
case 159: return new CityInfo("Lida", "03", 53.88333, 25.29972);
case 160: return new CityInfo("Lyel’chytsy", "02", 51.7862, 28.3288);
case 161: return new CityInfo("Lahishyn", "01", 52.339, 25.9867);
case 162: return new CityInfo("Krychaw", "06", 53.7125, 31.717);
case 163: return new CityInfo("Krupki", "05", 54.3178, 29.1374);
case 164: return new CityInfo("Kruhlaye", "06", 54.2497, 29.7968);
case 165: return new CityInfo("Kryvichy", "05", 54.7132, 27.2886);
case 166: return new CityInfo("Kreva", "03", 54.3118, 26.2916);
case 167: return new CityInfo("Krasnyy Bereg", "06", 53.3291, 30.1929);
case 168: return new CityInfo("Krasnaye", "05", 54.2438, 27.0758);
case 169: return new CityInfo("Krasnosel’skiy", "03", 53.26494, 24.42398);
case 170: return new CityInfo("Krasnapollye", "06", 53.3353, 31.3999);
case 171: return new CityInfo("Chyrvonaya Slabada", "05", 52.8522, 27.1698);
case 172: return new CityInfo("Kastsyukowka", "02", 52.5387, 30.9173);
case 173: return new CityInfo("Kastsyukovichy", "06", 53.3525, 32.0514);
case 174: return new CityInfo("Kosava", "01", 52.7583, 25.1554);
case 175: return new CityInfo("Korolëv Stan", "05", 53.9865, 27.7982);
case 176: return new CityInfo("Karma", "02", 53.1301, 30.8016);
case 177: return new CityInfo("Karanyowka", "02", 52.3506, 31.1121);
case 178: return new CityInfo("Karelichy", "03", 53.5648, 26.1406);
case 179: return new CityInfo("Kopys’", "07", 54.3221, 30.2897);
case 180: return new CityInfo("Kapyl’", "05", 53.1516, 27.0913);
case 181: return new CityInfo("Konstantinovo", "07", 54.6593, 29.2684);
case 182: return new CityInfo("Komsyenichy", "06", 54.1503, 29.8794);
case 183: return new CityInfo("Kalodzishchy", "05", 53.944, 27.7823);
case 184: return new CityInfo("Kokhanava", "07", 54.4611, 30.0018);
case 185: return new CityInfo("Kobryn", "01", 52.2138, 24.3564);
case 186: return new CityInfo("Knyazhytsy", "06", 53.9747, 30.1513);
case 187: return new CityInfo("Klimavichy", "06", 53.6079, 31.9586);
case 188: return new CityInfo("Klichaw", "06", 53.4923, 29.3356);
case 189: return new CityInfo("Klyetsk", "05", 53.0635, 26.6321);
case 190: return new CityInfo("Kirawsk", "06", 53.2693, 29.4752);
case 191: return new CityInfo("Khoyniki", "02", 51.8911, 29.9552);
case 192: return new CityInfo("Khotsimsk", "06", 53.4086, 32.578);
case 193: return new CityInfo("Kholopenichi", "05", 54.51746, 28.95645);
case 194: return new CityInfo("Khodasy", "06", 53.9266, 31.4779);
case 195: return new CityInfo("Khal’ch", "02", 52.5643, 31.1364);
case 196: return new CityInfo("Kamyanyuki", "01", 52.55757, 23.80525);
case 197: return new CityInfo("Kamyennyya Lavy", "06", 54.0898, 30.2962);
case 198: return new CityInfo("Kamyanyets", "01", 52.40013, 23.81);
case 199: return new CityInfo("Kalinkavichy", "02", 52.1323, 29.3257);
case 200: return new CityInfo("Iwye", "03", 53.9299, 25.7727);
case 201: return new CityInfo("Ivyanyets", "05", 53.8864, 26.7432);
case 202: return new CityInfo("Ivatsevichy", "01", 52.709, 25.3401);
case 203: return new CityInfo("Ivanava", "01", 52.1451, 25.5365);
case 204: return new CityInfo("Il’ya", "05", 54.4167, 27.2958);
case 205: return new CityInfo("Hrodna", "03", 53.6884, 23.8258);
case 206: return new CityInfo("Horki", "06", 54.2862, 30.9863);
case 207: return new CityInfo("Homyel'", "02", 52.4345, 30.9754);
case 208: return new CityInfo("Hlybokaye", "07", 55.1384, 27.6905);
case 209: return new CityInfo("Hantsavichy", "01", 52.758, 26.43);
case 210: return new CityInfo("Hotsk", "05", 52.5215, 27.1385);
case 211: return new CityInfo("Haradok", "07", 55.4624, 29.9845);
case 212: return new CityInfo("Haradzishcha", "06", 54.1893, 30.6231);
case 213: return new CityInfo("Haradzishcha", "01", 53.3247, 26.0107);
case 214: return new CityInfo("Haradzyeya", "05", 53.3121, 26.538);
case 215: return new CityInfo("Harbavichy", "06", 53.8183, 30.7001);
case 216: return new CityInfo("Hal’shany", "03", 54.2585, 26.0144);
case 217: return new CityInfo("Halowchyn", "06", 54.0601, 29.9184);
case 218: return new CityInfo("Hlusk", "06", 52.903, 28.6845);
case 219: return new CityInfo("Hlusha", "06", 53.0868, 28.8567);
case 220: return new CityInfo("Hyeranyony", "03", 54.1159, 25.5773);
case 221: return new CityInfo("Hatava", "05", 53.7829, 27.6407);
case 222: return new CityInfo("Dzyarzhynsk", "05", 53.6832, 27.138);
case 223: return new CityInfo("Dyatlovo", "03", 53.4631, 25.4068);
case 224: return new CityInfo("Dukora", "05", 53.6786, 27.94);
case 225: return new CityInfo("Dubrowna", "07", 54.5716, 30.691);
case 226: return new CityInfo("Drybin", "06", 54.1192, 31.0939);
case 227: return new CityInfo("Druya", "07", 55.7906, 27.4505);
case 228: return new CityInfo("Drahichyn", "01", 52.1874, 25.1597);
case 229: return new CityInfo("Dowsk", "02", 53.1571, 30.4601);
case 230: return new CityInfo("Damachava", "01", 51.75, 23.6);
case 231: return new CityInfo("Dokshytsy", "07", 54.8918, 27.7667);
case 232: return new CityInfo("Dobrush", "02", 52.4089, 31.3237);
case 233: return new CityInfo("Dzisna", "07", 55.5676, 28.2076);
case 234: return new CityInfo("Davyd-Haradok", "01", 52.0566, 27.2161);
case 235: return new CityInfo("Dashkawka", "06", 53.7352, 30.2625);
case 236: return new CityInfo("Chervyen’", "05", 53.7059, 28.4313);
case 237: return new CityInfo("Charnawchytsy", "01", 52.21948, 23.74043);
case 238: return new CityInfo("Cherykaw", "06", 53.5689, 31.3831);
case 239: return new CityInfo("Chachersk", "02", 52.9164, 30.9179);
case 240: return new CityInfo("Chavusy", "06", 53.8098, 30.9717);
case 241: return new CityInfo("Chashniki", "07", 54.8584, 29.1608);
case 242: return new CityInfo("Bykhaw", "06", 53.521, 30.2454);
case 243: return new CityInfo("Byaroza", "01", 52.5314, 24.9786);
case 244: return new CityInfo("Buynichy", "06", 53.8536, 30.2671);
case 245: return new CityInfo("Buda-Kashalyova", "02", 52.7179, 30.5701);
case 246: return new CityInfo("Brest", "01", 52.09755, 23.68775);
case 247: return new CityInfo("Braslaw", "07", 55.6413, 27.0418);
case 248: return new CityInfo("Brahin", "02", 51.787, 30.2677);
case 249: return new CityInfo("Turets-Bayary", "05", 54.3785, 26.6581);
case 250: return new CityInfo("Baruny", "03", 54.3171, 26.1376);
case 251: return new CityInfo("Vyaliki Trastsyanets", "05", 53.851, 27.7139);
case 252: return new CityInfo("Bol’shoye Stiklevo", "05", 53.8693, 27.7005);
case 253: return new CityInfo("Vyalikaya Mashchanitsa", "06", 53.9541, 29.6255);
case 254: return new CityInfo("Vyalikaya Byerastavitsa", "03", 53.196, 24.0166);
case 255: return new CityInfo("Bobr", "05", 54.342, 29.2736);
case 256: return new CityInfo("Blon’", "05", 53.5269, 28.1732);
case 257: return new CityInfo("Byarozawka", "03", 53.72406, 25.49709);
case 258: return new CityInfo("Byerazino", "05", 53.8391, 28.9879);
case 259: return new CityInfo("Byalynichy", "06", 53.9994, 29.7141);
case 260: return new CityInfo("Byelaazyorsk", "01", 52.4731, 25.1784);
case 261: return new CityInfo("Byelagruda", "03", 53.80128, 25.16711);
case 262: return new CityInfo("Byahoml’", "07", 54.7316, 28.0577);
case 263: return new CityInfo("Barysaw", "05", 54.2279, 28.505);
case 264: return new CityInfo("Baranovichi", "01", 53.1327, 26.0139);
case 265: return new CityInfo("Baran’", "07", 54.4784, 30.3159);
case 266: return new CityInfo("Babruysk", "06", 53.1384, 29.2214);
case 267: return new CityInfo("Ashmyany", "03", 54.421, 25.936);
case 268: return new CityInfo("Antopal’", "01", 52.2038, 24.7863);
case 269: return new CityInfo("Balbasava", "07", 54.4207, 30.2909);
case 270: return new CityInfo("Ryasno, Рясно, Расна", "06", 53.7115, 30.6176);
case 271: return new CityInfo("Novosëlki", "06", 53.813, 30.3769);
case 272: return new CityInfo("Ramanavichy", "06", 53.8653, 30.5597);
case 273: return new CityInfo("Palykavichy Pyershyya", "06", 53.9854, 30.36);
case 274: return new CityInfo("Horad Kobryn", "01", 52.21611, 24.36639);
case 275: return new CityInfo("Horad Luninyets", "01", 52.25028, 26.79944);
case 276: return new CityInfo("Horad Pinsk", "01", 52.12139, 26.07278);
case 277: return new CityInfo("Horad Orsha", "07", 54.51528, 30.40528);
case 278: return new CityInfo("Horad Rechytsa", "02", 52.36389, 30.39472);
case 279: return new CityInfo("Horad Krychaw", "06", 53.69889, 31.71417);
case 280: return new CityInfo("Fanipol", "05", 53.74998, 27.33338);
case 281: return new CityInfo("Natal’yewsk", "05", 53.7275, 28.4325);
case 282: return new CityInfo("Gorodishche", "05", 53.9833, 27.8384);
case 283: return new CityInfo("Yukhnovka", "05", 53.9753, 27.8586);
case 284: return new CityInfo("Khatsyezhyna", "05", 53.9094, 27.3069);
case 285: return new CityInfo("Schomyslitsa", "05", 53.8211, 27.4522);
case 286: return new CityInfo("Yubilyeyny", "05", 53.8191, 27.5215);
case 287: return new CityInfo("Charkasy", "05", 53.7662, 27.3347);
case 288: return new CityInfo("Atolina", "05", 53.7817, 27.4346);
case 289: return new CityInfo("Pryvol’ny", "05", 53.7969, 27.7967);
case 290: return new CityInfo("Enyerhyetykaw", "05", 53.5871, 27.0535);
case 291: return new CityInfo("Svislach", "05", 53.6404, 27.9199);
case 292: return new CityInfo("Druzhny", "05", 53.6238, 27.8977);
case 293: return new CityInfo("Vishnyavyets", "05", 53.3474, 26.6895);
case 294: return new CityInfo("Peramoga", "02", 52.3973, 31.071);
case 295: return new CityInfo("Borovlyany", "05", 54.0022, 27.6754);
case 296: return new CityInfo("Chyst’", "05", 54.2698, 27.1067);
case 297: return new CityInfo("Lyeskawka", "05", 54.0024, 27.7108);
case 298: return new CityInfo("Lyasny", "05", 54.0072, 27.6963);
case 299: return new CityInfo("Bal’shavik", "05", 54.0036, 27.5669);
case 300: return new CityInfo("Usiazh", "05", 54.07598, 28.00698);
case 301: return new CityInfo("Николаевка-2", "06", 53.95295, 30.38278);
case 302: return new CityInfo("Октябрьский", "05", 54.04059, 28.19813);
case 303: return new CityInfo("Michanovichi", "05", 53.73937, 27.69276);
default: return new CityInfo("Posëlok Voskhod", "06", 53.7766, 30.3497);

                                    }                                        
                                }
                            
                        }
                    }
                