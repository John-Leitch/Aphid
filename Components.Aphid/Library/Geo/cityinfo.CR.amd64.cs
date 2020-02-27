
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
                                    public const string Country = "CR";
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
                            
                                        var cur = (Math.Abs(10.18561 - lat) + Math.Abs(-84.39076 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(10 - lat) + Math.Abs(-85.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89792 - lat) + Math.Abs(-85.01454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90467 - lat) + Math.Abs(-83.68352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.85336 - lat) + Math.Abs(-83.72273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90644 - lat) + Math.Abs(-83.9876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.83837 - lat) + Math.Abs(-83.98391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46701 - lat) + Math.Abs(-84.96775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.74622 - lat) + Math.Abs(-84.23368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52766 - lat) + Math.Abs(-82.62185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.09748 - lat) + Math.Abs(-83.50659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.51674 - lat) + Math.Abs(-85.64748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0897 - lat) + Math.Abs(-84.34752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.82079 - lat) + Math.Abs(-82.97092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96016 - lat) + Math.Abs(-84.04762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06389 - lat) + Math.Abs(-84.15499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02275 - lat) + Math.Abs(-84.4442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.84636 - lat) + Math.Abs(-84.31428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26053 - lat) + Math.Abs(-85.5851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.9326 - lat) + Math.Abs(-84.18255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08802 - lat) + Math.Abs(-84.47022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87556 - lat) + Math.Abs(-84.07661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.831 - lat) + Math.Abs(-84.29008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06403 - lat) + Math.Abs(-84.47281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0132 - lat) + Math.Abs(-84.10016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92787 - lat) + Math.Abs(-84.13722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92829 - lat) + Math.Abs(-84.05074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99559 - lat) + Math.Abs(-84.09656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.68323 - lat) + Math.Abs(-84.0405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87121 - lat) + Math.Abs(-84.06084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.6601 - lat) + Math.Abs(-84.02026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.8773 - lat) + Math.Abs(-84.0847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.10248 - lat) + Math.Abs(-84.31694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95974 - lat) + Math.Abs(-84.08165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.01667 - lat) + Math.Abs(-84.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95173 - lat) + Math.Abs(-85.1361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.93333 - lat) + Math.Abs(-84.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3674 - lat) + Math.Abs(-83.69713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79853 - lat) + Math.Abs(-84.16173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99299 - lat) + Math.Abs(-84.12934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90488 - lat) + Math.Abs(-84.10551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89898 - lat) + Math.Abs(-84.00287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.98333 - lat) + Math.Abs(-84.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88147 - lat) + Math.Abs(-85.52809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.85259 - lat) + Math.Abs(-84.09062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91163 - lat) + Math.Abs(-84.17835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.07404 - lat) + Math.Abs(-84.21551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94522 - lat) + Math.Abs(-84.03927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81814 - lat) + Math.Abs(-82.90911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26712 - lat) + Math.Abs(-83.7511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.24138 - lat) + Math.Abs(-84.27933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.32381 - lat) + Math.Abs(-84.42714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43063 - lat) + Math.Abs(-84.16231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95808 - lat) + Math.Abs(-84.0305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97625 - lat) + Math.Abs(-84.83836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99074 - lat) + Math.Abs(-83.03596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36667 - lat) + Math.Abs(-84.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17185 - lat) + Math.Abs(-83.60439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45056 - lat) + Math.Abs(-84.27406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81135 - lat) + Math.Abs(-83.70336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88071 - lat) + Math.Abs(-84.03501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52012 - lat) + Math.Abs(-84.32249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.83832 - lat) + Math.Abs(-83.86557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.82005 - lat) + Math.Abs(-84.93513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.83778 - lat) + Math.Abs(-84.20478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.10188 - lat) + Math.Abs(-83.46987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.80709 - lat) + Math.Abs(-84.04764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91197 - lat) + Math.Abs(-84.52337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79617 - lat) + Math.Abs(-83.85383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15038 - lat) + Math.Abs(-85.45093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.09866 - lat) + Math.Abs(-84.37824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03333 - lat) + Math.Abs(-85.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7573 - lat) + Math.Abs(-84.10956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0925 - lat) + Math.Abs(-84.72978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00695 - lat) + Math.Abs(-84.13396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.2627 - lat) + Math.Abs(-83.58202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08363 - lat) + Math.Abs(-83.28431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00268 - lat) + Math.Abs(-84.63994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.03333 - lat) + Math.Abs(-84.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99844 - lat) + Math.Abs(-84.15448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63504 - lat) + Math.Abs(-85.43772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40174 - lat) + Math.Abs(-84.13348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.85065 - lat) + Math.Abs(-83.6169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.20951 - lat) + Math.Abs(-84.40074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.07377 - lat) + Math.Abs(-85.63272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97961 - lat) + Math.Abs(-84.17281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28089 - lat) + Math.Abs(-84.95951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16772 - lat) + Math.Abs(-83.774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61497 - lat) + Math.Abs(-84.62975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96745 - lat) + Math.Abs(-84.01326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0579 - lat) + Math.Abs(-85.41803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00236 - lat) + Math.Abs(-84.11651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21682 - lat) + Math.Abs(-83.78483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94805 - lat) + Math.Abs(-84.05665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.2129 - lat) + Math.Abs(-83.68793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.93491 - lat) + Math.Abs(-84.01688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.60327 - lat) + Math.Abs(-83.11342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.67384 - lat) + Math.Abs(-85.19984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47089 - lat) + Math.Abs(-84.64535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36131 - lat) + Math.Abs(-84.47496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.05676 - lat) + Math.Abs(-84.42337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99447 - lat) + Math.Abs(-84.66466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91887 - lat) + Math.Abs(-84.13989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94727 - lat) + Math.Abs(-84.50626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33554 - lat) + Math.Abs(-83.6694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91179 - lat) + Math.Abs(-84.03407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89449 - lat) + Math.Abs(-83.87302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64002 - lat) + Math.Abs(-82.946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.93333 - lat) + Math.Abs(-84 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91491 - lat) + Math.Abs(-84.2417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95091 - lat) + Math.Abs(-84.08503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95988 - lat) + Math.Abs(-83.52381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.98424 - lat) + Math.Abs(-84.77892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86444 - lat) + Math.Abs(-83.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02918 - lat) + Math.Abs(-84.27403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92171 - lat) + Math.Abs(-83.78507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53305 - lat) + Math.Abs(-82.83844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.43105 - lat) + Math.Abs(-85.09825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95 - lat) + Math.Abs(-84.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.73781 - lat) + Math.Abs(-82.84042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17189 - lat) + Math.Abs(-83.33417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.73279 - lat) + Math.Abs(-85.05676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40789 - lat) + Math.Abs(-85.58836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.85014 - lat) + Math.Abs(-85.32923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08354 - lat) + Math.Abs(-83.33413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97439 - lat) + Math.Abs(-84.42166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.52541 - lat) + Math.Abs(-85.25537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97489 - lat) + Math.Abs(-84.37886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.85876 - lat) + Math.Abs(-84.0923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99591 - lat) + Math.Abs(-84.05126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90163 - lat) + Math.Abs(-84.10042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.01625 - lat) + Math.Abs(-84.21163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96164 - lat) + Math.Abs(-84.0488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.35719 - lat) + Math.Abs(-83.7362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15144 - lat) + Math.Abs(-83.97748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zarcero", "01", 10.18561, -84.39076);
case 1: return new CityInfo("Zapotal", "03", 10, -85.3);
case 2: return new CityInfo("Upala", "01", 10.89792, -85.01454);
case 3: return new CityInfo("Turrialba", "02", 9.90467, -83.68352);
case 4: return new CityInfo("Tucurrique", "02", 9.85336, -83.72273);
case 5: return new CityInfo("Tres Ríos", "02", 9.90644, -83.9876);
case 6: return new CityInfo("Tobosi", "02", 9.83837, -83.98391);
case 7: return new CityInfo("Tilarán", "03", 10.46701, -84.96775);
case 8: return new CityInfo("Tejar", "08", 9.74622, -84.23368);
case 9: return new CityInfo("Sixaola", "06", 9.52766, -82.62185);
case 10: return new CityInfo("Siquirres", "06", 10.09748, -83.50659);
case 11: return new CityInfo("Sardinal", "03", 10.51674, -85.64748);
case 12: return new CityInfo("Sarchí", "01", 10.0897, -84.34752);
case 13: return new CityInfo("San Vito", "07", 8.82079, -82.97092);
case 14: return new CityInfo("San Vicente", "08", 9.96016, -84.04762);
case 15: return new CityInfo("Santo Domingo", "04", 10.06389, -84.15499);
case 16: return new CityInfo("Santiago", "01", 10.02275, -84.4442);
case 17: return new CityInfo("Santiago", "08", 9.84636, -84.31428);
case 18: return new CityInfo("Santa Cruz", "03", 10.26053, -85.5851);
case 19: return new CityInfo("Santa Ana", "08", 9.9326, -84.18255);
case 20: return new CityInfo("San Ramón", "01", 10.08802, -84.47022);
case 21: return new CityInfo("San Rafael Arriba", "08", 9.87556, -84.07661);
case 22: return new CityInfo("San Rafael Abajo", "08", 9.831, -84.29008);
case 23: return new CityInfo("San Rafael", "01", 10.06403, -84.47281);
case 24: return new CityInfo("San Rafael", "04", 10.0132, -84.10016);
case 25: return new CityInfo("San Rafael", "08", 9.92787, -84.13722);
case 26: return new CityInfo("San Pedro", "08", 9.92829, -84.05074);
case 27: return new CityInfo("San Pablo", "04", 9.99559, -84.09656);
case 28: return new CityInfo("San Pablo", "08", 9.68323, -84.0405);
case 29: return new CityInfo("San Miguel", "08", 9.87121, -84.06084);
case 30: return new CityInfo("San Marcos", "08", 9.6601, -84.02026);
case 31: return new CityInfo("San Juan de Dios", "08", 9.8773, -84.0847);
case 32: return new CityInfo("San Juan", "01", 10.10248, -84.31694);
case 33: return new CityInfo("San Juan", "08", 9.95974, -84.08165);
case 34: return new CityInfo("San Josecito", "04", 10.01667, -84.1);
case 35: return new CityInfo("San José", "01", 10.95173, -85.1361);
case 36: return new CityInfo("San José", "08", 9.93333, -84.08333);
case 37: return new CityInfo("San Isidro", "08", 9.3674, -83.69713);
case 38: return new CityInfo("San Ignacio", "08", 9.79853, -84.16173);
case 39: return new CityInfo("San Francisco", "04", 9.99299, -84.12934);
case 40: return new CityInfo("San Felipe", "08", 9.90488, -84.10551);
case 41: return new CityInfo("San Diego", "02", 9.89898, -84.00287);
case 42: return new CityInfo("San Antonio", "04", 9.98333, -84.18333);
case 43: return new CityInfo("Sámara", "03", 9.88147, -85.52809);
case 44: return new CityInfo("Salitrillos", "08", 9.85259, -84.09062);
case 45: return new CityInfo("Salitral", "08", 9.91163, -84.17835);
case 46: return new CityInfo("Sabanilla", "01", 10.07404, -84.21551);
case 47: return new CityInfo("Sabanilla", "08", 9.94522, -84.03927);
case 48: return new CityInfo("Sabalito", "07", 8.81814, -82.90911);
case 49: return new CityInfo("Roxana", "06", 10.26712, -83.7511);
case 50: return new CityInfo("Río Segundo", "01", 10.24138, -84.27933);
case 51: return new CityInfo("Quesada", "01", 10.32381, -84.42714);
case 52: return new CityInfo("Quepos", "07", 9.43063, -84.16231);
case 53: return new CityInfo("Purral", "08", 9.95808, -84.0305);
case 54: return new CityInfo("Puntarenas", "07", 9.97625, -84.83836);
case 55: return new CityInfo("Limón", "06", 9.99074, -83.03596);
case 56: return new CityInfo("Pocosol", "01", 10.36667, -84.61667);
case 57: return new CityInfo("Pocora", "06", 10.17185, -83.60439);
case 58: return new CityInfo("Pital", "01", 10.45056, -84.27406);
case 59: return new CityInfo("Pejibaye", "02", 9.81135, -83.70336);
case 60: return new CityInfo("Patarrá", "08", 9.88071, -84.03501);
case 61: return new CityInfo("Parrita", "07", 9.52012, -84.32249);
case 62: return new CityInfo("Paraíso", "02", 9.83832, -83.86557);
case 63: return new CityInfo("Paquera", "07", 9.82005, -84.93513);
case 64: return new CityInfo("Palmichal", "08", 9.83778, -84.20478);
case 65: return new CityInfo("Pacuarito", "06", 10.10188, -83.46987);
case 66: return new CityInfo("Pacayas", "02", 9.80709, -84.04764);
case 67: return new CityInfo("Orotina", "01", 9.91197, -84.52337);
case 68: return new CityInfo("Orosí", "02", 9.79617, -83.85383);
case 69: return new CityInfo("Nicoya", "03", 10.15038, -85.45093);
case 70: return new CityInfo("Naranjo", "01", 10.09866, -84.37824);
case 71: return new CityInfo("Nandayure", "03", 10.03333, -85.2);
case 72: return new CityInfo("Monterrey", "08", 9.7573, -84.10956);
case 73: return new CityInfo("Miramar", "07", 10.0925, -84.72978);
case 74: return new CityInfo("Mercedes", "04", 10.00695, -84.13396);
case 75: return new CityInfo("Mercedes", "08", 9.2627, -83.58202);
case 76: return new CityInfo("Matina", "06", 10.08363, -83.28431);
case 77: return new CityInfo("Macacona", "07", 10.00268, -84.63994);
case 78: return new CityInfo("Los Chiles", "01", 11.03333, -84.71667);
case 79: return new CityInfo("Llorente", "04", 9.99844, -84.15448);
case 80: return new CityInfo("Liberia", "03", 10.63504, -85.43772);
case 81: return new CityInfo("La Virgen", "04", 10.40174, -84.13348);
case 82: return new CityInfo("La Suiza", "02", 9.85065, -83.6169);
case 83: return new CityInfo("Laguna", "01", 10.20951, -84.40074);
case 84: return new CityInfo("La Cruz", "03", 11.07377, -85.63272);
case 85: return new CityInfo("La Asunción", "04", 9.97961, -84.17281);
case 86: return new CityInfo("Juntas", "03", 10.28089, -84.95951);
case 87: return new CityInfo("Jiménez", "06", 10.16772, -83.774);
case 88: return new CityInfo("Jacó", "07", 9.61497, -84.62975);
case 89: return new CityInfo("Ipís", "08", 9.96745, -84.01326);
case 90: return new CityInfo("Hojancha", "03", 10.0579, -85.41803);
case 91: return new CityInfo("Heredia", "04", 10.00236, -84.11651);
case 92: return new CityInfo("Guápiles", "06", 10.21682, -83.78483);
case 93: return new CityInfo("Guadalupe", "08", 9.94805, -84.05665);
case 94: return new CityInfo("Guácimo", "06", 10.2129, -83.68793);
case 95: return new CityInfo("Granadilla", "08", 9.93491, -84.01688);
case 96: return new CityInfo("Golfito", "07", 8.60327, -83.11342);
case 97: return new CityInfo("Fortuna", "03", 10.67384, -85.19984);
case 98: return new CityInfo("La Fortuna", "01", 10.47089, -84.64535);
case 99: return new CityInfo("Florencia", "01", 10.36131, -84.47496);
case 100: return new CityInfo("Esquipulas", "01", 10.05676, -84.42337);
case 101: return new CityInfo("Esparza", "07", 9.99447, -84.66466);
case 102: return new CityInfo("Escazú", "08", 9.91887, -84.13989);
case 103: return new CityInfo("Desamparados", "01", 9.94727, -84.50626);
case 104: return new CityInfo("Daniel Flores", "08", 9.33554, -83.6694);
case 105: return new CityInfo("Curridabat", "08", 9.91179, -84.03407);
case 106: return new CityInfo("Cot", "02", 9.89449, -83.87302);
case 107: return new CityInfo("Corredor", "07", 8.64002, -82.946);
case 108: return new CityInfo("Concepción", "02", 9.93333, -84);
case 109: return new CityInfo("Colón", "08", 9.91491, -84.2417);
case 110: return new CityInfo("Colima", "08", 9.95091, -84.08503);
case 111: return new CityInfo("Ciudad Cortés", "07", 8.95988, -83.52381);
case 112: return new CityInfo("Chacarita", "07", 9.98424, -84.77892);
case 113: return new CityInfo("Cartago", "02", 9.86444, -83.91944);
case 114: return new CityInfo("Carrillos", "01", 10.02918, -84.27403);
case 115: return new CityInfo("Capellades", "02", 9.92171, -83.78507);
case 116: return new CityInfo("Canoas", "07", 8.53305, -82.83844);
case 117: return new CityInfo("Cañas", "03", 10.43105, -85.09825);
case 118: return new CityInfo("Calle Blancos", "08", 9.95, -84.06667);
case 119: return new CityInfo("Cahuita", "06", 9.73781, -82.84042);
case 120: return new CityInfo("Buenos Aires", "07", 9.17189, -83.33417);
case 121: return new CityInfo("Bijagua", "01", 10.73279, -85.05676);
case 122: return new CityInfo("Belén", "03", 10.40789, -85.58836);
case 123: return new CityInfo("Bejuco", "03", 9.85014, -85.32923);
case 124: return new CityInfo("Batán", "06", 10.08354, -83.33413);
case 125: return new CityInfo("Barrio Jesús", "01", 9.97439, -84.42166);
case 126: return new CityInfo("Bagaces", "03", 10.52541, -85.25537);
case 127: return new CityInfo("Atenas", "01", 9.97489, -84.37886);
case 128: return new CityInfo("Aserrí", "08", 9.85876, -84.0923);
case 129: return new CityInfo("Ángeles", "04", 9.99591, -84.05126);
case 130: return new CityInfo("Alajuelita", "08", 9.90163, -84.10042);
case 131: return new CityInfo("Alajuela", "01", 10.01625, -84.21163);
case 132: return new CityInfo("San Vicente de Moravia", "08", 9.96164, -84.0488);
case 133: return new CityInfo("Cariari", "06", 10.35719, -83.7362);
default: return new CityInfo("Dulce Nombre de Jesus", "08", 10.15144, -83.97748);

                                    }                                        
                                }
                            
                        }
                    }
                