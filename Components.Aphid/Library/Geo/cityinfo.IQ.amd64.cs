
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
                                    public const string Country = "IQ";
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
                            
                                        var cur = (Math.Abs(36.90547 - lat) + Math.Abs(43.14478 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(37.14871 - lat) + Math.Abs(42.68591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.0362 - lat) + Math.Abs(47.91951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88808 - lat) + Math.Abs(44.63256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61581 - lat) + Math.Abs(43.67861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13923 - lat) + Math.Abs(44.44907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.49118 - lat) + Math.Abs(43.12114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37913 - lat) + Math.Abs(42.44806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.89086 - lat) + Math.Abs(46.45425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85823 - lat) + Math.Abs(42.8482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80851 - lat) + Math.Abs(43.03935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.56687 - lat) + Math.Abs(43.48815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51722 - lat) + Math.Abs(43.22806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.40422 - lat) + Math.Abs(44.32563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35278 - lat) + Math.Abs(45.86682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.1959 - lat) + Math.Abs(43.88568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.71557 - lat) + Math.Abs(44.27857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.61207 - lat) + Math.Abs(44.52372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48229 - lat) + Math.Abs(41.91898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25511 - lat) + Math.Abs(44.88239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.39251 - lat) + Math.Abs(40.98945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27093 - lat) + Math.Abs(43.37758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3071 - lat) + Math.Abs(45.3906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52802 - lat) + Math.Abs(47.29362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18254 - lat) + Math.Abs(45.13017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84069 - lat) + Math.Abs(44.30229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90123 - lat) + Math.Abs(45.41422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.7481 - lat) + Math.Abs(45.55503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.77622 - lat) + Math.Abs(43.57974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.08289 - lat) + Math.Abs(44.62873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68963 - lat) + Math.Abs(44.96057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.3482 - lat) + Math.Abs(45.39065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.46806 - lat) + Math.Abs(44.39222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.61603 - lat) + Math.Abs(44.02488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22781 - lat) + Math.Abs(43.43732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.62805 - lat) + Math.Abs(45.31852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27517 - lat) + Math.Abs(43.59593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18333 - lat) + Math.Abs(44.01193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.63664 - lat) + Math.Abs(42.82768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27757 - lat) + Math.Abs(44.49334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.08599 - lat) + Math.Abs(42.36174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17778 - lat) + Math.Abs(45.98611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.13661 - lat) + Math.Abs(42.37727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27798 - lat) + Math.Abs(43.67065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92922 - lat) + Math.Abs(44.96282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6532 - lat) + Math.Abs(44.54407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86709 - lat) + Math.Abs(42.98845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67482 - lat) + Math.Abs(44.07067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19989 - lat) + Math.Abs(42.82361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72057 - lat) + Math.Abs(45.57138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53356 - lat) + Math.Abs(44.8343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.96588 - lat) + Math.Abs(47.00196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92915 - lat) + Math.Abs(43.48878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17454 - lat) + Math.Abs(43.01233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.75403 - lat) + Math.Abs(44.60518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.62054 - lat) + Math.Abs(45.94908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12163 - lat) + Math.Abs(43.2709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69631 - lat) + Math.Abs(45.07782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.01485 - lat) + Math.Abs(44.14574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31556 - lat) + Math.Abs(44.03533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.34058 - lat) + Math.Abs(44.40088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.11508 - lat) + Math.Abs(45.93344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.39213 - lat) + Math.Abs(47.70175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69595 - lat) + Math.Abs(43.35202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2306 - lat) + Math.Abs(43.99442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.67444 - lat) + Math.Abs(44.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.92556 - lat) + Math.Abs(44.77583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56496 - lat) + Math.Abs(45.4329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.33198 - lat) + Math.Abs(45.2944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.50464 - lat) + Math.Abs(44.53943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.58376 - lat) + Math.Abs(44.64675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.40906 - lat) + Math.Abs(46.1727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96257 - lat) + Math.Abs(44.60075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.03718 - lat) + Math.Abs(40.28586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52845 - lat) + Math.Abs(45.20377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.26964 - lat) + Math.Abs(43.91067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.72079 - lat) + Math.Abs(46.10778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.42056 - lat) + Math.Abs(43.30778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76038 - lat) + Math.Abs(43.89428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.55621 - lat) + Math.Abs(45.41293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.05799 - lat) + Math.Abs(46.25726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02594 - lat) + Math.Abs(44.34625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.46934 - lat) + Math.Abs(41.94223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.01547 - lat) + Math.Abs(47.43362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.79933 - lat) + Math.Abs(43.29447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29799 - lat) + Math.Abs(44.68282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77872 - lat) + Math.Abs(44.29005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80437 - lat) + Math.Abs(44.4893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.97861 - lat) + Math.Abs(44.93694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.679 - lat) + Math.Abs(46.96948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33271 - lat) + Math.Abs(43.10555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.335 - lat) + Math.Abs(43.11889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.06221 - lat) + Math.Abs(44.36564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.66138 - lat) + Math.Abs(44.40854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.96324 - lat) + Math.Abs(47.26998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.5128 - lat) + Math.Abs(45.81817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.05114 - lat) + Math.Abs(44.44017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.85118 - lat) + Math.Abs(44.52047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80809 - lat) + Math.Abs(44.53343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66789 - lat) + Math.Abs(47.2945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46186 - lat) + Math.Abs(46.68794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.54671 - lat) + Math.Abs(44.22765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46367 - lat) + Math.Abs(44.41963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17419 - lat) + Math.Abs(46.04345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.36351 - lat) + Math.Abs(44.66011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.58481 - lat) + Math.Abs(47.76114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.72444 - lat) + Math.Abs(44.97694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.5729 - lat) + Math.Abs(42.73395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.74311 - lat) + Math.Abs(44.6196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.96972 - lat) + Math.Abs(46.72278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.97421 - lat) + Math.Abs(48.47309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.34913 - lat) + Math.Abs(43.78599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.0426 - lat) + Math.Abs(41.71632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.50852 - lat) + Math.Abs(47.7804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.90941 - lat) + Math.Abs(45.06359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53333 - lat) + Math.Abs(43.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83561 - lat) + Math.Abs(47.14483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09214 - lat) + Math.Abs(43.48769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0643 - lat) + Math.Abs(45.24743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.84667 - lat) + Math.Abs(44.23444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.99289 - lat) + Math.Abs(44.92552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.45597 - lat) + Math.Abs(43.79341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.90692 - lat) + Math.Abs(44.48649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.44636 - lat) + Math.Abs(47.97813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.30563 - lat) + Math.Abs(44.18477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11207 - lat) + Math.Abs(45.68663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.50316 - lat) + Math.Abs(47.81507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32592 - lat) + Math.Abs(43.77267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.00193 - lat) + Math.Abs(44.03827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12062 - lat) + Math.Abs(44.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20067 - lat) + Math.Abs(44.13263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.63665 - lat) + Math.Abs(44.8882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3209 - lat) + Math.Abs(41.87656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20901 - lat) + Math.Abs(45.25926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.36857 - lat) + Math.Abs(41.98194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13963 - lat) + Math.Abs(42.56995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27899 - lat) + Math.Abs(44.48815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.17649 - lat) + Math.Abs(48.39775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.48117 - lat) + Math.Abs(48.01424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12287 - lat) + Math.Abs(46.74928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12659 - lat) + Math.Abs(45.28292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14246 - lat) + Math.Abs(42.68187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31975 - lat) + Math.Abs(45.68948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zāwītah", "08", 36.90547, 43.14478);
case 1: return new CityInfo("Zaxo", "08", 37.14871, 42.68591);
case 2: return new CityInfo("Umm Qaşr", "02", 30.0362, 47.91951);
case 3: return new CityInfo("Tozkhurmato", "18", 34.88808, 44.63256);
case 4: return new CityInfo("Tikrīt", "18", 34.61581, 43.67861);
case 5: return new CityInfo("Dāqūq", "13", 35.13923, 44.44907);
case 6: return new CityInfo("Tallkayf", "15", 36.49118, 43.12114);
case 7: return new CityInfo("Tall ‘Afar", "15", 36.37913, 42.44806);
case 8: return new CityInfo("Sūq ash Shuyūkh", "09", 30.89086, 46.45425);
case 9: return new CityInfo("Saymayl", "08", 36.85823, 42.8482);
case 10: return new CityInfo("Sīnah", "08", 36.80851, 43.03935);
case 11: return new CityInfo("‘Ayn Tamr", "12", 32.56687, 43.48815);
case 12: return new CityInfo("Ash Sharqāt", "18", 35.51722, 43.22806);
case 13: return new CityInfo("Shaqlāwah", "11", 36.40422, 44.32563);
case 14: return new CityInfo("Seyid Sadiq", "05", 35.35278, 45.86682);
case 15: return new CityInfo("Sāmarrā’", "18", 34.1959, 43.88568);
case 16: return new CityInfo("Nāḩīyat Saddat al Hindīyah", "06", 32.71557, 44.27857);
case 17: return new CityInfo("Ṟuwandiz", "11", 36.61207, 44.52372);
case 18: return new CityInfo("Rāwah", "01", 34.48229, 41.91898);
case 19: return new CityInfo("Ṟaniye", "05", 36.25511, 44.88239);
case 20: return new CityInfo("Al Qā’im", "01", 34.39251, 40.98945);
case 21: return new CityInfo("Al-Hamdaniya", "15", 36.27093, 43.37758);
case 22: return new CityInfo("Qeredagh", "05", 35.3071, 45.3906);
case 23: return new CityInfo("Qal‘at Şāliḩ", "14", 31.52802, 47.29362);
case 24: return new CityInfo("Qeładizê", "05", 36.18254, 45.13017);
case 25: return new CityInfo("Mêrgasur", "11", 36.84069, 44.30229);
case 26: return new CityInfo("Mawet", "05", 35.90123, 45.41422);
case 27: return new CityInfo("Mandalī", "10", 33.7481, 45.55503);
case 28: return new CityInfo("Mexmur", "11", 35.77622, 43.57974);
case 29: return new CityInfo("Koysinceq", "11", 36.08289, 44.62873);
case 30: return new CityInfo("Kifrī", "10", 34.68963, 44.96057);
case 31: return new CityInfo("Khānaqīn", "10", 34.3482, 45.39065);
case 32: return new CityInfo("Kirkuk", "13", 35.46806, 44.39222);
case 33: return new CityInfo("Karbala", "12", 32.61603, 44.02488);
case 34: return new CityInfo("Ain Nuni", "08", 37.22781, 43.43732);
case 35: return new CityInfo("Kelar", "05", 34.62805, 45.31852);
case 36: return new CityInfo("Al ‘Abbāsī", "13", 35.27517, 43.59593);
case 37: return new CityInfo("Erbil", "11", 36.18333, 44.01193);
case 38: return new CityInfo("Hīt", "01", 33.63664, 42.82768);
case 39: return new CityInfo("Hīrān", "11", 36.27757, 44.49334);
case 40: return new CityInfo("Al Ḩaqlānīyah", "01", 34.08599, 42.36174);
case 41: return new CityInfo("Ḩalabjah", "05", 35.17778, 45.98611);
case 42: return new CityInfo("Ḩadīthah", "01", 34.13661, 42.37727);
case 43: return new CityInfo("Xebat", "11", 36.27798, 43.67065);
case 44: return new CityInfo("Dukan", "05", 35.92922, 44.96282);
case 45: return new CityInfo("Soran", "11", 36.6532, 44.54407);
case 46: return new CityInfo("Dihok", "08", 36.86709, 42.98845);
case 47: return new CityInfo("Dibis", "13", 35.67482, 44.07067);
case 48: return new CityInfo("Derkar", "08", 37.19989, 42.82361);
case 49: return new CityInfo("Chwarta", "05", 35.72057, 45.57138);
case 50: return new CityInfo("Jamjamāl", "05", 35.53356, 44.8343);
case 51: return new CityInfo("Al Jabāyish", "09", 30.96588, 47.00196);
case 52: return new CityInfo("Bayjī", "18", 34.92915, 43.48878);
case 53: return new CityInfo("Batifa", "08", 37.17454, 43.01233);
case 54: return new CityInfo("Baqubah", "10", 33.75403, 44.60518);
case 55: return new CityInfo("Baynjiwayn", "05", 35.62054, 45.94908);
case 56: return new CityInfo("Bāmarnī", "08", 37.12163, 43.2709);
case 57: return new CityInfo("Baladrūz", "10", 33.69631, 45.07782);
case 58: return new CityInfo("Balad", "18", 34.01485, 44.14574);
case 59: return new CityInfo("Beḧirke", "11", 36.31556, 44.03533);
case 60: return new CityInfo("Baghdad", "07", 33.34058, 44.40088);
case 61: return new CityInfo("Badrah", "16", 33.11508, 45.93344);
case 62: return new CityInfo("Az Zubayr", "02", 30.39213, 47.70175);
case 63: return new CityInfo("Ash Shaykhān", "15", 36.69595, 43.35202);
case 64: return new CityInfo("‘Aynkāwah", "11", 36.2306, 43.99442);
case 65: return new CityInfo("Aţ Ţārmīyah", "07", 33.67444, 44.39583);
case 66: return new CityInfo("Aş Şuwayrah", "16", 32.92556, 44.77583);
case 67: return new CityInfo("As Sulaymānīyah", "05", 35.56496, 45.4329);
case 68: return new CityInfo("As Samawah", "03", 31.33198, 45.2944);
case 69: return new CityInfo("As Salmān", "03", 30.50464, 44.53943);
case 70: return new CityInfo("Nāḩiyat ash Shināfīyah", "04", 31.58376, 44.64675);
case 71: return new CityInfo("Ash Shaţrah", "09", 31.40906, 46.1727);
case 72: return new CityInfo("Ash Shāmīyah", "04", 31.96257, 44.60075);
case 73: return new CityInfo("Ar Ruţbah", "01", 33.03718, 40.28586);
case 74: return new CityInfo("Ar Rumaythah", "03", 31.52845, 45.20377);
case 75: return new CityInfo("Ar Riyāḑ", "13", 35.26964, 43.91067);
case 76: return new CityInfo("Ar Rifā‘ī", "09", 31.72079, 46.10778);
case 77: return new CityInfo("Ramadi", "01", 33.42056, 43.30778);
case 78: return new CityInfo("‘Aqrah", "15", 36.76038, 43.89428);
case 79: return new CityInfo("An Nu‘mānīyah", "16", 32.55621, 45.41293);
case 80: return new CityInfo("Nasiriyah", "09", 31.05799, 46.25726);
case 81: return new CityInfo("Najaf", "17", 32.02594, 44.34625);
case 82: return new CityInfo("‘Anat al Qadīmah", "01", 34.46934, 41.94223);
case 83: return new CityInfo("Al Qurnah", "02", 31.01547, 47.43362);
case 84: return new CityInfo("Al Qayyārah", "15", 35.79933, 43.29447);
case 85: return new CityInfo("Imam Qasim", "06", 32.29799, 44.68282);
case 86: return new CityInfo("Al Musayyib", "06", 32.77872, 44.29005);
case 87: return new CityInfo("Al Mishkhāb", "17", 31.80437, 44.4893);
case 88: return new CityInfo("Al Miqdādīyah", "10", 33.97861, 44.93694);
case 89: return new CityInfo("Al Maymūnah", "14", 31.679, 46.96948);
case 90: return new CityInfo("Al Mawşil al Jadīdah", "15", 36.33271, 43.10555);
case 91: return new CityInfo("Mosul", "15", 36.335, 43.11889);
case 92: return new CityInfo("Al Maḩmūdīyah", "07", 33.06221, 44.36564);
case 93: return new CityInfo("Al Maḩāwīl", "06", 32.66138, 44.40854);
case 94: return new CityInfo("Al Madīnah", "02", 30.96324, 47.26998);
case 95: return new CityInfo("Al Kūt", "16", 32.5128, 45.81817);
case 96: return new CityInfo("Kufa", "17", 32.05114, 44.44017);
case 97: return new CityInfo("Al Khāliş", "10", 33.85118, 44.52047);
case 98: return new CityInfo("Khāliş", "10", 33.80809, 44.53343);
case 99: return new CityInfo("Al Kaḩlā’", "14", 31.66789, 47.2945);
case 100: return new CityInfo("‘Alī al Gharbī", "14", 32.46186, 46.68794);
case 101: return new CityInfo("Al Hindīyah", "12", 32.54671, 44.22765);
case 102: return new CityInfo("Al Ḩillah", "06", 32.46367, 44.41963);
case 103: return new CityInfo("Al Ḩayy", "16", 32.17419, 46.04345);
case 104: return new CityInfo("Al Hāshimīyah", "06", 32.36351, 44.66011);
case 105: return new CityInfo("Al Hārithah", "02", 30.58481, 47.76114);
case 106: return new CityInfo("Al Ḩamzah", "04", 31.72444, 44.97694);
case 107: return new CityInfo("Al Ḩaḑar", "15", 35.5729, 42.73395);
case 108: return new CityInfo("Nahiyat Ghammas", "04", 31.74311, 44.6196);
case 109: return new CityInfo("Nāḩiyat al Fuhūd", "09", 30.96972, 46.72278);
case 110: return new CityInfo("Al Fāw", "02", 29.97421, 48.47309);
case 111: return new CityInfo("Al Fallūjah", "01", 33.34913, 43.78599);
case 112: return new CityInfo("Al Ba‘āj", "15", 36.0426, 41.71632);
case 113: return new CityInfo("Basrah", "02", 30.50852, 47.7804);
case 114: return new CityInfo("Al ‘Azīzīyah", "16", 32.90941, 45.06359);
case 115: return new CityInfo("Al ‘Awjah", "18", 34.53333, 43.73333);
case 116: return new CityInfo("Al ‘Amārah", "14", 31.83561, 47.14483);
case 117: return new CityInfo("Al ‘Amādīyah", "08", 37.09214, 43.48769);
case 118: return new CityInfo("‘Afak", "04", 32.0643, 45.24743);
case 119: return new CityInfo("Ad Dujayl", "18", 33.84667, 44.23444);
case 120: return new CityInfo("Ad Dīwānīyah", "04", 31.99289, 44.92552);
case 121: return new CityInfo("Ad Dawr", "18", 34.45597, 43.79341);
case 122: return new CityInfo("Al Manādhirah", "17", 31.90692, 44.48649);
case 123: return new CityInfo("Abī al Khaşīb", "02", 30.44636, 47.97813);
case 124: return new CityInfo("Abū Ghurayb", "07", 33.30563, 44.18477);
case 125: return new CityInfo("Derbendîxan", "05", 35.11207, 45.68663);
case 126: return new CityInfo("Al Başrah al Qadīmah", "02", 30.50316, 47.81507);
case 127: return new CityInfo("Al Ḩawījah", "13", 35.32592, 43.77267);
case 128: return new CityInfo("Qushtepe", "11", 36.00193, 44.03827);
case 129: return new CityInfo("Dare Tû", "11", 36.12062, 44.05972);
case 130: return new CityInfo("Kasnazān", "11", 36.20067, 44.13263);
case 131: return new CityInfo("Choman", "11", 36.63665, 44.8882);
case 132: return new CityInfo("Sinjār", "15", 36.3209, 41.87656);
case 133: return new CityInfo("Halshaw", "05", 36.20901, 45.25926);
case 134: return new CityInfo("‘Anah", "01", 34.36857, 41.98194);
case 135: return new CityInfo("Ibrāhīm al Khalīl", "08", 37.13963, 42.56995);
case 136: return new CityInfo("Nāḩiyat Hīrān", "11", 36.27899, 44.48815);
case 137: return new CityInfo("Nāḩiyat Baḩār", "02", 30.17649, 48.39775);
case 138: return new CityInfo("Nāḩiyat ‘Atbah", "02", 30.48117, 48.01424);
case 139: return new CityInfo("Nāḩiyat Alī ash Sharqī", "14", 32.12287, 46.74928);
case 140: return new CityInfo("Hayraw", "05", 36.12659, 45.28292);
case 141: return new CityInfo("Zaxu", "08", 37.14246, 42.68187);
default: return new CityInfo("Ḩalabjah al Jadīdah", "05", 35.31975, 45.68948);

                                    }                                        
                                }
                            
                        }
                    }
                