
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
                                    public const string Country = "UZ";
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
                            
                                        var cur = (Math.Abs(42.45306 - lat) + Math.Abs(59.61028 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(43.76833 - lat) + Math.Abs(59.02139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.8395 - lat) + Math.Abs(59.00093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.40881 - lat) + Math.Abs(59.44544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.77667 - lat) + Math.Abs(59.60778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01907 - lat) + Math.Abs(59.36425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.06874 - lat) + Math.Abs(58.90372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59889 - lat) + Math.Abs(59.53444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05207 - lat) + Math.Abs(58.84596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92952 - lat) + Math.Abs(59.78199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77877 - lat) + Math.Abs(59.03039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63433 - lat) + Math.Abs(58.9306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7417 - lat) + Math.Abs(64.17962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96056 - lat) + Math.Abs(68.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69395 - lat) + Math.Abs(65.67512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73982 - lat) + Math.Abs(67.6479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41902 - lat) + Math.Abs(67.26118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91878 - lat) + Math.Abs(65.41217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22417 - lat) + Math.Abs(67.27833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60139 - lat) + Math.Abs(67.09083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60861 - lat) + Math.Abs(66.28667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99944 - lat) + Math.Abs(67.7875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05778 - lat) + Math.Abs(66.83417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98322 - lat) + Math.Abs(71.80512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65417 - lat) + Math.Abs(66.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92944 - lat) + Math.Abs(64.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86056 - lat) + Math.Abs(65.78905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99249 - lat) + Math.Abs(66.85012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25528 - lat) + Math.Abs(65.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85143 - lat) + Math.Abs(65.27789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87904 - lat) + Math.Abs(66.75055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12158 - lat) + Math.Abs(66.88605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90546 - lat) + Math.Abs(66.26556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.0375 - lat) + Math.Abs(65.585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50056 - lat) + Math.Abs(64.79361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53333 - lat) + Math.Abs(63.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50699 - lat) + Math.Abs(63.84884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.72746 - lat) + Math.Abs(64.55466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96639 - lat) + Math.Abs(66.48611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62083 - lat) + Math.Abs(66.24806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85721 - lat) + Math.Abs(64.44641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71611 - lat) + Math.Abs(66.66417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69889 - lat) + Math.Abs(67.09333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26746 - lat) + Math.Abs(67.89886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7644 - lat) + Math.Abs(66.91626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03361 - lat) + Math.Abs(66.57222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92002 - lat) + Math.Abs(66.86228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69413 - lat) + Math.Abs(66.827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76003 - lat) + Math.Abs(67.27441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77472 - lat) + Math.Abs(64.42861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82139 - lat) + Math.Abs(65.65306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20835 - lat) + Math.Abs(67.20664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.415 - lat) + Math.Abs(63.80333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92675 - lat) + Math.Abs(65.92953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92139 - lat) + Math.Abs(65.92528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50308 - lat) + Math.Abs(64.81142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65417 - lat) + Math.Abs(66.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.34185 - lat) + Math.Abs(66.56342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05206 - lat) + Math.Abs(66.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04472 - lat) + Math.Abs(65.59082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12251 - lat) + Math.Abs(66.8757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25778 - lat) + Math.Abs(65.15674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81107 - lat) + Math.Abs(65.64246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62596 - lat) + Math.Abs(66.24515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81998 - lat) + Math.Abs(66.46441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02727 - lat) + Math.Abs(66.58083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.97664 - lat) + Math.Abs(66.68867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64501 - lat) + Math.Abs(65.68952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97724 - lat) + Math.Abs(71.13467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03106 - lat) + Math.Abs(65.66619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08083 - lat) + Math.Abs(68.16454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38903 - lat) + Math.Abs(67.82169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98333 - lat) + Math.Abs(68.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49528 - lat) + Math.Abs(67.87594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66139 - lat) + Math.Abs(71.74361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37583 - lat) + Math.Abs(70.81556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11202 - lat) + Math.Abs(69.0471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.275 - lat) + Math.Abs(68.8225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02539 - lat) + Math.Abs(65.96095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19474 - lat) + Math.Abs(71.72385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55389 - lat) + Math.Abs(71.14667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41517 - lat) + Math.Abs(67.17946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0059 - lat) + Math.Abs(64.37356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11919 - lat) + Math.Abs(70.09406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17424 - lat) + Math.Abs(71.73013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00033 - lat) + Math.Abs(64.50213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08073 - lat) + Math.Abs(71.92331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18667 - lat) + Math.Abs(69.14528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55 - lat) + Math.Abs(60.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12694 - lat) + Math.Abs(68.49444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20447 - lat) + Math.Abs(67.90396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11371 - lat) + Math.Abs(72.07915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54222 - lat) + Math.Abs(71.06083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0321 - lat) + Math.Abs(69.36253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99984 - lat) + Math.Abs(71.51162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47722 - lat) + Math.Abs(71.76778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26465 - lat) + Math.Abs(69.21627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91617 - lat) + Math.Abs(71.57819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.7508 - lat) + Math.Abs(64.61711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01171 - lat) + Math.Abs(60.30111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24861 - lat) + Math.Abs(69.79667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84361 - lat) + Math.Abs(68.66167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65583 - lat) + Math.Abs(60.3025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71331 - lat) + Math.Abs(72.05706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12 - lat) + Math.Abs(64.50139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37222 - lat) + Math.Abs(69.38167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35667 - lat) + Math.Abs(71.28472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.535 - lat) + Math.Abs(60.34556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52861 - lat) + Math.Abs(70.9425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89722 - lat) + Math.Abs(69.35056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8977 - lat) + Math.Abs(72.2449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01136 - lat) + Math.Abs(66.23113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.29444 - lat) + Math.Abs(69.67639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87361 - lat) + Math.Abs(71.10889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31181 - lat) + Math.Abs(67.95667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92936 - lat) + Math.Abs(72.49687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84472 - lat) + Math.Abs(69.59833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90639 - lat) + Math.Abs(69.63833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56139 - lat) + Math.Abs(65.68861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55 - lat) + Math.Abs(61.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08444 - lat) + Math.Abs(65.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48104 - lat) + Math.Abs(70.77093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9983 - lat) + Math.Abs(71.67257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50236 - lat) + Math.Abs(72.32646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48048 - lat) + Math.Abs(72.31388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47237 - lat) + Math.Abs(71.72463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.11556 - lat) + Math.Abs(60.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64153 - lat) + Math.Abs(72.23868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03306 - lat) + Math.Abs(64.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85444 - lat) + Math.Abs(72.30734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29721 - lat) + Math.Abs(71.98026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73192 - lat) + Math.Abs(72.76177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42722 - lat) + Math.Abs(71.71889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43553 - lat) + Math.Abs(71.76721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38972 - lat) + Math.Abs(69.465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66886 - lat) + Math.Abs(72.56002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37833 - lat) + Math.Abs(60.36389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42762 - lat) + Math.Abs(71.50534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91667 - lat) + Math.Abs(72.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24944 - lat) + Math.Abs(71.54738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.02207 - lat) + Math.Abs(60.01701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27593 - lat) + Math.Abs(65.14511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12341 - lat) + Math.Abs(67.82842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55389 - lat) + Math.Abs(69.70083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31944 - lat) + Math.Abs(61.07417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84472 - lat) + Math.Abs(60.39194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48972 - lat) + Math.Abs(68.78417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10223 - lat) + Math.Abs(64.68226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13111 - lat) + Math.Abs(63.45713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55806 - lat) + Math.Abs(69.77083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02696 - lat) + Math.Abs(67.58781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66473 - lat) + Math.Abs(68.16768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38421 - lat) + Math.Abs(71.78432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01944 - lat) + Math.Abs(68.94083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52881 - lat) + Math.Abs(68.03153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58389 - lat) + Math.Abs(70.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00329 - lat) + Math.Abs(71.23791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46889 - lat) + Math.Abs(69.58222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93633 - lat) + Math.Abs(68.76128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56667 - lat) + Math.Abs(70.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06924 - lat) + Math.Abs(71.82372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62907 - lat) + Math.Abs(72.50212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81108 - lat) + Math.Abs(69.19417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19761 - lat) + Math.Abs(65.33527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43583 - lat) + Math.Abs(70.61028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69111 - lat) + Math.Abs(60.7525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20972 - lat) + Math.Abs(69.33417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22083 - lat) + Math.Abs(69.26972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90499 - lat) + Math.Abs(71.84737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46306 - lat) + Math.Abs(71.21222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01667 - lat) + Math.Abs(70.14361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78206 - lat) + Math.Abs(72.34424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80104 - lat) + Math.Abs(72.17306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39194 - lat) + Math.Abs(71.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71984 - lat) + Math.Abs(72.64282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74649 - lat) + Math.Abs(71.70031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52204 - lat) + Math.Abs(72.07292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69904 - lat) + Math.Abs(60.75501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56055 - lat) + Math.Abs(61.0018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84607 - lat) + Math.Abs(60.94744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.12215 - lat) + Math.Abs(60.06276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.15001 - lat) + Math.Abs(63.55221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13782 - lat) + Math.Abs(65.37545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0254 - lat) + Math.Abs(64.82885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56762 - lat) + Math.Abs(65.67947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26327 - lat) + Math.Abs(71.54239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07703 - lat) + Math.Abs(71.81772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87642 - lat) + Math.Abs(71.1022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00334 - lat) + Math.Abs(71.51056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5205 - lat) + Math.Abs(71.66015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25363 - lat) + Math.Abs(66.68849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Nukus", "09", 42.45306, 59.61028);
case 1: return new CityInfo("Mŭynoq", "09", 43.76833, 59.02139);
case 2: return new CityInfo("Qanliko‘l", "09", 42.8395, 59.00093);
case 3: return new CityInfo("Xo‘jayli Shahri", "09", 42.40881, 59.44544);
case 4: return new CityInfo("Kegeyli Shahar", "09", 42.77667, 59.60778);
case 5: return new CityInfo("Qozonketkan", "09", 43.01907, 59.36425);
case 6: return new CityInfo("Oltinko‘l", "09", 43.06874, 58.90372);
case 7: return new CityInfo("Oqmang‘it", "09", 42.59889, 59.53444);
case 8: return new CityInfo("Qo‘ng‘irot Shahri", "09", 43.05207, 58.84596);
case 9: return new CityInfo("Chimboy Shahri", "09", 42.92952, 59.78199);
case 10: return new CityInfo("Mo‘ynoq Shahri", "09", 43.77877, 59.03039);
case 11: return new CityInfo("Shumanay Shahri", "09", 42.63433, 58.9306);
case 12: return new CityInfo("Jondor Shaharchasi", "02", 39.7417, 64.17962);
case 13: return new CityInfo("Zomin Shaharchasi", "15", 39.96056, 68.39583);
case 14: return new CityInfo("Nishon Tumani", "08", 38.69395, 65.67512);
case 15: return new CityInfo("Usmat Shaharchasi", "15", 39.73982, 67.6479);
case 16: return new CityInfo("Urgut Shahri", "10", 39.41902, 67.26118);
case 17: return new CityInfo("Mug‘lon Shahar", "08", 38.91878, 65.41217);
case 18: return new CityInfo("Tirmiz", "12", 37.22417, 67.27833);
case 19: return new CityInfo("Toyloq Qishlog’i", "10", 39.60139, 67.09083);
case 20: return new CityInfo("Nurobod Shahri", "10", 39.60861, 66.28667);
case 21: return new CityInfo("Sho‘rchi", "12", 37.99944, 67.7875);
case 22: return new CityInfo("Shahrisabz", "08", 39.05778, 66.83417);
case 23: return new CityInfo("Shohimardon", "03", 39.98322, 71.80512);
case 24: return new CityInfo("Samarkand", "10", 39.65417, 66.95972);
case 25: return new CityInfo("Romitan Shahri", "02", 39.92944, 64.37944);
case 26: return new CityInfo("Qarshi", "08", 38.86056, 65.78905);
case 27: return new CityInfo("Payariq Shahri", "10", 39.99249, 66.85012);
case 28: return new CityInfo("Muborak", "08", 39.25528, 65.15278);
case 29: return new CityInfo("Yangi Mirishkor", "08", 38.85143, 65.27789);
case 30: return new CityInfo("Loyish Shaharchasi", "10", 39.87904, 66.75055);
case 31: return new CityInfo("Kitob", "08", 39.12158, 66.88605);
case 32: return new CityInfo("Kattaqo’rg’on Shahri", "10", 39.90546, 66.26556);
case 33: return new CityInfo("Koson", "08", 39.0375, 65.585);
case 34: return new CityInfo("Qorovulbozor", "02", 39.50056, 64.79361);
case 35: return new CityInfo("Karakul’", "02", 39.53333, 63.83333);
case 36: return new CityInfo("Qorako‘l Shahri", "02", 39.50699, 63.84884);
case 37: return new CityInfo("Kogon Shahri", "02", 39.72746, 64.55466);
case 38: return new CityInfo("Ishtixon Shahri", "10", 39.96639, 66.48611);
case 39: return new CityInfo("G‘uzor", "08", 38.62083, 66.24806);
case 40: return new CityInfo("Galaosiyo Shahri", "02", 39.85721, 64.44641);
case 41: return new CityInfo("Juma Shahri", "10", 39.71611, 66.66417);
case 42: return new CityInfo("Jomboy Shahri", "10", 39.69889, 67.09333);
case 43: return new CityInfo("Denov", "12", 38.26746, 67.89886);
case 44: return new CityInfo("Dahbed", "10", 39.7644, 66.91626);
case 45: return new CityInfo("Chiroqchi", "08", 39.03361, 66.57222);
case 46: return new CityInfo("Chelak", "10", 39.92002, 66.86228);
case 47: return new CityInfo("Charxin", "10", 39.69413, 66.827);
case 48: return new CityInfo("Bulung’ur Shahri", "10", 39.76003, 67.27441);
case 49: return new CityInfo("Bukhara", "02", 39.77472, 64.42861);
case 50: return new CityInfo("Beshkent", "08", 38.82139, 65.65306);
case 51: return new CityInfo("Boysun", "12", 38.20835, 67.20664);
case 52: return new CityInfo("Olot Shahri", "02", 39.415, 63.80333);
case 53: return new CityInfo("Oqtosh Shahri", "10", 39.92675, 65.92953);
case 54: return new CityInfo("Oqtosh", "10", 39.92139, 65.92528);
case 55: return new CityInfo("Qorovulbozor Shahri", "02", 39.50308, 64.81142);
case 56: return new CityInfo("Samarqand Shahri", "10", 39.65417, 66.95972);
case 57: return new CityInfo("Qorashina", "08", 38.34185, 66.56342);
case 58: return new CityInfo("Shahrisabz Shahri", "08", 39.05206, 66.82083);
case 59: return new CityInfo("Koson Shahri", "08", 39.04472, 65.59082);
case 60: return new CityInfo("Kitob Shahri", "08", 39.12251, 66.8757);
case 61: return new CityInfo("Muborak Shahri", "08", 39.25778, 65.15674);
case 62: return new CityInfo("Beshkent Shahri", "08", 38.81107, 65.64246);
case 63: return new CityInfo("G‘uzor Shahri", "08", 38.62596, 66.24515);
case 64: return new CityInfo("Qamashi Shahri", "08", 38.81998, 66.46441);
case 65: return new CityInfo("Chiroqchi Shahri", "08", 39.02727, 66.58083);
case 66: return new CityInfo("Yakkabog‘ Shahri", "08", 38.97664, 66.68867);
case 67: return new CityInfo("Yangi-Nishon Shahri", "08", 38.64501, 65.68952);
case 68: return new CityInfo("Ravon", "03", 39.97724, 71.13467);
case 69: return new CityInfo("Ziyodin Shaharchasi", "10", 40.03106, 65.66619);
case 70: return new CityInfo("Zarbdor Shaharchasi", "15", 40.08083, 68.16454);
case 71: return new CityInfo("Zafarobod Shaharchasi", "15", 40.38903, 67.82169);
case 72: return new CityInfo("Zafar", "14", 40.98333, 68.9);
case 73: return new CityInfo("G’oliblar Qishlog’i", "15", 40.49528, 67.87594);
case 74: return new CityInfo("Yozyovon", "03", 40.66139, 71.74361);
case 75: return new CityInfo("Yaypan", "03", 40.37583, 70.81556);
case 76: return new CityInfo("Yangiyŭl", "14", 41.11202, 69.0471);
case 77: return new CityInfo("Yangiyer", "16", 40.275, 68.8225);
case 78: return new CityInfo("Yangirabot", "07", 40.02539, 65.96095);
case 79: return new CityInfo("Yangiqo‘rg‘on", "06", 41.19474, 71.72385);
case 80: return new CityInfo("Yangiqo‘rg‘on", "03", 40.55389, 71.14667);
case 81: return new CityInfo("Yangiqishloq Shaharchasi", "15", 40.41517, 67.17946);
case 82: return new CityInfo("Yangibozor Qishlog’i", "02", 40.0059, 64.37356);
case 83: return new CityInfo("Yangiobod", "14", 41.11919, 70.09406);
case 84: return new CityInfo("Vodil", "03", 40.17424, 71.73013);
case 85: return new CityInfo("Vobkent Shahri", "02", 40.00033, 64.50213);
case 86: return new CityInfo("Uychi", "06", 41.08073, 71.92331);
case 87: return new CityInfo("Ŭrtaowul", "14", 41.18667, 69.14528);
case 88: return new CityInfo("Urganch", "05", 41.55, 60.63333);
case 89: return new CityInfo("Dashtobod", "15", 40.12694, 68.49444);
case 90: return new CityInfo("Uchtepa Qishlog’i", "15", 40.20447, 67.90396);
case 91: return new CityInfo("Uchqŭrghon Shahri", "06", 41.11371, 72.07915);
case 92: return new CityInfo("Uchko‘prik", "03", 40.54222, 71.06083);
case 93: return new CityInfo("Tŭytepa", "14", 41.0321, 69.36253);
case 94: return new CityInfo("To‘rqao‘rg‘on", "06", 40.99984, 71.51162);
case 95: return new CityInfo("Toshloq", "03", 40.47722, 71.76778);
case 96: return new CityInfo("Tashkent", "13", 41.26465, 69.21627);
case 97: return new CityInfo("Toshbuloq", "06", 40.91617, 71.57819);
case 98: return new CityInfo("Tomdibuloq", "07", 41.7508, 64.61711);
case 99: return new CityInfo("Taxtako‘pir", "09", 43.01171, 60.30111);
case 100: return new CityInfo("Sŭqoq", "14", 41.24861, 69.79667);
case 101: return new CityInfo("Sirdaryo", "16", 40.84361, 68.66167);
case 102: return new CityInfo("Showot", "05", 41.65583, 60.3025);
case 103: return new CityInfo("Shahrixon", "01", 40.71331, 72.05706);
case 104: return new CityInfo("Shofirkon Shahri", "02", 40.12, 64.50139);
case 105: return new CityInfo("Salor", "14", 41.37222, 69.38167);
case 106: return new CityInfo("Rishton", "03", 40.35667, 71.28472);
case 107: return new CityInfo("Qŭshkŭpir", "05", 41.535, 60.34556);
case 108: return new CityInfo("Qo‘qon", "03", 40.52861, 70.9425);
case 109: return new CityInfo("Piskent", "14", 40.89722, 69.35056);
case 110: return new CityInfo("Poytug‘", "01", 40.8977, 72.2449);
case 111: return new CityInfo("Payshamba Shahri", "10", 40.01136, 66.23113);
case 112: return new CityInfo("Parkent", "14", 41.29444, 69.67639);
case 113: return new CityInfo("Pop", "06", 40.87361, 71.10889);
case 114: return new CityInfo("Paxtakor Shahri", "15", 40.31181, 67.95667);
case 115: return new CityInfo("Paxtaobod", "01", 40.92936, 72.49687);
case 116: return new CityInfo("Olmaliq", "14", 40.84472, 69.59833);
case 117: return new CityInfo("Ohangaron", "14", 40.90639, 69.63833);
case 118: return new CityInfo("Nurota", "07", 40.56139, 65.68861);
case 119: return new CityInfo("Novyy Turtkul’", "09", 41.55, 61.01667);
case 120: return new CityInfo("Navoiy", "07", 40.08444, 65.37917);
case 121: return new CityInfo("Navbahor", "03", 40.48104, 70.77093);
case 122: return new CityInfo("Namangan", "06", 40.9983, 71.67257);
case 123: return new CityInfo("Marhamat", "01", 40.50236, 72.32646);
case 124: return new CityInfo("Marhamat", "01", 40.48048, 72.31388);
case 125: return new CityInfo("Marg‘ilon", "03", 40.47237, 71.72463);
case 126: return new CityInfo("Manghit", "09", 42.11556, 60.05972);
case 127: return new CityInfo("Asaka", "01", 40.64153, 72.23868);
case 128: return new CityInfo("Qiziltepa", "07", 40.03306, 64.85);
case 129: return new CityInfo("Kuyganyor", "01", 40.85444, 72.30734);
case 130: return new CityInfo("Quvasoy", "03", 40.29721, 71.98026);
case 131: return new CityInfo("Qo‘rg‘ontepa", "01", 40.73192, 72.76177);
case 132: return new CityInfo("Yangi Marg‘ilon", "03", 40.42722, 71.71889);
case 133: return new CityInfo("Kirguli", "03", 40.43553, 71.76721);
case 134: return new CityInfo("Qibray", "14", 41.38972, 69.465);
case 135: return new CityInfo("Xo‘jaobod", "01", 40.66886, 72.56002);
case 136: return new CityInfo("Khiwa", "05", 41.37833, 60.36389);
case 137: return new CityInfo("Hamza", "03", 40.42762, 71.50534);
case 138: return new CityInfo("Haqqulobod", "06", 40.91667, 72.11667);
case 139: return new CityInfo("Kosonsoy", "06", 41.24944, 71.54738);
case 140: return new CityInfo("Qorao‘zak", "09", 43.02207, 60.01701);
case 141: return new CityInfo("Konimex", "07", 40.27593, 65.14511);
case 142: return new CityInfo("Jizzax", "15", 40.12341, 67.82842);
case 143: return new CityInfo("Iskandar", "14", 41.55389, 69.70083);
case 144: return new CityInfo("Hazorasp", "05", 41.31944, 61.07417);
case 145: return new CityInfo("Gurlan", "05", 41.84472, 60.39194);
case 146: return new CityInfo("Guliston", "16", 40.48972, 68.78417);
case 147: return new CityInfo("G’ijduvon Shahri", "02", 40.10223, 64.68226);
case 148: return new CityInfo("Gazli", "02", 40.13111, 63.45713);
case 149: return new CityInfo("G‘azalkent", "14", 41.55806, 69.77083);
case 150: return new CityInfo("G’allaorol Shahri", "15", 40.02696, 67.58781);
case 151: return new CityInfo("Gagarin Shahri", "15", 40.66473, 68.16768);
case 152: return new CityInfo("Fergana", "03", 40.38421, 71.78432);
case 153: return new CityInfo("Amir Timur", "14", 41.01944, 68.94083);
case 154: return new CityInfo("Do’stlik Shahri", "15", 40.52881, 68.03153);
case 155: return new CityInfo("Dang‘ara", "03", 40.58389, 70.91444);
case 156: return new CityInfo("Chust", "06", 41.00329, 71.23791);
case 157: return new CityInfo("Chirchiq", "14", 41.46889, 69.58222);
case 158: return new CityInfo("Chinoz", "14", 40.93633, 68.76128);
case 159: return new CityInfo("Kyzyldzhar", "14", 41.56667, 70.01667);
case 160: return new CityInfo("Chortoq", "06", 41.06924, 71.82372);
case 161: return new CityInfo("Buloqboshi", "01", 40.62907, 72.50212);
case 162: return new CityInfo("Bo‘ka", "14", 40.81108, 69.19417);
case 163: return new CityInfo("Beshrabot", "07", 40.19761, 65.33527);
case 164: return new CityInfo("Beshariq", "03", 40.43583, 70.61028);
case 165: return new CityInfo("Beruniy", "09", 41.69111, 60.7525);
case 166: return new CityInfo("Bektemir", "13", 41.20972, 69.33417);
case 167: return new CityInfo("Bekobod", "14", 40.22083, 69.26972);
case 168: return new CityInfo("Baliqchi", "01", 40.90499, 71.84737);
case 169: return new CityInfo("Bag‘dod", "03", 40.46306, 71.21222);
case 170: return new CityInfo("Angren", "14", 41.01667, 70.14361);
case 171: return new CityInfo("Andijon", "01", 40.78206, 72.34424);
case 172: return new CityInfo("Oltinko‘l", "01", 40.80104, 72.17306);
case 173: return new CityInfo("Oltiariq", "03", 40.39194, 71.47417);
case 174: return new CityInfo("Oxunboboyev", "01", 40.71984, 72.64282);
case 175: return new CityInfo("Oqoltin", "01", 40.74649, 71.70031);
case 176: return new CityInfo("Quva", "03", 40.52204, 72.07292);
case 177: return new CityInfo("Beruniy Shahri", "09", 41.69904, 60.75501);
case 178: return new CityInfo("To‘rtko‘l Shahri", "09", 41.56055, 61.0018);
case 179: return new CityInfo("Bo‘ston Shahri", "09", 41.84607, 60.94744);
case 180: return new CityInfo("Mang‘it Shahri", "09", 42.12215, 60.06276);
case 181: return new CityInfo("Uchquduq Shahri", "07", 42.15001, 63.55221);
case 182: return new CityInfo("Karmana Shahri", "07", 40.13782, 65.37545);
case 183: return new CityInfo("Qiziltepa Shahri", "07", 40.0254, 64.82885);
case 184: return new CityInfo("Nurota Shahri", "07", 40.56762, 65.67947);
case 185: return new CityInfo("Kosonsoy Shahri", "06", 41.26327, 71.54239);
case 186: return new CityInfo("Chortoq Shahri", "06", 41.07703, 71.81772);
case 187: return new CityInfo("Pop Shahri", "06", 40.87642, 71.1022);
case 188: return new CityInfo("Tŭragŭrghon Shahri", "06", 41.00334, 71.51056);
case 189: return new CityInfo("Langar", "03", 40.5205, 71.66015);
default: return new CityInfo("Qo’shrabod", "10", 40.25363, 66.68849);

                                    }                                        
                                }
                            
                        }
                    }
                