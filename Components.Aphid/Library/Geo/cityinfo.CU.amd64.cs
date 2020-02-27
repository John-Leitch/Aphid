
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
                                    public const string Country = "CU";
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
                            
                                        var cur = (Math.Abs(21.99712 - lat) + Math.Abs(-79.36678 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(20.27465 - lat) + Math.Abs(-76.95132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.32691 - lat) + Math.Abs(-79.23567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.61892 - lat) + Math.Abs(-83.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.25817 - lat) + Math.Abs(-78.14979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.73748 - lat) + Math.Abs(-78.79336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.15678 - lat) + Math.Abs(-81.24441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.60009 - lat) + Math.Abs(-76.13364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.79505 - lat) + Math.Abs(-81.53617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.80224 - lat) + Math.Abs(-79.98467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.91524 - lat) + Math.Abs(-80.01929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.00198 - lat) + Math.Abs(-79.26387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.8 - lat) + Math.Abs(-83.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.23631 - lat) + Math.Abs(-77.52561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.58677 - lat) + Math.Abs(-80.24261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.97 - lat) + Math.Abs(-82.38694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.02083 - lat) + Math.Abs(-75.82667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.71633 - lat) + Math.Abs(-77.99816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.15424 - lat) + Math.Abs(-81.92556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.40694 - lat) + Math.Abs(-79.96472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.78444 - lat) + Math.Abs(-81.91333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.09544 - lat) + Math.Abs(-82.32669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27898 - lat) + Math.Abs(-83.75956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.18809 - lat) + Math.Abs(-75.85031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27967 - lat) + Math.Abs(-83.8401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.96139 - lat) + Math.Abs(-82.15111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.64667 - lat) + Math.Abs(-83.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.92972 - lat) + Math.Abs(-79.4425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.71658 - lat) + Math.Abs(-83.05647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.05756 - lat) + Math.Abs(-74.81054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.89018 - lat) + Math.Abs(-82.50099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.80667 - lat) + Math.Abs(-80.07556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.58269 - lat) + Math.Abs(-75.24116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.34184 - lat) + Math.Abs(-80.55596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.36667 - lat) + Math.Abs(-75.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.55971 - lat) + Math.Abs(-76.91673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.49502 - lat) + Math.Abs(-79.54548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.125 - lat) + Math.Abs(-82.33194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.37266 - lat) + Math.Abs(-80.15046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.88042 - lat) + Math.Abs(-80.39098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.02942 - lat) + Math.Abs(-75.99441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.82313 - lat) + Math.Abs(-82.35558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.78816 - lat) + Math.Abs(-80.25226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19517 - lat) + Math.Abs(-76.60358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.94501 - lat) + Math.Abs(-78.4313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31184 - lat) + Math.Abs(-79.6544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.41667 - lat) + Math.Abs(-83.69667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.90553 - lat) + Math.Abs(-77.32152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.76987 - lat) + Math.Abs(-81.0183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.72709 - lat) + Math.Abs(-81.28963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.24126 - lat) + Math.Abs(-80.3911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.2113 - lat) + Math.Abs(-75.99362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.36373 - lat) + Math.Abs(-74.9704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.54585 - lat) + Math.Abs(-77.26504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.76266 - lat) + Math.Abs(-81.75617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.88667 - lat) + Math.Abs(-82.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.04698 - lat) + Math.Abs(-77.58089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.07308 - lat) + Math.Abs(-77.74516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.10774 - lat) + Math.Abs(-78.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.65776 - lat) + Math.Abs(-74.95075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.58691 - lat) + Math.Abs(-83.94551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.48802 - lat) + Math.Abs(-77.61033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.78813 - lat) + Math.Abs(-82.15138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.14298 - lat) + Math.Abs(-77.43532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.65417 - lat) + Math.Abs(-75.67945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.04111 - lat) + Math.Abs(-81.5775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.94714 - lat) + Math.Abs(-80.91902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.98931 - lat) + Math.Abs(-82.75376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.34173 - lat) + Math.Abs(-77.12126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.29058 - lat) + Math.Abs(-84.28599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.15021 - lat) + Math.Abs(-79.97867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.58733 - lat) + Math.Abs(-80.91451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.3107 - lat) + Math.Abs(-76.93403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.91717 - lat) + Math.Abs(-79.00329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.24673 - lat) + Math.Abs(-74.15181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.91 - lat) + Math.Abs(-81.85639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.58882 - lat) + Math.Abs(-83.24671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.72969 - lat) + Math.Abs(-80.72081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.95035 - lat) + Math.Abs(-81.41059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.96167 - lat) + Math.Abs(-76.95111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.77241 - lat) + Math.Abs(-79.26832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.87199 - lat) + Math.Abs(-82.42328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.74995 - lat) + Math.Abs(-83.55415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.41479 - lat) + Math.Abs(-80.2931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.13302 - lat) + Math.Abs(-82.38304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.77041 - lat) + Math.Abs(-83.73138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.80375 - lat) + Math.Abs(-81.19127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.96917 - lat) + Math.Abs(-76.29944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.90748 - lat) + Math.Abs(-77.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.36785 - lat) + Math.Abs(-76.42741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.16139 - lat) + Math.Abs(-76.47919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.94333 - lat) + Math.Abs(-79.16906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.04419 - lat) + Math.Abs(-82.00919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.97559 - lat) + Math.Abs(-82.16852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.52694 - lat) + Math.Abs(-81.12861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.93924 - lat) + Math.Abs(-80.01185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.06936 - lat) + Math.Abs(-74.6314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.88722 - lat) + Math.Abs(-76.26306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.25494 - lat) + Math.Abs(-76.5393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.79613 - lat) + Math.Abs(-82.50667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.83727 - lat) + Math.Abs(-82.02641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.04956 - lat) + Math.Abs(-79.46106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.81 - lat) + Math.Abs(-82.20306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.14444 - lat) + Math.Abs(-75.20917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.20179 - lat) + Math.Abs(-84.08484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.92639 - lat) + Math.Abs(-82.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.12518 - lat) + Math.Abs(-82.30067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.05222 - lat) + Math.Abs(-77.3499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.81112 - lat) + Math.Abs(-82.14748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.10988 - lat) + Math.Abs(-76.13145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.73872 - lat) + Math.Abs(-78.54434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.10475 - lat) + Math.Abs(-79.72141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.52536 - lat) + Math.Abs(-78.22579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.1461 - lat) + Math.Abs(-78.97328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.4468 - lat) + Math.Abs(-80.09711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.85139 - lat) + Math.Abs(-78.11725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.61802 - lat) + Math.Abs(-79.86603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.0485 - lat) + Math.Abs(-75.94579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.3 - lat) + Math.Abs(-78.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.15247 - lat) + Math.Abs(-80.20354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.64855 - lat) + Math.Abs(-75.92967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.34203 - lat) + Math.Abs(-80.27021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.98212 - lat) + Math.Abs(-80.58556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.29879 - lat) + Math.Abs(-76.24511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.50419 - lat) + Math.Abs(-83.51442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.8767 - lat) + Math.Abs(-79.84014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.72064 - lat) + Math.Abs(-80.90492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.98812 - lat) + Math.Abs(-77.42598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.01921 - lat) + Math.Abs(-78.70365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.6493 - lat) + Math.Abs(-80.04935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.14957 - lat) + Math.Abs(-80.44662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.84 - lat) + Math.Abs(-78.76194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.19534 - lat) + Math.Abs(-78.9123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.10809 - lat) + Math.Abs(-82.3866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.66381 - lat) + Math.Abs(-75.26882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.55709 - lat) + Math.Abs(-76.4727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.57572 - lat) + Math.Abs(-78.28251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.03661 - lat) + Math.Abs(-81.20596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.74057 - lat) + Math.Abs(-82.95912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.23329 - lat) + Math.Abs(-77.2799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.48333 - lat) + Math.Abs(-79.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.46476 - lat) + Math.Abs(-79.72324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.38083 - lat) + Math.Abs(-77.91694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.92036 - lat) + Math.Abs(-76.87144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.5342 - lat) + Math.Abs(-80.91105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.64515 - lat) + Math.Abs(-79.8951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.95052 - lat) + Math.Abs(-82.59435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.51996 - lat) + Math.Abs(-79.46599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.73775 - lat) + Math.Abs(-76.32574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.97944 - lat) + Math.Abs(-82.92214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.07874 - lat) + Math.Abs(-79.49726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.17182 - lat) + Math.Abs(-76.75659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.76307 - lat) + Math.Abs(-81.4478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.08397 - lat) + Math.Abs(-78.33884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.92861 - lat) + Math.Abs(-82.38861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.37417 - lat) + Math.Abs(-76.64361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.98226 - lat) + Math.Abs(-82.54719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.71794 - lat) + Math.Abs(-82.28965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.16635 - lat) + Math.Abs(-76.94291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.68216 - lat) + Math.Abs(-78.62567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.34711 - lat) + Math.Abs(-74.49624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.96116 - lat) + Math.Abs(-75.722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.90332 - lat) + Math.Abs(-83.15994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.75103 - lat) + Math.Abs(-76.02571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.81667 - lat) + Math.Abs(-82.75944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.03811 - lat) + Math.Abs(-82.37703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.83104 - lat) + Math.Abs(-75.73566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.81914 - lat) + Math.Abs(-77.57958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.80517 - lat) + Math.Abs(-82.58392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.15794 - lat) + Math.Abs(-82.27837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.76719 - lat) + Math.Abs(-81.56803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.3852 - lat) + Math.Abs(-80.84792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27797 - lat) + Math.Abs(-80.56931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.16076 - lat) + Math.Abs(-82.32798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.13833 - lat) + Math.Abs(-82.36417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.13028 - lat) + Math.Abs(-82.35306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.24224 - lat) + Math.Abs(-77.82625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.0072 - lat) + Math.Abs(-82.4017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.0881 - lat) + Math.Abs(-82.3597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.41384 - lat) + Math.Abs(-75.49635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.71212 - lat) + Math.Abs(-77.7613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.19198 - lat) + Math.Abs(-74.22719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zaza del Medio", "14", 21.99712, -79.36678);
case 1: return new CityInfo("Yara", "09", 20.27465, -76.95132);
case 2: return new CityInfo("Yaguajay", "14", 22.32691, -79.23567);
case 3: return new CityInfo("Viñales", "01", 22.61892, -83.70694);
case 4: return new CityInfo("Vertientes", "05", 21.25817, -78.14979);
case 5: return new CityInfo("Venezuela", "07", 21.73748, -78.79336);
case 6: return new CityInfo("Varadero", "03", 23.15678, -81.24441);
case 7: return new CityInfo("San Germán", "12", 20.60009, -76.13364);
case 8: return new CityInfo("Unión de Reyes", "03", 22.79505, -81.53617);
case 9: return new CityInfo("Trinidad", "14", 21.80224, -79.98467);
case 10: return new CityInfo("Topes de Collantes", "14", 21.91524, -80.01929);
case 11: return new CityInfo("Taguasco", "14", 22.00198, -79.26387);
case 12: return new CityInfo("Soroa", "AR", 22.8, -83.01667);
case 13: return new CityInfo("Sibanicú", "05", 21.23631, -77.52561);
case 14: return new CityInfo("Santo Domingo", "16", 22.58677, -80.24261);
case 15: return new CityInfo("Santiago de las Vegas", "02", 22.97, -82.38694);
case 16: return new CityInfo("Santiago de Cuba", "15", 20.02083, -75.82667);
case 17: return new CityInfo("Santa Cruz del Sur", "05", 20.71633, -77.99816);
case 18: return new CityInfo("Santa Cruz del Norte", "MA", 23.15424, -81.92556);
case 19: return new CityInfo("Santa Clara", "16", 22.40694, -79.96472);
case 20: return new CityInfo("San Nicolás de Bari", "MA", 22.78444, -81.91333);
case 21: return new CityInfo("San Miguel del Padrón", "02", 23.09544, -82.32669);
case 22: return new CityInfo("San Luis", "01", 22.27898, -83.75956);
case 23: return new CityInfo("San Luis", "15", 20.18809, -75.85031);
case 24: return new CityInfo("San Juan y Martínez", "01", 22.27967, -83.8401);
case 25: return new CityInfo("San José de las Lajas", "MA", 22.96139, -82.15111);
case 26: return new CityInfo("San Diego de Los Baños", "01", 22.64667, -83.36972);
case 27: return new CityInfo("Sancti Spíritus", "14", 21.92972, -79.4425);
case 28: return new CityInfo("San Cristobal", "AR", 22.71658, -83.05647);
case 29: return new CityInfo("San Antonio del Sur", "10", 20.05756, -74.81054);
case 30: return new CityInfo("San Antonio de los Baños", "AR", 22.89018, -82.50099);
case 31: return new CityInfo("Sagua la Grande", "16", 22.80667, -80.07556);
case 32: return new CityInfo("Sagua de Tánamo", "12", 20.58269, -75.24116);
case 33: return new CityInfo("Rodas", "08", 22.34184, -80.55596);
case 34: return new CityInfo("Río Guayabal de Yateras", "10", 20.36667, -75.01667);
case 35: return new CityInfo("Río Cauto", "09", 20.55971, -76.91673);
case 36: return new CityInfo("Remedios", "16", 22.49502, -79.54548);
case 37: return new CityInfo("Regla", "02", 23.125, -82.33194);
case 38: return new CityInfo("Ranchuelo", "16", 22.37266, -80.15046);
case 39: return new CityInfo("Rancho Veloz", "16", 22.88042, -80.39098);
case 40: return new CityInfo("Santa Lucía", "12", 21.02942, -75.99441);
case 41: return new CityInfo("Quivicán", "MA", 22.82313, -82.35558);
case 42: return new CityInfo("Quemado de Güines", "16", 22.78816, -80.25226);
case 43: return new CityInfo("Puerto Padre", "13", 21.19517, -76.60358);
case 44: return new CityInfo("Primero de Enero", "07", 21.94501, -78.4313);
case 45: return new CityInfo("Placetas", "16", 22.31184, -79.6544);
case 46: return new CityInfo("Pinar del Río", "01", 22.41667, -83.69667);
case 47: return new CityInfo("Pilón", "09", 19.90553, -77.32152);
case 48: return new CityInfo("Perico", "03", 22.76987, -81.0183);
case 49: return new CityInfo("Pedro Betancourt", "03", 22.72709, -81.28963);
case 50: return new CityInfo("Palmira", "08", 22.24126, -80.3911);
case 51: return new CityInfo("Palma Soriano", "15", 20.2113, -75.99362);
case 52: return new CityInfo("Palenque", "10", 20.36373, -74.9704);
case 53: return new CityInfo("Nuevitas", "05", 21.54585, -77.26504);
case 54: return new CityInfo("Nueva Paz", "MA", 22.76266, -81.75617);
case 55: return new CityInfo("Nueva Gerona", "04", 21.88667, -82.80556);
case 56: return new CityInfo("Niquero", "09", 20.04698, -77.58089);
case 57: return new CityInfo("Najasa", "05", 21.07308, -77.74516);
case 58: return new CityInfo("Morón", "07", 22.10774, -78.62667);
case 59: return new CityInfo("Moa", "12", 20.65776, -74.95075);
case 60: return new CityInfo("Minas de Matahambre", "01", 22.58691, -83.94551);
case 61: return new CityInfo("Minas", "05", 21.48802, -77.61033);
case 62: return new CityInfo("Melena del Sur", "MA", 22.78813, -82.15138);
case 63: return new CityInfo("Media Luna", "09", 20.14298, -77.43532);
case 64: return new CityInfo("Mayarí", "12", 20.65417, -75.67945);
case 65: return new CityInfo("Matanzas", "03", 23.04111, -81.5775);
case 66: return new CityInfo("Martí", "03", 22.94714, -80.91902);
case 67: return new CityInfo("Mariel", "AR", 22.98931, -82.75376);
case 68: return new CityInfo("Manzanillo", "09", 20.34173, -77.12126);
case 69: return new CityInfo("Mantua", "01", 22.29058, -84.28599);
case 70: return new CityInfo("Manicaragua", "16", 22.15021, -79.97867);
case 71: return new CityInfo("Manguito", "03", 22.58733, -80.91451);
case 72: return new CityInfo("Manatí", "13", 21.3107, -76.93403);
case 73: return new CityInfo("Majagua", "07", 21.91717, -79.00329);
case 74: return new CityInfo("Maisí", "10", 20.24673, -74.15181);
case 75: return new CityInfo("Madruga", "MA", 22.91, -81.85639);
case 76: return new CityInfo("Los Palacios", "01", 22.58882, -83.24671);
case 77: return new CityInfo("Los Arabos", "03", 22.72969, -80.72081);
case 78: return new CityInfo("Limonar", "03", 22.95035, -81.41059);
case 79: return new CityInfo("Las Tunas", "13", 20.96167, -76.95111);
case 80: return new CityInfo("La Sierpe", "14", 21.77241, -79.26832);
case 81: return new CityInfo("La Salud", "MA", 22.87199, -82.42328);
case 82: return new CityInfo("La Palma", "01", 22.74995, -83.55415);
case 83: return new CityInfo("Lajas", "08", 22.41479, -80.2931);
case 84: return new CityInfo("Havana", "02", 23.13302, -82.38304);
case 85: return new CityInfo("Puerto Esperanza", "01", 22.77041, -83.73138);
case 86: return new CityInfo("Jovellanos", "03", 22.80375, -81.19127);
case 87: return new CityInfo("Jobabo", "12", 20.96917, -76.29944);
case 88: return new CityInfo("Jobabo", "13", 20.90748, -77.28194);
case 89: return new CityInfo("Jiguaní", "09", 20.36785, -76.42741);
case 90: return new CityInfo("Jesús Menéndez", "13", 21.16139, -76.47919);
case 91: return new CityInfo("Jatibonico", "14", 21.94333, -79.16906);
case 92: return new CityInfo("Jaruco", "MA", 23.04419, -82.00919);
case 93: return new CityInfo("Jamaica", "MA", 22.97559, -82.16852);
case 94: return new CityInfo("Jagüey Grande", "03", 22.52694, -81.12861);
case 95: return new CityInfo("Isabela de Sagua", "16", 22.93924, -80.01185);
case 96: return new CityInfo("Imías", "10", 20.06936, -74.6314);
case 97: return new CityInfo("Holguín", "12", 20.88722, -76.26306);
case 98: return new CityInfo("Guisa", "09", 20.25494, -76.5393);
case 99: return new CityInfo("Güira de Melena", "AR", 22.79613, -82.50667);
case 100: return new CityInfo("Güines", "MA", 22.83727, -82.02641);
case 101: return new CityInfo("Guayos", "14", 22.04956, -79.46106);
case 102: return new CityInfo("Guara", "MA", 22.81, -82.20306);
case 103: return new CityInfo("Guantánamo", "10", 20.14444, -75.20917);
case 104: return new CityInfo("Guane", "01", 22.20179, -84.08484);
case 105: return new CityInfo("Guanajay", "AR", 22.92639, -82.6875);
case 106: return new CityInfo("Guanabacoa", "02", 23.12518, -82.30067);
case 107: return new CityInfo("Guáimaro", "05", 21.05222, -77.3499);
case 108: return new CityInfo("Mañalich", "MA", 22.81112, -82.14748);
case 109: return new CityInfo("Gibara", "12", 21.10988, -76.13145);
case 110: return new CityInfo("Gaspar", "07", 21.73872, -78.54434);
case 111: return new CityInfo("Fomento", "14", 22.10475, -79.72141);
case 112: return new CityInfo("Florida", "05", 21.52536, -78.22579);
case 113: return new CityInfo("Florencia", "07", 22.1461, -78.97328);
case 114: return new CityInfo("Esperanza", "16", 22.4468, -80.09711);
case 115: return new CityInfo("Esmeralda", "05", 21.85139, -78.11725);
case 116: return new CityInfo("Encrucijada", "16", 22.61802, -79.86603);
case 117: return new CityInfo("El Cobre", "15", 20.0485, -75.94579);
case 118: return new CityInfo("El Caney", "05", 21.3, -78.48333);
case 119: return new CityInfo("Cumanayagua", "08", 22.15247, -80.20354);
case 120: return new CityInfo("Cueto", "12", 20.64855, -75.92967);
case 121: return new CityInfo("Cruces", "08", 22.34203, -80.27021);
case 122: return new CityInfo("Corralillo", "16", 22.98212, -80.58556);
case 123: return new CityInfo("Contramaestre", "15", 20.29879, -76.24511);
case 124: return new CityInfo("Consolación del Sur", "01", 22.50419, -83.51442);
case 125: return new CityInfo("Condado", "14", 21.8767, -79.84014);
case 126: return new CityInfo("Colón", "03", 22.72064, -80.90492);
case 127: return new CityInfo("Colombia", "13", 20.98812, -77.42598);
case 128: return new CityInfo("Ciro Redondo", "07", 22.01921, -78.70365);
case 129: return new CityInfo("Cifuentes", "16", 22.6493, -80.04935);
case 130: return new CityInfo("Cienfuegos", "08", 22.14957, -80.44662);
case 131: return new CityInfo("Ciego de Ávila", "07", 21.84, -78.76194);
case 132: return new CityInfo("Chambas", "07", 22.19534, -78.9123);
case 133: return new CityInfo("Cerro", "02", 23.10809, -82.3866);
case 134: return new CityInfo("Cayo Mambí", "12", 20.66381, -75.26882);
case 135: return new CityInfo("Cauto Cristo", "09", 20.55709, -76.4727);
case 136: return new CityInfo("Carlos Manuel de Céspedes", "05", 21.57572, -78.28251);
case 137: return new CityInfo("Cárdenas", "03", 23.03661, -81.20596);
case 138: return new CityInfo("Candelaria", "AR", 22.74057, -82.95912);
case 139: return new CityInfo("Campechuela", "09", 20.23329, -77.2799);
case 140: return new CityInfo("Camajuaní", "16", 22.48333, -79.75);
case 141: return new CityInfo("Camajuaní", "16", 22.46476, -79.72324);
case 142: return new CityInfo("Camagüey", "05", 21.38083, -77.91694);
case 143: return new CityInfo("Calixto", "13", 20.92036, -76.87144);
case 144: return new CityInfo("Calimete", "03", 22.5342, -80.91105);
case 145: return new CityInfo("Calabazar de Sagua", "16", 22.64515, -79.8951);
case 146: return new CityInfo("Caimito", "AR", 22.95052, -82.59435);
case 147: return new CityInfo("Caibarién", "16", 22.51996, -79.46599);
case 148: return new CityInfo("Cacocum", "12", 20.73775, -76.32574);
case 149: return new CityInfo("Cabañas", "AR", 22.97944, -82.92214);
case 150: return new CityInfo("Cabaiguán", "14", 22.07874, -79.49726);
case 151: return new CityInfo("Buey Arriba", "09", 20.17182, -76.75659);
case 152: return new CityInfo("Bolondrón", "03", 22.76307, -81.4478);
case 153: return new CityInfo("Bolivia", "07", 22.08397, -78.33884);
case 154: return new CityInfo("Bejucal", "MA", 22.92861, -82.38861);
case 155: return new CityInfo("Bayamo", "09", 20.37417, -76.64361);
case 156: return new CityInfo("Bauta", "AR", 22.98226, -82.54719);
case 157: return new CityInfo("Batabanó", "MA", 22.71794, -82.28965);
case 158: return new CityInfo("Bartolomé Masó", "09", 20.16635, -76.94291);
case 159: return new CityInfo("Baraguá", "07", 21.68216, -78.62567);
case 160: return new CityInfo("Baracoa", "10", 20.34711, -74.49624);
case 161: return new CityInfo("Banes", "12", 20.96116, -75.722);
case 162: return new CityInfo("Bahía Honda", "AR", 22.90332, -83.15994);
case 163: return new CityInfo("Báguanos", "12", 20.75103, -76.02571);
case 164: return new CityInfo("Artemisa", "AR", 22.81667, -82.75944);
case 165: return new CityInfo("Arroyo Naranjo", "02", 23.03811, -82.37703);
case 166: return new CityInfo("Antilla", "12", 20.83104, -75.73566);
case 167: return new CityInfo("Amancio", "13", 20.81914, -77.57958);
case 168: return new CityInfo("Alquízar", "AR", 22.80517, -82.58392);
case 169: return new CityInfo("Alamar", "02", 23.15794, -82.27837);
case 170: return new CityInfo("Alacranes", "03", 22.76719, -81.56803);
case 171: return new CityInfo("Aguada de Pasajeros", "08", 22.3852, -80.84792);
case 172: return new CityInfo("Abreus", "08", 22.27797, -80.56931);
case 173: return new CityInfo("Ciudad Camilo Cienfuegos", "02", 23.16076, -82.32798);
case 174: return new CityInfo("Centro Habana", "02", 23.13833, -82.36417);
case 175: return new CityInfo("La Habana Vieja", "02", 23.13028, -82.35306);
case 176: return new CityInfo("Jimaguayú", "05", 21.24224, -77.82625);
case 177: return new CityInfo("Boyeros", "02", 23.0072, -82.4017);
case 178: return new CityInfo("Diez de Octubre", "02", 23.0881, -82.3597);
case 179: return new CityInfo("Segundo Frente", "15", 20.41384, -75.49635);
case 180: return new CityInfo("Cubitas", "05", 21.71212, -77.7613);
default: return new CityInfo("La Máquina", "10", 20.19198, -74.22719);

                                    }                                        
                                }
                            
                        }
                    }
                