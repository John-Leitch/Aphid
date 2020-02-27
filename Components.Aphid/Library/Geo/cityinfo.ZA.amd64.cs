
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
                                    public const string Country = "ZA";
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
                            
                                        var cur = (Math.Abs(-26.1625 - lat) + Math.Abs(27.8725 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-33.4956 - lat) + Math.Abs(21.44373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.53695 - lat) + Math.Abs(26.07512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.30225 - lat) + Math.Abs(27.08395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.1974 - lat) + Math.Abs(25.98311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.33177 - lat) + Math.Abs(31.01166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.87133 - lat) + Math.Abs(29.23323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.51805 - lat) + Math.Abs(27.00933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.29265 - lat) + Math.Abs(23.48954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.34048 - lat) + Math.Abs(20.91544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.17588 - lat) + Math.Abs(26.82437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.31905 - lat) + Math.Abs(27.6486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.8549 - lat) + Math.Abs(26.36583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.97742 - lat) + Math.Abs(26.73506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.43184 - lat) + Math.Abs(30.57567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.11396 - lat) + Math.Abs(24.84753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.88333 - lat) + Math.Abs(28.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.66739 - lat) + Math.Abs(20.23086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.76952 - lat) + Math.Abs(30.79165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.95659 - lat) + Math.Abs(24.7284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.00805 - lat) + Math.Abs(27.3646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.42573 - lat) + Math.Abs(29.16585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.36541 - lat) + Math.Abs(29.88175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.10391 - lat) + Math.Abs(26.86593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.03026 - lat) + Math.Abs(28.60061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.20841 - lat) + Math.Abs(26.94855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.40364 - lat) + Math.Abs(23.11461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.67313 - lat) + Math.Abs(27.92615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.31401 - lat) + Math.Abs(26.82223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.08561 - lat) + Math.Abs(27.13814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.35101 - lat) + Math.Abs(21.82498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.71171 - lat) + Math.Abs(27.83795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.65862 - lat) + Math.Abs(30.32166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.44776 - lat) + Math.Abs(21.25612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.58893 - lat) + Math.Abs(28.78443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.20674 - lat) + Math.Abs(30.79776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.33523 - lat) + Math.Abs(31.41617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.75757 - lat) + Math.Abs(25.3971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.83322 - lat) + Math.Abs(30.16351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.74649 - lat) + Math.Abs(30.45126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.03363 - lat) + Math.Abs(25.78041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.72459 - lat) + Math.Abs(31.19939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.94564 - lat) + Math.Abs(30.48497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.41098 - lat) + Math.Abs(26.70107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.59165 - lat) + Math.Abs(27.41155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.20932 - lat) + Math.Abs(26.83898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.99636 - lat) + Math.Abs(28.2268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.53113 - lat) + Math.Abs(24.78659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.00893 - lat) + Math.Abs(26.25935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.02262 - lat) + Math.Abs(20.44171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.13371 - lat) + Math.Abs(31.39752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.57076 - lat) + Math.Abs(27.42396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.84493 - lat) + Math.Abs(26.76829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.32816 - lat) + Math.Abs(31.28954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.93366 - lat) + Math.Abs(29.24152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.25 - lat) + Math.Abs(28.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.26781 - lat) + Math.Abs(27.85849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.72173 - lat) + Math.Abs(25.58804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.11319 - lat) + Math.Abs(29.04454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.31971 - lat) + Math.Abs(27.62082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.55 - lat) + Math.Abs(29.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.28666 - lat) + Math.Abs(30.75316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.18871 - lat) + Math.Abs(25.32931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.81358 - lat) + Math.Abs(27.81695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.37622 - lat) + Math.Abs(32.41181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.66756 - lat) + Math.Abs(27.24208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.09345 - lat) + Math.Abs(21.25725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.03801 - lat) + Math.Abs(24.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.87196 - lat) + Math.Abs(30.27235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.78301 - lat) + Math.Abs(32.03768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.80138 - lat) + Math.Abs(28.42726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.1844 - lat) + Math.Abs(27.70203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.0941 - lat) + Math.Abs(28.00123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.16304 - lat) + Math.Abs(28.87056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.89756 - lat) + Math.Abs(26.87533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.87101 - lat) + Math.Abs(26.97862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.22476 - lat) + Math.Abs(22.02673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.66803 - lat) + Math.Abs(22.74251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.74486 - lat) + Math.Abs(28.18783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.19436 - lat) + Math.Abs(29.00974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.71667 - lat) + Math.Abs(27.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.33392 - lat) + Math.Abs(23.06541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.74137 - lat) + Math.Abs(30.45499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.62291 - lat) + Math.Abs(29.54477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.96109 - lat) + Math.Abs(25.61494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.58601 - lat) + Math.Abs(26.88329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.37808 - lat) + Math.Abs(31.61904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.05274 - lat) + Math.Abs(23.3716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.00706 - lat) + Math.Abs(30.81323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.90449 - lat) + Math.Abs(29.46885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.61679 - lat) + Math.Abs(30.39278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.52423 - lat) + Math.Abs(28.81582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.94299 - lat) + Math.Abs(31.14107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.08113 - lat) + Math.Abs(24.6593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.20059 - lat) + Math.Abs(27.11385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.42426 - lat) + Math.Abs(30.81689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.9033 - lat) + Math.Abs(27.45727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.78324 - lat) + Math.Abs(24.68768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.60047 - lat) + Math.Abs(22.19955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.98023 - lat) + Math.Abs(26.67272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.81381 - lat) + Math.Abs(24.41205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48333 - lat) + Math.Abs(27.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.7 - lat) + Math.Abs(28.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.18736 - lat) + Math.Abs(24.94991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.90968 - lat) + Math.Abs(31.64817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.88782 - lat) + Math.Abs(30.28708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.6207 - lat) + Math.Abs(31.09067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.43138 - lat) + Math.Abs(28.47713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.75796 - lat) + Math.Abs(29.9318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.47448 - lat) + Math.Abs(30.97033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.51686 - lat) + Math.Abs(30.92687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.46972 - lat) + Math.Abs(30.87533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.03673 - lat) + Math.Abs(27.83798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.41789 - lat) + Math.Abs(32.18483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.81292 - lat) + Math.Abs(30.63646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.56822 - lat) + Math.Abs(30.18618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.90173 - lat) + Math.Abs(28.99238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.80821 - lat) + Math.Abs(29.36644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.18307 - lat) + Math.Abs(22.14605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.20824 - lat) + Math.Abs(29.9946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.78664 - lat) + Math.Abs(20.12106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.98299 - lat) + Math.Abs(30.71769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.39675 - lat) + Math.Abs(26.36246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.27748 - lat) + Math.Abs(27.21605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.08909 - lat) + Math.Abs(28.16534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.85 - lat) + Math.Abs(25.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.61641 - lat) + Math.Abs(32.03861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.49285 - lat) + Math.Abs(25.00633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.77507 - lat) + Math.Abs(29.46482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.55987 - lat) + Math.Abs(28.0195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.58664 - lat) + Math.Abs(31.39783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.34357 - lat) + Math.Abs(28.81161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.66449 - lat) + Math.Abs(27.43048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.8636 - lat) + Math.Abs(30.37052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.96627 - lat) + Math.Abs(29.29068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.9 - lat) + Math.Abs(29.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.24373 - lat) + Math.Abs(28.1262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.44152 - lat) + Math.Abs(27.28165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.86522 - lat) + Math.Abs(25.64421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.07104 - lat) + Math.Abs(28.35183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.49768 - lat) + Math.Abs(28.10065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.09598 - lat) + Math.Abs(30.44393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.04385 - lat) + Math.Abs(29.90319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.8791 - lat) + Math.Abs(27.91348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.152 - lat) + Math.Abs(26.15968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.54331 - lat) + Math.Abs(29.0164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.2 - lat) + Math.Abs(29.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.19495 - lat) + Math.Abs(20.85872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.55874 - lat) + Math.Abs(29.77896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.71084 - lat) + Math.Abs(27.21613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.70312 - lat) + Math.Abs(27.2329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.19448 - lat) + Math.Abs(27.45739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.49331 - lat) + Math.Abs(21.26755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.59827 - lat) + Math.Abs(32.0894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.83333 - lat) + Math.Abs(26.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.4524 - lat) + Math.Abs(23.43246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.00333 - lat) + Math.Abs(24.73142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.08577 - lat) + Math.Abs(27.77515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.65036 - lat) + Math.Abs(27.23488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.27391 - lat) + Math.Abs(29.2253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.86301 - lat) + Math.Abs(26.89756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.24179 - lat) + Math.Abs(27.57422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.57704 - lat) + Math.Abs(27.892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.43321 - lat) + Math.Abs(31.95478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.54723 - lat) + Math.Abs(29.42412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.40661 - lat) + Math.Abs(25.00309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.03627 - lat) + Math.Abs(23.04713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.85213 - lat) + Math.Abs(26.66672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.39829 - lat) + Math.Abs(25.44279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.73226 - lat) + Math.Abs(24.76232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.34574 - lat) + Math.Abs(21.15786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.69569 - lat) + Math.Abs(23.04929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.9528 - lat) + Math.Abs(24.29053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.77341 - lat) + Math.Abs(20.6147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.4296 - lat) + Math.Abs(32.06658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.20227 - lat) + Math.Abs(28.04363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.94306 - lat) + Math.Abs(24.67218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.92246 - lat) + Math.Abs(24.83051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.76021 - lat) + Math.Abs(29.86993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.78409 - lat) + Math.Abs(30.12294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.15 - lat) + Math.Abs(30.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.60049 - lat) + Math.Abs(29.86561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.97676 - lat) + Math.Abs(27.04267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.47795 - lat) + Math.Abs(30.23057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.62464 - lat) + Math.Abs(24.08518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.83273 - lat) + Math.Abs(25.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.35122 - lat) + Math.Abs(30.95332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.01895 - lat) + Math.Abs(32.26762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.14519 - lat) + Math.Abs(31.87719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.74675 - lat) + Math.Abs(29.51361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.97654 - lat) + Math.Abs(27.02423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.15881 - lat) + Math.Abs(29.71528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.28115 - lat) + Math.Abs(27.9709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.50476 - lat) + Math.Abs(28.35921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.74964 - lat) + Math.Abs(24.79712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.27276 - lat) + Math.Abs(29.12946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.57643 - lat) + Math.Abs(29.88401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.89531 - lat) + Math.Abs(21.98378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.16843 - lat) + Math.Abs(29.39412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.06415 - lat) + Math.Abs(30.59279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.30422 - lat) + Math.Abs(26.53276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.25215 - lat) + Math.Abs(24.53075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.17827 - lat) + Math.Abs(30.14702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.30246 - lat) + Math.Abs(30.71868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23481 - lat) + Math.Abs(28.17665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.963 - lat) + Math.Abs(22.46173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.61692 - lat) + Math.Abs(27.99471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.59613 - lat) + Math.Abs(24.17612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.64378 - lat) + Math.Abs(30.22324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.91566 - lat) + Math.Abs(21.51335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.27888 - lat) + Math.Abs(28.49696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.77477 - lat) + Math.Abs(26.63376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48862 - lat) + Math.Abs(27.49387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.08042 - lat) + Math.Abs(29.49522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.872 - lat) + Math.Abs(27.87506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.01269 - lat) + Math.Abs(29.86619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.87097 - lat) + Math.Abs(31.89961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.88649 - lat) + Math.Abs(31.4699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.53333 - lat) + Math.Abs(29.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.76197 - lat) + Math.Abs(31.89329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.53333 - lat) + Math.Abs(29.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.33333 - lat) + Math.Abs(27.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46752 - lat) + Math.Abs(30.15513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.14095 - lat) + Math.Abs(28.15247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.01529 - lat) + Math.Abs(27.91162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.8579 - lat) + Math.Abs(31.0292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.16678 - lat) + Math.Abs(30.23371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.69339 - lat) + Math.Abs(30.14002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.0177 - lat) + Math.Abs(30.44979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.05531 - lat) + Math.Abs(23.7743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.372 - lat) + Math.Abs(27.04878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.58274 - lat) + Math.Abs(26.66511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.49035 - lat) + Math.Abs(22.53523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.8908 - lat) + Math.Abs(28.09707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.36669 - lat) + Math.Abs(29.32371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.1466 - lat) + Math.Abs(28.68322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.68638 - lat) + Math.Abs(25.45907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.64966 - lat) + Math.Abs(24.0123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.0151 - lat) + Math.Abs(30.05658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.18873 - lat) + Math.Abs(23.53951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.67088 - lat) + Math.Abs(28.52364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.0272 - lat) + Math.Abs(29.83955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.16422 - lat) + Math.Abs(25.61918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.71999 - lat) + Math.Abs(25.09718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.00115 - lat) + Math.Abs(27.58045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.91367 - lat) + Math.Abs(27.56555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.91402 - lat) + Math.Abs(25.16111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.06927 - lat) + Math.Abs(30.11489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.96827 - lat) + Math.Abs(22.13303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.36094 - lat) + Math.Abs(27.39767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.72868 - lat) + Math.Abs(30.54256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.52755 - lat) + Math.Abs(21.6762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.52356 - lat) + Math.Abs(27.6952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.33083 - lat) + Math.Abs(28.14981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.67554 - lat) + Math.Abs(30.32877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.99766 - lat) + Math.Abs(26.32862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.28756 - lat) + Math.Abs(26.14996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.81015 - lat) + Math.Abs(28.74248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.63473 - lat) + Math.Abs(27.78022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.30176 - lat) + Math.Abs(29.98696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.53215 - lat) + Math.Abs(20.04031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.46532 - lat) + Math.Abs(20.48659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.70008 - lat) + Math.Abs(26.45968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23656 - lat) + Math.Abs(28.36938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.26737 - lat) + Math.Abs(26.72595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.3887 - lat) + Math.Abs(26.61701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.53914 - lat) + Math.Abs(25.23965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.21197 - lat) + Math.Abs(28.25958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.28609 - lat) + Math.Abs(29.13964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.64685 - lat) + Math.Abs(25.60697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.12107 - lat) + Math.Abs(26.214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.85907 - lat) + Math.Abs(29.85384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.84721 - lat) + Math.Abs(27.44218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.23078 - lat) + Math.Abs(28.30707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.45794 - lat) + Math.Abs(29.46553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.73122 - lat) + Math.Abs(29.35187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.85185 - lat) + Math.Abs(30.99337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.18848 - lat) + Math.Abs(28.32078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.68991 - lat) + Math.Abs(30.03504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.35671 - lat) + Math.Abs(22.58295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.53537 - lat) + Math.Abs(24.52151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.9683 - lat) + Math.Abs(27.59567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.78842 - lat) + Math.Abs(31.05319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.53897 - lat) + Math.Abs(31.21439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.66331 - lat) + Math.Abs(28.59016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.83136 - lat) + Math.Abs(20.05595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.41445 - lat) + Math.Abs(29.74991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.75431 - lat) + Math.Abs(26.64382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.69366 - lat) + Math.Abs(26.71141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.78749 - lat) + Math.Abs(26.8344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.26786 - lat) + Math.Abs(28.12225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.20544 - lat) + Math.Abs(21.58001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.70747 - lat) + Math.Abs(26.29564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.69619 - lat) + Math.Abs(28.74918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.98953 - lat) + Math.Abs(28.12843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.85891 - lat) + Math.Abs(28.18577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.64651 - lat) + Math.Abs(19.44852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.63981 - lat) + Math.Abs(19.0112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.66833 - lat) + Math.Abs(18.50119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.90719 - lat) + Math.Abs(17.98997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.93462 - lat) + Math.Abs(18.86676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.66434 - lat) + Math.Abs(17.8865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.01167 - lat) + Math.Abs(17.9442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.95556 - lat) + Math.Abs(18.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.80342 - lat) + Math.Abs(19.88537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.25188 - lat) + Math.Abs(16.8697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.1283 - lat) + Math.Abs(19.39492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.90323 - lat) + Math.Abs(18.75704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.73378 - lat) + Math.Abs(18.97523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.15388 - lat) + Math.Abs(18.66031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.4608 - lat) + Math.Abs(18.72714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.98735 - lat) + Math.Abs(18.49746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.84808 - lat) + Math.Abs(18.71723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.4187 - lat) + Math.Abs(19.23446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.15152 - lat) + Math.Abs(19.01509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.56223 - lat) + Math.Abs(17.98905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.03139 - lat) + Math.Abs(18.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.98056 - lat) + Math.Abs(18.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.18173 - lat) + Math.Abs(18.89217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.36889 - lat) + Math.Abs(19.31095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.92584 - lat) + Math.Abs(18.42322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.47069 - lat) + Math.Abs(19.77601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.22997 - lat) + Math.Abs(19.4265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.04746 - lat) + Math.Abs(18.4525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.56668 - lat) + Math.Abs(18.48335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.85395 - lat) + Math.Abs(18.49231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.1323 - lat) + Math.Abs(28.16859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.96333 - lat) + Math.Abs(18.47639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.97846 - lat) + Math.Abs(18.4481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.885 - lat) + Math.Abs(28.29417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.66607 - lat) + Math.Abs(27.74477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.34881 - lat) + Math.Abs(30.04074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.91849 - lat) + Math.Abs(28.19881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.14691 - lat) + Math.Abs(31.41403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.05515 - lat) + Math.Abs(18.47617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.93312 - lat) + Math.Abs(28.01213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.90539 - lat) + Math.Abs(20.7169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.12965 - lat) + Math.Abs(28.15541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.2119 - lat) + Math.Abs(27.97322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.12593 - lat) + Math.Abs(28.165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.61376 - lat) + Math.Abs(31.15281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.89511 - lat) + Math.Abs(25.13914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Roodepoort", "06", -26.1625, 27.8725);
case 1: return new CityInfo("Zoar", "11", -33.4956, 21.44373);
case 2: return new CityInfo("Zeerust", "10", -25.53695, 26.07512);
case 3: return new CityInfo("Zastron", "03", -30.30225, 27.08395);
case 4: return new CityInfo("Wolmaransstad", "10", -27.1974, 25.98311);
case 5: return new CityInfo("White River", "07", -25.33177, 31.01166);
case 6: return new CityInfo("Witbank", "07", -25.87133, 29.23323);
case 7: return new CityInfo("Winburg", "03", -28.51805, 27.00933);
case 8: return new CityInfo("Willowmore", "05", -33.29265, 23.48954);
case 9: return new CityInfo("Williston", "08", -31.34048, 20.91544);
case 10: return new CityInfo("Whittlesea", "05", -32.17588, 26.82437);
case 11: return new CityInfo("Westonaria", "06", -26.31905, 27.6486);
case 12: return new CityInfo("Wesselsbron", "03", -27.8549, 26.36583);
case 13: return new CityInfo("Welkom", "03", -27.97742, 26.73506);
case 14: return new CityInfo("Wartburg", "02", -29.43184, 30.57567);
case 15: return new CityInfo("Warrenton", "08", -28.11396, 24.84753);
case 16: return new CityInfo("Warmbaths", "09", -24.88333, 28.28333);
case 17: return new CityInfo("Arniston", "11", -34.66739, 20.23086);
case 18: return new CityInfo("Vryheid", "02", -27.76952, 30.79165);
case 19: return new CityInfo("Vryburg", "10", -26.95659, 24.7284);
case 20: return new CityInfo("Vredefort", "03", -27.00805, 27.3646);
case 21: return new CityInfo("Vrede", "03", -27.42573, 29.16585);
case 22: return new CityInfo("Volksrust", "07", -27.36541, 29.88175);
case 23: return new CityInfo("Virginia", "03", -28.10391, 26.86593);
case 24: return new CityInfo("Villiers", "03", -27.03026, 28.60061);
case 25: return new CityInfo("Viljoenskroon", "03", -27.20841, 26.94855);
case 26: return new CityInfo("Victoria West", "08", -31.40364, 23.11461);
case 27: return new CityInfo("Vereeniging", "06", -26.67313, 27.92615);
case 28: return new CityInfo("Ventersdorp", "10", -26.31401, 26.82223);
case 29: return new CityInfo("Ventersburg", "03", -28.08561, 27.13814);
case 30: return new CityInfo("Van Wyksvlei", "08", -30.35101, 21.82498);
case 31: return new CityInfo("Vanderbijlpark", "06", -26.71171, 27.83795);
case 32: return new CityInfo("Utrecht", "02", -27.65862, 30.32166);
case 33: return new CityInfo("Upington", "08", -28.44776, 21.25612);
case 34: return new CityInfo("Mthatha", "05", -31.58893, 28.78443);
case 35: return new CityInfo("eMkhomazi", "02", -30.20674, 30.79776);
case 36: return new CityInfo("Ulundi", "02", -28.33523, 31.41617);
case 37: return new CityInfo("Uitenhage", "05", -33.75757, 25.3971);
case 38: return new CityInfo("Tzaneen", "09", -23.83322, 30.16351);
case 39: return new CityInfo("Tugela Ferry", "02", -28.74649, 30.45126);
case 40: return new CityInfo("Trompsburg", "03", -30.03363, 25.78041);
case 41: return new CityInfo("Thulamahashi", "09", -24.72459, 31.19939);
case 42: return new CityInfo("Thohoyandou", "09", -22.94564, 30.48497);
case 43: return new CityInfo("Theunissen", "03", -28.41098, 26.70107);
case 44: return new CityInfo("Thabazimbi", "09", -24.59165, 27.41155);
case 45: return new CityInfo("Thaba Nchu", "03", -29.20932, 26.83898);
case 46: return new CityInfo("Tembisa", "06", -25.99636, 28.2268);
case 47: return new CityInfo("Taung", "10", -27.53113, 24.78659);
case 48: return new CityInfo("Tarkastad", "05", -32.00893, 26.25935);
case 49: return new CityInfo("Swellendam", "11", -34.02262, 20.44171);
case 50: return new CityInfo("Sundumbili", "02", -29.13371, 31.39752);
case 51: return new CityInfo("Stutterheim", "05", -32.57076, 27.42396);
case 52: return new CityInfo("Stilfontein", "10", -26.84493, 26.76829);
case 53: return new CityInfo("KwaDukuza", "02", -29.32816, 31.28954);
case 54: return new CityInfo("Standerton", "07", -26.93366, 29.24152);
case 55: return new CityInfo("Springs", "06", -26.25, 28.4);
case 56: return new CityInfo("Soweto", "06", -26.26781, 27.85849);
case 57: return new CityInfo("Somerset East", "05", -32.72173, 25.58804);
case 58: return new CityInfo("Siyabuswa", "07", -25.11319, 29.04454);
case 59: return new CityInfo("Senekal", "03", -28.31971, 27.62082);
case 60: return new CityInfo("Secunda", "07", -26.55, 29.16667);
case 61: return new CityInfo("Scottburgh", "02", -30.28666, 30.75316);
case 62: return new CityInfo("Schweizer-Reneke", "10", -27.18871, 25.32931);
case 63: return new CityInfo("Sasolburg", "03", -26.81358, 27.81695);
case 64: return new CityInfo("Saint Lucia Estuary", "02", -28.37622, 32.41181);
case 65: return new CityInfo("Rustenburg", "10", -25.66756, 27.24208);
case 66: return new CityInfo("Riversdale", "11", -34.09345, 21.25725);
case 67: return new CityInfo("Ritchie", "08", -29.03801, 24.60278);
case 68: return new CityInfo("Richmond", "02", -29.87196, 30.27235);
case 69: return new CityInfo("Richards Bay", "02", -28.78301, 32.03768);
case 70: return new CityInfo("Reitz", "03", -27.80138, 28.42726);
case 71: return new CityInfo("Randfontein", "06", -26.1844, 27.70203);
case 72: return new CityInfo("Randburg", "06", -26.0941, 28.00123);
case 73: return new CityInfo("Qumbu", "05", -31.16304, 28.87056);
case 74: return new CityInfo("Queenstown", "05", -31.89756, 26.87533);
case 75: return new CityInfo("Queensdale", "05", -31.87101, 26.97862);
case 76: return new CityInfo("Prince Albert", "11", -33.22476, 22.02673);
case 77: return new CityInfo("Prieska", "08", -29.66803, 22.74251);
case 78: return new CityInfo("Pretoria", "06", -25.74486, 28.18783);
case 79: return new CityInfo("Mokopane", "09", -24.19436, 29.00974);
case 80: return new CityInfo("Potchefstroom", "10", -26.71667, 27.1);
case 81: return new CityInfo("Postmasburg", "08", -28.33392, 23.06541);
case 82: return new CityInfo("Port Shepstone", "02", -30.74137, 30.45499);
case 83: return new CityInfo("Port Saint John’s", "05", -31.62291, 29.54477);
case 84: return new CityInfo("Port Elizabeth", "05", -33.96109, 25.61494);
case 85: return new CityInfo("Port Alfred", "05", -33.58601, 26.88329);
case 86: return new CityInfo("Pongola", "02", -27.37808, 31.61904);
case 87: return new CityInfo("Plettenberg Bay", "11", -34.05274, 23.3716);
case 88: return new CityInfo("Piet Retief", "07", -27.00706, 30.81323);
case 89: return new CityInfo("Polokwane", "09", -23.90449, 29.46885);
case 90: return new CityInfo("Pietermaritzburg", "02", -29.61679, 30.39278);
case 91: return new CityInfo("Phuthaditjhaba", "03", -28.52423, 28.81582);
case 92: return new CityInfo("Phalaborwa", "09", -23.94299, 31.14107);
case 93: return new CityInfo("Petrusville", "08", -30.08113, 24.6593);
case 94: return new CityInfo("Peddie", "05", -33.20059, 27.11385);
case 95: return new CityInfo("Paulpietersburg", "02", -27.42426, 30.81689);
case 96: return new CityInfo("Parys", "03", -26.9033, 27.45727);
case 97: return new CityInfo("Pampierstad", "08", -27.78324, 24.68768);
case 98: return new CityInfo("Oudtshoorn", "11", -33.60047, 22.19955);
case 99: return new CityInfo("Orkney", "10", -26.98023, 26.67272);
case 100: return new CityInfo("Orania", "08", -29.81381, 24.41205);
case 101: return new CityInfo("Orange Farm", "06", -26.48333, 27.86667);
case 102: return new CityInfo("Modimolle", "09", -24.7, 28.4);
case 103: return new CityInfo("Noupoort", "08", -31.18736, 24.94991);
case 104: return new CityInfo("Nongoma", "02", -27.90968, 31.64817);
case 105: return new CityInfo("Nkowakowa", "09", -23.88782, 30.28708);
case 106: return new CityInfo("Nkandla", "02", -28.6207, 31.09067);
case 107: return new CityInfo("Nigel", "06", -26.43138, 28.47713);
case 108: return new CityInfo("Newcastle", "02", -27.75796, 29.9318);
case 109: return new CityInfo("Nelspruit", "07", -25.47448, 30.97033);
case 110: return new CityInfo("Ndwedwe", "02", -29.51686, 30.92687);
case 111: return new CityInfo("Mutale", "09", -22.46972, 30.87533);
case 112: return new CityInfo("Muldersdriseloop", "06", -26.03673, 27.83798);
case 113: return new CityInfo("Mtubatuba", "02", -28.41789, 32.18483);
case 114: return new CityInfo("Mpumalanga", "02", -29.81292, 30.63646);
case 115: return new CityInfo("Mpophomeni", "02", -29.56822, 30.18618);
case 116: return new CityInfo("Mount Frere", "05", -30.90173, 28.99238);
case 117: return new CityInfo("Mount Ayliff", "05", -30.80821, 29.36644);
case 118: return new CityInfo("Mossel Bay", "11", -34.18307, 22.14605);
case 119: return new CityInfo("Mooirivier", "02", -29.20824, 29.9946);
case 120: return new CityInfo("Montagu", "11", -33.78664, 20.12106);
case 121: return new CityInfo("Mondlo", "02", -27.98299, 30.71769);
case 122: return new CityInfo("Molteno", "05", -31.39675, 26.36246);
case 123: return new CityInfo("Mogwase", "10", -25.27748, 27.21605);
case 124: return new CityInfo("Modderfontein", "06", -26.08909, 28.16534);
case 125: return new CityInfo("Mmabatho", "10", -25.85, 25.63333);
case 126: return new CityInfo("Mkuze", "02", -27.61641, 32.03861);
case 127: return new CityInfo("Middelburg", "05", -31.49285, 25.00633);
case 128: return new CityInfo("Middelburg", "07", -25.77507, 29.46482);
case 129: return new CityInfo("Meyerton", "06", -26.55987, 28.0195);
case 130: return new CityInfo("Melmoth", "02", -28.58664, 31.39783);
case 131: return new CityInfo("Matatiele", "02", -30.34357, 28.81161);
case 132: return new CityInfo("Marquard", "03", -28.66449, 27.43048);
case 133: return new CityInfo("Margate", "02", -30.8636, 30.37052);
case 134: return new CityInfo("Marble Hall", "07", -24.96627, 29.29068);
case 135: return new CityInfo("Mankoeng", "09", -23.9, 29.81667);
case 136: return new CityInfo("Makapanstad", "10", -25.24373, 28.1262);
case 137: return new CityInfo("Maile", "10", -25.44152, 27.28165);
case 138: return new CityInfo("Mahikeng", "10", -25.86522, 25.64421);
case 139: return new CityInfo("Maclear", "05", -31.07104, 28.35183);
case 140: return new CityInfo("Mabopane", "06", -25.49768, 28.10065);
case 141: return new CityInfo("Lydenburg", "07", -25.09598, 30.44393);
case 142: return new CityInfo("Louis Trichardt", "09", -23.04385, 29.90319);
case 143: return new CityInfo("Lindley", "03", -27.8791, 27.91348);
case 144: return new CityInfo("Lichtenburg", "10", -26.152, 26.15968);
case 145: return new CityInfo("Libode", "05", -31.54331, 29.0164);
case 146: return new CityInfo("Lebowakgomo", "09", -24.2, 29.5);
case 147: return new CityInfo("Laingsburg", "11", -33.19495, 20.85872);
case 148: return new CityInfo("Ladysmith", "02", -28.55874, 29.77896);
case 149: return new CityInfo("Lady Grey", "05", -30.71084, 27.21613);
case 150: return new CityInfo("Lady Frere", "05", -31.70312, 27.2329);
case 151: return new CityInfo("Ladybrand", "03", -29.19448, 27.45739);
case 152: return new CityInfo("Ladismith", "11", -33.49331, 21.26755);
case 153: return new CityInfo("KwaMbonambi", "02", -28.59827, 32.0894);
case 154: return new CityInfo("Kutloanong", "03", -27.83333, 26.75);
case 155: return new CityInfo("Kuruman", "08", -27.4524, 23.43246);
case 156: return new CityInfo("Kruisfontein", "05", -34.00333, 24.73142);
case 157: return new CityInfo("Krugersdorp", "06", -26.08577, 27.77515);
case 158: return new CityInfo("Kroonstad", "03", -27.65036, 27.23488);
case 159: return new CityInfo("Kriel", "07", -26.27391, 29.2253);
case 160: return new CityInfo("Koster", "10", -25.86301, 26.89756);
case 161: return new CityInfo("Koppies", "03", -27.24179, 27.57422);
case 162: return new CityInfo("Komga", "05", -32.57704, 27.892);
case 163: return new CityInfo("Komatipoort", "07", -25.43321, 31.95478);
case 164: return new CityInfo("Kokstad", "02", -30.54723, 29.42412);
case 165: return new CityInfo("Koffiefontein", "03", -29.40661, 25.00309);
case 166: return new CityInfo("Knysna", "11", -34.03627, 23.04713);
case 167: return new CityInfo("Klerksdorp", "10", -26.85213, 26.66672);
case 168: return new CityInfo("Kirkwood", "05", -33.39829, 25.44279);
case 169: return new CityInfo("Kimberley", "08", -28.73226, 24.76232);
case 170: return new CityInfo("Kenhardt", "08", -29.34574, 21.15786);
case 171: return new CityInfo("Kathu", "08", -27.69569, 23.04929);
case 172: return new CityInfo("Kareedouw", "05", -33.9528, 24.29053);
case 173: return new CityInfo("Kakamas", "08", -28.77341, 20.6147);
case 174: return new CityInfo("Jozini", "02", -27.4296, 32.06658);
case 175: return new CityInfo("Johannesburg", "06", -26.20227, 28.04363);
case 176: return new CityInfo("Jansenville", "05", -32.94306, 24.67218);
case 177: return new CityInfo("Jan Kempdorp", "10", -27.92246, 24.83051);
case 178: return new CityInfo("Jane Furse", "09", -24.76021, 29.86993);
case 179: return new CityInfo("Izingolweni", "02", -30.78409, 30.12294);
case 180: return new CityInfo("Ixopo", "02", -30.15, 30.08333);
case 181: return new CityInfo("Impendle", "02", -29.60049, 29.86561);
case 182: return new CityInfo("Ilinge", "05", -31.97676, 27.04267);
case 183: return new CityInfo("Howick", "02", -29.47795, 30.23057);
case 184: return new CityInfo("Hopetown", "08", -29.62464, 24.08518);
case 185: return new CityInfo("Hoopstad", "03", -27.83273, 25.90833);
case 186: return new CityInfo("Hoedspruit", "09", -24.35122, 30.95332);
case 187: return new CityInfo("Hluhluwe", "02", -28.01895, 32.26762);
case 188: return new CityInfo("Hlabisa", "02", -28.14519, 31.87719);
case 189: return new CityInfo("Himeville", "02", -29.74675, 29.51361);
case 190: return new CityInfo("Hennenman", "03", -27.97654, 27.02423);
case 191: return new CityInfo("Hendrina", "07", -26.15881, 29.71528);
case 192: return new CityInfo("Heilbron", "03", -27.28115, 27.9709);
case 193: return new CityInfo("Heidelberg", "06", -26.50476, 28.35921);
case 194: return new CityInfo("Hartswater", "08", -27.74964, 24.79712);
case 195: return new CityInfo("Harrismith", "03", -28.27276, 29.12946);
case 196: return new CityInfo("Harding", "02", -30.57643, 29.88401);
case 197: return new CityInfo("Groblershoop", "08", -28.89531, 21.98378);
case 198: return new CityInfo("Groblersdal", "07", -25.16843, 29.39412);
case 199: return new CityInfo("Greytown", "02", -29.06415, 30.59279);
case 200: return new CityInfo("Grahamstown", "05", -33.30422, 26.53276);
case 201: return new CityInfo("Graaff-Reinet", "05", -32.25215, 24.53075);
case 202: return new CityInfo("Glencoe", "02", -28.17827, 30.14702);
case 203: return new CityInfo("Giyani", "09", -23.30246, 30.71868);
case 204: return new CityInfo("Germiston", "06", -26.23481, 28.17665);
case 205: return new CityInfo("George", "11", -33.963, 22.46173);
case 206: return new CityInfo("Ga-Rankuwa", "10", -25.61692, 27.99471);
case 207: return new CityInfo("Ganyesa", "10", -26.59613, 24.17612);
case 208: return new CityInfo("Ga-Kgapane", "09", -23.64378, 30.22324);
case 209: return new CityInfo("Fraserburg", "08", -31.91566, 21.51335);
case 210: return new CityInfo("Frankfort", "03", -27.27888, 28.49696);
case 211: return new CityInfo("Fort Beaufort", "05", -32.77477, 26.63376);
case 212: return new CityInfo("Fochville", "10", -26.48862, 27.49387);
case 213: return new CityInfo("Flagstaff", "05", -31.08042, 29.49522);
case 214: return new CityInfo("Ficksburg", "03", -28.872, 27.87506);
case 215: return new CityInfo("Estcourt", "02", -29.01269, 29.86619);
case 216: return new CityInfo("eSikhaleni", "02", -28.87097, 31.89961);
case 217: return new CityInfo("Eshowe", "02", -28.88649, 31.4699);
case 218: return new CityInfo("Ermelo", "07", -26.53333, 29.98333);
case 219: return new CityInfo("Empangeni", "02", -28.76197, 31.89329);
case 220: return new CityInfo("eMbalenhle", "07", -26.53333, 29.06667);
case 221: return new CityInfo("Elliot", "05", -31.33333, 27.85);
case 222: return new CityInfo("Ekuvukeni", "02", -28.46752, 30.15513);
case 223: return new CityInfo("Edenvale", "06", -26.14095, 28.15247);
case 224: return new CityInfo("East London", "05", -33.01529, 27.91162);
case 225: return new CityInfo("Durban", "02", -29.8579, 31.0292);
case 226: return new CityInfo("Dundee", "02", -28.16678, 30.23371);
case 227: return new CityInfo("Duiwelskloof", "09", -23.69339, 30.14002);
case 228: return new CityInfo("Driefontein", "07", -27.0177, 30.44979);
case 229: return new CityInfo("Douglas", "08", -29.05531, 23.7743);
case 230: return new CityInfo("Dordrecht", "05", -31.372, 27.04878);
case 231: return new CityInfo("Dewetsdorp", "03", -29.58274, 26.66511);
case 232: return new CityInfo("De Rust", "11", -33.49035, 22.53523);
case 233: return new CityInfo("Deneysville", "03", -26.8908, 28.09707);
case 234: return new CityInfo("Dendron", "09", -23.36669, 29.32371);
case 235: return new CityInfo("Delmas", "07", -26.1466, 28.68322);
case 236: return new CityInfo("Delareyville", "10", -26.68638, 25.45907);
case 237: return new CityInfo("De Aar", "08", -30.64966, 24.0123);
case 238: return new CityInfo("Dannhauser", "02", -28.0151, 30.05658);
case 239: return new CityInfo("Daniëlskuil", "08", -28.18873, 23.53951);
case 240: return new CityInfo("Cullinan", "06", -25.67088, 28.52364);
case 241: return new CityInfo("Creighton", "02", -30.0272, 29.83955);
case 242: return new CityInfo("Cradock", "05", -32.16422, 25.61918);
case 243: return new CityInfo("Colesberg", "08", -30.71999, 25.09718);
case 244: return new CityInfo("Cofimvaba", "05", -32.00115, 27.58045);
case 245: return new CityInfo("Clocolan", "03", -28.91367, 27.56555);
case 246: return new CityInfo("Christiana", "10", -27.91402, 25.16111);
case 247: return new CityInfo("Carolina", "07", -26.06927, 30.11489);
case 248: return new CityInfo("Carnarvon", "08", -30.96827, 22.13303);
case 249: return new CityInfo("Carletonville", "06", -26.36094, 27.39767);
case 250: return new CityInfo("Camperdown", "02", -29.72868, 30.54256);
case 251: return new CityInfo("Calitzdorp", "11", -33.52755, 21.6762);
case 252: return new CityInfo("Cala", "05", -31.52356, 27.6952);
case 253: return new CityInfo("Butterworth", "05", -32.33083, 28.14981);
case 254: return new CityInfo("Burgersfort", "07", -24.67554, 30.32877);
case 255: return new CityInfo("Burgersdorp", "05", -30.99766, 26.32862);
case 256: return new CityInfo("Bultfontein", "03", -28.28756, 26.14996);
case 257: return new CityInfo("Bronkhorstspruit", "06", -25.81015, 28.74248);
case 258: return new CityInfo("Brits", "10", -25.63473, 27.78022);
case 259: return new CityInfo("Breyten", "07", -26.30176, 29.98696);
case 260: return new CityInfo("Bredasdorp", "11", -34.53215, 20.04031);
case 261: return new CityInfo("Brandvlei", "08", -30.46532, 20.48659);
case 262: return new CityInfo("Brandfort", "03", -28.70008, 26.45968);
case 263: return new CityInfo("Brakpan", "06", -26.23656, 28.36938);
case 264: return new CityInfo("Botshabelo", "03", -29.26737, 26.72595);
case 265: return new CityInfo("Bothaville", "03", -27.3887, 26.61701);
case 266: return new CityInfo("Boshof", "03", -28.53914, 25.23965);
case 267: return new CityInfo("Boksburg", "06", -26.21197, 28.25958);
case 268: return new CityInfo("Bochum", "09", -23.28609, 29.13964);
case 269: return new CityInfo("Bloemhof", "10", -27.64685, 25.60697);
case 270: return new CityInfo("Bloemfontein", "03", -29.12107, 26.214);
case 271: return new CityInfo("Bizana", "05", -30.85907, 29.85384);
case 272: return new CityInfo("Bhisho", "05", -32.84721, 27.44218);
case 273: return new CityInfo("Bethlehem", "03", -28.23078, 28.30707);
case 274: return new CityInfo("Bethal", "07", -26.45794, 29.46553);
case 275: return new CityInfo("Bergville", "02", -28.73122, 29.35187);
case 276: return new CityInfo("Berea", "02", -29.85185, 30.99337);
case 277: return new CityInfo("Benoni", "06", -26.18848, 28.32078);
case 278: return new CityInfo("Belfast", "07", -25.68991, 30.03504);
case 279: return new CityInfo("Beaufort West", "11", -32.35671, 22.58295);
case 280: return new CityInfo("Barkly West", "08", -28.53537, 24.52151);
case 281: return new CityInfo("Barkly East", "05", -30.9683, 27.59567);
case 282: return new CityInfo("Barberton", "07", -25.78842, 31.05319);
case 283: return new CityInfo("Ballito", "02", -29.53897, 31.21439);
case 284: return new CityInfo("Balfour", "07", -26.66331, 28.59016);
case 285: return new CityInfo("Ashton", "11", -33.83136, 20.05595);
case 286: return new CityInfo("Apel", "09", -24.41445, 29.74991);
case 287: return new CityInfo("Allanridge", "03", -27.75431, 26.64382);
case 288: return new CityInfo("Aliwal North", "05", -30.69366, 26.71141);
case 289: return new CityInfo("Alice", "05", -32.78749, 26.8344);
case 290: return new CityInfo("Alberton", "06", -26.26786, 28.12225);
case 291: return new CityInfo("Albertina", "11", -34.20544, 21.58001);
case 292: return new CityInfo("Adelaide", "05", -32.70747, 26.29564);
case 293: return new CityInfo("Ekangala", "06", -25.69619, 28.74918);
case 294: return new CityInfo("Midrand", "06", -25.98953, 28.12843);
case 295: return new CityInfo("Centurion", "06", -25.85891, 28.18577);
case 296: return new CityInfo("Worcester", "11", -33.64651, 19.44852);
case 297: return new CityInfo("Wellington", "11", -33.63981, 19.0112);
case 298: return new CityInfo("Vredendal", "11", -31.66833, 18.50119);
case 299: return new CityInfo("Vredenburg", "11", -32.90719, 17.98997);
case 300: return new CityInfo("Stellenbosch", "11", -33.93462, 18.86676);
case 301: return new CityInfo("Springbok", "08", -29.66434, 17.8865);
case 302: return new CityInfo("Saldanha", "11", -33.01167, 17.9442);
case 303: return new CityInfo("Rosebank", "11", -33.95556, 18.47417);
case 304: return new CityInfo("Robertson", "11", -33.80342, 19.88537);
case 305: return new CityInfo("Port Nolloth", "08", -29.25188, 16.8697);
case 306: return new CityInfo("Pofadder", "08", -29.1283, 19.39492);
case 307: return new CityInfo("Piketberg", "11", -32.90323, 18.75704);
case 308: return new CityInfo("Paarl", "11", -33.73378, 18.97523);
case 309: return new CityInfo("Moorreesburg", "11", -33.15388, 18.66031);
case 310: return new CityInfo("Malmesbury", "11", -33.4608, 18.72714);
case 311: return new CityInfo("Lansdowne", "11", -33.98735, 18.49746);
case 312: return new CityInfo("Kraaifontein", "11", -33.84808, 18.71723);
case 313: return new CityInfo("Hermanus", "11", -34.4187, 19.23446);
case 314: return new CityInfo("Grabouw", "11", -34.15152, 19.01509);
case 315: return new CityInfo("Garies", "08", -30.56223, 17.98905);
case 316: return new CityInfo("Constantia", "11", -34.03139, 18.41833);
case 317: return new CityInfo("Claremont", "11", -33.98056, 18.46528);
case 318: return new CityInfo("Clanwilliam", "11", -32.18173, 18.89217);
case 319: return new CityInfo("Ceres", "11", -33.36889, 19.31095);
case 320: return new CityInfo("Cape Town", "11", -33.92584, 18.42322);
case 321: return new CityInfo("Calvinia", "08", -31.47069, 19.77601);
case 322: return new CityInfo("Caledon", "11", -34.22997, 19.4265);
case 323: return new CityInfo("Bergvliet", "11", -34.04746, 18.4525);
case 324: return new CityInfo("Atlantis", "11", -33.56668, 18.48335);
case 325: return new CityInfo("Sunset Beach", "11", -33.85395, 18.49231);
case 326: return new CityInfo("Eden Glen", "06", -26.1323, 28.16859);
case 327: return new CityInfo("Rondebosch", "11", -33.96333, 18.47639);
case 328: return new CityInfo("Newlands", "11", -33.97846, 18.4481);
case 329: return new CityInfo("Bela-Bela", "09", -24.885, 28.29417);
case 330: return new CityInfo("Lephalale", "09", -23.66607, 27.74477);
case 331: return new CityInfo("Musina", "09", -22.34881, 30.04074);
case 332: return new CityInfo("Midstream", "06", -25.91849, 28.19881);
case 333: return new CityInfo("Mandeni", "02", -29.14691, 31.41403);
case 334: return new CityInfo("Retreat", "11", -34.05515, 18.47617);
case 335: return new CityInfo("Diepsloot", "06", -25.93312, 28.01213);
case 336: return new CityInfo("Hardys Memories of Africa", "11", -33.90539, 20.7169);
case 337: return new CityInfo("Eastleigh", "06", -26.12965, 28.15541);
case 338: return new CityInfo("Riverlea", "06", -26.2119, 27.97322);
case 339: return new CityInfo("Eden Glen Ext 60", "06", -26.12593, 28.165);
case 340: return new CityInfo("Tongaat Beach", "02", -29.61376, 31.15281);
default: return new CityInfo("Thornhill", "05", -33.89511, 25.13914);

                                    }                                        
                                }
                            
                        }
                    }
                