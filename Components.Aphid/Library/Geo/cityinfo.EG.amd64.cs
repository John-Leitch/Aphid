
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
                                    public const string Country = "EG";
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
                            
                                        var cur = (Math.Abs(30.7142 - lat) + Math.Abs(31.24425 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(30.35487 - lat) + Math.Abs(31.20105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.78847 - lat) + Math.Abs(31.00192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.47639 - lat) + Math.Abs(30.96119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.0539 - lat) + Math.Abs(31.37787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.6798 - lat) + Math.Abs(30.94364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.76866 - lat) + Math.Abs(31.50198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.49199 - lat) + Math.Abs(34.89572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.91667 - lat) + Math.Abs(30.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.55695 - lat) + Math.Abs(31.69478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.2032 - lat) + Math.Abs(25.51965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.27133 - lat) + Math.Abs(30.78617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.19688 - lat) + Math.Abs(31.5243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.31269 - lat) + Math.Abs(31.32018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.55258 - lat) + Math.Abs(31.00904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.91582 - lat) + Math.Abs(34.32995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.9616 - lat) + Math.Abs(31.24069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.31214 - lat) + Math.Abs(30.71007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.39951 - lat) + Math.Abs(30.41718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.35831 - lat) + Math.Abs(33.07829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.28204 - lat) + Math.Abs(34.23869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.56482 - lat) + Math.Abs(31.15777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.97225 - lat) + Math.Abs(30.95614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.91544 - lat) + Math.Abs(32.76287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.16418 - lat) + Math.Abs(32.72671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.0568 - lat) + Math.Abs(27.96979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.17922 - lat) + Math.Abs(31.2056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.04681 - lat) + Math.Abs(34.6634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.04949 - lat) + Math.Abs(32.24142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.12624 - lat) + Math.Abs(31.64313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.46597 - lat) + Math.Abs(30.93199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.41899 - lat) + Math.Abs(30.77924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.36056 - lat) + Math.Abs(31.3776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.3529 - lat) + Math.Abs(27.23725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.06305 - lat) + Math.Abs(34.89005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.3126 - lat) + Math.Abs(30.96987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.73264 - lat) + Math.Abs(30.84129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.81667 - lat) + Math.Abs(31.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.2163 - lat) + Math.Abs(34.11074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.47669 - lat) + Math.Abs(32.94626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.76128 - lat) + Math.Abs(30.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.79336 - lat) + Math.Abs(31.62575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.8248 - lat) + Math.Abs(30.81805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.11174 - lat) + Math.Abs(30.93991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13379 - lat) + Math.Abs(30.12969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.67319 - lat) + Math.Abs(31.4976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.33826 - lat) + Math.Abs(31.89161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5084 - lat) + Math.Abs(31.84106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.2376 - lat) + Math.Abs(30.78944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.29336 - lat) + Math.Abs(32.55402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.3073 - lat) + Math.Abs(30.2981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.97916 - lat) + Math.Abs(32.87722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.35896 - lat) + Math.Abs(30.68061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.84144 - lat) + Math.Abs(31.30084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.6713 - lat) + Math.Abs(31.58801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.9128 - lat) + Math.Abs(30.29019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20365 - lat) + Math.Abs(30.54908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.05494 - lat) + Math.Abs(32.16329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.32977 - lat) + Math.Abs(31.71507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.72816 - lat) + Math.Abs(31.79697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.41648 - lat) + Math.Abs(31.81332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.75438 - lat) + Math.Abs(31.44016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13259 - lat) + Math.Abs(30.64784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.12467 - lat) + Math.Abs(32.47598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.08898 - lat) + Math.Abs(31.59478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.48208 - lat) + Math.Abs(34.49505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.55642 - lat) + Math.Abs(30.81057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.64148 - lat) + Math.Abs(30.85012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.03408 - lat) + Math.Abs(30.46823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.14816 - lat) + Math.Abs(31.12733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.26531 - lat) + Math.Abs(32.3019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.74906 - lat) + Math.Abs(33.93891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.21452 - lat) + Math.Abs(31.35798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.42039 - lat) + Math.Abs(31.56223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.93976 - lat) + Math.Abs(30.81338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.07441 - lat) + Math.Abs(31.09785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.5036 - lat) + Math.Abs(30.8004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.45977 - lat) + Math.Abs(31.1842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.58768 - lat) + Math.Abs(31.502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.12303 - lat) + Math.Abs(31.13571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.24168 - lat) + Math.Abs(33.6222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.54323 - lat) + Math.Abs(31.78504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.18096 - lat) + Math.Abs(31.18368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.09082 - lat) + Math.Abs(32.89942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.97371 - lat) + Math.Abs(32.52627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.56472 - lat) + Math.Abs(31.28111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.59683 - lat) + Math.Abs(30.89931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.29735 - lat) + Math.Abs(30.97641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.33778 - lat) + Math.Abs(31.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.69893 - lat) + Math.Abs(32.6421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.44023 - lat) + Math.Abs(30.81712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.10611 - lat) + Math.Abs(34.27716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.61618 - lat) + Math.Abs(31.73514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.61927 - lat) + Math.Abs(31.46165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.19327 - lat) + Math.Abs(31.13703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.06263 - lat) + Math.Abs(31.24967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.10988 - lat) + Math.Abs(30.7503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.18287 - lat) + Math.Abs(32.03108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.15823 - lat) + Math.Abs(31.936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.03637 - lat) + Math.Abs(31.38069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.47686 - lat) + Math.Abs(31.8035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.97063 - lat) + Math.Abs(31.1669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.45141 - lat) + Math.Abs(30.54635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.21035 - lat) + Math.Abs(31.36812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.00944 - lat) + Math.Abs(31.20861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.18065 - lat) + Math.Abs(31.86497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.60427 - lat) + Math.Abs(32.27225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20176 - lat) + Math.Abs(29.91582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.71877 - lat) + Math.Abs(31.56299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.9 - lat) + Math.Abs(31.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.31146 - lat) + Math.Abs(31.14766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.25738 - lat) + Math.Abs(33.81291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.30995 - lat) + Math.Abs(30.8418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.82431 - lat) + Math.Abs(30.89948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.34919 - lat) + Math.Abs(28.86591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.23568 - lat) + Math.Abs(32.00347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.43046 - lat) + Math.Abs(31.03679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.99257 - lat) + Math.Abs(31.41554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.61972 - lat) + Math.Abs(31.2575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13159 - lat) + Math.Abs(33.79844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.83007 - lat) + Math.Abs(28.95502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.5622 - lat) + Math.Abs(31.74566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.94162 - lat) + Math.Abs(31.29039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.82796 - lat) + Math.Abs(30.53552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.04514 - lat) + Math.Abs(31.31845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.3457 - lat) + Math.Abs(31.61624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.93043 - lat) + Math.Abs(30.83826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.72508 - lat) + Math.Abs(31.67148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.91018 - lat) + Math.Abs(30.17438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.26881 - lat) + Math.Abs(31.15232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.01887 - lat) + Math.Abs(33.0098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20864 - lat) + Math.Abs(31.63528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.39417 - lat) + Math.Abs(33.67825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.99123 - lat) + Math.Abs(33.89952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.60018 - lat) + Math.Abs(32.31671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.03 - lat) + Math.Abs(31.47 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.51478 - lat) + Math.Abs(30.34355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.56191 - lat) + Math.Abs(33.94934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.15791 - lat) + Math.Abs(30.70177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zefta", "05", 30.7142, 31.24425);
case 1: return new CityInfo("Toukh", "12", 30.35487, 31.20105);
case 2: return new CityInfo("Tanda", "05", 30.78847, 31.00192);
case 3: return new CityInfo("Ţāmiyah", "04", 29.47639, 30.96119);
case 4: return new CityInfo("Ţalkhā", "01", 31.0539, 31.37787);
case 5: return new CityInfo("Talā", "09", 30.6798, 30.94364);
case 6: return new CityInfo("Ţahţā", "24", 26.76866, 31.50198);
case 7: return new CityInfo("Taba", "26", 29.49199, 34.89572);
case 8: return new CityInfo("Sumusţā as Sulţānī", "18", 28.91667, 30.85);
case 9: return new CityInfo("Sohag", "24", 26.55695, 31.69478);
case 10: return new CityInfo("Siwa Oasis", "22", 29.2032, 25.51965);
case 11: return new CityInfo("Sīdī Sālim", "21", 31.27133, 30.78617);
case 12: return new CityInfo("Shirbīn", "01", 31.19688, 31.5243);
case 13: return new CityInfo("Shibīn al Qanāṭir", "12", 30.31269, 31.32018);
case 14: return new CityInfo("Shibīn al Kawm", "09", 30.55258, 31.00904);
case 15: return new CityInfo("Sharm el-Sheikh", "26", 27.91582, 34.32995);
case 16: return new CityInfo("Samannūd", "05", 30.9616, 31.24069);
case 17: return new CityInfo("Samālūţ", "10", 28.31214, 30.71007);
case 18: return new CityInfo("Rosetta", "03", 31.39951, 30.41718);
case 19: return new CityInfo("Ras Gharib", "02", 28.35831, 33.07829);
case 20: return new CityInfo("Rafaḩ", "27", 31.28204, 34.23869);
case 21: return new CityInfo("Quwaysinā", "09", 30.56482, 31.15777);
case 22: return new CityInfo("Quţūr", "05", 30.97225, 30.95614);
case 23: return new CityInfo("Kousa", "23", 25.91544, 32.76287);
case 24: return new CityInfo("Qinā", "23", 26.16418, 32.72671);
case 25: return new CityInfo("Qaşr al Farāfirah", "13", 27.0568, 27.96979);
case 26: return new CityInfo("Qalyūb", "12", 30.17922, 31.2056);
case 27: return new CityInfo("Nuwaybi‘a", "26", 29.04681, 34.6634);
case 28: return new CityInfo("Naja' Ḥammādī", "23", 26.04949, 32.24142);
case 29: return new CityInfo("Minyat an Naşr", "01", 31.12624, 31.64313);
case 30: return new CityInfo("Munūf", "09", 30.46597, 30.93199);
case 31: return new CityInfo("Maţāy", "10", 28.41899, 30.77924);
case 32: return new CityInfo("Mashtūl as Sūq", "14", 30.36056, 31.3776);
case 33: return new CityInfo("Mersa Matruh", "22", 31.3529, 27.23725);
case 34: return new CityInfo("Marsa Alam", "02", 25.06305, 34.89005);
case 35: return new CityInfo("Manfalūţ", "17", 27.3126, 30.96987);
case 36: return new CityInfo("Mallawī", "10", 27.73264, 30.84129);
case 37: return new CityInfo("Madīnat Sittah Uktūbar", "08", 29.81667, 31.05);
case 38: return new CityInfo("Ash Shaykh Zuwayd", "27", 31.2163, 34.11074);
case 39: return new CityInfo("Kawm Umbū", "16", 24.47669, 32.94626);
case 40: return new CityInfo("Kawm Ḩamādah", "03", 30.76128, 30.69972);
case 41: return new CityInfo("Kafr Şaqr", "14", 30.79336, 31.62575);
case 42: return new CityInfo("Kafr az Zayyāt", "05", 30.8248, 30.81805);
case 43: return new CityInfo("Kafr ash Shaykh", "21", 31.11174, 30.93991);
case 44: return new CityInfo("Kafr ad Dawwār", "03", 31.13379, 30.12969);
case 45: return new CityInfo("Juhaynah", "24", 26.67319, 31.4976);
case 46: return new CityInfo("Jirjā", "24", 26.33826, 31.89161);
case 47: return new CityInfo("‘Izbat al Burj", "01", 31.5084, 31.84106);
case 48: return new CityInfo("Iţsā", "04", 29.2376, 30.78944);
case 49: return new CityInfo("Isnā", "23", 25.29336, 32.55402);
case 50: return new CityInfo("Idkū", "03", 31.3073, 30.2981);
case 51: return new CityInfo("Idfū", "16", 24.97916, 32.87722);
case 52: return new CityInfo("Ibshawāy", "04", 29.35896, 30.68061);
case 53: return new CityInfo("Ḩalwān", "11", 29.84144, 31.30084);
case 54: return new CityInfo("Hihyā", "14", 30.6713, 31.58801);
case 55: return new CityInfo("Ḩawsh ‘Īsá", "03", 30.9128, 30.29019);
case 56: return new CityInfo("Fuwwah", "21", 31.20365, 30.54908);
case 57: return new CityInfo("Farshūţ", "23", 26.05494, 32.16329);
case 58: return new CityInfo("Fāraskūr", "20", 31.32977, 31.71507);
case 59: return new CityInfo("Fāqūs", "14", 30.72816, 31.79697);
case 60: return new CityInfo("Damietta", "20", 31.41648, 31.81332);
case 61: return new CityInfo("Diyarb Najm", "14", 30.75438, 31.44016);
case 62: return new CityInfo("Disūq", "21", 31.13259, 30.64784);
case 63: return new CityInfo("Dishnā", "23", 26.12467, 32.47598);
case 64: return new CityInfo("Dikirnis", "01", 31.08898, 31.59478);
case 65: return new CityInfo("Dahab", "26", 28.48208, 34.49505);
case 66: return new CityInfo("Dayrūţ", "17", 27.55642, 30.81057);
case 67: return new CityInfo("Dayr Mawās", "10", 27.64148, 30.85012);
case 68: return new CityInfo("Damanhūr", "03", 31.03408, 30.46823);
case 69: return new CityInfo("Būsh", "18", 29.14816, 31.12733);
case 70: return new CityInfo("Port Said", "19", 31.26531, 32.3019);
case 71: return new CityInfo("Safaga", "02", 26.74906, 33.93891);
case 72: return new CityInfo("Bilqās", "01", 31.21452, 31.35798);
case 73: return new CityInfo("Bilbays", "14", 30.42039, 31.56223);
case 74: return new CityInfo("Basyūn", "05", 30.93976, 30.81338);
case 75: return new CityInfo("Banī Suwayf", "18", 29.07441, 31.09785);
case 76: return new CityInfo("Banī Mazār", "10", 28.5036, 30.8004);
case 77: return new CityInfo("Banhā", "12", 30.45977, 31.1842);
case 78: return new CityInfo("Zagazig", "14", 30.58768, 31.502);
case 79: return new CityInfo("Awsīm", "08", 30.12303, 31.13571);
case 80: return new CityInfo("El-Tor", "26", 28.24168, 33.6222);
case 81: return new CityInfo("At Tall al Kabīr", "14", 30.54323, 31.78504);
case 82: return new CityInfo("Asyūţ", "17", 27.18096, 31.18368);
case 83: return new CityInfo("Aswan", "16", 24.09082, 32.89942);
case 84: return new CityInfo("Suez", "15", 29.97371, 32.52627);
case 85: return new CityInfo("Aş Şaff", "08", 29.56472, 31.28111);
case 86: return new CityInfo("Ash Shuhadā’", "09", 30.59683, 30.89931);
case 87: return new CityInfo("Ashmūn", "09", 30.29735, 30.97641);
case 88: return new CityInfo("Al Wāsiţah", "04", 29.33778, 31.20556);
case 89: return new CityInfo("Luxor", "28", 25.69893, 32.6421);
case 90: return new CityInfo("Al Qūşīyah", "17", 27.44023, 30.81712);
case 91: return new CityInfo("Al Quşayr", "02", 26.10611, 34.27716);
case 92: return new CityInfo("Al Qurayn", "14", 30.61618, 31.73514);
case 93: return new CityInfo("Al Qanāyāt", "14", 30.61927, 31.46165);
case 94: return new CityInfo("Al Qanāţir al Khayrīyah", "12", 30.19327, 31.13703);
case 95: return new CityInfo("Cairo", "11", 30.06263, 31.24967);
case 96: return new CityInfo("Al Minyā", "10", 28.10988, 30.7503);
case 97: return new CityInfo("Al Maţarīyah", "01", 31.18287, 32.03108);
case 98: return new CityInfo("Al Manzalah", "01", 31.15823, 31.936);
case 99: return new CityInfo("Al Manşūrah", "01", 31.03637, 31.38069);
case 100: return new CityInfo("Al Manshāh", "24", 26.47686, 31.8035);
case 101: return new CityInfo("Al Maḩallah al Kubrá", "05", 30.97063, 31.1669);
case 102: return new CityInfo("Al Khārijah", "13", 25.45141, 30.54635);
case 103: return new CityInfo("Al Khānkah", "12", 30.21035, 31.36812);
case 104: return new CityInfo("Giza", "08", 30.00944, 31.20861);
case 105: return new CityInfo("Al Jammālīyah", "01", 31.18065, 31.86497);
case 106: return new CityInfo("Ismailia", "07", 30.60427, 32.27225);
case 107: return new CityInfo("Alexandria", "06", 31.20176, 29.91582);
case 108: return new CityInfo("Al Ibrāhīmīyah", "14", 30.71877, 31.56299);
case 109: return new CityInfo("Al Ḩawāmidīyah", "08", 29.9, 31.25);
case 110: return new CityInfo("Al Ḩāmūl", "21", 31.31146, 31.14766);
case 111: return new CityInfo("Hurghada", "02", 27.25738, 33.81291);
case 112: return new CityInfo("Al Fayyūm", "04", 29.30995, 30.8418);
case 113: return new CityInfo("Al Fashn", "18", 28.82431, 30.89948);
case 114: return new CityInfo("Al Bawīţī", "08", 28.34919, 28.86591);
case 115: return new CityInfo("Al Balyanā", "24", 26.23568, 32.00347);
case 116: return new CityInfo("Al Bājūr", "09", 30.43046, 31.03679);
case 117: return new CityInfo("Al Badārī", "17", 26.99257, 31.41554);
case 118: return new CityInfo("Al ‘Ayyāţ", "08", 29.61972, 31.2575);
case 119: return new CityInfo("Arish", "27", 31.13159, 33.79844);
case 120: return new CityInfo("Al ‘Alamayn", "22", 30.83007, 28.95502);
case 121: return new CityInfo("Akhmīm", "24", 26.5622, 31.74566);
case 122: return new CityInfo("Ajā", "01", 30.94162, 31.29039);
case 123: return new CityInfo("Ad Dilinjāt", "03", 30.82796, 30.53552);
case 124: return new CityInfo("Abū Tīj", "17", 27.04514, 31.31845);
case 125: return new CityInfo("Abu Simbel", "16", 22.3457, 31.61624);
case 126: return new CityInfo("Abū Qurqāş", "10", 27.93043, 30.83826);
case 127: return new CityInfo("Abū Kabīr", "14", 30.72508, 31.67148);
case 128: return new CityInfo("Abū al Maţāmīr", "03", 30.91018, 30.17438);
case 129: return new CityInfo("Abnūb", "17", 27.26881, 31.15232);
case 130: return new CityInfo("Bi’r al ‘Abd", "27", 31.01887, 33.0098);
case 131: return new CityInfo("Az Zarqā", "20", 31.20864, 31.63528);
case 132: return new CityInfo("El Gouna", "02", 27.39417, 33.67825);
case 133: return new CityInfo("Makadi Bay", "02", 26.99123, 33.89952);
case 134: return new CityInfo("Ain Sukhna", "15", 29.60018, 32.31671);
case 135: return new CityInfo("New Cairo", "11", 30.03, 31.47);
case 136: return new CityInfo("Beheira", "03", 30.51478, 30.34355);
case 137: return new CityInfo("Saint Catherine", "26", 28.56191, 33.94934);
default: return new CityInfo("Munshāt ‘Alī Āghā", "21", 31.15791, 30.70177);

                                    }                                        
                                }
                            
                        }
                    }
                