
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
                                    public const string Country = "CI";
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
                            
                                        var cur = (Math.Abs(7.43027 - lat) + Math.Abs(-6.05054 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(6.76229 - lat) + Math.Abs(-6.8638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91937 - lat) + Math.Abs(-8.2065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.82055 - lat) + Math.Abs(-5.27674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.18174 - lat) + Math.Abs(-3.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2379 - lat) + Math.Abs(-7.86638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.38194 - lat) + Math.Abs(-6.47778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55004 - lat) + Math.Abs(-3.01431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55799 - lat) + Math.Abs(-5.01769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.57395 - lat) + Math.Abs(-8.42592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.57974 - lat) + Math.Abs(-8.41091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28333 - lat) + Math.Abs(-7.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48115 - lat) + Math.Abs(-6.40694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.15772 - lat) + Math.Abs(-5.2248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89839 - lat) + Math.Abs(-4.82293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.60542 - lat) + Math.Abs(-3.65804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.80335 - lat) + Math.Abs(-3.16832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87366 - lat) + Math.Abs(-7.45519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.42295 - lat) + Math.Abs(-7.3528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8645 - lat) + Math.Abs(-8.10143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62103 - lat) + Math.Abs(-5.91144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5841 - lat) + Math.Abs(-5.38476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66829 - lat) + Math.Abs(-4.57371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35694 - lat) + Math.Abs(-7.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95384 - lat) + Math.Abs(-6.08531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74851 - lat) + Math.Abs(-6.6363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95376 - lat) + Math.Abs(-3.58012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81952 - lat) + Math.Abs(-7.56085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45462 - lat) + Math.Abs(-5.29263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64705 - lat) + Math.Abs(-3.99626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38309 - lat) + Math.Abs(-5.41759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96837 - lat) + Math.Abs(-5.14882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.50511 - lat) + Math.Abs(-7.56433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65759 - lat) + Math.Abs(-5.29109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45275 - lat) + Math.Abs(-3.47152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00244 - lat) + Math.Abs(-5.90037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.47197 - lat) + Math.Abs(-4.35781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45728 - lat) + Math.Abs(-4.33993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05861 - lat) + Math.Abs(-6.18972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99744 - lat) + Math.Abs(-7.83593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.41251 - lat) + Math.Abs(-7.55383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4151 - lat) + Math.Abs(-3.03006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61083 - lat) + Math.Abs(-6.94215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.84752 - lat) + Math.Abs(-5.682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89029 - lat) + Math.Abs(-6.40921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79089 - lat) + Math.Abs(-5.83477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.48764 - lat) + Math.Abs(-3.25249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.25597 - lat) + Math.Abs(-7.23508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55505 - lat) + Math.Abs(-7.46348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45803 - lat) + Math.Abs(-5.62961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14943 - lat) + Math.Abs(-4.60982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34141 - lat) + Math.Abs(-4.67709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13728 - lat) + Math.Abs(-5.10095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81471 - lat) + Math.Abs(-7.5125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47807 - lat) + Math.Abs(-6.60509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.20515 - lat) + Math.Abs(-4.4146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49224 - lat) + Math.Abs(-6.58558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51952 - lat) + Math.Abs(-5.24038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.54368 - lat) + Math.Abs(-7.4935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.23869 - lat) + Math.Abs(-6.17147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6882 - lat) + Math.Abs(-6.0712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.25068 - lat) + Math.Abs(-5.00333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.2118 - lat) + Math.Abs(-3.73884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.32035 - lat) + Math.Abs(-3.95235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58461 - lat) + Math.Abs(-8.13183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13193 - lat) + Math.Abs(-5.9506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08226 - lat) + Math.Abs(-5.56938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5928 - lat) + Math.Abs(-5.19449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.3883 - lat) + Math.Abs(-7.37644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94333 - lat) + Math.Abs(-6.2549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.74202 - lat) + Math.Abs(-7.34918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.83739 - lat) + Math.Abs(-5.35723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.64678 - lat) + Math.Abs(-4.70519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.06757 - lat) + Math.Abs(-5.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48389 - lat) + Math.Abs(-5.11553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.12866 - lat) + Math.Abs(-4.89804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.0591 - lat) + Math.Abs(-3.9631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.25957 - lat) + Math.Abs(-8.15498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.87735 - lat) + Math.Abs(-6.45022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.32556 - lat) + Math.Abs(-4.37685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36321 - lat) + Math.Abs(-4.42863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.27534 - lat) + Math.Abs(-6.99704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52167 - lat) + Math.Abs(-6.48694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.26927 - lat) + Math.Abs(-2.9951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.69385 - lat) + Math.Abs(-5.03031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99041 - lat) + Math.Abs(-5.7442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85249 - lat) + Math.Abs(-5.31063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.27247 - lat) + Math.Abs(-3.59625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.65175 - lat) + Math.Abs(-4.20406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0402 - lat) + Math.Abs(-2.80003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06264 - lat) + Math.Abs(-4.49948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.56913 - lat) + Math.Abs(-8.00253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35581 - lat) + Math.Abs(-3.88537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73909 - lat) + Math.Abs(-7.61377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.07568 - lat) + Math.Abs(-3.40846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.67395 - lat) + Math.Abs(-5.58085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.01232 - lat) + Math.Abs(-7.48639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.62984 - lat) + Math.Abs(-4.08204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6052 - lat) + Math.Abs(-3.15709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.77402 - lat) + Math.Abs(-5.11411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67342 - lat) + Math.Abs(-3.96938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.49462 - lat) + Math.Abs(-4.05183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.5004 - lat) + Math.Abs(-3.66308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38423 - lat) + Math.Abs(-3.88759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.13113 - lat) + Math.Abs(-3.20415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.92801 - lat) + Math.Abs(-4.21319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.10694 - lat) + Math.Abs(-3.86194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28634 - lat) + Math.Abs(-3.30403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46779 - lat) + Math.Abs(-3.20711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.41613 - lat) + Math.Abs(-4.0159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35444 - lat) + Math.Abs(-4.00167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.72972 - lat) + Math.Abs(-3.49639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96111 - lat) + Math.Abs(-6.67306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78377 - lat) + Math.Abs(-6.59388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.98289 - lat) + Math.Abs(-3.94393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13622 - lat) + Math.Abs(-3.02308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3196 - lat) + Math.Abs(-4.25415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1998 - lat) + Math.Abs(-5.10884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zuénoula", "96", 7.43027, -6.05054);
case 1: return new CityInfo("Zoukougbeu", "96", 6.76229, -6.8638);
case 2: return new CityInfo("Zouan-Hounien", "78", 6.91937, -8.2065);
case 3: return new CityInfo("Yamoussoukro", "81", 6.82055, -5.27674);
case 4: return new CityInfo("Yakassé-Attobrou", "82", 6.18174, -3.65111);
case 5: return new CityInfo("Ouaninou", "97", 8.2379, -7.86638);
case 6: return new CityInfo("Vavoua", "96", 7.38194, -6.47778);
case 7: return new CityInfo("Transua", "92", 7.55004, -3.01431);
case 8: return new CityInfo("Toumodi", "81", 6.55799, -5.01769);
case 9: return new CityInfo("Toulépleu Gueré", "78", 6.57395, -8.42592);
case 10: return new CityInfo("Toulépleu", "78", 6.57974, -8.41091);
case 11: return new CityInfo("Touba", "97", 8.28333, -7.68333);
case 12: return new CityInfo("Tengréla", "87", 10.48115, -6.40694);
case 13: return new CityInfo("Tiébissou", "81", 7.15772, -5.2248);
case 14: return new CityInfo("Tiassalé", "82", 5.89839, -4.82293);
case 15: return new CityInfo("Téhini", "92", 9.60542, -3.65804);
case 16: return new CityInfo("Tanda", "92", 7.80335, -3.16832);
case 17: return new CityInfo("Taï", "78", 5.87366, -7.45519);
case 18: return new CityInfo("Tabou", "76", 4.42295, -7.3528);
case 19: return new CityInfo("Sipilou", "78", 7.8645, -8.10143);
case 20: return new CityInfo("Sinfra", "92", 6.62103, -5.91144);
case 21: return new CityInfo("Sinématiali", "87", 9.5841, -5.38476);
case 22: return new CityInfo("Sikensi", "82", 5.66829, -4.57371);
case 23: return new CityInfo("Séguélon", "77", 9.35694, -7.12083);
case 24: return new CityInfo("Sassandra", "76", 4.95384, -6.08531);
case 25: return new CityInfo("San-Pédro", "76", 4.74851, -6.6363);
case 26: return new CityInfo("Sandégué", "92", 7.95376, -3.58012);
case 27: return new CityInfo("Samatiguila", "77", 9.81952, -7.56085);
case 28: return new CityInfo("Sakassou", "90", 7.45462, -5.29263);
case 29: return new CityInfo("Prikro", "81", 7.64705, -3.99626);
case 30: return new CityInfo("Oumé", "95", 6.38309, -5.41759);
case 31: return new CityInfo("Ouangolodougou", "87", 9.96837, -5.14882);
case 32: return new CityInfo("Odienné", "77", 9.50511, -7.56433);
case 33: return new CityInfo("Niakaramandougou", "90", 8.65759, -5.29109);
case 34: return new CityInfo("Nassian", "92", 8.45275, -3.47152);
case 35: return new CityInfo("M’Bengué", "87", 10.00244, -5.90037);
case 36: return new CityInfo("M’Batto", "81", 6.47197, -4.35781);
case 37: return new CityInfo("M’Bahiakro", "81", 7.45728, -4.33993);
case 38: return new CityInfo("Mankono", "97", 8.05861, -6.18972);
case 39: return new CityInfo("Minignan", "77", 9.99744, -7.83593);
case 40: return new CityInfo("Man", "78", 7.41251, -7.55383);
case 41: return new CityInfo("Maféré", "94", 5.4151, -3.03006);
case 42: return new CityInfo("Madinani", "77", 9.61083, -6.94215);
case 43: return new CityInfo("Lakota", "95", 5.84752, -5.682);
case 44: return new CityInfo("Kouto", "87", 9.89029, -6.40921);
case 45: return new CityInfo("Kounahiri", "97", 7.79089, -5.83477);
case 46: return new CityInfo("Koun-Fao", "92", 7.48764, -3.25249);
case 47: return new CityInfo("Kouibly", "78", 7.25597, -7.23508);
case 48: return new CityInfo("Koro", "97", 8.55505, -7.46348);
case 49: return new CityInfo("Korhogo", "87", 9.45803, -5.62961);
case 50: return new CityInfo("Kong", "87", 9.14943, -4.60982);
case 51: return new CityInfo("Kouassi-Kouassikro", "81", 7.34141, -4.67709);
case 52: return new CityInfo("Katiola", "90", 8.13728, -5.10095);
case 53: return new CityInfo("Kaniasso", "77", 9.81471, -7.5125);
case 54: return new CityInfo("Kani", "97", 8.47807, -6.60509);
case 55: return new CityInfo("Jacqueville", "82", 5.20515, -4.4146);
case 56: return new CityInfo("Issia", "96", 6.49224, -6.58558);
case 57: return new CityInfo("Guitry", "95", 5.51952, -5.24038);
case 58: return new CityInfo("Guiglo", "78", 6.54368, -7.4935);
case 59: return new CityInfo("Guibéroua", "95", 6.23869, -6.17147);
case 60: return new CityInfo("Guéyo", "76", 5.6882, -6.0712);
case 61: return new CityInfo("Grand-Lahou", "82", 5.25068, -5.00333);
case 62: return new CityInfo("Grand-Bassam", "94", 5.2118, -3.73884);
case 63: return new CityInfo("Affery", "82", 6.32035, -3.95235);
case 64: return new CityInfo("Gbéléban", "77", 9.58461, -8.13183);
case 65: return new CityInfo("Gagnoa", "95", 6.13193, -5.9506);
case 66: return new CityInfo("Fresco", "76", 5.08226, -5.56938);
case 67: return new CityInfo("Ferkessédougou", "87", 9.5928, -5.19449);
case 68: return new CityInfo("Facobly", "78", 7.3883, -7.37644);
case 69: return new CityInfo("Dianra", "97", 8.94333, -6.2549);
case 70: return new CityInfo("Duekoué", "78", 6.74202, -7.34918);
case 71: return new CityInfo("Divo", "95", 5.83739, -5.35723);
case 72: return new CityInfo("Dimbokro", "81", 6.64678, -4.70519);
case 73: return new CityInfo("Dikodougou", "87", 9.06757, -5.77222);
case 74: return new CityInfo("Djékanou", "81", 6.48389, -5.11553);
case 75: return new CityInfo("Didiévi", "81", 7.12866, -4.89804);
case 76: return new CityInfo("Daoukro", "81", 7.0591, -3.9631);
case 77: return new CityInfo("Danané", "78", 7.25957, -8.15498);
case 78: return new CityInfo("Daloa", "96", 6.87735, -6.45022);
case 79: return new CityInfo("Dabou", "82", 5.32556, -4.37685);
case 80: return new CityInfo("Dabakala", "90", 8.36321, -4.42863);
case 81: return new CityInfo("Buyo", "76", 6.27534, -6.99704);
case 82: return new CityInfo("Boundiali", "87", 9.52167, -6.48694);
case 83: return new CityInfo("Bouna", "92", 9.26927, -2.9951);
case 84: return new CityInfo("Bouaké", "90", 7.69385, -5.03031);
case 85: return new CityInfo("Bouaflé", "96", 6.99041, -5.7442);
case 86: return new CityInfo("Botro", "90", 7.85249, -5.31063);
case 87: return new CityInfo("Bonoua", "94", 5.27247, -3.59625);
case 88: return new CityInfo("Bongouanou", "81", 6.65175, -4.20406);
case 89: return new CityInfo("Bondoukou", "92", 8.0402, -2.80003);
case 90: return new CityInfo("Bocanda", "81", 7.06264, -4.49948);
case 91: return new CityInfo("Bloléquin", "78", 6.56913, -8.00253);
case 92: return new CityInfo("Bingerville", "93", 5.35581, -3.88537);
case 93: return new CityInfo("Biankouma", "78", 7.73909, -7.61377);
case 94: return new CityInfo("Béttié", "94", 6.07568, -3.40846);
case 95: return new CityInfo("Béoumi", "90", 7.67395, -5.58085);
case 96: return new CityInfo("Bangolo", "78", 7.01232, -7.48639);
case 97: return new CityInfo("Azaguié", "82", 5.62984, -4.08204);
case 98: return new CityInfo("Ayamé", "94", 5.6052, -3.15709);
case 99: return new CityInfo("Attiégouakro", "98", 6.77402, -5.11411);
case 100: return new CityInfo("Arrah", "81", 6.67342, -3.96938);
case 101: return new CityInfo("Anyama", "93", 5.49462, -4.05183);
case 102: return new CityInfo("Alépé", "82", 5.5004, -3.66308);
case 103: return new CityInfo("Akoupé", "82", 6.38423, -3.88759);
case 104: return new CityInfo("Agnibilékrou", "94", 7.13113, -3.20415);
case 105: return new CityInfo("Agboville", "82", 5.92801, -4.21319);
case 106: return new CityInfo("Adzopé", "82", 6.10694, -3.86194);
case 107: return new CityInfo("Adiaké", "94", 5.28634, -3.30403);
case 108: return new CityInfo("Aboisso", "94", 5.46779, -3.20711);
case 109: return new CityInfo("Abobo", "93", 5.41613, -4.0159);
case 110: return new CityInfo("Abidjan", "93", 5.35444, -4.00167);
case 111: return new CityInfo("Abengourou", "94", 6.72972, -3.49639);
case 112: return new CityInfo("Séguéla", "97", 7.96111, -6.67306);
case 113: return new CityInfo("Soubré", "76", 5.78377, -6.59388);
case 114: return new CityInfo("Agou", "82", 5.98289, -3.94393);
case 115: return new CityInfo("Tiapoum", "94", 5.13622, -3.02308);
case 116: return new CityInfo("Songon", "93", 5.3196, -4.25415);
default: return new CityInfo("Taabo", "82", 6.1998, -5.10884);

                                    }                                        
                                }
                            
                        }
                    }
                