
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
                                    public const string Country = "PA";
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
                            
                                        var cur = (Math.Abs(8.00532 - lat) + Math.Abs(-81.50653 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(8.95609 - lat) + Math.Abs(-79.87037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15835 - lat) + Math.Abs(-77.69276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09839 - lat) + Math.Abs(-77.59817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.77291 - lat) + Math.Abs(-82.63823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52687 - lat) + Math.Abs(-80.37486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92772 - lat) + Math.Abs(-79.7028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.77379 - lat) + Math.Abs(-79.87547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79832 - lat) + Math.Abs(-79.86929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.38695 - lat) + Math.Abs(-79.78159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33921 - lat) + Math.Abs(-81.49823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58263 - lat) + Math.Abs(-79.4069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88988 - lat) + Math.Abs(-79.62603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43333 - lat) + Math.Abs(-82.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23136 - lat) + Math.Abs(-81.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69497 - lat) + Math.Abs(-80.19547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62163 - lat) + Math.Abs(-80.31975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62011 - lat) + Math.Abs(-80.35076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97208 - lat) + Math.Abs(-81.21777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.13112 - lat) + Math.Abs(-77.9262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98572 - lat) + Math.Abs(-78.06078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61223 - lat) + Math.Abs(-80.19467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.92794 - lat) + Math.Abs(-77.94562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92098 - lat) + Math.Abs(-77.72394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.51667 - lat) + Math.Abs(-79.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99498 - lat) + Math.Abs(-81.31518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84018 - lat) + Math.Abs(-80.4074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34542 - lat) + Math.Abs(-80.64012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40684 - lat) + Math.Abs(-80.44217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23989 - lat) + Math.Abs(-81.67168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08939 - lat) + Math.Abs(-79.3831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12111 - lat) + Math.Abs(-81.82471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65131 - lat) + Math.Abs(-80.32017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55281 - lat) + Math.Abs(-82.45963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47514 - lat) + Math.Abs(-82.56058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38825 - lat) + Math.Abs(-81.72162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71369 - lat) + Math.Abs(-80.97825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68226 - lat) + Math.Abs(-80.17536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66233 - lat) + Math.Abs(-80.29373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15036 - lat) + Math.Abs(-78.2503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79462 - lat) + Math.Abs(-79.55475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54642 - lat) + Math.Abs(-82.6517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63191 - lat) + Math.Abs(-80.00888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01223 - lat) + Math.Abs(-81.32163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61542 - lat) + Math.Abs(-80.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37233 - lat) + Math.Abs(-81.58141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53865 - lat) + Math.Abs(-82.68619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48678 - lat) + Math.Abs(-82.66539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29828 - lat) + Math.Abs(-79.63956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91143 - lat) + Math.Abs(-79.6736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11445 - lat) + Math.Abs(-79.59755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59037 - lat) + Math.Abs(-82.63691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38959 - lat) + Math.Abs(-82.65058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50803 - lat) + Math.Abs(-82.71295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.74614 - lat) + Math.Abs(-80.24173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.1 - lat) + Math.Abs(-80.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.86459 - lat) + Math.Abs(-80.09923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59958 - lat) + Math.Abs(-82.68489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85681 - lat) + Math.Abs(-79.87954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.49307 - lat) + Math.Abs(-80.18298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51406 - lat) + Math.Abs(-82.6987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11143 - lat) + Math.Abs(-80.66582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53922 - lat) + Math.Abs(-79.1957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65525 - lat) + Math.Abs(-78.1614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51063 - lat) + Math.Abs(-81.07802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64269 - lat) + Math.Abs(-82.75939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23219 - lat) + Math.Abs(-81.91323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.02875 - lat) + Math.Abs(-79.75443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83376 - lat) + Math.Abs(-82.77945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38298 - lat) + Math.Abs(-80.10992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78193 - lat) + Math.Abs(-81.3279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6317 - lat) + Math.Abs(-81.25377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.933 - lat) + Math.Abs(-80.36369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14011 - lat) + Math.Abs(-81.08663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.72207 - lat) + Math.Abs(-80.22276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48011 - lat) + Math.Abs(-82.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45339 - lat) + Math.Abs(-82.50179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42558 - lat) + Math.Abs(-82.50173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05032 - lat) + Math.Abs(-79.47068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54614 - lat) + Math.Abs(-82.6256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21574 - lat) + Math.Abs(-79.25559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45685 - lat) + Math.Abs(-78.93695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27252 - lat) + Math.Abs(-81.15988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30561 - lat) + Math.Abs(-82.10114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48746 - lat) + Math.Abs(-82.49124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30311 - lat) + Math.Abs(-81.01575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27724 - lat) + Math.Abs(-81.99345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93333 - lat) + Math.Abs(-79.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5324 - lat) + Math.Abs(-79.93089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46704 - lat) + Math.Abs(-80.80514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37261 - lat) + Math.Abs(-81.40486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95188 - lat) + Math.Abs(-80.84757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.67395 - lat) + Math.Abs(-80.24438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28905 - lat) + Math.Abs(-78.15206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63374 - lat) + Math.Abs(-82.72862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24652 - lat) + Math.Abs(-80.97472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.06667 - lat) + Math.Abs(-81.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29063 - lat) + Math.Abs(-81.86702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95118 - lat) + Math.Abs(-79.53726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51663 - lat) + Math.Abs(-82.50906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47323 - lat) + Math.Abs(-79.96104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48445 - lat) + Math.Abs(-82.45058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21063 - lat) + Math.Abs(-81.27572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0729 - lat) + Math.Abs(-80.93187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6026 - lat) + Math.Abs(-82.72588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19841 - lat) + Math.Abs(-80.13186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33518 - lat) + Math.Abs(-79.6039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68188 - lat) + Math.Abs(-79.86764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.34269 - lat) + Math.Abs(-79.80961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88002 - lat) + Math.Abs(-80.63818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83543 - lat) + Math.Abs(-80.3649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63822 - lat) + Math.Abs(-82.49965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11205 - lat) + Math.Abs(-81.31684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23064 - lat) + Math.Abs(-82.42748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81741 - lat) + Math.Abs(-82.85731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30296 - lat) + Math.Abs(-79.79234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9618 - lat) + Math.Abs(-79.70074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71192 - lat) + Math.Abs(-80.35904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3794 - lat) + Math.Abs(-80.16621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61933 - lat) + Math.Abs(-81.2883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42679 - lat) + Math.Abs(-80.48457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71907 - lat) + Math.Abs(-81.33423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28922 - lat) + Math.Abs(-79.77204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25688 - lat) + Math.Abs(-79.67937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97882 - lat) + Math.Abs(-81.16162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96666 - lat) + Math.Abs(-79.76105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.37149 - lat) + Math.Abs(-79.78809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01667 - lat) + Math.Abs(-79.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52065 - lat) + Math.Abs(-82.40654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94594 - lat) + Math.Abs(-81.06703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84436 - lat) + Math.Abs(-80.60397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55551 - lat) + Math.Abs(-80.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46374 - lat) + Math.Abs(-82.27951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22436 - lat) + Math.Abs(-81.82747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12483 - lat) + Math.Abs(-79.37261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33404 - lat) + Math.Abs(-79.89172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37174 - lat) + Math.Abs(-82.5267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21012 - lat) + Math.Abs(-82.36081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09418 - lat) + Math.Abs(-81.67915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03548 - lat) + Math.Abs(-81.38692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35924 - lat) + Math.Abs(-81.92724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43333 - lat) + Math.Abs(-81.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29662 - lat) + Math.Abs(-79.70606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03631 - lat) + Math.Abs(-82.24952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.141 - lat) + Math.Abs(-82.12717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91659 - lat) + Math.Abs(-82.18488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10953 - lat) + Math.Abs(-80.94487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03333 - lat) + Math.Abs(-82.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29525 - lat) + Math.Abs(-78.25409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04834 - lat) + Math.Abs(-81.60499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58297 - lat) + Math.Abs(-78.17777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36316 - lat) + Math.Abs(-79.79333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66632 - lat) + Math.Abs(-77.41922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19333 - lat) + Math.Abs(-80.08833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87022 - lat) + Math.Abs(-79.71423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27775 - lat) + Math.Abs(-82.86206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25081 - lat) + Math.Abs(-81.66259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58399 - lat) + Math.Abs(-82.42282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38671 - lat) + Math.Abs(-80.20231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3 - lat) + Math.Abs(-82.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26132 - lat) + Math.Abs(-81.97411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97876 - lat) + Math.Abs(-77.48758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44669 - lat) + Math.Abs(-82.83859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.06317 - lat) + Math.Abs(-80.62271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88051 - lat) + Math.Abs(-79.82795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29345 - lat) + Math.Abs(-81.69903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68547 - lat) + Math.Abs(-82.4909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63978 - lat) + Math.Abs(-82.4856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56125 - lat) + Math.Abs(-82.78503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55303 - lat) + Math.Abs(-79.65693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01738 - lat) + Math.Abs(-80.59538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47285 - lat) + Math.Abs(-82.41934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88245 - lat) + Math.Abs(-80.9788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25814 - lat) + Math.Abs(-80.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.65816 - lat) + Math.Abs(-80.12119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73672 - lat) + Math.Abs(-82.81968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31128 - lat) + Math.Abs(-78.2327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78389 - lat) + Math.Abs(-79.77547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5662 - lat) + Math.Abs(-79.29185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46168 - lat) + Math.Abs(-82.15924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11301 - lat) + Math.Abs(-77.68851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63777 - lat) + Math.Abs(-80.51024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52419 - lat) + Math.Abs(-80.91152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5703 - lat) + Math.Abs(-81.74661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8811 - lat) + Math.Abs(-82.75391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90863 - lat) + Math.Abs(-80.61433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77461 - lat) + Math.Abs(-80.32494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51889 - lat) + Math.Abs(-80.35727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01502 - lat) + Math.Abs(-80.80366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37056 - lat) + Math.Abs(-81.71709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46171 - lat) + Math.Abs(-81.6788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71931 - lat) + Math.Abs(-80.28366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.06667 - lat) + Math.Abs(-79.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36586 - lat) + Math.Abs(-82.43524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53034 - lat) + Math.Abs(-80.02699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90071 - lat) + Math.Abs(-77.38965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12767 - lat) + Math.Abs(-79.24468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01667 - lat) + Math.Abs(-79.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62848 - lat) + Math.Abs(-80.1724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99393 - lat) + Math.Abs(-80.52097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05053 - lat) + Math.Abs(-80.55409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03315 - lat) + Math.Abs(-79.62749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65842 - lat) + Math.Abs(-82.58625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6851 - lat) + Math.Abs(-80.16082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9936 - lat) + Math.Abs(-79.51973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38779 - lat) + Math.Abs(-80.19722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34654 - lat) + Math.Abs(-82.60589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8178 - lat) + Math.Abs(-82.82489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73956 - lat) + Math.Abs(-82.45228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.54359 - lat) + Math.Abs(-79.21946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73401 - lat) + Math.Abs(-82.45887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.66347 - lat) + Math.Abs(-80.35728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.22838 - lat) + Math.Abs(-80.08503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5697 - lat) + Math.Abs(-79.36341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.20658 - lat) + Math.Abs(-79.68089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58529 - lat) + Math.Abs(-80.25832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68335 - lat) + Math.Abs(-82.31911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07937 - lat) + Math.Abs(-79.28997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36119 - lat) + Math.Abs(-82.50791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41807 - lat) + Math.Abs(-80.65123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94052 - lat) + Math.Abs(-80.77936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87064 - lat) + Math.Abs(-81.84103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24263 - lat) + Math.Abs(-79.60756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.22205 - lat) + Math.Abs(-79.66602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93333 - lat) + Math.Abs(-79.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00273 - lat) + Math.Abs(-79.73141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23979 - lat) + Math.Abs(-80.08267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92453 - lat) + Math.Abs(-79.72004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.26333 - lat) + Math.Abs(-79.81556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55 - lat) + Math.Abs(-79.87547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.86944 - lat) + Math.Abs(-79.99472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44485 - lat) + Math.Abs(-80.58934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53047 - lat) + Math.Abs(-80.32692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.57937 - lat) + Math.Abs(-79.47109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33209 - lat) + Math.Abs(-80.51969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.44394 - lat) + Math.Abs(-78.58666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12832 - lat) + Math.Abs(-79.23111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94672 - lat) + Math.Abs(-77.7508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84246 - lat) + Math.Abs(-77.97539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85266 - lat) + Math.Abs(-77.9169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46402 - lat) + Math.Abs(-82.47935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98858 - lat) + Math.Abs(-81.05643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78935 - lat) + Math.Abs(-82.82865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02487 - lat) + Math.Abs(-80.86325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36942 - lat) + Math.Abs(-80.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98179 - lat) + Math.Abs(-80.43764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64261 - lat) + Math.Abs(-80.4595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07436 - lat) + Math.Abs(-79.56736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.57544 - lat) + Math.Abs(-79.33573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99482 - lat) + Math.Abs(-82.24147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62507 - lat) + Math.Abs(-80.27693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14544 - lat) + Math.Abs(-80.30124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.49909 - lat) + Math.Abs(-77.97897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01471 - lat) + Math.Abs(-79.85073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58173 - lat) + Math.Abs(-80.21294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45056 - lat) + Math.Abs(-82.40057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6172 - lat) + Math.Abs(-80.09449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43991 - lat) + Math.Abs(-79.75455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58265 - lat) + Math.Abs(-80.0661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.32603 - lat) + Math.Abs(-79.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37302 - lat) + Math.Abs(-81.72741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33891 - lat) + Math.Abs(-82.76791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66766 - lat) + Math.Abs(-82.36335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62182 - lat) + Math.Abs(-80.54819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73168 - lat) + Math.Abs(-80.55364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44851 - lat) + Math.Abs(-81.19886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52866 - lat) + Math.Abs(-80.39518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93333 - lat) + Math.Abs(-80.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13974 - lat) + Math.Abs(-81.02417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.783 - lat) + Math.Abs(-80.64524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91589 - lat) + Math.Abs(-80.48884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.7921 - lat) + Math.Abs(-82.44665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12425 - lat) + Math.Abs(-79.28929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59787 - lat) + Math.Abs(-80.09503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.20553 - lat) + Math.Abs(-80.86022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93046 - lat) + Math.Abs(-80.5382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42014 - lat) + Math.Abs(-81.10421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.97805 - lat) + Math.Abs(-82.21438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71821 - lat) + Math.Abs(-80.67273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79746 - lat) + Math.Abs(-80.61071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02326 - lat) + Math.Abs(-81.11941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98565 - lat) + Math.Abs(-80.61886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11722 - lat) + Math.Abs(-80.70769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07912 - lat) + Math.Abs(-80.85494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.51656 - lat) + Math.Abs(-80.13521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52271 - lat) + Math.Abs(-82.19997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88422 - lat) + Math.Abs(-80.35772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53027 - lat) + Math.Abs(-82.42295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.49601 - lat) + Math.Abs(-82.42417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10898 - lat) + Math.Abs(-81.01355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42577 - lat) + Math.Abs(-82.55212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09326 - lat) + Math.Abs(-81.47163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47457 - lat) + Math.Abs(-81.69827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.1989 - lat) + Math.Abs(-80.70458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41996 - lat) + Math.Abs(-81.61865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47696 - lat) + Math.Abs(-80.32499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83463 - lat) + Math.Abs(-79.80765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90607 - lat) + Math.Abs(-80.42561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35317 - lat) + Math.Abs(-81.75445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63817 - lat) + Math.Abs(-80.43848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62787 - lat) + Math.Abs(-79.93129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45053 - lat) + Math.Abs(-80.22676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07473 - lat) + Math.Abs(-81.13626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97406 - lat) + Math.Abs(-80.71103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76059 - lat) + Math.Abs(-79.86309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.65972 - lat) + Math.Abs(-80.56347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95178 - lat) + Math.Abs(-80.64239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97637 - lat) + Math.Abs(-80.41646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78598 - lat) + Math.Abs(-80.4106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10007 - lat) + Math.Abs(-82.86679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81756 - lat) + Math.Abs(-80.91335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74869 - lat) + Math.Abs(-79.90974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7659 - lat) + Math.Abs(-80.84515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75415 - lat) + Math.Abs(-81.11556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4306 - lat) + Math.Abs(-80.85752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.43609 - lat) + Math.Abs(-80.58698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91457 - lat) + Math.Abs(-80.70332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7511 - lat) + Math.Abs(-80.29216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45937 - lat) + Math.Abs(-80.00075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.734 - lat) + Math.Abs(-80.37384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76472 - lat) + Math.Abs(-80.27483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58141 - lat) + Math.Abs(-80.67978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76523 - lat) + Math.Abs(-80.2935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13564 - lat) + Math.Abs(-81.45674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68314 - lat) + Math.Abs(-80.49728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55167 - lat) + Math.Abs(-80.32749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.80675 - lat) + Math.Abs(-79.91311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84167 - lat) + Math.Abs(-79.91073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13553 - lat) + Math.Abs(-80.99047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87899 - lat) + Math.Abs(-81.27611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64118 - lat) + Math.Abs(-80.39432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79581 - lat) + Math.Abs(-80.7457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46915 - lat) + Math.Abs(-80.09204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2995 - lat) + Math.Abs(-81.86605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88809 - lat) + Math.Abs(-80.21893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18426 - lat) + Math.Abs(-79.0873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50818 - lat) + Math.Abs(-80.37381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42927 - lat) + Math.Abs(-82.38743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16994 - lat) + Math.Abs(-81.69654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54963 - lat) + Math.Abs(-79.93521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24184 - lat) + Math.Abs(-81.86931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46702 - lat) + Math.Abs(-80.75089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90167 - lat) + Math.Abs(-81.14056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.386 - lat) + Math.Abs(-80.44733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90949 - lat) + Math.Abs(-80.80706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81469 - lat) + Math.Abs(-80.50155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54151 - lat) + Math.Abs(-80.36533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08916 - lat) + Math.Abs(-79.52809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.86167 - lat) + Math.Abs(-79.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82285 - lat) + Math.Abs(-80.43003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55 - lat) + Math.Abs(-80.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87561 - lat) + Math.Abs(-80.54912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10475 - lat) + Math.Abs(-80.99738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21054 - lat) + Math.Abs(-80.63837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16429 - lat) + Math.Abs(-80.82143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2163 - lat) + Math.Abs(-80.82729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55702 - lat) + Math.Abs(-81.19109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64216 - lat) + Math.Abs(-80.66788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8191 - lat) + Math.Abs(-79.84962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59299 - lat) + Math.Abs(-80.44349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12784 - lat) + Math.Abs(-81.02693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79757 - lat) + Math.Abs(-80.30342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.40608 - lat) + Math.Abs(-78.13964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71667 - lat) + Math.Abs(-80.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68864 - lat) + Math.Abs(-80.19647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84091 - lat) + Math.Abs(-79.78648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56022 - lat) + Math.Abs(-80.32736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5532 - lat) + Math.Abs(-82.59489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17308 - lat) + Math.Abs(-79.27401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14707 - lat) + Math.Abs(-81.18114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6567 - lat) + Math.Abs(-80.61794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08944 - lat) + Math.Abs(-80.87963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16667 - lat) + Math.Abs(-80.63742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.43708 - lat) + Math.Abs(-80.89118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73102 - lat) + Math.Abs(-80.25298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.04404 - lat) + Math.Abs(-79.84215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.60409 - lat) + Math.Abs(-80.04716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33882 - lat) + Math.Abs(-80.72949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24981 - lat) + Math.Abs(-81.87779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58587 - lat) + Math.Abs(-80.13212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84848 - lat) + Math.Abs(-79.80404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3425 - lat) + Math.Abs(-78.9343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07944 - lat) + Math.Abs(-79.91389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93708 - lat) + Math.Abs(-81.01643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51572 - lat) + Math.Abs(-82.67212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88389 - lat) + Math.Abs(-80.39039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.40344 - lat) + Math.Abs(-82.79197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26817 - lat) + Math.Abs(-78.9246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45622 - lat) + Math.Abs(-80.06835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36618 - lat) + Math.Abs(-78.84606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83333 - lat) + Math.Abs(-80.27417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08703 - lat) + Math.Abs(-80.19158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51212 - lat) + Math.Abs(-82.61858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98025 - lat) + Math.Abs(-79.919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01319 - lat) + Math.Abs(-80.9859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82362 - lat) + Math.Abs(-80.55552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88028 - lat) + Math.Abs(-79.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96953 - lat) + Math.Abs(-80.88377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43916 - lat) + Math.Abs(-80.49005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98267 - lat) + Math.Abs(-80.76435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11865 - lat) + Math.Abs(-79.5366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05053 - lat) + Math.Abs(-80.32878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96766 - lat) + Math.Abs(-80.46523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75033 - lat) + Math.Abs(-80.59283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28415 - lat) + Math.Abs(-81.94633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17797 - lat) + Math.Abs(-79.25616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05 - lat) + Math.Abs(-79.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4624 - lat) + Math.Abs(-80.2828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79771 - lat) + Math.Abs(-82.42431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.51826 - lat) + Math.Abs(-78.16343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48361 - lat) + Math.Abs(-82.81641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43019 - lat) + Math.Abs(-78.5211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21444 - lat) + Math.Abs(-78.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31142 - lat) + Math.Abs(-82.15102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.65401 - lat) + Math.Abs(-81.20494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39813 - lat) + Math.Abs(-81.86525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91938 - lat) + Math.Abs(-79.73915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34981 - lat) + Math.Abs(-81.84503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39198 - lat) + Math.Abs(-81.8862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46847 - lat) + Math.Abs(-81.85714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33516 - lat) + Math.Abs(-81.9703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44281 - lat) + Math.Abs(-81.77196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51969 - lat) + Math.Abs(-80.58405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.19451 - lat) + Math.Abs(-80.75494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54828 - lat) + Math.Abs(-80.0135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62193 - lat) + Math.Abs(-82.57935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46205 - lat) + Math.Abs(-82.35727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34523 - lat) + Math.Abs(-82.53205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79404 - lat) + Math.Abs(-81.25904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.80023 - lat) + Math.Abs(-80.35983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81531 - lat) + Math.Abs(-80.28345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53006 - lat) + Math.Abs(-82.29959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85452 - lat) + Math.Abs(-79.81408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53733 - lat) + Math.Abs(-82.49281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.48968 - lat) + Math.Abs(-82.61279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46329 - lat) + Math.Abs(-80.26028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57466 - lat) + Math.Abs(-82.5373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41466 - lat) + Math.Abs(-78.45612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56085 - lat) + Math.Abs(-82.74142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15914 - lat) + Math.Abs(-80.25064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24346 - lat) + Math.Abs(-79.64856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53754 - lat) + Math.Abs(-80.95109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48333 - lat) + Math.Abs(-82.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.06684 - lat) + Math.Abs(-78.36436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.48157 - lat) + Math.Abs(-80.40695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3427 - lat) + Math.Abs(-82.87364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37979 - lat) + Math.Abs(-82.87385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66161 - lat) + Math.Abs(-79.87584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14373 - lat) + Math.Abs(-79.96439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.2363 - lat) + Math.Abs(-79.65986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11648 - lat) + Math.Abs(-80.98461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7511 - lat) + Math.Abs(-80.86943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42973 - lat) + Math.Abs(-82.57294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.37222 - lat) + Math.Abs(-82.52877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73885 - lat) + Math.Abs(-80.24854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56197 - lat) + Math.Abs(-82.67981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.1685 - lat) + Math.Abs(-80.65897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.18422 - lat) + Math.Abs(-81.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11923 - lat) + Math.Abs(-80.61707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48014 - lat) + Math.Abs(-80.15426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13 - lat) + Math.Abs(-77.71 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47102 - lat) + Math.Abs(-82.39352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.26667 - lat) + Math.Abs(-79.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23732 - lat) + Math.Abs(-81.50422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52146 - lat) + Math.Abs(-80.51681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37692 - lat) + Math.Abs(-80.79434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55276 - lat) + Math.Abs(-78.9523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.20942 - lat) + Math.Abs(-81.52706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95413 - lat) + Math.Abs(-81.07637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37803 - lat) + Math.Abs(-81.25621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35 - lat) + Math.Abs(-80.9762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93642 - lat) + Math.Abs(-80.63807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.69173 - lat) + Math.Abs(-80.32793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14176 - lat) + Math.Abs(-80.78242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53755 - lat) + Math.Abs(-81.06941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95342 - lat) + Math.Abs(-81.12154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94338 - lat) + Math.Abs(-80.5701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23811 - lat) + Math.Abs(-81.73218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47092 - lat) + Math.Abs(-79.96581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.67582 - lat) + Math.Abs(-80.3213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02905 - lat) + Math.Abs(-81.44384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03582 - lat) + Math.Abs(-81.21489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78245 - lat) + Math.Abs(-80.24713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35146 - lat) + Math.Abs(-81.88659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68489 - lat) + Math.Abs(-80.40309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05805 - lat) + Math.Abs(-80.77289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61685 - lat) + Math.Abs(-79.83483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44731 - lat) + Math.Abs(-80.03603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79316 - lat) + Math.Abs(-80.38267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8064 - lat) + Math.Abs(-80.52991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07842 - lat) + Math.Abs(-80.08316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24509 - lat) + Math.Abs(-79.69266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56802 - lat) + Math.Abs(-82.43929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35658 - lat) + Math.Abs(-80.13723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09286 - lat) + Math.Abs(-80.8238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.67605 - lat) + Math.Abs(-80.43896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83795 - lat) + Math.Abs(-79.84925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47761 - lat) + Math.Abs(-80.0128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.19378 - lat) + Math.Abs(-80.9577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.86667 - lat) + Math.Abs(-80.31936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5688 - lat) + Math.Abs(-80.20743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.41667 - lat) + Math.Abs(-82.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91634 - lat) + Math.Abs(-80.38686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25071 - lat) + Math.Abs(-80.62093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34556 - lat) + Math.Abs(-80.58721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.42661 - lat) + Math.Abs(-80.63311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62036 - lat) + Math.Abs(-80.58433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43773 - lat) + Math.Abs(-80.67929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87009 - lat) + Math.Abs(-79.80415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39716 - lat) + Math.Abs(-80.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32143 - lat) + Math.Abs(-80.92069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73697 - lat) + Math.Abs(-80.2798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94964 - lat) + Math.Abs(-79.54715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39876 - lat) + Math.Abs(-80.18721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68565 - lat) + Math.Abs(-80.65927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73124 - lat) + Math.Abs(-80.29691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.72571 - lat) + Math.Abs(-80.64349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.40195 - lat) + Math.Abs(-80.51791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61768 - lat) + Math.Abs(-80.23322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71843 - lat) + Math.Abs(-80.59757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76134 - lat) + Math.Abs(-80.01294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4457 - lat) + Math.Abs(-80.40938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58881 - lat) + Math.Abs(-82.62253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94858 - lat) + Math.Abs(-81.04838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40972 - lat) + Math.Abs(-80.45641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96059 - lat) + Math.Abs(-80.94801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15567 - lat) + Math.Abs(-80.69249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93344 - lat) + Math.Abs(-80.51358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69186 - lat) + Math.Abs(-82.51293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45797 - lat) + Math.Abs(-82.03081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35745 - lat) + Math.Abs(-81.36099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.7324 - lat) + Math.Abs(-79.88764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51191 - lat) + Math.Abs(-81.03646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55171 - lat) + Math.Abs(-82.39977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52834 - lat) + Math.Abs(-82.38677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56667 - lat) + Math.Abs(-82.41407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41066 - lat) + Math.Abs(-82.71332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42729 - lat) + Math.Abs(-82.43085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17823 - lat) + Math.Abs(-81.88484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.97092 - lat) + Math.Abs(-79.54612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.06896 - lat) + Math.Abs(-80.04878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57508 - lat) + Math.Abs(-78.25671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56667 - lat) + Math.Abs(-79.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35222 - lat) + Math.Abs(-79.90444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07712 - lat) + Math.Abs(-81.4399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70683 - lat) + Math.Abs(-82.60327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43701 - lat) + Math.Abs(-80.42251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56292 - lat) + Math.Abs(-79.89944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35451 - lat) + Math.Abs(-79.90011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.90007 - lat) + Math.Abs(-77.69274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.0754 - lat) + Math.Abs(-80.57177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.80817 - lat) + Math.Abs(-80.55607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45601 - lat) + Math.Abs(-80.42899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53606 - lat) + Math.Abs(-82.37547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50512 - lat) + Math.Abs(-82.35878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45317 - lat) + Math.Abs(-80.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.97206 - lat) + Math.Abs(-80.09209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59449 - lat) + Math.Abs(-80.27182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57555 - lat) + Math.Abs(-80.27161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39889 - lat) + Math.Abs(-80.54156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0762 - lat) + Math.Abs(-80.77656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8 - lat) + Math.Abs(-80.57451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84482 - lat) + Math.Abs(-80.72627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.86482 - lat) + Math.Abs(-82.56523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96082 - lat) + Math.Abs(-80.42944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94557 - lat) + Math.Abs(-82.11769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39291 - lat) + Math.Abs(-82.31993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69125 - lat) + Math.Abs(-78.6357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15093 - lat) + Math.Abs(-79.62098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.67187 - lat) + Math.Abs(-80.18975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53035 - lat) + Math.Abs(-80.35117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36667 - lat) + Math.Abs(-81.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35885 - lat) + Math.Abs(-81.66582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17019 - lat) + Math.Abs(-79.10083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95396 - lat) + Math.Abs(-79.12856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28628 - lat) + Math.Abs(-78.05185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43 - lat) + Math.Abs(-82.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57753 - lat) + Math.Abs(-79.88595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48899 - lat) + Math.Abs(-82.59834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25349 - lat) + Math.Abs(-81.57658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22818 - lat) + Math.Abs(-81.57421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84968 - lat) + Math.Abs(-82.57261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47733 - lat) + Math.Abs(-81.54585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28777 - lat) + Math.Abs(-81.36844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34777 - lat) + Math.Abs(-81.68926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83377 - lat) + Math.Abs(-80.83168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28523 - lat) + Math.Abs(-81.79804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31892 - lat) + Math.Abs(-81.56427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35174 - lat) + Math.Abs(-81.6105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70686 - lat) + Math.Abs(-79.91219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.02802 - lat) + Math.Abs(-79.90744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15735 - lat) + Math.Abs(-79.42097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74082 - lat) + Math.Abs(-79.85299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54026 - lat) + Math.Abs(-82.80022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15226 - lat) + Math.Abs(-82.2645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36218 - lat) + Math.Abs(-79.83232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5268 - lat) + Math.Abs(-81.87403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4646 - lat) + Math.Abs(-78.95931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75636 - lat) + Math.Abs(-79.87996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29858 - lat) + Math.Abs(-80.5548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53032 - lat) + Math.Abs(-82.8272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12472 - lat) + Math.Abs(-80.96374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84339 - lat) + Math.Abs(-81.81496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.22236 - lat) + Math.Abs(-78.89509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.89884 - lat) + Math.Abs(-78.22448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32004 - lat) + Math.Abs(-81.21152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14303 - lat) + Math.Abs(-80.71757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.517 - lat) + Math.Abs(-80.42916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74309 - lat) + Math.Abs(-82.91275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.44713 - lat) + Math.Abs(-80.2648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26534 - lat) + Math.Abs(-80.49105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38324 - lat) + Math.Abs(-81.99345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17272 - lat) + Math.Abs(-79.56212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78703 - lat) + Math.Abs(-81.21056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31886 - lat) + Math.Abs(-80.84067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95756 - lat) + Math.Abs(-81.38633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64907 - lat) + Math.Abs(-82.38058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24817 - lat) + Math.Abs(-81.08187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81143 - lat) + Math.Abs(-79.94738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62271 - lat) + Math.Abs(-80.23919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54162 - lat) + Math.Abs(-82.419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15559 - lat) + Math.Abs(-79.53974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.60898 - lat) + Math.Abs(-79.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57472 - lat) + Math.Abs(-79.92714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54703 - lat) + Math.Abs(-80.16756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03138 - lat) + Math.Abs(-80.63227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10863 - lat) + Math.Abs(-79.33694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54343 - lat) + Math.Abs(-80.19769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52143 - lat) + Math.Abs(-82.63638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48255 - lat) + Math.Abs(-82.61991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41774 - lat) + Math.Abs(-80.23462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63146 - lat) + Math.Abs(-79.94775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41384 - lat) + Math.Abs(-81.4844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27356 - lat) + Math.Abs(-79.69551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58536 - lat) + Math.Abs(-78.53008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62491 - lat) + Math.Abs(-82.81277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16933 - lat) + Math.Abs(-81.30071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78024 - lat) + Math.Abs(-82.44136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5051 - lat) + Math.Abs(-82.57025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24414 - lat) + Math.Abs(-80.85897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.34031 - lat) + Math.Abs(-82.24204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48973 - lat) + Math.Abs(-82.07136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.00796 - lat) + Math.Abs(-80.4532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18293 - lat) + Math.Abs(-80.19063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84517 - lat) + Math.Abs(-81.57265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35296 - lat) + Math.Abs(-82.11379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03003 - lat) + Math.Abs(-77.58978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21911 - lat) + Math.Abs(-82.21592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.18298 - lat) + Math.Abs(-81.22092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.89553 - lat) + Math.Abs(-81.85352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51486 - lat) + Math.Abs(-82.33361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37057 - lat) + Math.Abs(-80.25497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75 - lat) + Math.Abs(-80.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.60037 - lat) + Math.Abs(-79.88988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.63014 - lat) + Math.Abs(-80.38201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3 - lat) + Math.Abs(-82.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.34707 - lat) + Math.Abs(-82.2088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38937 - lat) + Math.Abs(-80.63546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.51984 - lat) + Math.Abs(-82.70424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4046 - lat) + Math.Abs(-80.77765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94814 - lat) + Math.Abs(-79.56672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.5436 - lat) + Math.Abs(-80.62505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.60463 - lat) + Math.Abs(-80.26016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.77058 - lat) + Math.Abs(-82.43306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.70517 - lat) + Math.Abs(-80.45342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14176 - lat) + Math.Abs(-81.89425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46399 - lat) + Math.Abs(-82.52617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.32481 - lat) + Math.Abs(-80.45361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04213 - lat) + Math.Abs(-80.92528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48257 - lat) + Math.Abs(-82.79086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95187 - lat) + Math.Abs(-79.66011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.97091 - lat) + Math.Abs(-79.96641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66269 - lat) + Math.Abs(-77.45142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03978 - lat) + Math.Abs(-79.95128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36865 - lat) + Math.Abs(-80.86268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39733 - lat) + Math.Abs(-80.26063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96015 - lat) + Math.Abs(-79.5514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53002 - lat) + Math.Abs(-80.62109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.80507 - lat) + Math.Abs(-82.47431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79947 - lat) + Math.Abs(-82.4348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84213 - lat) + Math.Abs(-79.84551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58792 - lat) + Math.Abs(-80.18443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28989 - lat) + Math.Abs(-81.67349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73458 - lat) + Math.Abs(-82.43213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30091 - lat) + Math.Abs(-82.4018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12016 - lat) + Math.Abs(-79.55641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39791 - lat) + Math.Abs(-82.55947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.2281 - lat) + Math.Abs(-78.02778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50351 - lat) + Math.Abs(-80.31169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24183 - lat) + Math.Abs(-80.54609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50486 - lat) + Math.Abs(-81.46397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46099 - lat) + Math.Abs(-82.45553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83465 - lat) + Math.Abs(-80.39405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19827 - lat) + Math.Abs(-77.98729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21121 - lat) + Math.Abs(-80.01338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93647 - lat) + Math.Abs(-78.90917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96861 - lat) + Math.Abs(-78.505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87962 - lat) + Math.Abs(-78.07689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33032 - lat) + Math.Abs(-79.79363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41482 - lat) + Math.Abs(-77.81161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08404 - lat) + Math.Abs(-77.53507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0254 - lat) + Math.Abs(-78.20927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02171 - lat) + Math.Abs(-78.20528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93942 - lat) + Math.Abs(-79.59097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98938 - lat) + Math.Abs(-81.32362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81141 - lat) + Math.Abs(-80.47029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78097 - lat) + Math.Abs(-80.53057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96099 - lat) + Math.Abs(-80.41283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50505 - lat) + Math.Abs(-80.20567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55006 - lat) + Math.Abs(-79.62221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18908 - lat) + Math.Abs(-79.62452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.1729 - lat) + Math.Abs(-79.54743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.09183 - lat) + Math.Abs(-79.51928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07939 - lat) + Math.Abs(-79.39556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10224 - lat) + Math.Abs(-79.416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79613 - lat) + Math.Abs(-80.25233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11178 - lat) + Math.Abs(-79.36113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.1021 - lat) + Math.Abs(-79.33414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15256 - lat) + Math.Abs(-79.17005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92132 - lat) + Math.Abs(-78.40546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58402 - lat) + Math.Abs(-78.38822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.828 - lat) + Math.Abs(-78.38435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64944 - lat) + Math.Abs(-78.13003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63528 - lat) + Math.Abs(-78.11292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29381 - lat) + Math.Abs(-78.10025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54518 - lat) + Math.Abs(-78.00797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14918 - lat) + Math.Abs(-77.69404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04171 - lat) + Math.Abs(-77.88682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.20108 - lat) + Math.Abs(-77.59637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85839 - lat) + Math.Abs(-78.1975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96817 - lat) + Math.Abs(-78.21648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83525 - lat) + Math.Abs(-78.65104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62483 - lat) + Math.Abs(-79.03748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15037 - lat) + Math.Abs(-82.05546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17471 - lat) + Math.Abs(-82.08041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28129 - lat) + Math.Abs(-82.26763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00308 - lat) + Math.Abs(-82.31476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28078 - lat) + Math.Abs(-82.41133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.38323 - lat) + Math.Abs(-82.65206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52757 - lat) + Math.Abs(-82.73344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.49587 - lat) + Math.Abs(-82.67534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71238 - lat) + Math.Abs(-80.74222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.72978 - lat) + Math.Abs(-82.89906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61903 - lat) + Math.Abs(-82.76392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50488 - lat) + Math.Abs(-82.77423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56516 - lat) + Math.Abs(-82.82214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46574 - lat) + Math.Abs(-82.84011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44778 - lat) + Math.Abs(-82.84256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43453 - lat) + Math.Abs(-82.86435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42891 - lat) + Math.Abs(-82.89726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30098 - lat) + Math.Abs(-82.85344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.29987 - lat) + Math.Abs(-82.87196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27417 - lat) + Math.Abs(-82.87252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38499 - lat) + Math.Abs(-82.81323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36725 - lat) + Math.Abs(-82.77959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33419 - lat) + Math.Abs(-82.81003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32458 - lat) + Math.Abs(-82.8157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53148 - lat) + Math.Abs(-82.50471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5155 - lat) + Math.Abs(-82.42263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45698 - lat) + Math.Abs(-82.43712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92046 - lat) + Math.Abs(-82.1806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8807 - lat) + Math.Abs(-82.22411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66427 - lat) + Math.Abs(-82.23196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84037 - lat) + Math.Abs(-81.99645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52995 - lat) + Math.Abs(-82.03132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.67457 - lat) + Math.Abs(-81.78586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35019 - lat) + Math.Abs(-81.80177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34298 - lat) + Math.Abs(-81.76618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31856 - lat) + Math.Abs(-81.75951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22919 - lat) + Math.Abs(-81.83278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23123 - lat) + Math.Abs(-81.82613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21238 - lat) + Math.Abs(-81.80797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55757 - lat) + Math.Abs(-81.72574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34751 - lat) + Math.Abs(-81.52912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.20617 - lat) + Math.Abs(-81.62123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24466 - lat) + Math.Abs(-81.65641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16247 - lat) + Math.Abs(-81.53917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84409 - lat) + Math.Abs(-82.82819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2906 - lat) + Math.Abs(-81.77047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31417 - lat) + Math.Abs(-82.88106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.71817 - lat) + Math.Abs(-81.40492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39898 - lat) + Math.Abs(-80.15731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74208 - lat) + Math.Abs(-80.18701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55119 - lat) + Math.Abs(-80.22623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54263 - lat) + Math.Abs(-80.40679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68361 - lat) + Math.Abs(-81.21608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51225 - lat) + Math.Abs(-81.36257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45977 - lat) + Math.Abs(-81.19592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53949 - lat) + Math.Abs(-81.48225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26152 - lat) + Math.Abs(-81.48412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85073 - lat) + Math.Abs(-79.82374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92874 - lat) + Math.Abs(-79.66831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6397 - lat) + Math.Abs(-79.8824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96105 - lat) + Math.Abs(-79.67876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.7995 - lat) + Math.Abs(-80.07747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zapotillo", "10", 8.00532, -81.50653);
case 1: return new CityInfo("Zangüengas", "13", 8.95609, -79.87037);
case 2: return new CityInfo("Yaviza", "05", 8.15835, -77.69276);
case 3: return new CityInfo("Yape", "11", 8.09839, -77.59817);
case 4: return new CityInfo("Volcán", "02", 8.77291, -82.63823);
case 5: return new CityInfo("Vista Hermosa", "03", 8.52687, -80.37486);
case 6: return new CityInfo("Vista Alegre", "13", 8.92772, -79.7028);
case 7: return new CityInfo("Villa Rosario", "13", 8.77379, -79.87547);
case 8: return new CityInfo("Villa Carmen", "13", 8.79832, -79.86929);
case 9: return new CityInfo("Villa Alondra", "04", 9.38695, -79.78159);
case 10: return new CityInfo("Viguí", "10", 8.33921, -81.49823);
case 11: return new CityInfo("Viento Frío", "04", 9.58263, -79.4069);
case 12: return new CityInfo("Veracruz", "13", 8.88988, -79.62603);
case 13: return new CityInfo("Veladero", "02", 8.43333, -82.56667);
case 14: return new CityInfo("Veladero", "02", 8.23136, -81.65417);
case 15: return new CityInfo("Vaquilla", "03", 8.69497, -80.19547);
case 16: return new CityInfo("Vallerriquito", "07", 7.62163, -80.31975);
case 17: return new CityInfo("Valle Rico", "07", 7.62011, -80.35076);
case 18: return new CityInfo("Utirá", "10", 7.97208, -81.21777);
case 19: return new CityInfo("Ustupo", "09", 9.13112, -77.9262);
case 20: return new CityInfo("Ualá", "05", 8.98572, -78.06078);
case 21: return new CityInfo("Turega", "03", 8.61223, -80.19467);
case 22: return new CityInfo("Tucutí", "05", 7.92794, -77.94562);
case 23: return new CityInfo("Tubualá", "09", 8.92098, -77.72394);
case 24: return new CityInfo("Tubualá", "09", 9.51667, -79.03333);
case 25: return new CityInfo("Tríbique", "10", 7.99498, -81.31518);
case 26: return new CityInfo("Tres Quebradas", "07", 7.84018, -80.4074);
case 27: return new CityInfo("Toza", "03", 8.34542, -80.64012);
case 28: return new CityInfo("Tonosí", "07", 7.40684, -80.44217);
case 29: return new CityInfo("Tolé", "02", 8.23989, -81.67168);
case 30: return new CityInfo("Tocumen", "08", 9.08939, -79.3831);
case 31: return new CityInfo("Tobobe", "12", 9.12111, -81.82471);
case 32: return new CityInfo("Toabré", "03", 8.65131, -80.32017);
case 33: return new CityInfo("Tinajas", "02", 8.55281, -82.45963);
case 34: return new CityInfo("Tijeras", "02", 8.47514, -82.56058);
case 35: return new CityInfo("Tebujo", "12", 8.38825, -81.72162);
case 36: return new CityInfo("Tebario", "10", 7.71369, -80.97825);
case 37: return new CityInfo("Tavidal Arriba", "03", 8.68226, -80.17536);
case 38: return new CityInfo("Tambo", "03", 8.66233, -80.29373);
case 39: return new CityInfo("Pueblo Nuevo", "05", 8.15036, -78.2503);
case 40: return new CityInfo("Taboga", "08", 8.79462, -79.55475);
case 41: return new CityInfo("Sortova", "02", 8.54642, -82.6517);
case 42: return new CityInfo("Sorá", "13", 8.63191, -80.00888);
case 43: return new CityInfo("Soná", "10", 8.01223, -81.32163);
case 44: return new CityInfo("Sofre", "03", 8.61542, -80.21667);
case 45: return new CityInfo("Sitio Prado", "12", 8.37233, -81.58141);
case 46: return new CityInfo("Sioguí Arriba", "02", 8.53865, -82.68619);
case 47: return new CityInfo("Sioguí Abajo", "02", 8.48678, -82.66539);
case 48: return new CityInfo("Sardinilla", "04", 9.29828, -79.63956);
case 49: return new CityInfo("San Vicente de Bique", "13", 8.91143, -79.6736);
case 50: return new CityInfo("San Vicente", "08", 9.11445, -79.59755);
case 51: return new CityInfo("San Vicente", "02", 8.59037, -82.63691);
case 52: return new CityInfo("Santo Tomás", "02", 8.38959, -82.65058);
case 53: return new CityInfo("Santo Domingo", "02", 8.50803, -82.71295);
case 54: return new CityInfo("Santo Domingo", "07", 7.74614, -80.24173);
case 55: return new CityInfo("Santiago de Veraguas", "10", 8.1, -80.98333);
case 56: return new CityInfo("Santa Rosa Número Uno", "13", 8.86459, -80.09923);
case 57: return new CityInfo("Santa Rosa", "02", 8.59958, -82.68489);
case 58: return new CityInfo("Santa Rita", "13", 8.85681, -79.87954);
case 59: return new CityInfo("Santa Rita", "03", 8.49307, -80.18298);
case 60: return new CityInfo("Santa Marta", "02", 8.51406, -82.6987);
case 61: return new CityInfo("Santa María", "06", 8.11143, -80.66582);
case 62: return new CityInfo("Santa Isabel", "04", 9.53922, -79.1957);
case 63: return new CityInfo("Santa Fé", "05", 8.65525, -78.1614);
case 64: return new CityInfo("Santa Fé", "10", 8.51063, -81.07802);
case 65: return new CityInfo("Santa Cruz", "02", 8.64269, -82.75939);
case 66: return new CityInfo("Santa Cruz", "02", 8.23219, -81.91323);
case 67: return new CityInfo("Santa Clara", "13", 9.02875, -79.75443);
case 68: return new CityInfo("Santa Clara", "02", 8.83376, -82.77945);
case 69: return new CityInfo("Santa Clara", "03", 8.38298, -80.10992);
case 70: return new CityInfo("Santa Catalina", "12", 8.78193, -81.3279);
case 71: return new CityInfo("Santa Catalina", "10", 7.6317, -81.25377);
case 72: return new CityInfo("Santa Ana Arriba", "07", 7.933, -80.36369);
case 73: return new CityInfo("San Pedro del Espino", "10", 8.14011, -81.08663);
case 74: return new CityInfo("San Pedro", "03", 8.72207, -80.22276);
case 75: return new CityInfo("San Pablo Viejo Arriba", "02", 8.48011, -82.50472);
case 76: return new CityInfo("San Pablo Viejo Abajo", "02", 8.45339, -82.50179);
case 77: return new CityInfo("San Pablo Nuevo Abajo", "02", 8.42558, -82.50173);
case 78: return new CityInfo("San Miguelito", "08", 9.05032, -79.47068);
case 79: return new CityInfo("San Miguel del Yuco", "02", 8.54614, -82.6256);
case 80: return new CityInfo("San Miguel", "08", 9.21574, -79.25559);
case 81: return new CityInfo("San Miguel", "08", 8.45685, -78.93695);
case 82: return new CityInfo("San Marcelo", "10", 8.27252, -81.15988);
case 83: return new CityInfo("San Lorenzo", "02", 8.30561, -82.10114);
case 84: return new CityInfo("San Juan del Tejal", "02", 8.48746, -82.49124);
case 85: return new CityInfo("San Juan", "10", 8.30311, -81.01575);
case 86: return new CityInfo("San Juan", "02", 8.27724, -81.99345);
case 87: return new CityInfo("San José", "13", 8.93333, -79.73333);
case 88: return new CityInfo("San José", "13", 8.5324, -79.93089);
case 89: return new CityInfo("San José", "10", 8.46704, -80.80514);
case 90: return new CityInfo("San José", "10", 8.37261, -81.40486);
case 91: return new CityInfo("San José", "06", 7.95188, -80.84757);
case 92: return new CityInfo("San José", "07", 7.67395, -80.24438);
case 93: return new CityInfo("San Ignacio de Tupile", "09", 9.28905, -78.15206);
case 94: return new CityInfo("San Francisco", "02", 8.63374, -82.72862);
case 95: return new CityInfo("San Francisco", "10", 8.24652, -80.97472);
case 96: return new CityInfo("San Francisco", "10", 8.06667, -81.36667);
case 97: return new CityInfo("San Félix", "02", 8.29063, -81.86702);
case 98: return new CityInfo("San Felipe", "08", 8.95118, -79.53726);
case 99: return new CityInfo("San Carlos", "02", 8.51663, -82.50906);
case 100: return new CityInfo("San Carlos", "13", 8.47323, -79.96104);
case 101: return new CityInfo("San Carlitos", "02", 8.48445, -82.45058);
case 102: return new CityInfo("San Bartolo", "10", 8.21063, -81.27572);
case 103: return new CityInfo("San Antonio", "10", 8.0729, -80.93187);
case 104: return new CityInfo("San Andrés", "02", 8.6026, -82.72588);
case 105: return new CityInfo("Salud", "04", 9.19841, -80.13186);
case 106: return new CityInfo("Salamanca", "04", 9.33518, -79.6039);
case 107: return new CityInfo("Sajalices", "08", 8.68188, -79.86764);
case 108: return new CityInfo("Sabanitas", "04", 9.34269, -79.80961);
case 109: return new CityInfo("Sabana Grande", "06", 7.88002, -80.63818);
case 110: return new CityInfo("Sabana Grande", "07", 7.83543, -80.3649);
case 111: return new CityInfo("Rovira Arriba", "02", 8.63822, -82.49965);
case 112: return new CityInfo("Rodeo Viejo", "10", 8.11205, -81.31684);
case 113: return new CityInfo("Valle del Risco", "01", 9.23064, -82.42748);
case 114: return new CityInfo("Río Sereno", "02", 8.81741, -82.85731);
case 115: return new CityInfo("Río Rita", "04", 9.30296, -79.79234);
case 116: return new CityInfo("Río Potrero", "13", 8.9618, -79.70074);
case 117: return new CityInfo("Río Hondo", "07", 7.71192, -80.35904);
case 118: return new CityInfo("Río Hato", "03", 8.3794, -80.16621);
case 119: return new CityInfo("Río Grande", "12", 8.61933, -81.2883);
case 120: return new CityInfo("Río Grande", "03", 8.42679, -80.48457);
case 121: return new CityInfo("Río Grande", "10", 7.71907, -81.33423);
case 122: return new CityInfo("Gatún", "04", 9.28922, -79.77204);
case 123: return new CityInfo("Río Duque", "04", 9.25688, -79.67937);
case 124: return new CityInfo("Río de Jesús", "10", 7.97882, -81.16162);
case 125: return new CityInfo("Río Congo", "13", 8.96666, -79.76105);
case 126: return new CityInfo("Río Alejandro", "04", 9.37149, -79.78809);
case 127: return new CityInfo("Río Abajo", "08", 9.01667, -79.5);
case 128: return new CityInfo("Rincón Largo", "02", 8.52065, -82.40654);
case 129: return new CityInfo("Rincón Largo", "10", 7.94594, -81.06703);
case 130: return new CityInfo("Rincón Hondo", "06", 7.84436, -80.60397);
case 131: return new CityInfo("Rincón de Las Palmas", "03", 8.55551, -80.25);
case 132: return new CityInfo("Rincón", "02", 8.46374, -82.27951);
case 133: return new CityInfo("Remedios", "02", 8.22436, -81.82747);
case 134: return new CityInfo("Rancho Café", "08", 9.12483, -79.37261);
case 135: return new CityInfo("Panama City", "04", 9.33404, -79.89172);
case 136: return new CityInfo("Querévalo", "02", 8.37174, -82.5267);
case 137: return new CityInfo("Quebrada Pastor", "01", 9.21012, -82.36081);
case 138: return new CityInfo("Quebrada de Piedra", "02", 8.09418, -81.67915);
case 139: return new CityInfo("Quebrada de Oro", "10", 8.03548, -81.38692);
case 140: return new CityInfo("Quebrada de Loro", "12", 8.35924, -81.92724);
case 141: return new CityInfo("Quebrada Canoa", "12", 8.43333, -81.78333);
case 142: return new CityInfo("Quebrada Bonita Adentro", "04", 9.29662, -79.70606);
case 143: return new CityInfo("Punta Róbalo", "01", 9.03631, -82.24952);
case 144: return new CityInfo("Punta Laurel", "01", 9.141, -82.12717);
case 145: return new CityInfo("Punta Peña", "01", 8.91659, -82.18488);
case 146: return new CityInfo("Punta Delgadita", "10", 8.10953, -80.94487);
case 147: return new CityInfo("Punta de Burica", "02", 8.03333, -82.86667);
case 148: return new CityInfo("Punta Alegre", "05", 8.29525, -78.25409);
case 149: return new CityInfo("Puerto Vidal", "10", 8.04834, -81.60499);
case 150: return new CityInfo("Puerto Piña", "05", 7.58297, -78.17777);
case 151: return new CityInfo("Puerto Pilón", "04", 9.36316, -79.79333);
case 152: return new CityInfo("Puerto Obaldía", "09", 8.66632, -77.41922);
case 153: return new CityInfo("Puerto Escondido", "04", 9.19333, -80.08833);
case 154: return new CityInfo("Puerto Caimito", "13", 8.87022, -79.71423);
case 155: return new CityInfo("Puerto Armuelles", "02", 8.27775, -82.86206);
case 156: return new CityInfo("Pueblo Viejo", "02", 8.25081, -81.66259);
case 157: return new CityInfo("Pueblo Nuevo", "02", 8.58399, -82.42282);
case 158: return new CityInfo("Pueblo Nuevo", "03", 8.38671, -80.20231);
case 159: return new CityInfo("Pueblo Nuevo", "02", 8.3, -82.1);
case 160: return new CityInfo("Pueblito", "02", 8.26132, -81.97411);
case 161: return new CityInfo("Púcuro", "05", 7.97876, -77.48758);
case 162: return new CityInfo("Progreso", "02", 8.44669, -82.83859);
case 163: return new CityInfo("Potuga", "06", 8.06317, -80.62271);
case 164: return new CityInfo("Potrero Grande", "13", 8.88051, -79.82795);
case 165: return new CityInfo("Potrero de Caña", "02", 8.29345, -81.69903);
case 166: return new CityInfo("Potrerillos Arriba", "02", 8.68547, -82.4909);
case 167: return new CityInfo("Potrerillos Abajo", "02", 8.63978, -82.4856);
case 168: return new CityInfo("Portón", "02", 8.56125, -82.78503);
case 169: return new CityInfo("Portobelo", "04", 9.55303, -79.65693);
case 170: return new CityInfo("Portobelillo", "06", 8.01738, -80.59538);
case 171: return new CityInfo("Portachuelo", "02", 8.47285, -82.41934);
case 172: return new CityInfo("Ponuga", "10", 7.88245, -80.9788);
case 173: return new CityInfo("Pocrí", "03", 8.25814, -80.55);
case 174: return new CityInfo("Pocrí", "07", 7.65816, -80.12119);
case 175: return new CityInfo("Plaza de Caisán", "02", 8.73672, -82.81968);
case 176: return new CityInfo("Playón Chico", "09", 9.31128, -78.2327);
case 177: return new CityInfo("Playa Leona", "13", 8.78389, -79.77547);
case 178: return new CityInfo("Playa Chiquita", "04", 9.5662, -79.29185);
case 179: return new CityInfo("Plan de Chorcha", "12", 8.46168, -82.15924);
case 180: return new CityInfo("Pinogana", "05", 8.11301, -77.68851);
case 181: return new CityInfo("Piedras Gordas", "03", 8.63777, -80.51024);
case 182: return new CityInfo("Piedras Gordas", "10", 8.52419, -80.91152);
case 183: return new CityInfo("Piedra Roja", "12", 8.5703, -81.74661);
case 184: return new CityInfo("Piedra Candela", "02", 8.8811, -82.75391);
case 185: return new CityInfo("Pesé", "06", 7.90863, -80.61433);
case 186: return new CityInfo("Perales", "07", 7.77461, -80.32494);
case 187: return new CityInfo("Penonomé", "03", 8.51889, -80.35727);
case 188: return new CityInfo("Peñas Chatas", "06", 8.01502, -80.80366);
case 189: return new CityInfo("Peña Prieta", "12", 8.37056, -81.71709);
case 190: return new CityInfo("Peña Blanca", "12", 8.46171, -81.6788);
case 191: return new CityInfo("Peña Blanca", "07", 7.71931, -80.28366);
case 192: return new CityInfo("Pedregal", "08", 9.06667, -79.43333);
case 193: return new CityInfo("Pedregal", "02", 8.36586, -82.43524);
case 194: return new CityInfo("Pedasí", "07", 7.53034, -80.02699);
case 195: return new CityInfo("Paya", "05", 7.90071, -77.38965);
case 196: return new CityInfo("Paso Blanco", "08", 9.12767, -79.24468);
case 197: return new CityInfo("Parque Lefevre", "08", 9.01667, -79.48333);
case 198: return new CityInfo("Paritilla", "07", 7.62848, -80.1724);
case 199: return new CityInfo("Parita", "06", 7.99393, -80.52097);
case 200: return new CityInfo("París", "06", 8.05053, -80.55409);
case 201: return new CityInfo("Paraíso", "08", 9.03315, -79.62749);
case 202: return new CityInfo("Paraíso", "02", 8.65842, -82.58625);
case 203: return new CityInfo("Paraíso", "07", 7.6851, -80.16082);
case 204: return new CityInfo("Panamá", "08", 8.9936, -79.51973);
case 205: return new CityInfo("Palo Verde", "03", 8.38779, -80.19722);
case 206: return new CityInfo("Palo Grande", "02", 8.34654, -82.60589);
case 207: return new CityInfo("Palmarito", "02", 8.8178, -82.82489);
case 208: return new CityInfo("Palmira Centro", "02", 8.73956, -82.45228);
case 209: return new CityInfo("Palmira", "04", 9.54359, -79.21946);
case 210: return new CityInfo("Palmira", "02", 8.73401, -82.45887);
case 211: return new CityInfo("Palmira", "07", 7.66347, -80.35728);
case 212: return new CityInfo("Palmas Bellas", "04", 9.22838, -80.08503);
case 213: return new CityInfo("Palenque", "04", 9.5697, -79.36341);
case 214: return new CityInfo("Palenque", "04", 9.20658, -79.68089);
case 215: return new CityInfo("Pajonal Abajo", "03", 8.58529, -80.25832);
case 216: return new CityInfo("Paja de Sombrero", "02", 8.68335, -82.31911);
case 217: return new CityInfo("Pacora", "08", 9.07937, -79.28997);
case 218: return new CityInfo("Orillas del Río", "02", 8.36119, -82.50791);
case 219: return new CityInfo("Olá", "03", 8.41807, -80.65123);
case 220: return new CityInfo("Ocú", "06", 7.94052, -80.77936);
case 221: return new CityInfo("Nutiví", "12", 8.87064, -81.84103);
case 222: return new CityInfo("Nuevo Vigía", "04", 9.24263, -79.60756);
case 223: return new CityInfo("Nuevo San Juan", "04", 9.22205, -79.66602);
case 224: return new CityInfo("Nuevo Guararé", "13", 8.93333, -79.71667);
case 225: return new CityInfo("Nuevo Emperador", "13", 9.00273, -79.73141);
case 226: return new CityInfo("Nuevo Chagres", "04", 9.23979, -80.08267);
case 227: return new CityInfo("Nuevo Arraiján", "13", 8.92453, -79.72004);
case 228: return new CityInfo("Nueva Providencia", "04", 9.26333, -79.81556);
case 229: return new CityInfo("Nueva Gorgona", "13", 8.55, -79.87547);
case 230: return new CityInfo("Nueva Arenosa", "13", 8.86944, -79.99472);
case 231: return new CityInfo("Nuestro Amo", "03", 8.44485, -80.58934);
case 232: return new CityInfo("Nuario", "07", 7.53047, -80.32692);
case 233: return new CityInfo("Nombre de Dios", "04", 9.57937, -79.47109);
case 234: return new CityInfo("Natá", "03", 8.33209, -80.51969);
case 235: return new CityInfo("Narganá", "09", 9.44394, -78.58666);
case 236: return new CityInfo("Naranjal", "08", 9.12832, -79.23111);
case 237: return new CityInfo("Mulatupo", "09", 8.94672, -77.7508);
case 238: return new CityInfo("Mortí", "05", 8.84246, -77.97539);
case 239: return new CityInfo("Mortí", "05", 8.85266, -77.9169);
case 240: return new CityInfo("Montilla", "02", 8.46402, -82.47935);
case 241: return new CityInfo("Montijo", "10", 7.98858, -81.05643);
case 242: return new CityInfo("Monte Lirio", "02", 8.78935, -82.82865);
case 243: return new CityInfo("La Montañuela", "10", 8.02487, -80.86325);
case 244: return new CityInfo("Monjarás", "10", 8.36942, -80.86667);
case 245: return new CityInfo("Monagrillo", "06", 7.98179, -80.43764);
case 246: return new CityInfo("Mogollón", "07", 7.64261, -80.4595);
case 247: return new CityInfo("Mocambo Arriba", "08", 9.07436, -79.56736);
case 248: return new CityInfo("Miramar", "04", 9.57544, -79.33573);
case 249: return new CityInfo("Miramar", "01", 8.99482, -82.24147);
case 250: return new CityInfo("Miraflores", "03", 8.62507, -80.27693);
case 251: return new CityInfo("Miguel de La Borda", "04", 9.14544, -80.30124);
case 252: return new CityInfo("Metetí", "05", 8.49909, -77.97897);
case 253: return new CityInfo("Mendoza", "13", 9.01471, -79.85073);
case 254: return new CityInfo("Membrillo", "03", 8.58173, -80.21294);
case 255: return new CityInfo("Mata del Nance", "02", 8.45056, -82.40057);
case 256: return new CityInfo("Mata Ahogado", "13", 8.6172, -80.09449);
case 257: return new CityInfo("María Chiquita", "04", 9.43991, -79.75455);
case 258: return new CityInfo("Mariabé", "07", 7.58265, -80.0661);
case 259: return new CityInfo("Las Margaritas", "04", 9.32603, -79.89028);
case 260: return new CityInfo("Maraca", "12", 8.37302, -81.72741);
case 261: return new CityInfo("Majagual", "02", 8.33891, -82.76791);
case 262: return new CityInfo("Mague", "02", 8.66766, -82.36335);
case 263: return new CityInfo("Machuca", "03", 8.62182, -80.54819);
case 264: return new CityInfo("Macaracas", "07", 7.73168, -80.55364);
case 265: return new CityInfo("Los Valles", "10", 8.44851, -81.19886);
case 266: return new CityInfo("Los Uveros", "03", 8.52866, -80.39518);
case 267: return new CityInfo("Los Santos", "07", 7.93333, -80.41667);
case 268: return new CityInfo("Los Remedios", "10", 8.13974, -81.02417);
case 269: return new CityInfo("Los Pozos", "06", 7.783, -80.64524);
case 270: return new CityInfo("Los Olivos", "07", 7.91589, -80.48884);
case 271: return new CityInfo("Los Naranjos", "02", 8.7921, -82.44665);
case 272: return new CityInfo("Los Lotes", "08", 9.12425, -79.28929);
case 273: return new CityInfo("Los Llanitos", "13", 8.59787, -80.09503);
case 274: return new CityInfo("Los Higos", "10", 8.20553, -80.86022);
case 275: return new CityInfo("Los Hatillos", "06", 7.93046, -80.5382);
case 276: return new CityInfo("Los Corotúes", "10", 8.42014, -81.10421);
case 277: return new CityInfo("Los Chiricanos", "01", 8.97805, -82.21438);
case 278: return new CityInfo("Los Cerros de Paja", "06", 7.71821, -80.67273);
case 279: return new CityInfo("Los Cerritos", "06", 7.79746, -80.61071);
case 280: return new CityInfo("Los Castillos", "10", 8.02326, -81.11941);
case 281: return new CityInfo("Los Castillos", "06", 7.98565, -80.61886);
case 282: return new CityInfo("Los Canelos", "06", 8.11722, -80.70769);
case 283: return new CityInfo("Los Boquerones", "10", 8.07912, -80.85494);
case 284: return new CityInfo("Los Asientos", "07", 7.51656, -80.13521);
case 285: return new CityInfo("Los Ángeles", "02", 8.52271, -82.19997);
case 286: return new CityInfo("Los Ángeles", "07", 7.88422, -80.35772);
case 287: return new CityInfo("Los Anastacios", "02", 8.53027, -82.42295);
case 288: return new CityInfo("Los Algarrobos", "02", 8.49601, -82.42417);
case 289: return new CityInfo("Los Algarrobos", "10", 8.10898, -81.01355);
case 290: return new CityInfo("Loma de San Pedro", "02", 8.42577, -82.55212);
case 291: return new CityInfo("Lolá", "10", 8.09326, -81.47163);
case 292: return new CityInfo("Buabidi", "12", 8.47457, -81.69827);
case 293: return new CityInfo("Llano Sánchez", "03", 8.1989, -80.70458);
case 294: return new CityInfo("Llano Ñopo", "12", 8.41996, -81.61865);
case 295: return new CityInfo("Llano Marín", "03", 8.47696, -80.32499);
case 296: return new CityInfo("Llano Largo", "13", 8.83463, -79.80765);
case 297: return new CityInfo("Llano Largo", "07", 7.90607, -80.42561);
case 298: return new CityInfo("Llano Junco", "12", 8.35317, -81.75445);
case 299: return new CityInfo("Llano Grande", "03", 8.63817, -80.43848);
case 300: return new CityInfo("Llano Grande", "08", 8.62787, -79.93129);
case 301: return new CityInfo("Llano Grande", "03", 8.45053, -80.22676);
case 302: return new CityInfo("Llano Grande", "10", 8.07473, -81.13626);
case 303: return new CityInfo("Llano Grande", "06", 7.97406, -80.71103);
case 304: return new CityInfo("Llano de Santa Rosa", "13", 8.76059, -79.86309);
case 305: return new CityInfo("Llano de Piedra", "07", 7.65972, -80.56347);
case 306: return new CityInfo("Llano de La Cruz", "06", 7.95178, -80.64239);
case 307: return new CityInfo("Llano Bonito", "06", 7.97637, -80.41646);
case 308: return new CityInfo("Llano Abajo", "07", 7.78598, -80.4106);
case 309: return new CityInfo("Limones", "02", 8.10007, -82.86679);
case 310: return new CityInfo("Limón de Tijeras", "06", 7.81756, -80.91335);
case 311: return new CityInfo("Lídice", "08", 8.74869, -79.90974);
case 312: return new CityInfo("Leones Arriba", "06", 7.7659, -80.84515);
case 313: return new CityInfo("Leones Arriba", "10", 7.75415, -81.11556);
case 314: return new CityInfo("La Yeguada", "10", 8.4306, -80.85752);
case 315: return new CityInfo("La Tronosa", "07", 7.43609, -80.58698);
case 316: return new CityInfo("La Trinidad", "06", 7.91457, -80.70332);
case 317: return new CityInfo("La Tiza", "07", 7.7511, -80.29216);
case 318: return new CityInfo("Las Uvas", "13", 8.45937, -80.00075);
case 319: return new CityInfo("Las Trancas", "07", 7.734, -80.37384);
case 320: return new CityInfo("Las Tablas", "07", 7.76472, -80.27483);
case 321: return new CityInfo("Las Sabanas", "03", 8.58141, -80.67978);
case 322: return new CityInfo("Las Palmitas", "07", 7.76523, -80.2935);
case 323: return new CityInfo("Las Palmas", "10", 8.13564, -81.45674);
case 324: return new CityInfo("Las Palmas", "07", 7.68314, -80.49728);
case 325: return new CityInfo("Sonadora", "03", 8.55167, -80.32749);
case 326: return new CityInfo("Las Ollas Arriba", "13", 8.80675, -79.91311);
case 327: return new CityInfo("Las Ollas Abajo", "13", 8.84167, -79.91073);
case 328: return new CityInfo("La Soledad", "10", 8.13553, -80.99047);
case 329: return new CityInfo("La Soledad", "10", 7.87899, -81.27611);
case 330: return new CityInfo("Las Minas", "03", 8.64118, -80.39432);
case 331: return new CityInfo("Las Minas", "06", 7.79581, -80.7457);
case 332: return new CityInfo("Las Matas", "03", 8.46915, -80.09204);
case 333: return new CityInfo("Las Matas", "02", 8.2995, -81.86605);
case 334: return new CityInfo("Las Marias", "03", 8.88809, -80.21893);
case 335: return new CityInfo("Las Margaritas", "08", 9.18426, -79.0873);
case 336: return new CityInfo("Las Lomas", "03", 8.50818, -80.37381);
case 337: return new CityInfo("Las Lomas", "02", 8.42927, -82.38743);
case 338: return new CityInfo("Lajas de Tolé", "02", 8.16994, -81.69654);
case 339: return new CityInfo("Las Lajas", "13", 8.54963, -79.93521);
case 340: return new CityInfo("Las Lajas", "02", 8.24184, -81.86931);
case 341: return new CityInfo("Las Huacas del Quije", "03", 8.46702, -80.75089);
case 342: return new CityInfo("Las Huacas", "10", 7.90167, -81.14056);
case 343: return new CityInfo("Las Guabas", "03", 8.386, -80.44733);
case 344: return new CityInfo("Las Guabas", "06", 7.90949, -80.80706);
case 345: return new CityInfo("Las Guabas", "07", 7.81469, -80.50155);
case 346: return new CityInfo("Las Delicias", "03", 8.54151, -80.36533);
case 347: return new CityInfo("Las Cumbres", "08", 9.08916, -79.52809);
case 348: return new CityInfo("Altos de San Francisco", "13", 8.86167, -79.79);
case 349: return new CityInfo("Las Cruces", "07", 7.82285, -80.43003);
case 350: return new CityInfo("Las Colinas", "13", 8.55, -80.08333);
case 351: return new CityInfo("Las Cabras", "06", 7.87561, -80.54912);
case 352: return new CityInfo("Las Barreras", "10", 8.10475, -80.99738);
case 353: return new CityInfo("Salitrosa", "03", 8.21054, -80.63837);
case 354: return new CityInfo("La Raya de Santa María", "10", 8.16429, -80.82143);
case 355: return new CityInfo("La Raya de Calobre", "10", 8.2163, -80.82729);
case 356: return new CityInfo("La Punta", "10", 7.55702, -81.19109);
case 357: return new CityInfo("Pitaloza Arriba", "06", 7.64216, -80.66788);
case 358: return new CityInfo("La Pita", "13", 8.8191, -79.84962);
case 359: return new CityInfo("La Pintada", "03", 8.59299, -80.44349);
case 360: return new CityInfo("La Peña", "10", 8.12784, -81.02693);
case 361: return new CityInfo("La Pasera", "07", 7.79757, -80.30342);
case 362: return new CityInfo("La Palma", "05", 8.40608, -78.13964);
case 363: return new CityInfo("La Palma", "07", 7.71667, -80.38333);
case 364: return new CityInfo("La Palma", "07", 7.68864, -80.19647);
case 365: return new CityInfo("La Mitra", "13", 8.84091, -79.78648);
case 366: return new CityInfo("La Miel", "07", 7.56022, -80.32736);
case 367: return new CityInfo("La Meseta", "02", 8.5532, -82.59489);
case 368: return new CityInfo("La Mesa", "08", 9.17308, -79.27401);
case 369: return new CityInfo("La Mesa", "10", 8.14707, -81.18114);
case 370: return new CityInfo("La Mesa", "07", 7.6567, -80.61794);
case 371: return new CityInfo("La Mata", "10", 8.08944, -80.87963);
case 372: return new CityInfo("La Loma", "03", 8.16667, -80.63742);
case 373: return new CityInfo("La Loma", "10", 7.43708, -80.89118);
case 374: return new CityInfo("La Laja", "07", 7.73102, -80.25298);
case 375: return new CityInfo("La Laguna", "13", 9.04404, -79.84215);
case 376: return new CityInfo("La Laguna", "13", 8.60409, -80.04716);
case 377: return new CityInfo("La Laguna", "10", 8.33882, -80.72949);
case 378: return new CityInfo("Lajas Adentro", "02", 8.24981, -81.87779);
case 379: return new CityInfo("Lajamina", "07", 7.58587, -80.13212);
case 380: return new CityInfo("La Herradura", "13", 8.84848, -79.80404);
case 381: return new CityInfo("La Guinea", "08", 8.3425, -78.9343);
case 382: return new CityInfo("Lagarterita", "13", 9.07944, -79.91389);
case 383: return new CityInfo("La Garceana", "10", 7.93708, -81.01643);
case 384: return new CityInfo("La Estrella", "02", 8.51572, -82.67212);
case 385: return new CityInfo("La Espigadilla", "07", 7.88389, -80.39039);
case 386: return new CityInfo("La Esperanza", "02", 8.40344, -82.79197);
case 387: return new CityInfo("La Esmeralda", "08", 8.26817, -78.9246);
case 388: return new CityInfo("La Ermita", "13", 8.45622, -80.06835);
case 389: return new CityInfo("La Ensenada", "08", 8.36618, -78.84606);
case 390: return new CityInfo("La Enea", "07", 7.83333, -80.27417);
case 391: return new CityInfo("La Encantada", "04", 9.08703, -80.19158);
case 392: return new CityInfo("La Concepción", "02", 8.51212, -82.61858);
case 393: return new CityInfo("La Colorada", "13", 8.98025, -79.919);
case 394: return new CityInfo("La Colorada", "10", 8.01319, -80.9859);
case 395: return new CityInfo("La Colorada", "07", 7.82362, -80.55552);
case 396: return new CityInfo("La Chorrera", "13", 8.88028, -79.78333);
case 397: return new CityInfo("La Carrillo", "10", 7.96953, -80.88377);
case 398: return new CityInfo("La Candelaria", "03", 8.43916, -80.49005);
case 399: return new CityInfo("Cabuya", "06", 7.98267, -80.76435);
case 400: return new CityInfo("La Cabima", "08", 9.11865, -79.5366);
case 401: return new CityInfo("Boca del Guásimo", "04", 9.05053, -80.32878);
case 402: return new CityInfo("La Arena", "06", 7.96766, -80.46523);
case 403: return new CityInfo("La Arena", "06", 7.75033, -80.59283);
case 404: return new CityInfo("Juay", "02", 8.28415, -81.94633);
case 405: return new CityInfo("Juan Gil", "08", 9.17797, -79.25616);
case 406: return new CityInfo("Juan Díaz", "08", 9.05, -79.45);
case 407: return new CityInfo("Juan Díaz", "03", 8.4624, -80.2828);
case 408: return new CityInfo("Jaramillo Arriba", "02", 8.79771, -82.42431);
case 409: return new CityInfo("Jaqué", "05", 7.51826, -78.16343);
case 410: return new CityInfo("Jacú", "02", 8.48361, -82.81641);
case 411: return new CityInfo("Isla Tigre", "09", 9.43019, -78.5211);
case 412: return new CityInfo("Icantí", "08", 9.21444, -78.68333);
case 413: return new CityInfo("Horconcitos", "02", 8.31142, -82.15102);
case 414: return new CityInfo("Hicaco", "10", 7.65401, -81.20494);
case 415: return new CityInfo("Hato Pilón", "12", 8.39813, -81.86525);
case 416: return new CityInfo("Hato Montaña", "13", 8.91938, -79.73915);
case 417: return new CityInfo("Hato Juli", "12", 8.34981, -81.84503);
case 418: return new CityInfo("Hato Jobo", "12", 8.39198, -81.8862);
case 419: return new CityInfo("Hato Culantro", "12", 8.46847, -81.85714);
case 420: return new CityInfo("Hato Corotú", "12", 8.33516, -81.9703);
case 421: return new CityInfo("Hato Chami", "12", 8.44281, -81.77196);
case 422: return new CityInfo("Guzman", "03", 8.51969, -80.58405);
case 423: return new CityInfo("Las Guías Abajo", "10", 8.19451, -80.75494);
case 424: return new CityInfo("Guayabito", "13", 8.54828, -80.0135);
case 425: return new CityInfo("Guayabal", "02", 8.62193, -82.57935);
case 426: return new CityInfo("Guayabal", "02", 8.46205, -82.35727);
case 427: return new CityInfo("Guarumal", "02", 8.34523, -82.53205);
case 428: return new CityInfo("Guarumal", "10", 7.79404, -81.25904);
case 429: return new CityInfo("Guararé Arriba", "07", 7.80023, -80.35983);
case 430: return new CityInfo("Guararé", "07", 7.81531, -80.28345);
case 431: return new CityInfo("Gualaca", "02", 8.53006, -82.29959);
case 432: return new CityInfo("Guadalupe", "13", 8.85452, -79.81408);
case 433: return new CityInfo("Guaca Arriba", "02", 8.53733, -82.49281);
case 434: return new CityInfo("Guabito", "01", 9.48968, -82.61279);
case 435: return new CityInfo("Guabas Arriba", "03", 8.46329, -80.26028);
case 436: return new CityInfo("Guabal", "02", 8.57466, -82.5373);
case 437: return new CityInfo("Gonzalo Vásquez", "08", 8.41466, -78.45612);
case 438: return new CityInfo("Gómez", "02", 8.56085, -82.74142);
case 439: return new CityInfo("Gobea", "04", 9.15914, -80.25064);
case 440: return new CityInfo("Gatuncillo", "04", 9.24346, -79.64856);
case 441: return new CityInfo("Gatú", "10", 8.53754, -80.95109);
case 442: return new CityInfo("Gariché", "02", 8.48333, -82.78333);
case 443: return new CityInfo("Garachiné", "05", 8.06684, -78.36436);
case 444: return new CityInfo("Flores", "07", 7.48157, -80.40695);
case 445: return new CityInfo("Finca Corredor", "02", 8.3427, -82.87364);
case 446: return new CityInfo("Finca Blanco", "02", 8.37979, -82.87385);
case 447: return new CityInfo("El Espavé", "13", 8.66161, -79.87584);
case 448: return new CityInfo("Escobal", "04", 9.14373, -79.96439);
case 449: return new CityInfo("El Valle de la Unión", "04", 9.2363, -79.65986);
case 450: return new CityInfo("El Uvito", "10", 8.11648, -80.98461);
case 451: return new CityInfo("El Toro", "06", 7.7511, -80.86943);
case 452: return new CityInfo("El Tejar", "02", 8.42973, -82.57294);
case 453: return new CityInfo("El Silencio", "01", 9.37222, -82.52877);
case 454: return new CityInfo("Sesteadero", "07", 7.73885, -80.24854);
case 455: return new CityInfo("El Santo", "02", 8.56197, -82.67981);
case 456: return new CityInfo("El Roble", "03", 8.1685, -80.65897);
case 457: return new CityInfo("El Rincón", "10", 8.18422, -81.43333);
case 458: return new CityInfo("El Rincón", "06", 8.11923, -80.61707);
case 459: return new CityInfo("El Retiro", "03", 8.48014, -80.15426);
case 460: return new CityInfo("El Real de Santa María", "05", 8.13, -77.71);
case 461: return new CityInfo("Quinteño", "02", 8.47102, -82.39352);
case 462: return new CityInfo("El Progreso", "08", 9.26667, -79.11667);
case 463: return new CityInfo("El Prado", "10", 8.23732, -81.50422);
case 464: return new CityInfo("El Potrero", "03", 8.52146, -80.51681);
case 465: return new CityInfo("El Potrero", "10", 8.37692, -80.79434);
case 466: return new CityInfo("El Porvenir", "09", 9.55276, -78.9523);
case 467: return new CityInfo("El Piro", "10", 8.20942, -81.52706);
case 468: return new CityInfo("El Pilón", "10", 7.95413, -81.07637);
case 469: return new CityInfo("El Picador", "10", 8.37803, -81.25621);
case 470: return new CityInfo("El Peñón", "10", 8.35, -80.9762);
case 471: return new CityInfo("El Pedregoso", "06", 7.93642, -80.63807);
case 472: return new CityInfo("El Pedregoso", "07", 7.69173, -80.32793);
case 473: return new CityInfo("El Pedernal", "10", 8.14176, -80.78242);
case 474: return new CityInfo("El Pantano", "10", 8.53755, -81.06941);
case 475: return new CityInfo("El Pájaro", "10", 7.95342, -81.12154);
case 476: return new CityInfo("El Pájaro", "06", 7.94338, -80.5701);
case 477: return new CityInfo("El Nancito", "02", 8.23811, -81.73218);
case 478: return new CityInfo("El Nance", "13", 8.47092, -79.96581);
case 479: return new CityInfo("El Muñoz", "07", 7.67582, -80.3213);
case 480: return new CityInfo("El María", "10", 8.02905, -81.44384);
case 481: return new CityInfo("El Marañón", "10", 8.03582, -81.21489);
case 482: return new CityInfo("El Manantial", "07", 7.78245, -80.24713);
case 483: return new CityInfo("Salto Dupí", "12", 8.35146, -81.88659);
case 484: return new CityInfo("El Macano", "07", 7.68489, -80.40309);
case 485: return new CityInfo("El Limón", "06", 8.05805, -80.77289);
case 486: return new CityInfo("El Líbano", "13", 8.61685, -79.83483);
case 487: return new CityInfo("El Higo", "13", 8.44731, -80.03603);
case 488: return new CityInfo("El Hato", "07", 7.79316, -80.38267);
case 489: return new CityInfo("El Guásimo", "07", 7.8064, -80.52991);
case 490: return new CityInfo("El Guabo", "04", 9.07842, -80.08316);
case 491: return new CityInfo("El Giral", "04", 9.24509, -79.69266);
case 492: return new CityInfo("El Flor", "02", 8.56802, -82.43929);
case 493: return new CityInfo("Farallón", "03", 8.35658, -80.13723);
case 494: return new CityInfo("El Espino de Santa Rosa", "10", 8.09286, -80.8238);
case 495: return new CityInfo("El Espino Amarillo", "07", 7.67605, -80.43896);
case 496: return new CityInfo("El Espino", "13", 8.83795, -79.84925);
case 497: return new CityInfo("El Espino", "13", 8.47761, -80.0128);
case 498: return new CityInfo("El Espino", "10", 8.19378, -80.9577);
case 499: return new CityInfo("El Espinal", "07", 7.86667, -80.31936);
case 500: return new CityInfo("Entradero", "03", 8.5688, -80.20743);
case 501: return new CityInfo("El Empalme", "01", 9.41667, -82.51667);
case 502: return new CityInfo("El Ejido", "07", 7.91634, -80.38686);
case 503: return new CityInfo("El Cristo", "03", 8.25071, -80.62093);
case 504: return new CityInfo("El Cortezo", "03", 8.34556, -80.58721);
case 505: return new CityInfo("El Cortezo", "07", 7.42661, -80.63311);
case 506: return new CityInfo("El Copé", "03", 8.62036, -80.58433);
case 507: return new CityInfo("El Copé", "03", 8.43773, -80.67929);
case 508: return new CityInfo("El Coco", "13", 8.87009, -79.80415);
case 509: return new CityInfo("El Coco", "03", 8.39716, -80.35);
case 510: return new CityInfo("El Coclá", "10", 8.32143, -80.92069);
case 511: return new CityInfo("El Cocal", "07", 7.73697, -80.2798);
case 512: return new CityInfo("El Chorrillo", "08", 8.94964, -79.54715);
case 513: return new CityInfo("El Chirú", "03", 8.39876, -80.18721);
case 514: return new CityInfo("El Cedro", "06", 7.68565, -80.65927);
case 515: return new CityInfo("El Carate", "07", 7.73124, -80.29691);
case 516: return new CityInfo("El Capurí", "06", 7.72571, -80.64349);
case 517: return new CityInfo("El Caño", "03", 8.40195, -80.51791);
case 518: return new CityInfo("El Cañafístulo", "07", 7.61768, -80.23322);
case 519: return new CityInfo("El Calabacito", "06", 7.71843, -80.59757);
case 520: return new CityInfo("El Cacao", "13", 8.76134, -80.01294);
case 521: return new CityInfo("El Cacao", "07", 7.4457, -80.40938);
case 522: return new CityInfo("Bongo Arriba", "02", 8.58881, -82.62253);
case 523: return new CityInfo("El Bongo", "10", 7.94858, -81.04838);
case 524: return new CityInfo("El Bebedero", "07", 7.40972, -80.45641);
case 525: return new CityInfo("El Barrito", "10", 7.96059, -80.94801);
case 526: return new CityInfo("El Barrero", "03", 8.15567, -80.69249);
case 527: return new CityInfo("El Barrero", "06", 7.93344, -80.51358);
case 528: return new CityInfo("El Banco", "02", 8.69186, -82.51293);
case 529: return new CityInfo("Cerro Banco", "12", 8.45797, -82.03081);
case 530: return new CityInfo("El Bale", "10", 8.35745, -81.36099);
case 531: return new CityInfo("El Alto de Capira", "13", 8.7324, -79.88764);
case 532: return new CityInfo("El Alto", "10", 8.51191, -81.03646);
case 533: return new CityInfo("Dos Ríos Arriba", "02", 8.55171, -82.39977);
case 534: return new CityInfo("Dos Ríos Abajo", "02", 8.52834, -82.38677);
case 535: return new CityInfo("Dolega District", "02", 8.56667, -82.41407);
case 536: return new CityInfo("Divalá", "02", 8.41066, -82.71332);
case 537: return new CityInfo("David", "02", 8.42729, -82.43085);
case 538: return new CityInfo("Kusapín", "12", 9.17823, -81.88484);
case 539: return new CityInfo("Curundú", "08", 8.97092, -79.54612);
case 540: return new CityInfo("Cuipo", "04", 9.06896, -80.04878);
case 541: return new CityInfo("Cucunatí", "05", 8.57508, -78.25671);
case 542: return new CityInfo("Cuango", "04", 9.56667, -79.31667);
case 543: return new CityInfo("Cristóbal", "04", 9.35222, -79.90444);
case 544: return new CityInfo("Corozal", "10", 8.07712, -81.4399);
case 545: return new CityInfo("Cordillera", "02", 8.70683, -82.60327);
case 546: return new CityInfo("El Congo", "03", 8.43701, -80.42251);
case 547: return new CityInfo("Coloncito", "13", 8.56292, -79.89944);
case 548: return new CityInfo("Colón", "04", 9.35451, -79.90011);
case 549: return new CityInfo("Coetupo", "09", 8.90007, -77.69274);
case 550: return new CityInfo("Coclé del Norte", "04", 9.0754, -80.57177);
case 551: return new CityInfo("Coclecito", "04", 8.80817, -80.55607);
case 552: return new CityInfo("Coclé", "03", 8.45601, -80.42899);
case 553: return new CityInfo("Angostura de Cochea Arriba", "02", 8.53606, -82.37547);
case 554: return new CityInfo("Cochea Abajo", "02", 8.50512, -82.35878);
case 555: return new CityInfo("Ciruelito", "03", 8.45317, -80.45);
case 556: return new CityInfo("Cirí de Los Sotos", "13", 8.97206, -80.09209);
case 557: return new CityInfo("Churuquita Grande", "03", 8.59449, -80.27182);
case 558: return new CityInfo("Churuquita Chiquita", "03", 8.57555, -80.27161);
case 559: return new CityInfo("Churubé Abajo", "03", 8.39889, -80.54156);
case 560: return new CityInfo("Chupampa", "06", 8.0762, -80.77656);
case 561: return new CityInfo("Chupá", "07", 7.8, -80.57451);
case 562: return new CityInfo("Chumical", "06", 7.84482, -80.72627);
case 563: return new CityInfo("Barrio Guadalupe", "02", 8.86482, -82.56523);
case 564: return new CityInfo("Chitré", "06", 7.96082, -80.42944);
case 565: return new CityInfo("Chiriquí Grande", "01", 8.94557, -82.11769);
case 566: return new CityInfo("Chiriquí", "02", 8.39291, -82.31993);
case 567: return new CityInfo("Chimán", "08", 8.69125, -78.6357);
case 568: return new CityInfo("Chilibre", "08", 9.15093, -79.62098);
case 569: return new CityInfo("Chiguirí Arriba", "03", 8.67187, -80.18975);
case 570: return new CityInfo("Chigoré", "03", 8.53035, -80.35117);
case 571: return new CityInfo("Chichica", "12", 8.36667, -81.66667);
case 572: return new CityInfo("Chichica", "12", 8.35885, -81.66582);
case 573: return new CityInfo("Chepo", "08", 9.17019, -79.10083);
case 574: return new CityInfo("Chepillo", "08", 8.95396, -79.12856);
case 575: return new CityInfo("Chepigana", "05", 8.28628, -78.05185);
case 576: return new CityInfo("Changuinola", "01", 9.43, -82.52);
case 577: return new CityInfo("Chame", "13", 8.57753, -79.88595);
case 578: return new CityInfo("Chacarero", "02", 8.48899, -82.59834);
case 579: return new CityInfo("Cerro Viejo", "02", 8.25349, -81.57658);
case 580: return new CityInfo("Cerro Venado", "02", 8.22818, -81.57421);
case 581: return new CityInfo("Cerro Punta", "02", 8.84968, -82.57261);
case 582: return new CityInfo("Cerro Plata", "12", 8.47733, -81.54585);
case 583: return new CityInfo("Cerro de Plata", "10", 8.28777, -81.36844);
case 584: return new CityInfo("Cerro Mosquito", "12", 8.34777, -81.68926);
case 585: return new CityInfo("Cerro Largo", "06", 7.83377, -80.83168);
case 586: return new CityInfo("Cerro Iglesias", "12", 8.28523, -81.79804);
case 587: return new CityInfo("Cerro Iglesias", "02", 8.31892, -81.56427);
case 588: return new CityInfo("Cerro Caña", "12", 8.35174, -81.6105);
case 589: return new CityInfo("Cerro Campana", "08", 8.70686, -79.91219);
case 590: return new CityInfo("Cerro Cama", "13", 9.02802, -79.90744);
case 591: return new CityInfo("Cerro Azul", "08", 9.15735, -79.42097);
case 592: return new CityInfo("Cermeño", "13", 8.74082, -79.85299);
case 593: return new CityInfo("Celmira", "02", 8.54026, -82.80022);
case 594: return new CityInfo("Cauchero", "01", 9.15226, -82.2645);
case 595: return new CityInfo("Cativá", "04", 9.36218, -79.83232);
case 596: return new CityInfo("Cascabel", "12", 8.5268, -81.87403);
case 597: return new CityInfo("Cartí Sugdup", "09", 9.4646, -78.95931);
case 598: return new CityInfo("Capira", "13", 8.75636, -79.87996);
case 599: return new CityInfo("Capellanía", "03", 8.29858, -80.5548);
case 600: return new CityInfo("San Isidro", "02", 8.53032, -82.8272);
case 601: return new CityInfo("Canto del Llano", "10", 8.12472, -80.96374);
case 602: return new CityInfo("Kankintú", "12", 8.84339, -81.81496);
case 603: return new CityInfo("Cañita", "08", 9.22236, -78.89509);
case 604: return new CityInfo("Cañazas", "08", 8.89884, -78.22448);
case 605: return new CityInfo("Cañazas", "10", 8.32004, -81.21152);
case 606: return new CityInfo("Cañazas", "10", 8.14303, -80.71757);
case 607: return new CityInfo("Cañaveral", "03", 8.517, -80.42916);
case 608: return new CityInfo("Cañas Gordas", "02", 8.74309, -82.91275);
case 609: return new CityInfo("Cañas", "07", 7.44713, -80.2648);
case 610: return new CityInfo("Cambutal", "07", 7.26534, -80.49105);
case 611: return new CityInfo("Camarón Arriba", "12", 8.38324, -81.99345);
case 612: return new CityInfo("Calzada Larga", "08", 9.17272, -79.56212);
case 613: return new CityInfo("Calovébora", "10", 8.78703, -81.21056);
case 614: return new CityInfo("Calobre", "10", 8.31886, -80.84067);
case 615: return new CityInfo("Calidonia", "10", 7.95756, -81.38633);
case 616: return new CityInfo("Caldera", "02", 8.64907, -82.38058);
case 617: return new CityInfo("Calabacito", "10", 8.24817, -81.08187);
case 618: return new CityInfo("Caimito", "13", 8.81143, -79.94738);
case 619: return new CityInfo("Caimito", "03", 8.62271, -80.23919);
case 620: return new CityInfo("Caimito", "02", 8.54162, -82.419);
case 621: return new CityInfo("Caimitillo", "08", 9.15559, -79.53974);
case 622: return new CityInfo("Cacique", "04", 9.60898, -79.61667);
case 623: return new CityInfo("Cabuya", "13", 8.57472, -79.92714);
case 624: return new CityInfo("Cabuya", "03", 8.54703, -80.16756);
case 625: return new CityInfo("Cabuya", "06", 8.03138, -80.63227);
case 626: return new CityInfo("Cabra Número Uno", "08", 9.10863, -79.33694);
case 627: return new CityInfo("Caballero", "03", 8.54343, -80.19769);
case 628: return new CityInfo("Bugabita Arriba", "02", 8.52143, -82.63638);
case 629: return new CityInfo("Bugaba", "02", 8.48255, -82.61991);
case 630: return new CityInfo("Buen Retiro", "03", 8.41774, -80.23462);
case 631: return new CityInfo("Buenos Aires", "13", 8.63146, -79.94775);
case 632: return new CityInfo("Buenos Aires", "12", 8.41384, -81.4844);
case 633: return new CityInfo("Buena Vista", "04", 9.27356, -79.69551);
case 634: return new CityInfo("Brujas", "08", 8.58536, -78.53008);
case 635: return new CityInfo("Breñón", "02", 8.62491, -82.81277);
case 636: return new CityInfo("Boró", "10", 8.16933, -81.30071);
case 637: return new CityInfo("Boquete", "02", 8.78024, -82.44136);
case 638: return new CityInfo("Boquerón", "02", 8.5051, -82.57025);
case 639: return new CityInfo("Boquerón", "10", 8.24414, -80.85897);
case 640: return new CityInfo("Bocas del Toro", "01", 9.34031, -82.24204);
case 641: return new CityInfo("Soloy", "12", 8.48973, -82.07136);
case 642: return new CityInfo("Boca de Parita", "06", 8.00796, -80.4532);
case 643: return new CityInfo("Boca de Río Indio", "04", 9.18293, -80.19063);
case 644: return new CityInfo("Boca del Río Chiriquí", "12", 8.84517, -81.57265);
case 645: return new CityInfo("Boca del Monte", "02", 8.35296, -82.11379);
case 646: return new CityInfo("Boca de Cupé", "05", 8.03003, -77.58978);
case 647: return new CityInfo("Boca Chica", "02", 8.21911, -82.21592);
case 648: return new CityInfo("Bisvalles", "10", 8.18298, -81.22092);
case 649: return new CityInfo("Bisira", "12", 8.89553, -81.85352);
case 650: return new CityInfo("Bijagual", "02", 8.51486, -82.33361);
case 651: return new CityInfo("Bijagual", "03", 8.37057, -80.25497);
case 652: return new CityInfo("Bella Vista", "07", 7.75, -80.23333);
case 653: return new CityInfo("Bejuco", "13", 8.60037, -79.88988);
case 654: return new CityInfo("Bayano", "07", 7.63014, -80.38201);
case 655: return new CityInfo("Isla Bastimentos", "01", 9.3, -82.13333);
case 656: return new CityInfo("Bastimentos", "01", 9.34707, -82.2088);
case 657: return new CityInfo("Barranco Colorado", "03", 8.38937, -80.63546);
case 658: return new CityInfo("Barranco", "01", 9.51984, -82.70424);
case 659: return new CityInfo("Barnizal", "10", 8.4046, -80.77765);
case 660: return new CityInfo("Balboa", "08", 8.94814, -79.56672);
case 661: return new CityInfo("Bajos de Güera", "07", 7.5436, -80.62505);
case 662: return new CityInfo("Bajo Corral", "07", 7.60463, -80.26016);
case 663: return new CityInfo("Bajo Boquete", "02", 8.77058, -82.43306);
case 664: return new CityInfo("Bahía Honda", "07", 7.70517, -80.45342);
case 665: return new CityInfo("Bahía Azul", "12", 9.14176, -81.89425);
case 666: return new CityInfo("Bágala", "02", 8.46399, -82.52617);
case 667: return new CityInfo("Ave María", "07", 7.32481, -80.45361);
case 668: return new CityInfo("Atalaya", "10", 8.04213, -80.92528);
case 669: return new CityInfo("Aserrío de Gariché", "02", 8.48257, -82.79086);
case 670: return new CityInfo("Arraiján", "13", 8.95187, -79.66011);
case 671: return new CityInfo("Arosemena", "13", 8.97091, -79.96641);
case 672: return new CityInfo("Armila", "09", 8.66269, -77.45142);
case 673: return new CityInfo("Arenosa", "13", 9.03978, -79.95128);
case 674: return new CityInfo("Arenas", "10", 7.36865, -80.86268);
case 675: return new CityInfo("Antón", "03", 8.39733, -80.26063);
case 676: return new CityInfo("Ancón", "08", 8.96015, -79.5514);
case 677: return new CityInfo("Altos de Güera", "07", 7.53002, -80.62109);
case 678: return new CityInfo("Alto Quiel", "02", 8.80507, -82.47431);
case 679: return new CityInfo("Alto Lino", "02", 8.79947, -82.4348);
case 680: return new CityInfo("Alto del Espino", "13", 8.84213, -79.84551);
case 681: return new CityInfo("Alto de La Estancia", "03", 8.58792, -80.18443);
case 682: return new CityInfo("Alto Caballero", "12", 8.28989, -81.67349);
case 683: return new CityInfo("Alto Boquete", "02", 8.73458, -82.43213);
case 684: return new CityInfo("Almirante", "01", 9.30091, -82.4018);
case 685: return new CityInfo("Alcalde Díaz", "08", 9.12016, -79.55641);
case 686: return new CityInfo("Alanje", "02", 8.39791, -82.55947);
case 687: return new CityInfo("Ailigandí", "09", 9.2281, -78.02778);
case 688: return new CityInfo("Aguas Blancas", "03", 8.50351, -80.31169);
case 689: return new CityInfo("Aguadulce", "03", 8.24183, -80.54609);
case 690: return new CityInfo("Agua de Salud", "12", 8.50486, -81.46397);
case 691: return new CityInfo("Aguacatal", "02", 8.46099, -82.45553);
case 692: return new CityInfo("Agua Buena", "07", 7.83465, -80.39405);
case 693: return new CityInfo("Achutupo", "09", 9.19827, -77.98729);
case 694: return new CityInfo("Achiote", "04", 9.21121, -80.01338);
case 695: return new CityInfo("Pásiga", "08", 8.93647, -78.90917);
case 696: return new CityInfo("Ipetí", "08", 8.96861, -78.505);
case 697: return new CityInfo("Jingurudó", "11", 7.87962, -78.07689);
case 698: return new CityInfo("Santa Rita Arriba", "04", 9.33032, -79.79363);
case 699: return new CityInfo("Lajas Blancas", "11", 8.41482, -77.81161);
case 700: return new CityInfo("Unión Chocó", "11", 8.08404, -77.53507);
case 701: return new CityInfo("Sambú", "05", 8.0254, -78.20927);
case 702: return new CityInfo("Puerto Indio", "05", 8.02171, -78.20528);
case 703: return new CityInfo("Howard", "08", 8.93942, -79.59097);
case 704: return new CityInfo("La Tollosa", "10", 7.98938, -81.32362);
case 705: return new CityInfo("Villa Lourdes", "07", 7.81141, -80.47029);
case 706: return new CityInfo("Cedro Arriba", "07", 7.78097, -80.53057);
case 707: return new CityInfo("San Juan Bautista", "06", 7.96099, -80.41283);
case 708: return new CityInfo("Oria Arriba", "07", 7.50505, -80.20567);
case 709: return new CityInfo("Nuevo Tonosí", "04", 9.55006, -79.62221);
case 710: return new CityInfo("Villa Unida", "08", 9.18908, -79.62452);
case 711: return new CityInfo("San Antonio", "08", 9.1729, -79.54743);
case 712: return new CityInfo("Gonzalillo", "08", 9.09183, -79.51928);
case 713: return new CityInfo("Nuevo Belén", "08", 9.07939, -79.39556);
case 714: return new CityInfo("La Colorada", "08", 9.10224, -79.416);
case 715: return new CityInfo("Las Tablas Abajo", "07", 7.79613, -80.25233);
case 716: return new CityInfo("Vista Hermosa", "08", 9.11178, -79.36113);
case 717: return new CityInfo("Nueva Esperanza", "08", 9.1021, -79.33414);
case 718: return new CityInfo("Unión de Azuero", "08", 9.15256, -79.17005);
case 719: return new CityInfo("Tortí", "08", 8.92132, -78.40546);
case 720: return new CityInfo("Barriales", "05", 8.58402, -78.38822);
case 721: return new CityInfo("Platanilla", "05", 8.828, -78.38435);
case 722: return new CityInfo("Zapallal", "05", 8.64944, -78.13003);
case 723: return new CityInfo("Quebrada Honda", "05", 8.63528, -78.11292);
case 724: return new CityInfo("Setegantí", "05", 8.29381, -78.10025);
case 725: return new CityInfo("Villa Darién", "05", 8.54518, -78.00797);
case 726: return new CityInfo("Pueblo Nuevo", "05", 8.14918, -77.69404);
case 727: return new CityInfo("Camogantí", "05", 8.04171, -77.88682);
case 728: return new CityInfo("Corozal", "11", 8.20108, -77.59637);
case 729: return new CityInfo("Agua Fría Número Uno", "05", 8.85839, -78.1975);
case 730: return new CityInfo("Bayamón", "11", 7.96817, -78.21648);
case 731: return new CityInfo("Unión Santeña", "08", 8.83525, -78.65104);
case 732: return new CityInfo("Contadora", "08", 8.62483, -79.03748);
case 733: return new CityInfo("Cayo de Agua", "01", 9.15037, -82.05546);
case 734: return new CityInfo("Isla Tigre", "01", 9.17471, -82.08041);
case 735: return new CityInfo("San Cristóbal", "01", 9.28129, -82.26763);
case 736: return new CityInfo("Norteño", "00", 9.00308, -82.31476);
case 737: return new CityInfo("Nuevo Paraiso", "01", 9.28078, -82.41133);
case 738: return new CityInfo("Sieyic", "01", 9.38323, -82.65206);
case 739: return new CityInfo("Barranco Adentro", "01", 9.52757, -82.73344);
case 740: return new CityInfo("La Mesa", "01", 9.49587, -82.67534);
case 741: return new CityInfo("Quebrada del Rosario", "06", 7.71238, -80.74222);
case 742: return new CityInfo("Alto Quiel", "02", 8.72978, -82.89906);
case 743: return new CityInfo("La Bonita", "02", 8.61903, -82.76392);
case 744: return new CityInfo("El Roble", "02", 8.50488, -82.77423);
case 745: return new CityInfo("Paso Canoas Arriba", "02", 8.56516, -82.82214);
case 746: return new CityInfo("Cuervito Abajo", "02", 8.46574, -82.84011);
case 747: return new CityInfo("Santa María", "02", 8.44778, -82.84256);
case 748: return new CityInfo("Chuchupate", "02", 8.43453, -82.86435);
case 749: return new CityInfo("Finca Balsa", "02", 8.42891, -82.89726);
case 750: return new CityInfo("El Palmar", "02", 8.30098, -82.85344);
case 751: return new CityInfo("Agua Buena", "02", 8.29987, -82.87196);
case 752: return new CityInfo("Monte Verde", "02", 8.27417, -82.87252);
case 753: return new CityInfo("Berba", "02", 8.38499, -82.81323);
case 754: return new CityInfo("San Valentín", "02", 8.36725, -82.77959);
case 755: return new CityInfo("Manaca Norte", "02", 8.33419, -82.81003);
case 756: return new CityInfo("Manaca Civil", "02", 8.32458, -82.8157);
case 757: return new CityInfo("Pueblo Nuevo", "02", 8.53148, -82.50471);
case 758: return new CityInfo("Algarrobos Arriba", "02", 8.5155, -82.42263);
case 759: return new CityInfo("Nuevo San Carlitos", "02", 8.45698, -82.43712);
case 760: return new CityInfo("Rámbala", "01", 8.92046, -82.1806);
case 761: return new CityInfo("Pueblo Nuevo", "12", 8.8807, -82.22411);
case 762: return new CityInfo("Valle de La Mina", "02", 8.66427, -82.23196);
case 763: return new CityInfo("Quebrada Tula", "12", 8.84037, -81.99645);
case 764: return new CityInfo("Boca de Balsa", "12", 8.52995, -82.03132);
case 765: return new CityInfo("Cuoronte", "12", 8.67457, -81.78586);
case 766: return new CityInfo("Oma", "12", 8.35019, -81.80177);
case 767: return new CityInfo("Cerro Ceniza", "12", 8.34298, -81.76618);
case 768: return new CityInfo("Cabecera de Cerro Puerco", "12", 8.31856, -81.75951);
case 769: return new CityInfo("El Porvenir", "02", 8.22919, -81.83278);
case 770: return new CityInfo("Santa Lucia", "02", 8.23123, -81.82613);
case 771: return new CityInfo("El Puerto", "02", 8.21238, -81.80797);
case 772: return new CityInfo("Mirones", "12", 8.55757, -81.72574);
case 773: return new CityInfo("Bajo Solis", "02", 8.34751, -81.52912);
case 774: return new CityInfo("Bella Vista", "02", 8.20617, -81.62123);
case 775: return new CityInfo("Llano Limón", "02", 8.24466, -81.65641);
case 776: return new CityInfo("Cerro Pelado", "10", 8.16247, -81.53917);
case 777: return new CityInfo("Miraflores", "02", 8.84409, -82.82819);
case 778: return new CityInfo("Lajero Arriba", "12", 8.2906, -81.77047);
case 779: return new CityInfo("San Bartolo Línea", "02", 8.31417, -82.88106);
case 780: return new CityInfo("Loma Yuca", "12", 8.71817, -81.40492);
case 781: return new CityInfo("Los Pollos", "03", 8.39898, -80.15731);
case 782: return new CityInfo("San Miguel Centro", "03", 8.74208, -80.18701);
case 783: return new CityInfo("San Juan de Dios", "03", 8.55119, -80.22623);
case 784: return new CityInfo("Bella Vista", "03", 8.54263, -80.40679);
case 785: return new CityInfo("Río Luís", "10", 8.68361, -81.21608);
case 786: return new CityInfo("Güibale", "12", 8.51225, -81.36257);
case 787: return new CityInfo("Paredón Arriba", "12", 8.45977, -81.19592);
case 788: return new CityInfo("Guayabito", "12", 8.53949, -81.48225);
case 789: return new CityInfo("Alto de Jesús", "10", 8.26152, -81.48412);
case 790: return new CityInfo("La Pesa", "13", 8.85073, -79.82374);
case 791: return new CityInfo("Monte Claro", "13", 8.92874, -79.66831);
case 792: return new CityInfo("La Cresta", "13", 8.6397, -79.8824);
case 793: return new CityInfo("Cerro El Castillo", "13", 8.96105, -79.67876);
default: return new CityInfo("Ciricito Abajo", "13", 8.7995, -80.07747);

                                    }                                        
                                }
                            
                        }
                    }
                