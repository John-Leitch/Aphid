
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
                                    public const string Country = "SE";
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
                            
                                        var cur = (Math.Abs(66.43038 - lat) + Math.Abs(20.62434 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(67.67589 - lat) + Math.Abs(21.64204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.72587 - lat) + Math.Abs(20.91548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.83533 - lat) + Math.Abs(20.51908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.71261 - lat) + Math.Abs(21.1658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.82842 - lat) + Math.Abs(20.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.85 - lat) + Math.Abs(20.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.91243 - lat) + Math.Abs(22.65128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.98333 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.8397 - lat) + Math.Abs(20.47857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.03333 - lat) + Math.Abs(20.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.15 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.98333 - lat) + Math.Abs(21.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.65983 - lat) + Math.Abs(21.94004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.68333 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.75067 - lat) + Math.Abs(20.95279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.85482 - lat) + Math.Abs(22.29126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.90383 - lat) + Math.Abs(20.55014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.85573 - lat) + Math.Abs(23.49689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.67171 - lat) + Math.Abs(22.08973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.43333 - lat) + Math.Abs(21.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.85 - lat) + Math.Abs(23.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.35 - lat) + Math.Abs(21.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.19324 - lat) + Math.Abs(20.84806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.80879 - lat) + Math.Abs(20.18901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.81089 - lat) + Math.Abs(23.24496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.77002 - lat) + Math.Abs(21.73113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.31717 - lat) + Math.Abs(21.47944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.21284 - lat) + Math.Abs(23.36607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.38778 - lat) + Math.Abs(23.65425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.32754 - lat) + Math.Abs(22.84414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.88333 - lat) + Math.Abs(21.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.7 - lat) + Math.Abs(20.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.81667 - lat) + Math.Abs(20.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.78333 - lat) + Math.Abs(23.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.41805 - lat) + Math.Abs(21.50151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.73818 - lat) + Math.Abs(20.73206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.55 - lat) + Math.Abs(21.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.17529 - lat) + Math.Abs(20.65495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.58415 - lat) + Math.Abs(22.15465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.36667 - lat) + Math.Abs(21.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.11667 - lat) + Math.Abs(22.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.81667 - lat) + Math.Abs(20.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.18333 - lat) + Math.Abs(20.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.85177 - lat) + Math.Abs(23.05515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.85572 - lat) + Math.Abs(20.22513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.85298 - lat) + Math.Abs(23.15645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.83571 - lat) + Math.Abs(20.98453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.85 - lat) + Math.Abs(20.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.05914 - lat) + Math.Abs(20.03919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.15 - lat) + Math.Abs(21.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.81121 - lat) + Math.Abs(20.40752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.28188 - lat) + Math.Abs(21.40544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.70602 - lat) + Math.Abs(20.36409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.83549 - lat) + Math.Abs(24.13676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.63931 - lat) + Math.Abs(22.01145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.13387 - lat) + Math.Abs(20.65278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.76667 - lat) + Math.Abs(20.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.84806 - lat) + Math.Abs(20.896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.88333 - lat) + Math.Abs(20.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.95258 - lat) + Math.Abs(21.2058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.05992 - lat) + Math.Abs(20.85593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.51667 - lat) + Math.Abs(20.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.61667 - lat) + Math.Abs(21.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.86667 - lat) + Math.Abs(20.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.82518 - lat) + Math.Abs(21.68864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.3 - lat) + Math.Abs(21.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.57791 - lat) + Math.Abs(22.10844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.64179 - lat) + Math.Abs(22.24227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.98333 - lat) + Math.Abs(21.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.55462 - lat) + Math.Abs(21.83551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.45 - lat) + Math.Abs(20.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.26667 - lat) + Math.Abs(21.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.67624 - lat) + Math.Abs(21.00162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.51667 - lat) + Math.Abs(21.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.26667 - lat) + Math.Abs(18.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25 - lat) + Math.Abs(18.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.24167 - lat) + Math.Abs(18.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.03004 - lat) + Math.Abs(17.55203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23333 - lat) + Math.Abs(18.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.70833 - lat) + Math.Abs(19 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.78333 - lat) + Math.Abs(17.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.175 - lat) + Math.Abs(14.94089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.42966 - lat) + Math.Abs(13.82041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.88109 - lat) + Math.Abs(14.24237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.35 - lat) + Math.Abs(14.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.03333 - lat) + Math.Abs(14.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.86091 - lat) + Math.Abs(16.69922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70039 - lat) + Math.Abs(13.7915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.34366 - lat) + Math.Abs(13.66081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.9 - lat) + Math.Abs(17.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.53333 - lat) + Math.Abs(15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.78333 - lat) + Math.Abs(14.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.62941 - lat) + Math.Abs(12.8489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.64089 - lat) + Math.Abs(18.29602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31667 - lat) + Math.Abs(15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.25 - lat) + Math.Abs(14.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.55 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1 - lat) + Math.Abs(13.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.45 - lat) + Math.Abs(13.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.0433 - lat) + Math.Abs(15.87374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.20175 - lat) + Math.Abs(19.71945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.94968 - lat) + Math.Abs(12.54394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.66588 - lat) + Math.Abs(15.85515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.69466 - lat) + Math.Abs(12.69586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.62417 - lat) + Math.Abs(16.65596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24091 - lat) + Math.Abs(17.61486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.29752 - lat) + Math.Abs(15.83141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38304 - lat) + Math.Abs(15.43201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15063 - lat) + Math.Abs(12.57429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(15.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51341 - lat) + Math.Abs(15.7161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.3 - lat) + Math.Abs(17.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(18.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.1 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.60452 - lat) + Math.Abs(18.25601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.42887 - lat) + Math.Abs(15.07762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98333 - lat) + Math.Abs(12.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.45 - lat) + Math.Abs(13.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.47124 - lat) + Math.Abs(13.01971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.22883 - lat) + Math.Abs(12.30986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.31778 - lat) + Math.Abs(12.76722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55 - lat) + Math.Abs(13.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.68333 - lat) + Math.Abs(13.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.16667 - lat) + Math.Abs(12.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.5269 - lat) + Math.Abs(15.29254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.26591 - lat) + Math.Abs(12.3322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63333 - lat) + Math.Abs(13.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41678 - lat) + Math.Abs(13.12008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.87767 - lat) + Math.Abs(14.80906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40225 - lat) + Math.Abs(18.35317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.36667 - lat) + Math.Abs(17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.01667 - lat) + Math.Abs(17.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41667 - lat) + Math.Abs(12.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.49108 - lat) + Math.Abs(13.1121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.64667 - lat) + Math.Abs(11.92944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.7584 - lat) + Math.Abs(16.63733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.94609 - lat) + Math.Abs(16.27794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.61617 - lat) + Math.Abs(16.55276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6 - lat) + Math.Abs(16.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38249 - lat) + Math.Abs(13.85093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.34571 - lat) + Math.Abs(18.04985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.1 - lat) + Math.Abs(13.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.16528 - lat) + Math.Abs(17.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35 - lat) + Math.Abs(14.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.25 - lat) + Math.Abs(12.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(13.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.18604 - lat) + Math.Abs(14.04001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.50486 - lat) + Math.Abs(13.96877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35599 - lat) + Math.Abs(12.3906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.03706 - lat) + Math.Abs(12.80907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.12293 - lat) + Math.Abs(11.70777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26671 - lat) + Math.Abs(17.88407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.10557 - lat) + Math.Abs(12.25078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.26234 - lat) + Math.Abs(12.95413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.50893 - lat) + Math.Abs(14.22458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.91564 - lat) + Math.Abs(19.82438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.90676 - lat) + Math.Abs(19.75712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38075 - lat) + Math.Abs(12.3234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.11491 - lat) + Math.Abs(14.4718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.44179 - lat) + Math.Abs(15.94429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53436 - lat) + Math.Abs(18.07758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4775 - lat) + Math.Abs(12.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.46667 - lat) + Math.Abs(13.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.47744 - lat) + Math.Abs(13.58505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.96133 - lat) + Math.Abs(12.85611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.55 - lat) + Math.Abs(13.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.01667 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06279 - lat) + Math.Abs(14.54388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.2031 - lat) + Math.Abs(16.60225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65 - lat) + Math.Abs(17.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39145 - lat) + Math.Abs(13.18633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(11.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.94587 - lat) + Math.Abs(17.48757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.49807 - lat) + Math.Abs(14.14842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.44863 - lat) + Math.Abs(14.88969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.31667 - lat) + Math.Abs(14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.63333 - lat) + Math.Abs(14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.53333 - lat) + Math.Abs(14.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.85882 - lat) + Math.Abs(17.63889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51839 - lat) + Math.Abs(17.91128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.15807 - lat) + Math.Abs(12.30476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6688 - lat) + Math.Abs(13.13931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.95 - lat) + Math.Abs(13.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.31722 - lat) + Math.Abs(13.24847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.79159 - lat) + Math.Abs(13.41422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66667 - lat) + Math.Abs(13.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.13333 - lat) + Math.Abs(12.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.34784 - lat) + Math.Abs(11.9424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.01667 - lat) + Math.Abs(13.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.08333 - lat) + Math.Abs(11.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.85 - lat) + Math.Abs(17.23306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16037 - lat) + Math.Abs(13.59811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.51667 - lat) + Math.Abs(13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.30532 - lat) + Math.Abs(15.47129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04147 - lat) + Math.Abs(12.3995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31667 - lat) + Math.Abs(17.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.73237 - lat) + Math.Abs(11.73778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.19858 - lat) + Math.Abs(17.83317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(17.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.89621 - lat) + Math.Abs(17.54812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.13846 - lat) + Math.Abs(12.22596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.14474 - lat) + Math.Abs(12.29253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.61667 - lat) + Math.Abs(12.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.28365 - lat) + Math.Abs(12.28864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.17304 - lat) + Math.Abs(18.18507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.37514 - lat) + Math.Abs(13.15691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.7 - lat) + Math.Abs(16.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.05417 - lat) + Math.Abs(12.27899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.57864 - lat) + Math.Abs(13.74916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.48333 - lat) + Math.Abs(13.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.03717 - lat) + Math.Abs(14.9782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.95663 - lat) + Math.Abs(13.07725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72432 - lat) + Math.Abs(11.77013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41667 - lat) + Math.Abs(16.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.13527 - lat) + Math.Abs(13.0082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41251 - lat) + Math.Abs(15.99844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46667 - lat) + Math.Abs(15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.06667 - lat) + Math.Abs(17.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5109 - lat) + Math.Abs(16.47069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1135 - lat) + Math.Abs(13.74516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1 - lat) + Math.Abs(15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.425 - lat) + Math.Abs(12.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.70739 - lat) + Math.Abs(14.12597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.41667 - lat) + Math.Abs(15.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54293 - lat) + Math.Abs(13.9546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.95 - lat) + Math.Abs(12.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.81667 - lat) + Math.Abs(12.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16667 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.93333 - lat) + Math.Abs(13.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50816 - lat) + Math.Abs(11.84431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.2584 - lat) + Math.Abs(17.65606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.9 - lat) + Math.Abs(11.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.99543 - lat) + Math.Abs(13.6279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.71667 - lat) + Math.Abs(15.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.5247 - lat) + Math.Abs(14.97902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.48333 - lat) + Math.Abs(13.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.48654 - lat) + Math.Abs(17.32613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.53333 - lat) + Math.Abs(13.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.96667 - lat) + Math.Abs(16.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.85946 - lat) + Math.Abs(13.42891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.68333 - lat) + Math.Abs(16.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.34269 - lat) + Math.Abs(17.51812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.57467 - lat) + Math.Abs(14.00495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.18035 - lat) + Math.Abs(13.95824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.42453 - lat) + Math.Abs(14.16162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70761 - lat) + Math.Abs(14.32205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.86667 - lat) + Math.Abs(13.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15 - lat) + Math.Abs(16.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.72385 - lat) + Math.Abs(11.32587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.17358 - lat) + Math.Abs(12.22753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.42521 - lat) + Math.Abs(15.68154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81667 - lat) + Math.Abs(15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.3 - lat) + Math.Abs(18.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.86667 - lat) + Math.Abs(16.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.4439 - lat) + Math.Abs(18.06872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.67722 - lat) + Math.Abs(14.08876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53333 - lat) + Math.Abs(15.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.76667 - lat) + Math.Abs(14.43535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.49551 - lat) + Math.Abs(13.11078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.03407 - lat) + Math.Abs(14.36577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.50788 - lat) + Math.Abs(13.23515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.58639 - lat) + Math.Abs(17.90849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.65507 - lat) + Math.Abs(16.02823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.43184 - lat) + Math.Abs(13.71394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.74022 - lat) + Math.Abs(15.90173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26667 - lat) + Math.Abs(14.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.14292 - lat) + Math.Abs(11.81821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.61667 - lat) + Math.Abs(12.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.84431 - lat) + Math.Abs(18.66643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.74273 - lat) + Math.Abs(16.86978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9134 - lat) + Math.Abs(13.10762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.82533 - lat) + Math.Abs(12.01604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.70725 - lat) + Math.Abs(16.22188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33333 - lat) + Math.Abs(11.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83764 - lat) + Math.Abs(13.14302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.1 - lat) + Math.Abs(19.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21667 - lat) + Math.Abs(14.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.39129 - lat) + Math.Abs(17.3063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.45806 - lat) + Math.Abs(17.34889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36128 - lat) + Math.Abs(17.97114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65 - lat) + Math.Abs(15.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.61639 - lat) + Math.Abs(11.78556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.08333 - lat) + Math.Abs(15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33333 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.16667 - lat) + Math.Abs(15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16979 - lat) + Math.Abs(12.83925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.85206 - lat) + Math.Abs(15.55583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.93945 - lat) + Math.Abs(11.1712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55 - lat) + Math.Abs(13.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.64762 - lat) + Math.Abs(18.09909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.52717 - lat) + Math.Abs(16.243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28333 - lat) + Math.Abs(18.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.37741 - lat) + Math.Abs(17.03119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.95933 - lat) + Math.Abs(17.70588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.58333 - lat) + Math.Abs(16.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.0959 - lat) + Math.Abs(17.11731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53183 - lat) + Math.Abs(14.27201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.58333 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.95569 - lat) + Math.Abs(17.78644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.21667 - lat) + Math.Abs(15.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.32468 - lat) + Math.Abs(12.92533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.01667 - lat) + Math.Abs(11.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.71409 - lat) + Math.Abs(15.13169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.47802 - lat) + Math.Abs(13.86611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.41917 - lat) + Math.Abs(16.58727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.33667 - lat) + Math.Abs(17.36583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32938 - lat) + Math.Abs(18.06871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31737 - lat) + Math.Abs(14.59341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.17772 - lat) + Math.Abs(13.82828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.08333 - lat) + Math.Abs(17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.8 - lat) + Math.Abs(16.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(13.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.07046 - lat) + Math.Abs(11.8181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.48333 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.27254 - lat) + Math.Abs(13.71454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.79476 - lat) + Math.Abs(12.31688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.60199 - lat) + Math.Abs(17.80459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.769 - lat) + Math.Abs(12.63034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3344 - lat) + Math.Abs(17.68842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.90188 - lat) + Math.Abs(13.39577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28333 - lat) + Math.Abs(18.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7503 - lat) + Math.Abs(13.19797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36667 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.64277 - lat) + Math.Abs(13.20638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32627 - lat) + Math.Abs(18.07251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06667 - lat) + Math.Abs(16.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03992 - lat) + Math.Abs(13.67811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.13333 - lat) + Math.Abs(15.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18393 - lat) + Math.Abs(15.15633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.53484 - lat) + Math.Abs(17.53702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.73333 - lat) + Math.Abs(16.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.50561 - lat) + Math.Abs(17.51032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13333 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05205 - lat) + Math.Abs(14.57525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36004 - lat) + Math.Abs(18.00086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(14.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42804 - lat) + Math.Abs(17.95093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.16667 - lat) + Math.Abs(17.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.11667 - lat) + Math.Abs(12.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.73993 - lat) + Math.Abs(15.79391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.56667 - lat) + Math.Abs(16.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.71677 - lat) + Math.Abs(13.34659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.19554 - lat) + Math.Abs(17.62525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31278 - lat) + Math.Abs(18.07577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.48057 - lat) + Math.Abs(16.32221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.30373 - lat) + Math.Abs(17.05921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.81667 - lat) + Math.Abs(18.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38333 - lat) + Math.Abs(17.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07011 - lat) + Math.Abs(15.56025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.28333 - lat) + Math.Abs(16.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.45 - lat) + Math.Abs(16.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34337 - lat) + Math.Abs(13.36989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35593 - lat) + Math.Abs(11.22411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14181 - lat) + Math.Abs(15.41416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7 - lat) + Math.Abs(15.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.67413 - lat) + Math.Abs(16.2432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16241 - lat) + Math.Abs(13.41212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72349 - lat) + Math.Abs(14.80627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3227 - lat) + Math.Abs(13.10268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.85 - lat) + Math.Abs(12.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70461 - lat) + Math.Abs(18.8031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36667 - lat) + Math.Abs(15.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.08333 - lat) + Math.Abs(17.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.62507 - lat) + Math.Abs(17.41552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.47839 - lat) + Math.Abs(13.50186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.71667 - lat) + Math.Abs(16.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35 - lat) + Math.Abs(13.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.15 - lat) + Math.Abs(15.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.67646 - lat) + Math.Abs(15.3659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.88333 - lat) + Math.Abs(12.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.39118 - lat) + Math.Abs(13.84506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.29056 - lat) + Math.Abs(17.38694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.44929 - lat) + Math.Abs(12.96067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.13738 - lat) + Math.Abs(15.3394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.03106 - lat) + Math.Abs(16.44713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32472 - lat) + Math.Abs(16.48284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.63643 - lat) + Math.Abs(16.52321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32324 - lat) + Math.Abs(13.46552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.41667 - lat) + Math.Abs(13.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83028 - lat) + Math.Abs(15.69337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42423 - lat) + Math.Abs(16.11746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.47428 - lat) + Math.Abs(14.28283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.43044 - lat) + Math.Abs(14.09383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98333 - lat) + Math.Abs(12.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.40633 - lat) + Math.Abs(13.07693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.9257 - lat) + Math.Abs(11.26931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41208 - lat) + Math.Abs(13.67078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46667 - lat) + Math.Abs(17.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98665 - lat) + Math.Abs(11.55742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.38333 - lat) + Math.Abs(13.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43333 - lat) + Math.Abs(13.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.56667 - lat) + Math.Abs(15.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38659 - lat) + Math.Abs(13.43836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.93333 - lat) + Math.Abs(18.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.39427 - lat) + Math.Abs(15.08659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.18333 - lat) + Math.Abs(12.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.2 - lat) + Math.Abs(12.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15 - lat) + Math.Abs(16.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.91667 - lat) + Math.Abs(12.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48333 - lat) + Math.Abs(14.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28333 - lat) + Math.Abs(13.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71533 - lat) + Math.Abs(12.83495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63135 - lat) + Math.Abs(13.70622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.55653 - lat) + Math.Abs(14.35037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.72199 - lat) + Math.Abs(13.13211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.54095 - lat) + Math.Abs(15.75104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.78333 - lat) + Math.Abs(14.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.61731 - lat) + Math.Abs(17.72361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26667 - lat) + Math.Abs(14.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.58333 - lat) + Math.Abs(13.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.01667 - lat) + Math.Abs(14.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02791 - lat) + Math.Abs(17.93379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27597 - lat) + Math.Abs(17.93072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14696 - lat) + Math.Abs(14.98553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.40327 - lat) + Math.Abs(14.66244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.81872 - lat) + Math.Abs(17.69958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.8 - lat) + Math.Abs(11.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.91667 - lat) + Math.Abs(13.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.54172 - lat) + Math.Abs(12.43429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.34778 - lat) + Math.Abs(15.75051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.50577 - lat) + Math.Abs(11.9321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.69284 - lat) + Math.Abs(13.14257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63333 - lat) + Math.Abs(14.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61667 - lat) + Math.Abs(16.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.76667 - lat) + Math.Abs(12.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.01667 - lat) + Math.Abs(13.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98333 - lat) + Math.Abs(13.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.25893 - lat) + Math.Abs(17.15284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70992 - lat) + Math.Abs(12.79238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28333 - lat) + Math.Abs(18.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.15 - lat) + Math.Abs(13.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98333 - lat) + Math.Abs(12.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.91993 - lat) + Math.Abs(16.60655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71667 - lat) + Math.Abs(15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.13229 - lat) + Math.Abs(12.92888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71667 - lat) + Math.Abs(14.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.86667 - lat) + Math.Abs(14.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.47285 - lat) + Math.Abs(13.58829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.96667 - lat) + Math.Abs(12.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65 - lat) + Math.Abs(12.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.46191 - lat) + Math.Abs(18.18538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98388 - lat) + Math.Abs(14.30849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66667 - lat) + Math.Abs(15.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.46667 - lat) + Math.Abs(14.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.53333 - lat) + Math.Abs(19.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.63333 - lat) + Math.Abs(15.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.10911 - lat) + Math.Abs(16.11424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.01667 - lat) + Math.Abs(14.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.25 - lat) + Math.Abs(14.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56 - lat) + Math.Abs(13.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.58333 - lat) + Math.Abs(17.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.9 - lat) + Math.Abs(18.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.2381 - lat) + Math.Abs(14.57719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(17.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.18333 - lat) + Math.Abs(15.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.20999 - lat) + Math.Abs(15.27602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.93333 - lat) + Math.Abs(11.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43333 - lat) + Math.Abs(15.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.50357 - lat) + Math.Abs(18.45899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.15 - lat) + Math.Abs(12.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26078 - lat) + Math.Abs(15.62143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.80223 - lat) + Math.Abs(16.35014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.64972 - lat) + Math.Abs(16.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.46667 - lat) + Math.Abs(15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.98333 - lat) + Math.Abs(14.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33333 - lat) + Math.Abs(16.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39688 - lat) + Math.Abs(18.39434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13624 - lat) + Math.Abs(15.6865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.75 - lat) + Math.Abs(18.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.4291 - lat) + Math.Abs(18.33386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.83333 - lat) + Math.Abs(15.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.17467 - lat) + Math.Abs(13.59498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65338 - lat) + Math.Abs(12.49791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.88632 - lat) + Math.Abs(15.11787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40197 - lat) + Math.Abs(13.49144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36588 - lat) + Math.Abs(17.99569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.81037 - lat) + Math.Abs(16.63738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.81667 - lat) + Math.Abs(17.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.06667 - lat) + Math.Abs(19.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.53947 - lat) + Math.Abs(16.46791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.76667 - lat) + Math.Abs(16.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22133 - lat) + Math.Abs(18.2985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.1 - lat) + Math.Abs(16.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53333 - lat) + Math.Abs(17.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78333 - lat) + Math.Abs(16.63306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13829 - lat) + Math.Abs(13.39476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.15494 - lat) + Math.Abs(17.6534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16667 - lat) + Math.Abs(16.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.56667 - lat) + Math.Abs(15.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.7395 - lat) + Math.Abs(12.10642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28071 - lat) + Math.Abs(17.84783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06565 - lat) + Math.Abs(15.33747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03333 - lat) + Math.Abs(12.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54014 - lat) + Math.Abs(13.09605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.73621 - lat) + Math.Abs(12.27881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.67057 - lat) + Math.Abs(17.10152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98856 - lat) + Math.Abs(16.3139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.34957 - lat) + Math.Abs(12.89703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.28763 - lat) + Math.Abs(18.58119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61667 - lat) + Math.Abs(16.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.95 - lat) + Math.Abs(14.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19601 - lat) + Math.Abs(13.09199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.42608 - lat) + Math.Abs(12.93595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.58306 - lat) + Math.Abs(16.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46667 - lat) + Math.Abs(13.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.03333 - lat) + Math.Abs(14.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25909 - lat) + Math.Abs(18.37408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18333 - lat) + Math.Abs(17.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.1792 - lat) + Math.Abs(14.63566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33879 - lat) + Math.Abs(18.08487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.82465 - lat) + Math.Abs(15.27357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.2 - lat) + Math.Abs(17.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71806 - lat) + Math.Abs(18.80086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.09188 - lat) + Math.Abs(17.52283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.05 - lat) + Math.Abs(14.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.98333 - lat) + Math.Abs(17.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.8 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.26455 - lat) + Math.Abs(16.44837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.4 - lat) + Math.Abs(18.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.38165 - lat) + Math.Abs(13.99364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.73333 - lat) + Math.Abs(17.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.12034 - lat) + Math.Abs(14.6155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.84058 - lat) + Math.Abs(15.74599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.29091 - lat) + Math.Abs(18.71525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.50944 - lat) + Math.Abs(15.54128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.36241 - lat) + Math.Abs(12.08839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28338 - lat) + Math.Abs(13.27773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.33333 - lat) + Math.Abs(18.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27412 - lat) + Math.Abs(15.2066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.22407 - lat) + Math.Abs(17.70138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.59815 - lat) + Math.Abs(14.05089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05747 - lat) + Math.Abs(14.02233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.81667 - lat) + Math.Abs(16.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.4 - lat) + Math.Abs(17.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.69107 - lat) + Math.Abs(12.6979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2773 - lat) + Math.Abs(14.53402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.25 - lat) + Math.Abs(14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.80444 - lat) + Math.Abs(12.17131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3922 - lat) + Math.Abs(15.24228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.69882 - lat) + Math.Abs(12.13448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.71667 - lat) + Math.Abs(11.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.1 - lat) + Math.Abs(11.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.22949 - lat) + Math.Abs(14.65294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71667 - lat) + Math.Abs(14.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.16667 - lat) + Math.Abs(15.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.54506 - lat) + Math.Abs(11.97458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.10412 - lat) + Math.Abs(12.7477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70814 - lat) + Math.Abs(11.65585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.8912 - lat) + Math.Abs(16.71846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.54333 - lat) + Math.Abs(16.19092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.90337 - lat) + Math.Abs(17.94793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.00619 - lat) + Math.Abs(17.7594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.8 - lat) + Math.Abs(18.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.17718 - lat) + Math.Abs(17.4323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62274 - lat) + Math.Abs(14.30313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.753 - lat) + Math.Abs(17.00788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.28333 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.74461 - lat) + Math.Abs(15.90714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.96667 - lat) + Math.Abs(14.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.18808 - lat) + Math.Abs(12.71599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.91206 - lat) + Math.Abs(19.48153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.50539 - lat) + Math.Abs(15.97243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.75799 - lat) + Math.Abs(18.70496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.95 - lat) + Math.Abs(17.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.59419 - lat) + Math.Abs(16.1826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.21667 - lat) + Math.Abs(15.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.98333 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.11667 - lat) + Math.Abs(14.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.56852 - lat) + Math.Abs(19.50244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06505 - lat) + Math.Abs(15.92366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51926 - lat) + Math.Abs(15.03979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78333 - lat) + Math.Abs(11.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.2875 - lat) + Math.Abs(17.36917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56 - lat) + Math.Abs(14.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.6125 - lat) + Math.Abs(17.05556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.26339 - lat) + Math.Abs(17.38354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.63306 - lat) + Math.Abs(16.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(15.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.76667 - lat) + Math.Abs(16.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.17693 - lat) + Math.Abs(14.49706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65307 - lat) + Math.Abs(14.69676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.44384 - lat) + Math.Abs(16.9024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.35 - lat) + Math.Abs(14.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31053 - lat) + Math.Abs(18.16372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.38509 - lat) + Math.Abs(14.96325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.06176 - lat) + Math.Abs(11.74936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83856 - lat) + Math.Abs(13.54361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.46634 - lat) + Math.Abs(11.67345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.25 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.9171 - lat) + Math.Abs(13.87831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.15 - lat) + Math.Abs(14.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.53706 - lat) + Math.Abs(15.03649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(15.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31862 - lat) + Math.Abs(18.44312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.30906 - lat) + Math.Abs(13.66356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19281 - lat) + Math.Abs(14.74739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31667 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.93395 - lat) + Math.Abs(16.96353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.5248 - lat) + Math.Abs(16.37877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05749 - lat) + Math.Abs(12.88018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.00704 - lat) + Math.Abs(14.54316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4 - lat) + Math.Abs(15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04134 - lat) + Math.Abs(16.44463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65893 - lat) + Math.Abs(12.11792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.6554 - lat) + Math.Abs(12.01378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.05 - lat) + Math.Abs(17.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.5 - lat) + Math.Abs(14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28333 - lat) + Math.Abs(12.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.60057 - lat) + Math.Abs(13.72115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.60645 - lat) + Math.Abs(14.03897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57 - lat) + Math.Abs(14.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.29799 - lat) + Math.Abs(16.81394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.32595 - lat) + Math.Abs(15.12365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.68333 - lat) + Math.Abs(12.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05 - lat) + Math.Abs(14.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(15.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.1 - lat) + Math.Abs(16.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.69979 - lat) + Math.Abs(12.45312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.48561 - lat) + Math.Abs(12.93958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.42512 - lat) + Math.Abs(18.31555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.34864 - lat) + Math.Abs(17.03173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62157 - lat) + Math.Abs(17.85476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.46135 - lat) + Math.Abs(13.59644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.70971 - lat) + Math.Abs(13.82367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.38333 - lat) + Math.Abs(13.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.86667 - lat) + Math.Abs(13.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.25963 - lat) + Math.Abs(17.223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.61667 - lat) + Math.Abs(15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35 - lat) + Math.Abs(15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.22822 - lat) + Math.Abs(17.46213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73333 - lat) + Math.Abs(13.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.68329 - lat) + Math.Abs(13.71542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.68333 - lat) + Math.Abs(13.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.41102 - lat) + Math.Abs(15.51647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.60587 - lat) + Math.Abs(13.00073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.13333 - lat) + Math.Abs(16.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.57667 - lat) + Math.Abs(14.4617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.38773 - lat) + Math.Abs(15.80675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.18501 - lat) + Math.Abs(18.74243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.27429 - lat) + Math.Abs(11.43576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.59537 - lat) + Math.Abs(18.67351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.47168 - lat) + Math.Abs(13.44727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70584 - lat) + Math.Abs(13.19321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.64323 - lat) + Math.Abs(13.70162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14959 - lat) + Math.Abs(15.18776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9 - lat) + Math.Abs(13.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.29903 - lat) + Math.Abs(17.04958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.9574 - lat) + Math.Abs(17.57826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65265 - lat) + Math.Abs(13.89148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16667 - lat) + Math.Abs(16.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.73333 - lat) + Math.Abs(15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.4 - lat) + Math.Abs(14.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.67244 - lat) + Math.Abs(13.06849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.5489 - lat) + Math.Abs(19.38735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.02994 - lat) + Math.Abs(12.15934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.43333 - lat) + Math.Abs(14.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.76667 - lat) + Math.Abs(13.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7761 - lat) + Math.Abs(13.52414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.2117 - lat) + Math.Abs(17.1279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.82883 - lat) + Math.Abs(16.09126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.22452 - lat) + Math.Abs(11.92014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.51667 - lat) + Math.Abs(15.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.39793 - lat) + Math.Abs(12.92486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.63333 - lat) + Math.Abs(16.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.07437 - lat) + Math.Abs(13.2401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.83324 - lat) + Math.Abs(13.94082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.48947 - lat) + Math.Abs(16.04257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.51667 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98678 - lat) + Math.Abs(13.05579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.32029 - lat) + Math.Abs(14.84594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(15.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.41086 - lat) + Math.Abs(15.62157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.43333 - lat) + Math.Abs(15.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.78333 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.73333 - lat) + Math.Abs(16.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.56667 - lat) + Math.Abs(12.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.61667 - lat) + Math.Abs(16.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.58333 - lat) + Math.Abs(18.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.59202 - lat) + Math.Abs(15.2304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.53592 - lat) + Math.Abs(13.35566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.527 - lat) + Math.Abs(13.05676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13333 - lat) + Math.Abs(12.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.50517 - lat) + Math.Abs(13.15765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36667 - lat) + Math.Abs(18.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.95 - lat) + Math.Abs(15.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.83333 - lat) + Math.Abs(13.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.66667 - lat) + Math.Abs(14.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.75185 - lat) + Math.Abs(15.26969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.9759 - lat) + Math.Abs(14.18264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.77051 - lat) + Math.Abs(12.26904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.47839 - lat) + Math.Abs(13.71267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57 - lat) + Math.Abs(15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7303 - lat) + Math.Abs(14.99994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.76667 - lat) + Math.Abs(14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.9863 - lat) + Math.Abs(14.61904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27264 - lat) + Math.Abs(14.98328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.87149 - lat) + Math.Abs(17.95125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24583 - lat) + Math.Abs(18.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45238 - lat) + Math.Abs(16.03831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.18333 - lat) + Math.Abs(17.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.6 - lat) + Math.Abs(13.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98333 - lat) + Math.Abs(12.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.68665 - lat) + Math.Abs(12.21169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.8708 - lat) + Math.Abs(12.83016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.36667 - lat) + Math.Abs(14.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16667 - lat) + Math.Abs(14.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.51207 - lat) + Math.Abs(13.04371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.91667 - lat) + Math.Abs(13.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55 - lat) + Math.Abs(13.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.35 - lat) + Math.Abs(14.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.01667 - lat) + Math.Abs(11.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.29361 - lat) + Math.Abs(17.375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.75 - lat) + Math.Abs(11.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13386 - lat) + Math.Abs(13.04678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.45099 - lat) + Math.Abs(16.32131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.78333 - lat) + Math.Abs(12.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3 - lat) + Math.Abs(13.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42245 - lat) + Math.Abs(16.09656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33183 - lat) + Math.Abs(18.04118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36305 - lat) + Math.Abs(11.25938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63 - lat) + Math.Abs(17.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.6 - lat) + Math.Abs(16.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40483 - lat) + Math.Abs(17.62926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.48719 - lat) + Math.Abs(12.07612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.47857 - lat) + Math.Abs(17.74834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.87096 - lat) + Math.Abs(11.98054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35 - lat) + Math.Abs(18.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.1277 - lat) + Math.Abs(15.14341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.13333 - lat) + Math.Abs(16.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.32589 - lat) + Math.Abs(14.44883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.67231 - lat) + Math.Abs(16.36741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30978 - lat) + Math.Abs(14.10808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03129 - lat) + Math.Abs(14.15242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4007 - lat) + Math.Abs(16.20496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.93161 - lat) + Math.Abs(17.77646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.84332 - lat) + Math.Abs(15.39618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.81667 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.30246 - lat) + Math.Abs(15.12519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.70348 - lat) + Math.Abs(12.1542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33306 - lat) + Math.Abs(18.58306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.87597 - lat) + Math.Abs(14.99436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.16667 - lat) + Math.Abs(18.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45526 - lat) + Math.Abs(13.93453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51404 - lat) + Math.Abs(15.99255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.6 - lat) + Math.Abs(15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56516 - lat) + Math.Abs(16.23037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.94263 - lat) + Math.Abs(11.85051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.90867 - lat) + Math.Abs(18.26568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.72564 - lat) + Math.Abs(17.78753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.18333 - lat) + Math.Abs(14.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.51861 - lat) + Math.Abs(13.32423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.03333 - lat) + Math.Abs(11.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13559 - lat) + Math.Abs(13.13086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.38667 - lat) + Math.Abs(18.20371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.32693 - lat) + Math.Abs(17.21764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.39296 - lat) + Math.Abs(13.37465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.59416 - lat) + Math.Abs(13.24574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38306 - lat) + Math.Abs(16.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6851 - lat) + Math.Abs(14.22025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40316 - lat) + Math.Abs(17.94479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98781 - lat) + Math.Abs(15.63303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.07786 - lat) + Math.Abs(13.52061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.50728 - lat) + Math.Abs(12.69463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.54967 - lat) + Math.Abs(15.96296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.47652 - lat) + Math.Abs(14.09709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.23333 - lat) + Math.Abs(16.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50234 - lat) + Math.Abs(13.31277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.85345 - lat) + Math.Abs(14.30457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.79188 - lat) + Math.Abs(13.11021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.14024 - lat) + Math.Abs(12.78234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.99587 - lat) + Math.Abs(16.20721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.65632 - lat) + Math.Abs(18.27292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.85 - lat) + Math.Abs(11.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3793 - lat) + Math.Abs(13.50357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16156 - lat) + Math.Abs(15.58661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32667 - lat) + Math.Abs(14.52386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1706 - lat) + Math.Abs(14.86188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.53724 - lat) + Math.Abs(14.5047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.52091 - lat) + Math.Abs(17.63152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15 - lat) + Math.Abs(17.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56087 - lat) + Math.Abs(18.22007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.66157 - lat) + Math.Abs(16.36163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.24841 - lat) + Math.Abs(15.28721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.60992 - lat) + Math.Abs(12.05106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.50999 - lat) + Math.Abs(13.30582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.75086 - lat) + Math.Abs(12.15224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.99976 - lat) + Math.Abs(13.08795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66667 - lat) + Math.Abs(16.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.69586 - lat) + Math.Abs(16.88256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.67295 - lat) + Math.Abs(12.50335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.9863 - lat) + Math.Abs(11.82943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.14972 - lat) + Math.Abs(18.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58 - lat) + Math.Abs(12.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2338 - lat) + Math.Abs(12.67184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.74588 - lat) + Math.Abs(12.1735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78145 - lat) + Math.Abs(14.15618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.74434 - lat) + Math.Abs(16.71947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.60665 - lat) + Math.Abs(19.82324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.21667 - lat) + Math.Abs(15.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.43424 - lat) + Math.Abs(17.37273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.71667 - lat) + Math.Abs(16.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.3462 - lat) + Math.Abs(13.46572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.41667 - lat) + Math.Abs(15.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53333 - lat) + Math.Abs(14.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.09165 - lat) + Math.Abs(17.56615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.88333 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71667 - lat) + Math.Abs(16.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23333 - lat) + Math.Abs(14.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19187 - lat) + Math.Abs(15.84115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42268 - lat) + Math.Abs(17.83508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.7 - lat) + Math.Abs(16.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.6 - lat) + Math.Abs(16.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.4 - lat) + Math.Abs(17.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67688 - lat) + Math.Abs(15.09487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.75 - lat) + Math.Abs(14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.57732 - lat) + Math.Abs(17.09807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.64219 - lat) + Math.Abs(17.07477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.4 - lat) + Math.Abs(13.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.85821 - lat) + Math.Abs(12.71401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.62 - lat) + Math.Abs(13.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.55726 - lat) + Math.Abs(12.53841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.99892 - lat) + Math.Abs(13.23958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1 - lat) + Math.Abs(12.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.33333 - lat) + Math.Abs(19.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78596 - lat) + Math.Abs(14.30214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.44127 - lat) + Math.Abs(11.3032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62673 - lat) + Math.Abs(16.9438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.48815 - lat) + Math.Abs(15.84357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.72744 - lat) + Math.Abs(17.10558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23705 - lat) + Math.Abs(17.98192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35 - lat) + Math.Abs(15.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.78685 - lat) + Math.Abs(15.14023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.03333 - lat) + Math.Abs(11.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.85363 - lat) + Math.Abs(14.21914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.11353 - lat) + Math.Abs(16.20552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.04233 - lat) + Math.Abs(14.76175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.35475 - lat) + Math.Abs(12.47777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.62312 - lat) + Math.Abs(19.90856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.3 - lat) + Math.Abs(16.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.5 - lat) + Math.Abs(16.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.9 - lat) + Math.Abs(15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.85238 - lat) + Math.Abs(13.66094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.93444 - lat) + Math.Abs(13.5385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.68972 - lat) + Math.Abs(11.64972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.43333 - lat) + Math.Abs(15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28333 - lat) + Math.Abs(18.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.01667 - lat) + Math.Abs(17.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.73948 - lat) + Math.Abs(12.85462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.40982 - lat) + Math.Abs(12.9558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.49411 - lat) + Math.Abs(13.00782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.84085 - lat) + Math.Abs(13.28351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.66667 - lat) + Math.Abs(16.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.51529 - lat) + Math.Abs(14.27746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.52177 - lat) + Math.Abs(17.09133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02669 - lat) + Math.Abs(15.66873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16597 - lat) + Math.Abs(16.02562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.9 - lat) + Math.Abs(11.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19971 - lat) + Math.Abs(12.55795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.80485 - lat) + Math.Abs(12.9797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.54573 - lat) + Math.Abs(16.28668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70167 - lat) + Math.Abs(11.71639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.30133 - lat) + Math.Abs(14.28784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.31667 - lat) + Math.Abs(12.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28333 - lat) + Math.Abs(14.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1 - lat) + Math.Abs(12.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70338 - lat) + Math.Abs(12.44657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31293 - lat) + Math.Abs(13.88437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.63333 - lat) + Math.Abs(13.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.91667 - lat) + Math.Abs(14.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.44232 - lat) + Math.Abs(13.59575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.07739 - lat) + Math.Abs(13.02662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(14.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.23848 - lat) + Math.Abs(11.67598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.23788 - lat) + Math.Abs(18.37443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32273 - lat) + Math.Abs(18.48675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.04673 - lat) + Math.Abs(12.69437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4 - lat) + Math.Abs(17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.27973 - lat) + Math.Abs(15.98855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.41367 - lat) + Math.Abs(13.51255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.93815 - lat) + Math.Abs(16.86217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.72222 - lat) + Math.Abs(12.67194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28468 - lat) + Math.Abs(13.93547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3 - lat) + Math.Abs(18.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.11667 - lat) + Math.Abs(15.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15905 - lat) + Math.Abs(13.76638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13333 - lat) + Math.Abs(12.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65436 - lat) + Math.Abs(12.36318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.74491 - lat) + Math.Abs(12.72758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.63228 - lat) + Math.Abs(17.93794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.9276 - lat) + Math.Abs(17.21849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.71725 - lat) + Math.Abs(13.52623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.1 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7 - lat) + Math.Abs(15.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36065 - lat) + Math.Abs(16.90339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.16775 - lat) + Math.Abs(18.14478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.16809 - lat) + Math.Abs(18.13796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16061 - lat) + Math.Abs(14.09307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.9 - lat) + Math.Abs(17.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.57615 - lat) + Math.Abs(15.36516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.11041 - lat) + Math.Abs(16.35377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.01798 - lat) + Math.Abs(14.19401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.54385 - lat) + Math.Abs(16.56934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.01667 - lat) + Math.Abs(14.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.55254 - lat) + Math.Abs(11.27268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.73412 - lat) + Math.Abs(11.65807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.67446 - lat) + Math.Abs(12.85676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.05 - lat) + Math.Abs(18.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.61395 - lat) + Math.Abs(16.22846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.29491 - lat) + Math.Abs(16.45434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06463 - lat) + Math.Abs(15.10993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.01667 - lat) + Math.Abs(14.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.5796 - lat) + Math.Abs(11.54058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.62919 - lat) + Math.Abs(13.43801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.15208 - lat) + Math.Abs(16.497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.78388 - lat) + Math.Abs(14.52197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39152 - lat) + Math.Abs(16.42229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31667 - lat) + Math.Abs(16.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.46667 - lat) + Math.Abs(15.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(14.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.11667 - lat) + Math.Abs(15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.85 - lat) + Math.Abs(12.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.02378 - lat) + Math.Abs(13.67214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.8 - lat) + Math.Abs(17.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55175 - lat) + Math.Abs(16.18684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.91667 - lat) + Math.Abs(14.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.91185 - lat) + Math.Abs(14.07444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50503 - lat) + Math.Abs(14.96661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.2688 - lat) + Math.Abs(16.49894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32684 - lat) + Math.Abs(18.38975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.85 - lat) + Math.Abs(17.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71667 - lat) + Math.Abs(16.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.98615 - lat) + Math.Abs(14.09644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.8 - lat) + Math.Abs(15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.59167 - lat) + Math.Abs(12.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.7 - lat) + Math.Abs(12.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05 - lat) + Math.Abs(14.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.70593 - lat) + Math.Abs(14.53453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.68751 - lat) + Math.Abs(15.48507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.21217 - lat) + Math.Abs(11.41877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35141 - lat) + Math.Abs(13.11105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.05 - lat) + Math.Abs(17.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.73333 - lat) + Math.Abs(14.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4838 - lat) + Math.Abs(13.55027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62603 - lat) + Math.Abs(17.25787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.36667 - lat) + Math.Abs(12.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.30145 - lat) + Math.Abs(15.87085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.70248 - lat) + Math.Abs(11.25738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33219 - lat) + Math.Abs(12.68122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.01667 - lat) + Math.Abs(14.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07465 - lat) + Math.Abs(15.00784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.76667 - lat) + Math.Abs(19.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.83625 - lat) + Math.Abs(12.29954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.52824 - lat) + Math.Abs(13.49458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70716 - lat) + Math.Abs(11.96679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.10617 - lat) + Math.Abs(12.15254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.3585 - lat) + Math.Abs(13.73686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.04751 - lat) + Math.Abs(17.31191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.04874 - lat) + Math.Abs(17.25858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.94091 - lat) + Math.Abs(12.80929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.93333 - lat) + Math.Abs(12.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.93333 - lat) + Math.Abs(12.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.3 - lat) + Math.Abs(14.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31667 - lat) + Math.Abs(15.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.3044 - lat) + Math.Abs(13.54078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.31667 - lat) + Math.Abs(18.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.81667 - lat) + Math.Abs(12.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.56858 - lat) + Math.Abs(13.03186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.59907 - lat) + Math.Abs(13.3982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.86753 - lat) + Math.Abs(14.64379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.94297 - lat) + Math.Abs(17.87774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67452 - lat) + Math.Abs(17.14174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41667 - lat) + Math.Abs(12.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54949 - lat) + Math.Abs(14.17923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30429 - lat) + Math.Abs(14.94623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.31667 - lat) + Math.Abs(16.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.93333 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.98729 - lat) + Math.Abs(12.80482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.7 - lat) + Math.Abs(13.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.89485 - lat) + Math.Abs(16.40508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.89817 - lat) + Math.Abs(17.63386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.66667 - lat) + Math.Abs(13.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.91275 - lat) + Math.Abs(15.2319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.59856 - lat) + Math.Abs(15.07745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.65 - lat) + Math.Abs(12.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65 - lat) + Math.Abs(17.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71667 - lat) + Math.Abs(12.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7738 - lat) + Math.Abs(13.09022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.54607 - lat) + Math.Abs(12.5428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78333 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.46667 - lat) + Math.Abs(15.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.68333 - lat) + Math.Abs(12.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.55655 - lat) + Math.Abs(12.78457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.82483 - lat) + Math.Abs(13.01064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31667 - lat) + Math.Abs(12.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.89605 - lat) + Math.Abs(16.54904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.27298 - lat) + Math.Abs(15.53415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.13333 - lat) + Math.Abs(14.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.49855 - lat) + Math.Abs(16.17016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.90843 - lat) + Math.Abs(17.84729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.5 - lat) + Math.Abs(12.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.66667 - lat) + Math.Abs(11.65833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.95372 - lat) + Math.Abs(16.29485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.35 - lat) + Math.Abs(12.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16415 - lat) + Math.Abs(13.83016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.52541 - lat) + Math.Abs(13.48127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.7 - lat) + Math.Abs(14.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71667 - lat) + Math.Abs(17.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61667 - lat) + Math.Abs(16.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.41667 - lat) + Math.Abs(18.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.20767 - lat) + Math.Abs(16.30787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.66667 - lat) + Math.Abs(14.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75373 - lat) + Math.Abs(13.36671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5061 - lat) + Math.Abs(14.79275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13333 - lat) + Math.Abs(13.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.13333 - lat) + Math.Abs(16.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.05834 - lat) + Math.Abs(16.58781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.17375 - lat) + Math.Abs(14.87227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.77554 - lat) + Math.Abs(16.92106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.45913 - lat) + Math.Abs(12.17508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.04972 - lat) + Math.Abs(12.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.6 - lat) + Math.Abs(11.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.04364 - lat) + Math.Abs(14.27562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24868 - lat) + Math.Abs(17.85991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.70578 - lat) + Math.Abs(15.76739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.93333 - lat) + Math.Abs(14.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16667 - lat) + Math.Abs(13.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.492 - lat) + Math.Abs(13.247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.71236 - lat) + Math.Abs(14.16831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.36667 - lat) + Math.Abs(16.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43333 - lat) + Math.Abs(15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.85822 - lat) + Math.Abs(19.0619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61 - lat) + Math.Abs(14.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06667 - lat) + Math.Abs(14.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6499 - lat) + Math.Abs(16.46859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.80011 - lat) + Math.Abs(15.84422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.56816 - lat) + Math.Abs(11.99235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.4074 - lat) + Math.Abs(16.58549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.36667 - lat) + Math.Abs(19.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.60357 - lat) + Math.Abs(15.62597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.17347 - lat) + Math.Abs(13.55068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.90552 - lat) + Math.Abs(12.49118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.00418 - lat) + Math.Abs(15.79316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.46667 - lat) + Math.Abs(14.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9 - lat) + Math.Abs(14.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.31639 - lat) + Math.Abs(17.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83928 - lat) + Math.Abs(13.30393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36661 - lat) + Math.Abs(16.5077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24241 - lat) + Math.Abs(17.81631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.8 - lat) + Math.Abs(15.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.63607 - lat) + Math.Abs(17.07768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43333 - lat) + Math.Abs(18.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40993 - lat) + Math.Abs(15.59575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.54556 - lat) + Math.Abs(17.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.63268 - lat) + Math.Abs(15.53648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.18333 - lat) + Math.Abs(11.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6 - lat) + Math.Abs(13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.66643 - lat) + Math.Abs(14.97205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.17275 - lat) + Math.Abs(13.49647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.291 - lat) + Math.Abs(17.81212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.49175 - lat) + Math.Abs(15.02226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26 - lat) + Math.Abs(15.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.25 - lat) + Math.Abs(17.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.46667 - lat) + Math.Abs(15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43472 - lat) + Math.Abs(13.20887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.37692 - lat) + Math.Abs(15.81747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.89304 - lat) + Math.Abs(18.49174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62918 - lat) + Math.Abs(12.82564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.91247 - lat) + Math.Abs(11.93308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.31667 - lat) + Math.Abs(14.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.4 - lat) + Math.Abs(12.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.82098 - lat) + Math.Abs(13.02897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.26185 - lat) + Math.Abs(16.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.6 - lat) + Math.Abs(11.79917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.11887 - lat) + Math.Abs(12.60688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39926 - lat) + Math.Abs(18.05619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32653 - lat) + Math.Abs(18.71152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.55027 - lat) + Math.Abs(15.18362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56061 - lat) + Math.Abs(15.13281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.92636 - lat) + Math.Abs(12.02598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.63333 - lat) + Math.Abs(14.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.57279 - lat) + Math.Abs(16.38722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.5275 - lat) + Math.Abs(11.5777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.27467 - lat) + Math.Abs(17.37994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.80104 - lat) + Math.Abs(16.55571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.603 - lat) + Math.Abs(13.472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23797 - lat) + Math.Abs(14.43077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83333 - lat) + Math.Abs(14.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.60405 - lat) + Math.Abs(13.52317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.71667 - lat) + Math.Abs(12.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.92555 - lat) + Math.Abs(12.30865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.71667 - lat) + Math.Abs(13.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.66655 - lat) + Math.Abs(13.34976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.13306 - lat) + Math.Abs(18.40639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.88422 - lat) + Math.Abs(12.30398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.36667 - lat) + Math.Abs(14.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.2 - lat) + Math.Abs(13.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54478 - lat) + Math.Abs(12.92375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.2378 - lat) + Math.Abs(12.12187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.26255 - lat) + Math.Abs(16.01034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51667 - lat) + Math.Abs(17.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28 - lat) + Math.Abs(18.43 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.07586 - lat) + Math.Abs(14.83203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.72442 - lat) + Math.Abs(14.10254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.07551 - lat) + Math.Abs(14.46958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.34 - lat) + Math.Abs(17.94 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.25521 - lat) + Math.Abs(14.07797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51667 - lat) + Math.Abs(17.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35 - lat) + Math.Abs(18.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.21667 - lat) + Math.Abs(18.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.58333 - lat) + Math.Abs(17.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.44655 - lat) + Math.Abs(18.11019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.17343 - lat) + Math.Abs(13.73789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(11.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.64528 - lat) + Math.Abs(11.78167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.56344 - lat) + Math.Abs(12.34923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23333 - lat) + Math.Abs(15.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.75067 - lat) + Math.Abs(15.42193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.06667 - lat) + Math.Abs(15.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.19719 - lat) + Math.Abs(15.05376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.77186 - lat) + Math.Abs(13.82631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45707 - lat) + Math.Abs(14.18041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4858 - lat) + Math.Abs(15.43714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.8793 - lat) + Math.Abs(16.65634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.56667 - lat) + Math.Abs(15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72101 - lat) + Math.Abs(12.9401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.11667 - lat) + Math.Abs(14.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73962 - lat) + Math.Abs(17.31239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.99777 - lat) + Math.Abs(17.67348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.34817 - lat) + Math.Abs(16.39464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24196 - lat) + Math.Abs(18.22762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.66866 - lat) + Math.Abs(12.57272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.5 - lat) + Math.Abs(14.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.01667 - lat) + Math.Abs(15.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33333 - lat) + Math.Abs(18.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98333 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.93333 - lat) + Math.Abs(13.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.58333 - lat) + Math.Abs(13.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.08372 - lat) + Math.Abs(12.91914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73726 - lat) + Math.Abs(15.45291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.93027 - lat) + Math.Abs(19.21369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06465 - lat) + Math.Abs(17.15931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24122 - lat) + Math.Abs(14.24942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.12487 - lat) + Math.Abs(12.96502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.38333 - lat) + Math.Abs(13.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.76667 - lat) + Math.Abs(11.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.5 - lat) + Math.Abs(15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.73221 - lat) + Math.Abs(11.67916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4264 - lat) + Math.Abs(12.52523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.76667 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.87096 - lat) + Math.Abs(12.32546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45935 - lat) + Math.Abs(14.71598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.2 - lat) + Math.Abs(18.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.71667 - lat) + Math.Abs(13.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.29032 - lat) + Math.Abs(13.71128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.98333 - lat) + Math.Abs(12.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05 - lat) + Math.Abs(13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.88333 - lat) + Math.Abs(13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.56667 - lat) + Math.Abs(11.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.08883 - lat) + Math.Abs(16.20978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.23333 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.25349 - lat) + Math.Abs(16.82749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.98253 - lat) + Math.Abs(17.06368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38083 - lat) + Math.Abs(18.03427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.63472 - lat) + Math.Abs(18.62806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.7405 - lat) + Math.Abs(16.91284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.81381 - lat) + Math.Abs(14.44735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.39063 - lat) + Math.Abs(16.07274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.53074 - lat) + Math.Abs(17.38123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.92931 - lat) + Math.Abs(17.04194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.21667 - lat) + Math.Abs(16.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.48831 - lat) + Math.Abs(15.52969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71183 - lat) + Math.Abs(15.87313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02912 - lat) + Math.Abs(12.23207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.42689 - lat) + Math.Abs(12.85339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53333 - lat) + Math.Abs(15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0091 - lat) + Math.Abs(12.8058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.76667 - lat) + Math.Abs(12.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.704 - lat) + Math.Abs(14.178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.54935 - lat) + Math.Abs(16.5074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.68333 - lat) + Math.Abs(17.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.58155 - lat) + Math.Abs(13.17862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.86021 - lat) + Math.Abs(14.124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.5671 - lat) + Math.Abs(17.52781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.95 - lat) + Math.Abs(17.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.15 - lat) + Math.Abs(14.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.8049 - lat) + Math.Abs(12.16202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.81667 - lat) + Math.Abs(16.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.92286 - lat) + Math.Abs(15.10016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38333 - lat) + Math.Abs(13.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14274 - lat) + Math.Abs(16.16295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.20152 - lat) + Math.Abs(15.9977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13566 - lat) + Math.Abs(12.9443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.88333 - lat) + Math.Abs(12.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.31667 - lat) + Math.Abs(13.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.87988 - lat) + Math.Abs(14.9023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.40772 - lat) + Math.Abs(15.84852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.63712 - lat) + Math.Abs(16.56036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.79878 - lat) + Math.Abs(12.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.16026 - lat) + Math.Abs(17.34762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.1701 - lat) + Math.Abs(15.3443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59 - lat) + Math.Abs(15.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.02397 - lat) + Math.Abs(13.5651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.35 - lat) + Math.Abs(12.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.36667 - lat) + Math.Abs(16.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.25 - lat) + Math.Abs(14.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.82762 - lat) + Math.Abs(14.97937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.65528 - lat) + Math.Abs(12.58518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.59033 - lat) + Math.Abs(19.16682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51644 - lat) + Math.Abs(16.73436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2978 - lat) + Math.Abs(18.0514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.96841 - lat) + Math.Abs(11.78487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.11667 - lat) + Math.Abs(18.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.72675 - lat) + Math.Abs(17.02322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.20627 - lat) + Math.Abs(12.21293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63248 - lat) + Math.Abs(13.07141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27983 - lat) + Math.Abs(16.67896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(13.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16989 - lat) + Math.Abs(14.29082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.05173 - lat) + Math.Abs(17.88606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39217 - lat) + Math.Abs(12.13336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.275 - lat) + Math.Abs(12.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36134 - lat) + Math.Abs(13.33648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.46667 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39387 - lat) + Math.Abs(15.83882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60 - lat) + Math.Abs(16.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98843 - lat) + Math.Abs(13.07483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.37028 - lat) + Math.Abs(17.41167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.69896 - lat) + Math.Abs(16.33407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78628 - lat) + Math.Abs(12.09852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2428 - lat) + Math.Abs(12.86219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.52495 - lat) + Math.Abs(15.65904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.83895 - lat) + Math.Abs(14.81016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.88333 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.28333 - lat) + Math.Abs(13.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.43836 - lat) + Math.Abs(13.31966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.76191 - lat) + Math.Abs(12.36211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.051 - lat) + Math.Abs(12.70492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28333 - lat) + Math.Abs(17.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.57081 - lat) + Math.Abs(17.44895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33188 - lat) + Math.Abs(17.98325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.89935 - lat) + Math.Abs(14.55559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.22774 - lat) + Math.Abs(14.03935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.95872 - lat) + Math.Abs(12.1235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06667 - lat) + Math.Abs(18.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26667 - lat) + Math.Abs(18.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.97303 - lat) + Math.Abs(15.65413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39853 - lat) + Math.Abs(13.61369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.75324 - lat) + Math.Abs(17.77331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.88333 - lat) + Math.Abs(18.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.96667 - lat) + Math.Abs(18.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55146 - lat) + Math.Abs(14.13827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.12009 - lat) + Math.Abs(12.69406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.93033 - lat) + Math.Abs(12.53345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.68299 - lat) + Math.Abs(16.52722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.34675 - lat) + Math.Abs(16.07499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.95 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.75 - lat) + Math.Abs(12.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.67714 - lat) + Math.Abs(17.8406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.92579 - lat) + Math.Abs(12.07835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.25 - lat) + Math.Abs(17.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.47944 - lat) + Math.Abs(18.29967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.23333 - lat) + Math.Abs(13.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65396 - lat) + Math.Abs(13.11107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.91667 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.12559 - lat) + Math.Abs(15.07363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(16.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73333 - lat) + Math.Abs(17.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66667 - lat) + Math.Abs(16.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15 - lat) + Math.Abs(14.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4 - lat) + Math.Abs(13.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.375 - lat) + Math.Abs(13.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.29167 - lat) + Math.Abs(12.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.42444 - lat) + Math.Abs(11.93583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.39167 - lat) + Math.Abs(12.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56543 - lat) + Math.Abs(16.53045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.18333 - lat) + Math.Abs(15.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5 - lat) + Math.Abs(12.95833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.758 - lat) + Math.Abs(12.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83208 - lat) + Math.Abs(12.94429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.70039 - lat) + Math.Abs(11.76136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.775 - lat) + Math.Abs(11.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.31361 - lat) + Math.Abs(11.8273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.43333 - lat) + Math.Abs(17.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.29153 - lat) + Math.Abs(18.2549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56 - lat) + Math.Abs(12.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4 - lat) + Math.Abs(12.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.85989 - lat) + Math.Abs(12.45161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.89852 - lat) + Math.Abs(13.4646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.69195 - lat) + Math.Abs(11.91605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.42531 - lat) + Math.Abs(12.02903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.80433 - lat) + Math.Abs(20.36955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.82277 - lat) + Math.Abs(12.27696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.35989 - lat) + Math.Abs(12.15801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48014 - lat) + Math.Abs(17.71631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.68 - lat) + Math.Abs(16.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41465 - lat) + Math.Abs(17.91398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3939 - lat) + Math.Abs(17.90111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.61373 - lat) + Math.Abs(22.17702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2335 - lat) + Math.Abs(17.8538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.78049 - lat) + Math.Abs(12.03604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.80236 - lat) + Math.Abs(12.07131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.77141 - lat) + Math.Abs(12.04183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.8048 - lat) + Math.Abs(12.02883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.81555 - lat) + Math.Abs(12.03861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.48984 - lat) + Math.Abs(18.13429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.39911 - lat) + Math.Abs(13.07995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.25101 - lat) + Math.Abs(17.18215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.85307 - lat) + Math.Abs(24.10486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vuollerim", "14", 66.43038, 20.62434);
case 1: return new CityInfo("Vittangi", "14", 67.67589, 21.64204);
case 2: return new CityInfo("Viken", "23", 64.72587, 20.91548);
case 3: return new CityInfo("Vidsel", "14", 65.83533, 20.51908);
case 4: return new CityInfo("Ursviken", "23", 64.71261, 21.1658);
case 5: return new CityInfo("Umeå", "23", 63.82842, 20.25972);
case 6: return new CityInfo("Tuolluvaara", "14", 67.85, 20.33333);
case 7: return new CityInfo("Töre", "14", 65.91243, 22.65128);
case 8: return new CityInfo("Tällberg", "23", 64.98333, 20.8);
case 9: return new CityInfo("Täfteå", "23", 63.8397, 20.47857);
case 10: return new CityInfo("Svartå", "23", 65.03333, 20.76667);
case 11: return new CityInfo("Storvik", "23", 65.15, 20.73333);
case 12: return new CityInfo("Stensjön", "23", 64.98333, 21.1);
case 13: return new CityInfo("Södra Sunderbyn", "14", 65.65983, 21.94004);
case 14: return new CityInfo("Skelleftehamn", "23", 64.68333, 21.23333);
case 15: return new CityInfo("Skellefteå", "23", 64.75067, 20.95279);
case 16: return new CityInfo("Råneå", "14", 65.85482, 22.29126);
case 17: return new CityInfo("Sävar", "23", 63.90383, 20.55014);
case 18: return new CityInfo("Sangis", "14", 65.85573, 23.49689);
case 19: return new CityInfo("Rutvik", "14", 65.67171, 22.08973);
case 20: return new CityInfo("Rosvik", "14", 65.43333, 21.7);
case 21: return new CityInfo("Rolfs", "14", 65.85, 23.11667);
case 22: return new CityInfo("Roknäs", "14", 65.35, 21.2);
case 23: return new CityInfo("Robertsfors", "23", 64.19324, 20.84806);
case 24: return new CityInfo("Röbäck", "23", 63.80879, 20.18901);
case 25: return new CityInfo("Risögrund", "14", 65.81089, 23.24496);
case 26: return new CityInfo("Sävast", "14", 65.77002, 21.73113);
case 27: return new CityInfo("Piteå", "14", 65.31717, 21.47944);
case 28: return new CityInfo("Pajala", "14", 67.21284, 23.36607);
case 29: return new CityInfo("Övertorneå", "14", 66.38778, 23.65425);
case 30: return new CityInfo("Överkalix", "14", 66.32754, 22.84414);
case 31: return new CityInfo("Ostvik", "23", 64.88333, 21.06667);
case 32: return new CityInfo("Obbola", "23", 63.7, 20.31667);
case 33: return new CityInfo("Nyland", "23", 64.81667, 20.76667);
case 34: return new CityInfo("Nyborg", "14", 65.78333, 23.2);
case 35: return new CityInfo("Norrfjärden", "14", 65.41805, 21.50151);
case 36: return new CityInfo("Medle", "23", 64.73818, 20.73206);
case 37: return new CityInfo("Måttsund", "14", 65.55, 21.9);
case 38: return new CityInfo("Malmberget", "14", 67.17529, 20.65495);
case 39: return new CityInfo("Luleå", "14", 65.58415, 22.15465);
case 40: return new CityInfo("Lövånger", "23", 64.36667, 21.3);
case 41: return new CityInfo("Långvik", "14", 66.11667, 22.23333);
case 42: return new CityInfo("Långsele", "23", 64.81667, 20.25);
case 43: return new CityInfo("Koskullskulle", "14", 67.18333, 20.75);
case 44: return new CityInfo("Korpilombolo", "14", 66.85177, 23.05515);
case 45: return new CityInfo("Kiruna", "14", 67.85572, 20.22513);
case 46: return new CityInfo("Kalix", "14", 65.85298, 23.15645);
case 47: return new CityInfo("Kåge", "23", 64.83571, 20.98453);
case 48: return new CityInfo("Jukkasjärvi", "14", 67.85, 20.61667);
case 49: return new CityInfo("Jörn", "23", 65.05914, 20.03919);
case 50: return new CityInfo("Jävre", "14", 65.15, 21.48333);
case 51: return new CityInfo("Innertavle", "23", 63.81121, 20.40752);
case 52: return new CityInfo("Hortlax", "14", 65.28188, 21.40544);
case 53: return new CityInfo("Holmsund", "23", 63.70602, 20.36409);
case 54: return new CityInfo("Haparanda", "14", 65.83549, 24.13676);
case 55: return new CityInfo("Gammelstad", "14", 65.63931, 22.01145);
case 56: return new CityInfo("Gällivare", "14", 67.13387, 20.65278);
case 57: return new CityInfo("Forsbacka", "23", 64.76667, 20.5);
case 58: return new CityInfo("Ersmark", "23", 64.84806, 20.896);
case 59: return new CityInfo("Ersmark", "23", 63.88333, 20.31667);
case 60: return new CityInfo("Byske", "23", 64.95258, 21.2058);
case 61: return new CityInfo("Bygdeå", "23", 64.05992, 20.85593);
case 62: return new CityInfo("Burträsk", "23", 64.51667, 20.65);
case 63: return new CityInfo("Bureå", "23", 64.61667, 21.2);
case 64: return new CityInfo("Boliden", "23", 64.86667, 20.38333);
case 65: return new CityInfo("Boden", "14", 65.82518, 21.68864);
case 66: return new CityInfo("Bergsviken", "14", 65.3, 21.38333);
case 67: return new CityInfo("Bergnäset", "14", 65.57791, 22.10844);
case 68: return new CityInfo("Bensbyn", "14", 65.64179, 22.24227);
case 69: return new CityInfo("Backa", "23", 64.98333, 21.06667);
case 70: return new CityInfo("Antnäs", "14", 65.55462, 21.83551);
case 71: return new CityInfo("Ånäset", "14", 65.45, 20.88333);
case 72: return new CityInfo("Ånäset", "23", 64.26667, 21.05);
case 73: return new CityInfo("Älvsbyn", "14", 65.67624, 21.00162);
case 74: return new CityInfo("Alvik", "14", 65.51667, 21.76667);
case 75: return new CityInfo("Alunda", "21", 60.26667, 18.4);
case 76: return new CityInfo("Boda", "21", 60.25, 18.38333);
case 77: return new CityInfo("Anneberg", "21", 60.24167, 18.41667);
case 78: return new CityInfo("Björklinge", "21", 60.03004, 17.55203);
case 79: return new CityInfo("Marieberg", "21", 60.23333, 18.5);
case 80: return new CityInfo("Strömma", "26", 59.70833, 19);
case 81: return new CityInfo("Ytternäs", "21", 59.78333, 17.6);
case 82: return new CityInfo("Ytterhogdal", "07", 62.175, 14.94089);
case 83: return new CityInfo("Ystad", "27", 55.42966, 13.82041);
case 84: return new CityInfo("Yngsjö", "27", 55.88109, 14.24237);
case 85: return new CityInfo("Vrigstad", "08", 57.35, 14.46667);
case 86: return new CityInfo("Vretstorp", "15", 59.03333, 14.86667);
case 87: return new CityInfo("Vrena", "18", 58.86091, 16.69922);
case 88: return new CityInfo("Vollsjö", "27", 55.70039, 13.7915);
case 89: return new CityInfo("Vittsjö", "27", 56.34366, 13.66081);
case 90: return new CityInfo("Vittinge", "21", 59.9, 17.06667);
case 91: return new CityInfo("Vissefjärda", "09", 56.53333, 15.58333);
case 92: return new CityInfo("Vislanda", "12", 56.78333, 14.45);
case 93: return new CityInfo("Viskafors", "28", 57.62941, 12.8489);
case 94: return new CityInfo("Visby", "05", 57.64089, 18.29602);
case 95: return new CityInfo("Virserum", "09", 57.31667, 15.58333);
case 96: return new CityInfo("Vintrosa", "15", 59.25, 14.95);
case 97: return new CityInfo("Vintrie", "27", 55.55, 12.96667);
case 98: return new CityInfo("Vinslöv", "27", 56.1, 13.91667);
case 99: return new CityInfo("Vinninga", "28", 58.45, 13.26667);
case 100: return new CityInfo("Vingåker", "18", 59.0433, 15.87374);
case 101: return new CityInfo("Vindeln", "23", 64.20175, 19.71945);
case 102: return new CityInfo("Vinberg", "06", 56.94968, 12.54394);
case 103: return new CityInfo("Vimmerby", "09", 57.66588, 15.85515);
case 104: return new CityInfo("Villshärad", "06", 56.69466, 12.69586);
case 105: return new CityInfo("Vilhelmina", "23", 64.62417, 16.65596);
case 106: return new CityInfo("Viksäter", "26", 59.24091, 17.61486);
case 107: return new CityInfo("Vikmanshyttan", "10", 60.29752, 15.83141);
case 108: return new CityInfo("Vikingstad", "16", 58.38304, 15.43201);
case 109: return new CityInfo("Viken", "27", 56.15063, 12.57429);
case 110: return new CityInfo("Vikarbyn", "10", 60.91667, 15.01667);
case 111: return new CityInfo("Vika", "10", 60.51341, 15.7161);
case 112: return new CityInfo("Vi", "24", 62.3, 17.16667);
case 113: return new CityInfo("Vidja", "26", 59.2, 18.06667);
case 114: return new CityInfo("Viby", "21", 60.1, 17.2);
case 115: return new CityInfo("Vibble", "05", 57.60452, 18.25601);
case 116: return new CityInfo("Vetlanda", "08", 57.42887, 15.07762);
case 117: return new CityInfo("Vessigebro", "06", 56.98333, 12.65);
case 118: return new CityInfo("Vemdalen", "07", 62.45, 13.86667);
case 119: return new CityInfo("Vellinge", "27", 55.47124, 13.01971);
case 120: return new CityInfo("Velanda", "15", 59.2, 15.06667);
case 121: return new CityInfo("Velanda", "28", 58.22883, 12.30986);
case 122: return new CityInfo("Vejbystrand", "27", 56.31778, 12.76722);
case 123: return new CityInfo("Veinge", "06", 56.55, 13.06667);
case 124: return new CityInfo("Vegby", "28", 57.68333, 13.38333);
case 125: return new CityInfo("Vedum", "28", 58.16667, 12.98333);
case 126: return new CityInfo("Vedevåg", "15", 59.5269, 15.29254);
case 127: return new CityInfo("Veddige", "06", 57.26591, 12.3322);
case 128: return new CityInfo("Veberöd", "27", 55.63333, 13.48333);
case 129: return new CityInfo("Våxtorp", "06", 56.41678, 13.12008);
case 130: return new CityInfo("Växjö", "12", 56.87767, 14.80906);
case 131: return new CityInfo("Vaxholm", "26", 59.40225, 18.35317);
case 132: return new CityInfo("Vattjom", "24", 62.36667, 17);
case 133: return new CityInfo("Vattholma", "21", 60.01667, 17.73333);
case 134: return new CityInfo("Västra Karup", "27", 56.41667, 12.75);
case 135: return new CityInfo("Västra Ingelstad", "27", 55.49108, 13.1121);
case 136: return new CityInfo("Västra Frölunda", "28", 57.64667, 11.92944);
case 137: return new CityInfo("Västervik", "09", 57.7584, 16.63733);
case 138: return new CityInfo("Västerfärnebo", "25", 59.94609, 16.27794);
case 139: return new CityInfo("Västerås", "25", 59.61617, 16.55276);
case 140: return new CityInfo("Vassmolösa", "09", 56.6, 16.16667);
case 141: return new CityInfo("Väse", "22", 59.38249, 13.85093);
case 142: return new CityInfo("Vasastan", "26", 59.34571, 18.04985);
case 143: return new CityInfo("Vartofta", "28", 58.1, 13.63333);
case 144: return new CityInfo("Vårsta", "26", 59.16528, 17.79722);
case 145: return new CityInfo("Värsås", "28", 58.35, 14.05);
case 146: return new CityInfo("Väröbacka", "06", 57.25, 12.18333);
case 147: return new CityInfo("Varnhem", "28", 58.38333, 13.65);
case 148: return new CityInfo("Värnamo", "08", 57.18604, 14.04001);
case 149: return new CityInfo("Väring", "28", 58.50486, 13.96877);
case 150: return new CityInfo("Vargön", "28", 58.35599, 12.3906);
case 151: return new CityInfo("Vårgårda", "28", 58.03706, 12.80907);
case 152: return new CityInfo("Varekil", "28", 58.12293, 11.70777);
case 153: return new CityInfo("Vårby", "26", 59.26671, 17.88407);
case 154: return new CityInfo("Varberg", "06", 57.10557, 12.25078);
case 155: return new CityInfo("Vara", "28", 58.26234, 12.95413);
case 156: return new CityInfo("Vansbro", "10", 60.50893, 14.22458);
case 157: return new CityInfo("Vännäsby", "23", 63.91564, 19.82438);
case 158: return new CityInfo("Vännäs", "23", 63.90676, 19.75712);
case 159: return new CityInfo("Vänersborg", "28", 58.38075, 12.3234);
case 160: return new CityInfo("Våmhus", "10", 61.11491, 14.4718);
case 161: return new CityInfo("Valskog", "25", 59.44179, 15.94429);
case 162: return new CityInfo("Vallentuna", "26", 59.53436, 18.07758);
case 163: return new CityInfo("Vallda", "06", 57.4775, 12.00139);
case 164: return new CityInfo("Vallberga", "06", 56.46667, 13.01667);
case 165: return new CityInfo("Vallargärdet", "22", 59.47744, 13.58505);
case 166: return new CityInfo("Vallåkra", "27", 55.96133, 12.85611);
case 167: return new CityInfo("Valla", "07", 63.55, 13.8);
case 168: return new CityInfo("Valla", "18", 59.01667, 16.38333);
case 169: return new CityInfo("Valje", "27", 56.06279, 14.54388);
case 170: return new CityInfo("Valdemarsvik", "16", 58.2031, 16.60225);
case 171: return new CityInfo("Valbo", "03", 60.65, 17.03333);
case 172: return new CityInfo("Vålberg", "22", 59.39145, 13.18633);
case 173: return new CityInfo("Väjern", "28", 58.38333, 11.26667);
case 174: return new CityInfo("Vagnhärad", "18", 58.94587, 17.48757);
case 175: return new CityInfo("Vaggeryd", "08", 57.49807, 14.14842);
case 176: return new CityInfo("Vadstena", "16", 58.44863, 14.88969);
case 177: return new CityInfo("Väderstad", "16", 58.31667, 14.91667);
case 178: return new CityInfo("Väckelsång", "12", 56.63333, 14.91667);
case 179: return new CityInfo("Urshult", "12", 56.53333, 14.78333);
case 180: return new CityInfo("Uppsala", "21", 59.85882, 17.63889);
case 181: return new CityInfo("Upplands Väsby", "26", 59.51839, 17.91128);
case 182: return new CityInfo("Upphärad", "28", 58.15807, 12.30476);
case 183: return new CityInfo("Hjärup", "27", 55.6688, 13.13931);
case 184: return new CityInfo("Unnaryd", "06", 56.95, 13.51667);
case 185: return new CityInfo("Undersåker", "07", 63.31722, 13.24847);
case 186: return new CityInfo("Ulricehamn", "28", 57.79159, 13.41422);
case 187: return new CityInfo("Ullervad", "28", 58.66667, 13.86667);
case 188: return new CityInfo("Ullared", "06", 57.13333, 12.71667);
case 189: return new CityInfo("Uddevalla", "28", 58.34784, 11.9424);
case 190: return new CityInfo("Uddeholm", "22", 60.01667, 13.61667);
case 191: return new CityInfo("Ucklum", "28", 58.08333, 11.95);
case 192: return new CityInfo("Tystberga", "18", 58.85, 17.23306);
case 193: return new CityInfo("Tyringe", "27", 56.16037, 13.59811);
case 194: return new CityInfo("Tygelsjö", "27", 55.51667, 13);
case 195: return new CityInfo("Tving", "02", 56.30532, 15.47129);
case 196: return new CityInfo("Tvååker", "06", 57.04147, 12.3995);
case 197: return new CityInfo("Tureholm", "26", 59.31667, 17.71667);
case 198: return new CityInfo("Tumlehed", "28", 57.73237, 11.73778);
case 199: return new CityInfo("Tumba", "26", 59.19858, 17.83317);
case 200: return new CityInfo("Tullinge", "26", 59.2, 17.9);
case 201: return new CityInfo("Trosa", "18", 58.89621, 17.54812);
case 202: return new CityInfo("Trönningenäs", "06", 57.13846, 12.22596);
case 203: return new CityInfo("Trönninge", "06", 57.14474, 12.29253);
case 204: return new CityInfo("Trönninge", "06", 56.61667, 12.93333);
case 205: return new CityInfo("Trollhättan", "28", 58.28365, 12.28864);
case 206: return new CityInfo("Gimo", "21", 60.17304, 18.18507);
case 207: return new CityInfo("Trelleborg", "27", 55.37514, 13.15691);
case 208: return new CityInfo("Trekanten", "09", 56.7, 16.11667);
case 209: return new CityInfo("Träslövsläge", "06", 57.05417, 12.27899);
case 210: return new CityInfo("Traryd", "12", 56.57864, 13.74916);
case 211: return new CityInfo("Tranemo", "28", 57.48333, 13.35);
case 212: return new CityInfo("Tranås", "08", 58.03717, 14.9782);
case 213: return new CityInfo("Torup", "06", 56.95663, 13.07725);
case 214: return new CityInfo("Torslanda", "28", 57.72432, 11.77013);
case 215: return new CityInfo("Torshälla", "18", 59.41667, 16.46667);
case 216: return new CityInfo("Torsby", "22", 60.13527, 13.0082);
case 217: return new CityInfo("Torsås", "09", 56.41251, 15.99844);
case 218: return new CityInfo("Torsång", "10", 60.46667, 15.56667);
case 219: return new CityInfo("Torsåker", "24", 63.06667, 17.75);
case 220: return new CityInfo("Torsåker", "03", 60.5109, 16.47069);
case 221: return new CityInfo("Tormestorp", "27", 56.1135, 13.74516);
case 222: return new CityInfo("Torhamn", "02", 56.1, 15.83333);
case 223: return new CityInfo("Torekov", "27", 56.425, 12.63333);
case 224: return new CityInfo("Töreboda", "28", 58.70739, 14.12597);
case 225: return new CityInfo("Tomtebo", "10", 60.41667, 15.71667);
case 226: return new CityInfo("Tomelilla", "27", 55.54293, 13.9546);
case 227: return new CityInfo("Tollered", "28", 57.95, 12.1);
case 228: return new CityInfo("Tollered", "28", 57.81667, 12.41667);
case 229: return new CityInfo("Tollarp1", "27", 56.16667, 14.28333);
case 230: return new CityInfo("Tollarp", "27", 55.93333, 13.98333);
case 231: return new CityInfo("Töcksfors", "22", 59.50816, 11.84431);
case 232: return new CityInfo("Tobo", "21", 60.2584, 17.65606);
case 233: return new CityInfo("Tjuvkil", "28", 57.9, 11.73333);
case 234: return new CityInfo("Tjörnarp", "27", 55.99543, 13.6279);
case 235: return new CityInfo("Tjällmo", "16", 58.71667, 15.35);
case 236: return new CityInfo("Tingsryd", "12", 56.5247, 14.97902);
case 237: return new CityInfo("Timsfors", "12", 56.48333, 13.58333);
case 238: return new CityInfo("Timrå", "24", 62.48654, 17.32613);
case 239: return new CityInfo("Timmersdala", "28", 58.53333, 13.75);
case 240: return new CityInfo("Timmernabben", "09", 56.96667, 16.43333);
case 241: return new CityInfo("Timmele", "28", 57.85946, 13.42891);
case 242: return new CityInfo("Tillberga", "25", 59.68333, 16.61667);
case 243: return new CityInfo("Tierp", "21", 60.34269, 17.51812);
case 244: return new CityInfo("Tidan", "28", 58.57467, 14.00495);
case 245: return new CityInfo("Tidaholm", "28", 58.18035, 13.95824);
case 246: return new CityInfo("Tibro", "28", 58.42453, 14.16162);
case 247: return new CityInfo("Tenhult", "08", 57.70761, 14.32205);
case 248: return new CityInfo("Teckomatorp", "27", 55.86667, 13.08333);
case 249: return new CityInfo("Tärnsjö", "21", 60.15, 16.93333);
case 250: return new CityInfo("Tanumshede", "28", 58.72385, 11.32587);
case 251: return new CityInfo("Tångaberg", "06", 57.17358, 12.22753);
case 252: return new CityInfo("Tallboda", "16", 58.42521, 15.68154);
case 253: return new CityInfo("Tällberg", "10", 60.81667, 15);
case 254: return new CityInfo("Tallåsen", "23", 64.3, 18.83333);
case 255: return new CityInfo("Tallåsen", "03", 61.86667, 16.01667);
case 256: return new CityInfo("Täby", "26", 59.4439, 18.06872);
case 257: return new CityInfo("Taberg", "08", 57.67722, 14.08876);
case 258: return new CityInfo("Sylta", "25", 59.53333, 15.98333);
case 259: return new CityInfo("Svenstavik", "07", 62.76667, 14.43535);
case 260: return new CityInfo("Svenljunga", "28", 57.49551, 13.11078);
case 261: return new CityInfo("Sveg", "07", 62.03407, 14.36577);
case 262: return new CityInfo("Svedala", "27", 55.50788, 13.23515);
case 263: return new CityInfo("Svartvik", "24", 62.58639, 17.90849);
case 264: return new CityInfo("Svärtinge", "16", 58.65507, 16.02823);
case 265: return new CityInfo("Svarte", "27", 55.43184, 13.71394);
case 266: return new CityInfo("Svärdsjö", "10", 60.74022, 15.90173);
case 267: return new CityInfo("Svängsta", "02", 56.26667, 14.76667);
case 268: return new CityInfo("Svanesund", "28", 58.14292, 11.81821);
case 269: return new CityInfo("Svaneholm", "28", 57.61667, 12.81667);
case 270: return new CityInfo("Svanberga", "26", 59.84431, 18.66643);
case 271: return new CityInfo("Svalsta", "18", 58.74273, 16.86978);
case 272: return new CityInfo("Svalöv", "27", 55.9134, 13.10762);
case 273: return new CityInfo("Surte", "28", 57.82533, 12.01604);
case 274: return new CityInfo("Surahammar", "25", 59.70725, 16.22188);
case 275: return new CityInfo("Sunningen", "28", 58.33333, 11.83333);
case 276: return new CityInfo("Sunne", "22", 59.83764, 13.14302);
case 277: return new CityInfo("Sunnansjö", "23", 64.1, 19.35);
case 278: return new CityInfo("Sunnansjö", "10", 60.21667, 14.95);
case 279: return new CityInfo("Sundsvall", "24", 62.39129, 17.3063);
case 280: return new CityInfo("Sundsbruk", "24", 62.45806, 17.34889);
case 281: return new CityInfo("Sundbyberg", "26", 59.36128, 17.97114);
case 282: return new CityInfo("Sundborn", "10", 60.65, 15.76667);
case 283: return new CityInfo("Styrsö", "28", 57.61639, 11.78556);
case 284: return new CityInfo("Sturkö", "02", 56.08333, 15.7);
case 285: return new CityInfo("Sturefors", "16", 58.33333, 15.73333);
case 286: return new CityInfo("Stugun", "07", 63.16667, 15.6);
case 287: return new CityInfo("Strövelstorp", "27", 56.16979, 12.83925);
case 288: return new CityInfo("Strömsund", "07", 63.85206, 15.55583);
case 289: return new CityInfo("Strömstad", "28", 58.93945, 11.1712);
case 290: return new CityInfo("Strömsnäsbruk", "12", 56.55, 13.71667);
case 291: return new CityInfo("Guojkkasuoluoj", "14", 65.64762, 18.09909);
case 292: return new CityInfo("Strömsholm", "25", 59.52717, 16.243);
case 293: return new CityInfo("Strömma", "26", 59.28333, 18.53333);
case 294: return new CityInfo("Strängnäs", "18", 59.37741, 17.03119);
case 295: return new CityInfo("Storvreta", "21", 59.95933, 17.70588);
case 296: return new CityInfo("Storvik", "03", 60.58333, 16.53333);
case 297: return new CityInfo("Storuman", "23", 65.0959, 17.11731);
case 298: return new CityInfo("Storfors", "22", 59.53183, 14.27201);
case 299: return new CityInfo("Storebro", "09", 57.58333, 15.85);
case 300: return new CityInfo("Stora Vika", "26", 58.95569, 17.78644);
case 301: return new CityInfo("Stora Mellösa", "15", 59.21667, 15.5);
case 302: return new CityInfo("Stora Levene", "28", 58.32468, 12.92533);
case 303: return new CityInfo("Stora Höga", "28", 58.01667, 11.83333);
case 304: return new CityInfo("Storå", "15", 59.71409, 15.13169);
case 305: return new CityInfo("Stöpen", "28", 58.47802, 13.86611);
case 306: return new CityInfo("Stöde", "24", 62.41917, 16.58727);
case 307: return new CityInfo("Stockvik", "24", 62.33667, 17.36583);
case 308: return new CityInfo("Stockholm", "26", 59.32938, 18.06871);
case 309: return new CityInfo("Stockaryd", "08", 57.31737, 14.59341);
case 310: return new CityInfo("Stoby", "27", 56.17772, 13.82828);
case 311: return new CityInfo("Stjärnhov", "18", 59.08333, 17);
case 312: return new CityInfo("Stigtomta", "18", 58.8, 16.78333);
case 313: return new CityInfo("Stidsvig", "27", 56.2, 13.13333);
case 314: return new CityInfo("Stenungsund", "28", 58.07046, 11.8181);
case 315: return new CityInfo("Stenstorp", "16", 58.48333, 15.06667);
case 316: return new CityInfo("Stenstorp", "28", 58.27254, 13.71454);
case 317: return new CityInfo("Stenkullen", "28", 57.79476, 12.31688);
case 318: return new CityInfo("Steninge", "26", 59.60199, 17.80459);
case 319: return new CityInfo("Steninge", "06", 56.769, 12.63034);
case 320: return new CityInfo("Stenhamra", "26", 59.3344, 17.68842);
case 321: return new CityInfo("Stehag", "27", 55.90188, 13.39577);
case 322: return new CityInfo("Stavsnäs", "26", 59.28333, 18.68333);
case 323: return new CityInfo("Stångby", "27", 55.7503, 13.19797);
case 324: return new CityInfo("Stallarholmen", "18", 59.36667, 17.2);
case 325: return new CityInfo("Staffanstorp", "27", 55.64277, 13.20638);
case 326: return new CityInfo("Gamla Stan", "26", 59.32627, 18.07251);
case 327: return new CityInfo("Sparreholm", "18", 59.06667, 16.81667);
case 328: return new CityInfo("Sösdala", "27", 56.03992, 13.67811);
case 329: return new CityInfo("Sörvik", "07", 64.13333, 15.71667);
case 330: return new CityInfo("Sörvik", "10", 60.18393, 15.15633);
case 331: return new CityInfo("Sorsele", "23", 65.53484, 17.53702);
case 332: return new CityInfo("Sörforsa", "03", 61.73333, 16.98333);
case 333: return new CityInfo("Söråker", "24", 62.50561, 17.51032);
case 334: return new CityInfo("Sommen", "08", 58.13333, 14.96667);
case 335: return new CityInfo("Sölvesborg", "02", 56.05205, 14.57525);
case 336: return new CityInfo("Solna", "26", 59.36004, 18.00086);
case 337: return new CityInfo("Sollerön", "10", 60.91667, 14.61667);
case 338: return new CityInfo("Sollentuna", "26", 59.42804, 17.95093);
case 339: return new CityInfo("Sollefteå", "24", 63.16667, 17.26667);
case 340: return new CityInfo("Sollebrunn", "28", 58.11667, 12.53333);
case 341: return new CityInfo("Södra Vi", "09", 57.73993, 15.79391);
case 342: return new CityInfo("Södra Sandby", "09", 56.56667, 16.61667);
case 343: return new CityInfo("Södra Sandby", "27", 55.71677, 13.34659);
case 344: return new CityInfo("Södertälje", "26", 59.19554, 17.62525);
case 345: return new CityInfo("Södermalm", "26", 59.31278, 18.07577);
case 346: return new CityInfo("Söderköping", "16", 58.48057, 16.32221);
case 347: return new CityInfo("Söderhamn", "03", 61.30373, 17.05921);
case 348: return new CityInfo("Söderfors", "23", 64.81667, 18.05);
case 349: return new CityInfo("Söderfors", "21", 60.38333, 17.23333);
case 350: return new CityInfo("Söderbärke", "10", 60.07011, 15.56025);
case 351: return new CityInfo("Söderala", "03", 61.28333, 16.96667);
case 352: return new CityInfo("Söderåkra", "09", 56.45, 16.06667);
case 353: return new CityInfo("Smygehamn", "27", 55.34337, 13.36989);
case 354: return new CityInfo("Smögen", "28", 58.35593, 11.22411);
case 355: return new CityInfo("Smedjebacken", "10", 60.14181, 15.41416);
case 356: return new CityInfo("Smedby", "10", 60.7, 15.05);
case 357: return new CityInfo("Smedby", "09", 56.67413, 16.2432);
case 358: return new CityInfo("Smålandsstenar", "08", 57.16241, 13.41212);
case 359: return new CityInfo("Anneberg", "08", 57.72349, 14.80627);
case 360: return new CityInfo("Slottsbron", "22", 59.3227, 13.10268);
case 361: return new CityInfo("Slöinge", "06", 56.85, 12.68333);
case 362: return new CityInfo("Slite", "05", 57.70461, 18.8031);
case 363: return new CityInfo("Slaka", "16", 58.36667, 15.55);
case 364: return new CityInfo("Skyttorp", "21", 60.08333, 17.73333);
case 365: return new CityInfo("Skutskär", "21", 60.62507, 17.41552);
case 366: return new CityInfo("Skurup", "27", 55.47839, 13.50186);
case 367: return new CityInfo("Skultuna", "25", 59.71667, 16.41667);
case 368: return new CityInfo("Skultorp", "28", 58.35, 13.83333);
case 369: return new CityInfo("Skruv", "12", 57.15, 15.16667);
case 370: return new CityInfo("Skruv", "12", 56.67646, 15.3659);
case 371: return new CityInfo("Skrea", "06", 56.88333, 12.56667);
case 372: return new CityInfo("Skövde", "28", 58.39118, 13.84506);
case 373: return new CityInfo("Skottsund", "24", 62.29056, 17.38694);
case 374: return new CityInfo("Skottorp", "06", 56.44929, 12.96067);
case 375: return new CityInfo("Sköllersta", "15", 59.13738, 15.3394);
case 376: return new CityInfo("Sköldinge", "18", 59.03106, 16.44713);
case 377: return new CityInfo("Skogstorp", "18", 59.32472, 16.48284);
case 378: return new CityInfo("Skogsby", "09", 56.63643, 16.52321);
case 379: return new CityInfo("Skoghall", "22", 59.32324, 13.46552);
case 380: return new CityInfo("Skivarp", "27", 55.41667, 13.56667);
case 381: return new CityInfo("Skinnskatteberg", "25", 59.83028, 15.69337);
case 382: return new CityInfo("Skillinge", "25", 59.42423, 16.11746);
case 383: return new CityInfo("Skillinge", "27", 55.47428, 14.28283);
case 384: return new CityInfo("Skillingaryd", "08", 57.43044, 14.09383);
case 385: return new CityInfo("Skepplanda", "28", 57.98333, 12.2);
case 386: return new CityInfo("Skegrie", "27", 55.40633, 13.07693);
case 387: return new CityInfo("Skee", "28", 58.9257, 11.26931);
case 388: return new CityInfo("Skattkärr", "22", 59.41208, 13.67078);
case 389: return new CityInfo("Skärplinge", "21", 60.46667, 17.76667);
case 390: return new CityInfo("Skärhamn", "28", 57.98665, 11.55742);
case 391: return new CityInfo("Skåre", "27", 55.38333, 13.05);
case 392: return new CityInfo("Skåre", "22", 59.43333, 13.43333);
case 393: return new CityInfo("Skärblacka", "16", 58.56667, 15.9);
case 394: return new CityInfo("Skara", "28", 58.38659, 13.43836);
case 395: return new CityInfo("Skänninge", "26", 59.93333, 18.48333);
case 396: return new CityInfo("Skänninge", "16", 58.39427, 15.08659);
case 397: return new CityInfo("Skällinge", "06", 57.18333, 12.46667);
case 398: return new CityInfo("Sjuntorp", "28", 58.2, 12.21667);
case 399: return new CityInfo("Sjövik", "10", 60.15, 16.31667);
case 400: return new CityInfo("Sjövik", "28", 57.91667, 12.36667);
case 401: return new CityInfo("Sjötorp", "22", 59.48333, 14.25);
case 402: return new CityInfo("Sjörröd", "27", 56.28333, 13.91667);
case 403: return new CityInfo("Sjömarken", "28", 57.71533, 12.83495);
case 404: return new CityInfo("Sjöbo", "27", 55.63135, 13.70622);
case 405: return new CityInfo("Simrishamn", "27", 55.55653, 14.35037);
case 406: return new CityInfo("Simlångsdalen", "06", 56.72199, 13.13211);
case 407: return new CityInfo("Silverdalen", "09", 57.54095, 15.75104);
case 408: return new CityInfo("Siljansnäs", "10", 60.78333, 14.85);
case 409: return new CityInfo("Sigtuna", "26", 59.61731, 17.72361);
case 410: return new CityInfo("Sibbhult", "27", 56.26667, 14.2);
case 411: return new CityInfo("Sexdrega", "28", 57.58333, 13.11667);
case 412: return new CityInfo("Selja", "10", 61.01667, 14.46667);
case 413: return new CityInfo("Segersäng", "26", 59.02791, 17.93379);
case 414: return new CityInfo("Segeltorp", "26", 59.27597, 17.93072);
case 415: return new CityInfo("Saxdalen", "10", 60.14696, 14.98553);
case 416: return new CityInfo("Sävsjö", "08", 57.40327, 14.66244);
case 417: return new CityInfo("Sävja", "21", 59.81872, 17.69958);
case 418: return new CityInfo("Kyrkobyn", "28", 57.8, 11.91667);
case 419: return new CityInfo("Sätofta", "27", 55.91667, 13.55);
case 420: return new CityInfo("Sätila", "28", 57.54172, 12.43429);
case 421: return new CityInfo("Säter", "10", 60.34778, 15.75051);
case 422: return new CityInfo("Särö", "06", 57.50577, 11.9321);
case 423: return new CityInfo("Särna", "10", 61.69284, 13.14257);
case 424: return new CityInfo("Sankt Olof", "27", 55.63333, 14.13333);
case 425: return new CityInfo("Sandviken", "03", 60.61667, 16.76667);
case 426: return new CityInfo("Sandhult", "28", 57.76667, 12.81667);
case 427: return new CityInfo("Sandhem", "28", 58.01667, 13.48333);
case 428: return new CityInfo("Sandhem", "08", 57.98333, 13.76667);
case 429: return new CityInfo("Sandarne", "03", 61.25893, 17.15284);
case 430: return new CityInfo("Sandared", "28", 57.70992, 12.79238);
case 431: return new CityInfo("Saltsjöbaden", "26", 59.28333, 18.3);
case 432: return new CityInfo("Sälen", "10", 61.15, 13.26667);
case 433: return new CityInfo("Sålanda", "28", 57.98333, 12.21667);
case 434: return new CityInfo("Sala", "25", 59.91993, 16.60655);
case 435: return new CityInfo("Sågmyra", "10", 60.71667, 15.28333);
case 436: return new CityInfo("Säffle", "22", 59.13229, 12.92888);
case 437: return new CityInfo("Ryssby", "08", 57.71667, 14.65);
case 438: return new CityInfo("Ryssby", "12", 56.86667, 14.16667);
case 439: return new CityInfo("Rydsgård", "27", 55.47285, 13.58829);
case 440: return new CityInfo("Rydebäck", "27", 55.96667, 12.76667);
case 441: return new CityInfo("Rydboholm", "28", 57.65, 12.88333);
case 442: return new CityInfo("Rydbo", "26", 59.46191, 18.18538);
case 443: return new CityInfo("Rydaholm", "08", 56.98388, 14.30849);
case 444: return new CityInfo("Ryd", "16", 58.66667, 15.08333);
case 445: return new CityInfo("Ryd", "12", 56.46667, 14.68333);
case 446: return new CityInfo("Rundvik", "23", 63.53333, 19.43333);
case 447: return new CityInfo("Ruda", "16", 58.63333, 15.76667);
case 448: return new CityInfo("Ruda", "09", 57.10911, 16.11424);
case 449: return new CityInfo("Rottne", "12", 57.01667, 14.9);
case 450: return new CityInfo("Rot", "10", 61.25, 14.03333);
case 451: return new CityInfo("Röstånga", "27", 56, 13.28333);
case 452: return new CityInfo("Rosersberg", "26", 59.58333, 17.88333);
case 453: return new CityInfo("Rörvik", "26", 59.9, 18.9);
case 454: return new CityInfo("Rörvik", "08", 57.2381, 14.57719);
case 455: return new CityInfo("Rönninge", "26", 59.2, 17.73333);
case 456: return new CityInfo("Ronnebyhamn", "02", 56.18333, 15.3);
case 457: return new CityInfo("Ronneby", "02", 56.20999, 15.27602);
case 458: return new CityInfo("Rönnäng", "28", 57.93333, 11.58333);
case 459: return new CityInfo("Romme", "10", 60.43333, 15.5);
case 460: return new CityInfo("Roma", "05", 57.50357, 18.45899);
case 461: return new CityInfo("Rolfstorp", "06", 57.15, 12.45);
case 462: return new CityInfo("Rödeby", "02", 56.26078, 15.62143);
case 463: return new CityInfo("Rockneby", "09", 56.80223, 16.35014);
case 464: return new CityInfo("Rinkabyholm", "09", 56.64972, 16.26667);
case 465: return new CityInfo("Rinkaby", "15", 59.46667, 15.58333);
case 466: return new CityInfo("Rinkaby", "27", 55.98333, 14.26667);
case 467: return new CityInfo("Ringarum", "16", 58.33333, 16.45);
case 468: return new CityInfo("Rindö", "26", 59.39688, 18.39434);
case 469: return new CityInfo("Rimforsa", "16", 58.13624, 15.6865);
case 470: return new CityInfo("Rimbo", "26", 59.75, 18.36667);
case 471: return new CityInfo("Resarö", "26", 59.4291, 18.33386);
case 472: return new CityInfo("Rejmyre", "16", 58.83333, 15.91667);
case 473: return new CityInfo("Reftele", "08", 57.17467, 13.59498);
case 474: return new CityInfo("Rävlanda", "28", 57.65338, 12.49791);
case 475: return new CityInfo("Rättvik", "10", 60.88632, 15.11787);
case 476: return new CityInfo("Råtorp", "22", 59.40197, 13.49144);
case 477: return new CityInfo("Råsunda", "26", 59.36588, 17.99569);
case 478: return new CityInfo("Ransta", "25", 59.81037, 16.63738);
case 479: return new CityInfo("Ramvik", "24", 62.81667, 17.85);
case 480: return new CityInfo("Ramsele", "23", 64.06667, 19.55);
case 481: return new CityInfo("Ramsele", "24", 63.53947, 16.46791);
case 482: return new CityInfo("Ramnäs", "25", 59.76667, 16.2);
case 483: return new CityInfo("Raksta", "26", 59.22133, 18.2985);
case 484: return new CityInfo("Råby", "10", 60.1, 16.36667);
case 485: return new CityInfo("Råby", "21", 59.53333, 17.5);
case 486: return new CityInfo("Piperskärr", "09", 57.78333, 16.63306);
case 487: return new CityInfo("Perstorp", "27", 56.13829, 13.39476);
case 488: return new CityInfo("Pershagen", "26", 59.15494, 17.6534);
case 489: return new CityInfo("Påskallavik", "09", 57.16667, 16.45);
case 490: return new CityInfo("Påryd", "09", 56.56667, 15.91667);
case 491: return new CityInfo("Partille", "28", 57.7395, 12.10642);
case 492: return new CityInfo("Parksidan", "26", 59.28071, 17.84783);
case 493: return new CityInfo("Pålsboda", "15", 59.06565, 15.33747);
case 494: return new CityInfo("Påarp", "27", 56.03333, 12.81667);
case 495: return new CityInfo("Oxie", "27", 55.54014, 13.09605);
case 496: return new CityInfo("Öxeryd", "28", 57.73621, 12.27881);
case 497: return new CityInfo("Oxelösund", "18", 58.67057, 17.10152);
case 498: return new CityInfo("Överum", "09", 57.98856, 16.3139);
case 499: return new CityInfo("Överlida", "28", 57.34957, 12.89703);
case 500: return new CityInfo("Överhörnäs", "24", 63.28763, 18.58119);
case 501: return new CityInfo("Överhärde", "03", 60.61667, 16.96667);
case 502: return new CityInfo("Otterbäcken", "28", 58.95, 14.03333);
case 503: return new CityInfo("Östra Ljungby", "27", 56.19601, 13.09199);
case 504: return new CityInfo("Östra Karup", "27", 56.42608, 12.93595);
case 505: return new CityInfo("Östra Husby", "16", 58.58306, 16.55);
case 506: return new CityInfo("Östra Grevie", "27", 55.46667, 13.13333);
case 507: return new CityInfo("Östnor", "10", 61.03333, 14.48333);
case 508: return new CityInfo("Östhammar", "21", 60.25909, 18.37408);
case 509: return new CityInfo("Östervåla", "21", 60.18333, 17.18333);
case 510: return new CityInfo("Östersund", "07", 63.1792, 14.63566);
case 511: return new CityInfo("Östermalm", "26", 59.33879, 18.08487);
case 512: return new CityInfo("Österbymo", "16", 57.82465, 15.27357);
case 513: return new CityInfo("Österbybruk", "21", 60.2, 17.9);
case 514: return new CityInfo("Österby", "05", 57.71806, 18.80086);
case 515: return new CityInfo("Östansjö", "14", 66.09188, 17.52283);
case 516: return new CityInfo("Östansjö", "15", 59.05, 14.98333);
case 517: return new CityInfo("Ösmo", "26", 58.98333, 17.9);
case 518: return new CityInfo("Oskarström", "06", 56.8, 12.96667);
case 519: return new CityInfo("Oskarshamn", "09", 57.26455, 16.44837);
case 520: return new CityInfo("Oskar-Fredriksborg", "26", 59.4, 18.43333);
case 521: return new CityInfo("Osby", "27", 56.38165, 13.99364);
case 522: return new CityInfo("Örsundsbro", "21", 59.73333, 17.3);
case 523: return new CityInfo("Orsa", "10", 61.12034, 14.6155);
case 524: return new CityInfo("Orrefors", "09", 56.84058, 15.74599);
case 525: return new CityInfo("Örnsköldsvik", "24", 63.29091, 18.71525);
case 526: return new CityInfo("Ornäs", "10", 60.50944, 15.54128);
case 527: return new CityInfo("Ölmanäs", "06", 57.36241, 12.08839);
case 528: return new CityInfo("Örkelljunga", "27", 56.28338, 13.27773);
case 529: return new CityInfo("Öregrund", "21", 60.33333, 18.43333);
case 530: return new CityInfo("Örebro", "15", 59.27412, 15.2066);
case 531: return new CityInfo("Örbyhus", "21", 60.22407, 17.70138);
case 532: return new CityInfo("Onslunda", "27", 55.59815, 14.05089);
case 533: return new CityInfo("Önnestad", "27", 56.05747, 14.02233);
case 534: return new CityInfo("Olstorp", "18", 58.81667, 16.63333);
case 535: return new CityInfo("Ölsta", "26", 59.4, 17.65);
case 536: return new CityInfo("Olsfors", "28", 57.69107, 12.6979);
case 537: return new CityInfo("Olofström", "02", 56.2773, 14.53402);
case 538: return new CityInfo("Olofstorp", "28", 58.25, 14);
case 539: return new CityInfo("Olofstorp", "28", 57.80444, 12.17131);
case 540: return new CityInfo("Ölmbrotorp", "15", 59.3922, 15.24228);
case 541: return new CityInfo("Öjersjö", "28", 57.69882, 12.13448);
case 542: return new CityInfo("Ödsmål", "28", 58.71667, 11.48333);
case 543: return new CityInfo("Ödsmål", "28", 58.1, 11.85);
case 544: return new CityInfo("Ödeshög", "16", 58.22949, 14.65294);
case 545: return new CityInfo("Odensjö", "08", 57.71667, 14.16667);
case 546: return new CityInfo("Odensbacken", "15", 59.16667, 15.53333);
case 547: return new CityInfo("Ödeborg", "28", 58.54506, 11.97458);
case 548: return new CityInfo("Ödåkra", "27", 56.10412, 12.7477);
case 549: return new CityInfo("Öckerö", "28", 57.70814, 11.65585);
case 550: return new CityInfo("Ockelbo", "03", 60.8912, 16.71846);
case 551: return new CityInfo("Öbonäs", "16", 58.54333, 16.19092);
case 552: return new CityInfo("Nynäshamn", "26", 58.90337, 17.94793);
case 553: return new CityInfo("Nyland", "24", 63.00619, 17.7594);
case 554: return new CityInfo("Nykvarn", "26", 59.8, 18.3);
case 555: return new CityInfo("Nykvarn", "26", 59.17718, 17.4323);
case 556: return new CityInfo("Nykroppa", "22", 59.62274, 14.30313);
case 557: return new CityInfo("Nyköping", "18", 58.753, 17.00788);
case 558: return new CityInfo("Nyhammar", "10", 60.28333, 14.96667);
case 559: return new CityInfo("Nybro", "09", 56.74461, 15.90714);
case 560: return new CityInfo("Nusnäs", "10", 60.96667, 14.63333);
case 561: return new CityInfo("Nossebro", "28", 58.18808, 12.71599);
case 562: return new CityInfo("Norsjö", "23", 64.91206, 19.48153);
case 563: return new CityInfo("Norsholm", "16", 58.50539, 15.97243);
case 564: return new CityInfo("Norrtälje", "26", 59.75799, 18.70496);
case 565: return new CityInfo("Norrsundet", "03", 60.95, 17.13333);
case 566: return new CityInfo("Norrköping", "16", 58.59419, 16.1826);
case 567: return new CityInfo("Norra Bro", "15", 59.21667, 15.25);
case 568: return new CityInfo("Norra Åsum", "27", 55.98333, 14.15);
case 569: return new CityInfo("Norje", "02", 56.11667, 14.66667);
case 570: return new CityInfo("Nordmaling", "23", 63.56852, 19.50244);
case 571: return new CityInfo("Norberg", "25", 60.06505, 15.92366);
case 572: return new CityInfo("Nora", "15", 59.51926, 15.03979);
case 573: return new CityInfo("Nolvik", "28", 57.78333, 11.81667);
case 574: return new CityInfo("Nolby", "24", 62.2875, 17.36917);
case 575: return new CityInfo("Nogersund", "02", 56, 14.73333);
case 576: return new CityInfo("Njutånger", "03", 61.6125, 17.05556);
case 577: return new CityInfo("Njurundabommen", "24", 62.26339, 17.38354);
case 578: return new CityInfo("Nävekvarn", "18", 58.63306, 16.8);
case 579: return new CityInfo("Nättraby", "02", 56.2, 15.51667);
case 580: return new CityInfo("Näsviken", "03", 61.76667, 16.86667);
case 581: return new CityInfo("Näsum", "27", 56.17693, 14.49706);
case 582: return new CityInfo("Nässjö", "08", 57.65307, 14.69676);
case 583: return new CityInfo("Näsåker", "24", 63.44384, 16.9024);
case 584: return new CityInfo("Nälden", "07", 63.35, 14.25);
case 585: return new CityInfo("Nacka", "26", 59.31053, 18.16372);
case 586: return new CityInfo("Myresjö", "08", 57.38509, 14.96325);
case 587: return new CityInfo("Myggenäs", "28", 58.06176, 11.74936);
case 588: return new CityInfo("Munkfors", "22", 59.83856, 13.54361);
case 589: return new CityInfo("Munkedal", "28", 58.46634, 11.67345);
case 590: return new CityInfo("Munka-Ljungby", "27", 56.25, 12.96667);
case 591: return new CityInfo("Mullsjö", "08", 57.9171, 13.87831);
case 592: return new CityInfo("Mullhyttan", "15", 59.15, 14.68333);
case 593: return new CityInfo("Motala", "16", 58.53706, 15.03649);
case 594: return new CityInfo("Mosås", "15", 59.2, 15.13333);
case 595: return new CityInfo("Mörtnäs", "26", 59.31862, 18.44312);
case 596: return new CityInfo("Mörsil", "07", 63.30906, 13.66356);
case 597: return new CityInfo("Mörrum", "02", 56.19281, 14.74739);
case 598: return new CityInfo("Mörlunda", "09", 57.31667, 15.85);
case 599: return new CityInfo("Morgongåva", "21", 59.93395, 16.96353);
case 600: return new CityInfo("Mörbylånga", "09", 56.5248, 16.37877);
case 601: return new CityInfo("Mörarp", "27", 56.05749, 12.88018);
case 602: return new CityInfo("Mora", "10", 61.00704, 14.54316);
case 603: return new CityInfo("Mora", "10", 60.4, 15.6);
case 604: return new CityInfo("Mönsterås", "09", 57.04134, 16.44463);
case 605: return new CityInfo("Mölnlycke", "28", 57.65893, 12.11792);
case 606: return new CityInfo("Mölndal", "28", 57.6554, 12.01378);
case 607: return new CityInfo("Mölnbo", "26", 59.05, 17.41667);
case 608: return new CityInfo("Mölltorp", "28", 58.5, 14.4);
case 609: return new CityInfo("Mölle", "27", 56.28333, 12.5);
case 610: return new CityInfo("Molkom", "22", 59.60057, 13.72115);
case 611: return new CityInfo("Moholm", "28", 58.60645, 14.03897);
case 612: return new CityInfo("Moheda", "12", 57, 14.56667);
case 613: return new CityInfo("Mohed", "03", 61.29799, 16.81394);
case 614: return new CityInfo("Mockfjärd", "10", 60.5, 14.96667);
case 615: return new CityInfo("Mjölby", "16", 58.32595, 15.12365);
case 616: return new CityInfo("Mjällby", "06", 56.68333, 12.76667);
case 617: return new CityInfo("Mjällby", "02", 56.05, 14.68333);
case 618: return new CityInfo("Mellösa", "15", 59.2, 15.5);
case 619: return new CityInfo("Mellösa", "18", 59.1, 16.55);
case 620: return new CityInfo("Mellerud", "28", 58.69979, 12.45312);
case 621: return new CityInfo("Mellbystrand", "06", 56.48561, 12.93958);
case 622: return new CityInfo("Mellansel", "24", 63.42512, 18.31555);
case 623: return new CityInfo("Matfors", "24", 62.34864, 17.03173);
case 624: return new CityInfo("Märsta", "26", 59.62157, 17.85476);
case 625: return new CityInfo("Markaryd", "12", 56.46135, 13.59644);
case 626: return new CityInfo("Mariestad", "28", 58.70971, 13.82367);
case 627: return new CityInfo("Marieholm", "08", 57.38333, 13.85);
case 628: return new CityInfo("Marieholm", "27", 55.86667, 13.15);
case 629: return new CityInfo("Mariefred", "18", 59.25963, 17.223);
case 630: return new CityInfo("Mariannelund", "08", 57.61667, 15.56667);
case 631: return new CityInfo("Mantorp", "16", 58.35, 15.28333);
case 632: return new CityInfo("Månkarbo", "21", 60.22822, 17.46213);
case 633: return new CityInfo("Malungsfors", "10", 60.73333, 13.55);
case 634: return new CityInfo("Malung", "10", 60.68329, 13.71542);
case 635: return new CityInfo("Målsryd", "28", 57.68333, 13.05);
case 636: return new CityInfo("Malmslätt", "16", 58.41102, 15.51647);
case 637: return new CityInfo("Malmö", "27", 55.60587, 13.00073);
case 638: return new CityInfo("Malmköping", "18", 59.13333, 16.73333);
case 639: return new CityInfo("Malmbäck", "08", 57.57667, 14.4617);
case 640: return new CityInfo("Målilla", "09", 57.38773, 15.80675);
case 641: return new CityInfo("Malå", "23", 65.18501, 18.74243);
case 642: return new CityInfo("Lysekil", "28", 58.27429, 11.43576);
case 643: return new CityInfo("Lycksele", "23", 64.59537, 18.67351);
case 644: return new CityInfo("Lundsbrunn", "28", 58.47168, 13.44727);
case 645: return new CityInfo("Lund", "27", 55.70584, 13.19321);
case 646: return new CityInfo("Lugnås", "28", 58.64323, 13.70162);
case 647: return new CityInfo("Ludvika", "10", 60.14959, 15.18776);
case 648: return new CityInfo("Ludvigsborg", "27", 55.9, 13.6);
case 649: return new CityInfo("Lucksta", "24", 62.29903, 17.04958);
case 650: return new CityInfo("Lövstalöt", "21", 59.9574, 17.57826);
case 651: return new CityInfo("Lövestad", "27", 55.65265, 13.89148);
case 652: return new CityInfo("Löttorp", "09", 57.16667, 16.98333);
case 653: return new CityInfo("Lotorp", "16", 58.73333, 15.83333);
case 654: return new CityInfo("Lönsboda", "27", 56.4, 14.31667);
case 655: return new CityInfo("Lomma", "27", 55.67244, 13.06849);
case 656: return new CityInfo("Lögdeå", "23", 63.5489, 19.38735);
case 657: return new CityInfo("Lödöse", "28", 58.02994, 12.15934);
case 658: return new CityInfo("Löderup", "27", 55.43333, 14.11667);
case 659: return new CityInfo("Löddeköpinge", "27", 55.76667, 13.01667);
case 660: return new CityInfo("Löberöd", "27", 55.7761, 13.52414);
case 661: return new CityInfo("Ljusne", "03", 61.2117, 17.1279);
case 662: return new CityInfo("Ljusdal", "03", 61.82883, 16.09126);
case 663: return new CityInfo("Ljungskile", "28", 58.22452, 11.92014);
case 664: return new CityInfo("Ljungsbro", "16", 58.51667, 15.5);
case 665: return new CityInfo("Ljunghusen", "27", 55.39793, 12.92486);
case 666: return new CityInfo("Ljungbyholm", "09", 56.63333, 16.16667);
case 667: return new CityInfo("Ljungbyhed", "27", 56.07437, 13.2401);
case 668: return new CityInfo("Ljungby", "12", 56.83324, 13.94082);
case 669: return new CityInfo("Ljungaverk", "24", 62.48947, 16.04257);
case 670: return new CityInfo("Ljunga", "16", 58.51667, 16.35);
case 671: return new CityInfo("Ljung", "28", 57.98678, 13.05579);
case 672: return new CityInfo("Lit", "07", 63.32029, 14.84594);
case 673: return new CityInfo("Listerby", "02", 56.2, 15.4);
case 674: return new CityInfo("Linneryd", "08", 57.4, 14.15);
case 675: return new CityInfo("Linköping", "16", 58.41086, 15.62157);
case 676: return new CityInfo("Linghem", "16", 58.43333, 15.78333);
case 677: return new CityInfo("Linghed", "10", 60.78333, 15.85);
case 678: return new CityInfo("Lindsdal", "09", 56.73333, 16.3);
case 679: return new CityInfo("Lindome", "28", 57.56667, 12.08333);
case 680: return new CityInfo("Lindö", "16", 58.61667, 16.25);
case 681: return new CityInfo("Lindholmen", "26", 59.58333, 18.1);
case 682: return new CityInfo("Lindesberg", "15", 59.59202, 15.2304);
case 683: return new CityInfo("Limmared", "28", 57.53592, 13.35566);
case 684: return new CityInfo("Lilla Tjärby", "06", 56.527, 13.05676);
case 685: return new CityInfo("Lilla Edet", "28", 58.13333, 12.13333);
case 686: return new CityInfo("Lidköping", "28", 58.50517, 13.15765);
case 687: return new CityInfo("Lidingö", "26", 59.36667, 18.13333);
case 688: return new CityInfo("Lidhult", "16", 57.95, 15.4);
case 689: return new CityInfo("Lidhult", "12", 56.83333, 13.43333);
case 690: return new CityInfo("Liatorp", "12", 56.66667, 14.26667);
case 691: return new CityInfo("Lessebo", "12", 56.75185, 15.26969);
case 692: return new CityInfo("Lesjöfors", "22", 59.9759, 14.18264);
case 693: return new CityInfo("Lerum", "28", 57.77051, 12.26904);
case 694: return new CityInfo("Lerdala", "28", 58.47839, 13.71267);
case 695: return new CityInfo("Lenhovda", "12", 57, 15.28333);
case 696: return new CityInfo("Leksand", "10", 60.7303, 14.99994);
case 697: return new CityInfo("Lekeryd", "08", 57.76667, 14.4);
case 698: return new CityInfo("Laxå", "15", 58.9863, 14.61904);
case 699: return new CityInfo("Latorpsbruk", "15", 59.27264, 14.98328);
case 700: return new CityInfo("Länna", "21", 59.87149, 17.95125);
case 701: return new CityInfo("Långvik", "26", 59.24583, 18.51667);
case 702: return new CityInfo("Långshyttan", "10", 60.45238, 16.03831);
case 703: return new CityInfo("Långsele", "24", 63.18333, 17.06667);
case 704: return new CityInfo("Länghem", "28", 57.6, 13.23333);
case 705: return new CityInfo("Långås", "06", 56.98333, 12.45);
case 706: return new CityInfo("Landvetter", "28", 57.68665, 12.21169);
case 707: return new CityInfo("Landskrona", "27", 55.8708, 12.83016);
case 708: return new CityInfo("Landsbro", "08", 57.36667, 14.9);
case 709: return new CityInfo("Lammhult", "12", 57.16667, 14.58333);
case 710: return new CityInfo("Laholm", "06", 56.51207, 13.04371);
case 711: return new CityInfo("Lagan", "12", 56.91667, 13.98333);
case 712: return new CityInfo("Kyrkhult", "06", 56.55, 13.26667);
case 713: return new CityInfo("Kyrkhult", "02", 56.35, 14.58333);
case 714: return new CityInfo("Kyrkesund", "28", 58.01667, 11.51667);
case 715: return new CityInfo("Kvissleby", "24", 62.29361, 17.375);
case 716: return new CityInfo("Kvisljungeby", "28", 57.75, 11.83333);
case 717: return new CityInfo("Kvidinge", "27", 56.13386, 13.04678);
case 718: return new CityInfo("Kvicksund", "18", 59.45099, 16.32131);
case 719: return new CityInfo("Kvibille", "06", 56.78333, 12.83333);
case 720: return new CityInfo("Kvänum", "28", 58.3, 13.18333);
case 721: return new CityInfo("Kungsör", "25", 59.42245, 16.09656);
case 722: return new CityInfo("Kungsholmen", "26", 59.33183, 18.04118);
case 723: return new CityInfo("Kungshamn", "28", 58.36305, 11.25938);
case 724: return new CityInfo("Kungsgården", "24", 63, 17.83333);
case 725: return new CityInfo("Kungsgården", "03", 60.6, 16.61667);
case 726: return new CityInfo("Kungsberga", "26", 59.40483, 17.62926);
case 727: return new CityInfo("Kungsbacka", "06", 57.48719, 12.07612);
case 728: return new CityInfo("Kungsängen", "26", 59.47857, 17.74834);
case 729: return new CityInfo("Kungälv", "28", 57.87096, 11.98054);
case 730: return new CityInfo("Kummelnäs", "26", 59.35, 18.28333);
case 731: return new CityInfo("Kumla", "15", 59.1277, 15.14341);
case 732: return new CityInfo("Krylbo", "10", 60.13333, 16.21667);
case 733: return new CityInfo("Krokom", "07", 63.32589, 14.44883);
case 734: return new CityInfo("Krokek", "16", 58.67231, 16.36741);
case 735: return new CityInfo("Kristinehamn", "22", 59.30978, 14.10808);
case 736: return new CityInfo("Kristianstad", "27", 56.03129, 14.15242);
case 737: return new CityInfo("Kristdala", "09", 57.4007, 16.20496);
case 738: return new CityInfo("Kramfors", "24", 62.93161, 17.77646);
case 739: return new CityInfo("Kosta", "12", 56.84332, 15.39618);
case 740: return new CityInfo("Kortebo", "08", 57.81667, 14.15);
case 741: return new CityInfo("Korsberga", "08", 57.30246, 15.12519);
case 742: return new CityInfo("Koppom", "22", 59.70348, 12.1542);
case 743: return new CityInfo("Kopparmora", "26", 59.33306, 18.58306);
case 744: return new CityInfo("Kopparberg", "15", 59.87597, 14.99436);
case 745: return new CityInfo("Köpmanholmen", "24", 63.16667, 18.56667);
case 746: return new CityInfo("Köpingebro", "27", 55.45526, 13.93453);
case 747: return new CityInfo("Köping", "25", 59.51404, 15.99255);
case 748: return new CityInfo("Kolsva", "25", 59.6, 15.83333);
case 749: return new CityInfo("Kolbäck", "25", 59.56516, 16.23037);
case 750: return new CityInfo("Kode", "28", 57.94263, 11.85051);
case 751: return new CityInfo("Knutby", "21", 59.90867, 18.26568);
case 752: return new CityInfo("Knivsta", "21", 59.72564, 17.78753);
case 753: return new CityInfo("Knislinge", "27", 56.18333, 14.08333);
case 754: return new CityInfo("Knäred", "06", 56.51861, 13.32423);
case 755: return new CityInfo("Klövedal", "28", 58.03333, 11.58333);
case 756: return new CityInfo("Klippan", "27", 56.13559, 13.13086);
case 757: return new CityInfo("Klintehamn", "05", 57.38667, 18.20371);
case 758: return new CityInfo("Klingsta", "24", 62.32693, 17.21764);
case 759: return new CityInfo("Klagstorp", "27", 55.39296, 13.37465);
case 760: return new CityInfo("Klågerup", "27", 55.59416, 13.24574);
case 761: return new CityInfo("Kjulaås", "18", 59.38306, 16.66667);
case 762: return new CityInfo("Kivik", "27", 55.6851, 14.22025);
case 763: return new CityInfo("Kista", "26", 59.40316, 17.94479);
case 764: return new CityInfo("Kisa", "16", 57.98781, 15.63303);
case 765: return new CityInfo("Kinnarp", "28", 58.07786, 13.52061);
case 766: return new CityInfo("Kinna", "28", 57.50728, 12.69463);
case 767: return new CityInfo("Kimstad", "16", 58.54967, 15.96296);
case 768: return new CityInfo("Killeberg", "27", 56.47652, 14.09709);
case 769: return new CityInfo("Kilafors", "03", 61.23333, 16.56667);
case 770: return new CityInfo("Kil", "22", 59.50234, 13.31277);
case 771: return new CityInfo("Kaxholmen", "08", 57.85345, 14.30457);
case 772: return new CityInfo("Kävlinge", "27", 55.79188, 13.11021);
case 773: return new CityInfo("Kattarp", "27", 56.14024, 12.78234);
case 774: return new CityInfo("Katrineholm", "18", 58.99587, 16.20721);
case 775: return new CityInfo("Kårsta", "26", 59.65632, 18.27292);
case 776: return new CityInfo("Kärna", "28", 57.85, 11.78333);
case 777: return new CityInfo("Karlstad", "22", 59.3793, 13.50357);
case 778: return new CityInfo("Karlskrona", "02", 56.16156, 15.58661);
case 779: return new CityInfo("Karlskoga", "15", 59.32667, 14.52386);
case 780: return new CityInfo("Karlshamn", "02", 56.1706, 14.86188);
case 781: return new CityInfo("Karlsborg", "28", 58.53724, 14.5047);
case 782: return new CityInfo("Karlholmsbruk", "21", 60.52091, 17.63152);
case 783: return new CityInfo("Karby", "21", 60.15, 17.58333);
case 784: return new CityInfo("Karby", "26", 59.56087, 18.22007);
case 785: return new CityInfo("Kalmar", "09", 56.66157, 16.36163);
case 786: return new CityInfo("Kallinge", "02", 56.24841, 15.28721);
case 787: return new CityInfo("Kållered", "28", 57.60992, 12.05106);
case 788: return new CityInfo("Källby", "28", 58.50999, 13.30582);
case 789: return new CityInfo("Kåhög", "28", 57.75086, 12.15224);
case 790: return new CityInfo("Kågeröd", "27", 55.99976, 13.08795);
case 791: return new CityInfo("Jursla", "16", 58.66667, 16.18333);
case 792: return new CityInfo("Junsele", "24", 63.69586, 16.88256);
case 793: return new CityInfo("Jössefors", "22", 59.67295, 12.50335);
case 794: return new CityInfo("Jörlanda", "28", 57.9863, 11.82943);
case 795: return new CityInfo("Jordbro", "26", 59.14972, 18.11667);
case 796: return new CityInfo("Jonstorp", "28", 58, 12.71667);
case 797: return new CityInfo("Jonstorp", "27", 56.2338, 12.67184);
case 798: return new CityInfo("Jonsered", "28", 57.74588, 12.1735);
case 799: return new CityInfo("Jönköping", "08", 57.78145, 14.15618);
case 800: return new CityInfo("Jönåker", "18", 58.74434, 16.71947);
case 801: return new CityInfo("Jokkmokk", "14", 66.60665, 19.82324);
case 802: return new CityInfo("Johannishus", "02", 56.21667, 15.41667);
case 803: return new CityInfo("Johannedal", "24", 62.43424, 17.37273);
case 804: return new CityInfo("Järvsö", "03", 61.71667, 16.16667);
case 805: return new CityInfo("Järpen", "07", 63.3462, 13.46572);
case 806: return new CityInfo("Järpås", "28", 58.38333, 12.96667);
case 807: return new CityInfo("Järnforsen", "09", 57.41667, 15.61667);
case 808: return new CityInfo("Järna", "10", 60.53333, 14.36667);
case 809: return new CityInfo("Järna", "26", 59.09165, 17.56615);
case 810: return new CityInfo("Järlåsa", "21", 59.88333, 17.2);
case 811: return new CityInfo("Järbo", "03", 60.71667, 16.6);
case 812: return new CityInfo("Jämshög", "02", 56.23333, 14.51667);
case 813: return new CityInfo("Jämjö", "02", 56.19187, 15.84115);
case 814: return new CityInfo("Jakobsberg", "26", 59.42268, 17.83508);
case 815: return new CityInfo("Irsta", "21", 59.7, 16.93333);
case 816: return new CityInfo("Irsta", "25", 59.6, 16.7);
case 817: return new CityInfo("Insjön", "23", 64.4, 17.48333);
case 818: return new CityInfo("Insjön", "10", 60.67688, 15.09487);
case 819: return new CityInfo("Ingelstad", "12", 56.75, 14.91667);
case 820: return new CityInfo("Indal", "24", 62.57732, 17.09807);
case 821: return new CityInfo("Iggesund", "03", 61.64219, 17.07477);
case 822: return new CityInfo("Igelstorp", "28", 58.4, 13.96667);
case 823: return new CityInfo("Idre", "10", 61.85821, 12.71401);
case 824: return new CityInfo("Idala", "27", 55.62, 13.5);
case 825: return new CityInfo("Hyssna", "28", 57.55726, 12.53841);
case 826: return new CityInfo("Hyltebruk", "06", 56.99892, 13.23958);
case 827: return new CityInfo("Hyllinge", "27", 56.1, 12.85);
case 828: return new CityInfo("Husum", "24", 63.33333, 19.16667);
case 829: return new CityInfo("Huskvarna", "08", 57.78596, 14.30214);
case 830: return new CityInfo("Hunnebostrand", "28", 58.44127, 11.3032);
case 831: return new CityInfo("Hummelsta", "21", 59.62673, 16.9438);
case 832: return new CityInfo("Hultsfred", "09", 57.48815, 15.84357);
case 833: return new CityInfo("Hudiksvall", "03", 61.72744, 17.10558);
case 834: return new CityInfo("Huddinge", "26", 59.23705, 17.98192);
case 835: return new CityInfo("Hovsta", "15", 59.35, 15.21667);
case 836: return new CityInfo("Hovmantorp", "12", 56.78685, 15.14023);
case 837: return new CityInfo("Höviksnäs", "28", 58.03333, 11.76667);
case 838: return new CityInfo("Hova", "28", 58.85363, 14.21914);
case 839: return new CityInfo("Hoting", "07", 64.11353, 16.20552);
case 840: return new CityInfo("Hörvik", "02", 56.04233, 14.76175);
case 841: return new CityInfo("Horred", "28", 57.35475, 12.47777);
case 842: return new CityInfo("Hörnefors", "23", 63.62312, 19.90856);
case 843: return new CityInfo("Horndal", "10", 60.3, 16.41667);
case 844: return new CityInfo("Horn", "25", 59.5, 16.28333);
case 845: return new CityInfo("Horn", "16", 57.9, 15.83333);
case 846: return new CityInfo("Hörby", "27", 55.85238, 13.66094);
case 847: return new CityInfo("Höör", "27", 55.93444, 13.5385);
case 848: return new CityInfo("Hönö", "28", 57.68972, 11.64972);
case 849: return new CityInfo("Holsbybrunn", "08", 57.43333, 15.2);
case 850: return new CityInfo("Hölö", "26", 59.28333, 18.66667);
case 851: return new CityInfo("Hölö", "26", 59.01667, 17.53333);
case 852: return new CityInfo("Holm", "06", 56.73948, 12.85462);
case 853: return new CityInfo("Höllviken", "27", 55.40982, 12.9558);
case 854: return new CityInfo("Hököpinge", "27", 55.49411, 13.00782);
case 855: return new CityInfo("Hökerum", "28", 57.84085, 13.28351);
case 856: return new CityInfo("Hökåsen", "25", 59.66667, 16.58333);
case 857: return new CityInfo("Hok", "08", 57.51529, 14.27746);
case 858: return new CityInfo("Högsjö", "24", 62.52177, 17.09133);
case 859: return new CityInfo("Högsjö", "18", 59.02669, 15.66873);
case 860: return new CityInfo("Högsby", "09", 57.16597, 16.02562);
case 861: return new CityInfo("Högsäter", "22", 59.9, 11.98333);
case 862: return new CityInfo("Höganäs", "27", 56.19971, 12.55795);
case 863: return new CityInfo("Hofterup", "27", 55.80485, 12.9797);
case 864: return new CityInfo("Hofors", "03", 60.54573, 16.28668);
case 865: return new CityInfo("Hjuvik", "28", 57.70167, 11.71639);
case 866: return new CityInfo("Hjo", "28", 58.30133, 14.28784);
case 867: return new CityInfo("Hjärnarp", "27", 56.31667, 12.91667);
case 868: return new CityInfo("Hittarp", "27", 56.28333, 14.11667);
case 869: return new CityInfo("Hittarp", "27", 56.1, 12.63333);
case 870: return new CityInfo("Hindås", "28", 57.70338, 12.44657);
case 871: return new CityInfo("Hillerstorp", "08", 57.31293, 13.88437);
case 872: return new CityInfo("Hillared", "28", 57.63333, 13.15);
case 873: return new CityInfo("Hestra", "08", 57.91667, 14.58333);
case 874: return new CityInfo("Hestra", "08", 57.44232, 13.59575);
case 875: return new CityInfo("Herrljunga", "28", 58.07739, 13.02662);
case 876: return new CityInfo("Herrestad", "16", 58.38333, 14.8);
case 877: return new CityInfo("Henån", "28", 58.23848, 11.67598);
case 878: return new CityInfo("Hemse", "05", 57.23788, 18.37443);
case 879: return new CityInfo("Hemmesta", "26", 59.32273, 18.48675);
case 880: return new CityInfo("Helsingborg", "27", 56.04673, 12.69437);
case 881: return new CityInfo("Hedesunda", "03", 60.4, 17);
case 882: return new CityInfo("Hedemora", "10", 60.27973, 15.98855);
case 883: return new CityInfo("Hede", "07", 62.41367, 13.51255);
case 884: return new CityInfo("Heby", "21", 59.93815, 16.86217);
case 885: return new CityInfo("Haverdal", "06", 56.72222, 12.67194);
case 886: return new CityInfo("Hästveda", "27", 56.28468, 13.93547);
case 887: return new CityInfo("Hästhagen", "26", 59.3, 18.15);
case 888: return new CityInfo("Hasslö", "02", 56.11667, 15.48333);
case 889: return new CityInfo("Hässleholm", "27", 56.15905, 13.76638);
case 890: return new CityInfo("Hasslarp", "27", 56.13333, 12.81667);
case 891: return new CityInfo("Härryda", "28", 57.65436, 12.36318);
case 892: return new CityInfo("Harplinge", "06", 56.74491, 12.72758);
case 893: return new CityInfo("Härnösand", "24", 62.63228, 17.93794);
case 894: return new CityInfo("Harmånger", "03", 61.9276, 17.21849);
case 895: return new CityInfo("Harlösa", "27", 55.71725, 13.52623);
case 896: return new CityInfo("Harbo", "21", 60.1, 17.2);
case 897: return new CityInfo("Häradsbygden", "10", 60.7, 15.03333);
case 898: return new CityInfo("Härad", "18", 59.36065, 16.90339);
case 899: return new CityInfo("Haninge", "26", 59.16775, 18.14478);
case 900: return new CityInfo("Handen", "26", 59.16809, 18.13796);
case 901: return new CityInfo("Hanaskog", "27", 56.16061, 14.09307);
case 902: return new CityInfo("Hamrångefjärden", "03", 60.9, 17.06667);
case 903: return new CityInfo("Hammerdal", "07", 63.57615, 15.36516);
case 904: return new CityInfo("Hammenhög", "27", 55.5, 14.15);
case 905: return new CityInfo("Hammarstrand", "07", 63.11041, 16.35377);
case 906: return new CityInfo("Hammarslund", "27", 56.01798, 14.19401);
case 907: return new CityInfo("Hammarby", "03", 60.54385, 16.56934);
case 908: return new CityInfo("Hammar", "27", 56.01667, 14.21667);
case 909: return new CityInfo("Hamburgsund", "28", 58.55254, 11.27268);
case 910: return new CityInfo("Hälsö", "28", 57.73412, 11.65807);
case 911: return new CityInfo("Halmstad", "06", 56.67446, 12.85676);
case 912: return new CityInfo("Hallstavik", "26", 60.05, 18.6);
case 913: return new CityInfo("Hallstahammar", "25", 59.61395, 16.22846);
case 914: return new CityInfo("Hållsta", "07", 63, 14.96667);
case 915: return new CityInfo("Hållsta", "18", 59.29491, 16.45434);
case 916: return new CityInfo("Hallsberg", "15", 59.06463, 15.10993);
case 917: return new CityInfo("Hällevik", "02", 56.01667, 14.7);
case 918: return new CityInfo("Hällevadsholm", "28", 58.5796, 11.54058);
case 919: return new CityInfo("Hällekis", "28", 58.62919, 13.43801);
case 920: return new CityInfo("Hälleforsnäs", "18", 59.15208, 16.497);
case 921: return new CityInfo("Hällefors", "15", 59.78388, 14.52197);
case 922: return new CityInfo("Hällbybrunn", "18", 59.39152, 16.42229);
case 923: return new CityInfo("Hällberga", "18", 59.31667, 16.6);
case 924: return new CityInfo("Hällaryd", "08", 57.46667, 15.16667);
case 925: return new CityInfo("Hällaryd", "02", 56.2, 14.95);
case 926: return new CityInfo("Hällabrottet", "15", 59.11667, 15.2);
case 927: return new CityInfo("Häljarp", "27", 55.85, 12.91667);
case 928: return new CityInfo("Hagfors", "22", 60.02378, 13.67214);
case 929: return new CityInfo("Hagby", "21", 59.8, 17.36667);
case 930: return new CityInfo("Hagby", "09", 56.55175, 16.18684);
case 931: return new CityInfo("Hackås", "07", 62.91667, 14.51667);
case 932: return new CityInfo("Habo", "08", 57.91185, 14.07444);
case 933: return new CityInfo("Gyttorp", "15", 59.50503, 14.96661);
case 934: return new CityInfo("Gusum", "16", 58.2688, 16.49894);
case 935: return new CityInfo("Gustavsberg", "26", 59.32684, 18.38975);
case 936: return new CityInfo("Gunsta", "21", 59.85, 17.83333);
case 937: return new CityInfo("Gunnebo", "09", 57.71667, 16.53333);
case 938: return new CityInfo("Gullspång", "28", 58.98615, 14.09644);
case 939: return new CityInfo("Gullringen", "09", 57.8, 15.7);
case 940: return new CityInfo("Gullbranna", "06", 56.59167, 12.95);
case 941: return new CityInfo("Gullbrandstorp", "06", 56.7, 12.73333);
case 942: return new CityInfo("Gualöv", "27", 56.05, 14.41667);
case 943: return new CityInfo("Grythyttan", "15", 59.70593, 14.53453);
case 944: return new CityInfo("Grycksbo", "10", 60.68751, 15.48507);
case 945: return new CityInfo("Grundsund", "28", 58.21217, 11.41877);
case 946: return new CityInfo("Grums", "22", 59.35141, 13.11105);
case 947: return new CityInfo("Grödby", "26", 59.05, 17.88333);
case 948: return new CityInfo("Grimslöv", "12", 56.73333, 14.53333);
case 949: return new CityInfo("Grimsås", "28", 57.4838, 13.55027);
case 950: return new CityInfo("Grillby", "21", 59.62603, 17.25787);
case 951: return new CityInfo("Grevie", "27", 56.36667, 12.8);
case 952: return new CityInfo("Grebo", "16", 58.30145, 15.87085);
case 953: return new CityInfo("Grebbestad", "28", 58.70248, 11.25738);
case 954: return new CityInfo("Grästorp", "28", 58.33219, 12.68122);
case 955: return new CityInfo("Gränna", "08", 58.01667, 14.46667);
case 956: return new CityInfo("Grängesberg", "10", 60.07465, 15.00784);
case 957: return new CityInfo("Gräddö", "26", 59.76667, 19.03333);
case 958: return new CityInfo("Gråbo", "28", 57.83625, 12.29954);
case 959: return new CityInfo("Götene", "28", 58.52824, 13.49458);
case 960: return new CityInfo("Göteborg", "28", 57.70716, 11.96679);
case 961: return new CityInfo("Göta", "28", 58.10617, 12.15254);
case 962: return new CityInfo("Gnosjö", "08", 57.3585, 13.73686);
case 963: return new CityInfo("Gnesta", "18", 59.04751, 17.31191);
case 964: return new CityInfo("Gnarp", "03", 62.04874, 17.25858);
case 965: return new CityInfo("Glumslöv", "27", 55.94091, 12.80929);
case 966: return new CityInfo("Glommen", "06", 57.93333, 12.35);
case 967: return new CityInfo("Glommen", "06", 56.93333, 12.35);
case 968: return new CityInfo("Glimåkra", "27", 56.3, 14.13333);
case 969: return new CityInfo("Glanshammar", "15", 59.31667, 15.4);
case 970: return new CityInfo("Gislaved", "08", 57.3044, 13.54078);
case 971: return new CityInfo("Gimåt", "24", 63.31667, 18.71667);
case 972: return new CityInfo("Getinge", "06", 56.81667, 12.73333);
case 973: return new CityInfo("Genevad", "06", 56.56858, 13.03186);
case 974: return new CityInfo("Genarp", "27", 55.59907, 13.3982);
case 975: return new CityInfo("Gemla", "12", 56.86753, 14.64379);
case 976: return new CityInfo("Gåvsta", "21", 59.94297, 17.87774);
case 977: return new CityInfo("Gävle", "03", 60.67452, 17.14174);
case 978: return new CityInfo("Gärsnäs", "22", 59.41667, 12.9);
case 979: return new CityInfo("Gärsnäs", "27", 55.54949, 14.17923);
case 980: return new CityInfo("Garphyttan", "15", 59.30429, 14.94623);
case 981: return new CityInfo("Garpenberg", "10", 60.31667, 16.2);
case 982: return new CityInfo("Gärds Köpinge", "27", 55.93333, 14.15);
case 983: return new CityInfo("Gantofta", "27", 55.98729, 12.80482);
case 984: return new CityInfo("Gånghester", "28", 57.7, 13.01667);
case 985: return new CityInfo("Gamleby", "09", 57.89485, 16.40508);
case 986: return new CityInfo("Gamla Uppsala", "21", 59.89817, 17.63386);
case 987: return new CityInfo("Gällstad", "28", 57.66667, 13.43333);
case 988: return new CityInfo("Gällö", "07", 62.91275, 15.2319);
case 989: return new CityInfo("Gagnef", "10", 60.59856, 15.07745);
case 990: return new CityInfo("Fyllinge", "06", 56.65, 12.91667);
case 991: return new CityInfo("Furuvik", "03", 60.65, 17.33333);
case 992: return new CityInfo("Furulund", "28", 57.71667, 12.13333);
case 993: return new CityInfo("Furulund", "27", 55.7738, 13.09022);
case 994: return new CityInfo("Funäsdalen", "07", 62.54607, 12.5428);
case 995: return new CityInfo("Frufällan", "28", 57.78333, 12.96667);
case 996: return new CityInfo("Frövi", "15", 59.46667, 15.36667);
case 997: return new CityInfo("Frösakull", "06", 56.68333, 12.73333);
case 998: return new CityInfo("Fritsla", "28", 57.55655, 12.78457);
case 999: return new CityInfo("Fristad", "28", 57.82483, 13.01064);
case 1000: return new CityInfo("Frillesås", "06", 57.31667, 12.16667);
case 1001: return new CityInfo("Friggesund", "03", 61.89605, 16.54904);
case 1002: return new CityInfo("Fridlevstad", "02", 56.27298, 15.53415);
case 1003: return new CityInfo("Fredriksberg", "10", 60.13333, 14.38333);
case 1004: return new CityInfo("Fränsta", "24", 62.49855, 16.17016);
case 1005: return new CityInfo("Frånö", "24", 62.90843, 17.84729);
case 1006: return new CityInfo("Frändefors", "28", 58.5, 12.28333);
case 1007: return new CityInfo("Fotö", "28", 57.66667, 11.65833);
case 1008: return new CityInfo("Forssjö", "18", 58.95372, 16.29485);
case 1009: return new CityInfo("Förslöv", "27", 56.35, 12.81667);
case 1010: return new CityInfo("Forsheda", "08", 57.16415, 13.83016);
case 1011: return new CityInfo("Forshaga", "22", 59.52541, 13.48127);
case 1012: return new CityInfo("Forserum", "08", 57.7, 14.46667);
case 1013: return new CityInfo("Forsby", "03", 60.71667, 17.13333);
case 1014: return new CityInfo("Forsbacka", "03", 60.61667, 16.88333);
case 1015: return new CityInfo("Fors", "24", 63.41667, 18.58333);
case 1016: return new CityInfo("Fors", "10", 60.20767, 16.30787);
case 1017: return new CityInfo("Föllinge", "07", 63.66667, 14.61667);
case 1018: return new CityInfo("Flyinge", "27", 55.75373, 13.36671);
case 1019: return new CityInfo("Floda", "10", 60.5061, 14.79275);
case 1020: return new CityInfo("Floby", "28", 58.13333, 13.33333);
case 1021: return new CityInfo("Fliseryd", "09", 57.13333, 16.26667);
case 1022: return new CityInfo("Flen", "18", 59.05834, 16.58781);
case 1023: return new CityInfo("Fjugesta", "15", 59.17375, 14.87227);
case 1024: return new CityInfo("Fjärdhundra", "21", 59.77554, 16.92106);
case 1025: return new CityInfo("Fjärås kyrkby", "06", 57.45913, 12.17508);
case 1026: return new CityInfo("Fjällbacka", "28", 59.04972, 12.56667);
case 1027: return new CityInfo("Fjällbacka", "28", 58.6, 11.28333);
case 1028: return new CityInfo("Fjälkinge", "27", 56.04364, 14.27562);
case 1029: return new CityInfo("Fittja", "26", 59.24868, 17.85991);
case 1030: return new CityInfo("Finspång", "16", 58.70578, 15.76739);
case 1031: return new CityInfo("Finnerödja", "15", 58.93333, 14.43333);
case 1032: return new CityInfo("Finja", "27", 56.16667, 13.68333);
case 1033: return new CityInfo("Filsbäck", "28", 58.492, 13.247);
case 1034: return new CityInfo("Filipstad", "22", 59.71236, 14.16831);
case 1035: return new CityInfo("Figeholm", "09", 57.36667, 16.55);
case 1036: return new CityInfo("Fellingsbro", "15", 59.43333, 15.58333);
case 1037: return new CityInfo("Fårösund", "05", 57.85822, 19.0619);
case 1038: return new CityInfo("Färnäs", "10", 61, 14.63333);
case 1039: return new CityInfo("Färlöv", "27", 56.06667, 14.08333);
case 1040: return new CityInfo("Färjestaden", "09", 56.6499, 16.46859);
case 1041: return new CityInfo("Färila", "03", 61.80011, 15.84422);
case 1042: return new CityInfo("Färgelanda", "28", 58.56816, 11.99235);
case 1043: return new CityInfo("Fanbyn", "24", 62.4074, 16.58549);
case 1044: return new CityInfo("Fanbyn", "24", 63.36667, 19.2);
case 1045: return new CityInfo("Falun", "10", 60.60357, 15.62597);
case 1046: return new CityInfo("Falköping", "28", 58.17347, 13.55068);
case 1047: return new CityInfo("Falkenberg", "06", 56.90552, 12.49118);
case 1048: return new CityInfo("Fagersta", "25", 60.00418, 15.79316);
case 1049: return new CityInfo("Fagersanna", "28", 58.46667, 14.3);
case 1050: return new CityInfo("Everöd", "27", 55.9, 14.1);
case 1051: return new CityInfo("Essvik", "24", 62.31639, 17.39306);
case 1052: return new CityInfo("Eslöv", "27", 55.83928, 13.30393);
case 1053: return new CityInfo("Eskilstuna", "18", 59.36661, 16.5077);
case 1054: return new CityInfo("Eriksberg", "26", 59.24241, 17.81631);
case 1055: return new CityInfo("Enviken", "10", 60.8, 15.78333);
case 1056: return new CityInfo("Enköping", "21", 59.63607, 17.07768);
case 1057: return new CityInfo("Enebyberg", "26", 59.43333, 18.05);
case 1058: return new CityInfo("Enbacka", "10", 60.40993, 15.59575);
case 1059: return new CityInfo("Enånger", "03", 61.54556, 17.01056);
case 1060: return new CityInfo("Emmaboda", "09", 56.63268, 15.53648);
case 1061: return new CityInfo("Ellös", "28", 58.18333, 11.46667);
case 1062: return new CityInfo("Eldsberga", "06", 56.6, 13);
case 1063: return new CityInfo("Eksjö", "08", 57.66643, 14.97205);
case 1064: return new CityInfo("Ekshärad", "22", 60.17275, 13.49647);
case 1065: return new CityInfo("Ekerö", "26", 59.291, 17.81212);
case 1066: return new CityInfo("Ekenässjön", "08", 57.49175, 15.02226);
case 1067: return new CityInfo("Ekeby-Almby", "15", 59.26, 15.33);
case 1068: return new CityInfo("Ekeby", "26", 59.25, 17.52);
case 1069: return new CityInfo("Ekängen", "16", 58.46667, 15.63333);
case 1070: return new CityInfo("Edsvalla", "22", 59.43472, 13.20887);
case 1071: return new CityInfo("Edsbyn", "03", 61.37692, 15.81747);
case 1072: return new CityInfo("Edsbro", "26", 59.89304, 18.49174);
case 1073: return new CityInfo("Edane", "22", 59.62918, 12.82564);
case 1074: return new CityInfo("Ed", "28", 58.91247, 11.93308);
case 1075: return new CityInfo("Dvärsätt", "07", 63.31667, 14.46667);
case 1076: return new CityInfo("Duved", "07", 63.4, 12.86667);
case 1077: return new CityInfo("Dösjebro", "27", 55.82098, 13.02897);
case 1078: return new CityInfo("Dorotea", "23", 64.26185, 16.41306);
case 1079: return new CityInfo("Donsö", "28", 57.6, 11.79917);
case 1080: return new CityInfo("Domsten", "27", 56.11887, 12.60688);
case 1081: return new CityInfo("Djursholm", "26", 59.39926, 18.05619);
case 1082: return new CityInfo("Djurö", "26", 59.32653, 18.71152);
case 1083: return new CityInfo("Djurmo", "10", 60.55027, 15.18362);
case 1084: return new CityInfo("Djurås", "10", 60.56061, 15.13281);
case 1085: return new CityInfo("Diseröd", "28", 57.92636, 12.02598);
case 1086: return new CityInfo("Diö", "12", 56.63333, 14.21667);
case 1087: return new CityInfo("Dingtuna", "25", 59.57279, 16.38722);
case 1088: return new CityInfo("Dingle", "28", 58.5275, 11.5777);
case 1089: return new CityInfo("Dingersjö", "24", 62.27467, 17.37994);
case 1090: return new CityInfo("Delsbo", "03", 61.80104, 16.55571);
case 1091: return new CityInfo("Deje", "22", 59.603, 13.472);
case 1092: return new CityInfo("Degerfors", "15", 59.23797, 14.43077);
case 1093: return new CityInfo("Degeberga", "27", 55.83333, 14.08333);
case 1094: return new CityInfo("Dalstorp", "28", 57.60405, 13.52317);
case 1095: return new CityInfo("Dals Rostock", "28", 58.71667, 12.35);
case 1096: return new CityInfo("Dals Långed", "28", 58.92555, 12.30865);
case 1097: return new CityInfo("Dalsjöfors", "28", 57.71667, 13.08333);
case 1098: return new CityInfo("Dalby", "27", 55.66655, 13.34976);
case 1099: return new CityInfo("Dalarö", "26", 59.13306, 18.40639);
case 1100: return new CityInfo("Charlottenberg", "22", 59.88422, 12.30398);
case 1101: return new CityInfo("Burseryd", "08", 57.36667, 14.78333);
case 1102: return new CityInfo("Burseryd", "08", 57.2, 13.28333);
case 1103: return new CityInfo("Bunkeflostrand", "27", 55.54478, 12.92375);
case 1104: return new CityInfo("Bua", "06", 57.2378, 12.12187);
case 1105: return new CityInfo("Brunna", "10", 60.26255, 16.01034);
case 1106: return new CityInfo("Brunna", "26", 59.51667, 17.75);
case 1107: return new CityInfo("Brunn", "26", 59.28, 18.43);
case 1108: return new CityInfo("Brunflo", "07", 63.07586, 14.83203);
case 1109: return new CityInfo("Brösarp", "27", 55.72442, 14.10254);
case 1110: return new CityInfo("Bromölla", "27", 56.07551, 14.46958);
case 1111: return new CityInfo("Bromma", "26", 59.34, 17.94);
case 1112: return new CityInfo("Broby", "27", 56.25521, 14.07797);
case 1113: return new CityInfo("Bro", "26", 59.51667, 17.63333);
case 1114: return new CityInfo("Brevik", "26", 59.35, 18.2);
case 1115: return new CityInfo("Brevik", "26", 59.21667, 18.38333);
case 1116: return new CityInfo("Bredsand", "21", 59.58333, 17.06667);
case 1117: return new CityInfo("Bredbyn", "24", 63.44655, 18.11019);
case 1118: return new CityInfo("Bredaryd", "08", 57.17343, 13.73789);
case 1119: return new CityInfo("Brastad", "28", 58.38333, 11.48333);
case 1120: return new CityInfo("Brännö", "28", 57.64528, 11.78167);
case 1121: return new CityInfo("Brålanda", "28", 58.56344, 12.34923);
case 1122: return new CityInfo("Bräkne-Hoby", "02", 56.23333, 15.11667);
case 1123: return new CityInfo("Bräcke", "07", 62.75067, 15.42193);
case 1124: return new CityInfo("Braås", "12", 57.06667, 15.05);
case 1125: return new CityInfo("Boxholm", "16", 58.19719, 15.05376);
case 1126: return new CityInfo("Bottnaryd", "08", 57.77186, 13.82631);
case 1127: return new CityInfo("Borrby", "27", 55.45707, 14.18041);
case 1128: return new CityInfo("Borlänge", "10", 60.4858, 15.43714);
case 1129: return new CityInfo("Borgholm", "09", 56.8793, 16.65634);
case 1130: return new CityInfo("Borensberg", "16", 58.56667, 15.28333);
case 1131: return new CityInfo("Borås", "28", 57.72101, 12.9401);
case 1132: return new CityInfo("Bor", "08", 57.11667, 14.16667);
case 1133: return new CityInfo("Bönan", "03", 60.73962, 17.31239);
case 1134: return new CityInfo("Bollstabruk", "24", 62.99777, 17.67348);
case 1135: return new CityInfo("Bollnäs", "03", 61.34817, 16.39464);
case 1136: return new CityInfo("Bollmora", "26", 59.24196, 18.22762);
case 1137: return new CityInfo("Bollebygd", "28", 57.66866, 12.57272);
case 1138: return new CityInfo("Bodafors", "08", 57.5, 14.7);
case 1139: return new CityInfo("Boda", "10", 61.01667, 15.21667);
case 1140: return new CityInfo("Boo", "26", 59.33333, 18.28333);
case 1141: return new CityInfo("Blomstermåla", "09", 56.98333, 16.33333);
case 1142: return new CityInfo("Blidsberg", "28", 57.93333, 13.48333);
case 1143: return new CityInfo("Blentarp", "27", 55.58333, 13.6);
case 1144: return new CityInfo("Bjuv", "27", 56.08372, 12.91914);
case 1145: return new CityInfo("Bjursås", "10", 60.73726, 15.45291);
case 1146: return new CityInfo("Bjurholm", "23", 63.93027, 19.21369);
case 1147: return new CityInfo("Björnlunda", "18", 59.06465, 17.15931);
case 1148: return new CityInfo("Björneborg", "22", 59.24122, 14.24942);
case 1149: return new CityInfo("Björnås", "27", 56.12487, 12.96502);
case 1150: return new CityInfo("Björnänge", "07", 63.38333, 13.13333);
case 1151: return new CityInfo("Björlanda", "28", 57.76667, 11.83333);
case 1152: return new CityInfo("Björkvik", "23", 65.5, 15.56667);
case 1153: return new CityInfo("Björkö", "28", 57.73221, 11.67916);
case 1154: return new CityInfo("Björketorp", "28", 57.4264, 12.52523);
case 1155: return new CityInfo("Björke", "03", 60.76667, 17.2);
case 1156: return new CityInfo("Björboholm", "28", 57.87096, 12.32546);
case 1157: return new CityInfo("Björbo", "10", 60.45935, 14.71598);
case 1158: return new CityInfo("Bjästa", "24", 63.2, 18.5);
case 1159: return new CityInfo("Bjärred", "27", 55.71667, 13.01667);
case 1160: return new CityInfo("Bjärnum", "27", 56.29032, 13.71128);
case 1161: return new CityInfo("Billingsfors", "28", 58.98333, 12.25);
case 1162: return new CityInfo("Billesholm", "27", 56.05, 13);
case 1163: return new CityInfo("Billeberga", "27", 55.88333, 13);
case 1164: return new CityInfo("Billdal", "28", 57.56667, 11.93333);
case 1165: return new CityInfo("Bie", "18", 59.08883, 16.20978);
case 1166: return new CityInfo("Bestorp", "16", 58.23333, 15.73333);
case 1167: return new CityInfo("Bergvik", "03", 61.25349, 16.82749);
case 1168: return new CityInfo("Bergsjö", "03", 61.98253, 17.06368);
case 1169: return new CityInfo("Bergshamra", "26", 59.38083, 18.03427);
case 1170: return new CityInfo("Bergshamra", "26", 59.63472, 18.62806);
case 1171: return new CityInfo("Bergshammar", "18", 58.7405, 16.91284);
case 1172: return new CityInfo("Hoverberg", "07", 62.81381, 14.44735);
case 1173: return new CityInfo("Bergkvara", "09", 56.39063, 16.07274);
case 1174: return new CityInfo("Bergeforsen", "24", 62.53074, 17.38123);
case 1175: return new CityInfo("Bergby", "03", 60.92931, 17.04194);
case 1176: return new CityInfo("Berga", "09", 57.21667, 16.03333);
case 1177: return new CityInfo("Berg", "16", 58.48831, 15.52969);
case 1178: return new CityInfo("Bengtsheden", "10", 60.71183, 15.87313);
case 1179: return new CityInfo("Bengtsfors", "28", 59.02912, 12.23207);
case 1180: return new CityInfo("Båstad", "27", 56.42689, 12.85339);
case 1181: return new CityInfo("Bäsna", "10", 60.53333, 15.2);
case 1182: return new CityInfo("Bårslöv", "27", 56.0091, 12.8058);
case 1183: return new CityInfo("Barsebäck", "27", 55.76667, 12.95);
case 1184: return new CityInfo("Barnarp", "08", 57.704, 14.178);
case 1185: return new CityInfo("Barkarö", "25", 59.54935, 16.5074);
case 1186: return new CityInfo("Bara", "18", 58.68333, 17.06667);
case 1187: return new CityInfo("Bara", "27", 55.58155, 13.17862);
case 1188: return new CityInfo("Bankeryd", "08", 57.86021, 14.124);
case 1189: return new CityInfo("Bålsta", "21", 59.5671, 17.52781);
case 1190: return new CityInfo("Bälinge", "21", 59.95, 17.53333);
case 1191: return new CityInfo("Baggetorp", "15", 59.15, 14.63333);
case 1192: return new CityInfo("Bäckefors", "28", 58.8049, 12.16202);
case 1193: return new CityInfo("Backe", "07", 63.81667, 16.4);
case 1194: return new CityInfo("Backa", "10", 60.92286, 15.10016);
case 1195: return new CityInfo("Axvall", "28", 58.38333, 13.56667);
case 1196: return new CityInfo("Avesta", "10", 60.14274, 16.16295);
case 1197: return new CityInfo("Åtvidaberg", "16", 58.20152, 15.9977);
case 1198: return new CityInfo("Åstorp", "27", 56.13566, 12.9443);
case 1199: return new CityInfo("Asmundtorp", "27", 55.88333, 12.93333);
case 1200: return new CityInfo("Åsljunga", "27", 56.31667, 13.36667);
case 1201: return new CityInfo("Askersund", "15", 58.87988, 14.9023);
case 1202: return new CityInfo("Askeby", "16", 58.40772, 15.84852);
case 1203: return new CityInfo("Åshammar", "03", 60.63712, 16.56036);
case 1204: return new CityInfo("Åsensbruk", "28", 58.79878, 12.42194);
case 1205: return new CityInfo("Åsele", "23", 64.16026, 17.34762);
case 1206: return new CityInfo("Åseda", "12", 57.1701, 15.3443);
case 1207: return new CityInfo("Åsbro", "15", 59, 15.05);
case 1208: return new CityInfo("Åsarp", "28", 58.02397, 13.5651);
case 1209: return new CityInfo("Åsa", "06", 57.35, 12.11667);
case 1210: return new CityInfo("Ås", "24", 63.36667, 16.58333);
case 1211: return new CityInfo("Ås", "07", 63.25, 14.56667);
case 1212: return new CityInfo("Åryd", "12", 56.82762, 14.97937);
case 1213: return new CityInfo("Arvika", "22", 59.65528, 12.58518);
case 1214: return new CityInfo("Arvidsjaur", "14", 65.59033, 19.16682);
case 1215: return new CityInfo("Årsunda", "03", 60.51644, 16.73436);
case 1216: return new CityInfo("Årsta", "26", 59.2978, 18.0514);
case 1217: return new CityInfo("Aröd", "28", 57.96841, 11.78487);
case 1218: return new CityInfo("Arnö", "26", 60.11667, 18.63333);
case 1219: return new CityInfo("Arnö", "18", 58.72675, 17.02322);
case 1220: return new CityInfo("Årnäs", "06", 57.20627, 12.21293);
case 1221: return new CityInfo("Arlöv", "27", 55.63248, 13.07141);
case 1222: return new CityInfo("Ärla", "18", 59.27983, 16.67896);
case 1223: return new CityInfo("Arkelstorp", "27", 56.2, 13.81667);
case 1224: return new CityInfo("Arkelstorp", "27", 56.16989, 14.29082);
case 1225: return new CityInfo("Arjeplog", "14", 66.05173, 17.88606);
case 1226: return new CityInfo("Årjäng", "22", 59.39217, 12.13336);
case 1227: return new CityInfo("Arild", "27", 56.275, 12.575);
case 1228: return new CityInfo("Ardala", "28", 58.36134, 13.33648);
case 1229: return new CityInfo("Arbrå", "03", 61.46667, 16.38333);
case 1230: return new CityInfo("Arboga", "25", 59.39387, 15.83882);
case 1231: return new CityInfo("Annelund", "25", 60, 16.03333);
case 1232: return new CityInfo("Annelund", "28", 57.98843, 13.07483);
case 1233: return new CityInfo("Ankarsvik", "24", 62.37028, 17.41167);
case 1234: return new CityInfo("Ankarsrum", "09", 57.69896, 16.33407);
case 1235: return new CityInfo("Angered", "28", 57.78628, 12.09852);
case 1236: return new CityInfo("Ängelholm", "27", 56.2428, 12.86219);
case 1237: return new CityInfo("Ånge", "24", 62.52495, 15.65904);
case 1238: return new CityInfo("Aneby", "08", 57.83895, 14.81016);
case 1239: return new CityInfo("Anderstorp", "28", 58.88333, 14.28333);
case 1240: return new CityInfo("Anderstorp", "08", 57.28333, 13.63333);
case 1241: return new CityInfo("Anderslöv", "27", 55.43836, 13.31966);
case 1242: return new CityInfo("Åmotfors", "22", 59.76191, 12.36211);
case 1243: return new CityInfo("Åmål", "28", 59.051, 12.70492);
case 1244: return new CityInfo("Älvnäs", "26", 59.28333, 17.76667);
case 1245: return new CityInfo("Älvkarleby", "21", 60.57081, 17.44895);
case 1246: return new CityInfo("Alvik", "26", 59.33188, 17.98325);
case 1247: return new CityInfo("Alvesta", "12", 56.89935, 14.55559);
case 1248: return new CityInfo("Älvdalen", "10", 61.22774, 14.03935);
case 1249: return new CityInfo("Älvängen", "28", 57.95872, 12.1235);
case 1250: return new CityInfo("Alunda", "21", 60.06667, 18.08333);
case 1251: return new CityInfo("Älta", "26", 59.26667, 18.18333);
case 1252: return new CityInfo("Alstermo", "12", 56.97303, 15.65413);
case 1253: return new CityInfo("Alster", "22", 59.39853, 13.61369);
case 1254: return new CityInfo("Alsike", "21", 59.75324, 17.77331);
case 1255: return new CityInfo("Almunge", "21", 59.88333, 18.05);
case 1256: return new CityInfo("Älmsta", "26", 59.96667, 18.8);
case 1257: return new CityInfo("Älmhult", "12", 56.55146, 14.13827);
case 1258: return new CityInfo("Allerum", "27", 56.12009, 12.69406);
case 1259: return new CityInfo("Alingsås", "28", 57.93033, 12.53345);
case 1260: return new CityInfo("Algutsrum", "09", 56.68299, 16.52722);
case 1261: return new CityInfo("Alfta", "03", 61.34675, 16.07499);
case 1262: return new CityInfo("Ålem", "09", 56.95, 16.38333);
case 1263: return new CityInfo("Åled", "06", 56.75, 12.93333);
case 1264: return new CityInfo("Älandsbro", "24", 62.67714, 17.8406);
case 1265: return new CityInfo("Alafors", "28", 57.92579, 12.07835);
case 1266: return new CityInfo("Åkers Styckebruk", "18", 59.25, 17.08333);
case 1267: return new CityInfo("Åkersberga", "26", 59.47944, 18.29967);
case 1268: return new CityInfo("Åkarp", "28", 58.23333, 13.65);
case 1269: return new CityInfo("Åkarp", "27", 55.65396, 13.11107);
case 1270: return new CityInfo("Åhus", "27", 55.91667, 14.28333);
case 1271: return new CityInfo("Åbytorp", "15", 59.12559, 15.07363);
case 1272: return new CityInfo("Åbyggeby", "03", 60.91667, 16.65);
case 1273: return new CityInfo("Åbyggeby", "03", 60.73333, 17.11667);
case 1274: return new CityInfo("Åby", "16", 58.66667, 16.18333);
case 1275: return new CityInfo("Abborrberget", "10", 60.15, 14.8);
case 1276: return new CityInfo("Abbekås", "27", 55.4, 13.6);
case 1277: return new CityInfo("Kurland", "27", 55.375, 13.08333);
case 1278: return new CityInfo("Skepparkroken", "27", 56.29167, 12.8);
case 1279: return new CityInfo("Västra Hagen", "06", 57.42444, 11.93583);
case 1280: return new CityInfo("Grevie", "27", 56.39167, 12.78333);
case 1281: return new CityInfo("Enhagen-Ekbacken", "25", 59.56543, 16.53045);
case 1282: return new CityInfo("Skavkulla", "02", 56.18333, 15.51667);
case 1283: return new CityInfo("Gessie Villastad", "27", 55.5, 12.95833);
case 1284: return new CityInfo("Sandskogen", "27", 55.758, 12.98333);
case 1285: return new CityInfo("Saxtorpsskogen", "27", 55.83208, 12.94429);
case 1286: return new CityInfo("Andalen", "28", 57.70039, 11.76136);
case 1287: return new CityInfo("Nolvik", "28", 57.775, 11.83333);
case 1288: return new CityInfo("Ammenäs", "28", 58.31361, 11.8273);
case 1289: return new CityInfo("Vi", "24", 62.43333, 17.41667);
case 1290: return new CityInfo("Fisksätra", "26", 59.29153, 18.2549);
case 1291: return new CityInfo("Ekeby", "27", 56, 12.96667);
case 1292: return new CityInfo("Skanör med Falsterbo", "27", 55.4, 12.85);
case 1293: return new CityInfo("Ingared", "28", 57.85989, 12.45161);
case 1294: return new CityInfo("Dalum", "28", 57.89852, 13.4646);
case 1295: return new CityInfo("Majorna", "28", 57.69195, 11.91605);
case 1296: return new CityInfo("Onsala", "06", 57.42531, 12.02903);
case 1297: return new CityInfo("Tomtebo", "23", 63.80433, 20.36955);
case 1298: return new CityInfo("Olstorp", "28", 57.82277, 12.27696);
case 1299: return new CityInfo("Kläppa", "06", 57.35989, 12.15801);
case 1300: return new CityInfo("Sylta", "26", 59.48014, 17.71631);
case 1301: return new CityInfo("Strömsfors", "16", 58.68, 16.33);
case 1302: return new CityInfo("Akalla", "26", 59.41465, 17.91398);
case 1303: return new CityInfo("Tensta", "26", 59.3939, 17.90111);
case 1304: return new CityInfo("Björkskatan", "14", 65.61373, 22.17702);
case 1305: return new CityInfo("Alby", "26", 59.2335, 17.8538);
case 1306: return new CityInfo("Hammarkullen", "28", 57.78049, 12.03604);
case 1307: return new CityInfo("Rannebergen", "28", 57.80236, 12.07131);
case 1308: return new CityInfo("Eriksbo", "28", 57.77141, 12.04183);
case 1309: return new CityInfo("Gårdsten", "28", 57.8048, 12.02883);
case 1310: return new CityInfo("Lövgärdet", "28", 57.81555, 12.03861);
case 1311: return new CityInfo("Tofta", "05", 57.48984, 18.13429);
case 1312: return new CityInfo("Åre", "07", 63.39911, 13.07995);
case 1313: return new CityInfo("Marielund", "18", 59.25101, 17.18215);
default: return new CityInfo("Marielund", "14", 65.85307, 24.10486);

                                    }                                        
                                }
                            
                        }
                    }
                