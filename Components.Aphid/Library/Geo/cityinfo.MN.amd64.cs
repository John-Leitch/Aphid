
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
                                    public const string Country = "MN";
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
                            
                                        var cur = (Math.Abs(46.05 - lat) + Math.Abs(92.01667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(48.9 - lat) + Math.Abs(89.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(92.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74167 - lat) + Math.Abs(96.84444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68333 - lat) + Math.Abs(92.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98111 - lat) + Math.Abs(92.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.27128 - lat) + Math.Abs(94.85836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6 - lat) + Math.Abs(93.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91667 - lat) + Math.Abs(92.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56667 - lat) + Math.Abs(95.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71667 - lat) + Math.Abs(93.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07972 - lat) + Math.Abs(98.85167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05 - lat) + Math.Abs(90.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71327 - lat) + Math.Abs(96.52588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11196 - lat) + Math.Abs(96.67145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75667 - lat) + Math.Abs(98.28389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46667 - lat) + Math.Abs(93.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41667 - lat) + Math.Abs(90.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42414 - lat) + Math.Abs(92.22439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82976 - lat) + Math.Abs(94.81544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68333 - lat) + Math.Abs(99.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75132 - lat) + Math.Abs(95.99974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35356 - lat) + Math.Abs(97.36633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33333 - lat) + Math.Abs(97.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3466 - lat) + Math.Abs(96.6457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49714 - lat) + Math.Abs(96.80311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8 - lat) + Math.Abs(98.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(95.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81667 - lat) + Math.Abs(93.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35732 - lat) + Math.Abs(94.52448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13333 - lat) + Math.Abs(97.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76667 - lat) + Math.Abs(90.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.98562 - lat) + Math.Abs(96.54339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.64278 - lat) + Math.Abs(97.61861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58722 - lat) + Math.Abs(99.35083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96833 - lat) + Math.Abs(89.9625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31667 - lat) + Math.Abs(95.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61627 - lat) + Math.Abs(90.24204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36667 - lat) + Math.Abs(92.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10641 - lat) + Math.Abs(91.71782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.4 - lat) + Math.Abs(94.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.9 - lat) + Math.Abs(99.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30677 - lat) + Math.Abs(95.44785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15 - lat) + Math.Abs(99.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9267 - lat) + Math.Abs(91.08782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70954 - lat) + Math.Abs(97.17596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77278 - lat) + Math.Abs(99.87389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(99.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.51672 - lat) + Math.Abs(94.29428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23123 - lat) + Math.Abs(98.5714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94776 - lat) + Math.Abs(89.14358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58876 - lat) + Math.Abs(95.43257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28001 - lat) + Math.Abs(90.91015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.87284 - lat) + Math.Abs(96.96259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.1 - lat) + Math.Abs(91.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03333 - lat) + Math.Abs(92.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48333 - lat) + Math.Abs(91.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.3413 - lat) + Math.Abs(91.60641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.77849 - lat) + Math.Abs(91.90424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9296 - lat) + Math.Abs(96.16239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52877 - lat) + Math.Abs(97.7409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94877 - lat) + Math.Abs(99.53665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30686 - lat) + Math.Abs(93.90409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21987 - lat) + Math.Abs(97.3744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60977 - lat) + Math.Abs(92.4024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65796 - lat) + Math.Abs(95.79323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.10719 - lat) + Math.Abs(99.67226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90713 - lat) + Math.Abs(93.78582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53333 - lat) + Math.Abs(99.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94229 - lat) + Math.Abs(99.16689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21061 - lat) + Math.Abs(99.59862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51667 - lat) + Math.Abs(91.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00556 - lat) + Math.Abs(91.64194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35639 - lat) + Math.Abs(99.34444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40946 - lat) + Math.Abs(98.28712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45 - lat) + Math.Abs(94.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.30272 - lat) + Math.Abs(89.51557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(96.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57967 - lat) + Math.Abs(89.5475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06667 - lat) + Math.Abs(91.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21211 - lat) + Math.Abs(97.60666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1664 - lat) + Math.Abs(98.69173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97838 - lat) + Math.Abs(95.92532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09237 - lat) + Math.Abs(91.54796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93678 - lat) + Math.Abs(93.61673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78333 - lat) + Math.Abs(98.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53333 - lat) + Math.Abs(93.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.95 - lat) + Math.Abs(89.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65013 - lat) + Math.Abs(95.0005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8 - lat) + Math.Abs(92.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04372 - lat) + Math.Abs(89.43798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66667 - lat) + Math.Abs(90.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71906 - lat) + Math.Abs(98.79181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55529 - lat) + Math.Abs(99.43314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61667 - lat) + Math.Abs(94.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23333 - lat) + Math.Abs(91.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55655 - lat) + Math.Abs(94.36449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80981 - lat) + Math.Abs(98.09006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43333 - lat) + Math.Abs(99.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9929 - lat) + Math.Abs(95.19962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65963 - lat) + Math.Abs(94.40414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9 - lat) + Math.Abs(97.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.1791 - lat) + Math.Abs(98.97205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70317 - lat) + Math.Abs(96.3592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37222 - lat) + Math.Abs(96.25833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11044 - lat) + Math.Abs(92.84374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30688 - lat) + Math.Abs(96.34237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(95.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64226 - lat) + Math.Abs(96.53687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16 - lat) + Math.Abs(99.87556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.08216 - lat) + Math.Abs(106.86985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.60885 - lat) + Math.Abs(101.93424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23245 - lat) + Math.Abs(101.04813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.69028 - lat) + Math.Abs(111.99463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0674 - lat) + Math.Abs(100.81724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.33333 - lat) + Math.Abs(111.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05 - lat) + Math.Abs(105.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33333 - lat) + Math.Abs(104.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94993 - lat) + Math.Abs(105.55321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9 - lat) + Math.Abs(109.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36446 - lat) + Math.Abs(113.577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.90771 - lat) + Math.Abs(106.88324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50725 - lat) + Math.Abs(100.66257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(104.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.30657 - lat) + Math.Abs(104.07417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91667 - lat) + Math.Abs(109.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.475 - lat) + Math.Abs(101.45417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47833 - lat) + Math.Abs(100.88944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(106.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96404 - lat) + Math.Abs(101.45977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50719 - lat) + Math.Abs(105.75594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79817 - lat) + Math.Abs(109.31826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(114.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.4 - lat) + Math.Abs(108.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94669 - lat) + Math.Abs(102.66123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04639 - lat) + Math.Abs(100.50917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39194 - lat) + Math.Abs(105.73517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38185 - lat) + Math.Abs(101.90815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85 - lat) + Math.Abs(104.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53257 - lat) + Math.Abs(107.04546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13333 - lat) + Math.Abs(114.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23139 - lat) + Math.Abs(106.20778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.31751 - lat) + Math.Abs(104.38196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72727 - lat) + Math.Abs(112.35563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85 - lat) + Math.Abs(103.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23733 - lat) + Math.Abs(106.43005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65 - lat) + Math.Abs(104.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04192 - lat) + Math.Abs(102.08925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56667 - lat) + Math.Abs(114.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2 - lat) + Math.Abs(111.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.71667 - lat) + Math.Abs(110.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43333 - lat) + Math.Abs(101.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61667 - lat) + Math.Abs(102.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65 - lat) + Math.Abs(103.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00793 - lat) + Math.Abs(104.94209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84199 - lat) + Math.Abs(105.13796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12667 - lat) + Math.Abs(101.42806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3 - lat) + Math.Abs(106.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81667 - lat) + Math.Abs(102.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30423 - lat) + Math.Abs(113.84977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94972 - lat) + Math.Abs(104.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73637 - lat) + Math.Abs(100.39135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.4538 - lat) + Math.Abs(105.31769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61667 - lat) + Math.Abs(110.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98259 - lat) + Math.Abs(103.78389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46667 - lat) + Math.Abs(102.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45 - lat) + Math.Abs(103.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48 - lat) + Math.Abs(113.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31944 - lat) + Math.Abs(110.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52843 - lat) + Math.Abs(101.37394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68333 - lat) + Math.Abs(109.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78336 - lat) + Math.Abs(104.48067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58333 - lat) + Math.Abs(110.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.2001 - lat) + Math.Abs(105.66582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.145 - lat) + Math.Abs(105.38833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.2436 - lat) + Math.Abs(113.37427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63417 - lat) + Math.Abs(100.1625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38254 - lat) + Math.Abs(110.31647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75 - lat) + Math.Abs(103.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75 - lat) + Math.Abs(109.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09121 - lat) + Math.Abs(103.83951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95 - lat) + Math.Abs(102.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12139 - lat) + Math.Abs(100.04306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7625 - lat) + Math.Abs(106.27083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63333 - lat) + Math.Abs(106.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63111 - lat) + Math.Abs(103.52917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37062 - lat) + Math.Abs(106.74076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.29667 - lat) + Math.Abs(103.42556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25 - lat) + Math.Abs(107.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(105.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80189 - lat) + Math.Abs(105.924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15 - lat) + Math.Abs(112.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0675 - lat) + Math.Abs(105.88056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.29591 - lat) + Math.Abs(100.25711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52056 - lat) + Math.Abs(105.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79309 - lat) + Math.Abs(101.97235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53333 - lat) + Math.Abs(100.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.46167 - lat) + Math.Abs(103.97417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2257 - lat) + Math.Abs(106.29152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2 - lat) + Math.Abs(107.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10361 - lat) + Math.Abs(105.42 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.395 - lat) + Math.Abs(102.69333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66306 - lat) + Math.Abs(102.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30241 - lat) + Math.Abs(102.44554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43333 - lat) + Math.Abs(114.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88199 - lat) + Math.Abs(101.23953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89704 - lat) + Math.Abs(102.76903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6 - lat) + Math.Abs(104.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.17361 - lat) + Math.Abs(102.13194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.60639 - lat) + Math.Abs(109.63806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66667 - lat) + Math.Abs(102.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67024 - lat) + Math.Abs(102.17491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36278 - lat) + Math.Abs(102.46794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1009 - lat) + Math.Abs(102.55686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2 - lat) + Math.Abs(100.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.4 - lat) + Math.Abs(113.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16667 - lat) + Math.Abs(101.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53333 - lat) + Math.Abs(102.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8 - lat) + Math.Abs(111.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13507 - lat) + Math.Abs(113.68378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47278 - lat) + Math.Abs(100.92778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28575 - lat) + Math.Abs(100.44834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(110.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77076 - lat) + Math.Abs(113.88248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66667 - lat) + Math.Abs(113.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(112.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54595 - lat) + Math.Abs(100.82788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24323 - lat) + Math.Abs(104.80511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8325 - lat) + Math.Abs(106.13639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(107.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61667 - lat) + Math.Abs(112.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04988 - lat) + Math.Abs(107.48955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27394 - lat) + Math.Abs(102.9812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15 - lat) + Math.Abs(109.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8807 - lat) + Math.Abs(115.72526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41845 - lat) + Math.Abs(100.82239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97238 - lat) + Math.Abs(106.11866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03333 - lat) + Math.Abs(104.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10944 - lat) + Math.Abs(101.57528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.2475 - lat) + Math.Abs(105.37361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68333 - lat) + Math.Abs(110.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70694 - lat) + Math.Abs(106.95278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85229 - lat) + Math.Abs(106.45786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95343 - lat) + Math.Abs(115.29396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38333 - lat) + Math.Abs(112.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8 - lat) + Math.Abs(107.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31556 - lat) + Math.Abs(105.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66805 - lat) + Math.Abs(102.54999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49331 - lat) + Math.Abs(100.87801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03791 - lat) + Math.Abs(105.9219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9459 - lat) + Math.Abs(111.49784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.42446 - lat) + Math.Abs(105.32078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.08578 - lat) + Math.Abs(106.18578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54571 - lat) + Math.Abs(114.40287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48667 - lat) + Math.Abs(105.92278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25463 - lat) + Math.Abs(103.88054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61667 - lat) + Math.Abs(109.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46787 - lat) + Math.Abs(103.51284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.57083 - lat) + Math.Abs(104.425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36111 - lat) + Math.Abs(108.36111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07257 - lat) + Math.Abs(114.53264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9 - lat) + Math.Abs(115.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53333 - lat) + Math.Abs(110.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88239 - lat) + Math.Abs(110.11631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(110.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.265 - lat) + Math.Abs(104.74348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49674 - lat) + Math.Abs(104.11777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54194 - lat) + Math.Abs(101.51417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8125 - lat) + Math.Abs(103.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.09745 - lat) + Math.Abs(103.54288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.77594 - lat) + Math.Abs(107.51616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31869 - lat) + Math.Abs(101.11576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85946 - lat) + Math.Abs(100.62687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2 - lat) + Math.Abs(108.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06667 - lat) + Math.Abs(103.66583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58333 - lat) + Math.Abs(106.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46667 - lat) + Math.Abs(106.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23223 - lat) + Math.Abs(108.28245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41171 - lat) + Math.Abs(100.574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41667 - lat) + Math.Abs(104.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17945 - lat) + Math.Abs(108.25996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98333 - lat) + Math.Abs(112.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52178 - lat) + Math.Abs(102.59428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73167 - lat) + Math.Abs(100.76 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91667 - lat) + Math.Abs(105.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01667 - lat) + Math.Abs(111.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78333 - lat) + Math.Abs(112.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70197 - lat) + Math.Abs(100.1433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19444 - lat) + Math.Abs(100.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72732 - lat) + Math.Abs(108.11062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(109.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86667 - lat) + Math.Abs(106.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55 - lat) + Math.Abs(111.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91667 - lat) + Math.Abs(112.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(103.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16667 - lat) + Math.Abs(110.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(110.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21552 - lat) + Math.Abs(104.77318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68056 - lat) + Math.Abs(113.27917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65595 - lat) + Math.Abs(105.75577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5 - lat) + Math.Abs(105.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61833 - lat) + Math.Abs(101.98972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17851 - lat) + Math.Abs(109.18968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63333 - lat) + Math.Abs(103.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26389 - lat) + Math.Abs(102.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79425 - lat) + Math.Abs(107.88334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46278 - lat) + Math.Abs(102.42056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76667 - lat) + Math.Abs(107.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94211 - lat) + Math.Abs(105.89584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26222 - lat) + Math.Abs(105.41194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12572 - lat) + Math.Abs(106.37426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44742 - lat) + Math.Abs(101.75503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31556 - lat) + Math.Abs(106.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7 - lat) + Math.Abs(106.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51082 - lat) + Math.Abs(96.79944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28948 - lat) + Math.Abs(103.85659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65858 - lat) + Math.Abs(118.51014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56221 - lat) + Math.Abs(108.30439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10558 - lat) + Math.Abs(108.62061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23012 - lat) + Math.Abs(105.89674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12915 - lat) + Math.Abs(104.40803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55717 - lat) + Math.Abs(106.96333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70693 - lat) + Math.Abs(106.95276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19245 - lat) + Math.Abs(102.81349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98257 - lat) + Math.Abs(89.84173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Uyenchi Somon", "12", 46.05, 92.01667);
case 1: return new CityInfo("Uujim", "03", 48.9, 89.61667);
case 2: return new CityInfo("Urdgol", "12", 47.83333, 92.65);
case 3: return new CityInfo("Uliastay", "09", 47.74167, 96.84444);
case 4: return new CityInfo("Ulaantolgoy", "12", 46.68333, 92.78333);
case 5: return new CityInfo("Ulaangom", "19", 49.98111, 92.06667);
case 6: return new CityInfo("Tsetserleg", "19", 49.27128, 94.85836);
case 7: return new CityInfo("Tsetsegnuur", "12", 46.6, 93.26667);
case 8: return new CityInfo("Tsenher", "12", 46.91667, 92.11667);
case 9: return new CityInfo("Tseel", "10", 45.56667, 95.86667);
case 10: return new CityInfo("Tsalgar", "19", 49.71667, 93.26667);
case 11: return new CityInfo("Tsahir", "01", 48.07972, 98.85167);
case 12: return new CityInfo("Tsagaantüngi", "03", 49.05, 90.45);
case 13: return new CityInfo("Tsagaan-Olom", "10", 46.71327, 96.52588);
case 14: return new CityInfo("Tsagaanchuluut", "09", 47.11196, 96.67145);
case 15: return new CityInfo("Tosontsengel", "09", 48.75667, 98.28389);
case 16: return new CityInfo("Tooromt", "19", 50.46667, 93.58333);
case 17: return new CityInfo("Tolbo", "03", 48.41667, 90.28333);
case 18: return new CityInfo("Tögrög", "12", 47.42414, 92.22439);
case 19: return new CityInfo("Tögrög", "10", 45.82976, 94.81544);
case 20: return new CityInfo("Vlaa Vula", "13", 50.68333, 99.23333);
case 21: return new CityInfo("Tegsh", "09", 48.75132, 95.99974);
case 22: return new CityInfo("Taygan", "10", 46.35356, 97.36633);
case 23: return new CityInfo("Talshand", "10", 45.33333, 97.98333);
case 24: return new CityInfo("Tahilt", "10", 45.3466, 96.6457);
case 25: return new CityInfo("Shiree", "09", 47.49714, 96.80311);
case 26: return new CityInfo("Sharga", "13", 49.8, 98.8);
case 27: return new CityInfo("Sharga", "10", 46.25, 95.26667);
case 28: return new CityInfo("Sharbulag", "19", 48.81667, 93.1);
case 29: return new CityInfo("Sayn-Ust", "10", 47.35732, 94.52448);
case 30: return new CityInfo("Sangiyn Dalay", "10", 45.13333, 97.75);
case 31: return new CityInfo("Rashaant", "03", 47.76667, 90.83333);
case 32: return new CityInfo("Oygon", "09", 48.98562, 96.54339);
case 33: return new CityInfo("Telmin Suma", "09", 48.64278, 97.61861);
case 34: return new CityInfo("Orgil", "13", 48.58722, 99.35083);
case 35: return new CityInfo("Ölgii", "03", 48.96833, 89.9625);
case 36: return new CityInfo("Nuga", "09", 48.31667, 95.11667);
case 37: return new CityInfo("Nogoonnuur", "03", 49.61627, 90.24204);
case 38: return new CityInfo("Naranbulag", "19", 49.36667, 92.56667);
case 39: return new CityInfo("Namir", "19", 49.10641, 91.71782);
case 40: return new CityInfo("Tsagaanhayrhan", "19", 49.4, 94.23333);
case 41: return new CityInfo("Mandal", "13", 49.9, 99.43333);
case 42: return new CityInfo("Jargalant", "19", 49.30677, 95.44785);
case 43: return new CityInfo("Jargalant", "02", 47.15, 99.63333);
case 44: return new CityInfo("Jargalant", "03", 46.9267, 91.08782);
case 45: return new CityInfo("Jargalant", "10", 45.70954, 97.17596);
case 46: return new CityInfo("Ider", "13", 48.77278, 99.87389);
case 47: return new CityInfo("Hunt", "01", 47.86667, 99.46667);
case 48: return new CityInfo("Hungiy", "09", 48.51672, 94.29428);
case 49: return new CityInfo("Höviyn Am", "02", 47.23123, 98.5714);
case 50: return new CityInfo("Höshööt", "03", 48.94776, 89.14358);
case 51: return new CityInfo("Holboo", "09", 48.58876, 95.43257);
case 52: return new CityInfo("Höhtolgoy", "19", 49.28001, 90.91015);
case 53: return new CityInfo("Hödrögö", "09", 48.87284, 96.96259);
case 54: return new CityInfo("Havtsal", "19", 50.1, 91.66667);
case 55: return new CityInfo("Har-Us", "19", 49.03333, 92.03333);
case 56: return new CityInfo("Har-Us", "12", 48.48333, 91.43333);
case 57: return new CityInfo("Harmod", "19", 50.3413, 91.60641);
case 58: return new CityInfo("Harhiraa", "19", 49.77849, 91.90424);
case 59: return new CityInfo("Haliun", "10", 45.9296, 96.16239);
case 60: return new CityInfo("Halban", "13", 49.52877, 97.7409);
case 61: return new CityInfo("Erdenet", "13", 48.94877, 99.53665);
case 62: return new CityInfo("Dzüyl", "10", 46.30686, 93.90409);
case 63: return new CityInfo("Dzuunmod", "09", 48.21987, 97.3744);
case 64: return new CityInfo("Dzüünhövöö", "19", 50.60977, 92.4024);
case 65: return new CityInfo("Dzür", "09", 49.65796, 95.79323);
case 66: return new CityInfo("Dzöölön", "13", 51.10719, 99.67226);
case 67: return new CityInfo("Dzel", "19", 49.90713, 93.78582);
case 68: return new CityInfo("Dzalaa", "02", 44.53333, 99.26667);
case 69: return new CityInfo("Dzag", "02", 46.94229, 99.16689);
case 70: return new CityInfo("Dzadgay", "02", 46.21061, 99.59862);
case 71: return new CityInfo("Duut", "12", 47.51667, 91.63333);
case 72: return new CityInfo("Khovd", "12", 48.00556, 91.64194);
case 73: return new CityInfo("Tsagaannuur", "13", 51.35639, 99.34444);
case 74: return new CityInfo("Delgermörön", "02", 46.40946, 98.28712);
case 75: return new CityInfo("Darvi", "10", 46.45, 94.11667);
case 76: return new CityInfo("Chihertey", "03", 48.30272, 89.51557);
case 77: return new CityInfo("Chandmanĭ", "09", 48.05, 96.25);
case 78: return new CityInfo("Buyant", "03", 48.57967, 89.5475);
case 79: return new CityInfo("Buyant", "12", 48.06667, 91.81667);
case 80: return new CityInfo("Buyant", "09", 47.21211, 97.60666);
case 81: return new CityInfo("Buyant", "02", 46.1664, 98.69173);
case 82: return new CityInfo("Buyanbat", "10", 46.97838, 95.92532);
case 83: return new CityInfo("Bürenhayrhan", "12", 46.09237, 91.54796);
case 84: return new CityInfo("Darvi", "12", 46.93678, 93.61673);
case 85: return new CityInfo("Bulgan", "02", 44.78333, 98.65);
case 86: return new CityInfo("Bugat", "19", 49.53333, 93.81667);
case 87: return new CityInfo("Buga", "03", 48.95, 89.98333);
case 88: return new CityInfo("Buga", "10", 47.65013, 95.0005);
case 89: return new CityInfo("Altay sumu", "12", 45.8, 92.28333);
case 90: return new CityInfo("Bilüü", "03", 49.04372, 89.43798);
case 91: return new CityInfo("Bayshint", "19", 49.66667, 90.28333);
case 92: return new CityInfo("Bayan-Uhaa", "09", 48.71906, 98.79181);
case 93: return new CityInfo("Bayansayr", "02", 45.55529, 99.43314);
case 94: return new CityInfo("Bayan-Ovoo", "10", 44.61667, 94.91667);
case 95: return new CityInfo("Bayanhoshuu", "12", 48.23333, 91.91667);
case 96: return new CityInfo("Bayangol", "10", 45.55655, 94.36449);
case 97: return new CityInfo("Bayanbulag", "02", 46.80981, 98.09006);
case 98: return new CityInfo("Bayan", "13", 49.43333, 99.6);
case 99: return new CityInfo("Bayan", "10", 46.9929, 95.19962);
case 100: return new CityInfo("Baruunturuun", "19", 49.65963, 94.40414);
case 101: return new CityInfo("Balgatay", "09", 46.9, 97.15);
case 102: return new CityInfo("Altraga", "13", 50.1791, 98.97205);
case 103: return new CityInfo("Altay", "09", 49.70317, 96.3592);
case 104: return new CityInfo("Altai", "10", 46.37222, 96.25833);
case 105: return new CityInfo("Altanteel", "12", 47.11044, 92.84374);
case 106: return new CityInfo("Altanbulag", "09", 49.30688, 96.34237);
case 107: return new CityInfo("Altan", "09", 48.11667, 95.71667);
case 108: return new CityInfo("Aldar", "09", 47.64226, 96.53687);
case 109: return new CityInfo("Horgo", "01", 48.16, 99.87556);
case 110: return new CityInfo("Üydzen", "14", 44.08216, 106.86985);
case 111: return new CityInfo("Uubulan", "01", 48.60885, 101.93424);
case 112: return new CityInfo("Urt", "14", 43.23245, 101.04813);
case 113: return new CityInfo("Uldz", "11", 48.69028, 111.99463);
case 114: return new CityInfo("Ulaan-Uul", "02", 46.0674, 100.81724);
case 115: return new CityInfo("Ulaan-Uul", "07", 44.33333, 111.23333);
case 116: return new CityInfo("Ulaanjirem", "08", 45.05, 105.56667);
case 117: return new CityInfo("Ulaanhudag", "18", 47.33333, 104.5);
case 118: return new CityInfo("Ulaanhad", "18", 47.94993, 105.55321);
case 119: return new CityInfo("Ulaan-Ereg", "11", 46.9, 109.75);
case 120: return new CityInfo("Ulaandel", "17", 46.36446, 113.577);
case 121: return new CityInfo("Ulan Bator", "20", 47.90771, 106.88324);
case 122: return new CityInfo("Turt", "13", 51.50725, 100.66257);
case 123: return new CityInfo("Tsul-Ulaan", "21", 47.83333, 104.5);
case 124: return new CityInfo("Tsoohor", "14", 43.30657, 104.07417);
case 125: return new CityInfo("Tsomog", "07", 45.91667, 109.06667);
case 126: return new CityInfo("Tsetserleg", "01", 47.475, 101.45417);
case 127: return new CityInfo("Tsengel", "13", 49.47833, 100.88944);
case 128: return new CityInfo("Tsant", "08", 46.18333, 106.71667);
case 129: return new CityInfo("Tsagaan-Ovoo", "15", 45.96404, 101.45977);
case 130: return new CityInfo("Tsagaan-Ovoo", "08", 45.50719, 105.75594);
case 131: return new CityInfo("Tsagaandörvölj", "07", 45.79817, 109.31826);
case 132: return new CityInfo("Tsagaanders", "06", 48.05, 114.36667);
case 133: return new CityInfo("Naran-mandokhu Somon", "07", 44.4, 108.25);
case 134: return new CityInfo("Teshig", "21", 49.94669, 102.66123);
case 135: return new CityInfo("Teel", "01", 48.04639, 100.50917);
case 136: return new CityInfo("Tavin", "08", 46.39194, 105.73517);
case 137: return new CityInfo("Tavanbulag", "01", 47.38185, 101.90815);
case 138: return new CityInfo("Dashinchilling", "21", 47.85, 104.05);
case 139: return new CityInfo("Suugaant", "08", 45.53257, 107.04546);
case 140: return new CityInfo("Sümiyn Bulag", "06", 49.13333, 114.88333);
case 141: return new CityInfo("Sühbaatar", "16", 50.23139, 106.20778);
case 142: return new CityInfo("Sört", "21", 49.31751, 104.38196);
case 143: return new CityInfo("Shireet", "17", 45.72727, 112.35563);
case 144: return new CityInfo("Shiree", "15", 45.85, 103.4);
case 145: return new CityInfo("Sharïngol", "16", 49.23733, 106.43005);
case 146: return new CityInfo("Sharhulsan", "14", 44.65, 104.05);
case 147: return new CityInfo("Sharga", "21", 49.04192, 102.08925);
case 148: return new CityInfo("Sergelen", "06", 48.56667, 114.08333);
case 149: return new CityInfo("Sergelen", "17", 46.2, 111.81667);
case 150: return new CityInfo("Senj", "07", 44.71667, 110.76667);
case 151: return new CityInfo("Selenge", "13", 49.43333, 101.46667);
case 152: return new CityInfo("Saynshand", "14", 43.61667, 102.53333);
case 153: return new CityInfo("Sangiyn Dalay", "15", 46.65, 103.31667);
case 154: return new CityInfo("Sangiyn Dalay", "08", 46.00793, 104.94209);
case 155: return new CityInfo("Sangiyn Dalay", "14", 42.84199, 105.13796);
case 156: return new CityInfo("Rashaant", "13", 49.12667, 101.42806);
case 157: return new CityInfo("Rashaant", "08", 45.3, 106.2);
case 158: return new CityInfo("Övt", "15", 46.81667, 102.25);
case 159: return new CityInfo("Ovoot", "17", 45.30423, 113.84977);
case 160: return new CityInfo("Orhontuul", "16", 48.94972, 104.97583);
case 161: return new CityInfo("Örgön", "02", 44.73637, 100.39135);
case 162: return new CityInfo("Orgil", "18", 48.4538, 105.31769);
case 163: return new CityInfo("Onon", "11", 48.61667, 110.6);
case 164: return new CityInfo("Ongon", "15", 46.98259, 103.78389);
case 165: return new CityInfo("Ongi", "15", 46.46667, 102.28333);
case 166: return new CityInfo("Ongi", "08", 45.45, 103.9);
case 167: return new CityInfo("Öndörhoshuu", "06", 48, 113.93333);
case 168: return new CityInfo("Undurkhaan", "11", 47.31944, 110.65556);
case 169: return new CityInfo("Öldziyt", "01", 48.52843, 101.37394);
case 170: return new CityInfo("Öldziyt", "07", 44.68333, 109.01667);
case 171: return new CityInfo("Ögöömör", "14", 43.78336, 104.48067);
case 172: return new CityInfo("Nüden", "07", 43.58333, 110.46667);
case 173: return new CityInfo("Nomgon", "16", 49.2001, 105.66582);
case 174: return new CityInfo("Nart", "16", 49.145, 105.38833);
case 175: return new CityInfo("Naranbulag", "06", 49.2436, 113.37427);
case 176: return new CityInfo("Murun-kuren", "13", 49.63417, 100.1625);
case 177: return new CityInfo("Mörön", "11", 47.38254, 110.31647);
case 178: return new CityInfo("Mönhbulag", "15", 46.75, 103.51667);
case 179: return new CityInfo("Modot", "11", 47.75, 109.05);
case 180: return new CityInfo("Mayhan", "15", 46.09121, 103.83951);
case 181: return new CityInfo("Mardzad", "15", 45.95, 102.05);
case 182: return new CityInfo("Manhan", "13", 50.12139, 100.04306);
case 183: return new CityInfo("Mandalgovi", "08", 45.7625, 106.27083);
case 184: return new CityInfo("Dzüünkharaa", "16", 48.63333, 106.73333);
case 185: return new CityInfo("Mandal", "21", 48.63111, 103.52917);
case 186: return new CityInfo("Mandal", "18", 48.37062, 106.74076);
case 187: return new CityInfo("Maanĭt", "21", 48.29667, 103.42556);
case 188: return new CityInfo("Maanĭt", "18", 47.25, 107.53333);
case 189: return new CityInfo("Sujji", "18", 47.86667, 105.25);
case 190: return new CityInfo("Javhlant", "18", 48.80189, 105.924);
case 191: return new CityInfo("Javarthushuu", "06", 49.15, 112.73333);
case 192: return new CityInfo("Jargalant", "16", 50.0675, 105.88056);
case 193: return new CityInfo("Jargalant", "13", 49.29591, 100.25711);
case 194: return new CityInfo("Jargalant", "18", 48.52056, 105.86833);
case 195: return new CityInfo("Jargalant", "01", 47.79309, 101.97235);
case 196: return new CityInfo("Jargalant", "01", 47.53333, 100.21667);
case 197: return new CityInfo("Ingettolgoy", "21", 49.46167, 103.97417);
case 198: return new CityInfo("Ihsüüj", "18", 48.2257, 106.29152);
case 199: return new CityInfo("Ihbulag", "14", 43.2, 107.2);
case 200: return new CityInfo("Huurch", "16", 50.10361, 105.42);
case 201: return new CityInfo("Hutag", "21", 49.395, 102.69333);
case 202: return new CityInfo("Hüremt", "21", 48.66306, 102.62278);
case 203: return new CityInfo("Hüremt", "15", 46.30241, 102.44554);
case 204: return new CityInfo("Hulstay", "06", 48.43333, 114.86667);
case 205: return new CityInfo("Hujirt", "01", 48.88199, 101.23953);
case 206: return new CityInfo("Khujirt", "15", 46.89704, 102.76903);
case 207: return new CityInfo("Hujirt", "18", 46.6, 104.58333);
case 208: return new CityInfo("Noyon Suma", "14", 43.17361, 102.13194);
case 209: return new CityInfo("Khuvsget", "07", 43.60639, 109.63806);
case 210: return new CityInfo("Hovd", "15", 44.66667, 102.38333);
case 211: return new CityInfo("Hovd", "15", 44.67024, 102.17491);
case 212: return new CityInfo("Hotont", "01", 47.36278, 102.46794);
case 213: return new CityInfo("Höshööt", "01", 48.1009, 102.55686);
case 214: return new CityInfo("Horiult", "02", 45.2, 100.76667);
case 215: return new CityInfo("Tsagaan-Owoo", "06", 48.4, 113.43333);
case 216: return new CityInfo("Bayan Uula Sumu", "15", 45.16667, 101.4);
case 217: return new CityInfo("Hoolt", "15", 45.53333, 102.98333);
case 218: return new CityInfo("Hongor", "07", 45.8, 111.2);
case 219: return new CityInfo("Hongor", "17", 45.13507, 113.68378);
case 220: return new CityInfo("Undur Sume", "13", 50.47278, 100.92778);
case 221: return new CityInfo("Höhbürd", "02", 46.28575, 100.44834);
case 222: return new CityInfo("Herlen", "11", 47.3, 110.56667);
case 223: return new CityInfo("Haylaastay", "17", 46.77076, 113.88248);
case 224: return new CityInfo("Havirga", "17", 45.66667, 113.08333);
case 225: return new CityInfo("Hatavch", "17", 46.16667, 112.95);
case 226: return new CityInfo("Hatansuudal", "02", 44.54595, 100.82788);
case 227: return new CityInfo("Hashaat", "08", 45.24323, 104.80511);
case 228: return new CityInfo("Orhon", "23", 49.8325, 106.13639);
case 229: return new CityInfo("Haraat", "08", 46.41667, 107.65);
case 230: return new CityInfo("Hanhöhiy", "17", 47.61667, 112.13333);
case 231: return new CityInfo("Hajuu-Us", "08", 46.04988, 107.48955);
case 232: return new CityInfo("Erhet", "21", 48.27394, 102.9812);
case 233: return new CityInfo("Ergel", "07", 43.15, 109.13333);
case 234: return new CityInfo("Ereencav", "06", 49.8807, 115.72526);
case 235: return new CityInfo("Erdenetsogt", "02", 46.41845, 100.82239);
case 236: return new CityInfo("Erdenetsogt", "14", 42.97238, 106.11866);
case 237: return new CityInfo("Erdenet", "25", 49.03333, 104.08333);
case 238: return new CityInfo("Eg-Uur", "13", 50.10944, 101.57528);
case 239: return new CityInfo("Enhtal", "16", 49.2475, 105.37361);
case 240: return new CityInfo("Eg", "11", 48.68333, 110.18333);
case 241: return new CityInfo("Dzuunmod", "18", 47.70694, 106.95278);
case 242: return new CityInfo("Dzüünharaa", "16", 48.85229, 106.45786);
case 243: return new CityInfo("Dzüünbulag", "06", 46.95343, 115.29396);
case 244: return new CityInfo("Dzüünbulag", "17", 46.38333, 112.18333);
case 245: return new CityInfo("Dzogsool", "18", 46.8, 107.15);
case 246: return new CityInfo("Dzelter", "16", 50.31556, 105.04583);
case 247: return new CityInfo("Dzegstey", "01", 47.66805, 102.54999);
case 248: return new CityInfo("Dzaanhoshuu", "01", 47.49331, 100.87801);
case 249: return new CityInfo("Dund-Urt", "18", 48.03791, 105.9219);
case 250: return new CityInfo("Dundbürd", "11", 47.9459, 111.49784);
case 251: return new CityInfo("Doloon", "14", 44.42446, 105.32078);
case 252: return new CityInfo("Delgerhaan", "16", 50.08578, 106.18578);
case 253: return new CityInfo("Dashbalbar", "06", 49.54571, 114.40287);
case 254: return new CityInfo("Darhan", "23", 49.48667, 105.92278);
case 255: return new CityInfo("Darhan", "21", 48.25463, 103.88054);
case 256: return new CityInfo("Darhan", "11", 46.61667, 109.41667);
case 257: return new CityInfo("Dalay", "14", 43.46787, 103.51284);
case 258: return new CityInfo("Dalandzadgad", "14", 43.57083, 104.425);
case 259: return new CityInfo("Choyr", "24", 46.36111, 108.36111);
case 260: return new CityInfo("Choibalsan", "06", 48.07257, 114.53264);
case 261: return new CityInfo("Chonogol", "17", 45.9, 115.36667);
case 262: return new CityInfo("Chandmanĭ", "07", 45.53333, 110.46667);
case 263: return new CityInfo("Saynshand", "07", 44.88239, 110.11631);
case 264: return new CityInfo("Buyant", "11", 46.25, 110.83333);
case 265: return new CityInfo("Burgaltay", "16", 49.265, 104.74348);
case 266: return new CityInfo("Bumbat", "15", 46.49674, 104.11777);
case 267: return new CityInfo("Bulgan", "13", 50.54194, 101.51417);
case 268: return new CityInfo("Bulgan", "21", 48.8125, 103.53472);
case 269: return new CityInfo("Bulgan", "14", 44.09745, 103.54288);
case 270: return new CityInfo("Bulagtay", "16", 49.77594, 107.51616);
case 271: return new CityInfo("Bulagiyn Denj", "01", 47.31869, 101.11576);
case 272: return new CityInfo("Bulag", "13", 49.85946, 100.62687);
case 273: return new CityInfo("Bulag", "18", 48.2, 108.48333);
case 274: return new CityInfo("Bugat", "21", 49.06667, 103.66583);
case 275: return new CityInfo("Bugant", "16", 49.58333, 106.85);
case 276: return new CityInfo("Bornuur", "18", 48.46667, 106.26667);
case 277: return new CityInfo("Böhöt", "08", 45.23223, 108.28245);
case 278: return new CityInfo("Bodĭ", "02", 45.41171, 100.574);
case 279: return new CityInfo("Bayshint", "18", 47.41667, 104.81667);
case 280: return new CityInfo("Bayasgalant", "18", 47.17945, 108.25996);
case 281: return new CityInfo("Bayasgalant", "17", 46.98333, 112.05);
case 282: return new CityInfo("Bayan-Ulaan", "15", 46.52178, 102.59428);
case 283: return new CityInfo("Bayantsagaan", "01", 48.73167, 100.76);
case 284: return new CityInfo("Bayantöhöm", "18", 46.91667, 105.05);
case 285: return new CityInfo("Bayan-Ovoo", "11", 49.01667, 111.63333);
case 286: return new CityInfo("Javhlant", "11", 47.78333, 112.11667);
case 287: return new CityInfo("Bayanhoshuu", "02", 46.70197, 100.1433);
case 288: return new CityInfo("Bayanhongor", "02", 46.19444, 100.71806);
case 289: return new CityInfo("Bayandelger", "18", 47.72732, 108.11062);
case 290: return new CityInfo("Bayanbulag", "11", 47.86667, 109.91667);
case 291: return new CityInfo("Bayanbaraat", "18", 46.86667, 106.25);
case 292: return new CityInfo("Bayan", "11", 48.55, 111.08333);
case 293: return new CityInfo("Bayan", "06", 47.91667, 112.95);
case 294: return new CityInfo("Bayan", "01", 47.45, 103.15);
case 295: return new CityInfo("Bayan", "11", 47.16667, 110.81667);
case 296: return new CityInfo("Bayan", "07", 46.25, 110.16667);
case 297: return new CityInfo("Bat-Öldziyt", "18", 48.21552, 104.77318);
case 298: return new CityInfo("Baruun-Urt", "17", 46.68056, 113.27917);
case 299: return new CityInfo("Baruunsuu", "14", 43.65595, 105.75577);
case 300: return new CityInfo("Hushaat", "16", 49.5, 105.61667);
case 301: return new CityInfo("Badrah", "13", 49.61833, 101.98972);
case 302: return new CityInfo("Avraga", "11", 47.17851, 109.18968);
case 303: return new CityInfo("Avdzaga", "21", 47.63333, 103.51667);
case 304: return new CityInfo("Arvayheer", "15", 46.26389, 102.775);
case 305: return new CityInfo("Arhust", "18", 47.79425, 107.88334);
case 306: return new CityInfo("Arguut", "15", 45.46278, 102.42056);
case 307: return new CityInfo("Argatay", "08", 45.76667, 107.98333);
case 308: return new CityInfo("Argalant", "18", 47.94211, 105.89584);
case 309: return new CityInfo("Ar-Asgat", "18", 48.26222, 105.41194);
case 310: return new CityInfo("Amardalay", "08", 46.12572, 106.37426);
case 311: return new CityInfo("Altan-Ovoo", "01", 47.44742, 101.75503);
case 312: return new CityInfo("Altanbulag", "16", 50.31556, 106.49861);
case 313: return new CityInfo("Altanbulag", "18", 47.7, 106.4);
case 314: return new CityInfo("Asgat", "09", 49.51082, 96.79944);
case 315: return new CityInfo("Ulaanshiveet", "21", 47.28948, 103.85659);
case 316: return new CityInfo("Sümber", "06", 47.65858, 118.51014);
case 317: return new CityInfo("Bayantal", "24", 46.56221, 108.30439);
case 318: return new CityInfo("Shiveegovĭ", "24", 46.10558, 108.62061);
case 319: return new CityInfo("Hongor", "23", 49.23012, 105.89674);
case 320: return new CityInfo("Jargalant", "25", 49.12915, 104.40803);
case 321: return new CityInfo("Höshigiyn-Ar", "18", 47.55717, 106.96333);
case 322: return new CityInfo("Зуунмод", "18", 47.70693, 106.95276);
case 323: return new CityInfo("Kharkhorin", "15", 47.19245, 102.81349);
default: return new CityInfo("Ulaan Khat", "03", 47.98257, 89.84173);

                                    }                                        
                                }
                            
                        }
                    }
                